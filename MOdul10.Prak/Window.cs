using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOdul10.Prak
{
    public class Window:IPart
    {
        public bool IsCompleted { get; private set; }

        public Window()
        {
            IsCompleted = false;
        }

        public void Build()
        {
            Console.WriteLine("Строительство окна завершено.");
            IsCompleted = true;
        }
    }
}
