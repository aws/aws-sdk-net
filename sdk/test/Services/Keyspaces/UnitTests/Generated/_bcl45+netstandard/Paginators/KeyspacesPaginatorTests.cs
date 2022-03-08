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
 * Do not modify this file. This file is generated from the keyspaces-2022-02-10.normal.json service model.
 */

using Amazon.Keyspaces;
using Amazon.Keyspaces.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class KeyspacesPaginatorTests
    {
        private static Mock<AmazonKeyspacesClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonKeyspacesClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Keyspaces")]
        public void ListKeyspacesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListKeyspacesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListKeyspacesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListKeyspacesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListKeyspaces(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListKeyspaces(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Keyspaces")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListKeyspacesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListKeyspacesRequest>();

            var response = InstantiateClassGenerator.Execute<ListKeyspacesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListKeyspaces(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListKeyspaces(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Keyspaces")]
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
        [TestCategory("Keyspaces")]
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
        [TestCategory("Keyspaces")]
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
        [TestCategory("Keyspaces")]
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

    }
}