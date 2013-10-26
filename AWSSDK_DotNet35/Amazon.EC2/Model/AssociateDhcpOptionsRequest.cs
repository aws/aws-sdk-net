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
    /// <para> Associates a set of DHCP options (that you've previously created) with the specified VPC. Or, associates the default DHCP options
    /// with the VPC. The default set consists of the standard EC2 host name, no domain name, no DNS server, no NTP server, and no NetBIOS server or
    /// node type. After you associate the options with the VPC, any existing instances and all new instances that you launch in that VPC use the
    /// options. For more information about the supported DHCP options and using them with Amazon VPC, go to Using DHCP Options in the Amazon
    /// Virtual Private Cloud Developer Guide. </para>
    /// </summary>
    public partial class AssociateDhcpOptionsRequest : AmazonEC2Request
    {
        private string dhcpOptionsId;
        private string vpcId;


        /// <summary>
        /// The ID of the DHCP options to associate with the VPC. Specify "default" to associate the default DHCP options with the VPC.
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
        /// The ID of the VPC to associate the DHCP options with.
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
    
