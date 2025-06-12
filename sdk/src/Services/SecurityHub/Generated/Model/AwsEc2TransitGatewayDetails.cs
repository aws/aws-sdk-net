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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about an Amazon Web Services Amazon EC2 Transit Gateway that interconnects
    /// virtual private clouds (VPCs) and on-premises networks.
    /// </summary>
    public partial class AwsEc2TransitGatewayDetails
    {
        private int? _amazonSideAsn;
        private string _associationDefaultRouteTableId;
        private string _autoAcceptSharedAttachments;
        private string _defaultRouteTableAssociation;
        private string _defaultRouteTablePropagation;
        private string _description;
        private string _dnsSupport;
        private string _id;
        private string _multicastSupport;
        private string _propagationDefaultRouteTableId;
        private List<string> _transitGatewayCidrBlocks = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _vpnEcmpSupport;

        /// <summary>
        /// Gets and sets the property AmazonSideAsn. 
        /// <para>
        /// A private Autonomous System Number (ASN) for the Amazon side of a BGP session. 
        /// </para>
        /// </summary>
        public int? AmazonSideAsn
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
        /// Turn on or turn off automatic acceptance of attachment requests. 
        /// </para>
        /// </summary>
        public string AutoAcceptSharedAttachments
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
        /// Turn on or turn off automatic association with the default association route table.
        /// 
        /// </para>
        /// </summary>
        public string DefaultRouteTableAssociation
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
        /// Turn on or turn off automatic propagation of routes to the default propagation route
        /// table. 
        /// </para>
        /// </summary>
        public string DefaultRouteTablePropagation
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the transit gateway. 
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DnsSupport. 
        /// <para>
        /// Turn on or turn off DNS support. 
        /// </para>
        /// </summary>
        public string DnsSupport
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the transit gateway. 
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property MulticastSupport. 
        /// <para>
        /// Indicates whether multicast is supported on the transit gateway. 
        /// </para>
        /// </summary>
        public string MulticastSupport
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
        /// Gets and sets the property TransitGatewayCidrBlocks. 
        /// <para>
        /// The transit gateway Classless Inter-Domain Routing (CIDR) blocks. 
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
        /// Turn on or turn off Equal Cost Multipath Protocol (ECMP) support. 
        /// </para>
        /// </summary>
        public string VpnEcmpSupport
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