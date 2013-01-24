/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Associates a set of DHCP options (that you've previously created) with the
    /// specified VPC. Or, associates the default DHCP options with the VPC.
    /// </summary>
    /// <remarks>
    /// The default set consists of the standard EC2 host name, no domain name, no
    /// DNS server, no NTP server, and no NetBIOS server or node type.
    ///
    /// After you associate the options with the VPC, any existing instances
    /// and all new instances that you launch in that VPC use the options. For more
    /// information about the supported DHCP options and using them with
    /// Amazon VPC, go to Using DHCP Options in the Amazon Virtual Private Cloud
    /// Developer Guide.
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class AssociateDhcpOptionsRequest
    {    
        private string dhcpOptionsIdField;
        private string vpcIdField;

        /// <summary>
        /// The ID of the DHCP options you want to associate with the VPC, or
        /// "default" if you want to associate the default DHCP options with the VPC.
        /// </summary>
        [XmlElementAttribute(ElementName = "DhcpOptionsId")]
        public string DhcpOptionsId
        {
            get { return this.dhcpOptionsIdField; }
            set { this.dhcpOptionsIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the DHCP options you want to associate with the VPC.
        /// </summary>
        /// <param name="dhcpOptionsId">The ID of the DHCP options you want to associate with the VPC, or
        /// "default" if you want to associate the default DHCP options with the VPC.</param>
        /// <returns>this instance</returns>
        public AssociateDhcpOptionsRequest WithDhcpOptionsId(string dhcpOptionsId)
        {
            this.dhcpOptionsIdField = dhcpOptionsId;
            return this;
        }

        /// <summary>
        /// Checks if DhcpOptionsId property is set
        /// </summary>
        /// <returns>true if DhcpOptionsId property is set</returns>
        public bool IsSetDhcpOptionsId()
        {
            return this.dhcpOptionsIdField != null;
        }

        /// <summary>
        /// The ID of the VPC you want to associate the DHCP options with.
        /// </summary>
        [XmlElementAttribute(ElementName = "VpcId")]
        public string VpcId
        {
            get { return this.vpcIdField; }
            set { this.vpcIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the VPC you want to associate the DHCP options with.
        /// </summary>
        /// <param name="vpcId">The ID of the VPC you want to associate the DHCP options with.</param>
        /// <returns>this instance</returns>
        public AssociateDhcpOptionsRequest WithVpcId(string vpcId)
        {
            this.vpcIdField = vpcId;
            return this;
        }

        /// <summary>
        /// Checks if VpcId property is set
        /// </summary>
        /// <returns>true if VpcId property is set</returns>
        public bool IsSetVpcId()
        {
            return this.vpcIdField != null;
        }

    }
}
