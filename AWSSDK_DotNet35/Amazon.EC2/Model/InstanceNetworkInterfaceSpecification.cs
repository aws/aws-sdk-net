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
    /// Describes a network interface.
    /// </summary>
    public partial class InstanceNetworkInterfaceSpecification
    {
        private bool? _associatePublicIpAddress;
        private bool? _deleteOnTermination;
        private string _description;
        private int? _deviceIndex;
        private List<string> _groups = new List<string>();
        private string _networkInterfaceId;
        private string _privateIpAddress;
        private List<PrivateIpAddressSpecification> _privateIpAddresses = new List<PrivateIpAddressSpecification>();
        private int? _secondaryPrivateIpAddressCount;
        private string _subnetId;

        /// <summary>
        /// Gets and sets the property AssociatePublicIpAddress. 
        /// <para>
        /// Indicates whether to assign a public IP address to an instance you launch in a VPC.
        /// The public IP address can only be assigned to a network interface for eth0, and can
        /// only be assigned to a new network interface, not an existing one. You cannot specify
        /// more than one network interface in the request. If luanching into a default subnet,
        /// the default value is <code>true</code>.
        /// </para>
        /// </summary>
        public bool AssociatePublicIpAddress
        {
            get { return this._associatePublicIpAddress.GetValueOrDefault(); }
            set { this._associatePublicIpAddress = value; }
        }

        // Check to see if AssociatePublicIpAddress property is set
        internal bool IsSetAssociatePublicIpAddress()
        {
            return this._associatePublicIpAddress.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeleteOnTermination. 
        /// <para>
        /// If set to <code>true</code>, the interface is deleted when the instance is terminated.
        /// You can specify <code>true</code> only if creating a new network interface when launching
        /// an instance.
        /// </para>
        /// </summary>
        public bool DeleteOnTermination
        {
            get { return this._deleteOnTermination.GetValueOrDefault(); }
            set { this._deleteOnTermination = value; }
        }

        // Check to see if DeleteOnTermination property is set
        internal bool IsSetDeleteOnTermination()
        {
            return this._deleteOnTermination.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the network interface. Applies only if creating a network interface
        /// when launching an instance.
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
        /// Gets and sets the property DeviceIndex. 
        /// <para>
        /// The index of the device on the instance for the network interface attachment. If you
        /// are specifying a network interface in a <a>RunInstances</a> request, you must provide
        /// the device index.
        /// </para>
        /// </summary>
        public int DeviceIndex
        {
            get { return this._deviceIndex.GetValueOrDefault(); }
            set { this._deviceIndex = value; }
        }

        // Check to see if DeviceIndex property is set
        internal bool IsSetDeviceIndex()
        {
            return this._deviceIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Groups. 
        /// <para>
        /// The IDs of the security groups for the network interface. Applies only if creating
        /// a network interface when launching an instance.
        /// </para>
        /// </summary>
        public List<string> Groups
        {
            get { return this._groups; }
            set { this._groups = value; }
        }

        // Check to see if Groups property is set
        internal bool IsSetGroups()
        {
            return this._groups != null && this._groups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        /// The ID of the network interface.
        /// </para>
        /// </summary>
        public string NetworkInterfaceId
        {
            get { return this._networkInterfaceId; }
            set { this._networkInterfaceId = value; }
        }

        // Check to see if NetworkInterfaceId property is set
        internal bool IsSetNetworkInterfaceId()
        {
            return this._networkInterfaceId != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateIpAddress. 
        /// <para>
        /// The private IP address of the network interface. Applies only if creating a network
        /// interface when launching an instance.
        /// </para>
        /// </summary>
        public string PrivateIpAddress
        {
            get { return this._privateIpAddress; }
            set { this._privateIpAddress = value; }
        }

        // Check to see if PrivateIpAddress property is set
        internal bool IsSetPrivateIpAddress()
        {
            return this._privateIpAddress != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateIpAddresses. 
        /// <para>
        /// One or more private IP addresses to assign to the network interface. Only one private
        /// IP address can be designated as primary.
        /// </para>
        /// </summary>
        public List<PrivateIpAddressSpecification> PrivateIpAddresses
        {
            get { return this._privateIpAddresses; }
            set { this._privateIpAddresses = value; }
        }

        // Check to see if PrivateIpAddresses property is set
        internal bool IsSetPrivateIpAddresses()
        {
            return this._privateIpAddresses != null && this._privateIpAddresses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SecondaryPrivateIpAddressCount. 
        /// <para>
        /// The number of secondary private IP addresses. You can't specify this option and specify
        /// more than one private IP address using the private IP addresses option.
        /// </para>
        /// </summary>
        public int SecondaryPrivateIpAddressCount
        {
            get { return this._secondaryPrivateIpAddressCount.GetValueOrDefault(); }
            set { this._secondaryPrivateIpAddressCount = value; }
        }

        // Check to see if SecondaryPrivateIpAddressCount property is set
        internal bool IsSetSecondaryPrivateIpAddressCount()
        {
            return this._secondaryPrivateIpAddressCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet associated with the network string. Applies only if creating
        /// a network interface when launching an instance.
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

    }
}