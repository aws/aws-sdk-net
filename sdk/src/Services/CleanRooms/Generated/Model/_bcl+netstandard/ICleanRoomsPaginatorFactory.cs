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

#pragma warning disable CS0612,CS0618
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Paginators for the CleanRooms service
    ///</summary>
    public interface ICleanRoomsPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListAnalysisTemplates operation
        ///</summary>
        IListAnalysisTemplatesPaginator ListAnalysisTemplates(ListAnalysisTemplatesRequest request);

        /// <summary>
        /// Paginator for ListCollaborationAnalysisTemplates operation
        ///</summary>
        IListCollaborationAnalysisTemplatesPaginator ListCollaborationAnalysisTemplates(ListCollaborationAnalysisTemplatesRequest request);

        /// <summary>
        /// Paginator for ListCollaborationConfiguredAudienceModelAssociations operation
        ///</summary>
        IListCollaborationConfiguredAudienceModelAssociationsPaginator ListCollaborationConfiguredAudienceModelAssociations(ListCollaborationConfiguredAudienceModelAssociationsRequest request);

        /// <summary>
        /// Paginator for ListCollaborationPrivacyBudgets operation
        ///</summary>
        IListCollaborationPrivacyBudgetsPaginator ListCollaborationPrivacyBudgets(ListCollaborationPrivacyBudgetsRequest request);

        /// <summary>
        /// Paginator for ListCollaborationPrivacyBudgetTemplates operation
        ///</summary>
        IListCollaborationPrivacyBudgetTemplatesPaginator ListCollaborationPrivacyBudgetTemplates(ListCollaborationPrivacyBudgetTemplatesRequest request);

        /// <summary>
        /// Paginator for ListCollaborations operation
        ///</summary>
        IListCollaborationsPaginator ListCollaborations(ListCollaborationsRequest request);

        /// <summary>
        /// Paginator for ListConfiguredAudienceModelAssociations operation
        ///</summary>
        IListConfiguredAudienceModelAssociationsPaginator ListConfiguredAudienceModelAssociations(ListConfiguredAudienceModelAssociationsRequest request);

        /// <summary>
        /// Paginator for ListConfiguredTableAssociations operation
        ///</summary>
        IListConfiguredTableAssociationsPaginator ListConfiguredTableAssociations(ListConfiguredTableAssociationsRequest request);

        /// <summary>
        /// Paginator for ListConfiguredTables operation
        ///</summary>
        IListConfiguredTablesPaginator ListConfiguredTables(ListConfiguredTablesRequest request);

        /// <summary>
        /// Paginator for ListMembers operation
        ///</summary>
        IListMembersPaginator ListMembers(ListMembersRequest request);

        /// <summary>
        /// Paginator for ListMemberships operation
        ///</summary>
        IListMembershipsPaginator ListMemberships(ListMembershipsRequest request);

        /// <summary>
        /// Paginator for ListPrivacyBudgets operation
        ///</summary>
        IListPrivacyBudgetsPaginator ListPrivacyBudgets(ListPrivacyBudgetsRequest request);

        /// <summary>
        /// Paginator for ListPrivacyBudgetTemplates operation
        ///</summary>
        IListPrivacyBudgetTemplatesPaginator ListPrivacyBudgetTemplates(ListPrivacyBudgetTemplatesRequest request);

        /// <summary>
        /// Paginator for ListProtectedQueries operation
        ///</summary>
        IListProtectedQueriesPaginator ListProtectedQueries(ListProtectedQueriesRequest request);

        /// <summary>
        /// Paginator for ListSchemas operation
        ///</summary>
        IListSchemasPaginator ListSchemas(ListSchemasRequest request);
    }
}