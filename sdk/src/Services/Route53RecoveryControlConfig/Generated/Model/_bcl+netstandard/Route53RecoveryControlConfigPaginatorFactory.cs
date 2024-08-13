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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Route53RecoveryControlConfig.Model
{
    /// <summary>
    /// Paginators for the Route53RecoveryControlConfig service
    ///</summary>
    public class Route53RecoveryControlConfigPaginatorFactory : IRoute53RecoveryControlConfigPaginatorFactory
    {
        private readonly IAmazonRoute53RecoveryControlConfig client;

        internal Route53RecoveryControlConfigPaginatorFactory(IAmazonRoute53RecoveryControlConfig client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAssociatedRoute53HealthChecks operation
        ///</summary>
        public IListAssociatedRoute53HealthChecksPaginator ListAssociatedRoute53HealthChecks(ListAssociatedRoute53HealthChecksRequest request) 
        {
            return new ListAssociatedRoute53HealthChecksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListClusters operation
        ///</summary>
        public IListClustersPaginator ListClusters(ListClustersRequest request) 
        {
            return new ListClustersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListControlPanels operation
        ///</summary>
        public IListControlPanelsPaginator ListControlPanels(ListControlPanelsRequest request) 
        {
            return new ListControlPanelsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRoutingControls operation
        ///</summary>
        public IListRoutingControlsPaginator ListRoutingControls(ListRoutingControlsRequest request) 
        {
            return new ListRoutingControlsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSafetyRules operation
        ///</summary>
        public IListSafetyRulesPaginator ListSafetyRules(ListSafetyRulesRequest request) 
        {
            return new ListSafetyRulesPaginator(this.client, request);
        }
    }
}