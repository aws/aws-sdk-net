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
    /// Contains information about a subnet in Amazon EC2.
    /// </summary>
    public partial class AwsEc2SubnetDetails
    {
        private bool? _assignIpv6AddressOnCreation;
        private string _availabilityZone;
        private string _availabilityZoneId;
        private int? _availableIpAddressCount;
        private string _cidrBlock;
        private bool? _defaultForAz;
        private List<Ipv6CidrBlockAssociation> _ipv6CidrBlockAssociationSet = AWSConfigs.InitializeCollections ? new List<Ipv6CidrBlockAssociation>() : null;
        private bool? _mapPublicIpOnLaunch;
        private string _ownerId;
        private string _state;
        private string _subnetArn;
        private string _subnetId;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property AssignIpv6AddressOnCreation. 
        /// <para>
        /// Whether to assign an IPV6 address to a network interface that is created in this subnet.
        /// </para>
        /// </summary>
        public bool? AssignIpv6AddressOnCreation
        {
            get { return this._assignIpv6AddressOnCreation; }
            set { this._assignIpv6AddressOnCreation = value; }
        }

        // Check to see if AssignIpv6AddressOnCreation property is set
        internal bool IsSetAssignIpv6AddressOnCreation()
        {
            return this._assignIpv6AddressOnCreation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone for the subnet.
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The identifier of the Availability Zone for the subnet.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId
        {
            get { return this._availabilityZoneId; }
            set { this._availabilityZoneId = value; }
        }

        // Check to see if AvailabilityZoneId property is set
        internal bool IsSetAvailabilityZoneId()
        {
            return this._availabilityZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property AvailableIpAddressCount. 
        /// <para>
        /// The number of available IPV4 addresses in the subnet. Does not include addresses for
        /// stopped instances.
        /// </para>
        /// </summary>
        public int? AvailableIpAddressCount
        {
            get { return this._availableIpAddressCount; }
            set { this._availableIpAddressCount = value; }
        }

        // Check to see if AvailableIpAddressCount property is set
        internal bool IsSetAvailableIpAddressCount()
        {
            return this._availableIpAddressCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CidrBlock. 
        /// <para>
        /// The IPV4 CIDR block that is assigned to the subnet.
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
        /// Gets and sets the property DefaultForAz. 
        /// <para>
        /// Whether this subnet is the default subnet for the Availability Zone.
        /// </para>
        /// </summary>
        public bool? DefaultForAz
        {
            get { return this._defaultForAz; }
            set { this._defaultForAz = value; }
        }

        // Check to see if DefaultForAz property is set
        internal bool IsSetDefaultForAz()
        {
            return this._defaultForAz.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ipv6CidrBlockAssociationSet. 
        /// <para>
        /// The IPV6 CIDR blocks that are associated with the subnet.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Ipv6CidrBlockAssociation> Ipv6CidrBlockAssociationSet
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
        /// Gets and sets the property MapPublicIpOnLaunch. 
        /// <para>
        /// Whether instances in this subnet receive a public IP address.
        /// </para>
        /// </summary>
        public bool? MapPublicIpOnLaunch
        {
            get { return this._mapPublicIpOnLaunch; }
            set { this._mapPublicIpOnLaunch = value; }
        }

        // Check to see if MapPublicIpOnLaunch property is set
        internal bool IsSetMapPublicIpOnLaunch()
        {
            return this._mapPublicIpOnLaunch.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The identifier of the Amazon Web Services account that owns the subnet.
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
        /// The current state of the subnet. Valid values are <c>available</c> or <c>pending</c>.
        /// </para>
        /// </summary>
        public string State
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
        /// Gets and sets the property SubnetArn. 
        /// <para>
        /// The ARN of the subnet.
        /// </para>
        /// </summary>
        public string SubnetArn
        {
            get { return this._subnetArn; }
            set { this._subnetArn = value; }
        }

        // Check to see if SubnetArn property is set
        internal bool IsSetSubnetArn()
        {
            return this._subnetArn != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The identifier of the subnet.
        /// </para>
        /// </summary>
        public string SubnetId
        {
            get { return this._subnetId; }
            set { this._subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this._subnetId != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The identifier of the VPC that contains the subnet.
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