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
    /// Describes a VPC.
    /// </summary>
    public partial class Vpc
    {
        /// <summary>
        /// Gets and sets the property BlockPublicAccessStates. 
        /// <para>
        /// The state of VPC Block Public Access (BPA).
        /// </para>
        /// </summary>
        public BlockPublicAccessStates BlockPublicAccessStates { get; set; }

        /// <summary>
        /// Checks to see if the BlockPublicAccessStates property is set.
        /// </summary>
        internal bool IsSetBlockPublicAccessStates() => this.BlockPublicAccessStates != null;

        /// <summary>
        /// Gets and sets the property CidrBlock. 
        /// <para>
        /// The primary IPv4 CIDR block for the VPC.
        /// </para>
        /// </summary>
        public string CidrBlock { get; set; }

        /// <summary>
        /// Checks to see if the CidrBlock property is set.
        /// </summary>
        internal bool IsSetCidrBlock() => this.CidrBlock != null;

        /// <summary>
        /// Gets and sets the property CidrBlockAssociationSet. 
        /// <para>
        /// Information about the IPv4 CIDR blocks associated with the VPC.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VpcCidrBlockAssociation> CidrBlockAssociationSet { get; set; } = AWSConfigs.InitializeCollections ? new List<VpcCidrBlockAssociation>() : null;

        /// <summary>
        /// Checks to see if the CidrBlockAssociationSet property is set.
        /// </summary>
        internal bool IsSetCidrBlockAssociationSet() => this.CidrBlockAssociationSet != null && (this.CidrBlockAssociationSet.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DhcpOptionsId. 
        /// <para>
        /// The ID of the set of DHCP options you've associated with the VPC.
        /// </para>
        /// </summary>
        public string DhcpOptionsId { get; set; }

        /// <summary>
        /// Checks to see if the DhcpOptionsId property is set.
        /// </summary>
        internal bool IsSetDhcpOptionsId() => this.DhcpOptionsId != null;

        /// <summary>
        /// Gets and sets the property EncryptionControl.
        /// </summary>
        public VpcEncryptionControl EncryptionControl { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionControl property is set.
        /// </summary>
        internal bool IsSetEncryptionControl() => this.EncryptionControl != null;

        /// <summary>
        /// Gets and sets the property InstanceTenancy. 
        /// <para>
        /// The allowed tenancy of instances launched into the VPC.
        /// </para>
        /// </summary>
        public Tenancy InstanceTenancy { get; set; }

        /// <summary>
        /// Checks to see if the InstanceTenancy property is set.
        /// </summary>
        internal bool IsSetInstanceTenancy() => this.InstanceTenancy != null;

        /// <summary>
        /// Gets and sets the property Ipv6CidrBlockAssociationSet. 
        /// <para>
        /// Information about the IPv6 CIDR blocks associated with the VPC.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VpcIpv6CidrBlockAssociation> Ipv6CidrBlockAssociationSet { get; set; } = AWSConfigs.InitializeCollections ? new List<VpcIpv6CidrBlockAssociation>() : null;

        /// <summary>
        /// Checks to see if the Ipv6CidrBlockAssociationSet property is set.
        /// </summary>
        internal bool IsSetIpv6CidrBlockAssociationSet() => this.Ipv6CidrBlockAssociationSet != null && (this.Ipv6CidrBlockAssociationSet.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IsDefault. 
        /// <para>
        /// Indicates whether the VPC is the default VPC.
        /// </para>
        /// </summary>
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Checks to see if the IsDefault property is set.
        /// </summary>
        internal bool IsSetIsDefault() => this.IsDefault.HasValue;

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the VPC.
        /// </para>
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the VPC.
        /// </para>
        /// </summary>
        public VpcState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags assigned to the VPC.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
