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
 * Do not modify this file. This file is generated from the arc-region-switch-2022-07-26.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.ARCRegionswitch.Model
{
    /// <summary>
    /// Paginators for the ARCRegionswitch service
    ///</summary>
    public interface IARCRegionswitchPaginatorFactory
    {

        /// <summary>
        /// Paginator for GetPlanEvaluationStatus operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetPlanEvaluationStatusPaginator GetPlanEvaluationStatus(GetPlanEvaluationStatusRequest request);

        /// <summary>
        /// Paginator for GetPlanExecution operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetPlanExecutionPaginator GetPlanExecution(GetPlanExecutionRequest request);

        /// <summary>
        /// Paginator for ListPlanExecutionEvents operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPlanExecutionEventsPaginator ListPlanExecutionEvents(ListPlanExecutionEventsRequest request);

        /// <summary>
        /// Paginator for ListPlanExecutions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPlanExecutionsPaginator ListPlanExecutions(ListPlanExecutionsRequest request);

        /// <summary>
        /// Paginator for ListPlans operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPlansPaginator ListPlans(ListPlansRequest request);

        /// <summary>
        /// Paginator for ListPlansInRegion operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPlansInRegionPaginator ListPlansInRegion(ListPlansInRegionRequest request);

        /// <summary>
        /// Paginator for ListRoute53HealthChecks operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListRoute53HealthChecksPaginator ListRoute53HealthChecks(ListRoute53HealthChecksRequest request);
    }
}