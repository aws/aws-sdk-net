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

namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// Paginators for the ChimeSDKVoice service
    ///</summary>
    public interface IChimeSDKVoicePaginatorFactory
    {

        /// <summary>
        /// Paginator for ListPhoneNumberOrders operation
        ///</summary>
        IListPhoneNumberOrdersPaginator ListPhoneNumberOrders(ListPhoneNumberOrdersRequest request);

        /// <summary>
        /// Paginator for ListPhoneNumbers operation
        ///</summary>
        IListPhoneNumbersPaginator ListPhoneNumbers(ListPhoneNumbersRequest request);

        /// <summary>
        /// Paginator for ListProxySessions operation
        ///</summary>
        IListProxySessionsPaginator ListProxySessions(ListProxySessionsRequest request);

        /// <summary>
        /// Paginator for ListSipMediaApplications operation
        ///</summary>
        IListSipMediaApplicationsPaginator ListSipMediaApplications(ListSipMediaApplicationsRequest request);

        /// <summary>
        /// Paginator for ListSipRules operation
        ///</summary>
        IListSipRulesPaginator ListSipRules(ListSipRulesRequest request);

        /// <summary>
        /// Paginator for ListVoiceConnectorGroups operation
        ///</summary>
        IListVoiceConnectorGroupsPaginator ListVoiceConnectorGroups(ListVoiceConnectorGroupsRequest request);

        /// <summary>
        /// Paginator for ListVoiceConnectors operation
        ///</summary>
        IListVoiceConnectorsPaginator ListVoiceConnectors(ListVoiceConnectorsRequest request);

        /// <summary>
        /// Paginator for ListVoiceProfileDomains operation
        ///</summary>
        IListVoiceProfileDomainsPaginator ListVoiceProfileDomains(ListVoiceProfileDomainsRequest request);

        /// <summary>
        /// Paginator for ListVoiceProfiles operation
        ///</summary>
        IListVoiceProfilesPaginator ListVoiceProfiles(ListVoiceProfilesRequest request);

        /// <summary>
        /// Paginator for SearchAvailablePhoneNumbers operation
        ///</summary>
        ISearchAvailablePhoneNumbersPaginator SearchAvailablePhoneNumbers(SearchAvailablePhoneNumbersRequest request);
    }
}