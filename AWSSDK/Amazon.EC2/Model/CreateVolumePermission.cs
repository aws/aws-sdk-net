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
    /// Permissions for creating a volume.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class CreateVolumePermission
    {    
        private string userIdField;
        private string groupNameField;

        /// <summary>
        /// User ID of a user that can create volumes from
        /// the snapshot.
        /// </summary>
        [XmlElementAttribute(ElementName = "UserId")]
        public string UserId
        {
            get { return this.userIdField; }
            set { this.userIdField = value; }
        }

        /// <summary>
        /// Sets the user ID of a user that can create volumes from
        /// the snapshot.
        /// </summary>
        /// <param name="userId">User ID of a user that can create volumes from
        /// the snapshot.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateVolumePermission WithUserId(string userId)
        {
            this.userIdField = userId;
            return this;
        }

        /// <summary>
        /// Checks if UserId property is set
        /// </summary>
        /// <returns>true if UserId property is set</returns>
        public bool IsSetUserId()
        {
            return this.userIdField != null;
        }

        /// <summary>
        /// Group that is allowed to create volumes from
        /// the snapshot (currently supports "all").
        /// </summary>
        [XmlElementAttribute(ElementName = "GroupName")]
        public string GroupName
        {
            get { return this.groupNameField; }
            set { this.groupNameField = value; }
        }

        /// <summary>
        /// Sets the group that is allowed to create volumes from
        /// the snapshot (currently supports "all").
        /// </summary>
        /// <param name="groupName">Group that is allowed to create volumes from
        /// the snapshot (currently supports "all").</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateVolumePermission WithGroupName(string groupName)
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
