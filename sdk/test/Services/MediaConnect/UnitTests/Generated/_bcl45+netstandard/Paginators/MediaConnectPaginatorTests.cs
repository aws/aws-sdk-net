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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
 */

using Amazon.MediaConnect;
using Amazon.MediaConnect.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class MediaConnectPaginatorTests
    {
        private static Mock<AmazonMediaConnectClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonMediaConnectClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaConnect")]
        public void ListEntitlementsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListEntitlementsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListEntitlementsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListEntitlementsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListEntitlements(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListEntitlements(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaConnect")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListEntitlementsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListEntitlementsRequest>();

            var response = InstantiateClassGenerator.Execute<ListEntitlementsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListEntitlements(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListEntitlements(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaConnect")]
        public void ListFlowsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListFlowsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListFlowsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListFlowsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListFlows(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListFlows(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaConnect")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListFlowsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListFlowsRequest>();

            var response = InstantiateClassGenerator.Execute<ListFlowsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListFlows(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListFlows(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaConnect")]
        public void ListOfferingsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListOfferingsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListOfferingsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListOfferingsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListOfferings(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListOfferings(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaConnect")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListOfferingsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListOfferingsRequest>();

            var response = InstantiateClassGenerator.Execute<ListOfferingsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListOfferings(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListOfferings(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaConnect")]
        public void ListReservationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListReservationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListReservationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListReservationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListReservations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListReservations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaConnect")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListReservationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListReservationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListReservationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListReservations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListReservations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif