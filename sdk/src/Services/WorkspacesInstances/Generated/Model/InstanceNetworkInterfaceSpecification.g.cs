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

namespace Amazon.WorkspacesInstances.Model
{
    /// <summary>
    /// Defines network interface configuration for WorkSpace Instance.
    /// </summary>
    public partial class InstanceNetworkInterfaceSpecification
    {
        /// <summary>
        /// Gets and sets the property AssociateCarrierIpAddress. 
        /// <para>
        /// Enables carrier IP address association.
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
        /// Enables public IP address assignment.
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
        /// Configures network connection tracking parameters.
        /// </para>
        /// </summary>
        public ConnectionTrackingSpecificationRequest ConnectionTrackingSpecification { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionTrackingSpecification property is set.
        /// </summary>
        internal bool IsSetConnectionTrackingSpecification() => this.ConnectionTrackingSpecification != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Descriptive text for the network interface.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DeviceIndex. 
        /// <para>
        /// Unique index for the network interface.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? DeviceIndex { get; set; }

        /// <summary>
        /// Checks to see if the DeviceIndex property is set.
        /// </summary>
        internal bool IsSetDeviceIndex() => this.DeviceIndex.HasValue;

        /// <summary>
        /// Gets and sets the property EnaSrdSpecification. 
        /// <para>
        /// Configures Elastic Network Adapter Scalable Reliable Datagram settings.
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
        /// Security groups associated with the network interface.
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
        /// Specifies the type of network interface.
        /// </para>
        /// </summary>
        public InterfaceTypeEnum InterfaceType { get; set; }

        /// <summary>
        /// Checks to see if the InterfaceType property is set.
        /// </summary>
        internal bool IsSetInterfaceType() => this.InterfaceType != null;

        /// <summary>
        /// Gets and sets the property Ipv4PrefixCount. 
        /// <para>
        /// Number of IPv4 prefixes to assign.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? Ipv4PrefixCount { get; set; }

        /// <summary>
        /// Checks to see if the Ipv4PrefixCount property is set.
        /// </summary>
        internal bool IsSetIpv4PrefixCount() => this.Ipv4PrefixCount.HasValue;

        /// <summary>
        /// Gets and sets the property Ipv4Prefixes. 
        /// <para>
        /// IPv4 prefix configurations for the interface.
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
        /// Number of IPv6 addresses to assign.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? Ipv6AddressCount { get; set; }

        /// <summary>
        /// Checks to see if the Ipv6AddressCount property is set.
        /// </summary>
        internal bool IsSetIpv6AddressCount() => this.Ipv6AddressCount.HasValue;

        /// <summary>
        /// Gets and sets the property Ipv6Addresses. 
        /// <para>
        /// Specific IPv6 addresses for the interface.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceIpv6Address> Ipv6Addresses { get; set; } = AWSConfigs.InitializeCollections ? new List<InstanceIpv6Address>() : null;

        /// <summary>
        /// Checks to see if the Ipv6Addresses property is set.
        /// </summary>
        internal bool IsSetIpv6Addresses() => this.Ipv6Addresses != null && (this.Ipv6Addresses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Ipv6PrefixCount. 
        /// <para>
        /// Number of IPv6 prefixes to assign.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? Ipv6PrefixCount { get; set; }

        /// <summary>
        /// Checks to see if the Ipv6PrefixCount property is set.
        /// </summary>
        internal bool IsSetIpv6PrefixCount() => this.Ipv6PrefixCount.HasValue;

        /// <summary>
        /// Gets and sets the property Ipv6Prefixes. 
        /// <para>
        /// IPv6 prefix configurations for the interface.
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
        /// Index of the network card for multiple network interfaces.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? NetworkCardIndex { get; set; }

        /// <summary>
        /// Checks to see if the NetworkCardIndex property is set.
        /// </summary>
        internal bool IsSetNetworkCardIndex() => this.NetworkCardIndex.HasValue;

        /// <summary>
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        /// Unique identifier for the network interface.
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
        /// Indicates the primary IPv6 configuration.
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
        /// Primary private IP address for the interface.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the PrivateIpAddress property is set.
        /// </summary>
        internal bool IsSetPrivateIpAddress() => this.PrivateIpAddress != null;

        /// <summary>
        /// Gets and sets the property PrivateIpAddresses. 
        /// <para>
        /// List of private IP addresses for the interface.
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
        /// Number of additional private IP addresses to assign.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? SecondaryPrivateIpAddressCount { get; set; }

        /// <summary>
        /// Checks to see if the SecondaryPrivateIpAddressCount property is set.
        /// </summary>
        internal bool IsSetSecondaryPrivateIpAddressCount() => this.SecondaryPrivateIpAddressCount.HasValue;

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// Subnet identifier for the network interface.
        /// </para>
        /// </summary>
        public string SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the SubnetId property is set.
        /// </summary>
        internal bool IsSetSubnetId() => this.SubnetId != null;
    }
}
