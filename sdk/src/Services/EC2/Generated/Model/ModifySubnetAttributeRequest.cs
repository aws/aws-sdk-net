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
    /// Container for the parameters to the ModifySubnetAttribute operation.
    /// Modifies a subnet attribute. You can only modify one attribute at a time.
    /// 
    ///  
    /// <para>
    /// Use this action to modify subnets on Amazon Web Services Outposts.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// To modify a subnet on an Outpost rack, set both <c>MapCustomerOwnedIpOnLaunch</c>
    /// and <c>CustomerOwnedIpv4Pool</c>. These two parameters act as a single attribute.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To modify a subnet on an Outpost server, set either <c>EnableLniAtDeviceIndex</c>
    /// or <c>DisableLniAtDeviceIndex</c>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information about Amazon Web Services Outposts, see the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/outposts/latest/userguide/how-servers-work.html">Outpost
    /// servers</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/outposts/latest/userguide/how-racks-work.html">Outpost
    /// racks</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ModifySubnetAttributeRequest : AmazonEC2Request
    {
        private bool? _assignIpv6AddressOnCreation;
        private string _customerOwnedIpv4Pool;
        private bool? _disableLniAtDeviceIndex;
        private bool? _enableDns64;
        private int? _enableLniAtDeviceIndex;
        private bool? _enableResourceNameDnsAAAARecordOnLaunch;
        private bool? _enableResourceNameDnsARecordOnLaunch;
        private bool? _mapCustomerOwnedIpOnLaunch;
        private bool? _mapPublicIpOnLaunch;
        private HostnameType _privateDnsHostnameTypeOnLaunch;
        private string _subnetId;

        /// <summary>
        /// Gets and sets the property AssignIpv6AddressOnCreation. 
        /// <para>
        /// Specify <c>true</c> to indicate that network interfaces created in the specified subnet
        /// should be assigned an IPv6 address. This includes a network interface that's created
        /// when launching an instance into the subnet (the instance therefore receives an IPv6
        /// address). 
        /// </para>
        ///  
        /// <para>
        /// If you enable the IPv6 addressing feature for your subnet, your network interface
        /// or instance only receives an IPv6 address if it's created using version <c>2016-11-15</c>
        /// or later of the Amazon EC2 API.
        /// </para>
        /// </summary>
        public bool? AssignIpv6AddressOnCreation
        {
            get { return this._assignIpv6AddressOnCreation; }
            set { this._assignIpv6AddressOnCreation = value; }
        }

        // Check to see if AssignIpv6AddressOnCreation property is set
        internal bool IsSetAssignIpv6AddressOnCreation()
        {
            return this._assignIpv6AddressOnCreation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomerOwnedIpv4Pool. 
        /// <para>
        /// The customer-owned IPv4 address pool associated with the subnet.
        /// </para>
        ///  
        /// <para>
        /// You must set this value when you specify <c>true</c> for <c>MapCustomerOwnedIpOnLaunch</c>.
        /// </para>
        /// </summary>
        public string CustomerOwnedIpv4Pool
        {
            get { return this._customerOwnedIpv4Pool; }
            set { this._customerOwnedIpv4Pool = value; }
        }

        // Check to see if CustomerOwnedIpv4Pool property is set
        internal bool IsSetCustomerOwnedIpv4Pool()
        {
            return this._customerOwnedIpv4Pool != null;
        }

        /// <summary>
        /// Gets and sets the property DisableLniAtDeviceIndex. 
        /// <para>
        ///  Specify <c>true</c> to indicate that local network interfaces at the current position
        /// should be disabled. 
        /// </para>
        /// </summary>
        public bool? DisableLniAtDeviceIndex
        {
            get { return this._disableLniAtDeviceIndex; }
            set { this._disableLniAtDeviceIndex = value; }
        }

        // Check to see if DisableLniAtDeviceIndex property is set
        internal bool IsSetDisableLniAtDeviceIndex()
        {
            return this._disableLniAtDeviceIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableDns64. 
        /// <para>
        /// Indicates whether DNS queries made to the Amazon-provided DNS Resolver in this subnet
        /// should return synthetic IPv6 addresses for IPv4-only destinations.
        /// </para>
        ///  
        /// <para>
        /// You must first configure a NAT gateway in a public subnet (separate from the subnet
        /// containing the IPv6-only workloads). For example, the subnet containing the NAT gateway
        /// should have a <c>0.0.0.0/0</c> route pointing to the internet gateway. For more information,
        /// see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/nat-gateway-nat64-dns64.html#nat-gateway-nat64-dns64-walkthrough">Configure
        /// DNS64 and NAT64</a> in the <i>Amazon VPC User Guide</i>.
        /// </para>
        /// </summary>
        public bool? EnableDns64
        {
            get { return this._enableDns64; }
            set { this._enableDns64 = value; }
        }

        // Check to see if EnableDns64 property is set
        internal bool IsSetEnableDns64()
        {
            return this._enableDns64.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableLniAtDeviceIndex. 
        /// <para>
        ///  Indicates the device position for local network interfaces in this subnet. For example,
        /// <c>1</c> indicates local network interfaces in this subnet are the secondary network
        /// interface (eth1). A local network interface cannot be the primary network interface
        /// (eth0). 
        /// </para>
        /// </summary>
        public int? EnableLniAtDeviceIndex
        {
            get { return this._enableLniAtDeviceIndex; }
            set { this._enableLniAtDeviceIndex = value; }
        }

        // Check to see if EnableLniAtDeviceIndex property is set
        internal bool IsSetEnableLniAtDeviceIndex()
        {
            return this._enableLniAtDeviceIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableResourceNameDnsAAAARecordOnLaunch. 
        /// <para>
        /// Indicates whether to respond to DNS queries for instance hostnames with DNS AAAA records.
        /// </para>
        /// </summary>
        public bool? EnableResourceNameDnsAAAARecordOnLaunch
        {
            get { return this._enableResourceNameDnsAAAARecordOnLaunch; }
            set { this._enableResourceNameDnsAAAARecordOnLaunch = value; }
        }

        // Check to see if EnableResourceNameDnsAAAARecordOnLaunch property is set
        internal bool IsSetEnableResourceNameDnsAAAARecordOnLaunch()
        {
            return this._enableResourceNameDnsAAAARecordOnLaunch.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableResourceNameDnsARecordOnLaunch. 
        /// <para>
        /// Indicates whether to respond to DNS queries for instance hostnames with DNS A records.
        /// </para>
        /// </summary>
        public bool? EnableResourceNameDnsARecordOnLaunch
        {
            get { return this._enableResourceNameDnsARecordOnLaunch; }
            set { this._enableResourceNameDnsARecordOnLaunch = value; }
        }

        // Check to see if EnableResourceNameDnsARecordOnLaunch property is set
        internal bool IsSetEnableResourceNameDnsARecordOnLaunch()
        {
            return this._enableResourceNameDnsARecordOnLaunch.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MapCustomerOwnedIpOnLaunch. 
        /// <para>
        /// Specify <c>true</c> to indicate that network interfaces attached to instances created
        /// in the specified subnet should be assigned a customer-owned IPv4 address.
        /// </para>
        ///  
        /// <para>
        /// When this value is <c>true</c>, you must specify the customer-owned IP pool using
        /// <c>CustomerOwnedIpv4Pool</c>.
        /// </para>
        /// </summary>
        public bool? MapCustomerOwnedIpOnLaunch
        {
            get { return this._mapCustomerOwnedIpOnLaunch; }
            set { this._mapCustomerOwnedIpOnLaunch = value; }
        }

        // Check to see if MapCustomerOwnedIpOnLaunch property is set
        internal bool IsSetMapCustomerOwnedIpOnLaunch()
        {
            return this._mapCustomerOwnedIpOnLaunch.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MapPublicIpOnLaunch. 
        /// <para>
        /// Specify <c>true</c> to indicate that network interfaces attached to instances created
        /// in the specified subnet should be assigned a public IPv4 address.
        /// </para>
        ///  
        /// <para>
        /// Amazon Web Services charges for all public IPv4 addresses, including public IPv4 addresses
        /// associated with running instances and Elastic IP addresses. For more information,
        /// see the <i>Public IPv4 Address</i> tab on the <a href="http://aws.amazon.com/vpc/pricing/">Amazon
        /// VPC pricing page</a>.
        /// </para>
        /// </summary>
        public bool? MapPublicIpOnLaunch
        {
            get { return this._mapPublicIpOnLaunch; }
            set { this._mapPublicIpOnLaunch = value; }
        }

        // Check to see if MapPublicIpOnLaunch property is set
        internal bool IsSetMapPublicIpOnLaunch()
        {
            return this._mapPublicIpOnLaunch.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PrivateDnsHostnameTypeOnLaunch. 
        /// <para>
        /// The type of hostname to assign to instances in the subnet at launch. For IPv4-only
        /// and dual-stack (IPv4 and IPv6) subnets, an instance DNS name can be based on the instance
        /// IPv4 address (ip-name) or the instance ID (resource-name). For IPv6 only subnets,
        /// an instance DNS name must be based on the instance ID (resource-name).
        /// </para>
        /// </summary>
        public HostnameType PrivateDnsHostnameTypeOnLaunch
        {
            get { return this._privateDnsHostnameTypeOnLaunch; }
            set { this._privateDnsHostnameTypeOnLaunch = value; }
        }

        // Check to see if PrivateDnsHostnameTypeOnLaunch property is set
        internal bool IsSetPrivateDnsHostnameTypeOnLaunch()
        {
            return this._privateDnsHostnameTypeOnLaunch != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet.
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

    }
}