using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOdul10.Prak
{
    public class House
    {
        public Basement Basement { get; set; }
        public List<Wall> Walls { get; set; }
        public Door Door { get; set; }
        public List<Window> Windows { get; set; }
        public Roof Roof { get; set; }

        public House()
        {
            Basement = new Basement();
            Walls = new List<Wall>();
            Door = new Door();
            Windows = new List<Window>();
            Roof = new Roof();
        }
        public bool IsCompleted()
        {
            return Basement.IsCompleted && Walls.Count == 4 && Door.IsCompleted &&
                   Windows.Count == 4 && Roof.IsCompleted;
        }


        public void ShowBuildingStatus()
        {
            Console.WriteLine($"Фундамент: {(Basement.IsCompleted ? "Построен" : "Не построен")}");
            Console.WriteLine($"Стены: {Walls.Count}/4");
            Console.WriteLine($"Дверь: {(Door.IsCompleted ? "Установлена" : "Не установлена")}");
            Console.WriteLine($"Окна: {Windows.Count}/4");
            Console.WriteLine($"Крыша: {(Roof.IsCompleted ? "Построена" : "Не построена")}");
        }
    }
}
