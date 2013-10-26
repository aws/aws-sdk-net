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
    /// <para> Creates a set of DHCP options that you can then associate with one or more VPCs, causing all existing and new instances that you
    /// launch in those VPCs to use the set of DHCP options. The following table lists the individual DHCP options you can specify. For more
    /// information about the options, go to <a href="http://www.ietf.org/rfc/rfc2132.txt" >http://www.ietf.org/rfc/rfc2132.txt</a> </para>
    /// </summary>
    public partial class CreateDhcpOptionsRequest : AmazonEC2Request
    {
        private List<DhcpConfiguration> dhcpConfigurations = new List<DhcpConfiguration>();


        /// <summary>
        /// A set of one or more DHCP configurations.
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
    
