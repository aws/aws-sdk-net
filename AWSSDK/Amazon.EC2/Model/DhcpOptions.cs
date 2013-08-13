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
    /// DHCP Options
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class DhcpOptions
    {    
        private string dhcpOptionsIdField;
        private List<DhcpConfiguration> configurationField;
        private List<Tag> tagField;

        /// <summary>
        /// The ID of the set of DHCP options
        /// </summary>
        [XmlElementAttribute(ElementName = "DhcpOptionsId")]
        public string DhcpOptionsId
        {
            get { return this.dhcpOptionsIdField; }
            set { this.dhcpOptionsIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the set of DHCP options
        /// </summary>
        /// <param name="dhcpOptionsId">The ID of the set of DHCP options</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DhcpOptions WithDhcpOptionsId(string dhcpOptionsId)
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
        /// Information about the set of DHCP options
        /// </summary>
        [XmlElementAttribute(ElementName = "Configuration")]
        public List<DhcpConfiguration> Configuration
        {
            get
            {
                if (this.configurationField == null)
                {
                    this.configurationField = new List<DhcpConfiguration>();
                }
                return this.configurationField;
            }
            set { this.configurationField = value; }
        }

        /// <summary>
        /// Sets the information about the set of DHCP options
        /// </summary>
        /// <param name="list">Information about the set of DHCP options</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DhcpOptions WithConfiguration(params DhcpConfiguration[] list)
        {
            foreach (DhcpConfiguration item in list)
            {
                Configuration.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Configuration property is set
        /// </summary>
        /// <returns>true if Configuration property is set</returns>
        public bool IsSetConfiguration()
        {
            return (Configuration.Count > 0);
        }

        /// <summary>
        /// List of tags for the DhcpOptions.
        /// </summary>
        [XmlElementAttribute(ElementName = "Tag")]
        public List<Tag> Tag
        {
            get
            {
                if (this.tagField == null)
                {
                    this.tagField = new List<Tag>();
                }
                return this.tagField;
            }
            set { this.tagField = value; }
        }

        /// <summary>
        /// Sets the list of tags for the DhcpOptions.
        /// </summary>
        /// <param name="list">A list of tags for the DhcpOptions.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DhcpOptions WithTag(params Tag[] list)
        {
            foreach (Tag item in list)
            {
                Tag.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Tag property is set
        /// </summary>
        /// <returns>true if Tag property is set</returns>
        public bool IsSetTag()
        {
            return (Tag.Count > 0);
        }

    }
}
