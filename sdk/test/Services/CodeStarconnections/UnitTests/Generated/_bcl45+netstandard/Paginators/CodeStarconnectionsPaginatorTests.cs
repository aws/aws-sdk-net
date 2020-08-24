#if !NETSTANDARD13
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
 * Do not modify this file. This file is generated from the codestar-connections-2019-12-01.normal.json service model.
 */

using Amazon.CodeStarconnections;
using Amazon.CodeStarconnections.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class CodeStarconnectionsPaginatorTests
    {
        private static Mock<AmazonCodeStarconnectionsClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonCodeStarconnectionsClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeStarconnections")]
        public void ListConnectionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListConnectionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListConnectionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListConnectionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListConnections(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListConnections(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeStarconnections")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListConnectionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListConnectionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListConnectionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListConnections(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListConnections(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeStarconnections")]
        public void ListHostsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListHostsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListHostsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListHostsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListHosts(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListHosts(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeStarconnections")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListHostsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListHostsRequest>();

            var response = InstantiateClassGenerator.Execute<ListHostsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListHosts(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListHosts(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif