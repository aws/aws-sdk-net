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
 * Do not modify this file. This file is generated from the cost-optimization-hub-2022-07-26.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.CostOptimizationHub.Model
{
    /// <summary>
    /// Paginators for the CostOptimizationHub service
    ///</summary>
    public class CostOptimizationHubPaginatorFactory : ICostOptimizationHubPaginatorFactory
    {
        private readonly IAmazonCostOptimizationHub client;

        internal CostOptimizationHubPaginatorFactory(IAmazonCostOptimizationHub client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListEnrollmentStatuses operation
        ///</summary>
        public IListEnrollmentStatusesPaginator ListEnrollmentStatuses(ListEnrollmentStatusesRequest request) 
        {
            return new ListEnrollmentStatusesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRecommendations operation
        ///</summary>
        public IListRecommendationsPaginator ListRecommendations(ListRecommendationsRequest request) 
        {
            return new ListRecommendationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRecommendationSummaries operation
        ///</summary>
        public IListRecommendationSummariesPaginator ListRecommendationSummaries(ListRecommendationSummariesRequest request) 
        {
            return new ListRecommendationSummariesPaginator(this.client, request);
        }
    }
}