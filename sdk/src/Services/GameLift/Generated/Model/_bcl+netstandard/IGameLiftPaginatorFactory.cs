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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Paginators for the GameLift service
    ///</summary>
    public interface IGameLiftPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeFleetAttributes operation
        ///</summary>
        IDescribeFleetAttributesPaginator DescribeFleetAttributes(DescribeFleetAttributesRequest request);

        /// <summary>
        /// Paginator for DescribeFleetCapacity operation
        ///</summary>
        IDescribeFleetCapacityPaginator DescribeFleetCapacity(DescribeFleetCapacityRequest request);

        /// <summary>
        /// Paginator for DescribeFleetEvents operation
        ///</summary>
        IDescribeFleetEventsPaginator DescribeFleetEvents(DescribeFleetEventsRequest request);

        /// <summary>
        /// Paginator for DescribeFleetLocationAttributes operation
        ///</summary>
        IDescribeFleetLocationAttributesPaginator DescribeFleetLocationAttributes(DescribeFleetLocationAttributesRequest request);

        /// <summary>
        /// Paginator for DescribeFleetUtilization operation
        ///</summary>
        IDescribeFleetUtilizationPaginator DescribeFleetUtilization(DescribeFleetUtilizationRequest request);

        /// <summary>
        /// Paginator for DescribeGameServerInstances operation
        ///</summary>
        IDescribeGameServerInstancesPaginator DescribeGameServerInstances(DescribeGameServerInstancesRequest request);

        /// <summary>
        /// Paginator for DescribeGameSessionDetails operation
        ///</summary>
        IDescribeGameSessionDetailsPaginator DescribeGameSessionDetails(DescribeGameSessionDetailsRequest request);

        /// <summary>
        /// Paginator for DescribeGameSessionQueues operation
        ///</summary>
        IDescribeGameSessionQueuesPaginator DescribeGameSessionQueues(DescribeGameSessionQueuesRequest request);

        /// <summary>
        /// Paginator for DescribeGameSessions operation
        ///</summary>
        IDescribeGameSessionsPaginator DescribeGameSessions(DescribeGameSessionsRequest request);

        /// <summary>
        /// Paginator for DescribeInstances operation
        ///</summary>
        IDescribeInstancesPaginator DescribeInstances(DescribeInstancesRequest request);

        /// <summary>
        /// Paginator for DescribeMatchmakingConfigurations operation
        ///</summary>
        IDescribeMatchmakingConfigurationsPaginator DescribeMatchmakingConfigurations(DescribeMatchmakingConfigurationsRequest request);

        /// <summary>
        /// Paginator for DescribeMatchmakingRuleSets operation
        ///</summary>
        IDescribeMatchmakingRuleSetsPaginator DescribeMatchmakingRuleSets(DescribeMatchmakingRuleSetsRequest request);

        /// <summary>
        /// Paginator for DescribePlayerSessions operation
        ///</summary>
        IDescribePlayerSessionsPaginator DescribePlayerSessions(DescribePlayerSessionsRequest request);

        /// <summary>
        /// Paginator for DescribeScalingPolicies operation
        ///</summary>
        IDescribeScalingPoliciesPaginator DescribeScalingPolicies(DescribeScalingPoliciesRequest request);

        /// <summary>
        /// Paginator for ListAliases operation
        ///</summary>
        IListAliasesPaginator ListAliases(ListAliasesRequest request);

        /// <summary>
        /// Paginator for ListBuilds operation
        ///</summary>
        IListBuildsPaginator ListBuilds(ListBuildsRequest request);

        /// <summary>
        /// Paginator for ListCompute operation
        ///</summary>
        IListComputePaginator ListCompute(ListComputeRequest request);

        /// <summary>
        /// Paginator for ListFleets operation
        ///</summary>
        IListFleetsPaginator ListFleets(ListFleetsRequest request);

        /// <summary>
        /// Paginator for ListGameServerGroups operation
        ///</summary>
        IListGameServerGroupsPaginator ListGameServerGroups(ListGameServerGroupsRequest request);

        /// <summary>
        /// Paginator for ListGameServers operation
        ///</summary>
        IListGameServersPaginator ListGameServers(ListGameServersRequest request);

        /// <summary>
        /// Paginator for ListLocations operation
        ///</summary>
        IListLocationsPaginator ListLocations(ListLocationsRequest request);

        /// <summary>
        /// Paginator for ListScripts operation
        ///</summary>
        IListScriptsPaginator ListScripts(ListScriptsRequest request);

        /// <summary>
        /// Paginator for SearchGameSessions operation
        ///</summary>
        ISearchGameSessionsPaginator SearchGameSessions(SearchGameSessionsRequest request);
    }
}