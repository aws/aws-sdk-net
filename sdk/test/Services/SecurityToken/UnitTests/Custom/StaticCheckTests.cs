/*
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
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using Amazon.Runtime.Internal;
using Amazon.Runtime.CredentialManagement.Internal;
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
        [TestCategory("SecurityToken")]
        public void LookForAssumeRoleRequestChanges()
        {
            AssertExtensions.AssertPropertiesUnchanged(
                typeof(AssumeRoleRequest),
                "A75E398328A157C4BF8C34BC6E86E784E7F47C34A2854387F64652B3729752EA",
                "The AssumeRoleAWSCredentialsOptions class and the ICoreAmazonSTS.CredentialsFromAssumeRoleAuthentication method implementation may need to be updated.");
        }

        [TestMethod]
        [TestCategory("SecurityToken")]
        public void LookForProfileTypeChanges()
        {
#if BCL35
            var expectedHash = "BAA0807391164631A9AB382D9319703CDBC44F344C2839D4127C49857C61FE94";
#else
            var expectedHash = "E15E66896846B0235881B8623AF005AA80B9DEDF4303348FC494290E0D6E2732";
#endif
            AssertExtensions.AssertEnumUnchanged(
                typeof(CredentialProfileType),
                expectedHash,
                "The AWSCredentialsFactory.GetAWSCredentials method implementation may need to be updated.");
        }

        [TestMethod]
        [TestCategory("SecurityToken")]
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
    }
}