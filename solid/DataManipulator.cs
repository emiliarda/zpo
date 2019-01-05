using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using solid;
using System.IO;

namespace solid
{
    class DataManipulator
    {
        ILoggerStore logger;
        IFileLocator fileStorage;
        ICacheStore cacheStorage;
        IStore saveOrReadStorage;

        public DataManipulator(MessageStorage ms)
        {
            logger = ms._logger;
            fileStorage = ms._filestorage;
            cacheStorage = ms._cache;
            saveOrReadStorage = ms._saveOrReadStorage;
        }

        public virtual void Save(string path, string message)
        {
            logger.Log("INFO", $"Saving message to {path}.");
            saveOrReadStorage.Save(path, message);
            cacheStorage.AddOrUpdate(path, message);
            logger.Log("INFO", $"Saved message to {path}.");
        }
        public virtual string Read(string path)
        {
            var file = fileStorage.GetFileInfo(path);
            logger.Log("DEBUG", $"Readline message {path}.");
            string message = saveOrReadStorage.Read(path);
            if (!file.Exists)
            {
                logger.Log("DEBUG", $"No message {path} found.");
            }
            cacheStorage.AddOrUpdate(path, message);
            logger.Log("DEBUG", $"Returning message {path}.");
            return cacheStorage.GetOrAdd(path, file);
        }
    }
}
