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
    /// A routing control, which is a simple on/off switch that you can use to route traffic
    /// to cells. When a routing control state is set to ON, traffic flows to a cell. When
    /// the state is set to OFF, traffic does not flow.
    /// </summary>
    public partial class RoutingControl
    {
        private string _controlPanelArn;
        private string _controlPanelName;
        private string _owner;
        private string _routingControlArn;
        private string _routingControlName;
        private RoutingControlState _routingControlState;

        /// <summary>
        /// Gets and sets the property ControlPanelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the control panel where the routing control is located.
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
        /// Gets and sets the property ControlPanelName. 
        /// <para>
        /// The name of the control panel where the routing control is located. Only ASCII characters
        /// are supported for control panel names.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ControlPanelName
        {
            get { return this._controlPanelName; }
            set { this._controlPanelName = value; }
        }

        // Check to see if ControlPanelName property is set
        internal bool IsSetControlPanelName()
        {
            return this._controlPanelName != null;
        }

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The Amazon Web Services account ID of the routing control owner.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=1024)]
        public string Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property RoutingControlArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the routing control.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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

        /// <summary>
        /// Gets and sets the property RoutingControlName. 
        /// <para>
        /// The name of the routing control.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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

        /// <summary>
        /// Gets and sets the property RoutingControlState. 
        /// <para>
        /// The current state of the routing control. When a routing control state is set to ON,
        /// traffic flows to a cell. When the state is set to OFF, traffic does not flow. 
        /// </para>
        /// </summary>
        public RoutingControlState RoutingControlState
        {
            get { return this._routingControlState; }
            set { this._routingControlState = value; }
        }

        // Check to see if RoutingControlState property is set
        internal bool IsSetRoutingControlState()
        {
            return this._routingControlState != null;
        }

    }
}