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
 * Do not modify this file. This file is generated from the route53-recovery-cluster-2019-12-02.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Route53RecoveryCluster.Model
{
    /// <summary>
    /// Paginators for the Route53RecoveryCluster service
    ///</summary>
    public class Route53RecoveryClusterPaginatorFactory : IRoute53RecoveryClusterPaginatorFactory
    {
        private readonly IAmazonRoute53RecoveryCluster client;

        internal Route53RecoveryClusterPaginatorFactory(IAmazonRoute53RecoveryCluster client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListRoutingControls operation
        ///</summary>
        public IListRoutingControlsPaginator ListRoutingControls(ListRoutingControlsRequest request) 
        {
            return new ListRoutingControlsPaginator(this.client, request);
        }
    }
}