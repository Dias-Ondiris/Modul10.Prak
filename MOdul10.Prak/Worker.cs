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
            else if (!house.Door.IsCompleted)
            {
                house.Door.Build();
                Console.WriteLine($"{Name} установил дверь.");
            }
            else if (house.Windows.Count < 4)
            {
                var window = new Window();
                window.Build();
                house.Windows.Add(window);
                Console.WriteLine($"{Name} установил окно. Всего окон: {house.Windows.Count}");
            }
            else if (!house.Roof.IsCompleted)
            {
                house.Roof.Build();
                Console.WriteLine($"{Name} построил крышу.");
            }
        }

        public string GetWorkStatus()
        {
            return $"{Name} выполняет работу.";
        }
    }
}
