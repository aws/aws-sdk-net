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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Paginators for the SecurityHub service
    ///</summary>
    public class SecurityHubPaginatorFactory : ISecurityHubPaginatorFactory
    {
        private readonly IAmazonSecurityHub client;

        internal SecurityHubPaginatorFactory(IAmazonSecurityHub client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeActionTargets operation
        ///</summary>
        public IDescribeActionTargetsPaginator DescribeActionTargets(DescribeActionTargetsRequest request) 
        {
            return new DescribeActionTargetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeProducts operation
        ///</summary>
        public IDescribeProductsPaginator DescribeProducts(DescribeProductsRequest request) 
        {
            return new DescribeProductsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeProductsV2 operation
        ///</summary>
        public IDescribeProductsV2Paginator DescribeProductsV2(DescribeProductsV2Request request) 
        {
            return new DescribeProductsV2Paginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeStandards operation
        ///</summary>
        public IDescribeStandardsPaginator DescribeStandards(DescribeStandardsRequest request) 
        {
            return new DescribeStandardsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeStandardsControls operation
        ///</summary>
        public IDescribeStandardsControlsPaginator DescribeStandardsControls(DescribeStandardsControlsRequest request) 
        {
            return new DescribeStandardsControlsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetEnabledStandards operation
        ///</summary>
        public IGetEnabledStandardsPaginator GetEnabledStandards(GetEnabledStandardsRequest request) 
        {
            return new GetEnabledStandardsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetFindingHistory operation
        ///</summary>
        public IGetFindingHistoryPaginator GetFindingHistory(GetFindingHistoryRequest request) 
        {
            return new GetFindingHistoryPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetFindings operation
        ///</summary>
        public IGetFindingsPaginator GetFindings(GetFindingsRequest request) 
        {
            return new GetFindingsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetFindingsV2 operation
        ///</summary>
        public IGetFindingsV2Paginator GetFindingsV2(GetFindingsV2Request request) 
        {
            return new GetFindingsV2Paginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetInsights operation
        ///</summary>
        public IGetInsightsPaginator GetInsights(GetInsightsRequest request) 
        {
            return new GetInsightsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetResourcesV2 operation
        ///</summary>
        public IGetResourcesV2Paginator GetResourcesV2(GetResourcesV2Request request) 
        {
            return new GetResourcesV2Paginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAggregatorsV2 operation
        ///</summary>
        public IListAggregatorsV2Paginator ListAggregatorsV2(ListAggregatorsV2Request request) 
        {
            return new ListAggregatorsV2Paginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListConfigurationPolicies operation
        ///</summary>
        public IListConfigurationPoliciesPaginator ListConfigurationPolicies(ListConfigurationPoliciesRequest request) 
        {
            return new ListConfigurationPoliciesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListConfigurationPolicyAssociations operation
        ///</summary>
        public IListConfigurationPolicyAssociationsPaginator ListConfigurationPolicyAssociations(ListConfigurationPolicyAssociationsRequest request) 
        {
            return new ListConfigurationPolicyAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEnabledProductsForImport operation
        ///</summary>
        public IListEnabledProductsForImportPaginator ListEnabledProductsForImport(ListEnabledProductsForImportRequest request) 
        {
            return new ListEnabledProductsForImportPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFindingAggregators operation
        ///</summary>
        public IListFindingAggregatorsPaginator ListFindingAggregators(ListFindingAggregatorsRequest request) 
        {
            return new ListFindingAggregatorsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListInvitations operation
        ///</summary>
        public IListInvitationsPaginator ListInvitations(ListInvitationsRequest request) 
        {
            return new ListInvitationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMembers operation
        ///</summary>
        public IListMembersPaginator ListMembers(ListMembersRequest request) 
        {
            return new ListMembersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListOrganizationAdminAccounts operation
        ///</summary>
        public IListOrganizationAdminAccountsPaginator ListOrganizationAdminAccounts(ListOrganizationAdminAccountsRequest request) 
        {
            return new ListOrganizationAdminAccountsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSecurityControlDefinitions operation
        ///</summary>
        public IListSecurityControlDefinitionsPaginator ListSecurityControlDefinitions(ListSecurityControlDefinitionsRequest request) 
        {
            return new ListSecurityControlDefinitionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListStandardsControlAssociations operation
        ///</summary>
        public IListStandardsControlAssociationsPaginator ListStandardsControlAssociations(ListStandardsControlAssociationsRequest request) 
        {
            return new ListStandardsControlAssociationsPaginator(this.client, request);
        }
    }
}