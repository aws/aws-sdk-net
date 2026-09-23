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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618

namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// Paginators for the ChimeSDKVoice service
    /// </summary>
    public interface IChimeSDKVoicePaginatorFactory
    {
        /// <summary>
        /// Paginator for ListPhoneNumberOrders operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPhoneNumberOrdersPaginator ListPhoneNumberOrders(ListPhoneNumberOrdersRequest request);

        /// <summary>
        /// Paginator for ListPhoneNumbers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPhoneNumbersPaginator ListPhoneNumbers(ListPhoneNumbersRequest request);

        /// <summary>
        /// Paginator for ListProxySessions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListProxySessionsPaginator ListProxySessions(ListProxySessionsRequest request);

        /// <summary>
        /// Paginator for ListSipMediaApplications operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSipMediaApplicationsPaginator ListSipMediaApplications(ListSipMediaApplicationsRequest request);

        /// <summary>
        /// Paginator for ListSipRules operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSipRulesPaginator ListSipRules(ListSipRulesRequest request);

        /// <summary>
        /// Paginator for ListVoiceConnectorGroups operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListVoiceConnectorGroupsPaginator ListVoiceConnectorGroups(ListVoiceConnectorGroupsRequest request);

        /// <summary>
        /// Paginator for ListVoiceConnectors operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListVoiceConnectorsPaginator ListVoiceConnectors(ListVoiceConnectorsRequest request);

        /// <summary>
        /// Paginator for ListVoiceProfileDomains operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListVoiceProfileDomainsPaginator ListVoiceProfileDomains(ListVoiceProfileDomainsRequest request);

        /// <summary>
        /// Paginator for ListVoiceProfiles operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListVoiceProfilesPaginator ListVoiceProfiles(ListVoiceProfilesRequest request);

        /// <summary>
        /// Paginator for SearchAvailablePhoneNumbers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchAvailablePhoneNumbersPaginator SearchAvailablePhoneNumbers(SearchAvailablePhoneNumbersRequest request);
    }
}
