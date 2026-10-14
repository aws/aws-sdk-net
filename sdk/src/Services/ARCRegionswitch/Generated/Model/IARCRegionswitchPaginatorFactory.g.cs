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

namespace Amazon.ARCRegionswitch.Model
{
    /// <summary>
    /// Paginators for the ARCRegionswitch service
    /// </summary>
    public interface IARCRegionswitchPaginatorFactory
    {
        /// <summary>
        /// Paginator for GetPlanEvaluationStatus operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetPlanEvaluationStatusPaginator GetPlanEvaluationStatus(GetPlanEvaluationStatusRequest request);

        /// <summary>
        /// Paginator for GetPlanExecution operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetPlanExecutionPaginator GetPlanExecution(GetPlanExecutionRequest request);

        /// <summary>
        /// Paginator for ListPlanExecutionEvents operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPlanExecutionEventsPaginator ListPlanExecutionEvents(ListPlanExecutionEventsRequest request);

        /// <summary>
        /// Paginator for ListPlanExecutions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPlanExecutionsPaginator ListPlanExecutions(ListPlanExecutionsRequest request);

        /// <summary>
        /// Paginator for ListPlans operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPlansPaginator ListPlans(ListPlansRequest request);

        /// <summary>
        /// Paginator for ListPlansInRegion operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPlansInRegionPaginator ListPlansInRegion(ListPlansInRegionRequest request);

        /// <summary>
        /// Paginator for ListRoute53HealthChecks operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListRoute53HealthChecksPaginator ListRoute53HealthChecks(ListRoute53HealthChecksRequest request);

        /// <summary>
        /// Paginator for ListRoute53HealthChecksInRegion operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListRoute53HealthChecksInRegionPaginator ListRoute53HealthChecksInRegion(ListRoute53HealthChecksInRegionRequest request);

        /// <summary>
        /// Paginator for ListServiceQuotaWarnings operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListServiceQuotaWarningsPaginator ListServiceQuotaWarnings(ListServiceQuotaWarningsRequest request);
    }
}
