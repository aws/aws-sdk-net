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
    /// Reset Network Interface Attribute request
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class ResetNetworkInterfaceAttributeRequest
    {
        private string networkInterfaceIdField;
        private string attributeField;

        /// <summary>
        /// ID of the network interface on which the attribute will be reset.
        /// </summary>
        [XmlElementAttribute(ElementName = "NetworkInterfaceId")]
        public string NetworkInterfaceId
        {
            get { return this.networkInterfaceIdField; }
            set { this.networkInterfaceIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the network interface on which the attribute will be reset.
        /// </summary>
        /// <param name="networkInterfaceId">Network Interface ID</param>
        /// <returns>this instance</returns>
        public ResetNetworkInterfaceAttributeRequest WithNetworkInterfaceId(string networkInterfaceId)
        {
            this.networkInterfaceIdField = networkInterfaceId;
            return this;
        }

        /// <summary>
        /// Checks if NetworkInterfaceId property is set
        /// </summary>
        /// <returns>true if NetworkInterfaceId property is set</returns>
        public bool IsSetNetworkInterfaceId()
        {
            return !string.IsNullOrEmpty(this.networkInterfaceIdField);
        }

        /// <summary>
        /// Name of the attribute to reset.
        /// </summary>
        [XmlElementAttribute(ElementName = "Attribute")]
        public string Attribute
        {
            get { return this.attributeField; }
            set { this.attributeField = value; }
        }

        /// <summary>
        /// Sets the name of the attribute to reset.
        /// </summary>
        /// <param name="attribute">Name of the attribute to reset.
        /// If not set, defaults to sourceDestCheck.
        /// </param>
        /// <returns>this instance</returns>
        public ResetNetworkInterfaceAttributeRequest WithAttribute(string attribute)
        {
            this.attributeField = attribute;
            return this;
        }

        /// <summary>
        /// Checks if the Attribute property is set
        /// </summary>
        /// <returns>true if the Attribute property is set</returns>
        public bool IsSetAttribute()
        {
            return !string.IsNullOrEmpty(this.attributeField);
        }

    }
}
