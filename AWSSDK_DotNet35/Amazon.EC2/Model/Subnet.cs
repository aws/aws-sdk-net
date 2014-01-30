/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para>Describes a subnet.</para>
    /// </summary>
    public class Subnet
    {
        
        private string subnetId;
        private SubnetState state;
        private string vpcId;
        private string cidrBlock;
        private int? availableIpAddressCount;
        private string availabilityZone;
        private bool? defaultForAz;
        private bool? mapPublicIpOnLaunch;
        private List<Tag> tags = new List<Tag>();


        /// <summary>
        /// The ID of the subnet.
        ///  
        /// </summary>
        public string SubnetId
        {
            get { return this.subnetId; }
            set { this.subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this.subnetId != null;
        }

        /// <summary>
        /// The current state of the subnet.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>pending, available</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public SubnetState State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this.state != null;
        }

        /// <summary>
        /// The ID of the VPC the subnet is in.
        ///  
        /// </summary>
        public string VpcId
        {
            get { return this.vpcId; }
            set { this.vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this.vpcId != null;
        }

        /// <summary>
        /// The CIDR block assigned to the subnet.
        ///  
        /// </summary>
        public string CidrBlock
        {
            get { return this.cidrBlock; }
            set { this.cidrBlock = value; }
        }

        // Check to see if CidrBlock property is set
        internal bool IsSetCidrBlock()
        {
            return this.cidrBlock != null;
        }

        /// <summary>
        /// The number of unused IP addresses in the subnet. Note that the IP addresses for any stopped instances are considered unavailable.
        ///  
        /// </summary>
        public int AvailableIpAddressCount
        {
            get { return this.availableIpAddressCount ?? default(int); }
            set { this.availableIpAddressCount = value; }
        }

        // Check to see if AvailableIpAddressCount property is set
        internal bool IsSetAvailableIpAddressCount()
        {
            return this.availableIpAddressCount.HasValue;
        }

        /// <summary>
        /// The Availability Zone of the subnet.
        ///  
        /// </summary>
        public string AvailabilityZone
        {
            get { return this.availabilityZone; }
            set { this.availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this.availabilityZone != null;
        }

        /// <summary>
        /// Indicates whether this is the default subnet for the Availability Zone.
        ///  
        /// </summary>
        public bool DefaultForAz
        {
            get { return this.defaultForAz ?? default(bool); }
            set { this.defaultForAz = value; }
        }

        // Check to see if DefaultForAz property is set
        internal bool IsSetDefaultForAz()
        {
            return this.defaultForAz.HasValue;
        }

        /// <summary>
        /// Indicates whether instances launched in this subnet receive a public IP address.
        ///  
        /// </summary>
        public bool MapPublicIpOnLaunch
        {
            get { return this.mapPublicIpOnLaunch ?? default(bool); }
            set { this.mapPublicIpOnLaunch = value; }
        }

        // Check to see if MapPublicIpOnLaunch property is set
        internal bool IsSetMapPublicIpOnLaunch()
        {
            return this.mapPublicIpOnLaunch.HasValue;
        }

        /// <summary>
        /// Any tags assigned to the subnet.
        ///  
        /// </summary>
        public List<Tag> Tags
        {
            get { return this.tags; }
            set { this.tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this.tags.Count > 0;
        }
    }
}
