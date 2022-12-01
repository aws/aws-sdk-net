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

namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// Paginators for the StepFunctions service
    ///</summary>
    public interface IStepFunctionsPaginatorFactory
    {

        /// <summary>
        /// Paginator for GetExecutionHistory operation
        ///</summary>
        IGetExecutionHistoryPaginator GetExecutionHistory(GetExecutionHistoryRequest request);

        /// <summary>
        /// Paginator for ListActivities operation
        ///</summary>
        IListActivitiesPaginator ListActivities(ListActivitiesRequest request);

        /// <summary>
        /// Paginator for ListExecutions operation
        ///</summary>
        IListExecutionsPaginator ListExecutions(ListExecutionsRequest request);

        /// <summary>
        /// Paginator for ListMapRuns operation
        ///</summary>
        IListMapRunsPaginator ListMapRuns(ListMapRunsRequest request);

        /// <summary>
        /// Paginator for ListStateMachines operation
        ///</summary>
        IListStateMachinesPaginator ListStateMachines(ListStateMachinesRequest request);
    }
}