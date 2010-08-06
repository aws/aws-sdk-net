/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2010-06-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Adds or remove permission settings for the
    /// specified snapshot
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2010-06-15/", IsNullable = false)]
    public class ModifySnapshotAttributeRequest
    {    
        private string snapshotIdField;
        private string attributeField;
        private string operationTypeField;
        private List<string> userIdField;
        private List<string> userGroupField;

        /// <summary>
        /// Gets and sets the SnapshotId property.
        /// The ID of the snapshot.
        /// </summary>
        [XmlElementAttribute(ElementName = "SnapshotId")]
        public string SnapshotId
        {
            get { return this.snapshotIdField; }
            set { this.snapshotIdField = value; }
        }

        /// <summary>
        /// Sets the SnapshotId property
        /// </summary>
        /// <param name="snapshotId">The ID of the snapshot.</param>
        /// <returns>this instance</returns>
        public ModifySnapshotAttributeRequest WithSnapshotId(string snapshotId)
        {
            this.snapshotIdField = snapshotId;
            return this;
        }

        /// <summary>
        /// Checks if SnapshotId property is set
        /// </summary>
        /// <returns>true if SnapshotId property is set</returns>
        public bool IsSetSnapshotId()
        {
            return this.snapshotIdField != null;
        }

        /// <summary>
        /// Gets and sets the Attribute property.
        /// Specifies the attribute to modify. Valid
        /// Values: createVolumePermission
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
        /// Values: createVolumePermission</param>
        /// <returns>this instance</returns>
        public ModifySnapshotAttributeRequest WithAttribute(string attribute)
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
        /// attribute.
        /// Valid Values: add | remove
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
        /// attribute.
        /// Valid Values: add | remove</param>
        /// <returns>this instance</returns>
        public ModifySnapshotAttributeRequest WithOperationType(string operationType)
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
        /// User ID of a user that can create volumes from
        /// the snapshot.
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
        /// <param name="list">User ID of a user that can create volumes from
        /// the snapshot.</param>
        /// <returns>this instance</returns>
        public ModifySnapshotAttributeRequest WithUserId(params string[] list)
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
        /// Group that is allowed to create volumes from
        /// the snapshot (currently
        /// supports "all").
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
        /// <param name="list">Group that is allowed to create volumes from
        /// the snapshot (currently
        /// supports "all").</param>
        /// <returns>this instance</returns>
        public ModifySnapshotAttributeRequest WithUserGroup(params string[] list)
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

    }
}
