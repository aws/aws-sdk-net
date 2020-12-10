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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// The transit gateway options.
    /// </summary>
    public partial class ModifyTransitGatewayOptions
    {
        private List<string> _addTransitGatewayCidrBlocks = new List<string>();
        private string _associationDefaultRouteTableId;
        private AutoAcceptSharedAttachmentsValue _autoAcceptSharedAttachments;
        private DefaultRouteTableAssociationValue _defaultRouteTableAssociation;
        private DefaultRouteTablePropagationValue _defaultRouteTablePropagation;
        private DnsSupportValue _dnsSupport;
        private string _propagationDefaultRouteTableId;
        private List<string> _removeTransitGatewayCidrBlocks = new List<string>();
        private VpnEcmpSupportValue _vpnEcmpSupport;

        /// <summary>
        /// Gets and sets the property AddTransitGatewayCidrBlocks. 
        /// <para>
        /// Adds IPv4 or IPv6 CIDR blocks for the transit gateway. Must be a size /24 CIDR block
        /// or larger for IPv4, or a size /64 CIDR block or larger for IPv6.
        /// </para>
        /// </summary>
        public List<string> AddTransitGatewayCidrBlocks
        {
            get { return this._addTransitGatewayCidrBlocks; }
            set { this._addTransitGatewayCidrBlocks = value; }
        }

        // Check to see if AddTransitGatewayCidrBlocks property is set
        internal bool IsSetAddTransitGatewayCidrBlocks()
        {
            return this._addTransitGatewayCidrBlocks != null && this._addTransitGatewayCidrBlocks.Count > 0; 
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
        /// Enable or disable automatic propagation of routes to the default propagation route
        /// table.
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
        /// </summary>
        public List<string> RemoveTransitGatewayCidrBlocks
        {
            get { return this._removeTransitGatewayCidrBlocks; }
            set { this._removeTransitGatewayCidrBlocks = value; }
        }

        // Check to see if RemoveTransitGatewayCidrBlocks property is set
        internal bool IsSetRemoveTransitGatewayCidrBlocks()
        {
            return this._removeTransitGatewayCidrBlocks != null && this._removeTransitGatewayCidrBlocks.Count > 0; 
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