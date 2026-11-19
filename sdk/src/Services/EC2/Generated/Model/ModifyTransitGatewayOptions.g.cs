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
    /// The transit gateway options.
    /// </summary>
    public partial class ModifyTransitGatewayOptions
    {
        /// <summary>
        /// Gets and sets the property AddTransitGatewayCidrBlocks. 
        /// <para>
        /// Adds IPv4 or IPv6 CIDR blocks for the transit gateway. Must be a size /24 CIDR block
        /// or larger for IPv4, or a size /64 CIDR block or larger for IPv6.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AddTransitGatewayCidrBlocks { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AddTransitGatewayCidrBlocks property is set.
        /// </summary>
        internal bool IsSetAddTransitGatewayCidrBlocks() => this.AddTransitGatewayCidrBlocks != null && (this.AddTransitGatewayCidrBlocks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AmazonSideAsn. 
        /// <para>
        /// A private Autonomous System Number (ASN) for the Amazon side of a BGP session. The
        /// range is 64512 to 65534 for 16-bit ASNs and 4200000000 to 4294967294 for 32-bit ASNs.
        /// </para>
        ///  
        /// <para>
        /// The modify ASN operation is not allowed on a transit gateway if it has the following
        /// attachments:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Dynamic VPN
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Static VPN
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Direct Connect Gateway
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Connect
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// VPN Concentrator
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Client VPN
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You must first delete all transit gateway attachments configured prior to modifying
        /// the ASN on the transit gateway.
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
        /// Enable or disable automatic acceptance of attachment requests.
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
        /// Enable or disable automatic association with the default association route table.
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
        /// is set to <c>enable</c>, Amazon Web Services Transit Gateway will create the default
        /// transit gateway route table.
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
        /// Enable or disable DNS support.
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
        /// Enable or disable encryption support for VPC Encryption Control.
        /// </para>
        /// </summary>
        public EncryptionSupportOptionValue EncryptionSupport { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionSupport property is set.
        /// </summary>
        internal bool IsSetEncryptionSupport() => this.EncryptionSupport != null;

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
        /// Gets and sets the property RemoveTransitGatewayCidrBlocks. 
        /// <para>
        /// Removes CIDR blocks for the transit gateway.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RemoveTransitGatewayCidrBlocks { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RemoveTransitGatewayCidrBlocks property is set.
        /// </summary>
        internal bool IsSetRemoveTransitGatewayCidrBlocks() => this.RemoveTransitGatewayCidrBlocks != null && (this.RemoveTransitGatewayCidrBlocks.Count > 0 || !AWSConfigs.InitializeCollections);

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
        ///  
        /// <para>
        /// For more information about security group referencing, see <a href="https://docs.aws.amazon.com/vpc/latest/tgw/tgw-vpc-attachments.html#vpc-attachment-security">Security
        /// group referencing</a> in the <i>Amazon Web Services Transit Gateways Guide</i>.
        /// </para>
        /// </summary>
        public SecurityGroupReferencingSupportValue SecurityGroupReferencingSupport { get; set; }

        /// <summary>
        /// Checks to see if the SecurityGroupReferencingSupport property is set.
        /// </summary>
        internal bool IsSetSecurityGroupReferencingSupport() => this.SecurityGroupReferencingSupport != null;

        /// <summary>
        /// Gets and sets the property VpnEcmpSupport. 
        /// <para>
        /// Enable or disable Equal Cost Multipath Protocol support.
        /// </para>
        /// </summary>
        public VpnEcmpSupportValue VpnEcmpSupport { get; set; }

        /// <summary>
        /// Checks to see if the VpnEcmpSupport property is set.
        /// </summary>
        internal bool IsSetVpnEcmpSupport() => this.VpnEcmpSupport != null;
    }
}
