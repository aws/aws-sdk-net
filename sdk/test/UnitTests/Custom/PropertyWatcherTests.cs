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
using Amazon.SecurityToken.Model;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class PropertyWatcherTests
    {
        [TestMethod]
        public void LookForAssumeRoleRequestChanges()
        {
            AssertExtensions.AssertPropertiesUnchanged(
                typeof(AssumeRoleRequest),
                "7A8200086250E7363E5535B0D94439E419E1BDD9698975E19DC46DFB3316DEE1",
                "The AssumeRoleAWSCredentialsOptions class and the ICoreAmazonSTS.CredentialsFromAssumeRoleAuthentication method implementation may need to be updated.");
        }
    }
}