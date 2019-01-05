using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using solid;
using System.IO;

namespace solid
{
    class Cache : ICacheStore
    {
        private readonly Dictionary<string, string> cache;

        public Cache()
        {
            this.cache = new Dictionary<string, string>();
        }
        public virtual bool AddOrUpdate(string path, string message)
        {
            if (cache.ContainsKey(path))
            {
                cache[path] = message;
            }
            else
            {
                cache.Add(path, message);
            }
            return true;
        }

        public virtual string GetOrAdd(string path, FileInfo file)
        {
            if (!cache.ContainsKey(path))
            {
                cache.Add(path, File.ReadAllText(file.FullName));
            }

            string message = cache[path];
            return message;
        }
    }
}
