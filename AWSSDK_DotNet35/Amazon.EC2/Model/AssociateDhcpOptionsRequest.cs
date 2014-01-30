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
    /// Container for the parameters to the AssociateDhcpOptions operation.
    /// <para>Associates a set of DHCP options (that you've previously created) with the specified VPC, or associates no DHCP options with the
    /// VPC.</para> <para>After you associate the options with the VPC, any existing instances and all new instances that you launch in that VPC use
    /// the options. You don't need to restart or relaunch the instances. They automatically pick up the changes within a few hours, depending on
    /// how frequently the instance renews its DHCP lease. You can explicitly renew the lease using the operating system on the instance.</para>
    /// <para>For more information, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_DHCP_Options.html" >DHCP Options Sets</a>
    /// in the <i>Amazon Virtual Private Cloud User Guide</i> .</para>
    /// </summary>
    public partial class AssociateDhcpOptionsRequest : AmazonEC2Request
    {
        private string dhcpOptionsId;
        private string vpcId;


        /// <summary>
        /// The ID of the DHCP options set, or <c>default</c> to associate no DHCP options with the VPC.
        ///  
        /// </summary>
        public string DhcpOptionsId
        {
            get { return this.dhcpOptionsId; }
            set { this.dhcpOptionsId = value; }
        }

        // Check to see if DhcpOptionsId property is set
        internal bool IsSetDhcpOptionsId()
        {
            return this.dhcpOptionsId != null;
        }

        /// <summary>
        /// The ID of the VPC.
        ///  
        /// </summary>
        public string VpcId
        {
            get { return this.vpcId; }
            set { this.vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this.vpcId != null;
        }

    }
}
    
