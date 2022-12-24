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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Paginators for the ComputeOptimizer service
    ///</summary>
    public class ComputeOptimizerPaginatorFactory : IComputeOptimizerPaginatorFactory
    {
        private readonly IAmazonComputeOptimizer client;

        internal ComputeOptimizerPaginatorFactory(IAmazonComputeOptimizer client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeRecommendationExportJobs operation
        ///</summary>
        public IDescribeRecommendationExportJobsPaginator DescribeRecommendationExportJobs(DescribeRecommendationExportJobsRequest request) 
        {
            return new DescribeRecommendationExportJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetEnrollmentStatusesForOrganization operation
        ///</summary>
        public IGetEnrollmentStatusesForOrganizationPaginator GetEnrollmentStatusesForOrganization(GetEnrollmentStatusesForOrganizationRequest request) 
        {
            return new GetEnrollmentStatusesForOrganizationPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetLambdaFunctionRecommendations operation
        ///</summary>
        public IGetLambdaFunctionRecommendationsPaginator GetLambdaFunctionRecommendations(GetLambdaFunctionRecommendationsRequest request) 
        {
            return new GetLambdaFunctionRecommendationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetRecommendationPreferences operation
        ///</summary>
        public IGetRecommendationPreferencesPaginator GetRecommendationPreferences(GetRecommendationPreferencesRequest request) 
        {
            return new GetRecommendationPreferencesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetRecommendationSummaries operation
        ///</summary>
        public IGetRecommendationSummariesPaginator GetRecommendationSummaries(GetRecommendationSummariesRequest request) 
        {
            return new GetRecommendationSummariesPaginator(this.client, request);
        }
    }
}