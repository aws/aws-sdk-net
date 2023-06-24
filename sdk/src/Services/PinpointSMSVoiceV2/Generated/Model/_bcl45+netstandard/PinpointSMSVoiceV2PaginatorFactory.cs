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

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// Paginators for the PinpointSMSVoiceV2 service
    ///</summary>
    public class PinpointSMSVoiceV2PaginatorFactory : IPinpointSMSVoiceV2PaginatorFactory
    {
        private readonly IAmazonPinpointSMSVoiceV2 client;

        internal PinpointSMSVoiceV2PaginatorFactory(IAmazonPinpointSMSVoiceV2 client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeAccountAttributes operation
        ///</summary>
        public IDescribeAccountAttributesPaginator DescribeAccountAttributes(DescribeAccountAttributesRequest request) 
        {
            return new DescribeAccountAttributesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeAccountLimits operation
        ///</summary>
        public IDescribeAccountLimitsPaginator DescribeAccountLimits(DescribeAccountLimitsRequest request) 
        {
            return new DescribeAccountLimitsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeConfigurationSets operation
        ///</summary>
        public IDescribeConfigurationSetsPaginator DescribeConfigurationSets(DescribeConfigurationSetsRequest request) 
        {
            return new DescribeConfigurationSetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeKeywords operation
        ///</summary>
        public IDescribeKeywordsPaginator DescribeKeywords(DescribeKeywordsRequest request) 
        {
            return new DescribeKeywordsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeOptedOutNumbers operation
        ///</summary>
        public IDescribeOptedOutNumbersPaginator DescribeOptedOutNumbers(DescribeOptedOutNumbersRequest request) 
        {
            return new DescribeOptedOutNumbersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeOptOutLists operation
        ///</summary>
        public IDescribeOptOutListsPaginator DescribeOptOutLists(DescribeOptOutListsRequest request) 
        {
            return new DescribeOptOutListsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribePhoneNumbers operation
        ///</summary>
        public IDescribePhoneNumbersPaginator DescribePhoneNumbers(DescribePhoneNumbersRequest request) 
        {
            return new DescribePhoneNumbersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribePools operation
        ///</summary>
        public IDescribePoolsPaginator DescribePools(DescribePoolsRequest request) 
        {
            return new DescribePoolsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeSenderIds operation
        ///</summary>
        public IDescribeSenderIdsPaginator DescribeSenderIds(DescribeSenderIdsRequest request) 
        {
            return new DescribeSenderIdsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeSpendLimits operation
        ///</summary>
        public IDescribeSpendLimitsPaginator DescribeSpendLimits(DescribeSpendLimitsRequest request) 
        {
            return new DescribeSpendLimitsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPoolOriginationIdentities operation
        ///</summary>
        public IListPoolOriginationIdentitiesPaginator ListPoolOriginationIdentities(ListPoolOriginationIdentitiesRequest request) 
        {
            return new ListPoolOriginationIdentitiesPaginator(this.client, request);
        }
    }
}