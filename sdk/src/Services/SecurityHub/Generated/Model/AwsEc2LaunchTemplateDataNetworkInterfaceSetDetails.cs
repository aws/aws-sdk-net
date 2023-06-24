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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// One or more network interfaces to attach to an Amazon EC2 instance. If you specify
    /// a network interface, you must specify security groups and subnets as part of the network
    /// interface.
    /// </summary>
    public partial class AwsEc2LaunchTemplateDataNetworkInterfaceSetDetails
    {
        private bool? _associateCarrierIpAddress;
        private bool? _associatePublicIpAddress;
        private bool? _deleteOnTermination;
        private string _description;
        private int? _deviceIndex;
        private List<string> _groups = new List<string>();
        private string _interfaceType;
        private int? _ipv4PrefixCount;
        private List<AwsEc2LaunchTemplateDataNetworkInterfaceSetIpv4PrefixesDetails> _ipv4Prefixes = new List<AwsEc2LaunchTemplateDataNetworkInterfaceSetIpv4PrefixesDetails>();
        private int? _ipv6AddressCount;
        private List<AwsEc2LaunchTemplateDataNetworkInterfaceSetIpv6AddressesDetails> _ipv6Addresses = new List<AwsEc2LaunchTemplateDataNetworkInterfaceSetIpv6AddressesDetails>();
        private int? _ipv6PrefixCount;
        private List<AwsEc2LaunchTemplateDataNetworkInterfaceSetIpv6PrefixesDetails> _ipv6Prefixes = new List<AwsEc2LaunchTemplateDataNetworkInterfaceSetIpv6PrefixesDetails>();
        private int? _networkCardIndex;
        private string _networkInterfaceId;
        private string _privateIpAddress;
        private List<AwsEc2LaunchTemplateDataNetworkInterfaceSetPrivateIpAddressesDetails> _privateIpAddresses = new List<AwsEc2LaunchTemplateDataNetworkInterfaceSetPrivateIpAddressesDetails>();
        private int? _secondaryPrivateIpAddressCount;
        private string _subnetId;

        /// <summary>
        /// Gets and sets the property AssociateCarrierIpAddress. 
        /// <para>
        ///  Indicates whether to associate a Carrier IP address with eth0 for a new network interface.
        /// You use this option when you launch an instance in a Wavelength Zone and want to associate
        /// a Carrier IP address with the network interface. For more information, see <a href="https://docs.aws.amazon.com/wavelength/latest/developerguide/how-wavelengths-work.html#provider-owned-ip">Carrier
        /// IP address</a> in the <i>Wavelength Developer Guide</i>. 
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
        ///  Associates a public IPv4 address with eth0 for a new network interface. 
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
        ///  Indicates whether the network interface is deleted when the instance is terminated.
        /// 
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
        ///  A description for the network interface. 
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
        ///  The device index for the network interface attachment. 
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
        ///  The IDs of one or more security groups. 
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
        ///  The type of network interface. 
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
        /// Gets and sets the property Ipv4PrefixCount. 
        /// <para>
        ///  The number of IPv4 prefixes to be automatically assigned to the network interface.
        /// You cannot use this option if you use the <code>Ipv4Prefixes</code> option. 
        /// </para>
        /// </summary>
        public int Ipv4PrefixCount
        {
            get { return this._ipv4PrefixCount.GetValueOrDefault(); }
            set { this._ipv4PrefixCount = value; }
        }

        // Check to see if Ipv4PrefixCount property is set
        internal bool IsSetIpv4PrefixCount()
        {
            return this._ipv4PrefixCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ipv4Prefixes. 
        /// <para>
        ///  One or more IPv4 prefixes to be assigned to the network interface. You cannot use
        /// this option if you use the <code>Ipv4PrefixCount</code> option. 
        /// </para>
        /// </summary>
        public List<AwsEc2LaunchTemplateDataNetworkInterfaceSetIpv4PrefixesDetails> Ipv4Prefixes
        {
            get { return this._ipv4Prefixes; }
            set { this._ipv4Prefixes = value; }
        }

        // Check to see if Ipv4Prefixes property is set
        internal bool IsSetIpv4Prefixes()
        {
            return this._ipv4Prefixes != null && this._ipv4Prefixes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Ipv6AddressCount. 
        /// <para>
        ///  The number of IPv6 addresses to assign to a network interface. Amazon EC2 automatically
        /// selects the IPv6 addresses from the subnet range. You can't use this option if you
        /// use <code>Ipv6Addresses</code>. 
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
        ///  One or more specific IPv6 addresses from the IPv6 CIDR block range of your subnet.
        /// You can't use this option if you use <code>Ipv6AddressCount</code>. 
        /// </para>
        /// </summary>
        public List<AwsEc2LaunchTemplateDataNetworkInterfaceSetIpv6AddressesDetails> Ipv6Addresses
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
        /// Gets and sets the property Ipv6PrefixCount. 
        /// <para>
        ///  The number of IPv6 prefixes to be automatically assigned to the network interface.
        /// You cannot use this option if you use the <code>Ipv6Prefix</code> option. 
        /// </para>
        /// </summary>
        public int Ipv6PrefixCount
        {
            get { return this._ipv6PrefixCount.GetValueOrDefault(); }
            set { this._ipv6PrefixCount = value; }
        }

        // Check to see if Ipv6PrefixCount property is set
        internal bool IsSetIpv6PrefixCount()
        {
            return this._ipv6PrefixCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ipv6Prefixes. 
        /// <para>
        ///  One or more IPv6 prefixes to be assigned to the network interface. You cannot use
        /// this option if you use the <code>Ipv6PrefixCount</code> option. 
        /// </para>
        /// </summary>
        public List<AwsEc2LaunchTemplateDataNetworkInterfaceSetIpv6PrefixesDetails> Ipv6Prefixes
        {
            get { return this._ipv6Prefixes; }
            set { this._ipv6Prefixes = value; }
        }

        // Check to see if Ipv6Prefixes property is set
        internal bool IsSetIpv6Prefixes()
        {
            return this._ipv6Prefixes != null && this._ipv6Prefixes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NetworkCardIndex. 
        /// <para>
        ///  The index of the network card. Some instance types support multiple network cards.
        /// The primary network interface must be assigned to network card index <code>0</code>.
        /// The default is network card index <code>0</code>. 
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
        ///  The ID of the network interface. 
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
        ///  The primary private IPv4 address of the network interface. 
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
        ///  One or more private IPv4 addresses. 
        /// </para>
        /// </summary>
        public List<AwsEc2LaunchTemplateDataNetworkInterfaceSetPrivateIpAddressesDetails> PrivateIpAddresses
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
        ///  The number of secondary private IPv4 addresses to assign to a network interface.
        /// 
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
        ///  The ID of the subnet for the network interface. 
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