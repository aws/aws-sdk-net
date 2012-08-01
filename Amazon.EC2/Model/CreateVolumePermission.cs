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
    ///<summary>
    ///Creat Volume Permission
    ///</summary>
    [XmlRootAttribute(IsNullable = false)]
    public class CreateVolumePermission
    {    
        private string userIdField;
        private string groupNameField;

        /// <summary>
        /// Gets and sets the UserId property.
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
        /// Sets the UserId property
        /// </summary>
        /// <param name="userId">User ID of a user that can create volumes from
        /// the snapshot.</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the GroupName property.
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
        /// Sets the GroupName property
        /// </summary>
        /// <param name="groupName">Group that is allowed to create volumes from
        /// the snapshot (currently supports "all").</param>
        /// <returns>this instance</returns>
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
