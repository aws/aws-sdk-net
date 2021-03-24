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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */

namespace Amazon.AlexaForBusiness.Model
{
    /// <summary>
    /// Paginators for the AlexaForBusiness service
    ///</summary>
    public interface IAlexaForBusinessPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListBusinessReportSchedules operation
        ///</summary>
        IListBusinessReportSchedulesPaginator ListBusinessReportSchedules(ListBusinessReportSchedulesRequest request);

        /// <summary>
        /// Paginator for ListConferenceProviders operation
        ///</summary>
        IListConferenceProvidersPaginator ListConferenceProviders(ListConferenceProvidersRequest request);

        /// <summary>
        /// Paginator for ListDeviceEvents operation
        ///</summary>
        IListDeviceEventsPaginator ListDeviceEvents(ListDeviceEventsRequest request);

        /// <summary>
        /// Paginator for ListGatewayGroups operation
        ///</summary>
        IListGatewayGroupsPaginator ListGatewayGroups(ListGatewayGroupsRequest request);

        /// <summary>
        /// Paginator for ListGateways operation
        ///</summary>
        IListGatewaysPaginator ListGateways(ListGatewaysRequest request);

        /// <summary>
        /// Paginator for ListSkills operation
        ///</summary>
        IListSkillsPaginator ListSkills(ListSkillsRequest request);

        /// <summary>
        /// Paginator for ListSkillsStoreCategories operation
        ///</summary>
        IListSkillsStoreCategoriesPaginator ListSkillsStoreCategories(ListSkillsStoreCategoriesRequest request);

        /// <summary>
        /// Paginator for ListSkillsStoreSkillsByCategory operation
        ///</summary>
        IListSkillsStoreSkillsByCategoryPaginator ListSkillsStoreSkillsByCategory(ListSkillsStoreSkillsByCategoryRequest request);

        /// <summary>
        /// Paginator for ListSmartHomeAppliances operation
        ///</summary>
        IListSmartHomeAppliancesPaginator ListSmartHomeAppliances(ListSmartHomeAppliancesRequest request);

        /// <summary>
        /// Paginator for ListTags operation
        ///</summary>
        IListTagsPaginator ListTags(ListTagsRequest request);

        /// <summary>
        /// Paginator for SearchAddressBooks operation
        ///</summary>
        ISearchAddressBooksPaginator SearchAddressBooks(SearchAddressBooksRequest request);

        /// <summary>
        /// Paginator for SearchContacts operation
        ///</summary>
        ISearchContactsPaginator SearchContacts(SearchContactsRequest request);

        /// <summary>
        /// Paginator for SearchDevices operation
        ///</summary>
        ISearchDevicesPaginator SearchDevices(SearchDevicesRequest request);

        /// <summary>
        /// Paginator for SearchNetworkProfiles operation
        ///</summary>
        ISearchNetworkProfilesPaginator SearchNetworkProfiles(SearchNetworkProfilesRequest request);

        /// <summary>
        /// Paginator for SearchProfiles operation
        ///</summary>
        ISearchProfilesPaginator SearchProfiles(SearchProfilesRequest request);

        /// <summary>
        /// Paginator for SearchRooms operation
        ///</summary>
        ISearchRoomsPaginator SearchRooms(SearchRoomsRequest request);

        /// <summary>
        /// Paginator for SearchSkillGroups operation
        ///</summary>
        ISearchSkillGroupsPaginator SearchSkillGroups(SearchSkillGroupsRequest request);

        /// <summary>
        /// Paginator for SearchUsers operation
        ///</summary>
        ISearchUsersPaginator SearchUsers(SearchUsersRequest request);
    }
}