/*
 * Copyright 2016 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.Runtime;
using Amazon.Runtime.Internal.Settings;
using Amazon.Runtime.Internal.Util;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Amazon.Util
{
    /// <summary>
    /// Manager to access an SDK encrypted store file.
    /// SDK encrypted store files are loacted under the current user's AppData\Local\AWSToolkit folder.
    /// These files are encrypted on a per user, per machine basis using the Windows Data Protection API.
    ///
    /// This class is not threadsafe.
    /// </summary>
    internal class EncryptedStoreObjectManager
    {
        /// <summary>
        /// True if the encrypted store is availble, false otherwise.
        /// </summary>
        public static bool IsAvailable
        {
            get { return UserCrypto.IsUserCryptAvailable; }
        }

        /// <summary>
        /// Construct an EncryptedStoreObjectManager.
        /// </summary>
        /// <param name="settingsType">The base filename to read/write.</param>
        public EncryptedStoreObjectManager(string settingsType)
            :this(settingsType, false)
        {
        }

        /// <summary>
        /// Construct an EncryptedStoreObjectManager.
        /// </summary>
        /// <param name="settingsType">The base filename to read/write.</param>
        /// <param name="useDisplayNameAsUniqueKey">Whether to use the display name as the unique key, or to store it as a property of the object in the store.</param>
        public EncryptedStoreObjectManager(string settingsType, bool useDisplayNameAsUniqueKey)
        {
            EnsureAvailable();
            SettingsType = settingsType;
            UseDisplayNameAsUniqueKey = useDisplayNameAsUniqueKey;
        }

        /// <summary>
        /// If true the unique key for objects in the store is the display name, if false it's an auto-generated GUID.
        /// </summary>
        public bool UseDisplayNameAsUniqueKey { get; private set; }

        /// <summary>
        /// The base filename to read/write.
        /// </summary>
        public string SettingsType { get; private set; }

        /// <summary>
        /// Register an object.  Let the uniqueKey be assigned automatically.
        /// </summary>
        /// <param name="displayName">The display name for the object.</param>
        /// <param name="properties">The property names and values for the object.</param>
        /// <returns>The unique key that was assigned to the object.</returns>
        public string RegisterObject(string displayName, Dictionary<string, string> properties)
        {
            return RegisterObject(null, displayName, properties);
        }

        /// <summary>
        /// Register an object.
        /// </summary>
        /// <param name="uniqueKey">The uniqueKey for the object, or null if one should be assigned automatically.</param>
        /// <param name="displayName">The display name for the object.</param>
        /// <param name="properties">The property names and values for the object.</param>
        /// <returns>The unique key that was assigned to the object.</returns>
        public string RegisterObject(string uniqueKey, string displayName, Dictionary<string, string> properties)
        {
            if (!string.IsNullOrEmpty(uniqueKey) && UseDisplayNameAsUniqueKey &&
                !string.Equals(displayName, uniqueKey, StringComparison.Ordinal))
            {
                throw new ArgumentException("UniqueKey cannot be specified when UseDisplayNameAsUniqueKey is set to true.");
            }

            var settings = GetSettings();
            SettingsCollection.ObjectSettings objectSettings;
            if (TryGetObjectSettings(displayName, settings, out objectSettings))
            {
                // clear it out - this is an update
                objectSettings.Clear();
            }
            else
            {
                string actualUniqueKey;
                if (UseDisplayNameAsUniqueKey)
                    actualUniqueKey = displayName;
                else if (string.IsNullOrEmpty(uniqueKey))
                    actualUniqueKey = Guid.NewGuid().ToString();
                else
                    actualUniqueKey = uniqueKey;

                objectSettings = settings.NewObjectSettings(actualUniqueKey);
            }

            foreach (var pair in properties)
            {
                objectSettings[pair.Key] = pair.Value;
            }

            // Set the display name after copying all the properties.
            // If it's a copy, the new name will overwrite the old one.
            if (!UseDisplayNameAsUniqueKey)
            {
                objectSettings[SettingsConstants.DisplayNameField] = displayName;
            }

            SaveSettings(settings);
            return objectSettings.UniqueKey;
        }

        /// <summary>
        /// Try to get an object form the store.
        /// </summary>
        /// <param name="displayName">The display name for the object.</param>
        /// <param name="properties">The property names and values for the object.</param>
        /// <returns>True if the object was found, false otherwise.</returns>
        public bool TryGetObject(string displayName, out Dictionary<string, string> properties)
        {
            string uniqueKey;
            return TryGetObject(displayName, out uniqueKey, out properties);
        }

        /// <summary>
        /// Try to get an object form the store.
        /// </summary>
        /// <param name="displayName">The display name for the object.</param>
        /// <param name="uniqueKey">The uniqueKey of the object in the store</param>
        /// <param name="properties">The property names and values for the object.</param>
        /// <returns>True if the object was found, false otherwise.</returns>
        public bool TryGetObject(string displayName, out string uniqueKey, out Dictionary<string, string> properties)
        {
            var settings = GetSettings();
            SettingsCollection.ObjectSettings objectSettings;
            properties = null;
            uniqueKey = null;
            if (TryGetObjectSettings(displayName, settings, out objectSettings))
            {
                uniqueKey = objectSettings.UniqueKey;
                properties = new Dictionary<string, string>();
                foreach (var key in objectSettings.Keys)
                {
                    properties.Add(key, objectSettings[key]);
                }
            }
            return properties != null;
        }

        /// <summary>
        /// Unregister an object from the store.
        /// </summary>
        /// <param name="displayName">The display name for the object.</param>
        public void UnregisterObject(string displayName)
        {
            var settings = GetSettings();
            SettingsCollection.ObjectSettings objectSettings = null;
            if (TryGetObjectSettings(displayName, settings, out objectSettings))
            {
                settings.Remove(objectSettings.UniqueKey);
                SaveSettings(settings);
            }
        }

        public void RenameObject(string oldDisplayName, string newDisplayName)
        {
            Dictionary<string, string> fromObject;
            Dictionary<string, string> toObject;

            if (TryGetObject(oldDisplayName, out fromObject))
            {
                if (TryGetObject(newDisplayName, out toObject))
                    throw new ArgumentException("Cannot rename object. The destination object " + newDisplayName + " already exists.");
                else
                {
                    var settings = GetSettings();
                    SettingsCollection.ObjectSettings objectSettings = null;
                    if (TryGetObjectSettings(oldDisplayName, settings, out objectSettings))
                    {
                        objectSettings[SettingsConstants.DisplayNameField] = newDisplayName;
                        SaveSettings(settings);
                    }
                }
            }
            else
                throw new ArgumentException("Cannot rename object. The source object " + oldDisplayName + " does not exist.");

        }

        public void CopyObject(string fromDisplayName, string toDisplayName)
        {
            Dictionary<string, string> fromObject;
            Dictionary<string, string> toObject;

            if (TryGetObject(fromDisplayName, out fromObject))
            {
                if (TryGetObject(toDisplayName, out toObject))
                    throw new ArgumentException("Cannot copy object. The destination object " + toDisplayName + " already exists.");
                else
                {
                    // Register the copy.  A new unique key will be automatically assigned.
                    RegisterObject(null, toDisplayName, fromObject);
                }
            }
            else
                throw new ArgumentException("Cannot copy object. The source object " + fromDisplayName + " does not exist.");
        }

        /// <summary>
        /// Get a list of the display names for the objects in the store.
        /// </summary>
        /// <returns>A list of display names.</returns>
        public List<string> ListObjectNames()
        {
            if (UseDisplayNameAsUniqueKey)
            {
                return GetSettings().Select(os => os.UniqueKey).ToList();
            }
            else
            {
                return GetSettings().Select(os => os.GetValueOrDefault(SettingsConstants.DisplayNameField, null)).ToList();
            }
        }

        private bool TryGetObjectSettings(string displayName, SettingsCollection settings, out SettingsCollection.ObjectSettings objectSettings)
        {
            if (UseDisplayNameAsUniqueKey)
            {
                objectSettings = settings.FirstOrDefault(x => string.Equals(x.UniqueKey, displayName, StringComparison.OrdinalIgnoreCase));
            }
            else
            {
                objectSettings = settings.FirstOrDefault(x => string.Equals(x[SettingsConstants.DisplayNameField], displayName, StringComparison.OrdinalIgnoreCase));
            }
            return objectSettings != null;
        }

        private SettingsCollection GetSettings()
        {
            return PersistenceManager.Instance.GetSettings(SettingsType);
        }

        private void SaveSettings(SettingsCollection settings)
        {
            PersistenceManager.Instance.SaveSettings(SettingsType, settings);
        }

        private static void EnsureAvailable()
        {
            if (!IsAvailable)
            {
                throw new AmazonClientException("The encrypted store is not available on this platform.");
            }
        }

    }
}
