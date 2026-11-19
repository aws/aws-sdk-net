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
    public partial class TransitGatewayRequestOptions
    {
        /// <summary>
        /// Gets and sets the property AmazonSideAsn. 
        /// <para>
        /// A private Autonomous System Number (ASN) for the Amazon side of a BGP session. The
        /// range is 64512 to 65534 for 16-bit ASNs and 4200000000 to 4294967294 for 32-bit ASNs.
        /// The default is <c>64512</c>.
        /// </para>
        /// </summary>
        public long? AmazonSideAsn { get; set; }

        /// <summary>
        /// Checks to see if the AmazonSideAsn property is set.
        /// </summary>
        internal bool IsSetAmazonSideAsn() => this.AmazonSideAsn.HasValue;

        /// <summary>
        /// Gets and sets the property AutoAcceptSharedAttachments. 
        /// <para>
        /// Enable or disable automatic acceptance of attachment requests. Disabled by default.
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
        /// Enabled by default.
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
        /// Enable or disable automatic propagation of routes to the default propagation route
        /// table. Enabled by default.
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
        /// Enable or disable DNS support. Enabled by default.
        /// </para>
        /// </summary>
        public DnsSupportValue DnsSupport { get; set; }

        /// <summary>
        /// Checks to see if the DnsSupport property is set.
        /// </summary>
        internal bool IsSetDnsSupport() => this.DnsSupport != null;

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
        /// Gets and sets the property TransitGatewayCidrBlocks. 
        /// <para>
        /// One or more IPv4 or IPv6 CIDR blocks for the transit gateway. Must be a size /24 CIDR
        /// block or larger for IPv4, or a size /64 CIDR block or larger for IPv6.
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
        /// Enable or disable Equal Cost Multipath Protocol support. Enabled by default.
        /// </para>
        /// </summary>
        public VpnEcmpSupportValue VpnEcmpSupport { get; set; }

        /// <summary>
        /// Checks to see if the VpnEcmpSupport property is set.
        /// </summary>
        internal bool IsSetVpnEcmpSupport() => this.VpnEcmpSupport != null;
    }
}
