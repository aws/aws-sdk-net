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
 *  API Version: 2012-05-01
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Create Network Interface request
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2012-05-01/", IsNullable = false)]
    public class CreateNetworkInterfaceRequest
    {
        private string subnetIdField;
        private string descriptionField;
        private string privateIpAddressField;
        private List<string> groupIdField;

        /// <summary>
        /// Gets and sets the ID of the subnet to associate with the network interface.
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
        /// Gets and sets the description of the network interface.
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
        /// Gets and sets the private IP address of the network interface.
        /// </summary>
        [XmlElementAttribute(ElementName = "PrivateIpAddress")]
        public string PrivateIpAddress
        {
            get { return this.privateIpAddressField; }
            set { this.privateIpAddressField = value; }
        }

        /// <summary>
        /// Sets the private IP address of the network interface.
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
        /// Gets and sets the list of security group IDs for use by the network interface.
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
    }
}
