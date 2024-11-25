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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
 */

#pragma warning disable CS0612,CS0618
namespace Amazon.Deadline.Model
{
    /// <summary>
    /// Paginators for the Deadline service
    ///</summary>
    public interface IDeadlinePaginatorFactory
    {

        /// <summary>
        /// Paginator for GetSessionsStatisticsAggregation operation
        ///</summary>
        IGetSessionsStatisticsAggregationPaginator GetSessionsStatisticsAggregation(GetSessionsStatisticsAggregationRequest request);

        /// <summary>
        /// Paginator for ListAvailableMeteredProducts operation
        ///</summary>
        IListAvailableMeteredProductsPaginator ListAvailableMeteredProducts(ListAvailableMeteredProductsRequest request);

        /// <summary>
        /// Paginator for ListBudgets operation
        ///</summary>
        IListBudgetsPaginator ListBudgets(ListBudgetsRequest request);

        /// <summary>
        /// Paginator for ListFarmMembers operation
        ///</summary>
        IListFarmMembersPaginator ListFarmMembers(ListFarmMembersRequest request);

        /// <summary>
        /// Paginator for ListFarms operation
        ///</summary>
        IListFarmsPaginator ListFarms(ListFarmsRequest request);

        /// <summary>
        /// Paginator for ListFleetMembers operation
        ///</summary>
        IListFleetMembersPaginator ListFleetMembers(ListFleetMembersRequest request);

        /// <summary>
        /// Paginator for ListFleets operation
        ///</summary>
        IListFleetsPaginator ListFleets(ListFleetsRequest request);

        /// <summary>
        /// Paginator for ListJobMembers operation
        ///</summary>
        IListJobMembersPaginator ListJobMembers(ListJobMembersRequest request);

        /// <summary>
        /// Paginator for ListJobParameterDefinitions operation
        ///</summary>
        IListJobParameterDefinitionsPaginator ListJobParameterDefinitions(ListJobParameterDefinitionsRequest request);

        /// <summary>
        /// Paginator for ListJobs operation
        ///</summary>
        IListJobsPaginator ListJobs(ListJobsRequest request);

        /// <summary>
        /// Paginator for ListLicenseEndpoints operation
        ///</summary>
        IListLicenseEndpointsPaginator ListLicenseEndpoints(ListLicenseEndpointsRequest request);

        /// <summary>
        /// Paginator for ListMeteredProducts operation
        ///</summary>
        IListMeteredProductsPaginator ListMeteredProducts(ListMeteredProductsRequest request);

        /// <summary>
        /// Paginator for ListMonitors operation
        ///</summary>
        IListMonitorsPaginator ListMonitors(ListMonitorsRequest request);

        /// <summary>
        /// Paginator for ListQueueEnvironments operation
        ///</summary>
        IListQueueEnvironmentsPaginator ListQueueEnvironments(ListQueueEnvironmentsRequest request);

        /// <summary>
        /// Paginator for ListQueueFleetAssociations operation
        ///</summary>
        IListQueueFleetAssociationsPaginator ListQueueFleetAssociations(ListQueueFleetAssociationsRequest request);

        /// <summary>
        /// Paginator for ListQueueMembers operation
        ///</summary>
        IListQueueMembersPaginator ListQueueMembers(ListQueueMembersRequest request);

        /// <summary>
        /// Paginator for ListQueues operation
        ///</summary>
        IListQueuesPaginator ListQueues(ListQueuesRequest request);

        /// <summary>
        /// Paginator for ListSessionActions operation
        ///</summary>
        IListSessionActionsPaginator ListSessionActions(ListSessionActionsRequest request);

        /// <summary>
        /// Paginator for ListSessions operation
        ///</summary>
        IListSessionsPaginator ListSessions(ListSessionsRequest request);

        /// <summary>
        /// Paginator for ListSessionsForWorker operation
        ///</summary>
        IListSessionsForWorkerPaginator ListSessionsForWorker(ListSessionsForWorkerRequest request);

        /// <summary>
        /// Paginator for ListStepConsumers operation
        ///</summary>
        IListStepConsumersPaginator ListStepConsumers(ListStepConsumersRequest request);

        /// <summary>
        /// Paginator for ListStepDependencies operation
        ///</summary>
        IListStepDependenciesPaginator ListStepDependencies(ListStepDependenciesRequest request);

        /// <summary>
        /// Paginator for ListSteps operation
        ///</summary>
        IListStepsPaginator ListSteps(ListStepsRequest request);

        /// <summary>
        /// Paginator for ListStorageProfiles operation
        ///</summary>
        IListStorageProfilesPaginator ListStorageProfiles(ListStorageProfilesRequest request);

        /// <summary>
        /// Paginator for ListStorageProfilesForQueue operation
        ///</summary>
        IListStorageProfilesForQueuePaginator ListStorageProfilesForQueue(ListStorageProfilesForQueueRequest request);

        /// <summary>
        /// Paginator for ListTasks operation
        ///</summary>
        IListTasksPaginator ListTasks(ListTasksRequest request);

        /// <summary>
        /// Paginator for ListWorkers operation
        ///</summary>
        IListWorkersPaginator ListWorkers(ListWorkersRequest request);
    }
}