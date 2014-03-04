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
    /// DHCP Configuration
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class DhcpConfiguration
    {    
        private string keyField;
        private List<string> valueField;

        /// <summary>
        /// The name of a DHCP option.
        /// </summary>
        [XmlElementAttribute(ElementName = "Key")]
        public string Key
        {
            get { return this.keyField; }
            set { this.keyField = value; }
        }

        /// <summary>
        /// Sets the name of a DHCP option.
        /// </summary>
        /// <param name="key">The name of a DHCP option.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DhcpConfiguration WithKey(string key)
        {
            this.keyField = key;
            return this;
        }

        /// <summary>
        /// Checks if Key property is set
        /// </summary>
        /// <returns>true if Key property is set</returns>
        public bool IsSetKey()
        {
            return this.keyField != null;
        }

        /// <summary>
        /// Values for the DHCP option.
        /// </summary>
        [XmlElementAttribute(ElementName = "Value")]
        public List<string> Value
        {
            get
            {
                if (this.valueField == null)
                {
                    this.valueField = new List<string>();
                }
                return this.valueField;
            }
            set { this.valueField = value; }
        }

        /// <summary>
        /// Sets the values for the DHCP option.
        /// </summary>
        /// <param name="list">A value for the DHCP option.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DhcpConfiguration WithValue(params string[] list)
        {
            foreach (string item in list)
            {
                Value.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Value property is set
        /// </summary>
        /// <returns>true if Value property is set</returns>
        public bool IsSetValue()
        {
            return (Value.Count > 0);
        }

    }
}
