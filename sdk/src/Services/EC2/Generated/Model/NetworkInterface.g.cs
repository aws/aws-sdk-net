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
    /// Describes a network interface.
    /// </summary>
    public partial class NetworkInterface
    {
        /// <summary>
        /// Gets and sets the property AssociatedSubnets. 
        /// <para>
        /// The subnets associated with this network interface.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AssociatedSubnets { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AssociatedSubnets property is set.
        /// </summary>
        internal bool IsSetAssociatedSubnets() => this.AssociatedSubnets != null && (this.AssociatedSubnets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Association. 
        /// <para>
        /// The association information for an Elastic IP address (IPv4) associated with the network
        /// interface.
        /// </para>
        /// </summary>
        public NetworkInterfaceAssociation Association { get; set; }

        /// <summary>
        /// Checks to see if the Association property is set.
        /// </summary>
        internal bool IsSetAssociation() => this.Association != null;

        /// <summary>
        /// Gets and sets the property Attachment. 
        /// <para>
        /// The network interface attachment.
        /// </para>
        /// </summary>
        public NetworkInterfaceAttachment Attachment { get; set; }

        /// <summary>
        /// Checks to see if the Attachment property is set.
        /// </summary>
        internal bool IsSetAttachment() => this.Attachment != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone.
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
        /// The ID of the Availability Zone.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property ConnectionTrackingConfiguration. 
        /// <para>
        /// A security group connection tracking configuration that enables you to set the timeout
        /// for connection tracking on an Elastic network interface. For more information, see
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/security-group-connection-tracking.html#connection-tracking-timeouts">Connection
        /// tracking timeouts</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public ConnectionTrackingConfiguration ConnectionTrackingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionTrackingConfiguration property is set.
        /// </summary>
        internal bool IsSetConnectionTrackingConfiguration() => this.ConnectionTrackingConfiguration != null;

        /// <summary>
        /// Gets and sets the property DenyAllIgwTraffic. 
        /// <para>
        /// Indicates whether a network interface with an IPv6 address is unreachable from the
        /// public internet. If the value is <c>true</c>, inbound traffic from the internet is
        /// dropped and you cannot assign an elastic IP address to the network interface. The
        /// network interface is reachable from peered VPCs and resources connected through a
        /// transit gateway, including on-premises networks.
        /// </para>
        /// </summary>
        public bool? DenyAllIgwTraffic { get; set; }

        /// <summary>
        /// Checks to see if the DenyAllIgwTraffic property is set.
        /// </summary>
        internal bool IsSetDenyAllIgwTraffic() => this.DenyAllIgwTraffic.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Groups. 
        /// <para>
        /// Any security groups for the network interface.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GroupIdentifier> Groups { get; set; } = AWSConfigs.InitializeCollections ? new List<GroupIdentifier>() : null;

        /// <summary>
        /// Checks to see if the Groups property is set.
        /// </summary>
        internal bool IsSetGroups() => this.Groups != null && (this.Groups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InterfaceType. 
        /// <para>
        /// The type of network interface.
        /// </para>
        /// </summary>
        public NetworkInterfaceType InterfaceType { get; set; }

        /// <summary>
        /// Checks to see if the InterfaceType property is set.
        /// </summary>
        internal bool IsSetInterfaceType() => this.InterfaceType != null;

        /// <summary>
        /// Gets and sets the property Ipv4Prefixes. 
        /// <para>
        /// The IPv4 prefixes that are assigned to the network interface.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Ipv4PrefixSpecification> Ipv4Prefixes { get; set; } = AWSConfigs.InitializeCollections ? new List<Ipv4PrefixSpecification>() : null;

        /// <summary>
        /// Checks to see if the Ipv4Prefixes property is set.
        /// </summary>
        internal bool IsSetIpv4Prefixes() => this.Ipv4Prefixes != null && (this.Ipv4Prefixes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Ipv6Address. 
        /// <para>
        /// The IPv6 globally unique address associated with the network interface.
        /// </para>
        /// </summary>
        public string Ipv6Address { get; set; }

        /// <summary>
        /// Checks to see if the Ipv6Address property is set.
        /// </summary>
        internal bool IsSetIpv6Address() => this.Ipv6Address != null;

        /// <summary>
        /// Gets and sets the property Ipv6Addresses. 
        /// <para>
        /// The IPv6 addresses associated with the network interface.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NetworkInterfaceIpv6Address> Ipv6Addresses { get; set; } = AWSConfigs.InitializeCollections ? new List<NetworkInterfaceIpv6Address>() : null;

        /// <summary>
        /// Checks to see if the Ipv6Addresses property is set.
        /// </summary>
        internal bool IsSetIpv6Addresses() => this.Ipv6Addresses != null && (this.Ipv6Addresses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Ipv6Native. 
        /// <para>
        /// Indicates whether this is an IPv6 only network interface.
        /// </para>
        /// </summary>
        public bool? Ipv6Native { get; set; }

        /// <summary>
        /// Checks to see if the Ipv6Native property is set.
        /// </summary>
        internal bool IsSetIpv6Native() => this.Ipv6Native.HasValue;

        /// <summary>
        /// Gets and sets the property Ipv6Prefixes. 
        /// <para>
        /// The IPv6 prefixes that are assigned to the network interface.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Ipv6PrefixSpecification> Ipv6Prefixes { get; set; } = AWSConfigs.InitializeCollections ? new List<Ipv6PrefixSpecification>() : null;

        /// <summary>
        /// Checks to see if the Ipv6Prefixes property is set.
        /// </summary>
        internal bool IsSetIpv6Prefixes() => this.Ipv6Prefixes != null && (this.Ipv6Prefixes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MacAddress. 
        /// <para>
        /// The MAC address.
        /// </para>
        /// </summary>
        public string MacAddress { get; set; }

        /// <summary>
        /// Checks to see if the MacAddress property is set.
        /// </summary>
        internal bool IsSetMacAddress() => this.MacAddress != null;

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
        /// Gets and sets the property Operator. 
        /// <para>
        /// The service provider that manages the network interface.
        /// </para>
        /// </summary>
        public OperatorResponse Operator { get; set; }

        /// <summary>
        /// Checks to see if the Operator property is set.
        /// </summary>
        internal bool IsSetOperator() => this.Operator != null;

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
        /// The Amazon Web Services account ID of the owner of the network interface.
        /// </para>
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property PrivateDnsName. 
        /// <para>
        /// The private hostname. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-naming.html">EC2
        /// instance hostnames, DNS names, and domains</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public string PrivateDnsName { get; set; }

        /// <summary>
        /// Checks to see if the PrivateDnsName property is set.
        /// </summary>
        internal bool IsSetPrivateDnsName() => this.PrivateDnsName != null;

        /// <summary>
        /// Gets and sets the property PrivateIpAddress. 
        /// <para>
        /// The IPv4 address of the network interface within the subnet.
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
        /// The private IPv4 addresses associated with the network interface.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NetworkInterfacePrivateIpAddress> PrivateIpAddresses { get; set; } = AWSConfigs.InitializeCollections ? new List<NetworkInterfacePrivateIpAddress>() : null;

        /// <summary>
        /// Checks to see if the PrivateIpAddresses property is set.
        /// </summary>
        internal bool IsSetPrivateIpAddresses() => this.PrivateIpAddresses != null && (this.PrivateIpAddresses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PublicDnsName. 
        /// <para>
        /// A public hostname. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-naming.html">EC2
        /// instance hostnames, DNS names, and domains</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public string PublicDnsName { get; set; }

        /// <summary>
        /// Checks to see if the PublicDnsName property is set.
        /// </summary>
        internal bool IsSetPublicDnsName() => this.PublicDnsName != null;

        /// <summary>
        /// Gets and sets the property PublicIpDnsNameOptions. 
        /// <para>
        /// Public hostname type options. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-naming.html">EC2
        /// instance hostnames, DNS names, and domains</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public PublicIpDnsNameOptions PublicIpDnsNameOptions { get; set; }

        /// <summary>
        /// Checks to see if the PublicIpDnsNameOptions property is set.
        /// </summary>
        internal bool IsSetPublicIpDnsNameOptions() => this.PublicIpDnsNameOptions != null;

        /// <summary>
        /// Gets and sets the property RequesterId. 
        /// <para>
        /// The alias or Amazon Web Services account ID of the principal or service that created
        /// the network interface.
        /// </para>
        /// </summary>
        public string RequesterId { get; set; }

        /// <summary>
        /// Checks to see if the RequesterId property is set.
        /// </summary>
        internal bool IsSetRequesterId() => this.RequesterId != null;

        /// <summary>
        /// Gets and sets the property RequesterManaged. 
        /// <para>
        /// Indicates whether the network interface is being managed by Amazon Web Services.
        /// </para>
        /// </summary>
        public bool? RequesterManaged { get; set; }

        /// <summary>
        /// Checks to see if the RequesterManaged property is set.
        /// </summary>
        internal bool IsSetRequesterManaged() => this.RequesterManaged.HasValue;

        /// <summary>
        /// Gets and sets the property SourceDestCheck. 
        /// <para>
        /// Indicates whether source/destination checking is enabled.
        /// </para>
        /// </summary>
        public bool? SourceDestCheck { get; set; }

        /// <summary>
        /// Checks to see if the SourceDestCheck property is set.
        /// </summary>
        internal bool IsSetSourceDestCheck() => this.SourceDestCheck.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the network interface.
        /// </para>
        /// </summary>
        public NetworkInterfaceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

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
        /// Gets and sets the property TagSet. 
        /// <para>
        /// Any tags assigned to the network interface.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> TagSet { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the TagSet property is set.
        /// </summary>
        internal bool IsSetTagSet() => this.TagSet != null && (this.TagSet.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
