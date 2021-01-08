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
 * Do not modify this file. This file is generated from the honeycode-2020-03-01.normal.json service model.
 */

using Amazon.Honeycode;
using Amazon.Honeycode.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class HoneycodePaginatorTests
    {
        private static Mock<AmazonHoneycodeClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonHoneycodeClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Honeycode")]
        public void ListTableColumnsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTableColumnsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTableColumnsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTableColumnsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTableColumns(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTableColumns(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Honeycode")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTableColumnsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTableColumnsRequest>();

            var response = InstantiateClassGenerator.Execute<ListTableColumnsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTableColumns(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTableColumns(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Honeycode")]
        public void ListTableRowsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTableRowsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTableRowsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTableRowsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTableRows(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTableRows(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Honeycode")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTableRowsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTableRowsRequest>();

            var response = InstantiateClassGenerator.Execute<ListTableRowsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTableRows(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTableRows(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Honeycode")]
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
        [TestCategory("Honeycode")]
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


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Honeycode")]
        public void QueryTableRowsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<QueryTableRowsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<QueryTableRowsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<QueryTableRowsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.QueryTableRows(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.QueryTableRows(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Honeycode")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void QueryTableRowsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<QueryTableRowsRequest>();

            var response = InstantiateClassGenerator.Execute<QueryTableRowsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.QueryTableRows(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.QueryTableRows(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif