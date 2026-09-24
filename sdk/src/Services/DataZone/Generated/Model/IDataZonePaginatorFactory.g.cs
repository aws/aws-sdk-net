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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Paginators for the DataZone service
    /// </summary>
    public interface IDataZonePaginatorFactory
    {
        /// <summary>
        /// Paginator for ListAccountPools operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAccountPoolsPaginator ListAccountPools(ListAccountPoolsRequest request);

        /// <summary>
        /// Paginator for ListAccountsInAccountPool operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAccountsInAccountPoolPaginator ListAccountsInAccountPool(ListAccountsInAccountPoolRequest request);

        /// <summary>
        /// Paginator for ListAssetFilters operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAssetFiltersPaginator ListAssetFilters(ListAssetFiltersRequest request);

        /// <summary>
        /// Paginator for ListAssetRevisions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAssetRevisionsPaginator ListAssetRevisions(ListAssetRevisionsRequest request);

        /// <summary>
        /// Paginator for ListConnections operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListConnectionsPaginator ListConnections(ListConnectionsRequest request);

        /// <summary>
        /// Paginator for ListDataProductRevisions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDataProductRevisionsPaginator ListDataProductRevisions(ListDataProductRevisionsRequest request);

        /// <summary>
        /// Paginator for ListDataSourceRunActivities operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDataSourceRunActivitiesPaginator ListDataSourceRunActivities(ListDataSourceRunActivitiesRequest request);

        /// <summary>
        /// Paginator for ListDataSourceRuns operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDataSourceRunsPaginator ListDataSourceRuns(ListDataSourceRunsRequest request);

        /// <summary>
        /// Paginator for ListDataSources operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDataSourcesPaginator ListDataSources(ListDataSourcesRequest request);

        /// <summary>
        /// Paginator for ListDomainUnitsForParent operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDomainUnitsForParentPaginator ListDomainUnitsForParent(ListDomainUnitsForParentRequest request);

        /// <summary>
        /// Paginator for ListDomains operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDomainsPaginator ListDomains(ListDomainsRequest request);

        /// <summary>
        /// Paginator for ListEntityOwners operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListEntityOwnersPaginator ListEntityOwners(ListEntityOwnersRequest request);

        /// <summary>
        /// Paginator for ListEnvironmentActions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListEnvironmentActionsPaginator ListEnvironmentActions(ListEnvironmentActionsRequest request);

        /// <summary>
        /// Paginator for ListEnvironmentBlueprintConfigurations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListEnvironmentBlueprintConfigurationsPaginator ListEnvironmentBlueprintConfigurations(ListEnvironmentBlueprintConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListEnvironmentBlueprints operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListEnvironmentBlueprintsPaginator ListEnvironmentBlueprints(ListEnvironmentBlueprintsRequest request);

        /// <summary>
        /// Paginator for ListEnvironmentProfiles operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListEnvironmentProfilesPaginator ListEnvironmentProfiles(ListEnvironmentProfilesRequest request);

        /// <summary>
        /// Paginator for ListEnvironments operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListEnvironmentsPaginator ListEnvironments(ListEnvironmentsRequest request);

        /// <summary>
        /// Paginator for ListJobRuns operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListJobRunsPaginator ListJobRuns(ListJobRunsRequest request);

        /// <summary>
        /// Paginator for ListLineageEvents operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListLineageEventsPaginator ListLineageEvents(ListLineageEventsRequest request);

        /// <summary>
        /// Paginator for ListLineageNodeHistory operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListLineageNodeHistoryPaginator ListLineageNodeHistory(ListLineageNodeHistoryRequest request);

        /// <summary>
        /// Paginator for ListMetadataGenerationRuns operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListMetadataGenerationRunsPaginator ListMetadataGenerationRuns(ListMetadataGenerationRunsRequest request);

        /// <summary>
        /// Paginator for ListNotebookRuns operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListNotebookRunsPaginator ListNotebookRuns(ListNotebookRunsRequest request);

        /// <summary>
        /// Paginator for ListNotebooks operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListNotebooksPaginator ListNotebooks(ListNotebooksRequest request);

        /// <summary>
        /// Paginator for ListNotifications operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListNotificationsPaginator ListNotifications(ListNotificationsRequest request);

        /// <summary>
        /// Paginator for ListPolicyGrants operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPolicyGrantsPaginator ListPolicyGrants(ListPolicyGrantsRequest request);

        /// <summary>
        /// Paginator for ListProjectMemberships operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListProjectMembershipsPaginator ListProjectMemberships(ListProjectMembershipsRequest request);

        /// <summary>
        /// Paginator for ListProjectProfiles operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListProjectProfilesPaginator ListProjectProfiles(ListProjectProfilesRequest request);

        /// <summary>
        /// Paginator for ListProjects operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListProjectsPaginator ListProjects(ListProjectsRequest request);

        /// <summary>
        /// Paginator for ListRules operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListRulesPaginator ListRules(ListRulesRequest request);

        /// <summary>
        /// Paginator for ListSubscriptionGrants operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSubscriptionGrantsPaginator ListSubscriptionGrants(ListSubscriptionGrantsRequest request);

        /// <summary>
        /// Paginator for ListSubscriptionRequests operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSubscriptionRequestsPaginator ListSubscriptionRequests(ListSubscriptionRequestsRequest request);

        /// <summary>
        /// Paginator for ListSubscriptionTargets operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSubscriptionTargetsPaginator ListSubscriptionTargets(ListSubscriptionTargetsRequest request);

        /// <summary>
        /// Paginator for ListSubscriptions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSubscriptionsPaginator ListSubscriptions(ListSubscriptionsRequest request);

        /// <summary>
        /// Paginator for ListTimeSeriesDataPoints operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTimeSeriesDataPointsPaginator ListTimeSeriesDataPoints(ListTimeSeriesDataPointsRequest request);

        /// <summary>
        /// Paginator for QueryGraph operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IQueryGraphPaginator QueryGraph(QueryGraphRequest request);

        /// <summary>
        /// Paginator for Search operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchPaginator Search(SearchRequest request);

        /// <summary>
        /// Paginator for SearchGroupProfiles operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchGroupProfilesPaginator SearchGroupProfiles(SearchGroupProfilesRequest request);

        /// <summary>
        /// Paginator for SearchListings operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchListingsPaginator SearchListings(SearchListingsRequest request);

        /// <summary>
        /// Paginator for SearchTypes operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchTypesPaginator SearchTypes(SearchTypesRequest request);

        /// <summary>
        /// Paginator for SearchUserProfiles operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchUserProfilesPaginator SearchUserProfiles(SearchUserProfilesRequest request);
    }
}
