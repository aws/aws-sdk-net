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
    /// Describes a subnet.
    /// </summary>
    public partial class Subnet
    {
        private bool? _assignIpv6AddressOnCreation;
        private string _availabilityZone;
        private string _availabilityZoneId;
        private int? _availableIpAddressCount;
        private string _cidrBlock;
        private string _customerOwnedIpv4Pool;
        private bool? _defaultForAz;
        private List<SubnetIpv6CidrBlockAssociation> _ipv6CidrBlockAssociationSet = new List<SubnetIpv6CidrBlockAssociation>();
        private bool? _mapCustomerOwnedIpOnLaunch;
        private bool? _mapPublicIpOnLaunch;
        private string _outpostArn;
        private string _ownerId;
        private SubnetState _state;
        private string _subnetArn;
        private string _subnetId;
        private List<Tag> _tags = new List<Tag>();
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property AssignIpv6AddressOnCreation. 
        /// <para>
        /// Indicates whether a network interface created in this subnet (including a network
        /// interface created by <a>RunInstances</a>) receives an IPv6 address.
        /// </para>
        /// </summary>
        public bool AssignIpv6AddressOnCreation
        {
            get { return this._assignIpv6AddressOnCreation.GetValueOrDefault(); }
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
        /// The Availability Zone of the subnet.
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
        /// The AZ ID of the subnet.
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
        /// The number of unused private IPv4 addresses in the subnet. The IPv4 addresses for
        /// any stopped instances are considered unavailable.
        /// </para>
        /// </summary>
        public int AvailableIpAddressCount
        {
            get { return this._availableIpAddressCount.GetValueOrDefault(); }
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
        /// The IPv4 CIDR block assigned to the subnet.
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
        /// Gets and sets the property CustomerOwnedIpv4Pool. 
        /// <para>
        /// The customer-owned IPv4 address pool associated with the subnet.
        /// </para>
        /// </summary>
        public string CustomerOwnedIpv4Pool
        {
            get { return this._customerOwnedIpv4Pool; }
            set { this._customerOwnedIpv4Pool = value; }
        }

        // Check to see if CustomerOwnedIpv4Pool property is set
        internal bool IsSetCustomerOwnedIpv4Pool()
        {
            return this._customerOwnedIpv4Pool != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultForAz. 
        /// <para>
        /// Indicates whether this is the default subnet for the Availability Zone.
        /// </para>
        /// </summary>
        public bool DefaultForAz
        {
            get { return this._defaultForAz.GetValueOrDefault(); }
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
        /// Information about the IPv6 CIDR blocks associated with the subnet.
        /// </para>
        /// </summary>
        public List<SubnetIpv6CidrBlockAssociation> Ipv6CidrBlockAssociationSet
        {
            get { return this._ipv6CidrBlockAssociationSet; }
            set { this._ipv6CidrBlockAssociationSet = value; }
        }

        // Check to see if Ipv6CidrBlockAssociationSet property is set
        internal bool IsSetIpv6CidrBlockAssociationSet()
        {
            return this._ipv6CidrBlockAssociationSet != null && this._ipv6CidrBlockAssociationSet.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MapCustomerOwnedIpOnLaunch. 
        /// <para>
        /// Indicates whether a network interface created in this subnet (including a network
        /// interface created by <a>RunInstances</a>) receives a customer-owned IPv4 address.
        /// </para>
        /// </summary>
        public bool MapCustomerOwnedIpOnLaunch
        {
            get { return this._mapCustomerOwnedIpOnLaunch.GetValueOrDefault(); }
            set { this._mapCustomerOwnedIpOnLaunch = value; }
        }

        // Check to see if MapCustomerOwnedIpOnLaunch property is set
        internal bool IsSetMapCustomerOwnedIpOnLaunch()
        {
            return this._mapCustomerOwnedIpOnLaunch.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MapPublicIpOnLaunch. 
        /// <para>
        /// Indicates whether instances launched in this subnet receive a public IPv4 address.
        /// </para>
        /// </summary>
        public bool MapPublicIpOnLaunch
        {
            get { return this._mapPublicIpOnLaunch.GetValueOrDefault(); }
            set { this._mapPublicIpOnLaunch = value; }
        }

        // Check to see if MapPublicIpOnLaunch property is set
        internal bool IsSetMapPublicIpOnLaunch()
        {
            return this._mapPublicIpOnLaunch.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutpostArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Outpost.
        /// </para>
        /// </summary>
        public string OutpostArn
        {
            get { return this._outpostArn; }
            set { this._outpostArn = value; }
        }

        // Check to see if OutpostArn property is set
        internal bool IsSetOutpostArn()
        {
            return this._outpostArn != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the AWS account that owns the subnet.
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
        /// The current state of the subnet.
        /// </para>
        /// </summary>
        public SubnetState State
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
        /// The Amazon Resource Name (ARN) of the subnet.
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
        /// The ID of the subnet.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags assigned to the subnet.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC the subnet is in.
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