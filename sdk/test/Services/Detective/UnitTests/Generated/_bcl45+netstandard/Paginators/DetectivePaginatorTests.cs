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
 * Do not modify this file. This file is generated from the detective-2018-10-26.normal.json service model.
 */

using Amazon.Detective;
using Amazon.Detective.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class DetectivePaginatorTests
    {
        private static Mock<AmazonDetectiveClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonDetectiveClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Detective")]
        public void ListGraphsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListGraphsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListGraphsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListGraphsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListGraphs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListGraphs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Detective")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListGraphsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListGraphsRequest>();

            var response = InstantiateClassGenerator.Execute<ListGraphsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListGraphs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListGraphs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Detective")]
        public void ListInvitationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListInvitationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListInvitationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListInvitationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListInvitations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListInvitations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Detective")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListInvitationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListInvitationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListInvitationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListInvitations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListInvitations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Detective")]
        public void ListMembersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListMembersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListMembersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListMembersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListMembers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListMembers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Detective")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListMembersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListMembersRequest>();

            var response = InstantiateClassGenerator.Execute<ListMembersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListMembers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListMembers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif