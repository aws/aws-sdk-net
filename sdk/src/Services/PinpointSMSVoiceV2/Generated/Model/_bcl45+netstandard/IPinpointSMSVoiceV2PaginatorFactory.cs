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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
 */

namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// Paginators for the PinpointSMSVoiceV2 service
    ///</summary>
    public interface IPinpointSMSVoiceV2PaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeAccountAttributes operation
        ///</summary>
        IDescribeAccountAttributesPaginator DescribeAccountAttributes(DescribeAccountAttributesRequest request);

        /// <summary>
        /// Paginator for DescribeAccountLimits operation
        ///</summary>
        IDescribeAccountLimitsPaginator DescribeAccountLimits(DescribeAccountLimitsRequest request);

        /// <summary>
        /// Paginator for DescribeConfigurationSets operation
        ///</summary>
        IDescribeConfigurationSetsPaginator DescribeConfigurationSets(DescribeConfigurationSetsRequest request);

        /// <summary>
        /// Paginator for DescribeKeywords operation
        ///</summary>
        IDescribeKeywordsPaginator DescribeKeywords(DescribeKeywordsRequest request);

        /// <summary>
        /// Paginator for DescribeOptedOutNumbers operation
        ///</summary>
        IDescribeOptedOutNumbersPaginator DescribeOptedOutNumbers(DescribeOptedOutNumbersRequest request);

        /// <summary>
        /// Paginator for DescribeOptOutLists operation
        ///</summary>
        IDescribeOptOutListsPaginator DescribeOptOutLists(DescribeOptOutListsRequest request);

        /// <summary>
        /// Paginator for DescribePhoneNumbers operation
        ///</summary>
        IDescribePhoneNumbersPaginator DescribePhoneNumbers(DescribePhoneNumbersRequest request);

        /// <summary>
        /// Paginator for DescribePools operation
        ///</summary>
        IDescribePoolsPaginator DescribePools(DescribePoolsRequest request);

        /// <summary>
        /// Paginator for DescribeSenderIds operation
        ///</summary>
        IDescribeSenderIdsPaginator DescribeSenderIds(DescribeSenderIdsRequest request);

        /// <summary>
        /// Paginator for DescribeSpendLimits operation
        ///</summary>
        IDescribeSpendLimitsPaginator DescribeSpendLimits(DescribeSpendLimitsRequest request);

        /// <summary>
        /// Paginator for ListPoolOriginationIdentities operation
        ///</summary>
        IListPoolOriginationIdentitiesPaginator ListPoolOriginationIdentities(ListPoolOriginationIdentitiesRequest request);
    }
}