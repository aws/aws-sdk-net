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
using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Reflection;
using System.Text;
using System.Globalization;
using Amazon.Runtime.CredentialManagement;
using Amazon.Runtime;
using AWSSDK_DotNet.CommonTest.Utils;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class StsRegionalFlagTests
    {
        private static readonly string ProfileText = @"[default]
                                                        region=us-west-2
                                                        aws_access_key_id=default_aws_access_key_id
                                                        aws_secret_access_key=default_aws_secret_access_key
                                                        sts_regional_endpoints=legacy
                                                        [other]
                                                        region=us-west-2
                                                        aws_access_key_id=other_aws_access_key_id
                                                        aws_secret_access_key=other_aws_secret_access_key
                                                        sts_regional_endpoints=regional";
       

        private const string AwsProfileEnvironmentVariable = "AWS_PROFILE";
        private const string AwsStsRegionalEndpointsEnvironmentVariable = "AWS_STS_REGIONAL_ENDPOINTS";

        [Ignore]
        [DataTestMethod]
        [DataRow("default", StsRegionalEndpointsValue.Legacy)]
        [DataRow("other", StsRegionalEndpointsValue.Regional)]
        [TestCategory("SecurityToken")]
        /// Ensure that the STS Regional Flag is set according to the value
        /// in the Shared Credentials File
        public void TestCredentialsFileStsFlag(string profile, StsRegionalEndpointsValue expectedValue)
        {
            /* // This test can not currently be run because SharedCredentialsFileTestFixture
               // is not referenced within the SecurityToken project. It causes errors when
               // building the project individually.
             using (var testFixture = new SharedCredentialsFileTestFixture(ProfileText))
            {
                var oldProfile = Environment.GetEnvironmentVariable(AwsProfileEnvironmentVariable);
                var oldSts = Environment.GetEnvironmentVariable(AwsStsRegionalEndpointsEnvironmentVariable);
                try
                {
                    Environment.SetEnvironmentVariable(AwsProfileEnvironmentVariable, profile);
                    // Environment Variable takes precedence over credentials file value so set it to null to avoid conflict
                    Environment.SetEnvironmentVariable(AwsStsRegionalEndpointsEnvironmentVariable, null);
                    ReflectionHelpers.Invoke(typeof(AmazonSecurityTokenServiceConfig), "credentialProfileChain", new CredentialProfileStoreChain(testFixture.CredentialsFilePath));
                    var config = new AmazonSecurityTokenServiceConfig();
                    Assert.AreEqual(expectedValue, config.StsRegionalEndpoints);
                }
                finally
                {
                    Environment.SetEnvironmentVariable(AwsProfileEnvironmentVariable, oldProfile);
                    Environment.SetEnvironmentVariable(AwsStsRegionalEndpointsEnvironmentVariable, oldSts);
                }

            }*/
        }

        [DataTestMethod]
        [DataRow("legacy", StsRegionalEndpointsValue.Legacy)]
        [DataRow("regional", StsRegionalEndpointsValue.Regional)]
        [TestCategory("SecurityToken")]
        /// Ensure that the STS Regional Flag is set according to the value
        /// in the environment
        public void TestEnvStsFlag(string stsFlagValue, StsRegionalEndpointsValue expectedValue)
        {
            var oldStsEnv = Environment.GetEnvironmentVariable(AwsStsRegionalEndpointsEnvironmentVariable);
            try
            {
                Environment.SetEnvironmentVariable(AwsStsRegionalEndpointsEnvironmentVariable, stsFlagValue);
                var config = new AmazonSecurityTokenServiceConfig();
                Assert.AreEqual(expectedValue, config.StsRegionalEndpoints);
            }
            finally
            {
                Environment.SetEnvironmentVariable(AwsStsRegionalEndpointsEnvironmentVariable, oldStsEnv);
            }
        }

        [DataTestMethod]
        [DataRow(StsRegionalEndpointsValue.Legacy)]
        [DataRow(StsRegionalEndpointsValue.Regional)]
        [TestCategory("SecurityToken")]
        /// Ensure that the STS Regional Flag is set according to the value
        /// the customer sets in the ClientConfig
        public void ClientConfigStsFlag(StsRegionalEndpointsValue stsFlagValue)
        {
            var config = new AmazonSecurityTokenServiceConfig()
            {
                StsRegionalEndpoints = stsFlagValue
            };
            Assert.AreEqual(stsFlagValue, config.StsRegionalEndpoints);   
        }

        [DataTestMethod]
        [TestCategory("SecurityToken")]
        [DataRow("invalid")]
        [DataRow("999999999999999999999999999999999999999999999999999999999999999999")]
        [DataRow("true")]
        /// Ensure that an invalid value is not allowed for the STS Regional
        /// Flag environment variable
        public void TestEnvStsFlagInvalid(string invalidValue)
        {
            var oldStsEnv = Environment.GetEnvironmentVariable(AwsStsRegionalEndpointsEnvironmentVariable);
            try
            {
                Environment.SetEnvironmentVariable(AwsStsRegionalEndpointsEnvironmentVariable, invalidValue);
                var config = new AmazonSecurityTokenServiceConfig();
                var getStsRegionalEndpoints = config.StsRegionalEndpoints;
                Assert.Fail();
            }
            catch (InvalidOperationException e)
            {
                Assert.IsInstanceOfType(e, typeof(InvalidOperationException));
            }
            finally
            {
                Environment.SetEnvironmentVariable(AwsStsRegionalEndpointsEnvironmentVariable, oldStsEnv);
            }
        }

    }
}
