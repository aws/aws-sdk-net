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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
 */

using Amazon.Athena;
using Amazon.Athena.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class AthenaPaginatorTests
    {
        private static Mock<AmazonAthenaClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonAthenaClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Athena")]
        public void GetQueryResultsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetQueryResultsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetQueryResultsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetQueryResultsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetQueryResults(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetQueryResults(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Athena")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetQueryResultsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetQueryResultsRequest>();

            var response = InstantiateClassGenerator.Execute<GetQueryResultsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetQueryResults(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetQueryResults(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Athena")]
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
        [TestCategory("Athena")]
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
        [TestCategory("Athena")]
        public void ListDataCatalogsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDataCatalogsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDataCatalogsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDataCatalogsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDataCatalogs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDataCatalogs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Athena")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDataCatalogsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDataCatalogsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDataCatalogsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDataCatalogs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDataCatalogs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Athena")]
        public void ListNamedQueriesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListNamedQueriesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListNamedQueriesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListNamedQueriesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListNamedQueries(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListNamedQueries(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Athena")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListNamedQueriesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListNamedQueriesRequest>();

            var response = InstantiateClassGenerator.Execute<ListNamedQueriesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListNamedQueries(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListNamedQueries(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Athena")]
        public void ListQueryExecutionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListQueryExecutionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListQueryExecutionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListQueryExecutionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListQueryExecutions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListQueryExecutions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Athena")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListQueryExecutionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListQueryExecutionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListQueryExecutionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListQueryExecutions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListQueryExecutions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Athena")]
        public void ListTableMetadataTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTableMetadataRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTableMetadataResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTableMetadataResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTableMetadata(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTableMetadata(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Athena")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTableMetadataTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTableMetadataRequest>();

            var response = InstantiateClassGenerator.Execute<ListTableMetadataResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTableMetadata(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTableMetadata(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Athena")]
        public void ListTagsForResourceTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTagsForResourceResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTagsForResourceResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTagsForResource(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTagsForResource(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Athena")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTagsForResourceTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();

            var response = InstantiateClassGenerator.Execute<ListTagsForResourceResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTagsForResource(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTagsForResource(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Athena")]
        public void ListWorkGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListWorkGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListWorkGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListWorkGroupsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListWorkGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListWorkGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Athena")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListWorkGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListWorkGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<ListWorkGroupsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListWorkGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListWorkGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif