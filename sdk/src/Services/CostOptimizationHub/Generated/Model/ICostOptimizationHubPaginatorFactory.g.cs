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

namespace Amazon.CostOptimizationHub.Model
{
    /// <summary>
    /// Paginators for the CostOptimizationHub service
    /// </summary>
    public interface ICostOptimizationHubPaginatorFactory
    {
        /// <summary>
        /// Paginator for ListEfficiencyMetrics operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListEfficiencyMetricsPaginator ListEfficiencyMetrics(ListEfficiencyMetricsRequest request);

        /// <summary>
        /// Paginator for ListEnrollmentStatuses operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListEnrollmentStatusesPaginator ListEnrollmentStatuses(ListEnrollmentStatusesRequest request);

        /// <summary>
        /// Paginator for ListRecommendationSummaries operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListRecommendationSummariesPaginator ListRecommendationSummaries(ListRecommendationSummariesRequest request);

        /// <summary>
        /// Paginator for ListRecommendations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListRecommendationsPaginator ListRecommendations(ListRecommendationsRequest request);
    }
}
