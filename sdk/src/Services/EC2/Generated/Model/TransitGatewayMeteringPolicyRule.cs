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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
        private string _destinationCidrBlock;
        private string _destinationPortRange;
        private string _destinationTransitGatewayAttachmentId;
        private TransitGatewayAttachmentResourceType _destinationTransitGatewayAttachmentType;
        private string _protocol;
        private string _sourceCidrBlock;
        private string _sourcePortRange;
        private string _sourceTransitGatewayAttachmentId;
        private TransitGatewayAttachmentResourceType _sourceTransitGatewayAttachmentType;

        /// <summary>
        /// Gets and sets the property DestinationCidrBlock. 
        /// <para>
        /// The destination CIDR block for the rule.
        /// </para>
        /// </summary>
        public string DestinationCidrBlock
        {
            get { return this._destinationCidrBlock; }
            set { this._destinationCidrBlock = value; }
        }

        // Check to see if DestinationCidrBlock property is set
        internal bool IsSetDestinationCidrBlock()
        {
            return this._destinationCidrBlock != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationPortRange. 
        /// <para>
        /// The destination port range for the rule.
        /// </para>
        /// </summary>
        public string DestinationPortRange
        {
            get { return this._destinationPortRange; }
            set { this._destinationPortRange = value; }
        }

        // Check to see if DestinationPortRange property is set
        internal bool IsSetDestinationPortRange()
        {
            return this._destinationPortRange != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationTransitGatewayAttachmentId. 
        /// <para>
        /// The ID of the destination transit gateway attachment.
        /// </para>
        /// </summary>
        public string DestinationTransitGatewayAttachmentId
        {
            get { return this._destinationTransitGatewayAttachmentId; }
            set { this._destinationTransitGatewayAttachmentId = value; }
        }

        // Check to see if DestinationTransitGatewayAttachmentId property is set
        internal bool IsSetDestinationTransitGatewayAttachmentId()
        {
            return this._destinationTransitGatewayAttachmentId != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationTransitGatewayAttachmentType. 
        /// <para>
        /// The type of the destination transit gateway attachment. Note that the <c>tgw-peering</c>
        /// resource type has been deprecated. To configure metering policies for Connect, use
        /// the transport attachment type.
        /// </para>
        /// </summary>
        public TransitGatewayAttachmentResourceType DestinationTransitGatewayAttachmentType
        {
            get { return this._destinationTransitGatewayAttachmentType; }
            set { this._destinationTransitGatewayAttachmentType = value; }
        }

        // Check to see if DestinationTransitGatewayAttachmentType property is set
        internal bool IsSetDestinationTransitGatewayAttachmentType()
        {
            return this._destinationTransitGatewayAttachmentType != null;
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol for the rule (1, 6, 17, etc.).
        /// </para>
        /// </summary>
        public string Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

        /// <summary>
        /// Gets and sets the property SourceCidrBlock. 
        /// <para>
        /// The source CIDR block for the rule.
        /// </para>
        /// </summary>
        public string SourceCidrBlock
        {
            get { return this._sourceCidrBlock; }
            set { this._sourceCidrBlock = value; }
        }

        // Check to see if SourceCidrBlock property is set
        internal bool IsSetSourceCidrBlock()
        {
            return this._sourceCidrBlock != null;
        }

        /// <summary>
        /// Gets and sets the property SourcePortRange. 
        /// <para>
        /// The source port range for the rule.
        /// </para>
        /// </summary>
        public string SourcePortRange
        {
            get { return this._sourcePortRange; }
            set { this._sourcePortRange = value; }
        }

        // Check to see if SourcePortRange property is set
        internal bool IsSetSourcePortRange()
        {
            return this._sourcePortRange != null;
        }

        /// <summary>
        /// Gets and sets the property SourceTransitGatewayAttachmentId. 
        /// <para>
        /// The ID of the source transit gateway attachment.
        /// </para>
        /// </summary>
        public string SourceTransitGatewayAttachmentId
        {
            get { return this._sourceTransitGatewayAttachmentId; }
            set { this._sourceTransitGatewayAttachmentId = value; }
        }

        // Check to see if SourceTransitGatewayAttachmentId property is set
        internal bool IsSetSourceTransitGatewayAttachmentId()
        {
            return this._sourceTransitGatewayAttachmentId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceTransitGatewayAttachmentType. 
        /// <para>
        /// The type of the source transit gateway attachment. Note that the <c>tgw-peering</c>
        /// resource type has been deprecated. To configure metering policies for Connect, use
        /// the transport attachment type.
        /// </para>
        /// </summary>
        public TransitGatewayAttachmentResourceType SourceTransitGatewayAttachmentType
        {
            get { return this._sourceTransitGatewayAttachmentType; }
            set { this._sourceTransitGatewayAttachmentType = value; }
        }

        // Check to see if SourceTransitGatewayAttachmentType property is set
        internal bool IsSetSourceTransitGatewayAttachmentType()
        {
            return this._sourceTransitGatewayAttachmentType != null;
        }

    }
}