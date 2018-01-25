/*
 * Copyright 2018 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class InstanceProfileAWSCredentialsTest
    {
        [TestMethod]
        public void TestNullRole()
        {
            AssertExtensions.ExpectException(() =>
            {
                var creds = new InstanceProfileAWSCredentials(null);
            }, typeof(ArgumentNullException), "Value cannot be null." + Environment.NewLine + "Parameter name: role");
        }

        [TestMethod]
        public void TestEmptyRole()
        {
            AssertExtensions.ExpectException(() =>
            {
                var creds = new InstanceProfileAWSCredentials(String.Empty);
            }, typeof(ArgumentException), "The argument 'role' must contain a valid role name.");
        }

        [TestMethod]
        public void TestWhitespaceRole()
        {
            AssertExtensions.ExpectException(() =>
            {
                var creds = new InstanceProfileAWSCredentials(" ");
            }, typeof(ArgumentException), "The argument 'role' must contain a valid role name.");
            
        }
    }
}
