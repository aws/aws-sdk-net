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
using Amazon.Runtime.Internal.Auth;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;

namespace AWSSDK_DotNet35.UnitTests.Custom.Runtime
{
    [TestClass]
    public class EnvironmentalVariableTest
    {
        [TestMethod]
        [TestCategory("Runtime")]
        public void EnvironmentalVariablesAWSCredentialsTest()
        {
            SetEnvironmentVariable("testKeyId", "testSecretAccessKey", "testSessionToken");
            EnvironmentVariablesAWSCredentials EnvCredentials = new EnvironmentVariablesAWSCredentials();
            Assert.AreEqual(EnvCredentials.GetCredentials(), new ImmutableCredentials("testKeyId", "testSecretAccessKey", "testSessionToken"));
        }

        public void SetEnvironmentVariable(string key, string accessKey, string sessionToken)
        {
            Environment.SetEnvironmentVariable("AWS_ACCESS_KEY_ID", key);
            Environment.SetEnvironmentVariable("AWS_SECRET_ACCESS_KEY", accessKey);
            Environment.SetEnvironmentVariable("AWS_SESSION_TOKEN", sessionToken);
        }
    }
}
