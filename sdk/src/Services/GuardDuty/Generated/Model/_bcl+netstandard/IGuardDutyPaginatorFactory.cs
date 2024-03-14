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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Paginators for the GuardDuty service
    ///</summary>
    public interface IGuardDutyPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeMalwareScans operation
        ///</summary>
        IDescribeMalwareScansPaginator DescribeMalwareScans(DescribeMalwareScansRequest request);

        /// <summary>
        /// Paginator for DescribeOrganizationConfiguration operation
        ///</summary>
        IDescribeOrganizationConfigurationPaginator DescribeOrganizationConfiguration(DescribeOrganizationConfigurationRequest request);

        /// <summary>
        /// Paginator for GetUsageStatistics operation
        ///</summary>
        IGetUsageStatisticsPaginator GetUsageStatistics(GetUsageStatisticsRequest request);

        /// <summary>
        /// Paginator for ListCoverage operation
        ///</summary>
        IListCoveragePaginator ListCoverage(ListCoverageRequest request);

        /// <summary>
        /// Paginator for ListDetectors operation
        ///</summary>
        IListDetectorsPaginator ListDetectors(ListDetectorsRequest request);

        /// <summary>
        /// Paginator for ListFilters operation
        ///</summary>
        IListFiltersPaginator ListFilters(ListFiltersRequest request);

        /// <summary>
        /// Paginator for ListFindings operation
        ///</summary>
        IListFindingsPaginator ListFindings(ListFindingsRequest request);

        /// <summary>
        /// Paginator for ListInvitations operation
        ///</summary>
        IListInvitationsPaginator ListInvitations(ListInvitationsRequest request);

        /// <summary>
        /// Paginator for ListIPSets operation
        ///</summary>
        IListIPSetsPaginator ListIPSets(ListIPSetsRequest request);

        /// <summary>
        /// Paginator for ListMembers operation
        ///</summary>
        IListMembersPaginator ListMembers(ListMembersRequest request);

        /// <summary>
        /// Paginator for ListOrganizationAdminAccounts operation
        ///</summary>
        IListOrganizationAdminAccountsPaginator ListOrganizationAdminAccounts(ListOrganizationAdminAccountsRequest request);

        /// <summary>
        /// Paginator for ListPublishingDestinations operation
        ///</summary>
        IListPublishingDestinationsPaginator ListPublishingDestinations(ListPublishingDestinationsRequest request);

        /// <summary>
        /// Paginator for ListThreatIntelSets operation
        ///</summary>
        IListThreatIntelSetsPaginator ListThreatIntelSets(ListThreatIntelSetsRequest request);
    }
}