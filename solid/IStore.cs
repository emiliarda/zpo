using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using solid;
using System.IO;

namespace solid
{
    interface IStore
    {
        bool Save(string id, string message);
        string Read(string id);
        
    }
}
