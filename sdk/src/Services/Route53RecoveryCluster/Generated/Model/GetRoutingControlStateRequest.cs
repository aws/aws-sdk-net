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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Route53RecoveryCluster.Model
{
    /// <summary>
    /// Container for the parameters to the GetRoutingControlState operation.
    /// Get the state for a routing control. A routing control is a simple on/off switch that
    /// you can use to route traffic to cells. When a routing control state is set to ON,
    /// traffic flows to a cell. When the state is set to OFF, traffic does not flow. 
    /// 
    ///  
    /// <para>
    /// Before you can create a routing control, you must first create a cluster, and then
    /// host the control in a control panel on the cluster. For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.create.html">
    /// Create routing control structures</a> in the Amazon Route 53 Application Recovery
    /// Controller Developer Guide. You access one of the endpoints for the cluster to get
    /// or update the routing control state to redirect traffic for your application. 
    /// </para>
    ///  
    /// <para>
    ///  <i>You must specify Regional endpoints when you work with API cluster operations
    /// to get or update routing control states in Route 53 ARC.</i> 
    /// </para>
    ///  
    /// <para>
    /// To see a code example for getting a routing control state, including accessing Regional
    /// cluster endpoints in sequence, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/service_code_examples_actions.html">API
    /// examples</a> in the Amazon Route 53 Application Recovery Controller Developer Guide.
    /// </para>
    ///  
    /// <para>
    /// Learn more about working with routing controls in the following topics in the Amazon
    /// Route 53 Application Recovery Controller Developer Guide:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.update.html">
    /// Viewing and updating routing control states</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.html">Working
    /// with routing controls in Route 53 ARC</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetRoutingControlStateRequest : AmazonRoute53RecoveryClusterRequest
    {
        private string _routingControlArn;

        /// <summary>
        /// Gets and sets the property RoutingControlArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the routing control that you want to get the state
        /// for.
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