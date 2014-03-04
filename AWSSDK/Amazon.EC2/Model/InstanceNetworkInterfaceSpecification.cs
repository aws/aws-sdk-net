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
        private bool? associatePublicIpAddress;
        private bool? deleteOnTerminationField;
        private string descriptionField;
        private int? deviceIndexField;
        private List<string> groupIdField;
        private string networkInterfaceIdField;
        private string privateIpAddressField;
        private List<PrivateIpAddress> privateIpAddressesField;
        private int? secondaryPrivateIpAddressCountField;
        private string subnetIdField;


        /// <summary>
        /// Indicates whether to assign a public IP address to an instance in a VPC.        
        /// </summary>
        /// <remarks>
        /// <para>The public IP address is associated with a specific network interface. 
        /// If set to <b>true</b>, the following rules apply:</para>
        /// <ol>
        /// <li>
        /// <p>Can only be associated with a single network interface with
        /// the device index of 0. You can't associate a public IP address
        /// with a second network interface, and you can't associate a
        /// public IP address if you are launching more than one network
        /// interface.</p>
        /// </li>
        /// <li>
        /// <p>Can only be associated with a new network interface, 
        /// not an existing one.</p>
        /// </li>
        /// </ol>
        /// <p>
        /// Default: If launching into a default subnet, the default value is <b>true</b>.
        /// If launching into a nondefault subnet, the default value is <b>false</b>. 
        /// </p>
        /// </remarks>
        [XmlElementAttribute(ElementName = "AssociatePublicIpAddress")]
        public bool AssociatePublicIpAddress
        {
            get { return this.associatePublicIpAddress.GetValueOrDefault(); }
            set { this.associatePublicIpAddress = value; }
        }

        /// <summary>
        /// Indicates whether to assign a public IP address to an instance in a VPC.        
        /// </summary>
        /// <remarks>
        /// <para>The public IP address is associated with a specific network interface. 
        /// If set to <b>true</b>, the following rules apply:</para>
        /// <ol>
        /// <li>
        /// <p>Can only be associated with a single network interface with
        /// the device index of 0. You can't associate a public IP address
        /// with a second network interface, and you can't associate a
        /// public IP address if you are launching more than one network
        /// interface.</p>
        /// </li>
        /// <li>
        /// <p>Can only be associated with a new network interface, 
        /// not an existing one.</p>
        /// </li>
        /// </ol>
        /// <p>
        /// Default: If launching into a default subnet, the default value is <b>true</b>.
        /// If launching into a nondefault subnet, the default value is <b>false</b>. 
        /// </p>
        /// </remarks>
        /// <param name="associatePublicIpAddress">Indicates whether to assign a public IP address to an instance in a VPC.</param>
        /// <returns>this instance</returns>
        public InstanceNetworkInterfaceSpecification WithAssociatePublicIpAddress(bool associatePublicIpAddress)
        {
            this.associatePublicIpAddress = associatePublicIpAddress;
            return this;
        }

        /// <summary>
        /// Checks if the AssociatePublicIpAddress property is set.
        /// </summary>
        /// <returns>true if the AssociatePublicIpAddress property is set.</returns>
        public bool IsSetAssociatePublicIpAddress()
        {
            return this.associatePublicIpAddress != null;
        }

        /// <summary>
        /// An existing interface to attach to a single instance. Requires n=1 instances.
        /// </summary>
        [XmlElementAttribute(ElementName = "NetworkInterfaceId")]
        public string NetworkInterfaceId
        {
            get { return this.networkInterfaceIdField; }
            set { this.networkInterfaceIdField = value; }
        }

        /// <summary>
        /// An existing interface to attach to a single instance. Requires n=1 instances.
        /// </summary>
        /// <param name="networkInterfaceId">The network interface ID.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        /// The device index. Applies to both attaching an existing network interface and when
        /// creating a network interface.
        /// </summary>
        /// <remarks>
        /// Condition: If you are specifying a network interface in the
        /// request, you must provide the device index.
        /// </remarks>
        [XmlElementAttribute(ElementName = "DeviceIndex")]
        public int DeviceIndex
        {
            get { return this.deviceIndexField.GetValueOrDefault(); }
            set { this.deviceIndexField = value; }
        }

        /// <summary>
        /// The device index. Applies to both attaching an existing network interface and when
        /// creating a network interface.
        /// </summary>
        /// <remarks>
        /// Condition: If you are specifying a network interface in the
        /// request, you must provide the device index.
        /// </remarks>
        /// <param name="deviceIndex">The index of the device on the instance for the network interface attachment.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        /// The subnet ID. Applies only when creating a network interface.
        /// </summary>
        [XmlElementAttribute(ElementName = "SubnetId")]
        public string SubnetId
        {
            get { return this.subnetIdField; }
            set { this.subnetIdField = value; }
        }

        /// <summary>
        /// The subnet ID. Applies only when creating a network interface.
        /// </summary>
        /// <param name="subnetId">The ID of the subnet associated with the network string.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        /// A description. Applies only when creating a network interface.
        /// </summary>
        [XmlElementAttribute(ElementName = "Description")]
        public string Description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <summary>
        /// A description. Applies only when creating a network interface.
        /// </summary>
        /// <param name="description">The description of the network interface.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        /// The primary private IP address. 
        /// Applies only when creating a network interface. 
        /// Requires n=1 network interfaces in launch.
        /// </summary>
        [XmlElementAttribute(ElementName = "PrivateIpAddress")]
        public string PrivateIpAddress
        {
            get { return this.privateIpAddressField; }
            set { this.privateIpAddressField = value; }
        }

        /// <summary>
        /// The primary private IP address. 
        /// Applies only when creating a network interface. 
        /// Requires n=1 network interfaces in launch.
        /// </summary>
        /// <param name="ipAddress">IP address of the network interface</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
