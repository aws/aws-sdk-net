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
    /// Instance Network Interface Specification
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class InstanceNetworkInterfaceSpecification
    {
        private string networkInterfaceIdField;
        private int? deviceIndexField;
        private string subnetIdField;
        private string descriptionField;
        private string privateIpAddressField;
        private List<string> groupIdField;
        private bool? deleteOnTerminationField;
        private List<PrivateIpAddress> privateIpAddressesField;
        private int? secondaryPrivateIpAddressCountField;

        /// <summary>
        /// The ID of the network interface.
        /// </summary>
        [XmlElementAttribute(ElementName = "NetworkInterfaceId")]
        public string NetworkInterfaceId
        {
            get { return this.networkInterfaceIdField; }
            set { this.networkInterfaceIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the network interface.
        /// </summary>
        /// <param name="networkInterfaceId">The network interface ID.</param>
        /// <returns>this instance</returns>
        public InstanceNetworkInterfaceSpecification WithNetworkInterfaceId(string networkInterfaceId)
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
            return this.networkInterfaceIdField != null;
        }

        /// <summary>
        /// The index of the device on the instance for the network interface attachment.
        /// </summary>
        [XmlElementAttribute(ElementName = "DeviceIndex")]
        public int DeviceIndex
        {
            get { return this.deviceIndexField.GetValueOrDefault(); }
            set { this.deviceIndexField = value; }
        }

        /// <summary>
        /// Sets the index of the device on the instance for the network interface attachment.
        /// </summary>
        /// <param name="deviceIndex">The index of the device on the instance for the network interface attachment.</param>
        /// <returns>this instance</returns>
        public InstanceNetworkInterfaceSpecification WithDeviceIndex(int deviceIndex)
        {
            this.deviceIndexField = deviceIndex;
            return this;
        }

        /// <summary>
        /// Checks if the DeviceIndex property is set
        /// </summary>
        /// <returns>true if the DeviceIndex property is set</returns>
        public bool IsSetDeviceIndex()
        {
            return this.deviceIndexField != null;
        }

        /// <summary>
        /// The ID of the subnet.
        /// </summary>
        [XmlElementAttribute(ElementName = "SubnetId")]
        public string SubnetId
        {
            get { return this.subnetIdField; }
            set { this.subnetIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the subnet.
        /// </summary>
        /// <param name="subnetId">The ID of the subnet associated with the network string.</param>
        /// <returns>this instance</returns>
        public InstanceNetworkInterfaceSpecification WithSubnetId(string subnetId)
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
        /// <param name="description">The description of the network interface.</param>
        /// <returns>this instance</returns>
        public InstanceNetworkInterfaceSpecification WithDescription(string description)
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
        /// The private IP address of the network interface.
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
        public InstanceNetworkInterfaceSpecification WithPrivateIpAddress(string ipAddress)
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
        /// The group IDs for use by the network interface.
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
        /// Sets the group IDs for use by the network interface.
        /// </summary>
        /// <param name="list">The group IDs for use by the network interface.</param>
        /// <returns>this instance</returns>
        public InstanceNetworkInterfaceSpecification WithGroupId(params string[] list)
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
        /// Whether the interface will be deleted when the instance is terminated.
        /// </summary>
        [XmlElementAttribute(ElementName = "DeleteOnTermination")]
        public bool DeleteOnTermination
        {
            get { return this.deleteOnTerminationField.GetValueOrDefault(); }
            set { this.deleteOnTerminationField = value; }
        }

        /// <summary>
        /// Sets whether the interface will be deleted when the instance is terminated.
        /// </summary>
        /// <param name="deleteOnTermination">true to delete the interface when the instance is terminated</param>
        /// <returns>this instance</returns>
        public InstanceNetworkInterfaceSpecification WithDeleteOnTermination(bool deleteOnTermination)
        {
            this.deleteOnTerminationField = deleteOnTermination;
            return this;
        }

        /// <summary>
        /// Checks if the DeleteOnTermination property is set
        /// </summary>
        /// <returns>true if the DeleteOnTermination property is set</returns>
        public bool IsSetDeleteOnTermination()
        {
            return this.deleteOnTerminationField != null;
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
        public InstanceNetworkInterfaceSpecification WithPrivateIpAddresses(params PrivateIpAddress[] privateIpAddresses)
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
        public InstanceNetworkInterfaceSpecification WithSecondaryPrivateIpAddressCount(int secondaryPrivateIpAddressCount)
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
