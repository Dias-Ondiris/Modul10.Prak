using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOdul10.Prak
{
    public class Worker : IWorker
    {
        public string Name { get; set; }

        public Worker(string name)
        {
            Name = name;
        }

        public void Work(House house)
        {
            if (!house.Basement.IsCompleted)
            {
                house.Basement.Build();
                Console.WriteLine($"{Name} построил фундамент.");
            }
            else if (house.Walls.Count < 4)
            {
                var wall = new Wall();
                wall.Build();
                house.Walls.Add(wall);
                Console.WriteLine($"{Name} построил стену. Всего стен: {house.Walls.Count}");
            }
        }

        public string GetWorkStatus()
        {
            // Возвращает статус работы строителя.
            return $"{Name} выполняет работу.";
        }
    }
}
