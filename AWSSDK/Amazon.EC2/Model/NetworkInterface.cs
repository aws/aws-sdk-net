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
using System.IO;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a Network Interface
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class NetworkInterface
    {
        private string networkInterfaceIdField;
        private string subnetIdField;
        private string vpcIdField;
        private string availabilityZoneField;
        private string descriptionField;
        private string ownerIdField;
        private string requesterIdField;
        private bool? requesterManagedField;
        private string statusField;
        private string macAddressField;
        private string privateIpAddressField;
        private string privateDnsNameField;
        private bool? sourceDestCheckField;
        private List<string> groupIdField;
        private List<string> groupNameField;
        private NetworkInterfaceAttachment attachmentField;
        private NetworkInterfaceAssociation associationField;
        private List<Tag> tagField;
        private List<NetworkInterfacePrivateIpAddress> privateIpAddressesField;

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
        public NetworkInterface WithNetworkInterfaceId(string networkInterfaceId)
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
        public NetworkInterface WithSubnetId(string subnetId)
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
        public NetworkInterface WithVpcId(string vpcId)
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
        /// The Availability Zone of the interface.
        /// </summary>
        [XmlElementAttribute(ElementName = "AvailabilityZone")]
        public string AvailabilityZone
        {
            get { return this.availabilityZoneField; }
            set { this.availabilityZoneField = value; }
        }

        /// <summary>
        /// Sets the Availability Zone of the interface.
        /// </summary>
        /// <param name="availabilityZone">Availability Zone</param>
        /// <returns>this instance</returns>
        public NetworkInterface WithAvailabilityZone(string availabilityZone)
        {
            this.availabilityZoneField = availabilityZone;
            return this;
        }

        /// <summary>
        /// Checks if the AvailabilityZone property is set
        /// </summary>
        /// <returns>true if the AvailabilityZone property is set</returns>
        public bool IsSetAvailabilityZone()
        {
            return !string.IsNullOrEmpty(this.availabilityZoneField);
        }

        /// <summary>
        /// The description of the interface.
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
        public NetworkInterface WithDescription(string description)
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
        public NetworkInterface WithOwnerId(string ownerId)
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
        /// ID of the entity that launched the instance on your behalf (e.g., AWS Management Console, Auto Scaling, etc.)
        /// </summary>
        [XmlElementAttribute(ElementName = "RequesterId")]
        public string RequesterId
        {
            get { return this.requesterIdField; }
            set { this.requesterIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the entity that launched the instance on your behalf (e.g., AWS Management Console, Auto Scaling, etc.)
        /// </summary>
        /// <param name="requesterId">ID of the entity that launched the instance on your behalf (e.g., AWS Management Console, Auto Scaling, etc.)</param>
        /// <returns>this instance</returns>
        public NetworkInterface WithRequesterId(string requesterId)
        {
            this.requesterIdField = requesterId;
            return this;
        }

        /// <summary>
        /// Checks if the RequesterId property is set
        /// </summary>
        /// <returns>true if the RequesterId property is set</returns>
        public bool IsSetRequesterId()
        {
            return !string.IsNullOrEmpty(this.requesterIdField);
        }

        /// <summary>
        /// Whether the interface is managed by the requester.
        /// </summary>
        [XmlElementAttribute(ElementName = "RequesterManaged")]
        public bool RequesterManaged
        {
            get { return this.requesterManagedField.GetValueOrDefault(); }
            set { this.requesterManagedField = value; }
        }

        /// <summary>
        /// Sets whether the interface is managed by the requester.
        /// </summary>
        /// <param name="requesterManaged">Requester Managed flag</param>
        /// <returns>this instance</returns>
        public NetworkInterface WithRequesterManaged(bool requesterManaged)
        {
            this.requesterManagedField = requesterManaged;
            return this;
        }

        public bool IsSetRequesterManaged()
        {
            return this.requesterManagedField != null;
        }

        /// <summary>
        /// The status of the interface.
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
        public NetworkInterface WithStatus(string status)
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
        /// The MAC address of the interface.
        /// </summary>
        [XmlElementAttribute(ElementName = "MacAddress")]
        public string MacAddress
        {
            get { return this.macAddressField; }
            set { this.macAddressField = value; }
        }

        /// <summary>
        /// Sets the MAC address of the interface.
        /// </summary>
        /// <param name="macAddress"></param>
        /// <returns>this instance</returns>
        public NetworkInterface WithMacAddress(string macAddress)
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
        public NetworkInterface WithPrivateIpAddress(string privateIpAddress)
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
        /// The private DNS name.
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
        public NetworkInterface WithPrivateDnsName(string privateDnsName)
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
        public NetworkInterface WithSourceDestCheck(bool sourceDestCheck)
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
        /// Security group IDs associated with the interface.
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
        /// Sets the security group IDs associated with the interface.
        /// </summary>
        /// <param name="list">A list of security groups the instance is in.</param>
        /// <returns>this instance</returns>
        public NetworkInterface WithGroupId(params string[] list)
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
        /// A list of security group names the instance is in.
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
        /// Sets the security group names the instance is in.
        /// </summary>
        /// <param name="list">A list of security groups the instance is in.</param>
        /// <returns>this instance</returns>
        public NetworkInterface WithGroupName(params string[] list)
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
        public NetworkInterfaceAttachment Attachment
        {
            get { return this.attachmentField; }
            set { this.attachmentField = value; }
        }

        /// <summary>
        /// Sets the network interface attachment.
        /// </summary>
        /// <param name="attachment">Network Interface Attachment</param>
        /// <returns>this instance</returns>
        public NetworkInterface WithAttachment(NetworkInterfaceAttachment attachment)
        {
            this.attachmentField = attachment;
            return this;
        }

        /// <summary>
        /// Checks if the Attachment property is set
        /// </summary>
        /// <returns>true if the Attachment property is set</returns>
        public bool IsSetAttachment()
        {
            return this.attachmentField != null;
        }

        /// <summary>
        /// The association information for an Elastic IP associated with the network interface.
        /// </summary>
        [XmlElementAttribute(ElementName = "Association")]
        public NetworkInterfaceAssociation Association
        {
            get { return this.associationField; }
            set { this.associationField = value; }
        }

        /// <summary>
        /// Sets the association information for an Elastic IP associated with the network interface.
        /// </summary>
        /// <param name="association">Network Interface Association</param>
        /// <returns>this instance</returns>
        public NetworkInterface WithAssociation(NetworkInterfaceAssociation association)
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

        /// <summary>
        /// Resouce tags for this interface.
        /// </summary>
        [XmlElementAttribute(ElementName = "Tag")]
        public List<Tag> Tag
        {
            get
            {
                if (this.tagField == null)
                {
                    this.tagField = new List<Tag>();
                }
                return this.tagField;
            }
            set { this.tagField = value; }
        }

        /// <summary>
        /// Sets the resouce tags for this interface.
        /// </summary>
        /// <param name="list">A list of tags for the NetworkInterface.</param>
        /// <returns>this instance</returns>
        public NetworkInterface WithTag(params Tag[] list)
        {
            foreach (Tag item in list)
            {
                Tag.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Tag property is set
        /// </summary>
        /// <returns>true if Tag property is set</returns>
        public bool IsSetTag()
        {
            return (Tag.Count > 0);
        }

        /// <summary>
        /// Private IP addresses.
        /// </summary>
        [XmlElementAttribute(ElementName = "PrivateIpAddresses")]
        public List<NetworkInterfacePrivateIpAddress> PrivateIpAddresses
        {
            get
            {
                if (this.privateIpAddressesField == null)
                {
                    this.privateIpAddressesField = new List<NetworkInterfacePrivateIpAddress>();
                }
                return this.privateIpAddressesField;
            }
            set { this.privateIpAddressesField = value; }
        }

        /// <summary>
        /// Sets the private IP addresses.
        /// </summary>
        /// <param name="privateIpAddresses">Private IP addresses.</param>
        /// <returns>this instance</returns>
        public NetworkInterface WithPrivateIpAddresses(params NetworkInterfacePrivateIpAddress[] privateIpAddresses)
        {
            foreach (NetworkInterfacePrivateIpAddress privateIpAddress in privateIpAddresses)
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
