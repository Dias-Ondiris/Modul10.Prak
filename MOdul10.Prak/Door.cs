using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOdul10.Prak
{
    public class Door : IPart
    {
        public bool IsCompleted { get; private set; }

        public Door()
        {
            IsCompleted = false;
        }

        public void Build()
        {
            Console.WriteLine("Установка двери завершена.");
            IsCompleted = true;
        }
    }
}
