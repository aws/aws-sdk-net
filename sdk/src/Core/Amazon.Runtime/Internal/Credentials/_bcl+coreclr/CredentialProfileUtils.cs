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
using Amazon.Runtime.Internal.Settings;
using Amazon.Util;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// This class is used internally and should not be accessed by SDK users.
    ///
    /// Provide access to internal properties of CredentialProfile to
    /// PowerShell tools and the Visual Studio Toolkit.
    /// </summary>
    public static class CredentialProfileUtils
    {
        public static Dictionary<string, string> GetProperties(CredentialProfile profile)
        {
            return profile.Properties;
        }

        public static void SetProperty(CredentialProfile profile, string key, string value)
        {
            profile.Properties[key] = value;
        }

        public static string GetProperty(CredentialProfile profile, string key)
        {
            string value;
            profile.Properties.TryGetValue(key, out value);
            return value;
        }

        public static void RegisterProfile(CredentialProfileManager profileManager, string profileName,
            CredentialProfileOptions profileOptions, Dictionary<string, string> properties)
        {
            RegisterProfile(profileManager, profileName, profileOptions, properties, null);
        }

        public static void RegisterProfile(CredentialProfileManager profileManager, string profileName,
            CredentialProfileOptions profileOptions, Dictionary<string, string> properties, RegionEndpoint region)
        {
            profileManager.RegisterProfileInternal(profileName, profileOptions, properties, region);
        }
    }
}