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
 * Do not modify this file. This file is generated from the route53-recovery-control-config-2020-11-02.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.Route53RecoveryControlConfig.Model
{
    /// <summary>
    /// Paginators for the Route53RecoveryControlConfig service
    ///</summary>
    public interface IRoute53RecoveryControlConfigPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListAssociatedRoute53HealthChecks operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAssociatedRoute53HealthChecksPaginator ListAssociatedRoute53HealthChecks(ListAssociatedRoute53HealthChecksRequest request);

        /// <summary>
        /// Paginator for ListClusters operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListClustersPaginator ListClusters(ListClustersRequest request);

        /// <summary>
        /// Paginator for ListControlPanels operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListControlPanelsPaginator ListControlPanels(ListControlPanelsRequest request);

        /// <summary>
        /// Paginator for ListRoutingControls operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListRoutingControlsPaginator ListRoutingControls(ListRoutingControlsRequest request);

        /// <summary>
        /// Paginator for ListSafetyRules operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSafetyRulesPaginator ListSafetyRules(ListSafetyRulesRequest request);
    }
}