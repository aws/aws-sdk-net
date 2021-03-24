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
 * Do not modify this file. This file is generated from the redshift-data-2019-12-20.normal.json service model.
 */

using Amazon.RedshiftDataAPIService;
using Amazon.RedshiftDataAPIService.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class RedshiftDataAPIServicePaginatorTests
    {
        private static Mock<AmazonRedshiftDataAPIServiceClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonRedshiftDataAPIServiceClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RedshiftDataAPIService")]
        public void DescribeTableTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTableRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeTableResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeTableResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeTable(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeTable(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RedshiftDataAPIService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeTableTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTableRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeTableResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeTable(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeTable(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RedshiftDataAPIService")]
        public void GetStatementResultTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetStatementResultRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetStatementResultResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetStatementResultResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetStatementResult(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetStatementResult(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RedshiftDataAPIService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetStatementResultTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetStatementResultRequest>();

            var response = InstantiateClassGenerator.Execute<GetStatementResultResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetStatementResult(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetStatementResult(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RedshiftDataAPIService")]
        public void ListDatabasesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDatabasesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDatabasesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDatabasesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDatabases(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDatabases(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RedshiftDataAPIService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDatabasesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDatabasesRequest>();

            var response = InstantiateClassGenerator.Execute<ListDatabasesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDatabases(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDatabases(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RedshiftDataAPIService")]
        public void ListSchemasTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSchemasRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSchemasResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSchemasResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSchemas(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSchemas(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RedshiftDataAPIService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSchemasTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSchemasRequest>();

            var response = InstantiateClassGenerator.Execute<ListSchemasResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSchemas(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSchemas(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RedshiftDataAPIService")]
        public void ListStatementsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListStatementsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListStatementsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListStatementsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListStatements(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListStatements(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RedshiftDataAPIService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListStatementsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListStatementsRequest>();

            var response = InstantiateClassGenerator.Execute<ListStatementsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListStatements(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListStatements(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RedshiftDataAPIService")]
        public void ListTablesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTablesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTablesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTablesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTables(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTables(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RedshiftDataAPIService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTablesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTablesRequest>();

            var response = InstantiateClassGenerator.Execute<ListTablesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTables(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTables(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}