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
using System.Linq;
using System.Text;

namespace Amazon.Runtime.Internal.Auth
{
    /// <summary>
    /// Provides access to read and write credentials INI files.
    /// The file is read, parsed, and validated at construction time.
    /// Changes can be made using the AddOrUpdateSection() and
    /// DeleteSection() methods.
    /// Those changes can be persisted to disk using the Persist() method.
    ///
    /// This class is not threadsafe.
    /// </summary>
    public class SharedCredentialsFile
    {
        private const string profileNamePrefix = "[";
        private const string profileNameSuffix = "]";
        private const string dataPrefix = "aws_";
        private const string keyValueSeparator = "=";
        private const string accessKeyName = "aws_access_key_id";
        private const string secretKeyName = "aws_secret_access_key";
        private const string tokenName = "aws_session_token";

        private Dictionary<string, CredentialsSection> Sections { get; set; }

        /// <summary>
        /// list of profile names
        /// The list is used to maintain the order of the sections in the credentials file.
        /// </summary>
        private List<string> ProfileNames { get; set; }

        /// <summary>
        /// a full copy of the original file
        /// This is used for optimistic concurrency on the credentials file.
        /// Note that this assumes a small credentials file and does
        /// not scale for very large files.
        /// </summary>
        private string OriginalContents { get; set; }

        /// <summary>
        /// path of the shared credentials file
        /// </summary>
        public string FilePath { get; private set; }

        /// <summary>
        /// Construct a new SharedCredentialsFile.
        /// </summary>
        /// <param name="filePath">path of the shared credentials file</param>
        public SharedCredentialsFile(string filePath)
        {
            FilePath = filePath;
            Parse();
        }

        /// <summary>
        /// Gets the CredentialsSection for the profileName given, or null if one doesn't exist.
        /// </summary>
        /// <param name="profileName">the name of the profile to get</param>
        /// <returns></returns>
        public CredentialsSection this[string profileName]
        {
            get
            {
                CredentialsSection section = null;
                Sections.TryGetValue(profileName, out section);
                return section;
            }
        }

        /// <summary>
        /// Add a section to the SharedCredentialsFile.
        /// If a section already exists with the same ProfileName, replace it.
        /// Changes are not written to disk until the Persist() method is called.
        /// </summary>
        /// <param name="section"></param>
        public void AddOrUpdateSection(CredentialsSection section)
        {
            section.Validate();
            // If the section doesn't exist yet add it to the end of the list.
            if (!Sections.ContainsKey(section.ProfileName))
            {
                ProfileNames.Add(section.ProfileName);
            }

            Sections[section.ProfileName] = section;
        }


        /// <summary>
        /// Deletes the section with the given ProfileName from the SharedCredentialsFile, if one exists.
        /// Changes are not written to disk until the Persist() method is called.
        /// </summary>
        /// <param name="profileName">ProfileName of section to delete</param>
        public void DeleteSection(string profileName)
        {
            if (Sections.ContainsKey(profileName))
            {
                Sections[profileName] = null;
                // No need to delete the name from ProfileNames
                // since GetSections() handles extra names in that list.
            }
        }

        /// <summary>
        /// Get a list of all of the CredentialsSections in the SharedCredentialsFile.
        /// </summary>
        /// <returns>a list of the CredentialsSection</returns>
        public List<CredentialsSection> GetSections()
        {
            // Build the list of sections based on the ordered
            // list of profileNames.  If there are profileNames
            // in the list that were removed from the dictionary
            // just skip them.
            var sectionList = new List<CredentialsSection>();
            foreach (string profileName in ProfileNames)
            {
                if (this[profileName] != null)
                {
                    sectionList.Add(this[profileName]);
                }
            }
            return sectionList;
        }

        /// <summary>
        /// the number of CredentialsSections in this SharedCredentialsFile
        /// </summary>
        public int Count
        {
            get
            {
                return Sections.Count;
            }
        }

