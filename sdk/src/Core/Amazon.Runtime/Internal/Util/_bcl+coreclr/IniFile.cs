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

using System;
using System.Collections.Generic;
using System.IO;

namespace Amazon.Runtime.Internal.Util
{
    /// <summary>
    /// Provides read/write access to a file in the INI format.
    ///
    /// This class is not threadsafe.
    /// </summary>
    public class IniFile
    {
        private const string sectionNamePrefix = "[";
        private const string sectionNameSuffix = "]";
        private const string keyValueSeparator = "=";
        private const string semiColonComment = ";";
        private const string hashComment = "#";

        private OptimisticLockedTextFile textFile;

        /// <summary>
        /// Construct a new IniFile.
        /// </summary>
        /// <param name="filePath">path of the IniFile</param>
        public IniFile(string filePath)
        {
            textFile = new OptimisticLockedTextFile(filePath);
            Validate();
        }

        /// <summary>
        /// the path of the file
        /// </summary>
        public String FilePath
        {
            get
            {
                return textFile.FilePath;
            }
        }

        /// <summary>
        /// helper to access the lines of the file
        /// </summary>
        private List<string> Lines
        {
            get
            {
                return textFile.Lines;
            }
        }

        /// <summary>
        /// Persist the changes to this INI file to disk.
        /// </summary>
        public void Persist()
        {
            Validate();
            textFile.Persist();
        }

        /// <summary>
        /// Update the section with the properties given.
        /// If the section doesn't exist, it will be appended to the file.
        ///
        /// -Any properties that do exist in the section will be updated.
        /// -A null value for a property denotes that it should be deleted from the section
        /// -If any properties don't exist they will be appended to the end of the section
        /// in the same order they appear in the list.
        /// </summary>
        /// <param name="sectionName">name of the section to operate on</param>
        /// <param name="properties">ordered list of properties to add/update/delete</param>
        public void EditSection(string sectionName, List<KeyValuePair<string, string>> properties)
        {
            EnsureSectionExists(sectionName);

            // build dictionary from list
            // ensure the keys will be looked up case-insensitive
            var propertiesLookup = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            foreach (var pair in properties)
            {
                propertiesLookup.Add(pair.Key, pair.Value);
            }

            var lineNumber = 0;
            if (SeekSpecificSection(sectionName, ref lineNumber))
            {
                lineNumber++;
                string propertyName;
                string propertyValue;
                while (SeekProperty(ref lineNumber, out propertyName, out propertyValue))
                {
                    var propertyDeleted = false;
                    if (propertiesLookup.ContainsKey(propertyName))
                    {
                        if (!string.Equals(propertiesLookup[propertyName], propertyValue))
                        {
                            if (propertiesLookup[propertyName] == null)
                            {
                                // delete the line
                                Lines.RemoveAt(lineNumber);
                                propertyDeleted = true;
                            }
                            else
                            {
                                // update the line
                                Lines[lineNumber] = propertyName + keyValueSeparator + propertiesLookup[propertyName];
                            }
                        }
                        propertiesLookup.Remove(propertyName);
                    }
                    if (!propertyDeleted)
                    {
                        lineNumber++;
                    }
                }
                foreach (var pair in properties)
                {
                    if (propertiesLookup.ContainsKey(pair.Key))
                    {
                        Lines.Insert(lineNumber++, pair.Key + keyValueSeparator + pair.Value);
                    }
                }
            }
        }

        /// <summary>
        /// Check if the section exists.  If not, append it to the end of the file.
        /// </summary>
        /// <param name="sectionName">section to ensure exists</param>
        public void EnsureSectionExists(string sectionName)
        {
            var lineNumber = 0;
            if (!SeekSpecificSection(sectionName, ref lineNumber))
            {
                Lines.Add(sectionNamePrefix + sectionName + sectionNameSuffix);
            }
        }

        /// <summary>
        /// If the section exists, delete it from the INI file.
        /// </summary>
        /// <param name="sectionName">section to delete</param>
        public void DeleteSection(string sectionName)
        {
            var lineNumber = 0;
            if (SeekSpecificSection(sectionName, ref lineNumber))
            {
                Lines.RemoveAt(lineNumber);
                while (lineNumber < Lines.Count &&
                    !IsSection(Lines[lineNumber]))
                {
                    Lines.RemoveAt(lineNumber);
                }
            }
        }

