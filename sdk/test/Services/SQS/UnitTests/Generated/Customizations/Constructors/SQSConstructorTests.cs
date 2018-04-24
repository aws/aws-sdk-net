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
 * Do not modify this file. This file is generated from the sqs-2012-11-05.normal.json service model.
 */
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.SQS;
using Amazon.SQS.Model;

namespace AWSSDK_DotNet35.UnitTests.TestTools
{
    [TestClass]
    public class SQSConstructorCustomizationsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SQS")]
        public void AddPermissionRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SQS.Model.AddPermissionRequest), new System.Type[] { typeof(string), typeof(string), typeof(List<string>), typeof(List<string>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SQS")]
        public void ChangeMessageVisibilityRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SQS.Model.ChangeMessageVisibilityRequest), new System.Type[] { typeof(string), typeof(string), typeof(int), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SQS")]
        public void ChangeMessageVisibilityBatchRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SQS.Model.ChangeMessageVisibilityBatchRequest), new System.Type[] { typeof(string), typeof(List<ChangeMessageVisibilityBatchRequestEntry>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SQS")]
        public void CreateQueueRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SQS.Model.CreateQueueRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SQS")]
        public void DeleteMessageRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SQS.Model.DeleteMessageRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SQS")]
        public void DeleteMessageBatchRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SQS.Model.DeleteMessageBatchRequest), new System.Type[] { typeof(string), typeof(List<DeleteMessageBatchRequestEntry>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SQS")]
        public void DeleteQueueRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SQS.Model.DeleteQueueRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SQS")]
        public void GetQueueAttributesRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SQS.Model.GetQueueAttributesRequest), new System.Type[] { typeof(string), typeof(List<string>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SQS")]
        public void GetQueueUrlRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SQS.Model.GetQueueUrlRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SQS")]
        public void ListQueuesRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SQS.Model.ListQueuesRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SQS")]
        public void ReceiveMessageRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SQS.Model.ReceiveMessageRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SQS")]
        public void RemovePermissionRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SQS.Model.RemovePermissionRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SQS")]
        public void SendMessageRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SQS.Model.SendMessageRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SQS")]
        public void SendMessageBatchRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SQS.Model.SendMessageBatchRequest), new System.Type[] { typeof(string), typeof(List<SendMessageBatchRequestEntry>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SQS")]
        public void SetQueueAttributesRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SQS.Model.SetQueueAttributesRequest), new System.Type[] { typeof(string), typeof(Dictionary<string, string>), });
        }

        void EnsureConstructorExists(System.Type type, System.Type[] constructorParams)
        {
            Assert.IsNotNull(type.GetConstructor(constructorParams));
        }
    }
}