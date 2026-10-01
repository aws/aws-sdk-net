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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// One or more network interfaces to attach to an Amazon EC2 instance. If you specify
    /// a network interface, you must specify security groups and subnets as part of the network
    /// interface.
    /// </summary>
    public partial class AwsEc2LaunchTemplateDataNetworkInterfaceSetDetails
    {
        /// <summary>
        /// Gets and sets the property AssociateCarrierIpAddress. 
        /// <para>
        ///  Indicates whether to associate a Carrier IP address with eth0 for a new network interface.
        /// You use this option when you launch an instance in a Wavelength Zone and want to associate
        /// a Carrier IP address with the network interface. For more information, see <a href="https://docs.aws.amazon.com/wavelength/latest/developerguide/how-wavelengths-work.html#provider-owned-ip">Carrier
        /// IP address</a> in the <i>Wavelength Developer Guide</i>. 
        /// </para>
        /// </summary>
        public bool? AssociateCarrierIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the AssociateCarrierIpAddress property is set.
        /// </summary>
        internal bool IsSetAssociateCarrierIpAddress() => this.AssociateCarrierIpAddress.HasValue;

        /// <summary>
        /// Gets and sets the property AssociatePublicIpAddress. 
        /// <para>
        ///  Associates a public IPv4 address with eth0 for a new network interface. 
        /// </para>
        /// </summary>
        public bool? AssociatePublicIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the AssociatePublicIpAddress property is set.
        /// </summary>
        internal bool IsSetAssociatePublicIpAddress() => this.AssociatePublicIpAddress.HasValue;

        /// <summary>
        /// Gets and sets the property DeleteOnTermination. 
        /// <para>
        ///  Indicates whether the network interface is deleted when the instance is terminated.
        /// 
        /// </para>
        /// </summary>
        public bool? DeleteOnTermination { get; set; }

        /// <summary>
        /// Checks to see if the DeleteOnTermination property is set.
        /// </summary>
        internal bool IsSetDeleteOnTermination() => this.DeleteOnTermination.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A description for the network interface. 
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DeviceIndex. 
        /// <para>
        ///  The device index for the network interface attachment. 
        /// </para>
        /// </summary>
        public int? DeviceIndex { get; set; }

        /// <summary>
        /// Checks to see if the DeviceIndex property is set.
        /// </summary>
        internal bool IsSetDeviceIndex() => this.DeviceIndex.HasValue;

        /// <summary>
        /// Gets and sets the property Groups. 
        /// <para>
        ///  The IDs of one or more security groups. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Groups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Groups property is set.
        /// </summary>
        internal bool IsSetGroups() => this.Groups != null && (this.Groups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InterfaceType. 
        /// <para>
        ///  The type of network interface. 
        /// </para>
        /// </summary>
        public string InterfaceType { get; set; }

        /// <summary>
        /// Checks to see if the InterfaceType property is set.
        /// </summary>
        internal bool IsSetInterfaceType() => this.InterfaceType != null;

        /// <summary>
        /// Gets and sets the property Ipv4PrefixCount. 
        /// <para>
        ///  The number of IPv4 prefixes to be automatically assigned to the network interface.
        /// You cannot use this option if you use the <c>Ipv4Prefixes</c> option. 
        /// </para>
        /// </summary>
        public int? Ipv4PrefixCount { get; set; }

        /// <summary>
        /// Checks to see if the Ipv4PrefixCount property is set.
        /// </summary>
        internal bool IsSetIpv4PrefixCount() => this.Ipv4PrefixCount.HasValue;

        /// <summary>
        /// Gets and sets the property Ipv4Prefixes. 
        /// <para>
        ///  One or more IPv4 prefixes to be assigned to the network interface. You cannot use
        /// this option if you use the <c>Ipv4PrefixCount</c> option. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEc2LaunchTemplateDataNetworkInterfaceSetIpv4PrefixesDetails> Ipv4Prefixes { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEc2LaunchTemplateDataNetworkInterfaceSetIpv4PrefixesDetails>() : null;

        /// <summary>
        /// Checks to see if the Ipv4Prefixes property is set.
        /// </summary>
        internal bool IsSetIpv4Prefixes() => this.Ipv4Prefixes != null && (this.Ipv4Prefixes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Ipv6AddressCount. 
        /// <para>
        ///  The number of IPv6 addresses to assign to a network interface. Amazon EC2 automatically
        /// selects the IPv6 addresses from the subnet range. You can't use this option if you
        /// use <c>Ipv6Addresses</c>. 
        /// </para>
        /// </summary>
        public int? Ipv6AddressCount { get; set; }

        /// <summary>
        /// Checks to see if the Ipv6AddressCount property is set.
        /// </summary>
        internal bool IsSetIpv6AddressCount() => this.Ipv6AddressCount.HasValue;

        /// <summary>
        /// Gets and sets the property Ipv6Addresses. 
        /// <para>
        ///  One or more specific IPv6 addresses from the IPv6 CIDR block range of your subnet.
        /// You can't use this option if you use <c>Ipv6AddressCount</c>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEc2LaunchTemplateDataNetworkInterfaceSetIpv6AddressesDetails> Ipv6Addresses { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEc2LaunchTemplateDataNetworkInterfaceSetIpv6AddressesDetails>() : null;

        /// <summary>
        /// Checks to see if the Ipv6Addresses property is set.
        /// </summary>
        internal bool IsSetIpv6Addresses() => this.Ipv6Addresses != null && (this.Ipv6Addresses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Ipv6PrefixCount. 
        /// <para>
        ///  The number of IPv6 prefixes to be automatically assigned to the network interface.
        /// You cannot use this option if you use the <c>Ipv6Prefix</c> option. 
        /// </para>
        /// </summary>
        public int? Ipv6PrefixCount { get; set; }

        /// <summary>
        /// Checks to see if the Ipv6PrefixCount property is set.
        /// </summary>
        internal bool IsSetIpv6PrefixCount() => this.Ipv6PrefixCount.HasValue;

        /// <summary>
        /// Gets and sets the property Ipv6Prefixes. 
        /// <para>
        ///  One or more IPv6 prefixes to be assigned to the network interface. You cannot use
        /// this option if you use the <c>Ipv6PrefixCount</c> option. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEc2LaunchTemplateDataNetworkInterfaceSetIpv6PrefixesDetails> Ipv6Prefixes { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEc2LaunchTemplateDataNetworkInterfaceSetIpv6PrefixesDetails>() : null;

        /// <summary>
        /// Checks to see if the Ipv6Prefixes property is set.
        /// </summary>
        internal bool IsSetIpv6Prefixes() => this.Ipv6Prefixes != null && (this.Ipv6Prefixes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NetworkCardIndex. 
        /// <para>
        ///  The index of the network card. Some instance types support multiple network cards.
        /// The primary network interface must be assigned to network card index <c>0</c>. The
        /// default is network card index <c>0</c>. 
        /// </para>
        /// </summary>
        public int? NetworkCardIndex { get; set; }

        /// <summary>
        /// Checks to see if the NetworkCardIndex property is set.
        /// </summary>
        internal bool IsSetNetworkCardIndex() => this.NetworkCardIndex.HasValue;

        /// <summary>
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        ///  The ID of the network interface. 
        /// </para>
        /// </summary>
        public string NetworkInterfaceId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInterfaceId property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaceId() => this.NetworkInterfaceId != null;

        /// <summary>
        /// Gets and sets the property PrivateIpAddress. 
        /// <para>
        ///  The primary private IPv4 address of the network interface. 
        /// </para>
        /// </summary>
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the PrivateIpAddress property is set.
        /// </summary>
        internal bool IsSetPrivateIpAddress() => this.PrivateIpAddress != null;

        /// <summary>
        /// Gets and sets the property PrivateIpAddresses. 
        /// <para>
        ///  One or more private IPv4 addresses. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEc2LaunchTemplateDataNetworkInterfaceSetPrivateIpAddressesDetails> PrivateIpAddresses { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEc2LaunchTemplateDataNetworkInterfaceSetPrivateIpAddressesDetails>() : null;

        /// <summary>
        /// Checks to see if the PrivateIpAddresses property is set.
        /// </summary>
        internal bool IsSetPrivateIpAddresses() => this.PrivateIpAddresses != null && (this.PrivateIpAddresses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SecondaryPrivateIpAddressCount. 
        /// <para>
        ///  The number of secondary private IPv4 addresses to assign to a network interface.
        /// 
        /// </para>
        /// </summary>
        public int? SecondaryPrivateIpAddressCount { get; set; }

        /// <summary>
        /// Checks to see if the SecondaryPrivateIpAddressCount property is set.
        /// </summary>
        internal bool IsSetSecondaryPrivateIpAddressCount() => this.SecondaryPrivateIpAddressCount.HasValue;

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        ///  The ID of the subnet for the network interface. 
        /// </para>
        /// </summary>
        public string SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the SubnetId property is set.
        /// </summary>
        internal bool IsSetSubnetId() => this.SubnetId != null;
    }
}
