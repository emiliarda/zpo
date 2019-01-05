using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using solid;

namespace solid
{
    
    class FileStorage : IStore, IFileLocator
    {
        public DirectoryInfo WorkingDirectory { get; private set; }

        public FileStorage(DirectoryInfo workingDirectory)
        {
            if (workingDirectory == null)
            {
                throw new ArgumentNullException("workingDirectory");
            }

            if (!workingDirectory.Exists)
            {
                throw new ArgumentNullException("Boo", "workingDirectory");
            }

            this.WorkingDirectory = workingDirectory;
        }

        public virtual bool Save(string path, string message)
        {
            if (path != null)
            {
                var file = this.GetFileInfo(path);
                File.WriteAllText(file.FullName, message);
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual string Read(string path)
        {
            var file = this.GetFileInfo(path);
            if (!file.Exists)
            {
                return "";
            }
            string message = File.ReadAllText(file.FullName);
            return message;
        }

        public virtual FileInfo GetFileInfo(string name)
        {
            return new FileInfo(Path.Combine(WorkingDirectory.FullName, name + ".txt"));
        }
    }
}
