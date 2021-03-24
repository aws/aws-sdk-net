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
 * Do not modify this file. This file is generated from the managedblockchain-2018-09-24.normal.json service model.
 */

using Amazon.ManagedBlockchain;
using Amazon.ManagedBlockchain.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class ManagedBlockchainPaginatorTests
    {
        private static Mock<AmazonManagedBlockchainClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonManagedBlockchainClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ManagedBlockchain")]
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
        [TestCategory("ManagedBlockchain")]
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
        [TestCategory("ManagedBlockchain")]
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
        [TestCategory("ManagedBlockchain")]
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


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ManagedBlockchain")]
        public void ListNetworksTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListNetworksRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListNetworksResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListNetworksResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListNetworks(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListNetworks(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ManagedBlockchain")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListNetworksTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListNetworksRequest>();

            var response = InstantiateClassGenerator.Execute<ListNetworksResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListNetworks(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListNetworks(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ManagedBlockchain")]
        public void ListNodesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListNodesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListNodesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListNodesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListNodes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListNodes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ManagedBlockchain")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListNodesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListNodesRequest>();

            var response = InstantiateClassGenerator.Execute<ListNodesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListNodes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListNodes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ManagedBlockchain")]
        public void ListProposalsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListProposalsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListProposalsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListProposalsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListProposals(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListProposals(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ManagedBlockchain")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListProposalsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListProposalsRequest>();

            var response = InstantiateClassGenerator.Execute<ListProposalsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListProposals(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListProposals(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ManagedBlockchain")]
        public void ListProposalVotesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListProposalVotesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListProposalVotesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListProposalVotesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListProposalVotes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListProposalVotes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ManagedBlockchain")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListProposalVotesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListProposalVotesRequest>();

            var response = InstantiateClassGenerator.Execute<ListProposalVotesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListProposalVotes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListProposalVotes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}