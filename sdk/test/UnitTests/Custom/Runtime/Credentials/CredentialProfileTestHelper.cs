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
using Amazon.Runtime.Internal;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Work around the fact that CredentialsProfile has no public constructor, for testing purposes.
    /// </summary>
    public static class CredentialProfileTestHelper
    {
        public static CredentialProfileOptions GetRandomOptions(CredentialProfileType profileType)
        {
            CredentialProfileOptions options = new CredentialProfileOptions();
            foreach (var propertyName in CredentialProfileTypeDetector.GetPropertiesForProfileType(profileType))
            {
                typeof(CredentialProfileOptions).GetProperty(propertyName).SetValue(options, Guid.NewGuid().ToString());
            }
            return options;
        }

        public static Dictionary<string, string> GetRandomProperties()
        {
            var properties = new Dictionary<string, string>();
            var numProperties = new Random().Next(1, 5);
            for (int i = 0; i < numProperties; i++)
            {
                properties.Add(Guid.NewGuid().ToString(), Guid.NewGuid().ToString());
            }
            return properties;
        }

        public static CredentialProfile GetRandomProfile(string profileName, CredentialProfileType profileType)
        {
            return GetCredentialProfile(profileName, GetRandomOptions(profileType));
        }

        public static CredentialProfile GetCredentialProfile(string profileName, CredentialProfileOptions options)
        {
            return GetCredentialProfile(profileName, options, null, new MemoryCredentialProfileStore());
        }

        public static CredentialProfile GetCredentialProfile(string profileName, CredentialProfileOptions options, Dictionary<string, string> properties)
        {
            return GetCredentialProfile(profileName, options, properties, new MemoryCredentialProfileStore());
        }

        public static CredentialProfile GetRandomProfile(string profileName, CredentialProfileType profileType, ICredentialProfileStore profileStore)
        {
            return GetCredentialProfile(profileName, GetRandomOptions(profileType), GetRandomProperties(), profileStore);
        }

        public static CredentialProfile GetCredentialProfile(string profileName, CredentialProfileOptions options, ICredentialProfileStore profileStore)
        {
            return GetCredentialProfile(profileName, options, null, profileStore);
        }

        public static CredentialProfile GetCredentialProfile(string profileName, CredentialProfileOptions options,
            Dictionary<string, string> properties, ICredentialProfileStore profileStore)
        {
            var constructor = typeof(CredentialProfile).GetConstructor(
                BindingFlags.NonPublic | BindingFlags.Instance,
                null,
                new Type[] { typeof(string), typeof(CredentialProfileOptions), typeof(Dictionary<string, string>), typeof(ICredentialProfileStore) },
                null);

            return (CredentialProfile)constructor.Invoke(new object[] { profileName, options, properties, profileStore });
        }
    }
}
