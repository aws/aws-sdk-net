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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
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
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeActionTargetsPaginator DescribeActionTargets(DescribeActionTargetsRequest request);

        /// <summary>
        /// Paginator for DescribeProducts operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeProductsPaginator DescribeProducts(DescribeProductsRequest request);

        /// <summary>
        /// Paginator for DescribeProductsV2 operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeProductsV2Paginator DescribeProductsV2(DescribeProductsV2Request request);

        /// <summary>
        /// Paginator for DescribeStandards operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeStandardsPaginator DescribeStandards(DescribeStandardsRequest request);

        /// <summary>
        /// Paginator for DescribeStandardsControls operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeStandardsControlsPaginator DescribeStandardsControls(DescribeStandardsControlsRequest request);

        /// <summary>
        /// Paginator for GetEnabledStandards operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetEnabledStandardsPaginator GetEnabledStandards(GetEnabledStandardsRequest request);

        /// <summary>
        /// Paginator for GetFindingHistory operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetFindingHistoryPaginator GetFindingHistory(GetFindingHistoryRequest request);

        /// <summary>
        /// Paginator for GetFindings operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetFindingsPaginator GetFindings(GetFindingsRequest request);

        /// <summary>
        /// Paginator for GetFindingsV2 operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetFindingsV2Paginator GetFindingsV2(GetFindingsV2Request request);

        /// <summary>
        /// Paginator for GetInsights operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetInsightsPaginator GetInsights(GetInsightsRequest request);

        /// <summary>
        /// Paginator for GetResourcesV2 operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetResourcesV2Paginator GetResourcesV2(GetResourcesV2Request request);

        /// <summary>
        /// Paginator for ListAggregatorsV2 operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAggregatorsV2Paginator ListAggregatorsV2(ListAggregatorsV2Request request);

        /// <summary>
        /// Paginator for ListConfigurationPolicies operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListConfigurationPoliciesPaginator ListConfigurationPolicies(ListConfigurationPoliciesRequest request);

        /// <summary>
        /// Paginator for ListConfigurationPolicyAssociations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListConfigurationPolicyAssociationsPaginator ListConfigurationPolicyAssociations(ListConfigurationPolicyAssociationsRequest request);

        /// <summary>
        /// Paginator for ListEnabledProductsForImport operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListEnabledProductsForImportPaginator ListEnabledProductsForImport(ListEnabledProductsForImportRequest request);

        /// <summary>
        /// Paginator for ListFindingAggregators operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFindingAggregatorsPaginator ListFindingAggregators(ListFindingAggregatorsRequest request);

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
        /// Paginator for ListSecurityControlDefinitions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSecurityControlDefinitionsPaginator ListSecurityControlDefinitions(ListSecurityControlDefinitionsRequest request);

        /// <summary>
        /// Paginator for ListStandardsControlAssociations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListStandardsControlAssociationsPaginator ListStandardsControlAssociations(ListStandardsControlAssociationsRequest request);
    }
}