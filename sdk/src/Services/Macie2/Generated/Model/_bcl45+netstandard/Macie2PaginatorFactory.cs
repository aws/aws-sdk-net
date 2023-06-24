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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Paginators for the Macie2 service
    ///</summary>
    public class Macie2PaginatorFactory : IMacie2PaginatorFactory
    {
        private readonly IAmazonMacie2 client;

        internal Macie2PaginatorFactory(IAmazonMacie2 client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeBuckets operation
        ///</summary>
        public IDescribeBucketsPaginator DescribeBuckets(DescribeBucketsRequest request) 
        {
            return new DescribeBucketsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetUsageStatistics operation
        ///</summary>
        public IGetUsageStatisticsPaginator GetUsageStatistics(GetUsageStatisticsRequest request) 
        {
            return new GetUsageStatisticsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAllowLists operation
        ///</summary>
        public IListAllowListsPaginator ListAllowLists(ListAllowListsRequest request) 
        {
            return new ListAllowListsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListClassificationJobs operation
        ///</summary>
        public IListClassificationJobsPaginator ListClassificationJobs(ListClassificationJobsRequest request) 
        {
            return new ListClassificationJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListClassificationScopes operation
        ///</summary>
        public IListClassificationScopesPaginator ListClassificationScopes(ListClassificationScopesRequest request) 
        {
            return new ListClassificationScopesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCustomDataIdentifiers operation
        ///</summary>
        public IListCustomDataIdentifiersPaginator ListCustomDataIdentifiers(ListCustomDataIdentifiersRequest request) 
        {
            return new ListCustomDataIdentifiersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFindings operation
        ///</summary>
        public IListFindingsPaginator ListFindings(ListFindingsRequest request) 
        {
            return new ListFindingsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFindingsFilters operation
        ///</summary>
        public IListFindingsFiltersPaginator ListFindingsFilters(ListFindingsFiltersRequest request) 
        {
            return new ListFindingsFiltersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListInvitations operation
        ///</summary>
        public IListInvitationsPaginator ListInvitations(ListInvitationsRequest request) 
        {
            return new ListInvitationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListManagedDataIdentifiers operation
        ///</summary>
        public IListManagedDataIdentifiersPaginator ListManagedDataIdentifiers(ListManagedDataIdentifiersRequest request) 
        {
            return new ListManagedDataIdentifiersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMembers operation
        ///</summary>
        public IListMembersPaginator ListMembers(ListMembersRequest request) 
        {
            return new ListMembersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListOrganizationAdminAccounts operation
        ///</summary>
        public IListOrganizationAdminAccountsPaginator ListOrganizationAdminAccounts(ListOrganizationAdminAccountsRequest request) 
        {
            return new ListOrganizationAdminAccountsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListResourceProfileArtifacts operation
        ///</summary>
        public IListResourceProfileArtifactsPaginator ListResourceProfileArtifacts(ListResourceProfileArtifactsRequest request) 
        {
            return new ListResourceProfileArtifactsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListResourceProfileDetections operation
        ///</summary>
        public IListResourceProfileDetectionsPaginator ListResourceProfileDetections(ListResourceProfileDetectionsRequest request) 
        {
            return new ListResourceProfileDetectionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSensitivityInspectionTemplates operation
        ///</summary>
        public IListSensitivityInspectionTemplatesPaginator ListSensitivityInspectionTemplates(ListSensitivityInspectionTemplatesRequest request) 
        {
            return new ListSensitivityInspectionTemplatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchResources operation
        ///</summary>
        public ISearchResourcesPaginator SearchResources(SearchResourcesRequest request) 
        {
            return new SearchResourcesPaginator(this.client, request);
        }
    }
}