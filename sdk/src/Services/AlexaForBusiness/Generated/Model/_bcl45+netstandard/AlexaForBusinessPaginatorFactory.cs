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

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.AlexaForBusiness.Model
{
    /// <summary>
    /// Paginators for the AlexaForBusiness service
    ///</summary>
    public class AlexaForBusinessPaginatorFactory : IAlexaForBusinessPaginatorFactory
    {
        private readonly IAmazonAlexaForBusiness client;

        internal AlexaForBusinessPaginatorFactory(IAmazonAlexaForBusiness client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListBusinessReportSchedules operation
        ///</summary>
        public IListBusinessReportSchedulesPaginator ListBusinessReportSchedules(ListBusinessReportSchedulesRequest request) 
        {
            return new ListBusinessReportSchedulesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListConferenceProviders operation
        ///</summary>
        public IListConferenceProvidersPaginator ListConferenceProviders(ListConferenceProvidersRequest request) 
        {
            return new ListConferenceProvidersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDeviceEvents operation
        ///</summary>
        public IListDeviceEventsPaginator ListDeviceEvents(ListDeviceEventsRequest request) 
        {
            return new ListDeviceEventsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListGatewayGroups operation
        ///</summary>
        public IListGatewayGroupsPaginator ListGatewayGroups(ListGatewayGroupsRequest request) 
        {
            return new ListGatewayGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListGateways operation
        ///</summary>
        public IListGatewaysPaginator ListGateways(ListGatewaysRequest request) 
        {
            return new ListGatewaysPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSkills operation
        ///</summary>
        public IListSkillsPaginator ListSkills(ListSkillsRequest request) 
        {
            return new ListSkillsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSkillsStoreCategories operation
        ///</summary>
        public IListSkillsStoreCategoriesPaginator ListSkillsStoreCategories(ListSkillsStoreCategoriesRequest request) 
        {
            return new ListSkillsStoreCategoriesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSkillsStoreSkillsByCategory operation
        ///</summary>
        public IListSkillsStoreSkillsByCategoryPaginator ListSkillsStoreSkillsByCategory(ListSkillsStoreSkillsByCategoryRequest request) 
        {
            return new ListSkillsStoreSkillsByCategoryPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSmartHomeAppliances operation
        ///</summary>
        public IListSmartHomeAppliancesPaginator ListSmartHomeAppliances(ListSmartHomeAppliancesRequest request) 
        {
            return new ListSmartHomeAppliancesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTags operation
        ///</summary>
        public IListTagsPaginator ListTags(ListTagsRequest request) 
        {
            return new ListTagsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchAddressBooks operation
        ///</summary>
        public ISearchAddressBooksPaginator SearchAddressBooks(SearchAddressBooksRequest request) 
        {
            return new SearchAddressBooksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchContacts operation
        ///</summary>
        public ISearchContactsPaginator SearchContacts(SearchContactsRequest request) 
        {
            return new SearchContactsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchDevices operation
        ///</summary>
        public ISearchDevicesPaginator SearchDevices(SearchDevicesRequest request) 
        {
            return new SearchDevicesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchNetworkProfiles operation
        ///</summary>
        public ISearchNetworkProfilesPaginator SearchNetworkProfiles(SearchNetworkProfilesRequest request) 
        {
            return new SearchNetworkProfilesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchProfiles operation
        ///</summary>
        public ISearchProfilesPaginator SearchProfiles(SearchProfilesRequest request) 
        {
            return new SearchProfilesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchRooms operation
        ///</summary>
        public ISearchRoomsPaginator SearchRooms(SearchRoomsRequest request) 
        {
            return new SearchRoomsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchSkillGroups operation
        ///</summary>
        public ISearchSkillGroupsPaginator SearchSkillGroups(SearchSkillGroupsRequest request) 
        {
            return new SearchSkillGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchUsers operation
        ///</summary>
        public ISearchUsersPaginator SearchUsers(SearchUsersRequest request) 
        {
            return new SearchUsersPaginator(this.client, request);
        }
    }
}
#endif