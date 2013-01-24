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
    /// Modifies an attribute of an AMI
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
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
        /// The AMI ID.
        /// </summary>
        [XmlElementAttribute(ElementName = "ImageId")]
        public string ImageId
        {
            get { return this.imageIdField; }
            set { this.imageIdField = value; }
        }

        /// <summary>
        /// Sets the AMI ID.
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
        /// The attribute to modify.
        /// Valid Values: launchPermission | productCodes
        /// </summary>
        [XmlElementAttribute(ElementName = "Attribute")]
        public string Attribute
        {
            get { return this.attributeField; }
            set { this.attributeField = value; }
        }

        /// <summary>
        /// Sets the attribute to modify.
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
        /// The operation to perform on the attribute.
        /// Valid Values: add | remove
        /// </summary>
        [XmlElementAttribute(ElementName = "OperationType")]
        public string OperationType
        {
            get { return this.operationTypeField; }
            set { this.operationTypeField = value; }
        }

        /// <summary>
        /// Sets the operation to perform on the attribute.
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
        /// AWS Access Key IDs to add/remove.
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
        /// Sets the AWS Access Key IDs to add/remove.
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
        /// Names of the groups to add/remove.
        /// Currently supports "all."
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
        /// Sets names of the groups to add/remove.
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
        /// Product codes to add.
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
        /// Sets product codes to add.
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
        /// New description for the AMI.
        /// </summary>
        [XmlElementAttribute(ElementName = "Description")]
        public string Description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <summary>
        /// Sets the new description for the AMI.
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
