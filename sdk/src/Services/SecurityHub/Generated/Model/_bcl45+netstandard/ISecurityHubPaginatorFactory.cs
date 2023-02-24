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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Paginators for the SecurityHub service
    ///</summary>
    public interface ISecurityHubPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeActionTargets operation
        ///</summary>
        IDescribeActionTargetsPaginator DescribeActionTargets(DescribeActionTargetsRequest request);

        /// <summary>
        /// Paginator for DescribeProducts operation
        ///</summary>
        IDescribeProductsPaginator DescribeProducts(DescribeProductsRequest request);

        /// <summary>
        /// Paginator for DescribeStandards operation
        ///</summary>
        IDescribeStandardsPaginator DescribeStandards(DescribeStandardsRequest request);

        /// <summary>
        /// Paginator for DescribeStandardsControls operation
        ///</summary>
        IDescribeStandardsControlsPaginator DescribeStandardsControls(DescribeStandardsControlsRequest request);

        /// <summary>
        /// Paginator for GetEnabledStandards operation
        ///</summary>
        IGetEnabledStandardsPaginator GetEnabledStandards(GetEnabledStandardsRequest request);

        /// <summary>
        /// Paginator for GetFindings operation
        ///</summary>
        IGetFindingsPaginator GetFindings(GetFindingsRequest request);

        /// <summary>
        /// Paginator for GetInsights operation
        ///</summary>
        IGetInsightsPaginator GetInsights(GetInsightsRequest request);

        /// <summary>
        /// Paginator for ListEnabledProductsForImport operation
        ///</summary>
        IListEnabledProductsForImportPaginator ListEnabledProductsForImport(ListEnabledProductsForImportRequest request);

        /// <summary>
        /// Paginator for ListFindingAggregators operation
        ///</summary>
        IListFindingAggregatorsPaginator ListFindingAggregators(ListFindingAggregatorsRequest request);

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

        /// <summary>
        /// Paginator for ListSecurityControlDefinitions operation
        ///</summary>
        IListSecurityControlDefinitionsPaginator ListSecurityControlDefinitions(ListSecurityControlDefinitionsRequest request);

        /// <summary>
        /// Paginator for ListStandardsControlAssociations operation
        ///</summary>
        IListStandardsControlAssociationsPaginator ListStandardsControlAssociations(ListStandardsControlAssociationsRequest request);
    }
}