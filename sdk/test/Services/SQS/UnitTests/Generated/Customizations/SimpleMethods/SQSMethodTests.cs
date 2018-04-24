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
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.SQS.Model;
using Amazon.SQS;

namespace AWSSDK_DotNet35.UnitTests.TestTools
{
    [TestClass]
    public class SQSMethodCustomizationsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleMethods"), TestCategory("SQS")]
        public void SQSSimpleMethodTests()
        {
            EnsureSimpleMethodExists(typeof(Amazon.SQS.AmazonSQSClient), "AddPermission", new Type[] { typeof(string), typeof(string), typeof(List<string>), typeof(List<string>), });
            EnsureSimpleMethodExists(typeof(Amazon.SQS.AmazonSQSClient), "ChangeMessageVisibility", new Type[] { typeof(string), typeof(string), typeof(int), });
            EnsureSimpleMethodExists(typeof(Amazon.SQS.AmazonSQSClient), "ChangeMessageVisibilityBatch", new Type[] { typeof(string), typeof(List<ChangeMessageVisibilityBatchRequestEntry>), });
            EnsureSimpleMethodExists(typeof(Amazon.SQS.AmazonSQSClient), "CreateQueue", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.SQS.AmazonSQSClient), "DeleteMessage", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.SQS.AmazonSQSClient), "DeleteMessageBatch", new Type[] { typeof(string), typeof(List<DeleteMessageBatchRequestEntry>), });
            EnsureSimpleMethodExists(typeof(Amazon.SQS.AmazonSQSClient), "DeleteQueue", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.SQS.AmazonSQSClient), "GetQueueAttributes", new Type[] { typeof(string), typeof(List<string>), });
            EnsureSimpleMethodExists(typeof(Amazon.SQS.AmazonSQSClient), "GetQueueUrl", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.SQS.AmazonSQSClient), "ListQueues", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.SQS.AmazonSQSClient), "PurgeQueue", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.SQS.AmazonSQSClient), "ReceiveMessage", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.SQS.AmazonSQSClient), "RemovePermission", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.SQS.AmazonSQSClient), "SendMessage", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.SQS.AmazonSQSClient), "SendMessageBatch", new Type[] { typeof(string), typeof(List<SendMessageBatchRequestEntry>), });
            EnsureSimpleMethodExists(typeof(Amazon.SQS.AmazonSQSClient), "SetQueueAttributes", new Type[] { typeof(string), typeof(Dictionary<string, string>), });
        }
        
        void EnsureSimpleMethodExists(Type type, string methodName, Type[] simpleParams)
        {
            Assert.IsNotNull(type.GetMethod(methodName, simpleParams), "Failed to find simple method " + methodName);
        }
    }
}