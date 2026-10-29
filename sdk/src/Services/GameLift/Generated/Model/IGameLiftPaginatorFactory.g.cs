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

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Paginators for the GameLift service
    /// </summary>
    public interface IGameLiftPaginatorFactory
    {
        /// <summary>
        /// Paginator for DescribeFleetAttributes operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IDescribeFleetAttributesPaginator DescribeFleetAttributes(DescribeFleetAttributesRequest request);

        /// <summary>
        /// Paginator for DescribeFleetCapacity operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IDescribeFleetCapacityPaginator DescribeFleetCapacity(DescribeFleetCapacityRequest request);

        /// <summary>
        /// Paginator for DescribeFleetEvents operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IDescribeFleetEventsPaginator DescribeFleetEvents(DescribeFleetEventsRequest request);

        /// <summary>
        /// Paginator for DescribeFleetLocationAttributes operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IDescribeFleetLocationAttributesPaginator DescribeFleetLocationAttributes(DescribeFleetLocationAttributesRequest request);

        /// <summary>
        /// Paginator for DescribeFleetUtilization operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IDescribeFleetUtilizationPaginator DescribeFleetUtilization(DescribeFleetUtilizationRequest request);

        /// <summary>
        /// Paginator for DescribeGameServerInstances operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IDescribeGameServerInstancesPaginator DescribeGameServerInstances(DescribeGameServerInstancesRequest request);

        /// <summary>
        /// Paginator for DescribeGameSessionDetails operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IDescribeGameSessionDetailsPaginator DescribeGameSessionDetails(DescribeGameSessionDetailsRequest request);

        /// <summary>
        /// Paginator for DescribeGameSessionQueues operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IDescribeGameSessionQueuesPaginator DescribeGameSessionQueues(DescribeGameSessionQueuesRequest request);

        /// <summary>
        /// Paginator for DescribeGameSessions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IDescribeGameSessionsPaginator DescribeGameSessions(DescribeGameSessionsRequest request);

        /// <summary>
        /// Paginator for DescribeInstances operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IDescribeInstancesPaginator DescribeInstances(DescribeInstancesRequest request);

        /// <summary>
        /// Paginator for DescribeMatchmakingConfigurations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IDescribeMatchmakingConfigurationsPaginator DescribeMatchmakingConfigurations(DescribeMatchmakingConfigurationsRequest request);

        /// <summary>
        /// Paginator for DescribeMatchmakingRuleSets operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IDescribeMatchmakingRuleSetsPaginator DescribeMatchmakingRuleSets(DescribeMatchmakingRuleSetsRequest request);

        /// <summary>
        /// Paginator for DescribePlayerSessions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IDescribePlayerSessionsPaginator DescribePlayerSessions(DescribePlayerSessionsRequest request);

        /// <summary>
        /// Paginator for DescribeScalingPolicies operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IDescribeScalingPoliciesPaginator DescribeScalingPolicies(DescribeScalingPoliciesRequest request);

        /// <summary>
        /// Paginator for ListAliases operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IListAliasesPaginator ListAliases(ListAliasesRequest request);

        /// <summary>
        /// Paginator for ListBuilds operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IListBuildsPaginator ListBuilds(ListBuildsRequest request);

        /// <summary>
        /// Paginator for ListCompute operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IListComputePaginator ListCompute(ListComputeRequest request);

        /// <summary>
        /// Paginator for ListContainerFleets operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IListContainerFleetsPaginator ListContainerFleets(ListContainerFleetsRequest request);

        /// <summary>
        /// Paginator for ListContainerGroupDefinitionVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IListContainerGroupDefinitionVersionsPaginator ListContainerGroupDefinitionVersions(ListContainerGroupDefinitionVersionsRequest request);

        /// <summary>
        /// Paginator for ListContainerGroupDefinitions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IListContainerGroupDefinitionsPaginator ListContainerGroupDefinitions(ListContainerGroupDefinitionsRequest request);

        /// <summary>
        /// Paginator for ListFleetDeployments operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IListFleetDeploymentsPaginator ListFleetDeployments(ListFleetDeploymentsRequest request);

        /// <summary>
        /// Paginator for ListFleets operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IListFleetsPaginator ListFleets(ListFleetsRequest request);

        /// <summary>
        /// Paginator for ListGameServerGroups operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IListGameServerGroupsPaginator ListGameServerGroups(ListGameServerGroupsRequest request);

        /// <summary>
        /// Paginator for ListGameServers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IListGameServersPaginator ListGameServers(ListGameServersRequest request);

        /// <summary>
        /// Paginator for ListLocations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IListLocationsPaginator ListLocations(ListLocationsRequest request);

        /// <summary>
        /// Paginator for ListScripts operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IListScriptsPaginator ListScripts(ListScriptsRequest request);

        /// <summary>
        /// Paginator for SearchGameSessions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        ISearchGameSessionsPaginator SearchGameSessions(SearchGameSessionsRequest request);
    }
}
