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
 * Do not modify this file. This file is generated from the schemas-2019-12-02.normal.json service model.
 */

using Amazon.Schemas;
using Amazon.Schemas.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class SchemasPaginatorTests
    {
        private static Mock<AmazonSchemasClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonSchemasClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Schemas")]
        public void ListDiscoverersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDiscoverersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDiscoverersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDiscoverersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDiscoverers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDiscoverers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Schemas")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDiscoverersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDiscoverersRequest>();

            var response = InstantiateClassGenerator.Execute<ListDiscoverersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDiscoverers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDiscoverers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Schemas")]
        public void ListRegistriesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListRegistriesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListRegistriesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListRegistriesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListRegistries(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListRegistries(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Schemas")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListRegistriesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListRegistriesRequest>();

            var response = InstantiateClassGenerator.Execute<ListRegistriesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListRegistries(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListRegistries(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Schemas")]
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
        [TestCategory("Schemas")]
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
        [TestCategory("Schemas")]
        public void ListSchemaVersionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSchemaVersionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSchemaVersionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSchemaVersionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSchemaVersions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSchemaVersions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Schemas")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSchemaVersionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSchemaVersionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListSchemaVersionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSchemaVersions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSchemaVersions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Schemas")]
        public void SearchSchemasTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<SearchSchemasRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<SearchSchemasResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<SearchSchemasResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.SearchSchemas(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.SearchSchemas(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Schemas")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void SearchSchemasTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<SearchSchemasRequest>();

            var response = InstantiateClassGenerator.Execute<SearchSchemasResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.SearchSchemas(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.SearchSchemas(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}