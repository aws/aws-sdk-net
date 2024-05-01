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
    /// Container for the parameters to the ListRoutingControls operation.
    /// List routing control names and Amazon Resource Names (ARNs), as well as the routing
    /// control state for each routing control, along with the control panel name and control
    /// panel ARN for the routing controls. If you specify a control panel ARN, this call
    /// lists the routing controls in the control panel. Otherwise, it lists all the routing
    /// controls in the cluster.
    /// 
    ///  
    /// <para>
    /// A routing control is a simple on/off switch in Route 53 ARC that you can use to route
    /// traffic to cells. When a routing control state is set to ON, traffic flows to a cell.
    /// When the state is set to OFF, traffic does not flow.
    /// </para>
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
    /// to use this API operation to list routing controls in Route 53 ARC.</i> 
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
    public partial class ListRoutingControlsRequest : AmazonRoute53RecoveryClusterRequest
    {
        private string _controlPanelArn;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ControlPanelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the control panel of the routing controls to list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ControlPanelArn
        {
            get { return this._controlPanelArn; }
            set { this._controlPanelArn = value; }
        }

        // Check to see if ControlPanelArn property is set
        internal bool IsSetControlPanelArn()
        {
            return this._controlPanelArn != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The number of routing controls objects that you want to return with this call. The
        /// default value is 500.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results. You receive this token from a previous call.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=8096)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}