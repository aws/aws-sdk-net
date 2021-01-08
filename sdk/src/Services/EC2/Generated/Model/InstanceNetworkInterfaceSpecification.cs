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
    /// Describes a network interface.
    /// </summary>
    public partial class InstanceNetworkInterfaceSpecification
    {
        private bool? _associateCarrierIpAddress;
        private bool? _associatePublicIpAddress;
        private bool? _deleteOnTermination;
        private string _description;
        private int? _deviceIndex;
        private List<string> _groups = new List<string>();
        private string _interfaceType;
        private int? _ipv6AddressCount;
        private List<InstanceIpv6Address> _ipv6Addresses = new List<InstanceIpv6Address>();
        private int? _networkCardIndex;
        private string _networkInterfaceId;
        private string _privateIpAddress;
        private List<PrivateIpAddressSpecification> _privateIpAddresses = new List<PrivateIpAddressSpecification>();
        private int? _secondaryPrivateIpAddressCount;
        private string _subnetId;

        /// <summary>
        /// Gets and sets the property AssociateCarrierIpAddress. 
        /// <para>
        /// Indicates whether to assign a carrier IP address to the network interface.
        /// </para>
        ///  
        /// <para>
        /// You can only assign a carrier IP address to a network interface that is in a subnet
        /// in a Wavelength Zone. For more information about carrier IP addresses, see Carrier
        /// IP addresses in the AWS Wavelength Developer Guide.
        /// </para>
        /// </summary>
        public bool AssociateCarrierIpAddress
        {
            get { return this._associateCarrierIpAddress.GetValueOrDefault(); }
            set { this._associateCarrierIpAddress = value; }
        }

        // Check to see if AssociateCarrierIpAddress property is set
        internal bool IsSetAssociateCarrierIpAddress()
        {
            return this._associateCarrierIpAddress.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AssociatePublicIpAddress. 
        /// <para>
        /// Indicates whether to assign a public IPv4 address to an instance you launch in a VPC.
        /// The public IP address can only be assigned to a network interface for eth0, and can
        /// only be assigned to a new network interface, not an existing one. You cannot specify
        /// more than one network interface in the request. If launching into a default subnet,
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
        /// The position of the network interface in the attachment order. A primary network interface
        /// has a device index of 0.
        /// </para>
        ///  
        /// <para>
        /// If you specify a network interface when launching an instance, you must specify the
        /// device index.
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
        /// Gets and sets the property InterfaceType. 
        /// <para>
        /// The type of network interface.
        /// </para>
        ///  
        /// <para>
        /// To create an Elastic Fabric Adapter (EFA), specify <code>efa</code>. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/efa.html">Elastic
        /// Fabric Adapter</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you are not creating an EFA, specify <code>interface</code> or omit this parameter.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>interface</code> | <code>efa</code> 
        /// </para>
        /// </summary>
        public string InterfaceType
        {
            get { return this._interfaceType; }
            set { this._interfaceType = value; }
        }

        // Check to see if InterfaceType property is set
        internal bool IsSetInterfaceType()
        {
            return this._interfaceType != null;
        }

        /// <summary>
        /// Gets and sets the property Ipv6AddressCount. 
        /// <para>
        /// A number of IPv6 addresses to assign to the network interface. Amazon EC2 chooses
        /// the IPv6 addresses from the range of the subnet. You cannot specify this option and
        /// the option to assign specific IPv6 addresses in the same request. You can specify
        /// this option if you've specified a minimum number of instances to launch.
        /// </para>
        /// </summary>
        public int Ipv6AddressCount
        {
            get { return this._ipv6AddressCount.GetValueOrDefault(); }
            set { this._ipv6AddressCount = value; }
        }

        // Check to see if Ipv6AddressCount property is set
        internal bool IsSetIpv6AddressCount()
        {
            return this._ipv6AddressCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ipv6Addresses. 
        /// <para>
        /// One or more IPv6 addresses to assign to the network interface. You cannot specify
        /// this option and the option to assign a number of IPv6 addresses in the same request.
        /// You cannot specify this option if you've specified a minimum number of instances to
        /// launch.
        /// </para>
        /// </summary>
        public List<InstanceIpv6Address> Ipv6Addresses
        {
            get { return this._ipv6Addresses; }
            set { this._ipv6Addresses = value; }
        }

        // Check to see if Ipv6Addresses property is set
        internal bool IsSetIpv6Addresses()
        {
            return this._ipv6Addresses != null && this._ipv6Addresses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NetworkCardIndex. 
        /// <para>
        /// The index of the network card. Some instance types support multiple network cards.
        /// The primary network interface must be assigned to network card index 0. The default
        /// is network card index 0.
        /// </para>
        /// </summary>
        public int NetworkCardIndex
        {
            get { return this._networkCardIndex.GetValueOrDefault(); }
            set { this._networkCardIndex = value; }
        }

        // Check to see if NetworkCardIndex property is set
        internal bool IsSetNetworkCardIndex()
        {
            return this._networkCardIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        /// The ID of the network interface.
        /// </para>
        ///  
        /// <para>
        /// If you are creating a Spot Fleet, omit this parameter because you can’t specify a
        /// network interface ID in a launch specification.
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
        /// The private IPv4 address of the network interface. Applies only if creating a network
        /// interface when launching an instance. You cannot specify this option if you're launching
        /// more than one instance in a <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_RunInstances.html">RunInstances</a>
        /// request.
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
        /// One or more private IPv4 addresses to assign to the network interface. Only one private
        /// IPv4 address can be designated as primary. You cannot specify this option if you're
        /// launching more than one instance in a <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_RunInstances.html">RunInstances</a>
        /// request.
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
        /// The number of secondary private IPv4 addresses. You can't specify this option and
        /// specify more than one private IP address using the private IP addresses option. You
        /// cannot specify this option if you're launching more than one instance in a <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_RunInstances.html">RunInstances</a>
        /// request.
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
        /// The ID of the subnet associated with the network interface. Applies only if creating
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