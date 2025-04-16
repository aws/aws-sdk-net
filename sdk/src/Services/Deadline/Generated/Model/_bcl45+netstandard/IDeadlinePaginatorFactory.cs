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
using Amazon.Runtime.Internal;

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
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetSessionsStatisticsAggregationPaginator GetSessionsStatisticsAggregation(GetSessionsStatisticsAggregationRequest request);

        /// <summary>
        /// Paginator for ListAvailableMeteredProducts operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAvailableMeteredProductsPaginator ListAvailableMeteredProducts(ListAvailableMeteredProductsRequest request);

        /// <summary>
        /// Paginator for ListBudgets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListBudgetsPaginator ListBudgets(ListBudgetsRequest request);

        /// <summary>
        /// Paginator for ListFarmMembers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFarmMembersPaginator ListFarmMembers(ListFarmMembersRequest request);

        /// <summary>
        /// Paginator for ListFarms operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFarmsPaginator ListFarms(ListFarmsRequest request);

        /// <summary>
        /// Paginator for ListFleetMembers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFleetMembersPaginator ListFleetMembers(ListFleetMembersRequest request);

        /// <summary>
        /// Paginator for ListFleets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFleetsPaginator ListFleets(ListFleetsRequest request);

        /// <summary>
        /// Paginator for ListJobMembers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListJobMembersPaginator ListJobMembers(ListJobMembersRequest request);

        /// <summary>
        /// Paginator for ListJobParameterDefinitions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListJobParameterDefinitionsPaginator ListJobParameterDefinitions(ListJobParameterDefinitionsRequest request);

        /// <summary>
        /// Paginator for ListJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListJobsPaginator ListJobs(ListJobsRequest request);

        /// <summary>
        /// Paginator for ListLicenseEndpoints operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListLicenseEndpointsPaginator ListLicenseEndpoints(ListLicenseEndpointsRequest request);

        /// <summary>
        /// Paginator for ListLimits operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListLimitsPaginator ListLimits(ListLimitsRequest request);

        /// <summary>
        /// Paginator for ListMeteredProducts operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMeteredProductsPaginator ListMeteredProducts(ListMeteredProductsRequest request);

        /// <summary>
        /// Paginator for ListMonitors operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMonitorsPaginator ListMonitors(ListMonitorsRequest request);

        /// <summary>
        /// Paginator for ListQueueEnvironments operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListQueueEnvironmentsPaginator ListQueueEnvironments(ListQueueEnvironmentsRequest request);

        /// <summary>
        /// Paginator for ListQueueFleetAssociations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListQueueFleetAssociationsPaginator ListQueueFleetAssociations(ListQueueFleetAssociationsRequest request);

        /// <summary>
        /// Paginator for ListQueueLimitAssociations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListQueueLimitAssociationsPaginator ListQueueLimitAssociations(ListQueueLimitAssociationsRequest request);

        /// <summary>
        /// Paginator for ListQueueMembers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListQueueMembersPaginator ListQueueMembers(ListQueueMembersRequest request);

        /// <summary>
        /// Paginator for ListQueues operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListQueuesPaginator ListQueues(ListQueuesRequest request);

        /// <summary>
        /// Paginator for ListSessionActions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSessionActionsPaginator ListSessionActions(ListSessionActionsRequest request);

        /// <summary>
        /// Paginator for ListSessions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSessionsPaginator ListSessions(ListSessionsRequest request);

        /// <summary>
        /// Paginator for ListSessionsForWorker operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSessionsForWorkerPaginator ListSessionsForWorker(ListSessionsForWorkerRequest request);

        /// <summary>
        /// Paginator for ListStepConsumers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListStepConsumersPaginator ListStepConsumers(ListStepConsumersRequest request);

        /// <summary>
        /// Paginator for ListStepDependencies operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListStepDependenciesPaginator ListStepDependencies(ListStepDependenciesRequest request);

        /// <summary>
        /// Paginator for ListSteps operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListStepsPaginator ListSteps(ListStepsRequest request);

        /// <summary>
        /// Paginator for ListStorageProfiles operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListStorageProfilesPaginator ListStorageProfiles(ListStorageProfilesRequest request);

        /// <summary>
        /// Paginator for ListStorageProfilesForQueue operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListStorageProfilesForQueuePaginator ListStorageProfilesForQueue(ListStorageProfilesForQueueRequest request);

        /// <summary>
        /// Paginator for ListTasks operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTasksPaginator ListTasks(ListTasksRequest request);

        /// <summary>
        /// Paginator for ListWorkers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListWorkersPaginator ListWorkers(ListWorkersRequest request);
    }
}