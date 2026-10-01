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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about an Amazon Web Services Amazon EC2 Transit Gateway that interconnects
    /// virtual private clouds (VPCs) and on-premises networks.
    /// </summary>
    public partial class AwsEc2TransitGatewayDetails
    {
        /// <summary>
        /// Gets and sets the property AmazonSideAsn. 
        /// <para>
        /// A private Autonomous System Number (ASN) for the Amazon side of a BGP session. 
        /// </para>
        /// </summary>
        public int? AmazonSideAsn { get; set; }

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
        /// Turn on or turn off automatic acceptance of attachment requests. 
        /// </para>
        /// </summary>
        public string AutoAcceptSharedAttachments { get; set; }

        /// <summary>
        /// Checks to see if the AutoAcceptSharedAttachments property is set.
        /// </summary>
        internal bool IsSetAutoAcceptSharedAttachments() => this.AutoAcceptSharedAttachments != null;

        /// <summary>
        /// Gets and sets the property DefaultRouteTableAssociation. 
        /// <para>
        /// Turn on or turn off automatic association with the default association route table.
        /// 
        /// </para>
        /// </summary>
        public string DefaultRouteTableAssociation { get; set; }

        /// <summary>
        /// Checks to see if the DefaultRouteTableAssociation property is set.
        /// </summary>
        internal bool IsSetDefaultRouteTableAssociation() => this.DefaultRouteTableAssociation != null;

        /// <summary>
        /// Gets and sets the property DefaultRouteTablePropagation. 
        /// <para>
        /// Turn on or turn off automatic propagation of routes to the default propagation route
        /// table. 
        /// </para>
        /// </summary>
        public string DefaultRouteTablePropagation { get; set; }

        /// <summary>
        /// Checks to see if the DefaultRouteTablePropagation property is set.
        /// </summary>
        internal bool IsSetDefaultRouteTablePropagation() => this.DefaultRouteTablePropagation != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the transit gateway. 
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DnsSupport. 
        /// <para>
        /// Turn on or turn off DNS support. 
        /// </para>
        /// </summary>
        public string DnsSupport { get; set; }

        /// <summary>
        /// Checks to see if the DnsSupport property is set.
        /// </summary>
        internal bool IsSetDnsSupport() => this.DnsSupport != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the transit gateway. 
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property MulticastSupport. 
        /// <para>
        /// Indicates whether multicast is supported on the transit gateway. 
        /// </para>
        /// </summary>
        public string MulticastSupport { get; set; }

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
        /// Gets and sets the property TransitGatewayCidrBlocks. 
        /// <para>
        /// The transit gateway Classless Inter-Domain Routing (CIDR) blocks. 
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
        /// Turn on or turn off Equal Cost Multipath Protocol (ECMP) support. 
        /// </para>
        /// </summary>
        public string VpnEcmpSupport { get; set; }

        /// <summary>
        /// Checks to see if the VpnEcmpSupport property is set.
        /// </summary>
        internal bool IsSetVpnEcmpSupport() => this.VpnEcmpSupport != null;
    }
}
