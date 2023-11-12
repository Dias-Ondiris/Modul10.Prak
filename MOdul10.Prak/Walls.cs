using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOdul10.Prak
{
    public class Wall : IPart
    {
        public bool IsCompleted { get; private set; }

        public Wall()
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
