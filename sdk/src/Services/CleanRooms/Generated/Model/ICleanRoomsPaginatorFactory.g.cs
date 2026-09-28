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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Paginators for the CleanRooms service
    /// </summary>
    public interface ICleanRoomsPaginatorFactory
    {
        /// <summary>
        /// Paginator for ListAnalysisLogExports operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAnalysisLogExportsPaginator ListAnalysisLogExports(ListAnalysisLogExportsRequest request);

        /// <summary>
        /// Paginator for ListAnalysisTemplates operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAnalysisTemplatesPaginator ListAnalysisTemplates(ListAnalysisTemplatesRequest request);

        /// <summary>
        /// Paginator for ListCollaborationAnalysisTemplates operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCollaborationAnalysisTemplatesPaginator ListCollaborationAnalysisTemplates(ListCollaborationAnalysisTemplatesRequest request);

        /// <summary>
        /// Paginator for ListCollaborationChangeRequests operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCollaborationChangeRequestsPaginator ListCollaborationChangeRequests(ListCollaborationChangeRequestsRequest request);

        /// <summary>
        /// Paginator for ListCollaborationConfiguredAudienceModelAssociations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCollaborationConfiguredAudienceModelAssociationsPaginator ListCollaborationConfiguredAudienceModelAssociations(ListCollaborationConfiguredAudienceModelAssociationsRequest request);

        /// <summary>
        /// Paginator for ListCollaborationIdNamespaceAssociations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCollaborationIdNamespaceAssociationsPaginator ListCollaborationIdNamespaceAssociations(ListCollaborationIdNamespaceAssociationsRequest request);

        /// <summary>
        /// Paginator for ListCollaborationPrivacyBudgetTemplates operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCollaborationPrivacyBudgetTemplatesPaginator ListCollaborationPrivacyBudgetTemplates(ListCollaborationPrivacyBudgetTemplatesRequest request);

        /// <summary>
        /// Paginator for ListCollaborationPrivacyBudgets operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCollaborationPrivacyBudgetsPaginator ListCollaborationPrivacyBudgets(ListCollaborationPrivacyBudgetsRequest request);

        /// <summary>
        /// Paginator for ListCollaborations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCollaborationsPaginator ListCollaborations(ListCollaborationsRequest request);

        /// <summary>
        /// Paginator for ListConfiguredAudienceModelAssociations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListConfiguredAudienceModelAssociationsPaginator ListConfiguredAudienceModelAssociations(ListConfiguredAudienceModelAssociationsRequest request);

        /// <summary>
        /// Paginator for ListConfiguredTableAssociations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListConfiguredTableAssociationsPaginator ListConfiguredTableAssociations(ListConfiguredTableAssociationsRequest request);

        /// <summary>
        /// Paginator for ListConfiguredTables operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListConfiguredTablesPaginator ListConfiguredTables(ListConfiguredTablesRequest request);

        /// <summary>
        /// Paginator for ListIdMappingTables operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListIdMappingTablesPaginator ListIdMappingTables(ListIdMappingTablesRequest request);

        /// <summary>
        /// Paginator for ListIdNamespaceAssociations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListIdNamespaceAssociationsPaginator ListIdNamespaceAssociations(ListIdNamespaceAssociationsRequest request);

        /// <summary>
        /// Paginator for ListIntermediateTableVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListIntermediateTableVersionsPaginator ListIntermediateTableVersions(ListIntermediateTableVersionsRequest request);

        /// <summary>
        /// Paginator for ListIntermediateTables operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListIntermediateTablesPaginator ListIntermediateTables(ListIntermediateTablesRequest request);

        /// <summary>
        /// Paginator for ListMembers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListMembersPaginator ListMembers(ListMembersRequest request);

        /// <summary>
        /// Paginator for ListMemberships operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListMembershipsPaginator ListMemberships(ListMembershipsRequest request);

        /// <summary>
        /// Paginator for ListPrivacyBudgetTemplates operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPrivacyBudgetTemplatesPaginator ListPrivacyBudgetTemplates(ListPrivacyBudgetTemplatesRequest request);

        /// <summary>
        /// Paginator for ListPrivacyBudgets operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPrivacyBudgetsPaginator ListPrivacyBudgets(ListPrivacyBudgetsRequest request);

        /// <summary>
        /// Paginator for ListProtectedJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListProtectedJobsPaginator ListProtectedJobs(ListProtectedJobsRequest request);

        /// <summary>
        /// Paginator for ListProtectedQueries operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListProtectedQueriesPaginator ListProtectedQueries(ListProtectedQueriesRequest request);

        /// <summary>
        /// Paginator for ListSchemas operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSchemasPaginator ListSchemas(ListSchemasRequest request);
    }
}
