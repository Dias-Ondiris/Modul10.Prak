using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOdul10.Prak
{
    public interface IPart
    {
        bool IsCompleted { get; }

        void Build();
    }
}
