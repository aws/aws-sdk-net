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
using Amazon.Runtime.Internal;

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
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAnalysisTemplatesPaginator ListAnalysisTemplates(ListAnalysisTemplatesRequest request);

        /// <summary>
        /// Paginator for ListCollaborationAnalysisTemplates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCollaborationAnalysisTemplatesPaginator ListCollaborationAnalysisTemplates(ListCollaborationAnalysisTemplatesRequest request);

        /// <summary>
        /// Paginator for ListCollaborationChangeRequests operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCollaborationChangeRequestsPaginator ListCollaborationChangeRequests(ListCollaborationChangeRequestsRequest request);

        /// <summary>
        /// Paginator for ListCollaborationConfiguredAudienceModelAssociations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCollaborationConfiguredAudienceModelAssociationsPaginator ListCollaborationConfiguredAudienceModelAssociations(ListCollaborationConfiguredAudienceModelAssociationsRequest request);

        /// <summary>
        /// Paginator for ListCollaborationIdNamespaceAssociations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCollaborationIdNamespaceAssociationsPaginator ListCollaborationIdNamespaceAssociations(ListCollaborationIdNamespaceAssociationsRequest request);

        /// <summary>
        /// Paginator for ListCollaborationPrivacyBudgets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCollaborationPrivacyBudgetsPaginator ListCollaborationPrivacyBudgets(ListCollaborationPrivacyBudgetsRequest request);

        /// <summary>
        /// Paginator for ListCollaborationPrivacyBudgetTemplates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCollaborationPrivacyBudgetTemplatesPaginator ListCollaborationPrivacyBudgetTemplates(ListCollaborationPrivacyBudgetTemplatesRequest request);

        /// <summary>
        /// Paginator for ListCollaborations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCollaborationsPaginator ListCollaborations(ListCollaborationsRequest request);

        /// <summary>
        /// Paginator for ListConfiguredAudienceModelAssociations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListConfiguredAudienceModelAssociationsPaginator ListConfiguredAudienceModelAssociations(ListConfiguredAudienceModelAssociationsRequest request);

        /// <summary>
        /// Paginator for ListConfiguredTableAssociations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListConfiguredTableAssociationsPaginator ListConfiguredTableAssociations(ListConfiguredTableAssociationsRequest request);

        /// <summary>
        /// Paginator for ListConfiguredTables operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListConfiguredTablesPaginator ListConfiguredTables(ListConfiguredTablesRequest request);

        /// <summary>
        /// Paginator for ListIdMappingTables operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListIdMappingTablesPaginator ListIdMappingTables(ListIdMappingTablesRequest request);

        /// <summary>
        /// Paginator for ListIdNamespaceAssociations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListIdNamespaceAssociationsPaginator ListIdNamespaceAssociations(ListIdNamespaceAssociationsRequest request);

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
        /// Paginator for ListMemberships operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMembershipsPaginator ListMemberships(ListMembershipsRequest request);

        /// <summary>
        /// Paginator for ListPrivacyBudgets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPrivacyBudgetsPaginator ListPrivacyBudgets(ListPrivacyBudgetsRequest request);

        /// <summary>
        /// Paginator for ListPrivacyBudgetTemplates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPrivacyBudgetTemplatesPaginator ListPrivacyBudgetTemplates(ListPrivacyBudgetTemplatesRequest request);

        /// <summary>
        /// Paginator for ListProtectedJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListProtectedJobsPaginator ListProtectedJobs(ListProtectedJobsRequest request);

        /// <summary>
        /// Paginator for ListProtectedQueries operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListProtectedQueriesPaginator ListProtectedQueries(ListProtectedQueriesRequest request);

        /// <summary>
        /// Paginator for ListSchemas operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSchemasPaginator ListSchemas(ListSchemasRequest request);
    }
}