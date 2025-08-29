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
    /// The transit gateway options.
    /// </summary>
    public partial class ModifyTransitGatewayOptions
    {
        private List<string> _addTransitGatewayCidrBlocks = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private long? _amazonSideAsn;
        private string _associationDefaultRouteTableId;
        private AutoAcceptSharedAttachmentsValue _autoAcceptSharedAttachments;
        private DefaultRouteTableAssociationValue _defaultRouteTableAssociation;
        private DefaultRouteTablePropagationValue _defaultRouteTablePropagation;
        private DnsSupportValue _dnsSupport;
        private string _propagationDefaultRouteTableId;
        private List<string> _removeTransitGatewayCidrBlocks = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private SecurityGroupReferencingSupportValue _securityGroupReferencingSupport;
        private VpnEcmpSupportValue _vpnEcmpSupport;

        /// <summary>
        /// Gets and sets the property AddTransitGatewayCidrBlocks. 
        /// <para>
        /// Adds IPv4 or IPv6 CIDR blocks for the transit gateway. Must be a size /24 CIDR block
        /// or larger for IPv4, or a size /64 CIDR block or larger for IPv6.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AddTransitGatewayCidrBlocks
        {
            get { return this._addTransitGatewayCidrBlocks; }
            set { this._addTransitGatewayCidrBlocks = value; }
        }

        // Check to see if AddTransitGatewayCidrBlocks property is set
        internal bool IsSetAddTransitGatewayCidrBlocks()
        {
            return this._addTransitGatewayCidrBlocks != null && (this._addTransitGatewayCidrBlocks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        ///  </li> </ul> 
        /// <para>
        /// You must first delete all transit gateway attachments configured prior to modifying
        /// the ASN on the transit gateway.
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
        /// Gets and sets the property AssociationDefaultRouteTableId. 
        /// <para>
        /// The ID of the default association route table.
        /// </para>
        /// </summary>
        public string AssociationDefaultRouteTableId
        {
            get { return this._associationDefaultRouteTableId; }
            set { this._associationDefaultRouteTableId = value; }
        }

        // Check to see if AssociationDefaultRouteTableId property is set
        internal bool IsSetAssociationDefaultRouteTableId()
        {
            return this._associationDefaultRouteTableId != null;
        }

        /// <summary>
        /// Gets and sets the property AutoAcceptSharedAttachments. 
        /// <para>
        /// Enable or disable automatic acceptance of attachment requests.
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
        /// Indicates whether resource attachments automatically propagate routes to the default
        /// propagation route table. Enabled by default. If <c>defaultRouteTablePropagation</c>
        /// is set to <c>enable</c>, Amazon Web Services Transit Gateway will create the default
        /// transit gateway route table.
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
        /// Enable or disable DNS support.
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
        /// Gets and sets the property PropagationDefaultRouteTableId. 
        /// <para>
        /// The ID of the default propagation route table.
        /// </para>
        /// </summary>
        public string PropagationDefaultRouteTableId
        {
            get { return this._propagationDefaultRouteTableId; }
            set { this._propagationDefaultRouteTableId = value; }
        }

        // Check to see if PropagationDefaultRouteTableId property is set
        internal bool IsSetPropagationDefaultRouteTableId()
        {
            return this._propagationDefaultRouteTableId != null;
        }

        /// <summary>
        /// Gets and sets the property RemoveTransitGatewayCidrBlocks. 
        /// <para>
        /// Removes CIDR blocks for the transit gateway.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RemoveTransitGatewayCidrBlocks
        {
            get { return this._removeTransitGatewayCidrBlocks; }
            set { this._removeTransitGatewayCidrBlocks = value; }
        }

        // Check to see if RemoveTransitGatewayCidrBlocks property is set
        internal bool IsSetRemoveTransitGatewayCidrBlocks()
        {
            return this._removeTransitGatewayCidrBlocks != null && (this._removeTransitGatewayCidrBlocks.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property VpnEcmpSupport. 
        /// <para>
        /// Enable or disable Equal Cost Multipath Protocol support.
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