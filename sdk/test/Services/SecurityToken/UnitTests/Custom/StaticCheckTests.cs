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
                "10605E2C8309455F9EFD711E8FDF5BFCF517FD421B2D6B571985E3DA1C7E54D0",
                "The AssumeRoleAWSCredentialsOptions class and the ICoreAmazonSTS.CredentialsFromAssumeRoleAuthentication method implementation may need to be updated.");
        }

        [TestMethod]
        [TestCategory("SecurityToken")]
        public void LookForProfileTypeChanges()
        {
            var expectedHash = "E15E66896846B0235881B8623AF005AA80B9DEDF4303348FC494290E0D6E2732";
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