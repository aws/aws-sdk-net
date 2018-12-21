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
using Amazon.Runtime.CredentialManagement;
using Amazon.Runtime.Internal;
using Amazon.Runtime.CredentialManagement.Internal;
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
        
        public static CredentialProfile GetRandomProfile(string profileName, CredentialProfileType profileType)
        {
            return GetCredentialProfile(Guid.NewGuid(), profileName, GetRandomOptions(profileType), GetRandomProperties(), GetRandomRegion(), null);
        }

        public static CredentialProfile GetCredentialProfile(Guid? uniqueKey, string profileName, CredentialProfileOptions options)
        {
            return GetCredentialProfile(uniqueKey, profileName, options, null, null, null);
        }                

        public static CredentialProfile GetCredentialProfile(Guid? uniqueKey, string profileName, CredentialProfileOptions options,
            Dictionary<string, string> properties, RegionEndpoint region, bool? endpointDiscoveryEnabled)
        {
            var profile = new CredentialProfile(profileName, options)
            {
                Region = region,
                EndpointDiscoveryEnabled = endpointDiscoveryEnabled
            };
            CredentialProfileUtils.SetUniqueKey(profile, uniqueKey);            
            ReflectionHelpers.Invoke(profile, "Properties", properties);
            return profile;
        }
    }
}
