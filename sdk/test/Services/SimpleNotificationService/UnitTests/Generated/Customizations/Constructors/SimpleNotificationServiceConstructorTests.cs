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
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;

namespace AWSSDK_DotNet35.UnitTests.TestTools
{
    [TestClass]
    public class SimpleNotificationServiceConstructorCustomizationsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SimpleNotificationService")]
        public void AddPermissionRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SimpleNotificationService.Model.AddPermissionRequest), new System.Type[] { typeof(string), typeof(string), typeof(List<string>), typeof(List<string>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SimpleNotificationService")]
        public void ConfirmSubscriptionRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SimpleNotificationService.Model.ConfirmSubscriptionRequest), new System.Type[] { typeof(string), typeof(string), });
            EnsureConstructorExists(typeof(Amazon.SimpleNotificationService.Model.ConfirmSubscriptionRequest), new System.Type[] { typeof(string), typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SimpleNotificationService")]
        public void CreateTopicRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SimpleNotificationService.Model.CreateTopicRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SimpleNotificationService")]
        public void DeleteTopicRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SimpleNotificationService.Model.DeleteTopicRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SimpleNotificationService")]
        public void GetSubscriptionAttributesRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SimpleNotificationService.Model.GetSubscriptionAttributesRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SimpleNotificationService")]
        public void GetTopicAttributesRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SimpleNotificationService.Model.GetTopicAttributesRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SimpleNotificationService")]
        public void ListSubscriptionsRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SimpleNotificationService.Model.ListSubscriptionsRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SimpleNotificationService")]
        public void ListSubscriptionsByTopicRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SimpleNotificationService.Model.ListSubscriptionsByTopicRequest), new System.Type[] { typeof(string), });
            EnsureConstructorExists(typeof(Amazon.SimpleNotificationService.Model.ListSubscriptionsByTopicRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SimpleNotificationService")]
        public void ListTopicsRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SimpleNotificationService.Model.ListTopicsRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SimpleNotificationService")]
        public void PublishRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SimpleNotificationService.Model.PublishRequest), new System.Type[] { typeof(string), typeof(string), });
            EnsureConstructorExists(typeof(Amazon.SimpleNotificationService.Model.PublishRequest), new System.Type[] { typeof(string), typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SimpleNotificationService")]
        public void RemovePermissionRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SimpleNotificationService.Model.RemovePermissionRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SimpleNotificationService")]
        public void SetSubscriptionAttributesRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SimpleNotificationService.Model.SetSubscriptionAttributesRequest), new System.Type[] { typeof(string), typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SimpleNotificationService")]
        public void SetTopicAttributesRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SimpleNotificationService.Model.SetTopicAttributesRequest), new System.Type[] { typeof(string), typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SimpleNotificationService")]
        public void SubscribeRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SimpleNotificationService.Model.SubscribeRequest), new System.Type[] { typeof(string), typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SimpleNotificationService")]
        public void UnsubscribeRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SimpleNotificationService.Model.UnsubscribeRequest), new System.Type[] { typeof(string), });
        }

        void EnsureConstructorExists(System.Type type, System.Type[] constructorParams)
        {
            Assert.IsNotNull(type.GetConstructor(constructorParams));
        }
    }
}