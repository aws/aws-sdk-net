/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using UnityEngine;
using System.Collections;
using Amazon.Runtime.Internal;
using System.Threading;

namespace Amazon.Util.Storage.Internal
{
    /// <summary>
    /// A Storage class which implement Key Value Store
    /// </summary>
    public class PlayerPreferenceKVStore : KVStore
    {
        /// <summary>
        /// Clears the value identified by key
        /// </summary>
        /// <param name="key">Identifier</param>
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

        /// <summary>
        /// Puts the value identifying it by a key
        /// </summary>
        /// <param name="key">identifier</param>
        /// <param name="value">value to be stored</param>
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

        /// <summary>
        /// Gets the value identified by key
        /// </summary>
        /// <param name="key">Identifier</param>
        /// <returns>Value for the identifier</returns>
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
