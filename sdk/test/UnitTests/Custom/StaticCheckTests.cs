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
using Amazon.Runtime.Internal;
using Amazon.SecurityToken.Model;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class StaticCheckTests
    {
        [TestMethod]
        public void LookForAssumeRoleRequestChanges()
        {
            AssertExtensions.AssertPropertiesUnchanged(
                typeof(AssumeRoleRequest),
                "7A8200086250E7363E5535B0D94439E419E1BDD9698975E19DC46DFB3316DEE1",
                "The AssumeRoleAWSCredentialsOptions class and the ICoreAmazonSTS.CredentialsFromAssumeRoleAuthentication method implementation may need to be updated.");
        }

        [TestMethod]
        public void LookForProfileTypeChanges()
        {
            AssertExtensions.AssertEnumUnchanged(
                typeof(CredentialProfileType),
                "1BC4C17D6922B3934F38783246E026E11BA85BEF6EFBB39CDACE0221E6135D31",
                "The SharedCredentialsFile.GetAWSCredentials method implementation may need to be updated.");
        }

        [TestMethod]
        public void EnsureCredentialProfileDetectorSetup()
        {
            var profileTypes = new HashSet<CredentialProfileType>((CredentialProfileType[])(Enum.GetValues(typeof(CredentialProfileType))));
            var profileOptionsProperties = new HashSet<string>(typeof(CredentialProfileOptions).GetProperties().Select((p) => p.Name));

            var referencedProfileTypes = new HashSet<CredentialProfileType>();
            var referencedProfileOptionsProperties = new HashSet<string>();

            // avoid making TypePropertyDictionary public just for unit testing
            var field = typeof(CredentialProfileTypeDetector).GetFields(BindingFlags.Static | BindingFlags.NonPublic).
                Where((fi) => fi.Name == "TypePropertyDictionary").First();
            var typePropertyDictionary = (Dictionary<CredentialProfileType, HashSet<string>>)field.GetValue(null);

            foreach (var pair in typePropertyDictionary)
            {
                referencedProfileTypes.Add(pair.Key);
                foreach (var propertyName in pair.Value)
                {
                    if (!referencedProfileOptionsProperties.Contains(propertyName))
                    {
                        referencedProfileOptionsProperties.Add(propertyName);
                    }
                }
            }

            // Make sure all ProfileType values are set up.
            Assert.IsTrue(profileTypes.SetEquals(referencedProfileTypes));
            // Make sure the all the strings are valid ProfileOptions property names, and that all
            // the properties are used at least once.
            Assert.IsTrue(profileOptionsProperties.SetEquals(referencedProfileOptionsProperties));
        }

        [TestMethod]
        public void EnsureProfileOptionsClassesMatch()
        {
            var mutableProperties = new HashSet<string>(typeof(CredentialProfileOptions).GetProperties().Select((p) => p.Name));
            var immutableProperties = new HashSet<string>(typeof(ImmutableCredentialProfileOptions).GetProperties().Select((p) => p.Name));
            Assert.IsTrue(immutableProperties.SetEquals(mutableProperties));
        }
    }
}