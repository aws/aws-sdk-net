#if !NETSTANDARD13
/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Paginators for the Macie2 service
    ///</summary>
    public interface IMacie2PaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeBuckets operation
        ///</summary>
        IDescribeBucketsPaginator DescribeBuckets(DescribeBucketsRequest request);

        /// <summary>
        /// Paginator for GetUsageStatistics operation
        ///</summary>
        IGetUsageStatisticsPaginator GetUsageStatistics(GetUsageStatisticsRequest request);

        /// <summary>
        /// Paginator for ListClassificationJobs operation
        ///</summary>
        IListClassificationJobsPaginator ListClassificationJobs(ListClassificationJobsRequest request);

        /// <summary>
        /// Paginator for ListCustomDataIdentifiers operation
        ///</summary>
        IListCustomDataIdentifiersPaginator ListCustomDataIdentifiers(ListCustomDataIdentifiersRequest request);

        /// <summary>
        /// Paginator for ListFindings operation
        ///</summary>
        IListFindingsPaginator ListFindings(ListFindingsRequest request);

        /// <summary>
        /// Paginator for ListFindingsFilters operation
        ///</summary>
        IListFindingsFiltersPaginator ListFindingsFilters(ListFindingsFiltersRequest request);

        /// <summary>
        /// Paginator for ListInvitations operation
        ///</summary>
        IListInvitationsPaginator ListInvitations(ListInvitationsRequest request);

        /// <summary>
        /// Paginator for ListMembers operation
        ///</summary>
        IListMembersPaginator ListMembers(ListMembersRequest request);

        /// <summary>
        /// Paginator for ListOrganizationAdminAccounts operation
        ///</summary>
        IListOrganizationAdminAccountsPaginator ListOrganizationAdminAccounts(ListOrganizationAdminAccountsRequest request);
    }
}
#endif