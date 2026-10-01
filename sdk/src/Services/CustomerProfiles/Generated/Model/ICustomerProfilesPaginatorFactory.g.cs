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

namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Paginators for the CustomerProfiles service
    /// </summary>
    public interface ICustomerProfilesPaginatorFactory
    {
        /// <summary>
        /// Paginator for GetSimilarProfiles operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetSimilarProfilesPaginator GetSimilarProfiles(GetSimilarProfilesRequest request);

        /// <summary>
        /// Paginator for ListDomainLayouts operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDomainLayoutsPaginator ListDomainLayouts(ListDomainLayoutsRequest request);

        /// <summary>
        /// Paginator for ListDomainObjectTypes operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDomainObjectTypesPaginator ListDomainObjectTypes(ListDomainObjectTypesRequest request);

        /// <summary>
        /// Paginator for ListEventStreams operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListEventStreamsPaginator ListEventStreams(ListEventStreamsRequest request);

        /// <summary>
        /// Paginator for ListEventTriggers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListEventTriggersPaginator ListEventTriggers(ListEventTriggersRequest request);

        /// <summary>
        /// Paginator for ListObjectTypeAttributes operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListObjectTypeAttributesPaginator ListObjectTypeAttributes(ListObjectTypeAttributesRequest request);

        /// <summary>
        /// Paginator for ListRecommenderFilters operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListRecommenderFiltersPaginator ListRecommenderFilters(ListRecommenderFiltersRequest request);

        /// <summary>
        /// Paginator for ListRecommenderRecipes operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListRecommenderRecipesPaginator ListRecommenderRecipes(ListRecommenderRecipesRequest request);

        /// <summary>
        /// Paginator for ListRecommenderSchemas operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListRecommenderSchemasPaginator ListRecommenderSchemas(ListRecommenderSchemasRequest request);

        /// <summary>
        /// Paginator for ListRecommenders operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListRecommendersPaginator ListRecommenders(ListRecommendersRequest request);

        /// <summary>
        /// Paginator for ListRuleBasedMatches operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListRuleBasedMatchesPaginator ListRuleBasedMatches(ListRuleBasedMatchesRequest request);

        /// <summary>
        /// Paginator for ListSegmentDefinitions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSegmentDefinitionsPaginator ListSegmentDefinitions(ListSegmentDefinitionsRequest request);

        /// <summary>
        /// Paginator for ListSegmentSubscriptionEvents operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSegmentSubscriptionEventsPaginator ListSegmentSubscriptionEvents(ListSegmentSubscriptionEventsRequest request);

        /// <summary>
        /// Paginator for ListUploadJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListUploadJobsPaginator ListUploadJobs(ListUploadJobsRequest request);
    }
}
