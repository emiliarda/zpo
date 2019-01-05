using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using solid;

namespace solid
{
    interface ILoggerStore
    {
        void Log(string type, string message);
    }
}
