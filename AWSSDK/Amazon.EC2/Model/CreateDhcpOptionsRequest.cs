/*******************************************************************************
 * Copyright 2008-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Creates a set of DHCP options that you can then
    /// associate with one or more VPCs, causing all
    /// existing and new instances that you launch in those
    /// VPCs to use the set of DHCP options. The following
    /// table lists the individual DHCP options you
    /// can specify. For more information about the options, go to
    /// RFC
    /// 2132.
    ///
    /// Options:
    /// 1. domain-name
    /// A domain name of your choice (e.g., mydomain.com).
    ///
    /// 2. domain-name-servers
    /// The IP address of a domain name server (e.g., 10.2.5.1).
    /// You can specify up to four addresses.
    ///
    /// 3. ntp-servers
    /// The IP address of a Network Time Protocol (NTP)
    /// server (e.g., 10.4.6.1). You can specify up to four addresses.
    ///
    /// 4.
    /// netbios-name-servers The IP address of a NetBIOS name server (e.g.,
    /// 10.8.9.5). You can specify up to four addresses.
    ///
    /// 5.
    /// netbios-node-type Value indicating the NetBIOS node type (1, 2, 4,
    /// or 8). For more information about the values, go to RFC 2132.
    /// We recommend you only use 2 at this time (broadcast and multicast
    /// are currently not supported)
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class CreateDhcpOptionsRequest
    {    
        private List<DhcpConfiguration> dhcpConfigurationField;

        /// <summary>
        /// Gets and sets the DhcpConfiguration property.
        /// DHCP Configuration
        /// </summary>
        [XmlElementAttribute(ElementName = "DhcpConfiguration")]
        public List<DhcpConfiguration> DhcpConfiguration
        {
            get
            {
                if (this.dhcpConfigurationField == null)
                {
                    this.dhcpConfigurationField = new List<DhcpConfiguration>();
                }
                return this.dhcpConfigurationField;
            }
            set { this.dhcpConfigurationField = value; }
        }

        /// <summary>
        /// Sets the DhcpConfiguration property
        /// </summary>
        /// <param name="list">DHCP Configuration</param>
        /// <returns>this instance</returns>
        public CreateDhcpOptionsRequest WithDhcpConfiguration(params DhcpConfiguration[] list)
        {
            foreach (DhcpConfiguration item in list)
            {
                DhcpConfiguration.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if DhcpConfiguration property is set
        /// </summary>
        /// <returns>true if DhcpConfiguration property is set</returns>
        public bool IsSetDhcpConfiguration()
        {
            return (DhcpConfiguration.Count > 0);
        }

    }
}
