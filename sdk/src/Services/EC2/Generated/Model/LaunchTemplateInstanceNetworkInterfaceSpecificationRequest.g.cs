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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// The parameters for a network interface.
    /// </summary>
    public partial class LaunchTemplateInstanceNetworkInterfaceSpecificationRequest
    {
        /// <summary>
        /// Gets and sets the property AssociateCarrierIpAddress. 
        /// <para>
        /// Associates a Carrier IP address with eth0 for a new network interface.
        /// </para>
        ///  
        /// <para>
        /// Use this option when you launch an instance in a Wavelength Zone and want to associate
        /// a Carrier IP address with the network interface. For more information about Carrier
        /// IP addresses, see <a href="https://docs.aws.amazon.com/wavelength/latest/developerguide/how-wavelengths-work.html#provider-owned-ip">Carrier
        /// IP addresses</a> in the <i>Wavelength Developer Guide</i>.
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
        /// Associates a public IPv4 address with eth0 for a new network interface.
        /// </para>
        ///  
        /// <para>
        /// Amazon Web Services charges for all public IPv4 addresses, including public IPv4 addresses
        /// associated with running instances and Elastic IP addresses. For more information,
        /// see the <i>Public IPv4 Address</i> tab on the <a href="http://aws.amazon.com/vpc/pricing/">Amazon
        /// VPC pricing page</a>.
        /// </para>
        /// </summary>
        public bool? AssociatePublicIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the AssociatePublicIpAddress property is set.
        /// </summary>
        internal bool IsSetAssociatePublicIpAddress() => this.AssociatePublicIpAddress.HasValue;

        /// <summary>
        /// Gets and sets the property ConnectionTrackingSpecification. 
        /// <para>
        /// A security group connection tracking specification that enables you to set the timeout
        /// for connection tracking on an Elastic network interface. For more information, see
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/security-group-connection-tracking.html#connection-tracking-timeouts">Idle
        /// connection tracking timeout</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public ConnectionTrackingSpecificationRequest ConnectionTrackingSpecification { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionTrackingSpecification property is set.
        /// </summary>
        internal bool IsSetConnectionTrackingSpecification() => this.ConnectionTrackingSpecification != null;

        /// <summary>
        /// Gets and sets the property DeleteOnTermination. 
        /// <para>
        /// Indicates whether the network interface is deleted when the instance is terminated.
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
        /// A description for the network interface.
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
        /// The device index for the network interface attachment. The primary network interface
        /// has a device index of 0. Each network interface is of type <c>interface</c>, you must
        /// specify a device index. If you create a launch template that includes secondary network
        /// interfaces but not a primary network interface, then you must add a primary network
        /// interface as a launch parameter when you launch an instance from the template.
        /// </para>
        /// </summary>
        public int? DeviceIndex { get; set; }

        /// <summary>
        /// Checks to see if the DeviceIndex property is set.
        /// </summary>
        internal bool IsSetDeviceIndex() => this.DeviceIndex.HasValue;

        /// <summary>
        /// Gets and sets the property EnaQueueCount. 
        /// <para>
        /// The number of ENA queues to be created with the instance.
        /// </para>
        /// </summary>
        public int? EnaQueueCount { get; set; }

        /// <summary>
        /// Checks to see if the EnaQueueCount property is set.
        /// </summary>
        internal bool IsSetEnaQueueCount() => this.EnaQueueCount.HasValue;

        /// <summary>
        /// Gets and sets the property EnaSrdSpecification. 
        /// <para>
        /// Configure ENA Express settings for your launch template.
        /// </para>
        /// </summary>
        public EnaSrdSpecificationRequest EnaSrdSpecification { get; set; }

        /// <summary>
        /// Checks to see if the EnaSrdSpecification property is set.
        /// </summary>
        internal bool IsSetEnaSrdSpecification() => this.EnaSrdSpecification != null;

        /// <summary>
        /// Gets and sets the property Groups. 
        /// <para>
        /// The IDs of one or more security groups.
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
        /// The type of network interface. To create an Elastic Fabric Adapter (EFA), specify
        /// <c>efa</c> or <c>efa</c>. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/efa.html">Elastic
        /// Fabric Adapter for AI/ML and HPC workloads on Amazon EC2</a> in the <i>Amazon EC2
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you are not creating an EFA, specify <c>interface</c> or omit this parameter.
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
        public string InterfaceType { get; set; }

        /// <summary>
        /// Checks to see if the InterfaceType property is set.
        /// </summary>
        internal bool IsSetInterfaceType() => this.InterfaceType != null;

        /// <summary>
        /// Gets and sets the property Ipv4PrefixCount. 
        /// <para>
        /// The number of IPv4 prefixes to be automatically assigned to the network interface.
        /// You cannot use this option if you use the <c>Ipv4Prefix</c> option.
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
        /// One or more IPv4 prefixes to be assigned to the network interface. You cannot use
        /// this option if you use the <c>Ipv4PrefixCount</c> option.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Ipv4PrefixSpecificationRequest> Ipv4Prefixes { get; set; } = AWSConfigs.InitializeCollections ? new List<Ipv4PrefixSpecificationRequest>() : null;

        /// <summary>
        /// Checks to see if the Ipv4Prefixes property is set.
        /// </summary>
        internal bool IsSetIpv4Prefixes() => this.Ipv4Prefixes != null && (this.Ipv4Prefixes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Ipv6AddressCount. 
        /// <para>
        /// The number of IPv6 addresses to assign to a network interface. Amazon EC2 automatically
        /// selects the IPv6 addresses from the subnet range. You can't use this option if specifying
        /// specific IPv6 addresses.
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
        /// One or more specific IPv6 addresses from the IPv6 CIDR block range of your subnet.
        /// You can't use this option if you're specifying a number of IPv6 addresses.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceIpv6AddressRequest> Ipv6Addresses { get; set; } = AWSConfigs.InitializeCollections ? new List<InstanceIpv6AddressRequest>() : null;

        /// <summary>
        /// Checks to see if the Ipv6Addresses property is set.
        /// </summary>
        internal bool IsSetIpv6Addresses() => this.Ipv6Addresses != null && (this.Ipv6Addresses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Ipv6PrefixCount. 
        /// <para>
        /// The number of IPv6 prefixes to be automatically assigned to the network interface.
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
        /// One or more IPv6 prefixes to be assigned to the network interface. You cannot use
        /// this option if you use the <c>Ipv6PrefixCount</c> option.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Ipv6PrefixSpecificationRequest> Ipv6Prefixes { get; set; } = AWSConfigs.InitializeCollections ? new List<Ipv6PrefixSpecificationRequest>() : null;

        /// <summary>
        /// Checks to see if the Ipv6Prefixes property is set.
        /// </summary>
        internal bool IsSetIpv6Prefixes() => this.Ipv6Prefixes != null && (this.Ipv6Prefixes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NetworkCardIndex. 
        /// <para>
        /// The index of the network card. Some instance types support multiple network cards.
        /// The primary network interface must be assigned to network card index 0. The default
        /// is network card index 0.
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
        /// The ID of the network interface.
        /// </para>
        /// </summary>
        public string NetworkInterfaceId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInterfaceId property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaceId() => this.NetworkInterfaceId != null;

        /// <summary>
        /// Gets and sets the property PrimaryIpv6. 
        /// <para>
        /// The primary IPv6 address of the network interface. When you enable an IPv6 GUA address
        /// to be a primary IPv6, the first IPv6 GUA will be made the primary IPv6 address until
        /// the instance is terminated or the network interface is detached. For more information
        /// about primary IPv6 addresses, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_RunInstances.html">RunInstances</a>.
        /// </para>
        /// </summary>
        public bool? PrimaryIpv6 { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryIpv6 property is set.
        /// </summary>
        internal bool IsSetPrimaryIpv6() => this.PrimaryIpv6.HasValue;

        /// <summary>
        /// Gets and sets the property PrivateIpAddress. 
        /// <para>
        /// The primary private IPv4 address of the network interface.
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
        /// One or more private IPv4 addresses.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PrivateIpAddressSpecification> PrivateIpAddresses { get; set; } = AWSConfigs.InitializeCollections ? new List<PrivateIpAddressSpecification>() : null;

        /// <summary>
        /// Checks to see if the PrivateIpAddresses property is set.
        /// </summary>
        internal bool IsSetPrivateIpAddresses() => this.PrivateIpAddresses != null && (this.PrivateIpAddresses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SecondaryPrivateIpAddressCount. 
        /// <para>
        /// The number of secondary private IPv4 addresses to assign to a network interface.
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
        /// The ID of the subnet for the network interface.
        /// </para>
        /// </summary>
        public string SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the SubnetId property is set.
        /// </summary>
        internal bool IsSetSubnetId() => this.SubnetId != null;
    }
}
