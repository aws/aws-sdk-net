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
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53RecoveryCluster.Model
{
    /// <summary>
    /// Container for the parameters to the GetRoutingControlState operation.
    /// Get the state for a routing control. A routing control is a simple on/off switch that
    /// you can use to route traffic to cells. When the state is On, traffic flows to a cell.
    /// When it's off, traffic does not flow. 
    /// 
    ///  
    /// <para>
    /// Before you can create a routing control, you first must create a cluster to host the
    /// control. For more information, see <a href="https://docs.aws.amazon.com/recovery-cluster/latest/api/cluster.html">CreateCluster</a>.
    /// Access one of the endpoints for the cluster to get or update the routing control state
    /// to redirect traffic.
    /// </para>
    ///  
    /// <para>
    /// For more information about working with routing controls, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.html">Routing
    /// control</a> in the Route 53 Application Recovery Controller Developer Guide.
    /// </para>
    /// </summary>
    public partial class GetRoutingControlStateRequest : AmazonRoute53RecoveryClusterRequest
    {
        private string _routingControlArn;

        /// <summary>
        /// Gets and sets the property RoutingControlArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) for the routing control that you want to get the
        /// state for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string RoutingControlArn
        {
            get { return this._routingControlArn; }
            set { this._routingControlArn = value; }
        }

        // Check to see if RoutingControlArn property is set
        internal bool IsSetRoutingControlArn()
        {
            return this._routingControlArn != null;
        }

    }
}