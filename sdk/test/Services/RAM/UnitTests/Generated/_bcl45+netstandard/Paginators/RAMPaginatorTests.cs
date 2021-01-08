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
 * Do not modify this file. This file is generated from the ram-2018-01-04.normal.json service model.
 */

using Amazon.RAM;
using Amazon.RAM.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class RAMPaginatorTests
    {
        private static Mock<AmazonRAMClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonRAMClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RAM")]
        public void GetResourcePoliciesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetResourcePoliciesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetResourcePoliciesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetResourcePoliciesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetResourcePolicies(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetResourcePolicies(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RAM")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetResourcePoliciesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetResourcePoliciesRequest>();

            var response = InstantiateClassGenerator.Execute<GetResourcePoliciesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetResourcePolicies(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetResourcePolicies(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RAM")]
        public void GetResourceShareAssociationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetResourceShareAssociationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetResourceShareAssociationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetResourceShareAssociationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetResourceShareAssociations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetResourceShareAssociations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RAM")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetResourceShareAssociationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetResourceShareAssociationsRequest>();

            var response = InstantiateClassGenerator.Execute<GetResourceShareAssociationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetResourceShareAssociations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetResourceShareAssociations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RAM")]
        public void GetResourceShareInvitationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetResourceShareInvitationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetResourceShareInvitationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetResourceShareInvitationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetResourceShareInvitations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetResourceShareInvitations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RAM")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetResourceShareInvitationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetResourceShareInvitationsRequest>();

            var response = InstantiateClassGenerator.Execute<GetResourceShareInvitationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetResourceShareInvitations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetResourceShareInvitations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RAM")]
        public void GetResourceSharesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetResourceSharesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetResourceSharesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetResourceSharesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetResourceShares(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetResourceShares(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RAM")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetResourceSharesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetResourceSharesRequest>();

            var response = InstantiateClassGenerator.Execute<GetResourceSharesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetResourceShares(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetResourceShares(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RAM")]
        public void ListPendingInvitationResourcesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPendingInvitationResourcesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPendingInvitationResourcesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPendingInvitationResourcesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPendingInvitationResources(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPendingInvitationResources(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RAM")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPendingInvitationResourcesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPendingInvitationResourcesRequest>();

            var response = InstantiateClassGenerator.Execute<ListPendingInvitationResourcesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPendingInvitationResources(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPendingInvitationResources(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RAM")]
        public void ListPrincipalsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPrincipalsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPrincipalsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPrincipalsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPrincipals(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPrincipals(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RAM")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPrincipalsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPrincipalsRequest>();

            var response = InstantiateClassGenerator.Execute<ListPrincipalsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPrincipals(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPrincipals(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RAM")]
        public void ListResourcesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListResourcesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListResourcesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListResourcesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListResources(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListResources(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RAM")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListResourcesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListResourcesRequest>();

            var response = InstantiateClassGenerator.Execute<ListResourcesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListResources(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListResources(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif