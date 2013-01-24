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
    /// Creates a network interface in the specified subnet.
    /// </summary>
    /// <remarks>
    /// This action is supported only in Amazon VPC.
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class CreateNetworkInterfaceRequest
    {
        private string subnetIdField;
        private string descriptionField;
        private string privateIpAddressField;
        private List<string> groupIdField;
        private List<PrivateIpAddress> privateIpAddressesField;
        private int? secondaryPrivateIpAddressCountField;

        /// <summary>
        /// The ID of the subnet to associate with the network interface.
        /// </summary>
        [XmlElementAttribute(ElementName = "SubnetId")]
        public string SubnetId
        {
            get { return this.subnetIdField; }
            set { this.subnetIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the subnet to associate with the network interface.
        /// </summary>
        /// <param name="subnetId">ID of the subnet</param>
        /// <returns>this instance</returns>
        public CreateNetworkInterfaceRequest WithSubnetId(string subnetId)
        {
            this.subnetIdField = subnetId;
            return this;
        }

        /// <summary>
        /// Checks if the SubnetId property is set
        /// </summary>
        /// <returns>true if the SubnetId property is set</returns>
        public bool IsSetSubnetId()
        {
            return !string.IsNullOrEmpty(this.subnetIdField);
        }

        /// <summary>
        /// The description of the network interface.
        /// </summary>
        [XmlElementAttribute(ElementName = "Description")]
        public string Description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <summary>
        /// Sets the description of the network interface.
        /// </summary>
        /// <param name="description">Description of the network interface</param>
        /// <returns>this instance</returns>
        public CreateNetworkInterfaceRequest WithDescription(string description)
        {
            this.descriptionField = description;
            return this;
        }

        /// <summary>
        /// Checks if the Description property is set
        /// </summary>
        /// <returns>true if the Description property is set</returns>
        public bool IsSetDescription()
        {
            return !string.IsNullOrEmpty(this.descriptionField);
        }

        /// <summary>
        /// The primary private IP address of the network interface.
        /// </summary>
        [XmlElementAttribute(ElementName = "PrivateIpAddress")]
        public string PrivateIpAddress
        {
            get { return this.privateIpAddressField; }
            set { this.privateIpAddressField = value; }
        }

        /// <summary>
        /// Sets the primary private IP address of the network interface.
        /// </summary>
        /// <param name="ipAddress">IP address of the network interface</param>
        /// <returns>this instance</returns>
        public CreateNetworkInterfaceRequest WithPrivateIpAddress(string ipAddress)
        {
            this.privateIpAddressField = ipAddress;
            return this;
        }

        /// <summary>
        /// Checks if the PrivateIpAddress property is set
        /// </summary>
        /// <returns>true of the PrivateIpAddress property is set</returns>
        public bool IsSetPrivateIpAddress()
        {
            return !string.IsNullOrEmpty(this.privateIpAddressField);
        }

        /// <summary>
        /// A list of security group IDs for use by the network interface.
        /// </summary>
        [XmlElementAttribute(ElementName = "GroupId")]
        public List<string> GroupId
        {
            get 
            {
                if (this.groupIdField == null)
                {
                    this.groupIdField = new List<string>();
                }
                return this.groupIdField; 
            }
            set { this.groupIdField = value; }
        }

        /// <summary>
        /// Sets the list of security group IDs for use by the network interface.
        /// </summary>
        /// <param name="list">List of security group IDs</param>
        /// <returns>this instance</returns>
        public CreateNetworkInterfaceRequest WithGroupId(params string[] list)
        {
            foreach (string item in list)
            {
                GroupId.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if the GroupId property is set
        /// </summary>
        /// <returns>true if the GroupId is set</returns>
        public bool IsSetGroupId()
        {
            return (GroupId.Count > 0);
        }


        /// <summary>
        /// Private IP addresses.
        /// </summary>
        [XmlElementAttribute(ElementName = "PrivateIpAddresses")]
        public List<PrivateIpAddress> PrivateIpAddresses
        {
            get
            {
                if (this.privateIpAddressesField == null)
                {
                    this.privateIpAddressesField = new List<PrivateIpAddress>();
                }
                return this.privateIpAddressesField;
            }
            set { this.privateIpAddressesField = value; }
        }

        /// <summary>
        /// Sets private IP addresses.
        /// </summary>
        /// <param name="privateIpAddresses">Private IP addresses.</param>
        /// <returns>this instance</returns>
        public CreateNetworkInterfaceRequest WithPrivateIpAddresses(params PrivateIpAddress[] privateIpAddresses)
        {
            foreach (PrivateIpAddress privateIpAddress in privateIpAddresses)
            {
                PrivateIpAddresses.Add(privateIpAddress);
            }
            return this;
        }

        /// <summary>
        /// Checks if the PrivateIpAddresses property is set
        /// </summary>
        /// <returns>true if the PrivateIpAddresses property is set</returns>
        public bool IsSetPrivateIpAddresses()
        {
            return PrivateIpAddresses.Count > 0;
        }


        /// <summary>
        /// Number of secondary private IP addresses.
        /// </summary>
        [XmlElementAttribute(ElementName = "SecondaryPrivateIpAddressCount")]
        public int SecondaryPrivateIpAddressCount
        {
            get { return this.secondaryPrivateIpAddressCountField.GetValueOrDefault(); }
            set { this.secondaryPrivateIpAddressCountField = value; }
        }

        /// <summary>
        /// Sets the number of secondary private IP addresses.
        /// </summary>
        /// <param name="secondaryPrivateIpAddressCount">Number of secondary private IP addresses.</param>
        /// <returns>this instance</returns>
        public CreateNetworkInterfaceRequest WithSecondaryPrivateIpAddressCount(int secondaryPrivateIpAddressCount)
        {
            this.secondaryPrivateIpAddressCountField = secondaryPrivateIpAddressCount;
            return this;
        }

        /// <summary>
        /// Checks if the SecondaryPrivateIpAddressCount property is set
        /// </summary>
        /// <returns>true if the SecondaryPrivateIpAddressCount property is set</returns>
        public bool IsSetSecondaryPrivateIpAddressCount()
        {
            return this.secondaryPrivateIpAddressCountField != null;
        }
    }
}
