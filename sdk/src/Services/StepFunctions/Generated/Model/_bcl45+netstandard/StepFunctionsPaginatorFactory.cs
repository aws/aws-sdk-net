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
 * Do not modify this file. This file is generated from the states-2016-11-23.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// Paginators for the StepFunctions service
    ///</summary>
    public class StepFunctionsPaginatorFactory : IStepFunctionsPaginatorFactory
    {
        private readonly IAmazonStepFunctions client;

        internal StepFunctionsPaginatorFactory(IAmazonStepFunctions client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetExecutionHistory operation
        ///</summary>
        public IGetExecutionHistoryPaginator GetExecutionHistory(GetExecutionHistoryRequest request) 
        {
            return new GetExecutionHistoryPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListActivities operation
        ///</summary>
        public IListActivitiesPaginator ListActivities(ListActivitiesRequest request) 
        {
            return new ListActivitiesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListExecutions operation
        ///</summary>
        public IListExecutionsPaginator ListExecutions(ListExecutionsRequest request) 
        {
            return new ListExecutionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMapRuns operation
        ///</summary>
        public IListMapRunsPaginator ListMapRuns(ListMapRunsRequest request) 
        {
            return new ListMapRunsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListStateMachines operation
        ///</summary>
        public IListStateMachinesPaginator ListStateMachines(ListStateMachinesRequest request) 
        {
            return new ListStateMachinesPaginator(this.client, request);
        }
    }
}