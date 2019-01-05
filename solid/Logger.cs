using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using solid;
using System.IO;

namespace solid
{
    class Logger : ILoggerStore
    {
        public virtual void Log(string type, string message)
        {
            Console.WriteLine(type + ": " + message);
        }
    }
}
