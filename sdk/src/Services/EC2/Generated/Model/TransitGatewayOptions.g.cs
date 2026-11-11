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
    /// Describes the options for a transit gateway.
    /// </summary>
    public partial class TransitGatewayOptions
    {
        /// <summary>
        /// Gets and sets the property AmazonSideAsn. 
        /// <para>
        /// A private Autonomous System Number (ASN) for the Amazon side of a BGP session. The
        /// range is 64512 to 65534 for 16-bit ASNs and 4200000000 to 4294967294 for 32-bit ASNs.
        /// </para>
        /// </summary>
        public long? AmazonSideAsn { get; set; }

        /// <summary>
        /// Checks to see if the AmazonSideAsn property is set.
        /// </summary>
        internal bool IsSetAmazonSideAsn() => this.AmazonSideAsn.HasValue;

        /// <summary>
        /// Gets and sets the property AssociationDefaultRouteTableId. 
        /// <para>
        /// The ID of the default association route table.
        /// </para>
        /// </summary>
        public string AssociationDefaultRouteTableId { get; set; }

        /// <summary>
        /// Checks to see if the AssociationDefaultRouteTableId property is set.
        /// </summary>
        internal bool IsSetAssociationDefaultRouteTableId() => this.AssociationDefaultRouteTableId != null;

        /// <summary>
        /// Gets and sets the property AutoAcceptSharedAttachments. 
        /// <para>
        /// Indicates whether attachment requests are automatically accepted.
        /// </para>
        /// </summary>
        public AutoAcceptSharedAttachmentsValue AutoAcceptSharedAttachments { get; set; }

        /// <summary>
        /// Checks to see if the AutoAcceptSharedAttachments property is set.
        /// </summary>
        internal bool IsSetAutoAcceptSharedAttachments() => this.AutoAcceptSharedAttachments != null;

        /// <summary>
        /// Gets and sets the property DefaultRouteTableAssociation. 
        /// <para>
        /// Indicates whether resource attachments are automatically associated with the default
        /// association route table. Enabled by default. Either <c>defaultRouteTableAssociation</c>
        /// or <c>defaultRouteTablePropagation</c> must be set to <c>enable</c> for Amazon Web
        /// Services Transit Gateway to create the default transit gateway route table.
        /// </para>
        /// </summary>
        public DefaultRouteTableAssociationValue DefaultRouteTableAssociation { get; set; }

        /// <summary>
        /// Checks to see if the DefaultRouteTableAssociation property is set.
        /// </summary>
        internal bool IsSetDefaultRouteTableAssociation() => this.DefaultRouteTableAssociation != null;

        /// <summary>
        /// Gets and sets the property DefaultRouteTablePropagation. 
        /// <para>
        /// Indicates whether resource attachments automatically propagate routes to the default
        /// propagation route table. Enabled by default. If <c>defaultRouteTablePropagation</c>
        /// is set to <c>enable</c>, Amazon Web Services Transit Gateway creates the default transit
        /// gateway route table.
        /// </para>
        /// </summary>
        public DefaultRouteTablePropagationValue DefaultRouteTablePropagation { get; set; }

        /// <summary>
        /// Checks to see if the DefaultRouteTablePropagation property is set.
        /// </summary>
        internal bool IsSetDefaultRouteTablePropagation() => this.DefaultRouteTablePropagation != null;

        /// <summary>
        /// Gets and sets the property DnsSupport. 
        /// <para>
        /// Indicates whether DNS support is enabled.
        /// </para>
        /// </summary>
        public DnsSupportValue DnsSupport { get; set; }

        /// <summary>
        /// Checks to see if the DnsSupport property is set.
        /// </summary>
        internal bool IsSetDnsSupport() => this.DnsSupport != null;

        /// <summary>
        /// Gets and sets the property EncryptionSupport. 
        /// <para>
        /// Defines if the Transit Gateway supports VPC Encryption Control.
        /// </para>
        /// </summary>
        public EncryptionSupport EncryptionSupport { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionSupport property is set.
        /// </summary>
        internal bool IsSetEncryptionSupport() => this.EncryptionSupport != null;

        /// <summary>
        /// Gets and sets the property MulticastSupport. 
        /// <para>
        /// Indicates whether multicast is enabled on the transit gateway
        /// </para>
        /// </summary>
        public MulticastSupportValue MulticastSupport { get; set; }

        /// <summary>
        /// Checks to see if the MulticastSupport property is set.
        /// </summary>
        internal bool IsSetMulticastSupport() => this.MulticastSupport != null;

        /// <summary>
        /// Gets and sets the property PropagationDefaultRouteTableId. 
        /// <para>
        /// The ID of the default propagation route table.
        /// </para>
        /// </summary>
        public string PropagationDefaultRouteTableId { get; set; }

        /// <summary>
        /// Checks to see if the PropagationDefaultRouteTableId property is set.
        /// </summary>
        internal bool IsSetPropagationDefaultRouteTableId() => this.PropagationDefaultRouteTableId != null;

        /// <summary>
        /// Gets and sets the property SecurityGroupReferencingSupport. 
        /// <para>
        /// Enables you to reference a security group across VPCs attached to a transit gateway
        /// to simplify security group management. 
        /// </para>
        ///  
        /// <para>
        /// This option is disabled by default.
        /// </para>
        /// </summary>
        public SecurityGroupReferencingSupportValue SecurityGroupReferencingSupport { get; set; }

        /// <summary>
        /// Checks to see if the SecurityGroupReferencingSupport property is set.
        /// </summary>
        internal bool IsSetSecurityGroupReferencingSupport() => this.SecurityGroupReferencingSupport != null;

        /// <summary>
        /// Gets and sets the property TransitGatewayCidrBlocks. 
        /// <para>
        /// The transit gateway CIDR blocks.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TransitGatewayCidrBlocks { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TransitGatewayCidrBlocks property is set.
        /// </summary>
        internal bool IsSetTransitGatewayCidrBlocks() => this.TransitGatewayCidrBlocks != null && (this.TransitGatewayCidrBlocks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpnEcmpSupport. 
        /// <para>
        /// Indicates whether Equal Cost Multipath Protocol support is enabled.
        /// </para>
        /// </summary>
        public VpnEcmpSupportValue VpnEcmpSupport { get; set; }

        /// <summary>
        /// Checks to see if the VpnEcmpSupport property is set.
        /// </summary>
        internal bool IsSetVpnEcmpSupport() => this.VpnEcmpSupport != null;
    }
}
