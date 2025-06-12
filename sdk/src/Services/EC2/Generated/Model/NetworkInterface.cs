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
    public partial class NetworkInterface
    {
        private List<string> _associatedSubnets = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private NetworkInterfaceAssociation _association;
        private NetworkInterfaceAttachment _attachment;
        private string _availabilityZone;
        private ConnectionTrackingConfiguration _connectionTrackingConfiguration;
        private bool? _denyAllIgwTraffic;
        private string _description;
        private List<GroupIdentifier> _groups = AWSConfigs.InitializeCollections ? new List<GroupIdentifier>() : null;
        private NetworkInterfaceType _interfaceType;
        private List<Ipv4PrefixSpecification> _ipv4Prefixes = AWSConfigs.InitializeCollections ? new List<Ipv4PrefixSpecification>() : null;
        private string _ipv6Address;
        private List<NetworkInterfaceIpv6Address> _ipv6Addresses = AWSConfigs.InitializeCollections ? new List<NetworkInterfaceIpv6Address>() : null;
        private bool? _ipv6Native;
        private List<Ipv6PrefixSpecification> _ipv6Prefixes = AWSConfigs.InitializeCollections ? new List<Ipv6PrefixSpecification>() : null;
        private string _macAddress;
        private string _networkInterfaceId;
        private OperatorResponse _operator;
        private string _outpostArn;
        private string _ownerId;
        private string _privateDnsName;
        private string _privateIpAddress;
        private List<NetworkInterfacePrivateIpAddress> _privateIpAddresses = AWSConfigs.InitializeCollections ? new List<NetworkInterfacePrivateIpAddress>() : null;
        private string _publicDnsName;
        private PublicIpDnsNameOptions _publicIpDnsNameOptions;
        private string _requesterId;
        private bool? _requesterManaged;
        private bool? _sourceDestCheck;
        private NetworkInterfaceStatus _status;
        private string _subnetId;
        private List<Tag> _tagSet = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property AssociatedSubnets. 
        /// <para>
        /// The subnets associated with this network interface.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AssociatedSubnets
        {
            get { return this._associatedSubnets; }
            set { this._associatedSubnets = value; }
        }

        // Check to see if AssociatedSubnets property is set
        internal bool IsSetAssociatedSubnets()
        {
            return this._associatedSubnets != null && (this._associatedSubnets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Association. 
        /// <para>
        /// The association information for an Elastic IP address (IPv4) associated with the network
        /// interface.
        /// </para>
        /// </summary>
        public NetworkInterfaceAssociation Association
        {
            get { return this._association; }
            set { this._association = value; }
        }

        // Check to see if Association property is set
        internal bool IsSetAssociation()
        {
            return this._association != null;
        }

        /// <summary>
        /// Gets and sets the property Attachment. 
        /// <para>
        /// The network interface attachment.
        /// </para>
        /// </summary>
        public NetworkInterfaceAttachment Attachment
        {
            get { return this._attachment; }
            set { this._attachment = value; }
        }

        // Check to see if Attachment property is set
        internal bool IsSetAttachment()
        {
            return this._attachment != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone.
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionTrackingConfiguration. 
        /// <para>
        /// A security group connection tracking configuration that enables you to set the timeout
        /// for connection tracking on an Elastic network interface. For more information, see
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/security-group-connection-tracking.html#connection-tracking-timeouts">Connection
        /// tracking timeouts</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public ConnectionTrackingConfiguration ConnectionTrackingConfiguration
        {
            get { return this._connectionTrackingConfiguration; }
            set { this._connectionTrackingConfiguration = value; }
        }

        // Check to see if ConnectionTrackingConfiguration property is set
        internal bool IsSetConnectionTrackingConfiguration()
        {
            return this._connectionTrackingConfiguration != null;
        }

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
        public bool? DenyAllIgwTraffic
        {
            get { return this._denyAllIgwTraffic; }
            set { this._denyAllIgwTraffic = value; }
        }

        // Check to see if DenyAllIgwTraffic property is set
        internal bool IsSetDenyAllIgwTraffic()
        {
            return this._denyAllIgwTraffic.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description.
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
        /// Gets and sets the property Groups. 
        /// <para>
        /// Any security groups for the network interface.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GroupIdentifier> Groups
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
        /// </summary>
        public NetworkInterfaceType InterfaceType
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
        /// Gets and sets the property Ipv4Prefixes. 
        /// <para>
        /// The IPv4 prefixes that are assigned to the network interface.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Ipv4PrefixSpecification> Ipv4Prefixes
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
        /// Gets and sets the property Ipv6Address. 
        /// <para>
        /// The IPv6 globally unique address associated with the network interface.
        /// </para>
        /// </summary>
        public string Ipv6Address
        {
            get { return this._ipv6Address; }
            set { this._ipv6Address = value; }
        }

        // Check to see if Ipv6Address property is set
        internal bool IsSetIpv6Address()
        {
            return this._ipv6Address != null;
        }

        /// <summary>
        /// Gets and sets the property Ipv6Addresses. 
        /// <para>
        /// The IPv6 addresses associated with the network interface.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NetworkInterfaceIpv6Address> Ipv6Addresses
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
        /// Gets and sets the property Ipv6Native. 
        /// <para>
        /// Indicates whether this is an IPv6 only network interface.
        /// </para>
        /// </summary>
        public bool? Ipv6Native
        {
            get { return this._ipv6Native; }
            set { this._ipv6Native = value; }
        }

        // Check to see if Ipv6Native property is set
        internal bool IsSetIpv6Native()
        {
            return this._ipv6Native.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ipv6Prefixes. 
        /// <para>
        /// The IPv6 prefixes that are assigned to the network interface.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Ipv6PrefixSpecification> Ipv6Prefixes
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
        /// Gets and sets the property MacAddress. 
        /// <para>
        /// The MAC address.
        /// </para>
        /// </summary>
        public string MacAddress
        {
            get { return this._macAddress; }
            set { this._macAddress = value; }
        }

        // Check to see if MacAddress property is set
        internal bool IsSetMacAddress()
        {
            return this._macAddress != null;
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
        /// Gets and sets the property Operator. 
        /// <para>
        /// The service provider that manages the network interface.
        /// </para>
        /// </summary>
        public OperatorResponse Operator
        {
            get { return this._operator; }
            set { this._operator = value; }
        }

        // Check to see if Operator property is set
        internal bool IsSetOperator()
        {
            return this._operator != null;
        }

        /// <summary>
        /// Gets and sets the property OutpostArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Outpost.
        /// </para>
        /// </summary>
        public string OutpostArn
        {
            get { return this._outpostArn; }
            set { this._outpostArn = value; }
        }

        // Check to see if OutpostArn property is set
        internal bool IsSetOutpostArn()
        {
            return this._outpostArn != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The Amazon Web Services account ID of the owner of the network interface.
        /// </para>
        /// </summary>
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateDnsName. 
        /// <para>
        /// The private hostname. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-naming.html">EC2
        /// instance hostnames, DNS names, and domains</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public string PrivateDnsName
        {
            get { return this._privateDnsName; }
            set { this._privateDnsName = value; }
        }

        // Check to see if PrivateDnsName property is set
        internal bool IsSetPrivateDnsName()
        {
            return this._privateDnsName != null;
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
        /// Gets and sets the property PrivateIpAddresses. 
        /// <para>
        /// The private IPv4 addresses associated with the network interface.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NetworkInterfacePrivateIpAddress> PrivateIpAddresses
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
        /// Gets and sets the property PublicDnsName. 
        /// <para>
        /// A public hostname. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-naming.html">EC2
        /// instance hostnames, DNS names, and domains</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public string PublicDnsName
        {
            get { return this._publicDnsName; }
            set { this._publicDnsName = value; }
        }

        // Check to see if PublicDnsName property is set
        internal bool IsSetPublicDnsName()
        {
            return this._publicDnsName != null;
        }

        /// <summary>
        /// Gets and sets the property PublicIpDnsNameOptions. 
        /// <para>
        /// Public hostname type options. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-naming.html">EC2
        /// instance hostnames, DNS names, and domains</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public PublicIpDnsNameOptions PublicIpDnsNameOptions
        {
            get { return this._publicIpDnsNameOptions; }
            set { this._publicIpDnsNameOptions = value; }
        }

        // Check to see if PublicIpDnsNameOptions property is set
        internal bool IsSetPublicIpDnsNameOptions()
        {
            return this._publicIpDnsNameOptions != null;
        }

        /// <summary>
        /// Gets and sets the property RequesterId. 
        /// <para>
        /// The alias or Amazon Web Services account ID of the principal or service that created
        /// the network interface.
        /// </para>
        /// </summary>
        public string RequesterId
        {
            get { return this._requesterId; }
            set { this._requesterId = value; }
        }

        // Check to see if RequesterId property is set
        internal bool IsSetRequesterId()
        {
            return this._requesterId != null;
        }

        /// <summary>
        /// Gets and sets the property RequesterManaged. 
        /// <para>
        /// Indicates whether the network interface is being managed by Amazon Web Services.
        /// </para>
        /// </summary>
        public bool? RequesterManaged
        {
            get { return this._requesterManaged; }
            set { this._requesterManaged = value; }
        }

        // Check to see if RequesterManaged property is set
        internal bool IsSetRequesterManaged()
        {
            return this._requesterManaged.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceDestCheck. 
        /// <para>
        /// Indicates whether source/destination checking is enabled.
        /// </para>
        /// </summary>
        public bool? SourceDestCheck
        {
            get { return this._sourceDestCheck; }
            set { this._sourceDestCheck = value; }
        }

        // Check to see if SourceDestCheck property is set
        internal bool IsSetSourceDestCheck()
        {
            return this._sourceDestCheck.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the network interface.
        /// </para>
        /// </summary>
        public NetworkInterfaceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
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

        /// <summary>
        /// Gets and sets the property TagSet. 
        /// <para>
        /// Any tags assigned to the network interface.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> TagSet
        {
            get { return this._tagSet; }
            set { this._tagSet = value; }
        }

        // Check to see if TagSet property is set
        internal bool IsSetTagSet()
        {
            return this._tagSet != null && (this._tagSet.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC.
        /// </para>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}