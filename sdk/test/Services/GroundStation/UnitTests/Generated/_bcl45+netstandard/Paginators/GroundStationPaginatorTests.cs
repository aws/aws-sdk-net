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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
 */

using Amazon.GroundStation;
using Amazon.GroundStation.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class GroundStationPaginatorTests
    {
        private static Mock<AmazonGroundStationClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonGroundStationClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GroundStation")]
        public void ListConfigsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListConfigsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListConfigsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListConfigsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListConfigs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListConfigs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GroundStation")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListConfigsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListConfigsRequest>();

            var response = InstantiateClassGenerator.Execute<ListConfigsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListConfigs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListConfigs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GroundStation")]
        public void ListContactsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListContactsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListContactsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListContactsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListContacts(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListContacts(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GroundStation")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListContactsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListContactsRequest>();

            var response = InstantiateClassGenerator.Execute<ListContactsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListContacts(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListContacts(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GroundStation")]
        public void ListDataflowEndpointGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDataflowEndpointGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDataflowEndpointGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDataflowEndpointGroupsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDataflowEndpointGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDataflowEndpointGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GroundStation")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDataflowEndpointGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDataflowEndpointGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDataflowEndpointGroupsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDataflowEndpointGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDataflowEndpointGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GroundStation")]
        public void ListGroundStationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListGroundStationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListGroundStationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListGroundStationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListGroundStations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListGroundStations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GroundStation")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListGroundStationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListGroundStationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListGroundStationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListGroundStations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListGroundStations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GroundStation")]
        public void ListMissionProfilesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListMissionProfilesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListMissionProfilesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListMissionProfilesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListMissionProfiles(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListMissionProfiles(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GroundStation")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListMissionProfilesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListMissionProfilesRequest>();

            var response = InstantiateClassGenerator.Execute<ListMissionProfilesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListMissionProfiles(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListMissionProfiles(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GroundStation")]
        public void ListSatellitesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSatellitesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSatellitesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSatellitesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSatellites(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSatellites(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GroundStation")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSatellitesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSatellitesRequest>();

            var response = InstantiateClassGenerator.Execute<ListSatellitesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSatellites(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSatellites(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif