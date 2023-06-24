﻿/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Amazon.Runtime.Internal.Util
{
    /// <summary>
    /// Subclass of IniFile that allows INI sections to be read with the profile keyword in front of the section name.
    /// </summary>
    public class ProfileIniFile : IniFile
    {
        private const string ProfileMarker = "profile";
        private const string SsoSessionMarker = "sso-session";

        public bool ProfileMarkerRequired { get; set; }
        public override HashSet<string> ListSectionNames()
        {
            var profileNames = new HashSet<string>();
            foreach (var profileName in base.ListSectionNames())
            {
                if (ProfileMarkerRequired)
                {
                    if (!(profileName.StartsWith(ProfileMarker, StringComparison.Ordinal)))
                        continue;
                }
                var actualProfileName = Regex.Replace(profileName, ProfileMarker + "[ \t]+", "");

                profileNames.Add(actualProfileName);
            }
            return profileNames;
        }

        public ProfileIniFile(string filePath,bool profileMarkerRequired) : base(filePath)
        {
            ProfileMarkerRequired = profileMarkerRequired;
        }

        public override bool TryGetSection(string sectionName, out Dictionary<string, string> properties)
        {
            return this.TryGetSection(sectionName, isSsoSession: false, out properties);
        }

        public bool TryGetSection(string sectionName, bool isSsoSession, out Dictionary<string, string> properties)
        {
            bool hasCredentialsProperties = false;
            properties = null;

            if (!ProfileMarkerRequired && !isSsoSession)
                hasCredentialsProperties = base.TryGetSection(sectionName, out properties);

            if (!hasCredentialsProperties)
            {
                var marker = isSsoSession ? SsoSessionMarker : ProfileMarker;

                var credentialSectionNameRegex = new Regex("^" + marker + "[ \\t]+" + Regex.Escape(sectionName) + "$", RegexOptions.Singleline);
                hasCredentialsProperties = this.TryGetSection(credentialSectionNameRegex, out properties);
            }
            return hasCredentialsProperties;
        }

        public override void EditSection(string sectionName, SortedDictionary<string, string> properties)
        {
            this.EditSection(sectionName, isSsoSession: false, properties);
        }

        public void EditSection(string sectionName, bool isSsoSession, SortedDictionary<string, string> properties)
        {
            if (!ProfileMarkerRequired && !isSsoSession)
            {
                base.EditSection(sectionName, properties);
                return;
            }

            var marker = isSsoSession ? SsoSessionMarker : ProfileMarker;

            var credentialSectionNameRegex = new Regex("^" + marker + "[ \\t]+" + Regex.Escape(sectionName) + "$", RegexOptions.Singleline);

            if(SectionExists(credentialSectionNameRegex, out var fullSectionName))
            {
                base.EditSection(fullSectionName, properties);
            }
        }

    }
}
