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
    /// Describes the options for a transit gateway.
    /// </summary>
    public partial class TransitGatewayRequestOptions
    {
        private long? _amazonSideAsn;
        private AutoAcceptSharedAttachmentsValue _autoAcceptSharedAttachments;
        private DefaultRouteTableAssociationValue _defaultRouteTableAssociation;
        private DefaultRouteTablePropagationValue _defaultRouteTablePropagation;
        private DnsSupportValue _dnsSupport;
        private MulticastSupportValue _multicastSupport;
        private SecurityGroupReferencingSupportValue _securityGroupReferencingSupport;
        private List<string> _transitGatewayCidrBlocks = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private VpnEcmpSupportValue _vpnEcmpSupport;

        /// <summary>
        /// Gets and sets the property AmazonSideAsn. 
        /// <para>
        /// A private Autonomous System Number (ASN) for the Amazon side of a BGP session. The
        /// range is 64512 to 65534 for 16-bit ASNs and 4200000000 to 4294967294 for 32-bit ASNs.
        /// The default is <c>64512</c>.
        /// </para>
        /// </summary>
        public long? AmazonSideAsn
        {
            get { return this._amazonSideAsn; }
            set { this._amazonSideAsn = value; }
        }

        // Check to see if AmazonSideAsn property is set
        internal bool IsSetAmazonSideAsn()
        {
            return this._amazonSideAsn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AutoAcceptSharedAttachments. 
        /// <para>
        /// Enable or disable automatic acceptance of attachment requests. Disabled by default.
        /// </para>
        /// </summary>
        public AutoAcceptSharedAttachmentsValue AutoAcceptSharedAttachments
        {
            get { return this._autoAcceptSharedAttachments; }
            set { this._autoAcceptSharedAttachments = value; }
        }

        // Check to see if AutoAcceptSharedAttachments property is set
        internal bool IsSetAutoAcceptSharedAttachments()
        {
            return this._autoAcceptSharedAttachments != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultRouteTableAssociation. 
        /// <para>
        /// Enable or disable automatic association with the default association route table.
        /// Enabled by default.
        /// </para>
        /// </summary>
        public DefaultRouteTableAssociationValue DefaultRouteTableAssociation
        {
            get { return this._defaultRouteTableAssociation; }
            set { this._defaultRouteTableAssociation = value; }
        }

        // Check to see if DefaultRouteTableAssociation property is set
        internal bool IsSetDefaultRouteTableAssociation()
        {
            return this._defaultRouteTableAssociation != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultRouteTablePropagation. 
        /// <para>
        /// Enable or disable automatic propagation of routes to the default propagation route
        /// table. Enabled by default.
        /// </para>
        /// </summary>
        public DefaultRouteTablePropagationValue DefaultRouteTablePropagation
        {
            get { return this._defaultRouteTablePropagation; }
            set { this._defaultRouteTablePropagation = value; }
        }

        // Check to see if DefaultRouteTablePropagation property is set
        internal bool IsSetDefaultRouteTablePropagation()
        {
            return this._defaultRouteTablePropagation != null;
        }

        /// <summary>
        /// Gets and sets the property DnsSupport. 
        /// <para>
        /// Enable or disable DNS support. Enabled by default.
        /// </para>
        /// </summary>
        public DnsSupportValue DnsSupport
        {
            get { return this._dnsSupport; }
            set { this._dnsSupport = value; }
        }

        // Check to see if DnsSupport property is set
        internal bool IsSetDnsSupport()
        {
            return this._dnsSupport != null;
        }

        /// <summary>
        /// Gets and sets the property MulticastSupport. 
        /// <para>
        /// Indicates whether multicast is enabled on the transit gateway
        /// </para>
        /// </summary>
        public MulticastSupportValue MulticastSupport
        {
            get { return this._multicastSupport; }
            set { this._multicastSupport = value; }
        }

        // Check to see if MulticastSupport property is set
        internal bool IsSetMulticastSupport()
        {
            return this._multicastSupport != null;
        }

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
        public SecurityGroupReferencingSupportValue SecurityGroupReferencingSupport
        {
            get { return this._securityGroupReferencingSupport; }
            set { this._securityGroupReferencingSupport = value; }
        }

        // Check to see if SecurityGroupReferencingSupport property is set
        internal bool IsSetSecurityGroupReferencingSupport()
        {
            return this._securityGroupReferencingSupport != null;
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayCidrBlocks. 
        /// <para>
        /// One or more IPv4 or IPv6 CIDR blocks for the transit gateway. Must be a size /24 CIDR
        /// block or larger for IPv4, or a size /64 CIDR block or larger for IPv6.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TransitGatewayCidrBlocks
        {
            get { return this._transitGatewayCidrBlocks; }
            set { this._transitGatewayCidrBlocks = value; }
        }

        // Check to see if TransitGatewayCidrBlocks property is set
        internal bool IsSetTransitGatewayCidrBlocks()
        {
            return this._transitGatewayCidrBlocks != null && (this._transitGatewayCidrBlocks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpnEcmpSupport. 
        /// <para>
        /// Enable or disable Equal Cost Multipath Protocol support. Enabled by default.
        /// </para>
        /// </summary>
        public VpnEcmpSupportValue VpnEcmpSupport
        {
            get { return this._vpnEcmpSupport; }
            set { this._vpnEcmpSupport = value; }
        }

        // Check to see if VpnEcmpSupport property is set
        internal bool IsSetVpnEcmpSupport()
        {
            return this._vpnEcmpSupport != null;
        }

    }
}