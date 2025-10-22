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
    /// Container for the parameters to the CreateVpc operation.
    /// Creates a VPC with the specified CIDR blocks. For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/vpc-ip-addressing.html">IP
    /// addressing for your VPCs and subnets</a> in the <i>Amazon VPC User Guide</i>.
    /// 
    ///  
    /// <para>
    /// You can optionally request an IPv6 CIDR block for the VPC. You can request an Amazon-provided
    /// IPv6 CIDR block from Amazon's pool of IPv6 addresses or an IPv6 CIDR block from an
    /// IPv6 address pool that you provisioned through bring your own IP addresses (<a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-byoip.html">BYOIP</a>).
    /// </para>
    ///  
    /// <para>
    /// By default, each instance that you launch in the VPC has the default DHCP options,
    /// which include only a default DNS server that we provide (AmazonProvidedDNS). For more
    /// information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_DHCP_Options.html">DHCP
    /// option sets</a> in the <i>Amazon VPC User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// You can specify the instance tenancy value for the VPC when you create it. You can't
    /// change this value for the VPC after you create it. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/dedicated-instance.html">Dedicated
    /// Instances</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateVpcRequest : AmazonEC2Request
    {
        private bool? _amazonProvidedIpv6CidrBlock;
        private string _cidrBlock;
        private bool? _dryRun;
        private Tenancy _instanceTenancy;
        private string _ipv4IpamPoolId;
        private int? _ipv4NetmaskLength;
        private string _ipv6CidrBlock;
        private string _ipv6CidrBlockNetworkBorderGroup;
        private string _ipv6IpamPoolId;
        private int? _ipv6NetmaskLength;
        private string _ipv6Pool;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateVpcRequest() { }

        /// <summary>
        /// Instantiates CreateVpcRequest with the parameterized properties
        /// </summary>
        /// <param name="cidrBlock">The IPv4 network range for the VPC, in CIDR notation. For example, <c>10.0.0.0/16</c>. We modify the specified CIDR block to its canonical form; for example, if you specify <c>100.68.0.18/18</c>, we modify it to <c>100.68.0.0/18</c>.</param>
        public CreateVpcRequest(string cidrBlock)
        {
            _cidrBlock = cidrBlock;
        }

        /// <summary>
        /// Gets and sets the property AmazonProvidedIpv6CidrBlock. 
        /// <para>
        /// Requests an Amazon-provided IPv6 CIDR block with a /56 prefix length for the VPC.
        /// You cannot specify the range of IP addresses, or the size of the CIDR block.
        /// </para>
        /// </summary>
        public bool? AmazonProvidedIpv6CidrBlock
        {
            get { return this._amazonProvidedIpv6CidrBlock; }
            set { this._amazonProvidedIpv6CidrBlock = value; }
        }

        // Check to see if AmazonProvidedIpv6CidrBlock property is set
        internal bool IsSetAmazonProvidedIpv6CidrBlock()
        {
            return this._amazonProvidedIpv6CidrBlock.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CidrBlock. 
        /// <para>
        /// The IPv4 network range for the VPC, in CIDR notation. For example, <c>10.0.0.0/16</c>.
        /// We modify the specified CIDR block to its canonical form; for example, if you specify
        /// <c>100.68.0.18/18</c>, we modify it to <c>100.68.0.0/18</c>.
        /// </para>
        /// </summary>
        public string CidrBlock
        {
            get { return this._cidrBlock; }
            set { this._cidrBlock = value; }
        }

        // Check to see if CidrBlock property is set
        internal bool IsSetCidrBlock()
        {
            return this._cidrBlock != null;
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
        /// Gets and sets the property InstanceTenancy. 
        /// <para>
        /// The tenancy options for instances launched into the VPC. For <c>default</c>, instances
        /// are launched with shared tenancy by default. You can launch instances with any tenancy
        /// into a shared tenancy VPC. For <c>dedicated</c>, instances are launched as dedicated
        /// tenancy instances by default. You can only launch instances with a tenancy of <c>dedicated</c>
        /// or <c>host</c> into a dedicated tenancy VPC. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Important:</b> The <c>host</c> value cannot be used with this parameter. Use the
        /// <c>default</c> or <c>dedicated</c> values only.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>default</c> 
        /// </para>
        /// </summary>
        public Tenancy InstanceTenancy
        {
            get { return this._instanceTenancy; }
            set { this._instanceTenancy = value; }
        }

        // Check to see if InstanceTenancy property is set
        internal bool IsSetInstanceTenancy()
        {
            return this._instanceTenancy != null;
        }

        /// <summary>
        /// Gets and sets the property Ipv4IpamPoolId. 
        /// <para>
        /// The ID of an IPv4 IPAM pool you want to use for allocating this VPC's CIDR. For more
        /// information, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/what-is-it-ipam.html">What
        /// is IPAM?</a> in the <i>Amazon VPC IPAM User Guide</i>. 
        /// </para>
        /// </summary>
        public string Ipv4IpamPoolId
        {
            get { return this._ipv4IpamPoolId; }
            set { this._ipv4IpamPoolId = value; }
        }

        // Check to see if Ipv4IpamPoolId property is set
        internal bool IsSetIpv4IpamPoolId()
        {
            return this._ipv4IpamPoolId != null;
        }

        /// <summary>
        /// Gets and sets the property Ipv4NetmaskLength. 
        /// <para>
        /// The netmask length of the IPv4 CIDR you want to allocate to this VPC from an Amazon
        /// VPC IP Address Manager (IPAM) pool. For more information about IPAM, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/what-is-it-ipam.html">What
        /// is IPAM?</a> in the <i>Amazon VPC IPAM User Guide</i>.
        /// </para>
        /// </summary>
        public int? Ipv4NetmaskLength
        {
            get { return this._ipv4NetmaskLength; }
            set { this._ipv4NetmaskLength = value; }
        }

        // Check to see if Ipv4NetmaskLength property is set
        internal bool IsSetIpv4NetmaskLength()
        {
            return this._ipv4NetmaskLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ipv6CidrBlock. 
        /// <para>
        /// The IPv6 CIDR block from the IPv6 address pool. You must also specify <c>Ipv6Pool</c>
        /// in the request.
        /// </para>
        ///  
        /// <para>
        /// To let Amazon choose the IPv6 CIDR block for you, omit this parameter.
        /// </para>
        /// </summary>
        public string Ipv6CidrBlock
        {
            get { return this._ipv6CidrBlock; }
            set { this._ipv6CidrBlock = value; }
        }

        // Check to see if Ipv6CidrBlock property is set
        internal bool IsSetIpv6CidrBlock()
        {
            return this._ipv6CidrBlock != null;
        }

        /// <summary>
        /// Gets and sets the property Ipv6CidrBlockNetworkBorderGroup. 
        /// <para>
        /// The name of the location from which we advertise the IPV6 CIDR block. Use this parameter
        /// to limit the address to this location.
        /// </para>
        ///  
        /// <para>
        ///  You must set <c>AmazonProvidedIpv6CidrBlock</c> to <c>true</c> to use this parameter.
        /// </para>
        /// </summary>
        public string Ipv6CidrBlockNetworkBorderGroup
        {
            get { return this._ipv6CidrBlockNetworkBorderGroup; }
            set { this._ipv6CidrBlockNetworkBorderGroup = value; }
        }

        // Check to see if Ipv6CidrBlockNetworkBorderGroup property is set
        internal bool IsSetIpv6CidrBlockNetworkBorderGroup()
        {
            return this._ipv6CidrBlockNetworkBorderGroup != null;
        }

        /// <summary>
        /// Gets and sets the property Ipv6IpamPoolId. 
        /// <para>
        /// The ID of an IPv6 IPAM pool which will be used to allocate this VPC an IPv6 CIDR.
        /// IPAM is a VPC feature that you can use to automate your IP address management workflows
        /// including assigning, tracking, troubleshooting, and auditing IP addresses across Amazon
        /// Web Services Regions and accounts throughout your Amazon Web Services Organization.
        /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/what-is-it-ipam.html">What
        /// is IPAM?</a> in the <i>Amazon VPC IPAM User Guide</i>.
        /// </para>
        /// </summary>
        public string Ipv6IpamPoolId
        {
            get { return this._ipv6IpamPoolId; }
            set { this._ipv6IpamPoolId = value; }
        }

        // Check to see if Ipv6IpamPoolId property is set
        internal bool IsSetIpv6IpamPoolId()
        {
            return this._ipv6IpamPoolId != null;
        }

        /// <summary>
        /// Gets and sets the property Ipv6NetmaskLength. 
        /// <para>
        /// The netmask length of the IPv6 CIDR you want to allocate to this VPC from an Amazon
        /// VPC IP Address Manager (IPAM) pool. For more information about IPAM, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/what-is-it-ipam.html">What
        /// is IPAM?</a> in the <i>Amazon VPC IPAM User Guide</i>.
        /// </para>
        /// </summary>
        public int? Ipv6NetmaskLength
        {
            get { return this._ipv6NetmaskLength; }
            set { this._ipv6NetmaskLength = value; }
        }

        // Check to see if Ipv6NetmaskLength property is set
        internal bool IsSetIpv6NetmaskLength()
        {
            return this._ipv6NetmaskLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ipv6Pool. 
        /// <para>
        /// The ID of an IPv6 address pool from which to allocate the IPv6 CIDR block.
        /// </para>
        /// </summary>
        public string Ipv6Pool
        {
            get { return this._ipv6Pool; }
            set { this._ipv6Pool = value; }
        }

        // Check to see if Ipv6Pool property is set
        internal bool IsSetIpv6Pool()
        {
            return this._ipv6Pool != null;
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to assign to the VPC.
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