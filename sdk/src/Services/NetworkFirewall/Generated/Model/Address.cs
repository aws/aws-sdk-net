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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// A single IP address specification. This is used in the <a>MatchAttributes</a> source
    /// and destination specifications.
    /// </summary>
    public partial class Address
    {
        private string _addressDefinition;

        /// <summary>
        /// Gets and sets the property AddressDefinition. 
        /// <para>
        /// Specify an IP address or a block of IP addresses in Classless Inter-Domain Routing
        /// (CIDR) notation. Network Firewall supports all address ranges for IPv4 and IPv6. 
        /// </para>
        ///  
        /// <para>
        /// Examples: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To configure Network Firewall to inspect for the IP address 192.0.2.44, specify <code>192.0.2.44/32</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To configure Network Firewall to inspect for IP addresses from 192.0.2.0 to 192.0.2.255,
        /// specify <code>192.0.2.0/24</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To configure Network Firewall to inspect for the IP address 1111:0000:0000:0000:0000:0000:0000:0111,
        /// specify <code>1111:0000:0000:0000:0000:0000:0000:0111/128</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To configure Network Firewall to inspect for IP addresses from 1111:0000:0000:0000:0000:0000:0000:0000
        /// to 1111:0000:0000:0000:ffff:ffff:ffff:ffff, specify <code>1111:0000:0000:0000:0000:0000:0000:0000/64</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about CIDR notation, see the Wikipedia entry <a href="https://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Classless
        /// Inter-Domain Routing</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string AddressDefinition
        {
            get { return this._addressDefinition; }
            set { this._addressDefinition = value; }
        }

        // Check to see if AddressDefinition property is set
        internal bool IsSetAddressDefinition()
        {
            return this._addressDefinition != null;
        }

    }
}