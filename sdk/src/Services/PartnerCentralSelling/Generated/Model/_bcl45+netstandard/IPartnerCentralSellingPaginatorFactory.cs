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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
 */

#pragma warning disable CS0612,CS0618
namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Paginators for the PartnerCentralSelling service
    ///</summary>
    public interface IPartnerCentralSellingPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListEngagementByAcceptingInvitationTasks operation
        ///</summary>
        IListEngagementByAcceptingInvitationTasksPaginator ListEngagementByAcceptingInvitationTasks(ListEngagementByAcceptingInvitationTasksRequest request);

        /// <summary>
        /// Paginator for ListEngagementFromOpportunityTasks operation
        ///</summary>
        IListEngagementFromOpportunityTasksPaginator ListEngagementFromOpportunityTasks(ListEngagementFromOpportunityTasksRequest request);

        /// <summary>
        /// Paginator for ListEngagementInvitations operation
        ///</summary>
        IListEngagementInvitationsPaginator ListEngagementInvitations(ListEngagementInvitationsRequest request);

        /// <summary>
        /// Paginator for ListEngagementMembers operation
        ///</summary>
        IListEngagementMembersPaginator ListEngagementMembers(ListEngagementMembersRequest request);

        /// <summary>
        /// Paginator for ListEngagementResourceAssociations operation
        ///</summary>
        IListEngagementResourceAssociationsPaginator ListEngagementResourceAssociations(ListEngagementResourceAssociationsRequest request);

        /// <summary>
        /// Paginator for ListEngagements operation
        ///</summary>
        IListEngagementsPaginator ListEngagements(ListEngagementsRequest request);

        /// <summary>
        /// Paginator for ListOpportunities operation
        ///</summary>
        IListOpportunitiesPaginator ListOpportunities(ListOpportunitiesRequest request);

        /// <summary>
        /// Paginator for ListResourceSnapshotJobs operation
        ///</summary>
        IListResourceSnapshotJobsPaginator ListResourceSnapshotJobs(ListResourceSnapshotJobsRequest request);

        /// <summary>
        /// Paginator for ListResourceSnapshots operation
        ///</summary>
        IListResourceSnapshotsPaginator ListResourceSnapshots(ListResourceSnapshotsRequest request);

        /// <summary>
        /// Paginator for ListSolutions operation
        ///</summary>
        IListSolutionsPaginator ListSolutions(ListSolutionsRequest request);
    }
}