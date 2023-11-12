using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOdul10.Prak
{
    public class Roof:IPart
    {
        public bool IsCompleted { get; private set; }

        public Roof()
        {
            IsCompleted = false;
        }

        public void Build()
        {
            Console.WriteLine("Строительство крыши завершено.");
            IsCompleted = true;
        }
    }
}