        /// <summary>
        /// Determine if a section exists in the INI file.
        /// </summary>
        /// <param name="sectionName">name of section to look for</param>
        /// <returns>true if the section exists, false otherwise</returns>
        public bool SectionExists(string sectionName)
        {
            var lineNumber = 0;
            return SeekSpecificSection(sectionName, ref lineNumber);
        }

        /// <summary>
        /// Return the properties for the section if it exists.
        /// </summary>
        /// <param name="sectionName">name of section to get</param>
        /// <param name="properties">properties contained in the section</param>
        /// <returns>True if the section was found, false otherwise</returns>
        public bool TryGetSection(string sectionName, out Dictionary<string, string> properties)
        {
            var lineNumber = 0;
            properties = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase); ;
            if (SeekSpecificSection(sectionName, ref lineNumber))
            {
                lineNumber++;
                string propertyName;
                string propertyValue;
                while (SeekProperty(ref lineNumber, out propertyName, out propertyValue))
                {
                    properties.Add(propertyName, propertyValue);
                    lineNumber++;
                }
                return true;
            }
            return false;
        }

        override public string ToString()
        {
            return textFile.ToString();
        }

        private void Validate()
        {
            for (int i = 0; i < Lines.Count; i++)
            {
                var line = Lines[i];
                if (!IsProperty(line) && !IsSection(line) && !IsCommentOrBlank(line))
                {
                    throw new InvalidDataException(GetErrorMessage(i));
                }
            }
        }

        private bool SeekSpecificSection(string sectionName, ref int lineNumber)
        {
            string currentSectionName = null;
            while (SeekSection(ref lineNumber, out currentSectionName) &&
                !string.Equals(sectionName, currentSectionName, StringComparison.OrdinalIgnoreCase))
            {
                lineNumber++;
            }
            return string.Equals(sectionName, currentSectionName, StringComparison.OrdinalIgnoreCase);
        }

        private bool SeekSection(ref int lineNumber, out string sectionName)
        {
            while (lineNumber < Lines.Count)
            {
                if (TryParseSection(Lines[lineNumber], out sectionName))
                {
                    return true;
                }
                lineNumber++;
            }
            sectionName = null;
            return false;
        }

        private bool SeekProperty(ref int lineNumber, out string propertyName, out string propertyValue)
        {
            while (lineNumber < Lines.Count)
            {
                if (TryParseProperty(Lines[lineNumber], out propertyName, out propertyValue))
                {
                    return true;
                }
                else if (IsSection(Lines[lineNumber]))
                {
                    return false;
                }
                else if (IsCommentOrBlank(Lines[lineNumber]))
                {
                    lineNumber++;
                }
                else
                {
                    throw new InvalidDataException(GetErrorMessage(lineNumber));
                }
            }
            propertyName = null;
            propertyValue = null;
            return false;
        }

        private string GetErrorMessage(int lineNumber)
        {
            return string.Format("Line {0}:<{1}> in file {2} does not contain a section, property or comment.", lineNumber + 1, Lines[lineNumber], FilePath);
        }

        private bool IsCommentOrBlank(string line)
        {
            if (line == null)
            {
                return true;
            }
            else
            {
                line = line.Trim();
                return string.IsNullOrEmpty(line) ||
                    line.StartsWith(semiColonComment) ||
                    line.StartsWith(hashComment);
            }
        }

        private bool IsSection(string line)
        {
            string dummy;
            return TryParseSection(line, out dummy);
        }

        private bool TryParseSection(string line, out string sectionName)
        {
            if (line != null)
            {
                line = line.Trim();
                if (line.StartsWith(sectionNamePrefix) && line.EndsWith(sectionNameSuffix))
                {
                    sectionName = line.Substring(1, line.Length - 2).Trim();
                    return true;
                }
            }
            sectionName = null;
            return false;
        }

        private bool IsProperty(string line)
        {
            string dummyName;
            string dummyValue;
            return TryParseProperty(line, out dummyName, out dummyValue);
        }

        private bool TryParseProperty(string line, out string propertyName, out string propertyValue)
        {
            if (line != null)
            {
                line = line.Trim();
                var separatorIndex = line.IndexOf(keyValueSeparator);
                if (separatorIndex >= 0)
                {
                    propertyName = line.Substring(0, separatorIndex).Trim();
                    var valueStartIndex = separatorIndex + keyValueSeparator.Length;
                    propertyValue = line.Substring(valueStartIndex, line.Length - valueStartIndex).Trim();
                    return true;
                }
            }
            propertyName = null;
            propertyValue = null;
            return false;
        }
    }
}