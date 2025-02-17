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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */

#pragma warning disable CS0612,CS0618
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Paginators for the DataZone service
    ///</summary>
    public interface IDataZonePaginatorFactory
    {

        /// <summary>
        /// Paginator for ListAssetFilters operation
        ///</summary>
        IListAssetFiltersPaginator ListAssetFilters(ListAssetFiltersRequest request);

        /// <summary>
        /// Paginator for ListAssetRevisions operation
        ///</summary>
        IListAssetRevisionsPaginator ListAssetRevisions(ListAssetRevisionsRequest request);

        /// <summary>
        /// Paginator for ListConnections operation
        ///</summary>
        IListConnectionsPaginator ListConnections(ListConnectionsRequest request);

        /// <summary>
        /// Paginator for ListDataProductRevisions operation
        ///</summary>
        IListDataProductRevisionsPaginator ListDataProductRevisions(ListDataProductRevisionsRequest request);

        /// <summary>
        /// Paginator for ListDataSourceRunActivities operation
        ///</summary>
        IListDataSourceRunActivitiesPaginator ListDataSourceRunActivities(ListDataSourceRunActivitiesRequest request);

        /// <summary>
        /// Paginator for ListDataSourceRuns operation
        ///</summary>
        IListDataSourceRunsPaginator ListDataSourceRuns(ListDataSourceRunsRequest request);

        /// <summary>
        /// Paginator for ListDataSources operation
        ///</summary>
        IListDataSourcesPaginator ListDataSources(ListDataSourcesRequest request);

        /// <summary>
        /// Paginator for ListDomains operation
        ///</summary>
        IListDomainsPaginator ListDomains(ListDomainsRequest request);

        /// <summary>
        /// Paginator for ListDomainUnitsForParent operation
        ///</summary>
        IListDomainUnitsForParentPaginator ListDomainUnitsForParent(ListDomainUnitsForParentRequest request);

        /// <summary>
        /// Paginator for ListEntityOwners operation
        ///</summary>
        IListEntityOwnersPaginator ListEntityOwners(ListEntityOwnersRequest request);

        /// <summary>
        /// Paginator for ListEnvironmentActions operation
        ///</summary>
        IListEnvironmentActionsPaginator ListEnvironmentActions(ListEnvironmentActionsRequest request);

        /// <summary>
        /// Paginator for ListEnvironmentBlueprintConfigurations operation
        ///</summary>
        IListEnvironmentBlueprintConfigurationsPaginator ListEnvironmentBlueprintConfigurations(ListEnvironmentBlueprintConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListEnvironmentBlueprints operation
        ///</summary>
        IListEnvironmentBlueprintsPaginator ListEnvironmentBlueprints(ListEnvironmentBlueprintsRequest request);

        /// <summary>
        /// Paginator for ListEnvironmentProfiles operation
        ///</summary>
        IListEnvironmentProfilesPaginator ListEnvironmentProfiles(ListEnvironmentProfilesRequest request);

        /// <summary>
        /// Paginator for ListEnvironments operation
        ///</summary>
        IListEnvironmentsPaginator ListEnvironments(ListEnvironmentsRequest request);

        /// <summary>
        /// Paginator for ListJobRuns operation
        ///</summary>
        IListJobRunsPaginator ListJobRuns(ListJobRunsRequest request);

        /// <summary>
        /// Paginator for ListLineageEvents operation
        ///</summary>
        IListLineageEventsPaginator ListLineageEvents(ListLineageEventsRequest request);

        /// <summary>
        /// Paginator for ListLineageNodeHistory operation
        ///</summary>
        IListLineageNodeHistoryPaginator ListLineageNodeHistory(ListLineageNodeHistoryRequest request);

        /// <summary>
        /// Paginator for ListMetadataGenerationRuns operation
        ///</summary>
        IListMetadataGenerationRunsPaginator ListMetadataGenerationRuns(ListMetadataGenerationRunsRequest request);

        /// <summary>
        /// Paginator for ListNotifications operation
        ///</summary>
        IListNotificationsPaginator ListNotifications(ListNotificationsRequest request);

        /// <summary>
        /// Paginator for ListPolicyGrants operation
        ///</summary>
        IListPolicyGrantsPaginator ListPolicyGrants(ListPolicyGrantsRequest request);

        /// <summary>
        /// Paginator for ListProjectMemberships operation
        ///</summary>
        IListProjectMembershipsPaginator ListProjectMemberships(ListProjectMembershipsRequest request);

        /// <summary>
        /// Paginator for ListProjectProfiles operation
        ///</summary>
        IListProjectProfilesPaginator ListProjectProfiles(ListProjectProfilesRequest request);

        /// <summary>
        /// Paginator for ListProjects operation
        ///</summary>
        IListProjectsPaginator ListProjects(ListProjectsRequest request);

        /// <summary>
        /// Paginator for ListRules operation
        ///</summary>
        IListRulesPaginator ListRules(ListRulesRequest request);

        /// <summary>
        /// Paginator for ListSubscriptionGrants operation
        ///</summary>
        IListSubscriptionGrantsPaginator ListSubscriptionGrants(ListSubscriptionGrantsRequest request);

        /// <summary>
        /// Paginator for ListSubscriptionRequests operation
        ///</summary>
        IListSubscriptionRequestsPaginator ListSubscriptionRequests(ListSubscriptionRequestsRequest request);

        /// <summary>
        /// Paginator for ListSubscriptions operation
        ///</summary>
        IListSubscriptionsPaginator ListSubscriptions(ListSubscriptionsRequest request);

        /// <summary>
        /// Paginator for ListSubscriptionTargets operation
        ///</summary>
        IListSubscriptionTargetsPaginator ListSubscriptionTargets(ListSubscriptionTargetsRequest request);

        /// <summary>
        /// Paginator for ListTimeSeriesDataPoints operation
        ///</summary>
        IListTimeSeriesDataPointsPaginator ListTimeSeriesDataPoints(ListTimeSeriesDataPointsRequest request);

        /// <summary>
        /// Paginator for Search operation
        ///</summary>
        ISearchPaginator Search(SearchRequest request);

        /// <summary>
        /// Paginator for SearchGroupProfiles operation
        ///</summary>
        ISearchGroupProfilesPaginator SearchGroupProfiles(SearchGroupProfilesRequest request);

        /// <summary>
        /// Paginator for SearchListings operation
        ///</summary>
        ISearchListingsPaginator SearchListings(SearchListingsRequest request);

        /// <summary>
        /// Paginator for SearchTypes operation
        ///</summary>
        ISearchTypesPaginator SearchTypes(SearchTypesRequest request);

        /// <summary>
        /// Paginator for SearchUserProfiles operation
        ///</summary>
        ISearchUserProfilesPaginator SearchUserProfiles(SearchUserProfilesRequest request);
    }
}