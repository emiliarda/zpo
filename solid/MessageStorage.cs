using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using solid;
using System.IO;

namespace solid
{
    class MessageStorage
    {
        private FileStorage fileStorage;
        private FileStorage saveOrReadStorage;
        private Cache cache;
        private Logger logger;

        private DirectoryInfo directoryInfo;

        public MessageStorage(DirectoryInfo di)
        {
            this.directoryInfo = di;
        }
        public virtual IFileLocator _filestorage
        {
            get { return fileStorage = new FileStorage(directoryInfo); }
        }

        public virtual ICacheStore _cache
        {
            get { return cache = new Cache(); }
        }
        public virtual ILoggerStore _logger
        {
            get { return logger= new Logger(); }
        }
        public virtual IStore _saveOrReadStorage
        {
            get { return saveOrReadStorage = new FileStorage(directoryInfo); }
        }
    }
}
