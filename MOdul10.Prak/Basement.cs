using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOdul10.Prak
{
    public class Basement : IPart
    {
        public bool IsCompleted { get; private set; }

        public Basement()
        {
            IsCompleted = false;
        }

        public void Build()
        {
            Console.WriteLine("Строительство фундамента завершено.");
            IsCompleted = true;
        }
    }
}
