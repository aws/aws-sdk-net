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
 *  API Version: 2009-11-30
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Gives you information about one or more sets of DHCP options. You can specify one or
    /// more DHCP options set IDs, or no IDs (to describe all your sets of DHCP options).
    /// The returned information consists of:
    /// 1. The DHCP options set ID
    /// 2. The options
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2009-11-30/", IsNullable = false)]
    public class DescribeDhcpOptionsRequest
    {
        private List<string> dhcpOptionsIdField;

        /// <summary>
        /// Gets and sets the DhcpOptionsId property.
        /// A DHCP options set ID.
        /// </summary>
        [XmlElementAttribute(ElementName = "DhcpOptionsId")]
        public List<string> DhcpOptionsId
        {
            get
            {
                if (this.dhcpOptionsIdField == null)
                {
                    this.dhcpOptionsIdField = new List<string>();
                }
                return this.dhcpOptionsIdField;
            }
            set { this.dhcpOptionsIdField = value; }
        }

        /// <summary>
        /// Sets the DhcpOptionsId property
        /// </summary>
        /// <param name="list">A DHCP options set ID.</param>
        /// <returns>this instance</returns>
        public DescribeDhcpOptionsRequest WithDhcpOptionsId(params string[] list)
        {
            foreach (string item in list)
            {
                DhcpOptionsId.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if DhcpOptionsId property is set
        /// </summary>
        /// <returns>true if DhcpOptionsId property is set</returns>
        public bool IsSetDhcpOptionsId()
        {
            return (DhcpOptionsId.Count > 0);
        }

    }
}
