/*
 * Copyright 2017 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class FallbackFactoryTest
    {
        private static readonly string ProfileText = new StringBuilder()
            .AppendLine("[default]")
            .AppendLine("region=us-west-2")
            .AppendLine("aws_access_key_id=default_aws_access_key_id")
            .AppendLine("aws_secret_access_key=default_aws_secret_access_key")            
            .AppendLine("[other]")
            .AppendLine("region=us-west-1")
            .AppendLine("aws_access_key_id=other_aws_access_key_id")
            .AppendLine("aws_secret_access_key=other_aws_secret_access_key")
            .AppendLine("endpoint_discovery_enabled=false")
            .AppendLine("[other2]")
            .AppendLine("region=us-west-1")
            .AppendLine("aws_access_key_id=other2_aws_access_key_id")
            .AppendLine("aws_secret_access_key=other2_aws_secret_access_key")
            .AppendLine("endpoint_discovery_enabled=true")
            .ToString();

        [TestMethod]
        public void TestDefaultProfile()
        {
            using (new FallbackFactoryTestFixture(ProfileText, null))
            {
                var creds = FallbackCredentialsFactory.GetCredentials();
                Assert.AreEqual("default_aws_access_key_id", creds.GetCredentials().AccessKey);

                var region = FallbackRegionFactory.GetRegionEndpoint(false);
                Assert.AreEqual(RegionEndpoint.USWest2, region);

                var enabled = FallbackEndpointDiscoveryEnabledFactory.GetEnabled();
                Assert.IsFalse(enabled.HasValue);                
            }
        }               

        [TestMethod]
        public void TestOtherProfile()
        {
            using (new FallbackFactoryTestFixture(ProfileText, "other"))
            {
                var creds = FallbackCredentialsFactory.GetCredentials();
                Assert.AreEqual("other_aws_access_key_id", creds.GetCredentials().AccessKey);

                var region = FallbackRegionFactory.GetRegionEndpoint(false);
                Assert.AreEqual(RegionEndpoint.USWest1, region);

                var enabled = FallbackEndpointDiscoveryEnabledFactory.GetEnabled();
                Assert.IsTrue(enabled.HasValue);
                Assert.IsFalse(enabled.Value);
            }
        }

        [TestMethod]
        public void TestOther2Profile()
        {
            using (new FallbackFactoryTestFixture(ProfileText, "other2"))
            {                
                var enabled = FallbackEndpointDiscoveryEnabledFactory.GetEnabled();
                Assert.IsTrue(enabled.HasValue);
                Assert.IsTrue(enabled.Value);
            }
        }

        [TestMethod]
        public void TestEnableEndpointDiscoveryEnvVariable()
        {
            using (new FallbackFactoryTestFixture(ProfileText, "other2", "false"))
            {
                var enabled = FallbackEndpointDiscoveryEnabledFactory.GetEnabled();
                Assert.IsTrue(enabled.HasValue);
                Assert.IsFalse(enabled.Value);
            }
        }

        public class FallbackFactoryTestFixture : IDisposable
        {
            private const string AWS_PROFILE_ENVIRONMENT_VARIABLE = "AWS_PROFILE";
            private const string AWS_ENABLE_ENDPOINT_DISCOVERY_ENVIRONMENT_VARIABLE = "AWS_ENABLE_ENDPOINT_DISCOVERY";

            private SharedCredentialsFileTestFixture sharedFixture;
            private NetSDKCredentialsFileTestFixture netSdkFixture;

            private CredentialProfileStoreChain originalCredsChain;
            private CredentialProfileStoreChain originalRegionChain;
            private CredentialProfileStoreChain originalEndpointDiscoveryEnabledChain;

            private string originalAWSProfileValue;
            private string originalAWSEnableEndpointDiscoveryValue;
            

            public FallbackFactoryTestFixture(string sharedCredsFileContent, string awsProfileValue, string enableEndpointDiscoveryValue = null)
            {
                sharedFixture = new SharedCredentialsFileTestFixture(sharedCredsFileContent);
                netSdkFixture = new NetSDKCredentialsFileTestFixture();

                originalCredsChain = (CredentialProfileStoreChain)ReflectionHelpers.Invoke(typeof(FallbackCredentialsFactory), "credentialProfileChain");
                ReflectionHelpers.Invoke(typeof(FallbackCredentialsFactory), "credentialProfileChain", new CredentialProfileStoreChain(sharedFixture.CredentialsFilePath));

                originalRegionChain = (CredentialProfileStoreChain)ReflectionHelpers.Invoke(typeof(FallbackRegionFactory), "credentialProfileChain");
                ReflectionHelpers.Invoke(typeof(FallbackRegionFactory), "credentialProfileChain", new CredentialProfileStoreChain(sharedFixture.CredentialsFilePath));

                originalEndpointDiscoveryEnabledChain = (CredentialProfileStoreChain)ReflectionHelpers.Invoke(typeof(FallbackEndpointDiscoveryEnabledFactory), "credentialProfileChain");
                ReflectionHelpers.Invoke(typeof(FallbackEndpointDiscoveryEnabledFactory), "credentialProfileChain", new CredentialProfileStoreChain(sharedFixture.CredentialsFilePath));

                originalAWSProfileValue = Environment.GetEnvironmentVariable(AWS_PROFILE_ENVIRONMENT_VARIABLE);
                Environment.SetEnvironmentVariable(AWS_PROFILE_ENVIRONMENT_VARIABLE, awsProfileValue);

                originalAWSEnableEndpointDiscoveryValue = Environment.GetEnvironmentVariable(AWS_ENABLE_ENDPOINT_DISCOVERY_ENVIRONMENT_VARIABLE);
                Environment.SetEnvironmentVariable(AWS_ENABLE_ENDPOINT_DISCOVERY_ENVIRONMENT_VARIABLE, enableEndpointDiscoveryValue);

                // reset before use to ensure the new credentialProfileChains are used.
                FallbackCredentialsFactory.Reset();
                FallbackRegionFactory.Reset();
                FallbackEndpointDiscoveryEnabledFactory.Reset();
            }

            public void Dispose()
            {
                Environment.SetEnvironmentVariable(AWS_PROFILE_ENVIRONMENT_VARIABLE, originalAWSProfileValue);
                Environment.SetEnvironmentVariable(AWS_ENABLE_ENDPOINT_DISCOVERY_ENVIRONMENT_VARIABLE, originalAWSEnableEndpointDiscoveryValue);

                ReflectionHelpers.Invoke(typeof(FallbackRegionFactory), "credentialProfileChain", originalRegionChain);
                ReflectionHelpers.Invoke(typeof(FallbackCredentialsFactory), "credentialProfileChain", originalCredsChain);
                ReflectionHelpers.Invoke(typeof(FallbackEndpointDiscoveryEnabledFactory), "credentialProfileChain", originalEndpointDiscoveryEnabledChain);

                netSdkFixture.Dispose();
                sharedFixture.Dispose();

                FallbackCredentialsFactory.Reset();
                FallbackRegionFactory.Reset();
                FallbackEndpointDiscoveryEnabledFactory.Reset();
            }
        }
    }
}
