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
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Route53RecoveryControlConfig.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRoutingControl operation.
    /// Creates a new routing control.
    /// 
    ///  
    /// <para>
    /// A routing control has one of two states: ON and OFF. You can map the routing control
    /// state to the state of an Amazon Route 53 health check, which can be used to control
    /// traffic routing.
    /// </para>
    ///  
    /// <para>
    /// To get or update the routing control state, see the Recovery Cluster (data plane)
    /// API actions for Amazon Route 53 Application Recovery Controller.
    /// </para>
    /// </summary>
    public partial class CreateRoutingControlRequest : AmazonRoute53RecoveryControlConfigRequest
    {
        private string _clientToken;
        private string _clusterArn;
        private string _controlPanelArn;
        private string _routingControlName;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive string of up to 64 ASCII characters. To make an idempotent
        /// API request with an action, specify a client token in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the cluster that includes the routing control.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ClusterArn
        {
            get { return this._clusterArn; }
            set { this._clusterArn = value; }
        }

        // Check to see if ClusterArn property is set
        internal bool IsSetClusterArn()
        {
            return this._clusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property ControlPanelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the control panel that includes the routing control.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property RoutingControlName. 
        /// <para>
        /// The name of the routing control.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string RoutingControlName
        {
            get { return this._routingControlName; }
            set { this._routingControlName = value; }
        }

        // Check to see if RoutingControlName property is set
        internal bool IsSetRoutingControlName()
        {
            return this._routingControlName != null;
        }

    }
}