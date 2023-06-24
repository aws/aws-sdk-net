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
 * Do not modify this file. This file is generated from the chime-sdk-voice-2022-08-03.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// Paginators for the ChimeSDKVoice service
    ///</summary>
    public class ChimeSDKVoicePaginatorFactory : IChimeSDKVoicePaginatorFactory
    {
        private readonly IAmazonChimeSDKVoice client;

        internal ChimeSDKVoicePaginatorFactory(IAmazonChimeSDKVoice client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListPhoneNumberOrders operation
        ///</summary>
        public IListPhoneNumberOrdersPaginator ListPhoneNumberOrders(ListPhoneNumberOrdersRequest request) 
        {
            return new ListPhoneNumberOrdersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPhoneNumbers operation
        ///</summary>
        public IListPhoneNumbersPaginator ListPhoneNumbers(ListPhoneNumbersRequest request) 
        {
            return new ListPhoneNumbersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProxySessions operation
        ///</summary>
        public IListProxySessionsPaginator ListProxySessions(ListProxySessionsRequest request) 
        {
            return new ListProxySessionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSipMediaApplications operation
        ///</summary>
        public IListSipMediaApplicationsPaginator ListSipMediaApplications(ListSipMediaApplicationsRequest request) 
        {
            return new ListSipMediaApplicationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSipRules operation
        ///</summary>
        public IListSipRulesPaginator ListSipRules(ListSipRulesRequest request) 
        {
            return new ListSipRulesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListVoiceConnectorGroups operation
        ///</summary>
        public IListVoiceConnectorGroupsPaginator ListVoiceConnectorGroups(ListVoiceConnectorGroupsRequest request) 
        {
            return new ListVoiceConnectorGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListVoiceConnectors operation
        ///</summary>
        public IListVoiceConnectorsPaginator ListVoiceConnectors(ListVoiceConnectorsRequest request) 
        {
            return new ListVoiceConnectorsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListVoiceProfileDomains operation
        ///</summary>
        public IListVoiceProfileDomainsPaginator ListVoiceProfileDomains(ListVoiceProfileDomainsRequest request) 
        {
            return new ListVoiceProfileDomainsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListVoiceProfiles operation
        ///</summary>
        public IListVoiceProfilesPaginator ListVoiceProfiles(ListVoiceProfilesRequest request) 
        {
            return new ListVoiceProfilesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchAvailablePhoneNumbers operation
        ///</summary>
        public ISearchAvailablePhoneNumbersPaginator SearchAvailablePhoneNumbers(SearchAvailablePhoneNumbersRequest request) 
        {
            return new SearchAvailablePhoneNumbersPaginator(this.client, request);
        }
    }
}