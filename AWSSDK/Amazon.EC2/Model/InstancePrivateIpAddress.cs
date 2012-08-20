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

using System.Xml.Serialization;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Instance Private Ip Address
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class InstancePrivateIpAddress
    {
        private string ipAddressField;
        private bool? primaryField;
        private InstanceNetworkInterfaceAssociation associationField;


        /// <summary>
        /// Gets and sets the IpAddress property.
        /// Private IP address.
        /// </summary>
        [XmlElementAttribute(ElementName = "IpAddress")]
        public string IpAddress
        {
            get { return this.ipAddressField; }
            set { this.ipAddressField = value; }
        }

        /// <summary>
        /// Sets the IpAddress property
        /// </summary>
        /// <param name="ipAddress">Private IP address.</param>
        /// <returns>this instance</returns>
        public InstancePrivateIpAddress WithIpAddress(string ipAddress)
        {
            this.ipAddressField = ipAddress;
            return this;
        }

        /// <summary>
        /// Checks if the IpAddress property is set
        /// </summary>
        /// <returns>true if the IpAddress property is set</returns>
        public bool IsSetIpAddress()
        {
            return !string.IsNullOrEmpty(this.ipAddressField);
        }


        /// <summary>
        /// Gets and sets the Primary property.
        /// Whether this is a primary IP.
        /// </summary>
        [XmlElementAttribute(ElementName = "Primary")]
        public bool Primary
        {
            get { return this.primaryField.GetValueOrDefault(); }
            set { this.primaryField = value; }
        }

        /// <summary>
        /// Sets the Primary property
        /// </summary>
        /// <param name="primary">Whether this is a primary IP.</param>
        /// <returns>this instance</returns>
        public InstancePrivateIpAddress WithPrimary(bool primary)
        {
            this.primaryField = primary;
            return this;
        }

        /// <summary>
        /// Checks if the Primary property is set
        /// </summary>
        /// <returns>true if the Primary property is set</returns>
        public bool IsSetPrimary()
        {
            return this.primaryField != null;
        }


        /// <summary>
        /// Gets and sets the Association property.
        /// Instance Network Interface Association.
        /// </summary>
        [XmlElementAttribute(ElementName = "Association")]
        public InstanceNetworkInterfaceAssociation Association
        {
            get { return this.associationField; }
            set { this.associationField = value; }
        }

        /// <summary>
        /// Sets the Association property
        /// </summary>
        /// <param name="association">Instance Network Interface Association.</param>
        /// <returns>this instance</returns>
        public InstancePrivateIpAddress WithAssociation(InstanceNetworkInterfaceAssociation association)
        {
            this.associationField = association;
            return this;
        }

        /// <summary>
        /// Checks if the Association property is set
        /// </summary>
        /// <returns>true if the Association property is set</returns>
        public bool IsSetAssociation()
        {
            return this.associationField != null;
        }
    }
}
