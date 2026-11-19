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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the traffic matching criteria for a transit gateway metering policy rule.
    /// </summary>
    public partial class TransitGatewayMeteringPolicyRule
    {
        /// <summary>
        /// Gets and sets the property DestinationCidrBlock. 
        /// <para>
        /// The destination CIDR block for the rule.
        /// </para>
        /// </summary>
        public string DestinationCidrBlock { get; set; }

        /// <summary>
        /// Checks to see if the DestinationCidrBlock property is set.
        /// </summary>
        internal bool IsSetDestinationCidrBlock() => this.DestinationCidrBlock != null;

        /// <summary>
        /// Gets and sets the property DestinationPortRange. 
        /// <para>
        /// The destination port range for the rule.
        /// </para>
        /// </summary>
        public string DestinationPortRange { get; set; }

        /// <summary>
        /// Checks to see if the DestinationPortRange property is set.
        /// </summary>
        internal bool IsSetDestinationPortRange() => this.DestinationPortRange != null;

        /// <summary>
        /// Gets and sets the property DestinationTransitGatewayAttachmentId. 
        /// <para>
        /// The ID of the destination transit gateway attachment.
        /// </para>
        /// </summary>
        public string DestinationTransitGatewayAttachmentId { get; set; }

        /// <summary>
        /// Checks to see if the DestinationTransitGatewayAttachmentId property is set.
        /// </summary>
        internal bool IsSetDestinationTransitGatewayAttachmentId() => this.DestinationTransitGatewayAttachmentId != null;

        /// <summary>
        /// Gets and sets the property DestinationTransitGatewayAttachmentType. 
        /// <para>
        /// The type of the destination transit gateway attachment. Note that the <c>tgw-peering</c>
        /// resource type has been deprecated. To configure metering policies for Connect, use
        /// the transport attachment type.
        /// </para>
        /// </summary>
        public TransitGatewayAttachmentResourceType DestinationTransitGatewayAttachmentType { get; set; }

        /// <summary>
        /// Checks to see if the DestinationTransitGatewayAttachmentType property is set.
        /// </summary>
        internal bool IsSetDestinationTransitGatewayAttachmentType() => this.DestinationTransitGatewayAttachmentType != null;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol for the rule (1, 6, 17, etc.).
        /// </para>
        /// </summary>
        public string Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property SourceCidrBlock. 
        /// <para>
        /// The source CIDR block for the rule.
        /// </para>
        /// </summary>
        public string SourceCidrBlock { get; set; }

        /// <summary>
        /// Checks to see if the SourceCidrBlock property is set.
        /// </summary>
        internal bool IsSetSourceCidrBlock() => this.SourceCidrBlock != null;

        /// <summary>
        /// Gets and sets the property SourcePortRange. 
        /// <para>
        /// The source port range for the rule.
        /// </para>
        /// </summary>
        public string SourcePortRange { get; set; }

        /// <summary>
        /// Checks to see if the SourcePortRange property is set.
        /// </summary>
        internal bool IsSetSourcePortRange() => this.SourcePortRange != null;

        /// <summary>
        /// Gets and sets the property SourceTransitGatewayAttachmentId. 
        /// <para>
        /// The ID of the source transit gateway attachment.
        /// </para>
        /// </summary>
        public string SourceTransitGatewayAttachmentId { get; set; }

        /// <summary>
        /// Checks to see if the SourceTransitGatewayAttachmentId property is set.
        /// </summary>
        internal bool IsSetSourceTransitGatewayAttachmentId() => this.SourceTransitGatewayAttachmentId != null;

        /// <summary>
        /// Gets and sets the property SourceTransitGatewayAttachmentType. 
        /// <para>
        /// The type of the source transit gateway attachment. Note that the <c>tgw-peering</c>
        /// resource type has been deprecated. To configure metering policies for Connect, use
        /// the transport attachment type.
        /// </para>
        /// </summary>
        public TransitGatewayAttachmentResourceType SourceTransitGatewayAttachmentType { get; set; }

        /// <summary>
        /// Checks to see if the SourceTransitGatewayAttachmentType property is set.
        /// </summary>
        internal bool IsSetSourceTransitGatewayAttachmentType() => this.SourceTransitGatewayAttachmentType != null;
    }
}
