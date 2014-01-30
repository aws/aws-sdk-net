/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para>Creates a VPC with the specified CIDR block.</para> <para>The smallest VPC you can create uses a /28 netmask (16 IP addresses), and
    /// the largest uses a /16 netmask (65,536 IP addresses). To help you decide how big to make your VPC, see <a
    /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Subnets.html" >Your VPC and Subnets</a> in the <i>Amazon Virtual Private
    /// Cloud User Guide</i> .</para> <para>By default, each instance you launch in the VPC has the default DHCP options, which includes only a
    /// default DNS server that we provide (AmazonProvidedDNS). For more information about DHCP options, see <a
    /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_DHCP_Options.html" >DHCP Options Sets</a> in the <i>Amazon Virtual Private
    /// Cloud User Guide</i> .</para>
    /// </summary>
    public partial class CreateVpcRequest : AmazonEC2Request
    {
        private string cidrBlock;
        private Tenancy instanceTenancy;


        /// <summary>
        /// The network range for the VPC, in CIDR notation. For example, <c>10.0.0.0/16</c>.
        ///  
        /// </summary>
        public string CidrBlock
        {
            get { return this.cidrBlock; }
            set { this.cidrBlock = value; }
        }

        // Check to see if CidrBlock property is set
        internal bool IsSetCidrBlock()
        {
            return this.cidrBlock != null;
        }

        /// <summary>
        /// The supported tenancy options for instances launched into the VPC. A value of <c>default</c> means that instances can be launched with any
        /// tenancy; a value of <c>dedicated</c> means all instances launched into the VPC are launched as dedicated tenancy instances regardless of the
        /// tenancy assigned to the instance at launch. Dedicated tenancy instances runs on single-tenant hardware. Default: <c>default</c>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>default, dedicated</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public Tenancy InstanceTenancy
        {
            get { return this.instanceTenancy; }
            set { this.instanceTenancy = value; }
        }

        // Check to see if InstanceTenancy property is set
        internal bool IsSetInstanceTenancy()
        {
            return this.instanceTenancy != null;
        }

    }
}
    
