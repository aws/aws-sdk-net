using UnityEngine;
using System.Collections;
using Amazon.Runtime.Internal;
using System.Threading;

namespace Amazon.Util.Storage.Internal
{
    public class PlayerPreferenceKVStore : KVStore
    {

        public override void Clear(string key)
        {
            if (UnityInitializer.IsMainThread())
            {
                ClearHelper(key);
            }
            else
            {
                UnityRequestQueue.Instance.ExecuteOnMainThread(() =>
                {
                    ClearHelper(key);
                });
            }
        }

        public override void Put(string key, string value)
        {
            if (UnityInitializer.IsMainThread())
            {
                PutHelper(key, value);
            }
            else
            {
                AutoResetEvent asyncEvent = new AutoResetEvent(false);
                UnityRequestQueue.Instance.ExecuteOnMainThread(() =>
                {
                    PutHelper(key, value);
                    asyncEvent.Set();
                });
                asyncEvent.WaitOne();
            }
        }

        public override string Get(string key)
        {
            if (UnityInitializer.IsMainThread())
            {
                return GetHelper(key);
            }
            else
            {
                string value = string.Empty;
                AutoResetEvent asyncEvent = new AutoResetEvent(false);
                UnityRequestQueue.Instance.ExecuteOnMainThread(() =>
                {
                    value = GetHelper(key);
                    asyncEvent.Set();
                });
                asyncEvent.WaitOne();
                return value;
            }
            
        }

        #region private methods

        private void PutHelper(string key, string value)
        {
            PlayerPrefs.SetString(key, value);
            PlayerPrefs.Save();
        }

        private void ClearHelper(string key)
        {
            PlayerPrefs.DeleteKey(key);
            PlayerPrefs.Save();
        }

        private string GetHelper(string key)
        {
            string value = string.Empty;
            if (PlayerPrefs.HasKey(key))
                value = PlayerPrefs.GetString(key);

            return value;
        }
        #endregion
    }
}
