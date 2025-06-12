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
    /// Describes a network interface.
    /// </summary>
    public partial class InstanceNetworkInterfaceSpecification
    {
        private bool? _associateCarrierIpAddress;
        private bool? _associatePublicIpAddress;
        private ConnectionTrackingSpecificationRequest _connectionTrackingSpecification;
        private bool? _deleteOnTermination;
        private string _description;
        private int? _deviceIndex;
        private int? _enaQueueCount;
        private EnaSrdSpecificationRequest _enaSrdSpecification;
        private List<string> _groups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _interfaceType;
        private int? _ipv4PrefixCount;
        private List<Ipv4PrefixSpecificationRequest> _ipv4Prefixes = AWSConfigs.InitializeCollections ? new List<Ipv4PrefixSpecificationRequest>() : null;
        private int? _ipv6AddressCount;
        private List<InstanceIpv6Address> _ipv6Addresses = AWSConfigs.InitializeCollections ? new List<InstanceIpv6Address>() : null;
        private int? _ipv6PrefixCount;
        private List<Ipv6PrefixSpecificationRequest> _ipv6Prefixes = AWSConfigs.InitializeCollections ? new List<Ipv6PrefixSpecificationRequest>() : null;
        private int? _networkCardIndex;
        private string _networkInterfaceId;
        private bool? _primaryIpv6;
        private string _privateIpAddress;
        private List<PrivateIpAddressSpecification> _privateIpAddresses = AWSConfigs.InitializeCollections ? new List<PrivateIpAddressSpecification>() : null;
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
        /// in a Wavelength Zone. For more information about carrier IP addresses, see <a href="https://docs.aws.amazon.com/wavelength/latest/developerguide/how-wavelengths-work.html#provider-owned-ip">Carrier
        /// IP address</a> in the <i>Amazon Web Services Wavelength Developer Guide</i>.
        /// </para>
        /// </summary>
        public bool? AssociateCarrierIpAddress
        {
            get { return this._associateCarrierIpAddress; }
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
        /// the default value is <c>true</c>.
        /// </para>
        ///  
        /// <para>
        /// Amazon Web Services charges for all public IPv4 addresses, including public IPv4 addresses
        /// associated with running instances and Elastic IP addresses. For more information,
        /// see the <i>Public IPv4 Address</i> tab on the <a href="http://aws.amazon.com/vpc/pricing/">Amazon
        /// VPC pricing page</a>.
        /// </para>
        /// </summary>
        public bool? AssociatePublicIpAddress
        {
            get { return this._associatePublicIpAddress; }
            set { this._associatePublicIpAddress = value; }
        }

        // Check to see if AssociatePublicIpAddress property is set
        internal bool IsSetAssociatePublicIpAddress()
        {
            return this._associatePublicIpAddress.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConnectionTrackingSpecification. 
        /// <para>
        /// A security group connection tracking specification that enables you to set the timeout
        /// for connection tracking on an Elastic network interface. For more information, see
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/security-group-connection-tracking.html#connection-tracking-timeouts">Connection
        /// tracking timeouts</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public ConnectionTrackingSpecificationRequest ConnectionTrackingSpecification
        {
            get { return this._connectionTrackingSpecification; }
            set { this._connectionTrackingSpecification = value; }
        }

        // Check to see if ConnectionTrackingSpecification property is set
        internal bool IsSetConnectionTrackingSpecification()
        {
            return this._connectionTrackingSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property DeleteOnTermination. 
        /// <para>
        /// If set to <c>true</c>, the interface is deleted when the instance is terminated. You
        /// can specify <c>true</c> only if creating a new network interface when launching an
        /// instance.
        /// </para>
        /// </summary>
        public bool? DeleteOnTermination
        {
            get { return this._deleteOnTermination; }
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
        public int? DeviceIndex
        {
            get { return this._deviceIndex; }
            set { this._deviceIndex = value; }
        }

        // Check to see if DeviceIndex property is set
        internal bool IsSetDeviceIndex()
        {
            return this._deviceIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnaQueueCount. 
        /// <para>
        /// The number of ENA queues to be created with the instance.
        /// </para>
        /// </summary>
        public int? EnaQueueCount
        {
            get { return this._enaQueueCount; }
            set { this._enaQueueCount = value; }
        }

        // Check to see if EnaQueueCount property is set
        internal bool IsSetEnaQueueCount()
        {
            return this._enaQueueCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnaSrdSpecification. 
        /// <para>
        /// Specifies the ENA Express settings for the network interface that's attached to the
        /// instance.
        /// </para>
        /// </summary>
        public EnaSrdSpecificationRequest EnaSrdSpecification
        {
            get { return this._enaSrdSpecification; }
            set { this._enaSrdSpecification = value; }
        }

        // Check to see if EnaSrdSpecification property is set
        internal bool IsSetEnaSrdSpecification()
        {
            return this._enaSrdSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property Groups. 
        /// <para>
        /// The IDs of the security groups for the network interface. Applies only if creating
        /// a network interface when launching an instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Groups
        {
            get { return this._groups; }
            set { this._groups = value; }
        }

        // Check to see if Groups property is set
        internal bool IsSetGroups()
        {
            return this._groups != null && (this._groups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InterfaceType. 
        /// <para>
        /// The type of network interface.
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>efa-only</c>, do not assign any IP addresses to the network interface.
        /// EFA-only network interfaces do not support IP addresses.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>interface</c> | <c>efa</c> | <c>efa-only</c> 
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
        /// The number of IPv4 delegated prefixes to be automatically assigned to the network
        /// interface. You cannot use this option if you use the <c>Ipv4Prefix</c> option.
        /// </para>
        /// </summary>
        public int? Ipv4PrefixCount
        {
            get { return this._ipv4PrefixCount; }
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
        /// The IPv4 delegated prefixes to be assigned to the network interface. You cannot use
        /// this option if you use the <c>Ipv4PrefixCount</c> option.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Ipv4PrefixSpecificationRequest> Ipv4Prefixes
        {
            get { return this._ipv4Prefixes; }
            set { this._ipv4Prefixes = value; }
        }

        // Check to see if Ipv4Prefixes property is set
        internal bool IsSetIpv4Prefixes()
        {
            return this._ipv4Prefixes != null && (this._ipv4Prefixes.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        public int? Ipv6AddressCount
        {
            get { return this._ipv6AddressCount; }
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
        /// The IPv6 addresses to assign to the network interface. You cannot specify this option
        /// and the option to assign a number of IPv6 addresses in the same request. You cannot
        /// specify this option if you've specified a minimum number of instances to launch.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceIpv6Address> Ipv6Addresses
        {
            get { return this._ipv6Addresses; }
            set { this._ipv6Addresses = value; }
        }

        // Check to see if Ipv6Addresses property is set
        internal bool IsSetIpv6Addresses()
        {
            return this._ipv6Addresses != null && (this._ipv6Addresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Ipv6PrefixCount. 
        /// <para>
        /// The number of IPv6 delegated prefixes to be automatically assigned to the network
        /// interface. You cannot use this option if you use the <c>Ipv6Prefix</c> option.
        /// </para>
        /// </summary>
        public int? Ipv6PrefixCount
        {
            get { return this._ipv6PrefixCount; }
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
        /// The IPv6 delegated prefixes to be assigned to the network interface. You cannot use
        /// this option if you use the <c>Ipv6PrefixCount</c> option.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Ipv6PrefixSpecificationRequest> Ipv6Prefixes
        {
            get { return this._ipv6Prefixes; }
            set { this._ipv6Prefixes = value; }
        }

        // Check to see if Ipv6Prefixes property is set
        internal bool IsSetIpv6Prefixes()
        {
            return this._ipv6Prefixes != null && (this._ipv6Prefixes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NetworkCardIndex. 
        /// <para>
        /// The index of the network card. Some instance types support multiple network cards.
        /// The primary network interface must be assigned to network card index 0. The default
        /// is network card index 0.
        /// </para>
        ///  
        /// <para>
        /// If you are using <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_RequestSpotInstances.html">RequestSpotInstances</a>
        /// to create Spot Instances, omit this parameter because you can’t specify the network
        /// card index when using this API. To specify the network card index, use <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_RunInstances.html">RunInstances</a>.
        /// </para>
        /// </summary>
        public int? NetworkCardIndex
        {
            get { return this._networkCardIndex; }
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
        /// Gets and sets the property PrimaryIpv6. 
        /// <para>
        /// The primary IPv6 address of the network interface. When you enable an IPv6 GUA address
        /// to be a primary IPv6, the first IPv6 GUA will be made the primary IPv6 address until
        /// the instance is terminated or the network interface is detached. For more information
        /// about primary IPv6 addresses, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_RunInstances.html">RunInstances</a>.
        /// </para>
        /// </summary>
        public bool? PrimaryIpv6
        {
            get { return this._primaryIpv6; }
            set { this._primaryIpv6 = value; }
        }

        // Check to see if PrimaryIpv6 property is set
        internal bool IsSetPrimaryIpv6()
        {
            return this._primaryIpv6.HasValue; 
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
        /// The private IPv4 addresses to assign to the network interface. Only one private IPv4
        /// address can be designated as primary. You cannot specify this option if you're launching
        /// more than one instance in a <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_RunInstances.html">RunInstances</a>
        /// request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PrivateIpAddressSpecification> PrivateIpAddresses
        {
            get { return this._privateIpAddresses; }
            set { this._privateIpAddresses = value; }
        }

        // Check to see if PrivateIpAddresses property is set
        internal bool IsSetPrivateIpAddresses()
        {
            return this._privateIpAddresses != null && (this._privateIpAddresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SecondaryPrivateIpAddressCount. 
        /// <para>
        /// The number of secondary private IPv4 addresses. You can’t specify this parameter and
        /// also specify a secondary private IP address using the <c>PrivateIpAddress</c> parameter.
        /// </para>
        /// </summary>
        public int? SecondaryPrivateIpAddressCount
        {
            get { return this._secondaryPrivateIpAddressCount; }
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