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

namespace Amazon.Route53RecoveryControlConfig.Model
{
    /// <summary>
    /// A routing control has one of two states: ON and OFF. You can map the routing control
    /// state to the state of an Amazon Route 53 health check, which can be used to control
    /// traffic routing.
    /// </summary>
    public partial class RoutingControl
    {
        /// <summary>
        /// Gets and sets the property ControlPanelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the control panel that includes the routing control.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ControlPanelArn { get; set; }

        /// <summary>
        /// Checks to see if the ControlPanelArn property is set.
        /// </summary>
        internal bool IsSetControlPanelArn() => this.ControlPanelArn != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the routing control.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The Amazon Web Services account ID of the routing control owner.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
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
        [AWSProperty(Min = 1, Max = 256)]
        public string RoutingControlArn { get; set; }

        /// <summary>
        /// Checks to see if the RoutingControlArn property is set.
        /// </summary>
        internal bool IsSetRoutingControlArn() => this.RoutingControlArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The deployment status of a routing control. Status can be one of the following: PENDING,
        /// DEPLOYED, PENDING_DELETION.
        /// </para>
        /// </summary>
        public Status Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
