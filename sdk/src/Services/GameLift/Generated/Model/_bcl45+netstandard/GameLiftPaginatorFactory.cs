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

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Paginators for the GameLift service
    ///</summary>
    public class GameLiftPaginatorFactory : IGameLiftPaginatorFactory
    {
        private readonly IAmazonGameLift client;

        internal GameLiftPaginatorFactory(IAmazonGameLift client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeFleetAttributes operation
        ///</summary>
        public IDescribeFleetAttributesPaginator DescribeFleetAttributes(DescribeFleetAttributesRequest request) 
        {
            return new DescribeFleetAttributesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeFleetCapacity operation
        ///</summary>
        public IDescribeFleetCapacityPaginator DescribeFleetCapacity(DescribeFleetCapacityRequest request) 
        {
            return new DescribeFleetCapacityPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeFleetEvents operation
        ///</summary>
        public IDescribeFleetEventsPaginator DescribeFleetEvents(DescribeFleetEventsRequest request) 
        {
            return new DescribeFleetEventsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeFleetLocationAttributes operation
        ///</summary>
        public IDescribeFleetLocationAttributesPaginator DescribeFleetLocationAttributes(DescribeFleetLocationAttributesRequest request) 
        {
            return new DescribeFleetLocationAttributesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeFleetUtilization operation
        ///</summary>
        public IDescribeFleetUtilizationPaginator DescribeFleetUtilization(DescribeFleetUtilizationRequest request) 
        {
            return new DescribeFleetUtilizationPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeGameServerInstances operation
        ///</summary>
        public IDescribeGameServerInstancesPaginator DescribeGameServerInstances(DescribeGameServerInstancesRequest request) 
        {
            return new DescribeGameServerInstancesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeGameSessionDetails operation
        ///</summary>
        public IDescribeGameSessionDetailsPaginator DescribeGameSessionDetails(DescribeGameSessionDetailsRequest request) 
        {
            return new DescribeGameSessionDetailsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeGameSessionQueues operation
        ///</summary>
        public IDescribeGameSessionQueuesPaginator DescribeGameSessionQueues(DescribeGameSessionQueuesRequest request) 
        {
            return new DescribeGameSessionQueuesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeGameSessions operation
        ///</summary>
        public IDescribeGameSessionsPaginator DescribeGameSessions(DescribeGameSessionsRequest request) 
        {
            return new DescribeGameSessionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeInstances operation
        ///</summary>
        public IDescribeInstancesPaginator DescribeInstances(DescribeInstancesRequest request) 
        {
            return new DescribeInstancesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeMatchmakingConfigurations operation
        ///</summary>
        public IDescribeMatchmakingConfigurationsPaginator DescribeMatchmakingConfigurations(DescribeMatchmakingConfigurationsRequest request) 
        {
            return new DescribeMatchmakingConfigurationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeMatchmakingRuleSets operation
        ///</summary>
        public IDescribeMatchmakingRuleSetsPaginator DescribeMatchmakingRuleSets(DescribeMatchmakingRuleSetsRequest request) 
        {
            return new DescribeMatchmakingRuleSetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribePlayerSessions operation
        ///</summary>
        public IDescribePlayerSessionsPaginator DescribePlayerSessions(DescribePlayerSessionsRequest request) 
        {
            return new DescribePlayerSessionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeScalingPolicies operation
        ///</summary>
        public IDescribeScalingPoliciesPaginator DescribeScalingPolicies(DescribeScalingPoliciesRequest request) 
        {
            return new DescribeScalingPoliciesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAliases operation
        ///</summary>
        public IListAliasesPaginator ListAliases(ListAliasesRequest request) 
        {
            return new ListAliasesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBuilds operation
        ///</summary>
        public IListBuildsPaginator ListBuilds(ListBuildsRequest request) 
        {
            return new ListBuildsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCompute operation
        ///</summary>
        public IListComputePaginator ListCompute(ListComputeRequest request) 
        {
            return new ListComputePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFleets operation
        ///</summary>
        public IListFleetsPaginator ListFleets(ListFleetsRequest request) 
        {
            return new ListFleetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListGameServerGroups operation
        ///</summary>
        public IListGameServerGroupsPaginator ListGameServerGroups(ListGameServerGroupsRequest request) 
        {
            return new ListGameServerGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListGameServers operation
        ///</summary>
        public IListGameServersPaginator ListGameServers(ListGameServersRequest request) 
        {
            return new ListGameServersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListLocations operation
        ///</summary>
        public IListLocationsPaginator ListLocations(ListLocationsRequest request) 
        {
            return new ListLocationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListScripts operation
        ///</summary>
        public IListScriptsPaginator ListScripts(ListScriptsRequest request) 
        {
            return new ListScriptsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchGameSessions operation
        ///</summary>
        public ISearchGameSessionsPaginator SearchGameSessions(SearchGameSessionsRequest request) 
        {
            return new SearchGameSessionsPaginator(this.client, request);
        }
    }
}