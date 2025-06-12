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
    /// Container for the parameters to the CreateNetworkInterface operation.
    /// Creates a network interface in the specified subnet.
    /// 
    ///  
    /// <para>
    /// The number of IP addresses you can assign to a network interface varies by instance
    /// type.
    /// </para>
    ///  
    /// <para>
    /// For more information about network interfaces, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-eni.html">Elastic
    /// network interfaces</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateNetworkInterfaceRequest : AmazonEC2Request
    {
        private string _clientToken;
        private ConnectionTrackingSpecificationRequest _connectionTrackingSpecification;
        private string _description;
        private bool? _dryRun;
        private bool? _enablePrimaryIpv6;
        private List<string> _groups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private NetworkInterfaceCreationType _interfaceType;
        private int? _ipv4PrefixCount;
        private List<Ipv4PrefixSpecificationRequest> _ipv4Prefixes = AWSConfigs.InitializeCollections ? new List<Ipv4PrefixSpecificationRequest>() : null;
        private int? _ipv6AddressCount;
        private List<InstanceIpv6Address> _ipv6Addresses = AWSConfigs.InitializeCollections ? new List<InstanceIpv6Address>() : null;
        private int? _ipv6PrefixCount;
        private List<Ipv6PrefixSpecificationRequest> _ipv6Prefixes = AWSConfigs.InitializeCollections ? new List<Ipv6PrefixSpecificationRequest>() : null;
        private OperatorRequest _operator;
        private string _privateIpAddress;
        private List<PrivateIpAddressSpecification> _privateIpAddresses = AWSConfigs.InitializeCollections ? new List<PrivateIpAddressSpecification>() : null;
        private int? _secondaryPrivateIpAddressCount;
        private string _subnetId;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/ec2-api-idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionTrackingSpecification. 
        /// <para>
        /// A connection tracking specification for the network interface.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the network interface.
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
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnablePrimaryIpv6. 
        /// <para>
        /// If you’re creating a network interface in a dual-stack or IPv6-only subnet, you have
        /// the option to assign a primary IPv6 IP address. A primary IPv6 address is an IPv6
        /// GUA address associated with an ENI that you have enabled to use a primary IPv6 address.
        /// Use this option if the instance that this ENI will be attached to relies on its IPv6
        /// address not changing. Amazon Web Services will automatically assign an IPv6 address
        /// associated with the ENI attached to your instance to be the primary IPv6 address.
        /// Once you enable an IPv6 GUA address to be a primary IPv6, you cannot disable it. When
        /// you enable an IPv6 GUA address to be a primary IPv6, the first IPv6 GUA will be made
        /// the primary IPv6 address until the instance is terminated or the network interface
        /// is detached. If you have multiple IPv6 addresses associated with an ENI attached to
        /// your instance and you enable a primary IPv6 address, the first IPv6 GUA address associated
        /// with the ENI becomes the primary IPv6 address.
        /// </para>
        /// </summary>
        public bool? EnablePrimaryIpv6
        {
            get { return this._enablePrimaryIpv6; }
            set { this._enablePrimaryIpv6 = value; }
        }

        // Check to see if EnablePrimaryIpv6 property is set
        internal bool IsSetEnablePrimaryIpv6()
        {
            return this._enablePrimaryIpv6.HasValue; 
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
        /// Gets and sets the property InterfaceType. 
        /// <para>
        /// The type of network interface. The default is <c>interface</c>.
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>efa-only</c>, do not assign any IP addresses to the network interface.
        /// EFA-only network interfaces do not support IP addresses.
        /// </para>
        ///  
        /// <para>
        /// The only supported values are <c>interface</c>, <c>efa</c>, <c>efa-only</c>, and <c>trunk</c>.
        /// </para>
        /// </summary>
        public NetworkInterfaceCreationType InterfaceType
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
        /// The number of IPv4 prefixes that Amazon Web Services automatically assigns to the
        /// network interface.
        /// </para>
        ///  
        /// <para>
        /// You can't specify a count of IPv4 prefixes if you've specified one of the following:
        /// specific IPv4 prefixes, specific private IPv4 addresses, or a count of private IPv4
        /// addresses.
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
        /// The IPv4 prefixes assigned to the network interface.
        /// </para>
        ///  
        /// <para>
        /// You can't specify IPv4 prefixes if you've specified one of the following: a count
        /// of IPv4 prefixes, specific private IPv4 addresses, or a count of private IPv4 addresses.
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
        /// The number of IPv6 addresses to assign to a network interface. Amazon EC2 automatically
        /// selects the IPv6 addresses from the subnet range.
        /// </para>
        ///  
        /// <para>
        /// You can't specify a count of IPv6 addresses using this parameter if you've specified
        /// one of the following: specific IPv6 addresses, specific IPv6 prefixes, or a count
        /// of IPv6 prefixes.
        /// </para>
        ///  
        /// <para>
        /// If your subnet has the <c>AssignIpv6AddressOnCreation</c> attribute set, you can override
        /// that setting by specifying 0 as the IPv6 address count.
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
        /// The IPv6 addresses from the IPv6 CIDR block range of your subnet.
        /// </para>
        ///  
        /// <para>
        /// You can't specify IPv6 addresses using this parameter if you've specified one of the
        /// following: a count of IPv6 addresses, specific IPv6 prefixes, or a count of IPv6 prefixes.
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
        /// The number of IPv6 prefixes that Amazon Web Services automatically assigns to the
        /// network interface.
        /// </para>
        ///  
        /// <para>
        /// You can't specify a count of IPv6 prefixes if you've specified one of the following:
        /// specific IPv6 prefixes, specific IPv6 addresses, or a count of IPv6 addresses.
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
        /// The IPv6 prefixes assigned to the network interface.
        /// </para>
        ///  
        /// <para>
        /// You can't specify IPv6 prefixes if you've specified one of the following: a count
        /// of IPv6 prefixes, specific IPv6 addresses, or a count of IPv6 addresses.
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
        /// Gets and sets the property Operator. 
        /// <para>
        /// Reserved for internal use.
        /// </para>
        /// </summary>
        public OperatorRequest Operator
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
        /// Gets and sets the property PrivateIpAddress. 
        /// <para>
        /// The primary private IPv4 address of the network interface. If you don't specify an
        /// IPv4 address, Amazon EC2 selects one for you from the subnet's IPv4 CIDR range. If
        /// you specify an IP address, you cannot indicate any IP addresses specified in <c>privateIpAddresses</c>
        /// as primary (only one IP address can be designated as primary).
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
        /// The private IPv4 addresses.
        /// </para>
        ///  
        /// <para>
        /// You can't specify private IPv4 addresses if you've specified one of the following:
        /// a count of private IPv4 addresses, specific IPv4 prefixes, or a count of IPv4 prefixes.
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
        /// The number of secondary private IPv4 addresses to assign to a network interface. When
        /// you specify a number of secondary IPv4 addresses, Amazon EC2 selects these IP addresses
        /// within the subnet's IPv4 CIDR range. You can't specify this option and specify more
        /// than one private IP address using <c>privateIpAddresses</c>.
        /// </para>
        ///  
        /// <para>
        /// You can't specify a count of private IPv4 addresses if you've specified one of the
        /// following: specific private IPv4 addresses, specific IPv4 prefixes, or a count of
        /// IPv4 prefixes.
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
        /// The ID of the subnet to associate with the network interface.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the new network interface.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && (this._tagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}