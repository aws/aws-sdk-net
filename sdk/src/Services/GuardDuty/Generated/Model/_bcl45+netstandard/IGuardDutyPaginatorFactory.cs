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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
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
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeMalwareScansPaginator DescribeMalwareScans(DescribeMalwareScansRequest request);

        /// <summary>
        /// Paginator for DescribeOrganizationConfiguration operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeOrganizationConfigurationPaginator DescribeOrganizationConfiguration(DescribeOrganizationConfigurationRequest request);

        /// <summary>
        /// Paginator for GetUsageStatistics operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetUsageStatisticsPaginator GetUsageStatistics(GetUsageStatisticsRequest request);

        /// <summary>
        /// Paginator for ListCoverage operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCoveragePaginator ListCoverage(ListCoverageRequest request);

        /// <summary>
        /// Paginator for ListDetectors operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDetectorsPaginator ListDetectors(ListDetectorsRequest request);

        /// <summary>
        /// Paginator for ListFilters operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFiltersPaginator ListFilters(ListFiltersRequest request);

        /// <summary>
        /// Paginator for ListFindings operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFindingsPaginator ListFindings(ListFindingsRequest request);

        /// <summary>
        /// Paginator for ListInvitations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListInvitationsPaginator ListInvitations(ListInvitationsRequest request);

        /// <summary>
        /// Paginator for ListIPSets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListIPSetsPaginator ListIPSets(ListIPSetsRequest request);

        /// <summary>
        /// Paginator for ListMembers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMembersPaginator ListMembers(ListMembersRequest request);

        /// <summary>
        /// Paginator for ListOrganizationAdminAccounts operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListOrganizationAdminAccountsPaginator ListOrganizationAdminAccounts(ListOrganizationAdminAccountsRequest request);

        /// <summary>
        /// Paginator for ListPublishingDestinations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPublishingDestinationsPaginator ListPublishingDestinations(ListPublishingDestinationsRequest request);

        /// <summary>
        /// Paginator for ListThreatEntitySets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListThreatEntitySetsPaginator ListThreatEntitySets(ListThreatEntitySetsRequest request);

        /// <summary>
        /// Paginator for ListThreatIntelSets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListThreatIntelSetsPaginator ListThreatIntelSets(ListThreatIntelSetsRequest request);

        /// <summary>
        /// Paginator for ListTrustedEntitySets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTrustedEntitySetsPaginator ListTrustedEntitySets(ListTrustedEntitySetsRequest request);
    }
}