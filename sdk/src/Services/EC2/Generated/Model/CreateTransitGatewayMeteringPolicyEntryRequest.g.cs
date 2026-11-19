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
    /// Container for the parameters to the CreateTransitGatewayMeteringPolicyEntry operation.
    /// Creates an entry in a transit gateway metering policy to define traffic measurement
    /// rules.
    /// </summary>
    public partial class CreateTransitGatewayMeteringPolicyEntryRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property DestinationCidrBlock. 
        /// <para>
        /// The destination CIDR block for traffic matching.
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
        /// The destination port range for traffic matching.
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
        /// The ID of the destination transit gateway attachment for traffic matching.
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
        /// The type of the destination transit gateway attachment for traffic matching. Note
        /// that the <c>tgw-peering</c> resource type has been deprecated. To configure metering
        /// policies for Connect, use the transport attachment type.
        /// </para>
        /// </summary>
        public TransitGatewayAttachmentResourceType DestinationTransitGatewayAttachmentType { get; set; }

        /// <summary>
        /// Checks to see if the DestinationTransitGatewayAttachmentType property is set.
        /// </summary>
        internal bool IsSetDestinationTransitGatewayAttachmentType() => this.DestinationTransitGatewayAttachmentType != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property MeteredAccount. 
        /// <para>
        /// The Amazon Web Services account ID to which the metered traffic should be attributed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TransitGatewayMeteringPayerType MeteredAccount { get; set; }

        /// <summary>
        /// Checks to see if the MeteredAccount property is set.
        /// </summary>
        internal bool IsSetMeteredAccount() => this.MeteredAccount != null;

        /// <summary>
        /// Gets and sets the property PolicyRuleNumber. 
        /// <para>
        /// The rule number for the metering policy entry. Rules are processed in order from lowest
        /// to highest number.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? PolicyRuleNumber { get; set; }

        /// <summary>
        /// Checks to see if the PolicyRuleNumber property is set.
        /// </summary>
        internal bool IsSetPolicyRuleNumber() => this.PolicyRuleNumber.HasValue;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol for traffic matching (1, 6, 17, etc.).
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
        /// The source CIDR block for traffic matching.
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
        /// The source port range for traffic matching.
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
        /// The ID of the source transit gateway attachment for traffic matching.
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
        /// The type of the source transit gateway attachment for traffic matching. Note that
        /// the <c>tgw-peering</c> resource type has been deprecated. To configure metering policies
        /// for Connect, use the transport attachment type.
        /// </para>
        /// </summary>
        public TransitGatewayAttachmentResourceType SourceTransitGatewayAttachmentType { get; set; }

        /// <summary>
        /// Checks to see if the SourceTransitGatewayAttachmentType property is set.
        /// </summary>
        internal bool IsSetSourceTransitGatewayAttachmentType() => this.SourceTransitGatewayAttachmentType != null;

        /// <summary>
        /// Gets and sets the property TransitGatewayMeteringPolicyId. 
        /// <para>
        /// The ID of the transit gateway metering policy to add the entry to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TransitGatewayMeteringPolicyId { get; set; }

        /// <summary>
        /// Checks to see if the TransitGatewayMeteringPolicyId property is set.
        /// </summary>
        internal bool IsSetTransitGatewayMeteringPolicyId() => this.TransitGatewayMeteringPolicyId != null;
    }
}
