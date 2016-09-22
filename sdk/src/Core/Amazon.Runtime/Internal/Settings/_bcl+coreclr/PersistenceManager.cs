﻿/*******************************************************************************
 *  Copyright 2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Threading;

using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;
using System.Globalization;


namespace Amazon.Runtime.Internal.Settings
{
    public class PersistenceManager
    {
        #region Private members

        static readonly PersistenceManager INSTANCE = new PersistenceManager();
        readonly HashSet<string> _encryptedKeys;
        readonly Dictionary<string, SettingsWatcher> _watchers = new Dictionary<string, SettingsWatcher>();

        #endregion


        #region Constructor

        private PersistenceManager()
        {
            this._encryptedKeys = new HashSet<string>
            {
                SettingsConstants.AccessKeyField,
                SettingsConstants.SecretKeyField,
                SettingsConstants.SecretKeyRepository,
                SettingsConstants.SecretKeyRepository,
                SettingsConstants.EC2InstanceUserName,
                SettingsConstants.EC2InstancePassword,
                SettingsConstants.ProxyUsernameEncrypted,
                SettingsConstants.ProxyPasswordEncrypted,
                SettingsConstants.UserIdentityField,
                SettingsConstants.RoleSession
            };
        }

        #endregion


        #region Public methods

        public static PersistenceManager Instance
        {
            get { return INSTANCE; }
        }

        public SettingsCollection GetSettings(string type)
        {
            return loadSettingsType(type);
        }

        public void SaveSettings(string type, SettingsCollection settings)
        {
            saveSettingsType(type, settings);
        }

        public string GetSetting(string key)
        {
            var sc = GetSettings(SettingsConstants.MiscSettings);
            var oc = sc[SettingsConstants.MiscSettings];
            var value = oc[key];
            return value;
        }

        public void SetSetting(string key, string value)
        {
            var sc = GetSettings(SettingsConstants.MiscSettings);
            var oc = sc[SettingsConstants.MiscSettings];
            oc[key] = value;
            SaveSettings(SettingsConstants.MiscSettings, sc);
        }

        public static string GetSettingsStoreFolder()
        {
#if BCL
            string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData) + "/AWSToolkit";
#else
            string folder = System.Environment.GetEnvironmentVariable("HOME");
            if (string.IsNullOrEmpty(folder))
                folder = System.Environment.GetEnvironmentVariable("USERPROFILE");

            folder = Path.Combine(folder, "AppData/Local/AWSToolkit");
#endif
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);
            return folder;
        }

        public SettingsWatcher Watch(string type)
        {
            SettingsWatcher sw = new SettingsWatcher(getFileFromType(type), type);
            this._watchers[type] = sw;
            return sw;
        }

        void enableWatcher(string type)
        {
            SettingsWatcher sw = null;
            if (this._watchers.TryGetValue(type, out sw))
            {
                sw.Enable = true;
            }
        }

        void disableWatcher(string type)
        {
            SettingsWatcher sw = null;
            if (this._watchers.TryGetValue(type, out sw))
            {
                sw.Enable = false;
            }
        }

        internal bool IsEncrypted(string key)
        {
            return this._encryptedKeys.Contains(key);
        }

#endregion


#region Private methods

        void saveSettingsType(string type, SettingsCollection settings)
        {
            this.disableWatcher(type);
            try
            {
                var filePath = getFileFromType(type);

                if (settings == null || settings.Count == 0)
                {
                    if (File.Exists(filePath))
                    {
                        File.Delete(filePath);
                    }

                    return;
                }

                // Cover the case where the file still has a lock on it from a previous IO access and needs time to let go.
                var retryAttempt = 0;
                while(true)
                {
                    try
                    {
                        using (var stream = File.OpenWrite(filePath))
                        using (var writer = new StreamWriter(stream))
                        {
                            settings.Persist(writer);
                            break;
                        }
                    }
                    catch (Exception)
                    {
                        if (retryAttempt < 5)
                        {
                            Thread.Sleep(1000);
                            retryAttempt++;
                        }
                        else
                            throw;
                    }
                }
            }
            finally
            {
                this.enableWatcher(type);
            }
        }

        SettingsCollection loadSettingsType(string type)
        {
            var filePath = getFileFromType(type);
            if(!File.Exists(filePath))
            {
                return new SettingsCollection();
            }

            // cover case where SDK in another process might be writing to settings file,
            // yielding IO contention exceptons
            var retryAttempt = 0;
            while (true)
            {
                try
                {
                    string content;
                    using (var stream = File.OpenRead(filePath))
                    using (var reader = new StreamReader(stream))
                    {
                        content = reader.ReadToEnd();
                    }

                    var settings = JsonMapper.ToObject<Dictionary<string, Dictionary<string, object>>>(content);

                    if (settings == null)
                        settings = new Dictionary<string, Dictionary<string, object>>();

                    decryptAnyEncryptedValues(settings);

                    return new SettingsCollection(settings);
                }
                catch
                {
                    if (retryAttempt < 5)
                    {
                        Thread.Sleep(1000);
                        retryAttempt++;
                    }
                    else
                        return new SettingsCollection(); // give up
                }
            }
        }

        void decryptAnyEncryptedValues(Dictionary<string, Dictionary<string, object>> settings)
        {
            foreach (var kvp in settings)
            {
                string settingsKey = kvp.Key;
                var objectCollection = kvp.Value;
                foreach (string key in new List<string>(objectCollection.Keys))
                {
                    if (IsEncrypted(key) || IsEncrypted(settingsKey))
                    {
                        string value = objectCollection[key] as string;
                        if (value != null)
                        {
                            try
                            {
                                objectCollection[key] = UserCrypto.Decrypt(value);
                            }
                            catch (Exception e)
                            {
                                objectCollection.Remove(key);
                                var logger = Logger.GetLogger(typeof(PersistenceManager));
                                logger.Error(e, "Exception decrypting value for key {0}/{1}", settingsKey, key);
                            }
                        }
                    }
                }
            }
        }

        private static string getFileFromType(string type)
        {
            return string.Format(CultureInfo.InvariantCulture, @"{0}\{1}.json", GetSettingsStoreFolder(), type);
        }

#endregion
    }


    public class SettingsWatcher : IDisposable
    {
#region Private members
#if BCL
        private static ICollection<FileSystemWatcher> watchers = new List<FileSystemWatcher>();
        private FileSystemWatcher watcher;
#endif
        private string type;

#endregion


#region Constructors

        private SettingsWatcher()
        {
            throw new NotSupportedException();
        }

        internal SettingsWatcher(string filePath, string type)
        {
            string dirPath = Path.GetDirectoryName(filePath);
            string fileName = Path.GetFileName(filePath);
            this.type = type;

#if BCL
            this.watcher = new FileSystemWatcher(dirPath, fileName)
            {
                EnableRaisingEvents = true
            };
            this.watcher.Changed += new FileSystemEventHandler(SettingsFileChanged);
            this.watcher.Created += new FileSystemEventHandler(SettingsFileChanged);


            watchers.Add(watcher);
#endif
        }

#endregion


#region Public methods

        public SettingsCollection GetSettings()
        {
            return PersistenceManager.Instance.GetSettings(this.type);
        }

        public bool Enable
        {
#if BCL
            get { return this.watcher.EnableRaisingEvents; }
            set { this.watcher.EnableRaisingEvents = value; }
#else
            get; set;
#endif
        }



#endregion


#region Events

        public event EventHandler SettingsChanged;

#endregion


#region IDisposable Members

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
#if BCL
                if (watcher != null)
                {
                    watchers.Remove(watcher);
                    watcher = null;
                }
#endif
            }
        }


#endregion


#region Private methods

#if BCL
        private void SettingsFileChanged(object sender, FileSystemEventArgs e)
        {
            if (SettingsChanged != null)
                SettingsChanged(this, null);
        }
#endif
#endregion
    }
}
