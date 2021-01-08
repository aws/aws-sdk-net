#if !NETSTANDARD13
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

/*
 * Do not modify this file. This file is generated from the sqs-2012-11-05.normal.json service model.
 */

using Amazon.SQS;
using Amazon.SQS.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class SQSPaginatorTests
    {
        private static Mock<AmazonSQSClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonSQSClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SQS")]
        public void ListDeadLetterSourceQueuesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDeadLetterSourceQueuesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDeadLetterSourceQueuesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDeadLetterSourceQueuesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDeadLetterSourceQueues(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDeadLetterSourceQueues(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SQS")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDeadLetterSourceQueuesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDeadLetterSourceQueuesRequest>();

            var response = InstantiateClassGenerator.Execute<ListDeadLetterSourceQueuesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDeadLetterSourceQueues(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDeadLetterSourceQueues(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SQS")]
        public void ListQueuesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListQueuesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListQueuesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListQueuesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListQueues(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListQueues(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SQS")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListQueuesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListQueuesRequest>();

            var response = InstantiateClassGenerator.Execute<ListQueuesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListQueues(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListQueues(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif