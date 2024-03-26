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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Amazon.Runtime;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class StsRegionalFlagTests
    {
        private const string AwsStsRegionalEndpointsEnvironmentVariable = "AWS_STS_REGIONAL_ENDPOINTS";

        /// <summary>
        /// Ensure that the STS Regional Flag is set according to the value in the environment.
        /// </summary>
        [DataTestMethod]
        [DataRow("regional", StsRegionalEndpointsValue.Regional)]
        [TestCategory("SecurityToken")]
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

        /// <summary>
        /// Ensure that the STS Regional Flag is set according to the value the customer sets in the ClientConfig.
        /// </summary>
        [DataTestMethod]
        [DataRow(StsRegionalEndpointsValue.Regional)]
        [TestCategory("SecurityToken")]
        public void ClientConfigStsFlag(StsRegionalEndpointsValue stsFlagValue)
        {
            var config = new AmazonSecurityTokenServiceConfig
            {
                StsRegionalEndpoints = stsFlagValue
            };

            Assert.AreEqual(stsFlagValue, config.StsRegionalEndpoints);   
        }

        /// <summary>
        /// Ensure that an invalid value is not allowed for the STS Regional Flag environment variable.
        /// </summary>
        [DataTestMethod]
        [TestCategory("SecurityToken")]
        [DataRow("invalid")]
        [DataRow("999999999999999999999999999999999999999999999999999999999999999999")]
        [DataRow("true")]
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
