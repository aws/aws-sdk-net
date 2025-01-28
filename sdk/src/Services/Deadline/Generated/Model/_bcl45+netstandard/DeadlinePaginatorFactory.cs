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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Deadline.Model
{
    /// <summary>
    /// Paginators for the Deadline service
    ///</summary>
    public class DeadlinePaginatorFactory : IDeadlinePaginatorFactory
    {
        private readonly IAmazonDeadline client;

        internal DeadlinePaginatorFactory(IAmazonDeadline client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetSessionsStatisticsAggregation operation
        ///</summary>
        public IGetSessionsStatisticsAggregationPaginator GetSessionsStatisticsAggregation(GetSessionsStatisticsAggregationRequest request) 
        {
            return new GetSessionsStatisticsAggregationPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAvailableMeteredProducts operation
        ///</summary>
        public IListAvailableMeteredProductsPaginator ListAvailableMeteredProducts(ListAvailableMeteredProductsRequest request) 
        {
            return new ListAvailableMeteredProductsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBudgets operation
        ///</summary>
        public IListBudgetsPaginator ListBudgets(ListBudgetsRequest request) 
        {
            return new ListBudgetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFarmMembers operation
        ///</summary>
        public IListFarmMembersPaginator ListFarmMembers(ListFarmMembersRequest request) 
        {
            return new ListFarmMembersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFarms operation
        ///</summary>
        public IListFarmsPaginator ListFarms(ListFarmsRequest request) 
        {
            return new ListFarmsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFleetMembers operation
        ///</summary>
        public IListFleetMembersPaginator ListFleetMembers(ListFleetMembersRequest request) 
        {
            return new ListFleetMembersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFleets operation
        ///</summary>
        public IListFleetsPaginator ListFleets(ListFleetsRequest request) 
        {
            return new ListFleetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListJobMembers operation
        ///</summary>
        public IListJobMembersPaginator ListJobMembers(ListJobMembersRequest request) 
        {
            return new ListJobMembersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListJobParameterDefinitions operation
        ///</summary>
        public IListJobParameterDefinitionsPaginator ListJobParameterDefinitions(ListJobParameterDefinitionsRequest request) 
        {
            return new ListJobParameterDefinitionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListJobs operation
        ///</summary>
        public IListJobsPaginator ListJobs(ListJobsRequest request) 
        {
            return new ListJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListLicenseEndpoints operation
        ///</summary>
        public IListLicenseEndpointsPaginator ListLicenseEndpoints(ListLicenseEndpointsRequest request) 
        {
            return new ListLicenseEndpointsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListLimits operation
        ///</summary>
        public IListLimitsPaginator ListLimits(ListLimitsRequest request) 
        {
            return new ListLimitsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMeteredProducts operation
        ///</summary>
        public IListMeteredProductsPaginator ListMeteredProducts(ListMeteredProductsRequest request) 
        {
            return new ListMeteredProductsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMonitors operation
        ///</summary>
        public IListMonitorsPaginator ListMonitors(ListMonitorsRequest request) 
        {
            return new ListMonitorsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListQueueEnvironments operation
        ///</summary>
        public IListQueueEnvironmentsPaginator ListQueueEnvironments(ListQueueEnvironmentsRequest request) 
        {
            return new ListQueueEnvironmentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListQueueFleetAssociations operation
        ///</summary>
        public IListQueueFleetAssociationsPaginator ListQueueFleetAssociations(ListQueueFleetAssociationsRequest request) 
        {
            return new ListQueueFleetAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListQueueLimitAssociations operation
        ///</summary>
        public IListQueueLimitAssociationsPaginator ListQueueLimitAssociations(ListQueueLimitAssociationsRequest request) 
        {
            return new ListQueueLimitAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListQueueMembers operation
        ///</summary>
        public IListQueueMembersPaginator ListQueueMembers(ListQueueMembersRequest request) 
        {
            return new ListQueueMembersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListQueues operation
        ///</summary>
        public IListQueuesPaginator ListQueues(ListQueuesRequest request) 
        {
            return new ListQueuesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSessionActions operation
        ///</summary>
        public IListSessionActionsPaginator ListSessionActions(ListSessionActionsRequest request) 
        {
            return new ListSessionActionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSessions operation
        ///</summary>
        public IListSessionsPaginator ListSessions(ListSessionsRequest request) 
        {
            return new ListSessionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSessionsForWorker operation
        ///</summary>
        public IListSessionsForWorkerPaginator ListSessionsForWorker(ListSessionsForWorkerRequest request) 
        {
            return new ListSessionsForWorkerPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListStepConsumers operation
        ///</summary>
        public IListStepConsumersPaginator ListStepConsumers(ListStepConsumersRequest request) 
        {
            return new ListStepConsumersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListStepDependencies operation
        ///</summary>
        public IListStepDependenciesPaginator ListStepDependencies(ListStepDependenciesRequest request) 
        {
            return new ListStepDependenciesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSteps operation
        ///</summary>
        public IListStepsPaginator ListSteps(ListStepsRequest request) 
        {
            return new ListStepsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListStorageProfiles operation
        ///</summary>
        public IListStorageProfilesPaginator ListStorageProfiles(ListStorageProfilesRequest request) 
        {
            return new ListStorageProfilesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListStorageProfilesForQueue operation
        ///</summary>
        public IListStorageProfilesForQueuePaginator ListStorageProfilesForQueue(ListStorageProfilesForQueueRequest request) 
        {
            return new ListStorageProfilesForQueuePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTasks operation
        ///</summary>
        public IListTasksPaginator ListTasks(ListTasksRequest request) 
        {
            return new ListTasksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWorkers operation
        ///</summary>
        public IListWorkersPaginator ListWorkers(ListWorkersRequest request) 
        {
            return new ListWorkersPaginator(this.client, request);
        }
    }
}