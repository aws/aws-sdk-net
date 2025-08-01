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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.ARCRegionswitch.Model
{
    /// <summary>
    /// Paginators for the ARCRegionswitch service
    ///</summary>
    public class ARCRegionswitchPaginatorFactory : IARCRegionswitchPaginatorFactory
    {
        private readonly IAmazonARCRegionswitch client;

        internal ARCRegionswitchPaginatorFactory(IAmazonARCRegionswitch client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetPlanEvaluationStatus operation
        ///</summary>
        public IGetPlanEvaluationStatusPaginator GetPlanEvaluationStatus(GetPlanEvaluationStatusRequest request) 
        {
            return new GetPlanEvaluationStatusPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetPlanExecution operation
        ///</summary>
        public IGetPlanExecutionPaginator GetPlanExecution(GetPlanExecutionRequest request) 
        {
            return new GetPlanExecutionPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPlanExecutionEvents operation
        ///</summary>
        public IListPlanExecutionEventsPaginator ListPlanExecutionEvents(ListPlanExecutionEventsRequest request) 
        {
            return new ListPlanExecutionEventsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPlanExecutions operation
        ///</summary>
        public IListPlanExecutionsPaginator ListPlanExecutions(ListPlanExecutionsRequest request) 
        {
            return new ListPlanExecutionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPlans operation
        ///</summary>
        public IListPlansPaginator ListPlans(ListPlansRequest request) 
        {
            return new ListPlansPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPlansInRegion operation
        ///</summary>
        public IListPlansInRegionPaginator ListPlansInRegion(ListPlansInRegionRequest request) 
        {
            return new ListPlansInRegionPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRoute53HealthChecks operation
        ///</summary>
        public IListRoute53HealthChecksPaginator ListRoute53HealthChecks(ListRoute53HealthChecksRequest request) 
        {
            return new ListRoute53HealthChecksPaginator(this.client, request);
        }
    }
}