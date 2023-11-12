using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOdul10.Prak
{
    public class TeamLeader : IWorker
    {
        public string Name { get; set; }

        public TeamLeader(string name)
        {
            Name = name;
        }
        public void Work(House house)
        {
            Console.WriteLine("Бригадир проверяет прогресс строительства.");
        }
        public string GetWorkStatus()
        {
            return $"{Name} готовит отчет о строительстве.";
        }
    }
}
