/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.KeyManagementService.Model;
using Amazon.KeyManagementService;

namespace AWSSDK_DotNet35.UnitTests.TestTools
{
    [TestClass]
    public class KeyManagementServiceMethodCustomizationsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleMethods"), TestCategory("KeyManagementService")]
        public void KeyManagementServiceSimpleMethodTests()
        {
            EnsureSimpleMethodExists(typeof(Amazon.KeyManagementService.AmazonKeyManagementServiceClient), "CancelKeyDeletion", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.KeyManagementService.AmazonKeyManagementServiceClient), "CreateAlias", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.KeyManagementService.AmazonKeyManagementServiceClient), "DeleteAlias", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.KeyManagementService.AmazonKeyManagementServiceClient), "DescribeKey", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.KeyManagementService.AmazonKeyManagementServiceClient), "DisableKey", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.KeyManagementService.AmazonKeyManagementServiceClient), "DisableKeyRotation", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.KeyManagementService.AmazonKeyManagementServiceClient), "EnableKey", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.KeyManagementService.AmazonKeyManagementServiceClient), "EnableKeyRotation", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.KeyManagementService.AmazonKeyManagementServiceClient), "GenerateRandom", new Type[] { typeof(int), });
            EnsureSimpleMethodExists(typeof(Amazon.KeyManagementService.AmazonKeyManagementServiceClient), "GetKeyPolicy", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.KeyManagementService.AmazonKeyManagementServiceClient), "GetKeyRotationStatus", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.KeyManagementService.AmazonKeyManagementServiceClient), "ListRetirableGrants", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.KeyManagementService.AmazonKeyManagementServiceClient), "ListRetirableGrants", new Type[] { });
            EnsureSimpleMethodExists(typeof(Amazon.KeyManagementService.AmazonKeyManagementServiceClient), "PutKeyPolicy", new Type[] { typeof(string), typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.KeyManagementService.AmazonKeyManagementServiceClient), "RetireGrant", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.KeyManagementService.AmazonKeyManagementServiceClient), "RevokeGrant", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.KeyManagementService.AmazonKeyManagementServiceClient), "ScheduleKeyDeletion", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.KeyManagementService.AmazonKeyManagementServiceClient), "ScheduleKeyDeletion", new Type[] { typeof(string), typeof(int), });
            EnsureSimpleMethodExists(typeof(Amazon.KeyManagementService.AmazonKeyManagementServiceClient), "UpdateAlias", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.KeyManagementService.AmazonKeyManagementServiceClient), "UpdateKeyDescription", new Type[] { typeof(string), typeof(string), });
        }
        
        void EnsureSimpleMethodExists(Type type, string methodName, Type[] simpleParams)
        {
            Assert.IsNotNull(type.GetMethod(methodName, simpleParams), "Failed to find simple method " + methodName);
        }
    }
}