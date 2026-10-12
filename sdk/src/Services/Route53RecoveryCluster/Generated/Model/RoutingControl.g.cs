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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property ControlPanelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the control panel where the routing control is located.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ControlPanelArn { get; set; }

        /// <summary>
        /// Checks to see if the ControlPanelArn property is set.
        /// </summary>
        internal bool IsSetControlPanelArn() => this.ControlPanelArn != null;

        /// <summary>
        /// Gets and sets the property ControlPanelName. 
        /// <para>
        /// The name of the control panel where the routing control is located. Only ASCII characters
        /// are supported for control panel names.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ControlPanelName { get; set; }

        /// <summary>
        /// Checks to see if the ControlPanelName property is set.
        /// </summary>
        internal bool IsSetControlPanelName() => this.ControlPanelName != null;

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The Amazon Web Services account ID of the routing control owner.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 1024)]
        public string Owner { get; set; }

        /// <summary>
        /// Checks to see if the Owner property is set.
        /// </summary>
        internal bool IsSetOwner() => this.Owner != null;

        /// <summary>
        /// Gets and sets the property RoutingControlArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the routing control.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string RoutingControlArn { get; set; }

        /// <summary>
        /// Checks to see if the RoutingControlArn property is set.
        /// </summary>
        internal bool IsSetRoutingControlArn() => this.RoutingControlArn != null;

        /// <summary>
        /// Gets and sets the property RoutingControlName. 
        /// <para>
        /// The name of the routing control.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string RoutingControlName { get; set; }

        /// <summary>
        /// Checks to see if the RoutingControlName property is set.
        /// </summary>
        internal bool IsSetRoutingControlName() => this.RoutingControlName != null;

        /// <summary>
        /// Gets and sets the property RoutingControlState. 
        /// <para>
        /// The current state of the routing control. When a routing control state is set to ON,
        /// traffic flows to a cell. When the state is set to OFF, traffic does not flow. 
        /// </para>
        /// </summary>
        public RoutingControlState RoutingControlState { get; set; }

        /// <summary>
        /// Checks to see if the RoutingControlState property is set.
        /// </summary>
        internal bool IsSetRoutingControlState() => this.RoutingControlState != null;
    }
}
