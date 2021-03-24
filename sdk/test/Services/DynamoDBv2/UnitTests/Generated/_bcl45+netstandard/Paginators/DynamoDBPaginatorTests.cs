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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
 */

using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class DynamoDBPaginatorTests
    {
        private static Mock<AmazonDynamoDBClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonDynamoDBClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DynamoDBv2")]
        public void BatchGetItemTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<BatchGetItemRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<BatchGetItemResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<BatchGetItemResponse>();
            secondResponse.UnprocessedKeys.Clear();

            _mockClient.SetupSequence(x => x.BatchGetItem(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.BatchGetItem(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DynamoDBv2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void BatchGetItemTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<BatchGetItemRequest>();

            var response = InstantiateClassGenerator.Execute<BatchGetItemResponse>();
            response.UnprocessedKeys.Clear();

            _mockClient.Setup(x => x.BatchGetItem(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.BatchGetItem(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DynamoDBv2")]
        public void ListTablesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTablesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTablesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTablesResponse>();
            secondResponse.LastEvaluatedTableName = null;

            _mockClient.SetupSequence(x => x.ListTables(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTables(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DynamoDBv2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTablesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTablesRequest>();

            var response = InstantiateClassGenerator.Execute<ListTablesResponse>();
            response.LastEvaluatedTableName = null;

            _mockClient.Setup(x => x.ListTables(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTables(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DynamoDBv2")]
        public void QueryTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<QueryRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<QueryResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<QueryResponse>();
            secondResponse.LastEvaluatedKey.Clear();

            _mockClient.SetupSequence(x => x.Query(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.Query(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DynamoDBv2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void QueryTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<QueryRequest>();

            var response = InstantiateClassGenerator.Execute<QueryResponse>();
            response.LastEvaluatedKey.Clear();

            _mockClient.Setup(x => x.Query(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.Query(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DynamoDBv2")]
        public void ScanTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ScanRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ScanResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ScanResponse>();
            secondResponse.LastEvaluatedKey.Clear();

            _mockClient.SetupSequence(x => x.Scan(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.Scan(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DynamoDBv2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ScanTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ScanRequest>();

            var response = InstantiateClassGenerator.Execute<ScanResponse>();
            response.LastEvaluatedKey.Clear();

            _mockClient.Setup(x => x.Scan(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.Scan(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}