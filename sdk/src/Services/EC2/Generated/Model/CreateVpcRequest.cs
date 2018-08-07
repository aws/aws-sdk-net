/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateVpc operation.
    /// Creates a VPC with the specified IPv4 CIDR block. The smallest VPC you can create
    /// uses a /28 netmask (16 IPv4 addresses), and the largest uses a /16 netmask (65,536
    /// IPv4 addresses). For more information about how large to make your VPC, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Subnets.html">Your
    /// VPC and Subnets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
    /// 
    ///  
    /// <para>
    /// You can optionally request an Amazon-provided IPv6 CIDR block for the VPC. The IPv6
    /// CIDR block uses a /56 prefix length, and is allocated from Amazon's pool of IPv6 addresses.
    /// You cannot choose the IPv6 range for your VPC.
    /// </para>
    ///  
    /// <para>
    /// By default, each instance you launch in the VPC has the default DHCP options, which
    /// include only a default DNS server that we provide (AmazonProvidedDNS). For more information,
    /// see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_DHCP_Options.html">DHCP
    /// Options Sets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// You can specify the instance tenancy value for the VPC when you create it. You can't
    /// change this value for the VPC after you create it. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/dedicated-instance.html">Dedicated
    /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateVpcRequest : AmazonEC2Request
    {
        private bool? _amazonProvidedIpv6CidrBlock;
        private string _cidrBlock;
        private Tenancy _instanceTenancy;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateVpcRequest() { }

        /// <summary>
        /// Instantiates CreateVpcRequest with the parameterized properties
        /// </summary>
        /// <param name="cidrBlock">The IPv4 network range for the VPC, in CIDR notation. For example, <code>10.0.0.0/16</code>.</param>
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
        public bool AmazonProvidedIpv6CidrBlock
        {
            get { return this._amazonProvidedIpv6CidrBlock.GetValueOrDefault(); }
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
        /// The IPv4 network range for the VPC, in CIDR notation. For example, <code>10.0.0.0/16</code>.
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
        /// Gets and sets the property InstanceTenancy. 
        /// <para>
        /// The tenancy options for instances launched into the VPC. For <code>default</code>,
        /// instances are launched with shared tenancy by default. You can launch instances with
        /// any tenancy into a shared tenancy VPC. For <code>dedicated</code>, instances are launched
        /// as dedicated tenancy instances by default. You can only launch instances with a tenancy
        /// of <code>dedicated</code> or <code>host</code> into a dedicated tenancy VPC. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Important:</b> The <code>host</code> value cannot be used with this parameter.
        /// Use the <code>default</code> or <code>dedicated</code> values only.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>default</code> 
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

    }
}