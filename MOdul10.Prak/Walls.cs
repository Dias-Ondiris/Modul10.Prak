using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOdul10.Prak
{
    public class Walls:IPart
    {
        public bool IsCompleted { get; private set; }

        public Walls()
        {
            IsCompleted = false;
        }

        public void Build()
        {
            Console.WriteLine("Строительство стены завершено.");
            IsCompleted = true;
        }
    }
}
