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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */

using Amazon.AlexaForBusiness;
using Amazon.AlexaForBusiness.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class AlexaForBusinessPaginatorTests
    {
        private static Mock<AmazonAlexaForBusinessClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonAlexaForBusinessClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AlexaForBusiness")]
        public void ListBusinessReportSchedulesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListBusinessReportSchedulesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListBusinessReportSchedulesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListBusinessReportSchedulesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListBusinessReportSchedules(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListBusinessReportSchedules(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AlexaForBusiness")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListBusinessReportSchedulesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListBusinessReportSchedulesRequest>();

            var response = InstantiateClassGenerator.Execute<ListBusinessReportSchedulesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListBusinessReportSchedules(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListBusinessReportSchedules(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AlexaForBusiness")]
        public void ListConferenceProvidersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListConferenceProvidersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListConferenceProvidersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListConferenceProvidersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListConferenceProviders(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListConferenceProviders(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AlexaForBusiness")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListConferenceProvidersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListConferenceProvidersRequest>();

            var response = InstantiateClassGenerator.Execute<ListConferenceProvidersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListConferenceProviders(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListConferenceProviders(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AlexaForBusiness")]
        public void ListDeviceEventsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDeviceEventsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDeviceEventsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDeviceEventsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDeviceEvents(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDeviceEvents(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AlexaForBusiness")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDeviceEventsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDeviceEventsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDeviceEventsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDeviceEvents(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDeviceEvents(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AlexaForBusiness")]
        public void ListGatewayGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListGatewayGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListGatewayGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListGatewayGroupsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListGatewayGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListGatewayGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AlexaForBusiness")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListGatewayGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListGatewayGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<ListGatewayGroupsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListGatewayGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListGatewayGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AlexaForBusiness")]
        public void ListGatewaysTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListGatewaysRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListGatewaysResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListGatewaysResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListGateways(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListGateways(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AlexaForBusiness")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListGatewaysTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListGatewaysRequest>();

            var response = InstantiateClassGenerator.Execute<ListGatewaysResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListGateways(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListGateways(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AlexaForBusiness")]
        public void ListSkillsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSkillsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSkillsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSkillsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSkills(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSkills(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AlexaForBusiness")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSkillsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSkillsRequest>();

            var response = InstantiateClassGenerator.Execute<ListSkillsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSkills(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSkills(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AlexaForBusiness")]
        public void ListSkillsStoreCategoriesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSkillsStoreCategoriesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSkillsStoreCategoriesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSkillsStoreCategoriesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSkillsStoreCategories(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSkillsStoreCategories(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AlexaForBusiness")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSkillsStoreCategoriesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSkillsStoreCategoriesRequest>();

            var response = InstantiateClassGenerator.Execute<ListSkillsStoreCategoriesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSkillsStoreCategories(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSkillsStoreCategories(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AlexaForBusiness")]
        public void ListSkillsStoreSkillsByCategoryTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSkillsStoreSkillsByCategoryRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSkillsStoreSkillsByCategoryResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSkillsStoreSkillsByCategoryResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSkillsStoreSkillsByCategory(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSkillsStoreSkillsByCategory(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AlexaForBusiness")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSkillsStoreSkillsByCategoryTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSkillsStoreSkillsByCategoryRequest>();

            var response = InstantiateClassGenerator.Execute<ListSkillsStoreSkillsByCategoryResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSkillsStoreSkillsByCategory(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSkillsStoreSkillsByCategory(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AlexaForBusiness")]
        public void ListSmartHomeAppliancesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSmartHomeAppliancesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSmartHomeAppliancesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSmartHomeAppliancesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSmartHomeAppliances(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSmartHomeAppliances(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AlexaForBusiness")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSmartHomeAppliancesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSmartHomeAppliancesRequest>();

            var response = InstantiateClassGenerator.Execute<ListSmartHomeAppliancesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSmartHomeAppliances(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSmartHomeAppliances(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AlexaForBusiness")]
        public void ListTagsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTagsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTagsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTagsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTags(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTags(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AlexaForBusiness")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTagsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTagsRequest>();

            var response = InstantiateClassGenerator.Execute<ListTagsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTags(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTags(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AlexaForBusiness")]
        public void SearchAddressBooksTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<SearchAddressBooksRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<SearchAddressBooksResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<SearchAddressBooksResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.SearchAddressBooks(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.SearchAddressBooks(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AlexaForBusiness")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void SearchAddressBooksTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<SearchAddressBooksRequest>();

            var response = InstantiateClassGenerator.Execute<SearchAddressBooksResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.SearchAddressBooks(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.SearchAddressBooks(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AlexaForBusiness")]
        public void SearchContactsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<SearchContactsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<SearchContactsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<SearchContactsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.SearchContacts(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.SearchContacts(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AlexaForBusiness")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void SearchContactsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<SearchContactsRequest>();

            var response = InstantiateClassGenerator.Execute<SearchContactsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.SearchContacts(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.SearchContacts(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AlexaForBusiness")]
        public void SearchDevicesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<SearchDevicesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<SearchDevicesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<SearchDevicesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.SearchDevices(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.SearchDevices(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AlexaForBusiness")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void SearchDevicesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<SearchDevicesRequest>();

            var response = InstantiateClassGenerator.Execute<SearchDevicesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.SearchDevices(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.SearchDevices(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AlexaForBusiness")]
        public void SearchNetworkProfilesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<SearchNetworkProfilesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<SearchNetworkProfilesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<SearchNetworkProfilesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.SearchNetworkProfiles(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.SearchNetworkProfiles(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AlexaForBusiness")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void SearchNetworkProfilesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<SearchNetworkProfilesRequest>();

            var response = InstantiateClassGenerator.Execute<SearchNetworkProfilesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.SearchNetworkProfiles(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.SearchNetworkProfiles(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AlexaForBusiness")]
        public void SearchProfilesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<SearchProfilesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<SearchProfilesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<SearchProfilesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.SearchProfiles(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.SearchProfiles(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AlexaForBusiness")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void SearchProfilesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<SearchProfilesRequest>();

            var response = InstantiateClassGenerator.Execute<SearchProfilesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.SearchProfiles(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.SearchProfiles(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AlexaForBusiness")]
        public void SearchRoomsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<SearchRoomsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<SearchRoomsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<SearchRoomsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.SearchRooms(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.SearchRooms(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AlexaForBusiness")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void SearchRoomsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<SearchRoomsRequest>();

            var response = InstantiateClassGenerator.Execute<SearchRoomsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.SearchRooms(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.SearchRooms(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AlexaForBusiness")]
        public void SearchSkillGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<SearchSkillGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<SearchSkillGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<SearchSkillGroupsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.SearchSkillGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.SearchSkillGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AlexaForBusiness")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void SearchSkillGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<SearchSkillGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<SearchSkillGroupsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.SearchSkillGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.SearchSkillGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AlexaForBusiness")]
        public void SearchUsersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<SearchUsersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<SearchUsersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<SearchUsersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.SearchUsers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.SearchUsers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AlexaForBusiness")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void SearchUsersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<SearchUsersRequest>();

            var response = InstantiateClassGenerator.Execute<SearchUsersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.SearchUsers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.SearchUsers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif