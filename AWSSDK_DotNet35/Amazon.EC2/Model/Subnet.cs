/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a subnet.
    /// </summary>
    public partial class Subnet
    {
        private string _availabilityZone;
        private int? _availableIpAddressCount;
        private string _cidrBlock;
        private bool? _defaultForAz;
        private bool? _mapPublicIpOnLaunch;
        private SubnetState _state;
        private string _subnetId;
        private List<Tag> _tags = new List<Tag>();
        private string _vpcId;

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
        /// Gets and sets the property AvailableIpAddressCount. 
        /// <para>
        /// The number of unused IP addresses in the subnet. Note that the IP addresses for any
        /// stopped instances are considered unavailable.
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
        /// The CIDR block assigned to the subnet.
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
        /// Gets and sets the property MapPublicIpOnLaunch. 
        /// <para>
        /// Indicates whether instances launched in this subnet receive a public IP address.
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