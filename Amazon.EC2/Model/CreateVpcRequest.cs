/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2010-06-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Creates a VPC with the CIDR block you specify.
    /// The smallest VPC you can create uses a /28 netmask (16 IP
    /// addresses), and the largest uses a /18 netmask (16,384 IP addresses).
    /// To help you decide how big to make your VPC, go to the
    /// topic about creating VPCs in the Amazon Virtual Private Cloud
    /// Developer Guide.
    ///
    /// By default, each instance you launch in the VPC has the default DHCP
    /// options (the standard EC2 host name, no domain name, no DNS server, no NTP
    /// server, and no NetBIOS server or node type).
    ///
    /// AWS might delete any VPC that you create with this operation
    /// if you leave it inactive for an extended period of time (inactive
    /// means that there are no running Amazon EC2 instances in the VPC).
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2010-06-15/", IsNullable = false)]
    public class CreateVpcRequest
    {    
        private string cidrBlockField;

        /// <summary>
        /// Gets and sets the CidrBlock property.
        /// A valid CIDR block.
        ///
        /// Constraints: Must contain the slash followed by one or two digits (e.g., /28)
        /// </summary>
        [XmlElementAttribute(ElementName = "CidrBlock")]
        public string CidrBlock
        {
            get { return this.cidrBlockField; }
            set { this.cidrBlockField = value; }
        }

        /// <summary>
        /// Sets the CidrBlock property
        /// </summary>
        /// <param name="cidrBlock">A valid CIDR block.
        ///
        /// Constraints: Must contain the slash followed by one or two digits (e.g., /28)</param>
        /// <returns>this instance</returns>
        public CreateVpcRequest WithCidrBlock(string cidrBlock)
        {
            this.cidrBlockField = cidrBlock;
            return this;
        }

        /// <summary>
        /// Checks if CidrBlock property is set
        /// </summary>
        /// <returns>true if CidrBlock property is set</returns>
        public bool IsSetCidrBlock()
        {
            return this.cidrBlockField != null;
        }

    }
}
