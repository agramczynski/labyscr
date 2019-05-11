using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazon
{
    interface IRunnable
    {
        bool HasFinished { get; set; }
        void Run();
    }
}
