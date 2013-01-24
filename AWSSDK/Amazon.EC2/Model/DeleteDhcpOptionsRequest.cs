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
    /// Deletes a set of DHCP options that you specify.
    /// </summary>
    /// <remarks>
    /// Amazon VPC returns an error if the set of options
    /// you specify is currently associated with a VPC.
    /// You can disassociate the set of options by associating
    /// either a new set of options or the default options
    /// with the VPC.
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class DeleteDhcpOptionsRequest
    {    
        private string dhcpOptionsIdField;

        /// <summary>
        /// The ID of the DHCP options set you want to delete.
        /// </summary>
        [XmlElementAttribute(ElementName = "DhcpOptionsId")]
        public string DhcpOptionsId
        {
            get { return this.dhcpOptionsIdField; }
            set { this.dhcpOptionsIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the DHCP options set you want to delete.
        /// </summary>
        /// <param name="dhcpOptionsId">The ID of the DHCP options set you want to
        /// delete.</param>
        /// <returns>this instance</returns>
        public DeleteDhcpOptionsRequest WithDhcpOptionsId(string dhcpOptionsId)
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

    }
}
