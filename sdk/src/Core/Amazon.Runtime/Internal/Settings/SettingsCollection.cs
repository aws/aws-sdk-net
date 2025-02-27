/*******************************************************************************
 *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Amazon.Runtime.Internal.Settings
{
    public class SettingsCollection : IEnumerable<SettingsCollection.ObjectSettings>
    {
        Dictionary<string, Dictionary<string, string>> _values;
        public SettingsCollection()
        {
            this._values = new Dictionary<string, Dictionary<string, string>>();
            this.InitializedEmpty = true;
        }

        public SettingsCollection(Dictionary<string, Dictionary<string, string>> values)
        {
            this._values = values;
            this.InitializedEmpty = false;
        }

        public int Count
        {
            get { return this._values.Count; }
        }

        public bool InitializedEmpty { get; private set; }

        internal void Persist(StreamWriter writer)
        {
            var options = new JsonWriterOptions();
            options.Indented = true;
            using (var stream = new MemoryStream())
            using (var jsonWriter = new Utf8JsonWriter(stream, options))
            {
                jsonWriter.WriteStartObject();
                foreach (var key in this._values.Keys)
                {
                    ObjectSettings os = this[key];
                    jsonWriter.WritePropertyName(key);
                    os.WriteToJson(jsonWriter);
                }
                jsonWriter.WriteEndObject();
                jsonWriter.Flush();
                
                string content = Encoding.UTF8.GetString(stream.ToArray());
                writer.Write(content);
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<SettingsCollection.ObjectSettings> GetEnumerator()
        {
            foreach (var key in this._values.Keys)
            {
                ObjectSettings os = this[key];
                yield return os;
            }
        }

        public ObjectSettings this[string key]
        {
            get 
            {
                Dictionary<string, string> values;
                if (!this._values.TryGetValue(key, out values))
                {
                    return NewObjectSettings(key);
                }

                return new ObjectSettings(key, values);
            }
        }

        public ObjectSettings NewObjectSettings()
        {
            string uniqueKey = Guid.NewGuid().ToString();
            return NewObjectSettings(uniqueKey);
        }

        public ObjectSettings NewObjectSettings(string uniqueKey)
        {
            Dictionary<string, string> backStore = new Dictionary<string, string>();
            ObjectSettings settings = new ObjectSettings(uniqueKey, backStore);
            this._values[uniqueKey] = backStore;
            return settings;
        }

        public void Remove(string uniqueKey)
        {
            this._values.Remove(uniqueKey);
        }

        public void Clear()
        {
            this._values.Clear();
        }

        public class ObjectSettings
        {
            string _uniqueKey;
            Dictionary<string, string> _values;

            internal ObjectSettings(string uniqueKey, Dictionary<string, string> values)
            {
                this._uniqueKey = uniqueKey;
                this._values = values;
            }

            public string UniqueKey
            {
                get { return this._uniqueKey; }
            }

            public string this[string key]
            {
                get 
                {
                    string s;
                    this._values.TryGetValue(key, out s);
                    return s; 
                }
                set { this._values[key] = value; }
            }

            public string GetValueOrDefault(string key, string defaultValue)
            {
                var value = this[key];
                if (value == null)
                    return defaultValue;

                return value;
            }

            public void Remove(string key)
            {
                this._values.Remove(key);
            }

            public void Clear()
            {
                this._values.Clear();
            }

            public bool IsEmpty
            {
                get { return this._values == null || this._values.Count == 0; }
            }

            public IEnumerable<string> Keys
            {
                get
                {
                    Dictionary<string, string>.KeyCollection keys = this._values.Keys;
                    string[] k = new string[keys.Count];
                    this._values.Keys.CopyTo(k,0);
                    return k;
                }
            }

            internal void WriteToJson(Utf8JsonWriter writer)
            {
                writer.WriteStartObject();
                foreach (var kvp in this._values)
                {
                    string value = kvp.Value as string;
                    if (value == null)
                        continue;

                    writer.WritePropertyName(kvp.Key);

                    if (PersistenceManager.IsEncrypted(kvp.Key) || PersistenceManager.IsEncrypted(this._uniqueKey))
                        value = UserCrypto.Encrypt(value);

                    writer.WriteStringValue(value);
                }
                writer.WriteEndObject();
            }
        }
    }
}
