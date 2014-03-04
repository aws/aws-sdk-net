using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace Amazon.EC2.Model
{
    [XmlRootAttribute(IsNullable = false)]
    public class NetworkInterfacePrivateIpAddress
    {
        private string ipAddressField;
        private string privateDnsNameField;
        private bool? primaryField;
        private NetworkInterfaceAssociation associationField;


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
        /// Private IP address.
        /// </summary>
        /// <param name="ipAddress">Private IP address.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public NetworkInterfacePrivateIpAddress WithIpAddress(string ipAddress)
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public NetworkInterfacePrivateIpAddress WithPrivateDnsName(string privateDnsName)
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public NetworkInterfacePrivateIpAddress WithPrimary(bool primary)
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
        public NetworkInterfaceAssociation Association
        {
            get { return this.associationField; }
            set { this.associationField = value; }
        }

        /// <summary>
        /// Sets the Instance Network Interface Association.
        /// </summary>
        /// <param name="association">Instance Network Interface Association.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public NetworkInterfacePrivateIpAddress WithAssociation(NetworkInterfaceAssociation association)
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
