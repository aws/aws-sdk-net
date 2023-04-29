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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Paginators for the GuardDuty service
    ///</summary>
    public class GuardDutyPaginatorFactory : IGuardDutyPaginatorFactory
    {
        private readonly IAmazonGuardDuty client;

        internal GuardDutyPaginatorFactory(IAmazonGuardDuty client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeMalwareScans operation
        ///</summary>
        public IDescribeMalwareScansPaginator DescribeMalwareScans(DescribeMalwareScansRequest request) 
        {
            return new DescribeMalwareScansPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeOrganizationConfiguration operation
        ///</summary>
        public IDescribeOrganizationConfigurationPaginator DescribeOrganizationConfiguration(DescribeOrganizationConfigurationRequest request) 
        {
            return new DescribeOrganizationConfigurationPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetUsageStatistics operation
        ///</summary>
        public IGetUsageStatisticsPaginator GetUsageStatistics(GetUsageStatisticsRequest request) 
        {
            return new GetUsageStatisticsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCoverage operation
        ///</summary>
        public IListCoveragePaginator ListCoverage(ListCoverageRequest request) 
        {
            return new ListCoveragePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDetectors operation
        ///</summary>
        public IListDetectorsPaginator ListDetectors(ListDetectorsRequest request) 
        {
            return new ListDetectorsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFilters operation
        ///</summary>
        public IListFiltersPaginator ListFilters(ListFiltersRequest request) 
        {
            return new ListFiltersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFindings operation
        ///</summary>
        public IListFindingsPaginator ListFindings(ListFindingsRequest request) 
        {
            return new ListFindingsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListInvitations operation
        ///</summary>
        public IListInvitationsPaginator ListInvitations(ListInvitationsRequest request) 
        {
            return new ListInvitationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListIPSets operation
        ///</summary>
        public IListIPSetsPaginator ListIPSets(ListIPSetsRequest request) 
        {
            return new ListIPSetsPaginator(this.client, request);
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
        /// Paginator for ListPublishingDestinations operation
        ///</summary>
        public IListPublishingDestinationsPaginator ListPublishingDestinations(ListPublishingDestinationsRequest request) 
        {
            return new ListPublishingDestinationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListThreatIntelSets operation
        ///</summary>
        public IListThreatIntelSetsPaginator ListThreatIntelSets(ListThreatIntelSetsRequest request) 
        {
            return new ListThreatIntelSetsPaginator(this.client, request);
        }
    }
}