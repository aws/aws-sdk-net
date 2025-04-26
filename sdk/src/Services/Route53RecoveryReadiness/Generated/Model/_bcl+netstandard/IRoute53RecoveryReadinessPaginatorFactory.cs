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
 * Do not modify this file. This file is generated from the route53-recovery-readiness-2019-12-02.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.Route53RecoveryReadiness.Model
{
    /// <summary>
    /// Paginators for the Route53RecoveryReadiness service
    ///</summary>
    public interface IRoute53RecoveryReadinessPaginatorFactory
    {

        /// <summary>
        /// Paginator for GetCellReadinessSummary operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetCellReadinessSummaryPaginator GetCellReadinessSummary(GetCellReadinessSummaryRequest request);

        /// <summary>
        /// Paginator for GetReadinessCheckResourceStatus operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetReadinessCheckResourceStatusPaginator GetReadinessCheckResourceStatus(GetReadinessCheckResourceStatusRequest request);

        /// <summary>
        /// Paginator for GetReadinessCheckStatus operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetReadinessCheckStatusPaginator GetReadinessCheckStatus(GetReadinessCheckStatusRequest request);

        /// <summary>
        /// Paginator for GetRecoveryGroupReadinessSummary operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetRecoveryGroupReadinessSummaryPaginator GetRecoveryGroupReadinessSummary(GetRecoveryGroupReadinessSummaryRequest request);

        /// <summary>
        /// Paginator for ListCells operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCellsPaginator ListCells(ListCellsRequest request);

        /// <summary>
        /// Paginator for ListCrossAccountAuthorizations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCrossAccountAuthorizationsPaginator ListCrossAccountAuthorizations(ListCrossAccountAuthorizationsRequest request);

        /// <summary>
        /// Paginator for ListReadinessChecks operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListReadinessChecksPaginator ListReadinessChecks(ListReadinessChecksRequest request);

        /// <summary>
        /// Paginator for ListRecoveryGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListRecoveryGroupsPaginator ListRecoveryGroups(ListRecoveryGroupsRequest request);

        /// <summary>
        /// Paginator for ListResourceSets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListResourceSetsPaginator ListResourceSets(ListResourceSetsRequest request);

        /// <summary>
        /// Paginator for ListRules operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListRulesPaginator ListRules(ListRulesRequest request);
    }
}