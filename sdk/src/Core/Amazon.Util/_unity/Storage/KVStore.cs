using System;
namespace Amazon.Util.Storage
{
    public abstract class KVStore
    {
        /// <summary>
        /// Clears the value identified by key
        /// </summary>
        /// <param name="key">Identifier</param>
        public abstract void Clear(string key);

        /// <summary>
        /// Puts the value identifying it by a key
        /// </summary>
        /// <param name="key">identifier</param>
        /// <param name="value">value to be stored</param>
        public abstract void Put(string key, string value);

        /// <summary>
        /// Gets the value identified by key
        /// </summary>
        /// <param name="key">Identifier</param>
        /// <returns>Value for the identifier</returns>
        public abstract string Get(string key);
    }
}

