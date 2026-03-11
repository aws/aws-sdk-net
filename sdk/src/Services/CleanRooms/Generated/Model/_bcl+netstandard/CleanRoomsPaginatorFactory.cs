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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Paginators for the CleanRooms service
    ///</summary>
    public class CleanRoomsPaginatorFactory : ICleanRoomsPaginatorFactory
    {
        private readonly IAmazonCleanRooms client;

        internal CleanRoomsPaginatorFactory(IAmazonCleanRooms client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAnalysisTemplates operation
        ///</summary>
        public IListAnalysisTemplatesPaginator ListAnalysisTemplates(ListAnalysisTemplatesRequest request) 
        {
            return new ListAnalysisTemplatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCollaborationAnalysisTemplates operation
        ///</summary>
        public IListCollaborationAnalysisTemplatesPaginator ListCollaborationAnalysisTemplates(ListCollaborationAnalysisTemplatesRequest request) 
        {
            return new ListCollaborationAnalysisTemplatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCollaborationChangeRequests operation
        ///</summary>
        public IListCollaborationChangeRequestsPaginator ListCollaborationChangeRequests(ListCollaborationChangeRequestsRequest request) 
        {
            return new ListCollaborationChangeRequestsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCollaborationConfiguredAudienceModelAssociations operation
        ///</summary>
        public IListCollaborationConfiguredAudienceModelAssociationsPaginator ListCollaborationConfiguredAudienceModelAssociations(ListCollaborationConfiguredAudienceModelAssociationsRequest request) 
        {
            return new ListCollaborationConfiguredAudienceModelAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCollaborationIdNamespaceAssociations operation
        ///</summary>
        public IListCollaborationIdNamespaceAssociationsPaginator ListCollaborationIdNamespaceAssociations(ListCollaborationIdNamespaceAssociationsRequest request) 
        {
            return new ListCollaborationIdNamespaceAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCollaborationPrivacyBudgets operation
        ///</summary>
        public IListCollaborationPrivacyBudgetsPaginator ListCollaborationPrivacyBudgets(ListCollaborationPrivacyBudgetsRequest request) 
        {
            return new ListCollaborationPrivacyBudgetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCollaborationPrivacyBudgetTemplates operation
        ///</summary>
        public IListCollaborationPrivacyBudgetTemplatesPaginator ListCollaborationPrivacyBudgetTemplates(ListCollaborationPrivacyBudgetTemplatesRequest request) 
        {
            return new ListCollaborationPrivacyBudgetTemplatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCollaborations operation
        ///</summary>
        public IListCollaborationsPaginator ListCollaborations(ListCollaborationsRequest request) 
        {
            return new ListCollaborationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListConfiguredAudienceModelAssociations operation
        ///</summary>
        public IListConfiguredAudienceModelAssociationsPaginator ListConfiguredAudienceModelAssociations(ListConfiguredAudienceModelAssociationsRequest request) 
        {
            return new ListConfiguredAudienceModelAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListConfiguredTableAssociations operation
        ///</summary>
        public IListConfiguredTableAssociationsPaginator ListConfiguredTableAssociations(ListConfiguredTableAssociationsRequest request) 
        {
            return new ListConfiguredTableAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListConfiguredTables operation
        ///</summary>
        public IListConfiguredTablesPaginator ListConfiguredTables(ListConfiguredTablesRequest request) 
        {
            return new ListConfiguredTablesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListIdMappingTables operation
        ///</summary>
        public IListIdMappingTablesPaginator ListIdMappingTables(ListIdMappingTablesRequest request) 
        {
            return new ListIdMappingTablesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListIdNamespaceAssociations operation
        ///</summary>
        public IListIdNamespaceAssociationsPaginator ListIdNamespaceAssociations(ListIdNamespaceAssociationsRequest request) 
        {
            return new ListIdNamespaceAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMembers operation
        ///</summary>
        public IListMembersPaginator ListMembers(ListMembersRequest request) 
        {
            return new ListMembersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMemberships operation
        ///</summary>
        public IListMembershipsPaginator ListMemberships(ListMembershipsRequest request) 
        {
            return new ListMembershipsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPrivacyBudgets operation
        ///</summary>
        public IListPrivacyBudgetsPaginator ListPrivacyBudgets(ListPrivacyBudgetsRequest request) 
        {
            return new ListPrivacyBudgetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPrivacyBudgetTemplates operation
        ///</summary>
        public IListPrivacyBudgetTemplatesPaginator ListPrivacyBudgetTemplates(ListPrivacyBudgetTemplatesRequest request) 
        {
            return new ListPrivacyBudgetTemplatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProtectedJobs operation
        ///</summary>
        public IListProtectedJobsPaginator ListProtectedJobs(ListProtectedJobsRequest request) 
        {
            return new ListProtectedJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProtectedQueries operation
        ///</summary>
        public IListProtectedQueriesPaginator ListProtectedQueries(ListProtectedQueriesRequest request) 
        {
            return new ListProtectedQueriesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSchemas operation
        ///</summary>
        public IListSchemasPaginator ListSchemas(ListSchemasRequest request) 
        {
            return new ListSchemasPaginator(this.client, request);
        }
    }
}