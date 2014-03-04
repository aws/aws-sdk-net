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
    /// Instance Network Interface
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class InstanceNetworkInterface
    {
        private string networkInterfaceIdField;
        private string subnetIdField;
        private string vpcIdField;
        private string descriptionField;
        private string ownerIdField;
        private string statusField;
        private string macAddressField;
        private string privateIpAddressField;
        private string privateDnsNameField;
        private bool? sourceDestCheckField;
        private List<string> groupIdField;
        private List<string> groupNameField;
        private InstanceNetworkInterfaceAttachment instanceNetworkInterfaceAttachmentField;
        private InstanceNetworkInterfaceAssociation instanceNetworkInterfaceAssociationField;
        private List<InstancePrivateIpAddress> privateIpAddressesField;

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
        /// <param name="networkInterfaceId">The ID of the network interface.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceNetworkInterface WithNetworkInterfaceId(string networkInterfaceId)
        {
            this.networkInterfaceIdField = networkInterfaceId;
            return this;
        }

        /// <summary>
        /// Checks if the NetworkInterfaceId property is set
        /// </summary>
        /// <returns>true if the NetworkInterfaceId property is set</returns>
        public bool IsSetNetworkInterfaceId()
        {
            return !string.IsNullOrEmpty(this.networkInterfaceIdField);
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
        /// <param name="subnetId">The ID of the subnet</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceNetworkInterface WithSubnetId(string subnetId)
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
        /// The ID of the VPC.
        /// </summary>
        [XmlElementAttribute(ElementName = "VpcId")]
        public string VpcId
        {
            get { return this.vpcIdField; }
            set { this.vpcIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the VPC.
        /// </summary>
        /// <param name="vpcId">The ID of the VPC.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceNetworkInterface WithVpcId(string vpcId)
        {
            this.vpcIdField = vpcId;
            return this;
        }

        /// <summary>
        /// Checks if the VpcId property is set
        /// </summary>
        /// <returns>true if the VpcId property is set</returns>
        public bool IsSetVpcId()
        {
            return !string.IsNullOrEmpty(this.vpcIdField);
        }

        /// <summary>
        /// Description of the interface.
        /// </summary>
        [XmlElementAttribute(ElementName = "Description")]
        public string Description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <summary>
        /// Sets the description of the interface.
        /// </summary>
        /// <param name="description">Description</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceNetworkInterface WithDescription(string description)
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
        /// The ID of the customer who created the interface.
        /// </summary>
        [XmlElementAttribute(ElementName = "OwnerId")]
        public string OwnerId
        {
            get { return this.ownerIdField; }
            set { this.ownerIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the customer who created the interface.
        /// </summary>
        /// <param name="ownerId">The ID of the customer who created the interface.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceNetworkInterface WithOwnerId(string ownerId)
        {
            this.ownerIdField = ownerId;
            return this;
        }

        /// <summary>
        /// Checks if the OwnerId property is set
        /// </summary>
        /// <returns>true if the OwnerId property is set</returns>
        public bool IsSetOwnerId()
        {
            return !string.IsNullOrEmpty(this.ownerIdField);
        }

        /// <summary>
        /// Status of the interface.
        /// Valid values: "available" | "in-use".
        /// </summary>
        [XmlElementAttribute(ElementName = "Status")]
        public string Status
        {
            get { return this.statusField; }
            set { this.statusField = value; }
        }

        /// <summary>
        /// Sets the status of the interface.
        /// </summary>
        /// <param name="status">"available" or "in-use"</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceNetworkInterface WithStatus(string status)
        {
            this.statusField = status;
            return this;
        }

        /// <summary>
        /// Checks if the Status property is set
        /// </summary>
        /// <returns>true if the Status property is set</returns>
        public bool IsSetStatus()
        {
            return !string.IsNullOrEmpty(this.statusField);
        }

        /// <summary>
        /// MAC address of the interface within the subnet.
        /// </summary>
        [XmlElementAttribute(ElementName = "MacAddress")]
        public string MacAddress
        {
            get { return this.macAddressField; }
            set { this.macAddressField = value; }
        }

        /// <summary>
        /// Sets the MAC address of the interface within the subnet.
        /// </summary>
        /// <param name="macAddress">MAC address of the interface within the subnet.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceNetworkInterface WithMacAddress(string macAddress)
        {
            this.macAddressField = macAddress;
            return this;
        }

        /// <summary>
        /// Checks if the MacAddress property is set
        /// </summary>
        /// <returns>true if the MacAddress property is set</returns>
        public bool IsSetMacAddress()
        {
            return !string.IsNullOrEmpty(this.macAddressField);
        }

        /// <summary>
        /// IP address of the interface within the subnet.
        /// </summary>
        [XmlElementAttribute(ElementName = "PrivateIpAddress")]
        public string PrivateIpAddress
        {
            get { return this.privateIpAddressField; }
            set { this.privateIpAddressField = value; }
        }

        /// <summary>
        /// Sets the IP address of the interface within the subnet.
        /// </summary>
        /// <param name="privateIpAddress">IP address of the interface within the subnet.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceNetworkInterface WithPrivateIpAddress(string privateIpAddress)
        {
            this.privateIpAddressField = privateIpAddress;
            return this;
        }

        /// <summary>
        /// Checks if the PrivateIpAddress property is set
        /// </summary>
        /// <returns>true if the PrivateIpAddress property is set</returns>
        public bool IsSetPrivateIpAddress()
        {
            return !string.IsNullOrEmpty(this.privateIpAddressField);
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
        /// <param name="privateDnsName">Private Dns Name</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceNetworkInterface WithPrivateDnsName(string privateDnsName)
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
        /// Whether traffic to or from the instance is validated.
        /// </summary>
        [XmlElementAttribute(ElementName = "SourceDestCheck")]
        public bool SourceDestCheck
        {
            get { return this.sourceDestCheckField.GetValueOrDefault(); }
            set { this.sourceDestCheckField = value; }
        }

        /// <summary>
        /// Sets whether traffic to or from the instance is validated.
        /// </summary>
        /// <param name="sourceDestCheck">Flag indicating whether traffic to or from the instance is validated.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceNetworkInterface WithSourceDestCheck(bool sourceDestCheck)
        {
            this.sourceDestCheckField = sourceDestCheck;
            return this;
        }

        /// <summary>
        /// Checks if the SourceDestCheck property is set
        /// </summary>
        /// <returns>true if the SourceDestCheck property is set</returns>
        public bool IsSetSourceDestCheck()
        {
            return this.sourceDestCheckField != null;
        }

        /// <summary>
        /// Security group IDs for the interface.
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
        /// Sets the security groups for the interface.
        /// </summary>
        /// <param name="list">A list of security groups the instance is in.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceNetworkInterface WithGroupId(params string[] list)
        {
            foreach (string item in list)
            {
                GroupId.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if GroupId property is set
        /// </summary>
        /// <returns>true if GroupId property is set</returns>
        public bool IsSetGroupId()
        {
            return (GroupId.Count > 0);
        }

        /// <summary>
        /// Security group names for the interface.
        /// </summary>
        [XmlElementAttribute(ElementName = "GroupName")]
        public List<string> GroupName
        {
            get
            {
                if (this.groupNameField == null)
                {
                    this.groupNameField = new List<string>();
                }
                return this.groupNameField;
            }
            set { this.groupNameField = value; }
        }

        /// <summary>
        /// Sets the security group names for the interface.
        /// </summary>
        /// <param name="list">A list of security groups the instance is in.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceNetworkInterface WithGroupName(params string[] list)
        {
            foreach (string item in list)
            {
                GroupName.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if GroupName property is set
        /// </summary>
        /// <returns>true if GroupId property is set</returns>
        public bool IsSetGroupName()
        {
            return (GroupName.Count > 0);
        }

        /// <summary>
        /// The network interface attachment.
        /// </summary>
        [XmlElementAttribute(ElementName = "Attachment")]
        public InstanceNetworkInterfaceAttachment Attachment
        {
            get { return this.instanceNetworkInterfaceAttachmentField; }
            set { this.instanceNetworkInterfaceAttachmentField = value; }
        }

        /// <summary>
        /// Sets the network interface attachment.
        /// </summary>
        /// <param name="attachment">Network Interface Attachment</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceNetworkInterface WithAttachment(InstanceNetworkInterfaceAttachment attachment)
        {
            this.instanceNetworkInterfaceAttachmentField = attachment;
            return this;
        }

        /// <summary>
        /// Checks if the Attachment property is set
        /// </summary>
        /// <returns>true if the Attachment property is set</returns>
        public bool IsSetAttachment()
        {
            return this.instanceNetworkInterfaceAttachmentField != null;
        }

        /// <summary>
        /// The association information for an Elastic IP associated with the network interface.
        /// </summary>
        [XmlElementAttribute(ElementName = "Association")]
        public InstanceNetworkInterfaceAssociation Association
        {
            get { return this.instanceNetworkInterfaceAssociationField; }
            set { this.instanceNetworkInterfaceAssociationField = value; }
        }

        /// <summary>
        /// Sets the association information for an Elastic IP associated with the network interface.
        /// </summary>
        /// <param name="association">Instance Network Interface Association</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceNetworkInterface WithAssociation(InstanceNetworkInterfaceAssociation association)
        {
            this.instanceNetworkInterfaceAssociationField = association;
            return this;
        }

        /// <summary>
        /// Checks if the Association property is set
        /// </summary>
        /// <returns>true if the Association property is set</returns>
        public bool IsSetAssociation()
        {
            return this.instanceNetworkInterfaceAssociationField != null;
        }


        /// <summary>
        /// The private IP addresses associated with the network interface.
        /// </summary>
        [XmlElementAttribute(ElementName = "PrivateIpAddresses")]
        public List<InstancePrivateIpAddress> PrivateIpAddresses
        {
            get
            {
                if (this.privateIpAddressesField == null)
                {
                    this.privateIpAddressesField = new List<InstancePrivateIpAddress>();
                }
                return this.privateIpAddressesField;
            }
            set { this.privateIpAddressesField = value; }
        }

        /// <summary>
        /// Sets the private IP addresses associated with the network interface.
        /// </summary>
        /// <param name="privateIpAddresses">Private IP addresses.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceNetworkInterface WithPrivateIpAddresses(params InstancePrivateIpAddress[] privateIpAddresses)
        {
            foreach (InstancePrivateIpAddress privateIpAddress in privateIpAddresses)
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
    }
}
