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
    /// <summary>Instance Network Interface Specification
    /// </summary>
    public class InstanceNetworkInterfaceSpecification
    {
        
        private string networkInterfaceId;
        private int? deviceIndex;
        private string subnetId;
        private string description;
        private string privateIpAddress;
        private List<string> groups = new List<string>();
        private bool? deleteOnTermination;
        private List<PrivateIpAddressSpecification> privateIpAddresses = new List<PrivateIpAddressSpecification>();
        private int? secondaryPrivateIpAddressCount;
        private bool? associatePublicIpAddress;


        /// <summary>
        /// An existing interface to attach to a single instance. Requires n=1 instances.
        ///  
        /// </summary>
        public string NetworkInterfaceId
        {
            get { return this.networkInterfaceId; }
            set { this.networkInterfaceId = value; }
        }

        // Check to see if NetworkInterfaceId property is set
        internal bool IsSetNetworkInterfaceId()
        {
            return this.networkInterfaceId != null;
        }

        /// <summary>
        /// The device index. Applies to both attaching an existing network interface and when creating a network interface. Condition: If you are
        /// specifying a network interface in the request, you must provide the device index.
        ///  
        /// </summary>
        public int DeviceIndex
        {
            get { return this.deviceIndex ?? default(int); }
            set { this.deviceIndex = value; }
        }

        // Check to see if DeviceIndex property is set
        internal bool IsSetDeviceIndex()
        {
            return this.deviceIndex.HasValue;
        }

        /// <summary>
        /// The subnet ID. Applies only when creating a network interface.
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
        /// A description. Applies only when creating a network interface.
        ///  
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }

        /// <summary>
        /// The primary private IP address. Applies only when creating a network interface. Requires n=1 network interfaces in launch.
        ///  
        /// </summary>
        public string PrivateIpAddress
        {
            get { return this.privateIpAddress; }
            set { this.privateIpAddress = value; }
        }

        // Check to see if PrivateIpAddress property is set
        internal bool IsSetPrivateIpAddress()
        {
            return this.privateIpAddress != null;
        }
        public List<string> Groups
        {
            get { return this.groups; }
            set { this.groups = value; }
        }

        // Check to see if Groups property is set
        internal bool IsSetGroups()
        {
            return this.groups.Count > 0;
        }
        public bool DeleteOnTermination
        {
            get { return this.deleteOnTermination ?? default(bool); }
            set { this.deleteOnTermination = value; }
        }

        // Check to see if DeleteOnTermination property is set
        internal bool IsSetDeleteOnTermination()
        {
            return this.deleteOnTermination.HasValue;
        }
        public List<PrivateIpAddressSpecification> PrivateIpAddresses
        {
            get { return this.privateIpAddresses; }
            set { this.privateIpAddresses = value; }
        }

        // Check to see if PrivateIpAddresses property is set
        internal bool IsSetPrivateIpAddresses()
        {
            return this.privateIpAddresses.Count > 0;
        }
        public int SecondaryPrivateIpAddressCount
        {
            get { return this.secondaryPrivateIpAddressCount ?? default(int); }
            set { this.secondaryPrivateIpAddressCount = value; }
        }

        // Check to see if SecondaryPrivateIpAddressCount property is set
        internal bool IsSetSecondaryPrivateIpAddressCount()
        {
            return this.secondaryPrivateIpAddressCount.HasValue;
        }

        /// <summary>
        /// Indicates whether to assign a public IP address to an instance in a VPC. The public IP address is associated with a specific network
        /// interface. If set to <c>true</c>, the following rules apply: <ol> <li> Can only be associated with a single network interface with the
        /// device index of 0. You can't associate a public IP address with a second network interface, and you can't associate a public IP address if
        /// you are launching more than one network interface. </li> <li> Can only be associated with a new network interface, not an existing one.
        /// </li> </ol> Default: If launching into a default subnet, the default value is <c>true</c>. If launching into a nondefault subnet, the
        /// default value is <c>false</c>.
        ///  
        /// </summary>
        public bool AssociatePublicIpAddress
        {
            get { return this.associatePublicIpAddress ?? default(bool); }
            set { this.associatePublicIpAddress = value; }
        }

        // Check to see if AssociatePublicIpAddress property is set
        internal bool IsSetAssociatePublicIpAddress()
        {
            return this.associatePublicIpAddress.HasValue;
        }
    }
}
