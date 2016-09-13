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
using Amazon.Runtime.Internal.Util;
using Amazon.SecurityToken.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class AmazonSecurityTokenServiceClientTest
    {
        [TestMethod]
        public void LookForAssumeRoleRequestChanges()
        {
            const int expectedHash = -430614572;
            // Use the property names only, because their hashes are consistent across runs.
            int actualHash = Hashing.Hash(typeof(AssumeRoleRequest).GetProperties().Select((p) => p.Name).ToArray());

            Assert.AreEqual(expectedHash, actualHash,
                "The AssumeRoleRequest class has added, removed, or changed properties.  " +
                "The AssumeRoleAWSCredentialsOptions class and the ICoreAmazonSTS.CredentialsFromAssumeRoleAuthentication " +
                "implementation may need to be updated as well.  Once they have been checked, and necessary updates have " +
                "been made, replace the value of expectedHash in this test with " + actualHash);
        }
    }
}
