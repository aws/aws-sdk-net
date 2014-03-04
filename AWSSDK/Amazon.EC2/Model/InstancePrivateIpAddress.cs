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
        private string privateDnsNameField;
        private bool? primaryField;
        private InstanceNetworkInterfaceAssociation associationField;


        /// <summary>
        /// Private IP address.
        /// </summary>
        [XmlElementAttribute(ElementName = "IpAddress")]
        public string IpAddress
        {
            get { return this.ipAddressField; }
            set { this.ipAddressField = value; }
        }

        /// <summary>
        /// Sets the private IP address.
        /// </summary>
        /// <param name="ipAddress">Private IP address.</param>
        /// <returns>this instance</returns>
        [System.Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        /// Private DNS name.
        /// </summary>
        [XmlElementAttribute(ElementName = "PrivateDnsName")]
        public string PrivateDnsName
        {
            get { return this.privateDnsNameField; }
            set { this.privateDnsNameField = value; }
        }

        /// <summary>
        /// Sets the private DNS name.
        /// </summary>
        /// <param name="privateDnsName">Private DNS name.</param>
        /// <returns>this instance</returns>
        [System.Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstancePrivateIpAddress WithPrivateDnsName(string privateDnsName)
        {
            this.privateDnsNameField = privateDnsName;
            return this;
        }

        /// <summary>
        /// Checks if the PrivateDnsName property is set
        /// </summary>
        /// <returns>true if the PrivateDnsName property is set</returns>
        public bool IsSetPrivateDnsName()
        {
            return !string.IsNullOrEmpty(this.privateDnsNameField);
        }


        /// <summary>
        /// Whether this is a primary IP.
        /// </summary>
        [XmlElementAttribute(ElementName = "Primary")]
        public bool Primary
        {
            get { return this.primaryField.GetValueOrDefault(); }
            set { this.primaryField = value; }
        }

        /// <summary>
        /// Sets whether this is a primary IP.
        /// </summary>
        /// <param name="primary">Whether this is a primary IP.</param>
        /// <returns>this instance</returns>
        [System.Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        /// Instance Network Interface Association.
        /// </summary>
        [XmlElementAttribute(ElementName = "Association")]
        public InstanceNetworkInterfaceAssociation Association
        {
            get { return this.associationField; }
            set { this.associationField = value; }
        }

        /// <summary>
        /// Sets the Instance Network Interface Association.
        /// </summary>
        /// <param name="association">Instance Network Interface Association.</param>
        /// <returns>this instance</returns>
        [System.Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
