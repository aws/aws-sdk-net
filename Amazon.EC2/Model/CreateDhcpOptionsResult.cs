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
    /// Create Dhcp Options Result
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2009-11-30/", IsNullable = false)]
    public class CreateDhcpOptionsResult
    {
        private DhcpOptions dhcpOptionsField;

        /// <summary>
        /// Gets and sets the DhcpOptions property.
        /// Dhcp options
        /// </summary>
        [XmlElementAttribute(ElementName = "DhcpOptions")]
        public DhcpOptions DhcpOptions
        {
            get { return this.dhcpOptionsField; }
            set { this.dhcpOptionsField = value; }
        }

        /// <summary>
        /// Sets the DhcpOptions property
        /// </summary>
        /// <param name="dhcpOptions">Dhcp options</param>
        /// <returns>this instance</returns>
        public CreateDhcpOptionsResult WithDhcpOptions(DhcpOptions dhcpOptions)
        {
            this.dhcpOptionsField = dhcpOptions;
            return this;
        }

        /// <summary>
        /// Checks if DhcpOptions property is set
        /// </summary>
        /// <returns>true if DhcpOptions property is set</returns>
        public bool IsSetDhcpOptions()
        {
            return this.dhcpOptionsField != null;
        }

    }
}
