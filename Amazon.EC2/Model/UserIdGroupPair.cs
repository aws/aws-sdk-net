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
 *  API Version: 2011-11-01
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    ///<summary>
    ///Security group and user ID pair.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2011-11-01/", IsNullable = false)]
    public class UserIdGroupPair
    {    
        private string userIdField;
        private string groupIdField;
        private string groupNameField;

        /// <summary>
        /// Gets and sets the UserId property.
        /// AWS User ID of an account. Cannot be used when
        /// specifying a CIDR IP address.
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
        /// <param name="userId">AWS User ID of an account. Cannot be used when
        /// specifying a CIDR IP address.</param>
        /// <returns>this instance</returns>
        public UserIdGroupPair WithUserId(string userId)
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
        /// Gets and sets the GroupId property.
        /// AWS Group ID of a Security Group. Cannot be used when
        /// specifying a CIDR IP address.
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
        /// <param name="userId">AWS Group ID of a Security Group. Cannot be used when
        /// specifying a CIDR IP address.</param>
        /// <returns>this instance</returns>
        public UserIdGroupPair WithGroupId(string userId)
        {
            this.groupIdField = userId;
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
        /// Name of the security group. Cannot be used when
        /// specifying a CIDR IP address.
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
        /// <param name="groupName">Name of the security group. Cannot be used when
        /// specifying a CIDR IP address.</param>
        /// <returns>this instance</returns>
        public UserIdGroupPair WithGroupName(string groupName)
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
