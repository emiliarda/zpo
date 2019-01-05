using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid
{
    class SqlStore : IStore
    {

        public string Read(string id)
        {
            return "Wczytano";
        }

        public bool Save(string id, string message)
        {
            return true;
        }
    }
}
