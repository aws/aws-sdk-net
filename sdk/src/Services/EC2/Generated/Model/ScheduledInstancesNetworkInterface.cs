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
    /// Describes a network interface for a Scheduled Instance.
    /// </summary>
    public partial class ScheduledInstancesNetworkInterface
    {
        private bool? _associatePublicIpAddress;
        private bool? _deleteOnTermination;
        private string _description;
        private int? _deviceIndex;
        private List<string> _groups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _ipv6AddressCount;
        private List<ScheduledInstancesIpv6Address> _ipv6Addresses = AWSConfigs.InitializeCollections ? new List<ScheduledInstancesIpv6Address>() : null;
        private string _networkInterfaceId;
        private string _privateIpAddress;
        private List<ScheduledInstancesPrivateIpAddressConfig> _privateIpAddressConfigs = AWSConfigs.InitializeCollections ? new List<ScheduledInstancesPrivateIpAddressConfig>() : null;
        private int? _secondaryPrivateIpAddressCount;
        private string _subnetId;

        /// <summary>
        /// Gets and sets the property AssociatePublicIpAddress. 
        /// <para>
        /// Indicates whether to assign a public IPv4 address to instances launched in a VPC.
        /// The public IPv4 address can only be assigned to a network interface for eth0, and
        /// can only be assigned to a new network interface, not an existing one. You cannot specify
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
        /// Gets and sets the property DeleteOnTermination. 
        /// <para>
        /// Indicates whether to delete the interface when the instance is terminated.
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
        /// The description.
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
        /// The index of the device for the network interface attachment.
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
        /// Gets and sets the property Groups. 
        /// <para>
        /// The IDs of the security groups.
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
        /// Gets and sets the property Ipv6AddressCount. 
        /// <para>
        /// The number of IPv6 addresses to assign to the network interface. The IPv6 addresses
        /// are automatically selected from the subnet range.
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
        /// The specific IPv6 addresses from the subnet range.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ScheduledInstancesIpv6Address> Ipv6Addresses
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
        /// The IPv4 address of the network interface within the subnet.
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
        /// Gets and sets the property PrivateIpAddressConfigs. 
        /// <para>
        /// The private IPv4 addresses.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ScheduledInstancesPrivateIpAddressConfig> PrivateIpAddressConfigs
        {
            get { return this._privateIpAddressConfigs; }
            set { this._privateIpAddressConfigs = value; }
        }

        // Check to see if PrivateIpAddressConfigs property is set
        internal bool IsSetPrivateIpAddressConfigs()
        {
            return this._privateIpAddressConfigs != null && (this._privateIpAddressConfigs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SecondaryPrivateIpAddressCount. 
        /// <para>
        /// The number of secondary private IPv4 addresses.
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

    }
}