/*******************************************************************************
 * Copyright 2008-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2011-05-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Modifies an attribute of an AMI
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2011-05-15/", IsNullable = false)]
    public class ModifyImageAttributeRequest
    {    
        private string imageIdField;
        private string attributeField;
        private string operationTypeField;
        private List<string> userIdField;
        private List<string> userGroupField;
        private List<string> productCodeField;
        private string descriptionField;

        /// <summary>
        /// Gets and sets the ImageId property.
        /// The AMI ID.
        /// </summary>
        [XmlElementAttribute(ElementName = "ImageId")]
        public string ImageId
        {
            get { return this.imageIdField; }
            set { this.imageIdField = value; }
        }

        /// <summary>
        /// Sets the ImageId property
        /// </summary>
        /// <param name="imageId">The AMI ID.</param>
        /// <returns>this instance</returns>
        public ModifyImageAttributeRequest WithImageId(string imageId)
        {
            this.imageIdField = imageId;
            return this;
        }

        /// <summary>
        /// Checks if ImageId property is set
        /// </summary>
        /// <returns>true if ImageId property is set</returns>
        public bool IsSetImageId()
        {
            return this.imageIdField != null;
        }

        /// <summary>
        /// Gets and sets the Attribute property.
        /// Specifies the attribute to modify. Valid
        /// Values: launchPermission |
        /// productCodes
        /// </summary>
        [XmlElementAttribute(ElementName = "Attribute")]
        public string Attribute
        {
            get { return this.attributeField; }
            set { this.attributeField = value; }
        }

        /// <summary>
        /// Sets the Attribute property
        /// </summary>
        /// <param name="attribute">Specifies the attribute to modify. Valid
        /// Values: launchPermission |
        /// productCodes</param>
        /// <returns>this instance</returns>
        public ModifyImageAttributeRequest WithAttribute(string attribute)
        {
            this.attributeField = attribute;
            return this;
        }

        /// <summary>
        /// Checks if Attribute property is set
        /// </summary>
        /// <returns>true if Attribute property is set</returns>
        public bool IsSetAttribute()
        {
            return this.attributeField != null;
        }

        /// <summary>
        /// Gets and sets the OperationType property.
        /// Specifies the operation to perform on the
        /// attribute. Valid Values: add | remove
        /// </summary>
        [XmlElementAttribute(ElementName = "OperationType")]
        public string OperationType
        {
            get { return this.operationTypeField; }
            set { this.operationTypeField = value; }
        }

        /// <summary>
        /// Sets the OperationType property
        /// </summary>
        /// <param name="operationType">Specifies the operation to perform on the
        /// attribute. Valid Values: add | remove</param>
        /// <returns>this instance</returns>
        public ModifyImageAttributeRequest WithOperationType(string operationType)
        {
            this.operationTypeField = operationType;
            return this;
        }

        /// <summary>
        /// Checks if OperationType property is set
        /// </summary>
        /// <returns>true if OperationType property is set</returns>
        public bool IsSetOperationType()
        {
            return this.operationTypeField != null;
        }

        /// <summary>
        /// Gets and sets the UserId property.
        /// AWS Access Key ID.
        /// </summary>
        [XmlElementAttribute(ElementName = "UserId")]
        public List<string> UserId
        {
            get
            {
                if (this.userIdField == null)
                {
                    this.userIdField = new List<string>();
                }
                return this.userIdField;
            }
            set { this.userIdField = value; }
        }

        /// <summary>
        /// Sets the UserId property
        /// </summary>
        /// <param name="list">AWS Access Key ID.</param>
        /// <returns>this instance</returns>
        public ModifyImageAttributeRequest WithUserId(params string[] list)
        {
            foreach (string item in list)
            {
                UserId.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if UserId property is set
        /// </summary>
        /// <returns>true if UserId property is set</returns>
        public bool IsSetUserId()
        {
            return (UserId.Count > 0);
        }

        /// <summary>
        /// Gets and sets the UserGroup property.
        /// Name of the group. Currently supports "all."
        /// </summary>
        [XmlElementAttribute(ElementName = "UserGroup")]
        public List<string> UserGroup
        {
            get
            {
                if (this.userGroupField == null)
                {
                    this.userGroupField = new List<string>();
                }
                return this.userGroupField;
            }
            set { this.userGroupField = value; }
        }

        /// <summary>
        /// Sets the UserGroup property
        /// </summary>
        /// <param name="list">Name of the group. Currently supports "all."</param>
        /// <returns>this instance</returns>
        public ModifyImageAttributeRequest WithUserGroup(params string[] list)
        {
            foreach (string item in list)
            {
                UserGroup.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if UserGroup property is set
        /// </summary>
        /// <returns>true if UserGroup property is set</returns>
        public bool IsSetUserGroup()
        {
            return (UserGroup.Count > 0);
        }

        /// <summary>
        /// Gets and sets the ProductCode property.
        /// Product code.
        /// </summary>
        [XmlElementAttribute(ElementName = "ProductCode")]
        public List<string> ProductCode
        {
            get
            {
                if (this.productCodeField == null)
                {
                    this.productCodeField = new List<string>();
                }
                return this.productCodeField;
            }
            set { this.productCodeField = value; }
        }

        /// <summary>
        /// Sets the ProductCode property
        /// </summary>
        /// <param name="list">Product code.</param>
        /// <returns>this instance</returns>
        public ModifyImageAttributeRequest WithProductCode(params string[] list)
        {
            foreach (string item in list)
            {
                ProductCode.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if ProductCode property is set
        /// </summary>
        /// <returns>true if ProductCode property is set</returns>
        public bool IsSetProductCode()
        {
            return (ProductCode.Count > 0);
        }

        /// <summary>
        /// Gets and sets the Description property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Description")]
        public string Description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">Description property</param>
        /// <returns>this instance</returns>
        public ModifyImageAttributeRequest WithDescription(string description)
        {
            this.descriptionField = description;
            return this;
        }

        /// <summary>
        /// Checks if Description property is set
        /// </summary>
        /// <returns>true if Description property is set</returns>
        public bool IsSetDescription()
        {
            return this.descriptionField != null;
        }

    }
}
