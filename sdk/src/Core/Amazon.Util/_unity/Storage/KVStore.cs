using System;
namespace Amazon.Util.Storage
{
    public abstract class KVStore
    {
        public abstract void Clear(string key);
        public abstract void Put(string key, string value);
        public abstract string Get(string key);
    }
}

