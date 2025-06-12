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
    /// Describes a VPC.
    /// </summary>
    public partial class Vpc
    {
        private BlockPublicAccessStates _blockPublicAccessStates;
        private string _cidrBlock;
        private List<VpcCidrBlockAssociation> _cidrBlockAssociationSet = AWSConfigs.InitializeCollections ? new List<VpcCidrBlockAssociation>() : null;
        private string _dhcpOptionsId;
        private VpcEncryptionControl _encryptionControl;
        private Tenancy _instanceTenancy;
        private List<VpcIpv6CidrBlockAssociation> _ipv6CidrBlockAssociationSet = AWSConfigs.InitializeCollections ? new List<VpcIpv6CidrBlockAssociation>() : null;
        private bool? _isDefault;
        private string _ownerId;
        private VpcState _state;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property BlockPublicAccessStates. 
        /// <para>
        /// The state of VPC Block Public Access (BPA).
        /// </para>
        /// </summary>
        public BlockPublicAccessStates BlockPublicAccessStates
        {
            get { return this._blockPublicAccessStates; }
            set { this._blockPublicAccessStates = value; }
        }

        // Check to see if BlockPublicAccessStates property is set
        internal bool IsSetBlockPublicAccessStates()
        {
            return this._blockPublicAccessStates != null;
        }

        /// <summary>
        /// Gets and sets the property CidrBlock. 
        /// <para>
        /// The primary IPv4 CIDR block for the VPC.
        /// </para>
        /// </summary>
        public string CidrBlock
        {
            get { return this._cidrBlock; }
            set { this._cidrBlock = value; }
        }

        // Check to see if CidrBlock property is set
        internal bool IsSetCidrBlock()
        {
            return this._cidrBlock != null;
        }

        /// <summary>
        /// Gets and sets the property CidrBlockAssociationSet. 
        /// <para>
        /// Information about the IPv4 CIDR blocks associated with the VPC.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VpcCidrBlockAssociation> CidrBlockAssociationSet
        {
            get { return this._cidrBlockAssociationSet; }
            set { this._cidrBlockAssociationSet = value; }
        }

        // Check to see if CidrBlockAssociationSet property is set
        internal bool IsSetCidrBlockAssociationSet()
        {
            return this._cidrBlockAssociationSet != null && (this._cidrBlockAssociationSet.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DhcpOptionsId. 
        /// <para>
        /// The ID of the set of DHCP options you've associated with the VPC.
        /// </para>
        /// </summary>
        public string DhcpOptionsId
        {
            get { return this._dhcpOptionsId; }
            set { this._dhcpOptionsId = value; }
        }

        // Check to see if DhcpOptionsId property is set
        internal bool IsSetDhcpOptionsId()
        {
            return this._dhcpOptionsId != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionControl.
        /// </summary>
        public VpcEncryptionControl EncryptionControl
        {
            get { return this._encryptionControl; }
            set { this._encryptionControl = value; }
        }

        // Check to see if EncryptionControl property is set
        internal bool IsSetEncryptionControl()
        {
            return this._encryptionControl != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceTenancy. 
        /// <para>
        /// The allowed tenancy of instances launched into the VPC.
        /// </para>
        /// </summary>
        public Tenancy InstanceTenancy
        {
            get { return this._instanceTenancy; }
            set { this._instanceTenancy = value; }
        }

        // Check to see if InstanceTenancy property is set
        internal bool IsSetInstanceTenancy()
        {
            return this._instanceTenancy != null;
        }

        /// <summary>
        /// Gets and sets the property Ipv6CidrBlockAssociationSet. 
        /// <para>
        /// Information about the IPv6 CIDR blocks associated with the VPC.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VpcIpv6CidrBlockAssociation> Ipv6CidrBlockAssociationSet
        {
            get { return this._ipv6CidrBlockAssociationSet; }
            set { this._ipv6CidrBlockAssociationSet = value; }
        }

        // Check to see if Ipv6CidrBlockAssociationSet property is set
        internal bool IsSetIpv6CidrBlockAssociationSet()
        {
            return this._ipv6CidrBlockAssociationSet != null && (this._ipv6CidrBlockAssociationSet.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IsDefault. 
        /// <para>
        /// Indicates whether the VPC is the default VPC.
        /// </para>
        /// </summary>
        public bool? IsDefault
        {
            get { return this._isDefault; }
            set { this._isDefault = value; }
        }

        // Check to see if IsDefault property is set
        internal bool IsSetIsDefault()
        {
            return this._isDefault.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the VPC.
        /// </para>
        /// </summary>
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the VPC.
        /// </para>
        /// </summary>
        public VpcState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags assigned to the VPC.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC.
        /// </para>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}