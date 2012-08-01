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
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Deletes a security group that you own.
    ///
    /// If you attempt to delete a security group that contains instances, a
    /// fault is returned.
    ///
    /// If you attempt to delete a security group that is referenced by
    /// another security group, a fault is returned. For example,
    /// if security group B has a rule that allows access from
    /// security group A, security group A cannot be deleted until the
    /// allow rule is removed.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class DeleteSecurityGroupRequest
    {    
        private string groupIdField;
        private string groupNameField;

        /// <summary>
        /// Gets and sets the GroupId property.
        /// ID of the security group to delete.
        /// </summary>
        [XmlElementAttribute(ElementName = "GroupId")]
        public string GroupId
        {
            get { return this.groupIdField; }
            set { this.groupIdField = value; }
        }

        /// <summary>
        /// Sets the GroupId property
        /// </summary>
        /// <param name="groupId">ID of the security group to delete.</param>
        /// <returns>this instance</returns>
        public DeleteSecurityGroupRequest WithGroupId(string groupId)
        {
            this.groupIdField = groupId;
            return this;
        }

        /// <summary>
        /// Checks if GroupId property is set
        /// </summary>
        /// <returns>true if GroupId property is set</returns>
        public bool IsSetGroupId()
        {
            return this.groupIdField != null;
        }

        /// <summary>
        /// Gets and sets the GroupName property.
        /// Name of the security group to delete.
        /// </summary>
        [XmlElementAttribute(ElementName = "GroupName")]
        public string GroupName
        {
            get { return this.groupNameField; }
            set { this.groupNameField = value; }
        }

        /// <summary>
        /// Sets the GroupName property
        /// </summary>
        /// <param name="groupName">Name of the security group to delete.</param>
        /// <returns>this instance</returns>
        public DeleteSecurityGroupRequest WithGroupName(string groupName)
        {
            this.groupNameField = groupName;
            return this;
        }

        /// <summary>
        /// Checks if GroupName property is set
        /// </summary>
        /// <returns>true if GroupName property is set</returns>
        public bool IsSetGroupName()
        {
            return this.groupNameField != null;
        }

    }
}
