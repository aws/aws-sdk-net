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

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Configuration for the target network topology and addressing.
    /// </summary>
    public partial class TargetNetwork
    {
        /// <summary>
        /// Gets and sets the property InboundCidr. 
        /// <para>
        /// The CIDR block for inbound traffic in the target network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 9, Max = 18)]
        public string InboundCidr { get; set; }

        /// <summary>
        /// Checks to see if the InboundCidr property is set.
        /// </summary>
        internal bool IsSetInboundCidr() => this.InboundCidr != null;

        /// <summary>
        /// Gets and sets the property InspectionCidr. 
        /// <para>
        /// The CIDR block for inspection traffic in the target network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 9, Max = 18)]
        public string InspectionCidr { get; set; }

        /// <summary>
        /// Checks to see if the InspectionCidr property is set.
        /// </summary>
        internal bool IsSetInspectionCidr() => this.InspectionCidr != null;

        /// <summary>
        /// Gets and sets the property OutboundCidr. 
        /// <para>
        /// The CIDR block for outbound traffic in the target network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 9, Max = 18)]
        public string OutboundCidr { get; set; }

        /// <summary>
        /// Checks to see if the OutboundCidr property is set.
        /// </summary>
        internal bool IsSetOutboundCidr() => this.OutboundCidr != null;

        /// <summary>
        /// Gets and sets the property Topology. 
        /// <para>
        /// The network topology type for the target environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TargetNetworkTopology Topology { get; set; }

        /// <summary>
        /// Checks to see if the Topology property is set.
        /// </summary>
        internal bool IsSetTopology() => this.Topology != null;
    }
}
