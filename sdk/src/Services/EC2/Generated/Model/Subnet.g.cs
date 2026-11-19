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
    /// Describes a subnet.
    /// </summary>
    public partial class Subnet
    {
        /// <summary>
        /// Gets and sets the property AssignIpv6AddressOnCreation. 
        /// <para>
        /// Indicates whether a network interface created in this subnet (including a network
        /// interface created by <a>RunInstances</a>) receives an IPv6 address.
        /// </para>
        /// </summary>
        public bool? AssignIpv6AddressOnCreation { get; set; }

        /// <summary>
        /// Checks to see if the AssignIpv6AddressOnCreation property is set.
        /// </summary>
        internal bool IsSetAssignIpv6AddressOnCreation() => this.AssignIpv6AddressOnCreation.HasValue;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone of the subnet.
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The AZ ID of the subnet.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property AvailableIpAddressCount. 
        /// <para>
        /// The number of unused private IPv4 addresses in the subnet. The IPv4 addresses for
        /// any stopped instances are considered unavailable.
        /// </para>
        /// </summary>
        public int? AvailableIpAddressCount { get; set; }

        /// <summary>
        /// Checks to see if the AvailableIpAddressCount property is set.
        /// </summary>
        internal bool IsSetAvailableIpAddressCount() => this.AvailableIpAddressCount.HasValue;

        /// <summary>
        /// Gets and sets the property BlockPublicAccessStates. 
        /// <para>
        /// The state of VPC Block Public Access (BPA).
        /// </para>
        /// </summary>
        public BlockPublicAccessStates BlockPublicAccessStates { get; set; }

        /// <summary>
        /// Checks to see if the BlockPublicAccessStates property is set.
        /// </summary>
        internal bool IsSetBlockPublicAccessStates() => this.BlockPublicAccessStates != null;

        /// <summary>
        /// Gets and sets the property CidrBlock. 
        /// <para>
        /// The IPv4 CIDR block assigned to the subnet.
        /// </para>
        /// </summary>
        public string CidrBlock { get; set; }

        /// <summary>
        /// Checks to see if the CidrBlock property is set.
        /// </summary>
        internal bool IsSetCidrBlock() => this.CidrBlock != null;

        /// <summary>
        /// Gets and sets the property CustomerOwnedIpv4Pool. 
        /// <para>
        /// The customer-owned IPv4 address pool associated with the subnet.
        /// </para>
        /// </summary>
        public string CustomerOwnedIpv4Pool { get; set; }

        /// <summary>
        /// Checks to see if the CustomerOwnedIpv4Pool property is set.
        /// </summary>
        internal bool IsSetCustomerOwnedIpv4Pool() => this.CustomerOwnedIpv4Pool != null;

        /// <summary>
        /// Gets and sets the property DefaultForAz. 
        /// <para>
        /// Indicates whether this is the default subnet for the Availability Zone.
        /// </para>
        /// </summary>
        public bool? DefaultForAz { get; set; }

        /// <summary>
        /// Checks to see if the DefaultForAz property is set.
        /// </summary>
        internal bool IsSetDefaultForAz() => this.DefaultForAz.HasValue;

        /// <summary>
        /// Gets and sets the property EnableDns64. 
        /// <para>
        /// Indicates whether DNS queries made to the Amazon-provided DNS Resolver in this subnet
        /// should return synthetic IPv6 addresses for IPv4-only destinations.
        /// </para>
        /// </summary>
        public bool? EnableDns64 { get; set; }

        /// <summary>
        /// Checks to see if the EnableDns64 property is set.
        /// </summary>
        internal bool IsSetEnableDns64() => this.EnableDns64.HasValue;

        /// <summary>
        /// Gets and sets the property EnableLniAtDeviceIndex. 
        /// <para>
        ///  Indicates the device position for local network interfaces in this subnet. For example,
        /// <c>1</c> indicates local network interfaces in this subnet are the secondary network
        /// interface (eth1). 
        /// </para>
        /// </summary>
        public int? EnableLniAtDeviceIndex { get; set; }

        /// <summary>
        /// Checks to see if the EnableLniAtDeviceIndex property is set.
        /// </summary>
        internal bool IsSetEnableLniAtDeviceIndex() => this.EnableLniAtDeviceIndex.HasValue;

        /// <summary>
        /// Gets and sets the property Ipv6CidrBlockAssociationSet. 
        /// <para>
        /// Information about the IPv6 CIDR blocks associated with the subnet.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SubnetIpv6CidrBlockAssociation> Ipv6CidrBlockAssociationSet { get; set; } = AWSConfigs.InitializeCollections ? new List<SubnetIpv6CidrBlockAssociation>() : null;

        /// <summary>
        /// Checks to see if the Ipv6CidrBlockAssociationSet property is set.
        /// </summary>
        internal bool IsSetIpv6CidrBlockAssociationSet() => this.Ipv6CidrBlockAssociationSet != null && (this.Ipv6CidrBlockAssociationSet.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Ipv6Native. 
        /// <para>
        /// Indicates whether this is an IPv6 only subnet.
        /// </para>
        /// </summary>
        public bool? Ipv6Native { get; set; }

        /// <summary>
        /// Checks to see if the Ipv6Native property is set.
        /// </summary>
        internal bool IsSetIpv6Native() => this.Ipv6Native.HasValue;

        /// <summary>
        /// Gets and sets the property MapCustomerOwnedIpOnLaunch. 
        /// <para>
        /// Indicates whether a network interface created in this subnet (including a network
        /// interface created by <a>RunInstances</a>) receives a customer-owned IPv4 address.
        /// </para>
        /// </summary>
        public bool? MapCustomerOwnedIpOnLaunch { get; set; }

        /// <summary>
        /// Checks to see if the MapCustomerOwnedIpOnLaunch property is set.
        /// </summary>
        internal bool IsSetMapCustomerOwnedIpOnLaunch() => this.MapCustomerOwnedIpOnLaunch.HasValue;

        /// <summary>
        /// Gets and sets the property MapPublicIpOnLaunch. 
        /// <para>
        /// Indicates whether instances launched in this subnet receive a public IPv4 address.
        /// </para>
        ///  
        /// <para>
        /// Amazon Web Services charges for all public IPv4 addresses, including public IPv4 addresses
        /// associated with running instances and Elastic IP addresses. For more information,
        /// see the <i>Public IPv4 Address</i> tab on the <a href="http://aws.amazon.com/vpc/pricing/">Amazon
        /// VPC pricing page</a>.
        /// </para>
        /// </summary>
        public bool? MapPublicIpOnLaunch { get; set; }

        /// <summary>
        /// Checks to see if the MapPublicIpOnLaunch property is set.
        /// </summary>
        internal bool IsSetMapPublicIpOnLaunch() => this.MapPublicIpOnLaunch.HasValue;

        /// <summary>
        /// Gets and sets the property OutpostArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Outpost.
        /// </para>
        /// </summary>
        public string OutpostArn { get; set; }

        /// <summary>
        /// Checks to see if the OutpostArn property is set.
        /// </summary>
        internal bool IsSetOutpostArn() => this.OutpostArn != null;

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the subnet.
        /// </para>
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property PrivateDnsNameOptionsOnLaunch. 
        /// <para>
        /// The type of hostnames to assign to instances in the subnet at launch. An instance
        /// hostname is based on the IPv4 address or ID of the instance.
        /// </para>
        /// </summary>
        public PrivateDnsNameOptionsOnLaunch PrivateDnsNameOptionsOnLaunch { get; set; }

        /// <summary>
        /// Checks to see if the PrivateDnsNameOptionsOnLaunch property is set.
        /// </summary>
        internal bool IsSetPrivateDnsNameOptionsOnLaunch() => this.PrivateDnsNameOptionsOnLaunch != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the subnet.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>failed</c>: The underlying infrastructure to support the subnet failed to provision
        /// as expected.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>failed-insufficient-capacity</c>: The underlying infrastructure to support the
        /// subnet failed to provision due to a shortage of EC2 instance capacity.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SubnetState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property SubnetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the subnet.
        /// </para>
        /// </summary>
        public string SubnetArn { get; set; }

        /// <summary>
        /// Checks to see if the SubnetArn property is set.
        /// </summary>
        internal bool IsSetSubnetArn() => this.SubnetArn != null;

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet.
        /// </para>
        /// </summary>
        public string SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the SubnetId property is set.
        /// </summary>
        internal bool IsSetSubnetId() => this.SubnetId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags assigned to the subnet.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Indicates if this is a subnet used with Amazon Elastic VMware Service (EVS). Possible
        /// values are <c>Elastic VMware Service</c> or no value. For more information about Amazon
        /// EVS, see <a href="https://docs.aws.amazon.com/evs/latest/APIReference/Welcome.html">
        /// <i>Amazon Elastic VMware Service API Reference</i> </a>.
        /// </para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC the subnet is in.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
