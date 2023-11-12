using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOdul10.Prak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание дома
            House house = new House();

            // Создание рабочих
            List<IWorker> workers = new List<IWorker>
    {
        new Worker("Аймурат"),
        new Worker("Олжас"),
        new Worker("Ислам"),
        new Worker("Тамер")
    };

            // Создание бригадира
            TeamLeader teamLeader = new TeamLeader("Диас");

            // Создание команды строителей
            Team team = new Team(workers, teamLeader);

            // Меню выбора для пользователя
            while (!house.IsCompleted())
            {
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1 - Строители построели следующую часть дома");
                Console.WriteLine("2 - Показать статус строительства");
                Console.WriteLine("3 - Выйти из программы");
                Console.Write("Введите номер действия: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        team.BuildHouse(house);
                        break;
                    case "2":
                        house.ShowBuildingStatus();
                        break;
                    case "3":
                        Console.WriteLine("Выход из программы.");
                        return;
                    default:
                        Console.WriteLine("Неверный ввод. Пожалуйста, выберите действие от 1 до 3.");
                        break;
                }
            }

            Console.WriteLine("Строительство дома завершено!");
            try
            {
                string imagePath = @"https://na-dache.pro/uploads/posts/2022-03/1647712508_35-na-dache-pro-p-trekhetazhnii-osobnyak-v-klassicheskom-sti-35.jpg";
                System.Diagnostics.Process.Start(imagePath);
            }
            catch (System.ComponentModel.Win32Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}. Пожалуйста, проверьте путь к файлу.");
            }
            Console.ReadKey();
        }
    }
}
