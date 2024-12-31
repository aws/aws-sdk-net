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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Paginators for the PartnerCentralSelling service
    ///</summary>
    public class PartnerCentralSellingPaginatorFactory : IPartnerCentralSellingPaginatorFactory
    {
        private readonly IAmazonPartnerCentralSelling client;

        internal PartnerCentralSellingPaginatorFactory(IAmazonPartnerCentralSelling client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListEngagementByAcceptingInvitationTasks operation
        ///</summary>
        public IListEngagementByAcceptingInvitationTasksPaginator ListEngagementByAcceptingInvitationTasks(ListEngagementByAcceptingInvitationTasksRequest request) 
        {
            return new ListEngagementByAcceptingInvitationTasksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEngagementFromOpportunityTasks operation
        ///</summary>
        public IListEngagementFromOpportunityTasksPaginator ListEngagementFromOpportunityTasks(ListEngagementFromOpportunityTasksRequest request) 
        {
            return new ListEngagementFromOpportunityTasksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEngagementInvitations operation
        ///</summary>
        public IListEngagementInvitationsPaginator ListEngagementInvitations(ListEngagementInvitationsRequest request) 
        {
            return new ListEngagementInvitationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEngagementMembers operation
        ///</summary>
        public IListEngagementMembersPaginator ListEngagementMembers(ListEngagementMembersRequest request) 
        {
            return new ListEngagementMembersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEngagementResourceAssociations operation
        ///</summary>
        public IListEngagementResourceAssociationsPaginator ListEngagementResourceAssociations(ListEngagementResourceAssociationsRequest request) 
        {
            return new ListEngagementResourceAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEngagements operation
        ///</summary>
        public IListEngagementsPaginator ListEngagements(ListEngagementsRequest request) 
        {
            return new ListEngagementsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListOpportunities operation
        ///</summary>
        public IListOpportunitiesPaginator ListOpportunities(ListOpportunitiesRequest request) 
        {
            return new ListOpportunitiesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListResourceSnapshotJobs operation
        ///</summary>
        public IListResourceSnapshotJobsPaginator ListResourceSnapshotJobs(ListResourceSnapshotJobsRequest request) 
        {
            return new ListResourceSnapshotJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListResourceSnapshots operation
        ///</summary>
        public IListResourceSnapshotsPaginator ListResourceSnapshots(ListResourceSnapshotsRequest request) 
        {
            return new ListResourceSnapshotsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSolutions operation
        ///</summary>
        public IListSolutionsPaginator ListSolutions(ListSolutionsRequest request) 
        {
            return new ListSolutionsPaginator(this.client, request);
        }
    }
}