        /// <summary>
        /// Persist changes to the SharedCredentialsFile to disk.
        /// </summary>
        public void Persist()
        {
            // build the new contents
            var newContents = new StringBuilder();
            foreach (CredentialsSection section in GetSections())
            {
                section.Validate();
                newContents.AppendLine(profileNamePrefix + section.ProfileName + profileNameSuffix);
                newContents.AppendLine(accessKeyName + keyValueSeparator + section.AccessKey);
                newContents.AppendLine(secretKeyName + keyValueSeparator + section.SecretKey);
                if (section.Token != null)
                {
                    newContents.AppendLine(tokenName + keyValueSeparator + section.Token);
                }
            }

            // open the file with exclusive access
            using (var fileStream = new FileStream(FilePath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None))
            {
                // get a current copy of the file
                string currentContents = null;
                using (var streamReader = new StreamReader(fileStream))
                {
                    currentContents = streamReader.ReadToEnd();

                    // optimistic concurrency check - make sure the file hasn't changed since it was read
                    if (string.Equals(currentContents, OriginalContents, StringComparison.Ordinal))
                    {
                        // write the new contents
                        fileStream.Seek(0, SeekOrigin.Begin);
                        using (var streamWriter = new StreamWriter(fileStream))
                        {
                            streamWriter.Write(newContents.ToString());
                            streamWriter.Flush();

                            // set the length in case the new contents are shorter than the old contents
                            fileStream.Flush();
                            fileStream.SetLength(fileStream.Position);
                            OriginalContents = newContents.ToString();
                        }
                    }
                    else
                    {
                        throw new IOException(string.Format("Cannot write to credentials file {0}.  The file has been modified since it was last read.", FilePath));
                    }
                }
            }
        }

        private void Parse()
        {
            Sections = new Dictionary<string, CredentialsSection>();
            ProfileNames = new List<string>();
            CredentialsSection currentSection = null;

            // Store a copy of the file for checking concurrency
            OriginalContents = "";
            try
            {
                OriginalContents = File.ReadAllText(FilePath);
            }
            catch (FileNotFoundException)
            {
                // This is OK.  The Persist() method will create it if necessary.
            }

            using (var stringReader = new StringReader(OriginalContents))
            {
                var line = stringReader.ReadLine();
                while (line != null)
                {
                    line = line.Trim();
                    if (line.StartsWith(profileNamePrefix, StringComparison.OrdinalIgnoreCase) &&
                        line.EndsWith(profileNameSuffix, StringComparison.OrdinalIgnoreCase))
                    {
                        if (currentSection != null)
                        {
                            AddOrUpdateSection(currentSection);
                        }

                        var profileName = GetProfileName(line);
                        currentSection = new CredentialsSection(profileName);
                    }
                    else if (line.StartsWith(dataPrefix, StringComparison.OrdinalIgnoreCase) && currentSection != null)
                    {
                        // split data into key-value pairs, store appropriately
                        var split = SplitData(line);
                        if (split.Count > 0)
                        {
                            var name = split[0];
                            var value = split.Count > 1 ? split[1] : null;

                            SetSectionValue(currentSection, name, value);
                        }
                    }
                    line = stringReader.ReadLine();
                }
            }

            if (currentSection != null)
            {
                AddOrUpdateSection(currentSection);
            }
        }

        private static List<string> SplitData(string line)
        {
            var split = line
                .Split(new string[] { keyValueSeparator }, 2, StringSplitOptions.None)
                .Select(s => s.Trim())
                .Where(s => !string.IsNullOrEmpty(s))
                .ToList();
            return split;
        }

        private static string GetProfileName(string line)
        {
            // get profile name by trimming off the [ and ] characters
            var profileName = line;
            profileName = profileName.Substring(profileNamePrefix.Length);
            profileName = profileName.Substring(0, profileName.Length - profileNameSuffix.Length);
            return profileName.Trim();
        }

        private static void SetSectionValue(CredentialsSection section, string name, string value)
        {
            if (string.Equals(accessKeyName, name, StringComparison.OrdinalIgnoreCase))
                section.AccessKey = value;
            else if (string.Equals(secretKeyName, name, StringComparison.OrdinalIgnoreCase))
                section.SecretKey = value;
            else if (string.Equals(tokenName, name, StringComparison.OrdinalIgnoreCase))
                section.Token = value;
        }
    }

    public class CredentialsSection
    {
        public CredentialsSection(string profileName)
        {
            ProfileName = profileName;
        }

        public string ProfileName { get; set; }
        public string AccessKey { get; set; }
        public string SecretKey { get; set; }
        public string Token { get; set; }

        public void Validate()
        {
            if (!HasValidCredentials)
                throw new InvalidDataException(String.Format("Credential profile [{0}] does not contain valid access and/or secret key materials.", ProfileName));
        }

        public bool HasValidCredentials
        {
            get
            {
                return
                    !string.IsNullOrEmpty(AccessKey) &&
                    !string.IsNullOrEmpty(SecretKey);
            }
        }
        public ImmutableCredentials Credentials
        {
            get
            {
                return new ImmutableCredentials(AccessKey, SecretKey, Token);
            }
        }
    }

}