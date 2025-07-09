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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Paginators for the CustomerProfiles service
    ///</summary>
    public class CustomerProfilesPaginatorFactory : ICustomerProfilesPaginatorFactory
    {
        private readonly IAmazonCustomerProfiles client;

        internal CustomerProfilesPaginatorFactory(IAmazonCustomerProfiles client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetSimilarProfiles operation
        ///</summary>
        public IGetSimilarProfilesPaginator GetSimilarProfiles(GetSimilarProfilesRequest request) 
        {
            return new GetSimilarProfilesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDomainLayouts operation
        ///</summary>
        public IListDomainLayoutsPaginator ListDomainLayouts(ListDomainLayoutsRequest request) 
        {
            return new ListDomainLayoutsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEventStreams operation
        ///</summary>
        public IListEventStreamsPaginator ListEventStreams(ListEventStreamsRequest request) 
        {
            return new ListEventStreamsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEventTriggers operation
        ///</summary>
        public IListEventTriggersPaginator ListEventTriggers(ListEventTriggersRequest request) 
        {
            return new ListEventTriggersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListObjectTypeAttributes operation
        ///</summary>
        public IListObjectTypeAttributesPaginator ListObjectTypeAttributes(ListObjectTypeAttributesRequest request) 
        {
            return new ListObjectTypeAttributesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRuleBasedMatches operation
        ///</summary>
        public IListRuleBasedMatchesPaginator ListRuleBasedMatches(ListRuleBasedMatchesRequest request) 
        {
            return new ListRuleBasedMatchesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSegmentDefinitions operation
        ///</summary>
        public IListSegmentDefinitionsPaginator ListSegmentDefinitions(ListSegmentDefinitionsRequest request) 
        {
            return new ListSegmentDefinitionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListUploadJobs operation
        ///</summary>
        public IListUploadJobsPaginator ListUploadJobs(ListUploadJobsRequest request) 
        {
            return new ListUploadJobsPaginator(this.client, request);
        }
    }
}