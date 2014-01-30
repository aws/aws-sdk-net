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
    /// <para>Describes a network interface.</para>
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
        /// The ID of the network interface.
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
        /// The index of the device on the instance for the network interface attachment.
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
        /// The ID of the subnet associated with the network string.
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
        /// The description of the network interface.
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
        /// The private IP address of the network interface.
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

        /// <summary>
        /// The IDs of the security groups for the network interface.
        ///  
        /// </summary>
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

        /// <summary>
        /// If set to <c>true</c>, the interface is deleted when the instance is terminated.
        ///  
        /// </summary>
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

        /// <summary>
        /// One or more private IP addresses to assign to the network interface.
        ///  
        /// </summary>
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

        /// <summary>
        /// The number of secondary private IP addresses.
        ///  
        /// </summary>
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
        /// Indicates whether to auto-assign a public IP address to an instance in a VPC. This public IP address can be assigned to the network
        /// interface for eth0 only when you launch the instance. You must create the network interface instead of using an existing network interface
        /// for eth0, and you must not specify more than one network interface.
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
