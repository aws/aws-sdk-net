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
 *  API Version: 2009-10-16
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.RDS.Model
{
    ///<summary>
    ///Information about the security group.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://rds.amazonaws.com/admin/2009-10-16/", IsNullable = false)]
    public class EC2SecurityGroup
    {
        private string statusField;
        private string EC2SecurityGroupNameField;
        private string EC2SecurityGroupOwnerIdField;

        /// <summary>
        /// Gets and sets the Status property.
        /// The status of the EC2 security group.
        /// </summary>
        [XmlElementAttribute(ElementName = "Status")]
        public string Status
        {
            get { return this.statusField; }
            set { this.statusField = value; }
        }

        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The status of the EC2 security group.</param>
        /// <returns>this instance</returns>
        public EC2SecurityGroup WithStatus(string status)
        {
            this.statusField = status;
            return this;
        }

        /// <summary>
        /// Checks if Status property is set
        /// </summary>
        /// <returns>true if Status property is set</returns>
        public bool IsSetStatus()
        {
            return this.statusField != null;
        }

        /// <summary>
        /// Gets and sets the EC2SecurityGroupName property.
        /// The name of the EC2 Security Group.
        /// </summary>
        [XmlElementAttribute(ElementName = "EC2SecurityGroupName")]
        public string EC2SecurityGroupName
        {
            get { return this.EC2SecurityGroupNameField; }
            set { this.EC2SecurityGroupNameField = value; }
        }

        /// <summary>
        /// Sets the EC2SecurityGroupName property
        /// </summary>
        /// <param name="EC2SecurityGroupName">The name of the EC2 Security Group.</param>
        /// <returns>this instance</returns>
        public EC2SecurityGroup WithEC2SecurityGroupName(string EC2SecurityGroupName)
        {
            this.EC2SecurityGroupNameField = EC2SecurityGroupName;
            return this;
        }

        /// <summary>
        /// Checks if EC2SecurityGroupName property is set
        /// </summary>
        /// <returns>true if EC2SecurityGroupName property is set</returns>
        public bool IsSetEC2SecurityGroupName()
        {
            return this.EC2SecurityGroupNameField != null;
        }

        /// <summary>
        /// Gets and sets the EC2SecurityGroupOwnerId property.
        /// AWS ID of the owner of the EC2 security group specified in the EC2SecurityGroupName parameter.
        /// </summary>
        [XmlElementAttribute(ElementName = "EC2SecurityGroupOwnerId")]
        public string EC2SecurityGroupOwnerId
        {
            get { return this.EC2SecurityGroupOwnerIdField; }
            set { this.EC2SecurityGroupOwnerIdField = value; }
        }

        /// <summary>
        /// Sets the EC2SecurityGroupOwnerId property
        /// </summary>
        /// <param name="EC2SecurityGroupOwnerId">AWS ID of the owner of the EC2 security group specified in the EC2SecurityGroupName parameter.</param>
        /// <returns>this instance</returns>
        public EC2SecurityGroup WithEC2SecurityGroupOwnerId(string EC2SecurityGroupOwnerId)
        {
            this.EC2SecurityGroupOwnerIdField = EC2SecurityGroupOwnerId;
            return this;
        }

        /// <summary>
        /// Checks if EC2SecurityGroupOwnerId property is set
        /// </summary>
        /// <returns>true if EC2SecurityGroupOwnerId property is set</returns>
        public bool IsSetEC2SecurityGroupOwnerId()
        {
            return this.EC2SecurityGroupOwnerIdField != null;
        }

    }
}
