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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Paginators for the DataZone service
    ///</summary>
    public class DataZonePaginatorFactory : IDataZonePaginatorFactory
    {
        private readonly IAmazonDataZone client;

        internal DataZonePaginatorFactory(IAmazonDataZone client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAccountPools operation
        ///</summary>
        public IListAccountPoolsPaginator ListAccountPools(ListAccountPoolsRequest request) 
        {
            return new ListAccountPoolsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAccountsInAccountPool operation
        ///</summary>
        public IListAccountsInAccountPoolPaginator ListAccountsInAccountPool(ListAccountsInAccountPoolRequest request) 
        {
            return new ListAccountsInAccountPoolPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAssetFilters operation
        ///</summary>
        public IListAssetFiltersPaginator ListAssetFilters(ListAssetFiltersRequest request) 
        {
            return new ListAssetFiltersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAssetRevisions operation
        ///</summary>
        public IListAssetRevisionsPaginator ListAssetRevisions(ListAssetRevisionsRequest request) 
        {
            return new ListAssetRevisionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListConnections operation
        ///</summary>
        public IListConnectionsPaginator ListConnections(ListConnectionsRequest request) 
        {
            return new ListConnectionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDataProductRevisions operation
        ///</summary>
        public IListDataProductRevisionsPaginator ListDataProductRevisions(ListDataProductRevisionsRequest request) 
        {
            return new ListDataProductRevisionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDataSourceRunActivities operation
        ///</summary>
        public IListDataSourceRunActivitiesPaginator ListDataSourceRunActivities(ListDataSourceRunActivitiesRequest request) 
        {
            return new ListDataSourceRunActivitiesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDataSourceRuns operation
        ///</summary>
        public IListDataSourceRunsPaginator ListDataSourceRuns(ListDataSourceRunsRequest request) 
        {
            return new ListDataSourceRunsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDataSources operation
        ///</summary>
        public IListDataSourcesPaginator ListDataSources(ListDataSourcesRequest request) 
        {
            return new ListDataSourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDomains operation
        ///</summary>
        public IListDomainsPaginator ListDomains(ListDomainsRequest request) 
        {
            return new ListDomainsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDomainUnitsForParent operation
        ///</summary>
        public IListDomainUnitsForParentPaginator ListDomainUnitsForParent(ListDomainUnitsForParentRequest request) 
        {
            return new ListDomainUnitsForParentPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEntityOwners operation
        ///</summary>
        public IListEntityOwnersPaginator ListEntityOwners(ListEntityOwnersRequest request) 
        {
            return new ListEntityOwnersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEnvironmentActions operation
        ///</summary>
        public IListEnvironmentActionsPaginator ListEnvironmentActions(ListEnvironmentActionsRequest request) 
        {
            return new ListEnvironmentActionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEnvironmentBlueprintConfigurations operation
        ///</summary>
        public IListEnvironmentBlueprintConfigurationsPaginator ListEnvironmentBlueprintConfigurations(ListEnvironmentBlueprintConfigurationsRequest request) 
        {
            return new ListEnvironmentBlueprintConfigurationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEnvironmentBlueprints operation
        ///</summary>
        public IListEnvironmentBlueprintsPaginator ListEnvironmentBlueprints(ListEnvironmentBlueprintsRequest request) 
        {
            return new ListEnvironmentBlueprintsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEnvironmentProfiles operation
        ///</summary>
        public IListEnvironmentProfilesPaginator ListEnvironmentProfiles(ListEnvironmentProfilesRequest request) 
        {
            return new ListEnvironmentProfilesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEnvironments operation
        ///</summary>
        public IListEnvironmentsPaginator ListEnvironments(ListEnvironmentsRequest request) 
        {
            return new ListEnvironmentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListJobRuns operation
        ///</summary>
        public IListJobRunsPaginator ListJobRuns(ListJobRunsRequest request) 
        {
            return new ListJobRunsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListLineageEvents operation
        ///</summary>
        public IListLineageEventsPaginator ListLineageEvents(ListLineageEventsRequest request) 
        {
            return new ListLineageEventsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListLineageNodeHistory operation
        ///</summary>
        public IListLineageNodeHistoryPaginator ListLineageNodeHistory(ListLineageNodeHistoryRequest request) 
        {
            return new ListLineageNodeHistoryPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMetadataGenerationRuns operation
        ///</summary>
        public IListMetadataGenerationRunsPaginator ListMetadataGenerationRuns(ListMetadataGenerationRunsRequest request) 
        {
            return new ListMetadataGenerationRunsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListNotifications operation
        ///</summary>
        public IListNotificationsPaginator ListNotifications(ListNotificationsRequest request) 
        {
            return new ListNotificationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPolicyGrants operation
        ///</summary>
        public IListPolicyGrantsPaginator ListPolicyGrants(ListPolicyGrantsRequest request) 
        {
            return new ListPolicyGrantsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProjectMemberships operation
        ///</summary>
        public IListProjectMembershipsPaginator ListProjectMemberships(ListProjectMembershipsRequest request) 
        {
            return new ListProjectMembershipsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProjectProfiles operation
        ///</summary>
        public IListProjectProfilesPaginator ListProjectProfiles(ListProjectProfilesRequest request) 
        {
            return new ListProjectProfilesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProjects operation
        ///</summary>
        public IListProjectsPaginator ListProjects(ListProjectsRequest request) 
        {
            return new ListProjectsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRules operation
        ///</summary>
        public IListRulesPaginator ListRules(ListRulesRequest request) 
        {
            return new ListRulesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSubscriptionGrants operation
        ///</summary>
        public IListSubscriptionGrantsPaginator ListSubscriptionGrants(ListSubscriptionGrantsRequest request) 
        {
            return new ListSubscriptionGrantsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSubscriptionRequests operation
        ///</summary>
        public IListSubscriptionRequestsPaginator ListSubscriptionRequests(ListSubscriptionRequestsRequest request) 
        {
            return new ListSubscriptionRequestsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSubscriptions operation
        ///</summary>
        public IListSubscriptionsPaginator ListSubscriptions(ListSubscriptionsRequest request) 
        {
            return new ListSubscriptionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSubscriptionTargets operation
        ///</summary>
        public IListSubscriptionTargetsPaginator ListSubscriptionTargets(ListSubscriptionTargetsRequest request) 
        {
            return new ListSubscriptionTargetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTimeSeriesDataPoints operation
        ///</summary>
        public IListTimeSeriesDataPointsPaginator ListTimeSeriesDataPoints(ListTimeSeriesDataPointsRequest request) 
        {
            return new ListTimeSeriesDataPointsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for Search operation
        ///</summary>
        public ISearchPaginator Search(SearchRequest request) 
        {
            return new SearchPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchGroupProfiles operation
        ///</summary>
        public ISearchGroupProfilesPaginator SearchGroupProfiles(SearchGroupProfilesRequest request) 
        {
            return new SearchGroupProfilesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchListings operation
        ///</summary>
        public ISearchListingsPaginator SearchListings(SearchListingsRequest request) 
        {
            return new SearchListingsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchTypes operation
        ///</summary>
        public ISearchTypesPaginator SearchTypes(SearchTypesRequest request) 
        {
            return new SearchTypesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchUserProfiles operation
        ///</summary>
        public ISearchUserProfilesPaginator SearchUserProfiles(SearchUserProfilesRequest request) 
        {
            return new SearchUserProfilesPaginator(this.client, request);
        }
    }
}