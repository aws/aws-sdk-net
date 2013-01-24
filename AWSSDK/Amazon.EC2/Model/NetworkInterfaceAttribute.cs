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
    /// Network Interface Attribute
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class NetworkInterfaceAttribute
    {
        private string networkInterfaceIdField;
        private string descriptionField;
        private bool? sourceDestCheckField;
        private List<string> groupIdField;
        private List<string> groupNameField;
        private NetworkInterfaceAttachment attachmentField;

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
        /// <param name="networkInterfaceId">The ID of the network interface</param>
        /// <returns>this instance</returns>
        public NetworkInterfaceAttribute WithNetworkInterfaceId(string networkInterfaceId)
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
        /// Description of the network interface.
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
        public NetworkInterfaceAttribute WithDescription(string description)
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
        /// Whether source/destination checking is enabled on the instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "SourceDestCheck")]
        public bool SourceDestCheck
        {
            get { return this.sourceDestCheckField.GetValueOrDefault(); }
            set { this.sourceDestCheckField = value; }
        }

        /// <summary>
        /// Sets whether source/destination checking is enabled on the instance.
        /// </summary>
        /// <param name="sourceDestCheck">Flag indicating whether traffic to or from the instance is validated.</param>
        /// <returns>this instance</returns>
        public NetworkInterfaceAttribute WithSourceDestCheck(bool sourceDestCheck)
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
        /// The IDs of security groups the interface is in.
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
        /// Sets the IDs of security groups the interface is in.
        /// </summary>
        /// <param name="list">ID of the security group.</param>
        /// <returns>this instance</returns>
        public NetworkInterfaceAttribute WithGroupId(params string[] list)
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
        /// The names of security groups the interface is in.
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
        /// Sets the names of security groups the interface is in.
        /// </summary>
        /// <param name="list">Name of the security group.</param>
        /// <returns>this instance</returns>
        public NetworkInterfaceAttribute WithGroupName(params string[] list)
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
        /// <returns>true if GroupName property is set</returns>
        public bool IsSetGroupName()
        {
            return (GroupName.Count > 0);
        }

        /// <summary>
        /// The interface attachment.
        /// </summary>
        [XmlElementAttribute(ElementName = "Attachment")]
        public NetworkInterfaceAttachment Attachment
        {
            get { return this.attachmentField; }
            set { this.attachmentField = value; }
        }

        /// <summary>
        /// Sets the interface attachment.
        /// </summary>
        /// <param name="attachment">Network Interface Attachment</param>
        /// <returns>this instance</returns>
        public NetworkInterfaceAttribute WithAttachment(NetworkInterfaceAttachment attachment)
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
    }
}
