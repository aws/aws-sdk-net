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
    /// Container for the parameters to the CreateDhcpOptions operation.
    /// <para>Creates a set of DHCP options for your VPC. After creating the set, you must associate it with the VPC, causing all existing and new
    /// instances that you launch in the VPC to use this set of DHCP options. The following are the individual DHCP options you can specify. For
    /// more information about the options, see <a href="http://www.ietf.org/rfc/rfc2132.txt" >RFC 2132</a> .</para> <para>For more information
    /// about DHCP options, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_DHCP_Options.html" >DHCP Options Sets</a> in the
    /// <i>Amazon Virtual Private Cloud User Guide</i> .</para>
    /// </summary>
    public partial class CreateDhcpOptionsRequest : AmazonEC2Request
    {
        private List<DhcpConfiguration> dhcpConfigurations = new List<DhcpConfiguration>();


        /// <summary>
        /// A DHCP configuration option.
        ///  
        /// </summary>
        public List<DhcpConfiguration> DhcpConfigurations
        {
            get { return this.dhcpConfigurations; }
            set { this.dhcpConfigurations = value; }
        }

        // Check to see if DhcpConfigurations property is set
        internal bool IsSetDhcpConfigurations()
        {
            return this.dhcpConfigurations.Count > 0;
        }

    }
}
    
