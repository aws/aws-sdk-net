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
    /// <para> Creates a VPC with the CIDR block you specify. The smallest VPC you can create uses a <c>/28</c> netmask (16 IP addresses), and the
    /// largest uses a <c>/18</c> netmask (16,384 IP addresses). To help you decide how big to make your VPC, go to the topic about creating VPCs in
    /// the Amazon Virtual Private Cloud Developer Guide. </para> <para> By default, each instance you launch in the VPC has the default DHCP
    /// options (the standard EC2 host name, no domain name, no DNS server, no NTP server, and no NetBIOS server or node type). </para>
    /// </summary>
    public partial class CreateVpcRequest : AmazonEC2Request
    {
        private string cidrBlock;
        private Tenancy instanceTenancy;


        /// <summary>
        /// A valid CIDR block.
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
        /// The allowed tenancy of instances launched into the VPC. A value of default means instances can be launched with any tenancy; a value of
        /// dedicated means instances must be launched with tenancy as dedicated.
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
    
