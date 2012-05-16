﻿/*******************************************************************************
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
 *  API Version: 2012-04-01
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Modify Network Interface Attribute request.
    /// Modifies a network interface attribute. Only one attribute can be specified per call.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2012-04-01/", IsNullable = false)]
    public class ModifyNetworkInterfaceAttributeRequest
    {
        private string networkInterfaceIdField;
        private string descriptionField;
        private bool? sourceDestCheckField;
        private List<string> groupIdField;
        private ModifyNetworkInterfaceAttachment attachmentField;

        /// <summary>
        /// Gets and sets the NetworkInterfaceId property.
        /// The ID of the network interface with the attributes that you want to modify.
        /// </summary>
        [XmlElementAttribute(ElementName = "NetworkInterfaceId")]
        public string NetworkInterfaceId
        {
            get { return this.networkInterfaceIdField; }
            set { this.networkInterfaceIdField = value; }
        }

        /// <summary>
        /// Sets the NetworkInterfaceId property.
        /// The ID of the network interface with the attributes that you want to modify.
        /// </summary>
        /// <param name="networkInterfaceId">The network interface ID.</param>
        /// <returns>this instance</returns>
        public ModifyNetworkInterfaceAttributeRequest WithNetworkInterfaceId(string networkInterfaceId)
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
        /// Gets and sets the Description property.
        /// The description of the network interface.
        /// </summary>
        [XmlElementAttribute(ElementName = "Description")]
        public string Description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <summary>
        /// Sets the Description property.
        /// The description of the network interface.
        /// </summary>
        /// <param name="description">Network interface description</param>
        /// <returns>this instance</returns>
        public ModifyNetworkInterfaceAttributeRequest WithDescription(string description)
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
        /// Gets and sets the SourceDestCheck property.
        /// This attribute exists to enable a Network Address Translation (NAT) instance in a VPC 
        /// to perform NAT. The attribute controls whether source/destination checking is enabled 
        /// on the instance. A value of true means checking is enabled, and false means checking is 
        /// disabled. The value must be false for the instance to perform NAT. For more information, 
        /// go to NAT Instances in the Amazon Virtual Private Cloud User Guide.
        /// </summary>
        [XmlElementAttribute(ElementName = "SourceDestCheck")]
        public bool SourceDestCheck
        {
            get { return this.sourceDestCheckField.GetValueOrDefault(); }
            set { this.sourceDestCheckField = value; }
        }

        /// <summary>
        /// Sets the SourceDestCheck property.
        /// </summary>
        /// <param name="sourceDestCheck">
        /// true to enable a Network Address Translation (NAT) instance in a VPC 
        /// to perform NAT.
        /// </param>
        /// <returns>this instance</returns>
        public ModifyNetworkInterfaceAttributeRequest WithSourceDestCheck(bool sourceDestCheck)
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
        /// Gets and sets the GroupId property.
        /// The full set of group IDs to associate with the network interface.
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
        /// Sets the GroupId property.
        /// </summary>
        /// <param name="list">
        /// The full set of group IDs to associate with the network interface.
        /// </param>
        /// <returns>this instance</returns>
        public ModifyNetworkInterfaceAttributeRequest WithGroupId(params string[] list)
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
        /// <returns>true if the GroupId property is set</returns>
        public bool IsSetGroupId()
        {
            return (GroupId.Count > 0);
        }

        /// <summary>
        /// Gets and sets the Attachment property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Attachment")]
        public ModifyNetworkInterfaceAttachment Attachment
        {
            get { return this.attachmentField; }
            set { this.attachmentField = value; }
        }

        /// <summary>
        /// Sets the Attachment property.
        /// </summary>
        /// <param name="attachment">Modify network interface attachment</param>
        /// <returns>this instance</returns>
        public ModifyNetworkInterfaceAttributeRequest WithModifyNetworkInterfaceAttachment(ModifyNetworkInterfaceAttachment attachment)
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
