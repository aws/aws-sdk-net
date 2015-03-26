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
 * Do not modify this file. This file is generated from the sns-2010-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.SimpleNotificationService.Model;
using Amazon.SimpleNotificationService;

namespace AWSSDK_DotNet35.UnitTests.TestTools
{
    [TestClass]
    public class SimpleNotificationServiceMethodCustomizationsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleMethods"), TestCategory("SimpleNotificationService")]
        public void SimpleNotificationServiceSimpleMethodTests()
        {
            EnsureSimpleMethodExists(typeof(Amazon.SimpleNotificationService.AmazonSimpleNotificationServiceClient), "AddPermission", new Type[] { typeof(string), typeof(string), typeof(List<string>), typeof(List<string>), });
            EnsureSimpleMethodExists(typeof(Amazon.SimpleNotificationService.AmazonSimpleNotificationServiceClient), "ConfirmSubscription", new Type[] { typeof(string), typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.SimpleNotificationService.AmazonSimpleNotificationServiceClient), "ConfirmSubscription", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.SimpleNotificationService.AmazonSimpleNotificationServiceClient), "CreateTopic", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.SimpleNotificationService.AmazonSimpleNotificationServiceClient), "DeleteTopic", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.SimpleNotificationService.AmazonSimpleNotificationServiceClient), "GetSubscriptionAttributes", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.SimpleNotificationService.AmazonSimpleNotificationServiceClient), "GetTopicAttributes", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.SimpleNotificationService.AmazonSimpleNotificationServiceClient), "ListSubscriptions", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.SimpleNotificationService.AmazonSimpleNotificationServiceClient), "ListSubscriptionsByTopic", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.SimpleNotificationService.AmazonSimpleNotificationServiceClient), "ListSubscriptionsByTopic", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.SimpleNotificationService.AmazonSimpleNotificationServiceClient), "ListTopics", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.SimpleNotificationService.AmazonSimpleNotificationServiceClient), "Publish", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.SimpleNotificationService.AmazonSimpleNotificationServiceClient), "Publish", new Type[] { typeof(string), typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.SimpleNotificationService.AmazonSimpleNotificationServiceClient), "RemovePermission", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.SimpleNotificationService.AmazonSimpleNotificationServiceClient), "SetSubscriptionAttributes", new Type[] { typeof(string), typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.SimpleNotificationService.AmazonSimpleNotificationServiceClient), "SetTopicAttributes", new Type[] { typeof(string), typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.SimpleNotificationService.AmazonSimpleNotificationServiceClient), "Subscribe", new Type[] { typeof(string), typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.SimpleNotificationService.AmazonSimpleNotificationServiceClient), "Unsubscribe", new Type[] { typeof(string), });
        }
        
        void EnsureSimpleMethodExists(Type type, string methodName, Type[] simpleParams)
        {
            Assert.IsNotNull(type.GetMethod(methodName, simpleParams), "Failed to find simple method " + methodName);
        }
    }
}