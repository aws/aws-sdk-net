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
 * Do not modify this file. This file is generated from the trustedadvisor-2022-09-15.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.TrustedAdvisor.Model
{
    /// <summary>
    /// Paginators for the TrustedAdvisor service
    ///</summary>
    public interface ITrustedAdvisorPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListChecks operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListChecksPaginator ListChecks(ListChecksRequest request);

        /// <summary>
        /// Paginator for ListOrganizationRecommendationAccounts operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListOrganizationRecommendationAccountsPaginator ListOrganizationRecommendationAccounts(ListOrganizationRecommendationAccountsRequest request);

        /// <summary>
        /// Paginator for ListOrganizationRecommendationResources operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListOrganizationRecommendationResourcesPaginator ListOrganizationRecommendationResources(ListOrganizationRecommendationResourcesRequest request);

        /// <summary>
        /// Paginator for ListOrganizationRecommendations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListOrganizationRecommendationsPaginator ListOrganizationRecommendations(ListOrganizationRecommendationsRequest request);

        /// <summary>
        /// Paginator for ListRecommendationResources operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListRecommendationResourcesPaginator ListRecommendationResources(ListRecommendationResourcesRequest request);

        /// <summary>
        /// Paginator for ListRecommendations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListRecommendationsPaginator ListRecommendations(ListRecommendationsRequest request);
    }
}