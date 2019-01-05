using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using solid;
using System.IO;

namespace solid
{
    interface ICacheStore
    {
        bool AddOrUpdate(string id, string message);
        string GetOrAdd(string id, FileInfo file);
    }
}
