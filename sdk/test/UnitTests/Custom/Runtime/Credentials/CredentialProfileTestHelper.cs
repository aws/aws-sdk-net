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
using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using AWSSDK_DotNet.CommonTest.Utils;
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
        private static readonly List<RegionEndpoint> EndpointList = new List<RegionEndpoint>(RegionEndpoint.EnumerableAllRegions);

        public static CredentialProfileOptions GetRandomOptions(CredentialProfileType profileType)
        {
            CredentialProfileOptions options = new CredentialProfileOptions();
            foreach (var propertyName in CredentialProfileTypeDetector.GetPropertiesForProfileType(profileType))
            {
                typeof(CredentialProfileOptions).GetProperty(propertyName).SetValue(options, Guid.NewGuid().ToString());
            }
            return options;
        }

        public static RegionEndpoint GetRandomRegion()
        {
            return EndpointList[new Random().Next(0, EndpointList.Count - 1)];
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

        public static CredentialProfile GetCredentialProfile(string profileName, CredentialProfileOptions options)
        {
            return GetCredentialProfile(null, profileName, options, null, null, new MemoryCredentialProfileStore());
        }

        public static CredentialProfile GetCredentialProfile(string profileName, CredentialProfileOptions options, Dictionary<string, string> properties)
        {
            return GetCredentialProfile(null, profileName, options, properties, null, new MemoryCredentialProfileStore());
        }

        public static CredentialProfile GetCredentialProfile(string profileName, CredentialProfileOptions options, Dictionary<string, string> properties, RegionEndpoint region)
        {
            return GetCredentialProfile(null, profileName, options, properties, region, new MemoryCredentialProfileStore());
        }

        public static CredentialProfile GetCredentialProfile(string uniqueKey, string profileName, CredentialProfileOptions options, Dictionary<string, string> properties)
        {
            return GetCredentialProfile(uniqueKey, profileName, options, properties, null, new MemoryCredentialProfileStore());
        }

        public static CredentialProfile GetCredentialProfile(string uniqueKey, string profileName,
            CredentialProfileOptions options, Dictionary<string, string> properties, RegionEndpoint region)
        {
            return GetCredentialProfile(uniqueKey, profileName, options, properties, region, new MemoryCredentialProfileStore());
        }

        public static CredentialProfile GetRandomProfile(string profileName, CredentialProfileType profileType, ICredentialProfileStore profileStore)
        {
            return GetCredentialProfile(null, profileName, GetRandomOptions(profileType), GetRandomProperties(), GetRandomRegion(), profileStore);
        }

        public static CredentialProfile GetCredentialProfile(string profileName, CredentialProfileOptions options, ICredentialProfileStore profileStore)
        {
            return GetCredentialProfile(null, profileName, options, null, null, profileStore);
        }

        private static CredentialProfile GetCredentialProfile(string uniqueKey, string profileName, CredentialProfileOptions options,
            Dictionary<string, string> properties, RegionEndpoint region, ICredentialProfileStore profileStore)
        {
            var constructor = typeof(CredentialProfile).GetConstructor(
                BindingFlags.NonPublic | BindingFlags.Instance,
                null,
                new Type[] { typeof(string), typeof(CredentialProfileOptions), typeof(ICredentialProfileStore) },
                null);

            var profile = (CredentialProfile)constructor.Invoke(new object[] { profileName, options, profileStore });
            ReflectionHelpers.Invoke(profile, "UniqueKey", uniqueKey);
            ReflectionHelpers.Invoke(profile, "Properties", properties);
            profile.Region = region;
            return profile;
        }
    }
}
