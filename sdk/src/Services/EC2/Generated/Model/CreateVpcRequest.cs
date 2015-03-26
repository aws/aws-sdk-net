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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
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
    /// Creates a VPC with the specified CIDR block.
    /// 
    ///  
    /// <para>
    /// The smallest VPC you can create uses a /28 netmask (16 IP addresses), and the largest
    /// uses a /16 netmask (65,536 IP addresses). To help you decide how big to make your
    /// VPC, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Subnets.html">Your
    /// VPC and Subnets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// By default, each instance you launch in the VPC has the default DHCP options, which
    /// includes only a default DNS server that we provide (AmazonProvidedDNS). For more information
    /// about DHCP options, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_DHCP_Options.html">DHCP
    /// Options Sets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateVpcRequest : AmazonEC2Request
    {
        private string _cidrBlock;
        private Tenancy _instanceTenancy;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateVpcRequest() { }

        /// <summary>
        /// Instantiates CreateVpcRequest with the parameterized properties
        /// </summary>
        /// <param name="cidrBlock">The network range for the VPC, in CIDR notation. For example, <code>10.0.0.0/16</code>.</param>
        public CreateVpcRequest(string cidrBlock)
        {
            _cidrBlock = cidrBlock;
        }

        /// <summary>
        /// Gets and sets the property CidrBlock. 
        /// <para>
        /// The network range for the VPC, in CIDR notation. For example, <code>10.0.0.0/16</code>.
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
        /// The supported tenancy options for instances launched into the VPC. A value of <code>default</code>
        /// means that instances can be launched with any tenancy; a value of <code>dedicated</code>
        /// means all instances launched into the VPC are launched as dedicated tenancy instances
        /// regardless of the tenancy assigned to the instance at launch. Dedicated tenancy instances
        /// run on single-tenant hardware.
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