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
        private bool? primaryField;
        private NetworkInterfaceAssociation associationField;


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
        /// Gets and sets the Association property.
        /// Instance Network Interface Association.
        /// </summary>
        [XmlElementAttribute(ElementName = "Association")]
        public NetworkInterfaceAssociation Association
        {
            get { return this.associationField; }
            set { this.associationField = value; }
        }

        /// <summary>
        /// Sets the Association property
        /// </summary>
        /// <param name="association">Instance Network Interface Association.</param>
        /// <returns>this instance</returns>
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
