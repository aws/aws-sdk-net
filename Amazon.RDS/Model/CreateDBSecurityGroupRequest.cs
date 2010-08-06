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
 *  API Version: 2010-01-01
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Creates a new DB Security Group.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://rds.amazonaws.com/doc/2010-01-01/", IsNullable = false)]
    public class CreateDBSecurityGroupRequest
    {
        private string DBSecurityGroupNameField;
        private string DBSecurityGroupDescriptionField;

        /// <summary>
        /// Gets and sets the DBSecurityGroupName property.
        /// Name for the DB Security Group. This value is store as a lower-case string.
        /// </summary>
        [XmlElementAttribute(ElementName = "DBSecurityGroupName")]
        public string DBSecurityGroupName
        {
            get { return this.DBSecurityGroupNameField; }
            set { this.DBSecurityGroupNameField = value; }
        }

        /// <summary>
        /// Sets the DBSecurityGroupName property
        /// </summary>
        /// <param name="DBSecurityGroupName">Name for the DB Security Group. This value is store as a lower-case string.</param>
        /// <returns>this instance</returns>
        public CreateDBSecurityGroupRequest WithDBSecurityGroupName(string DBSecurityGroupName)
        {
            this.DBSecurityGroupNameField = DBSecurityGroupName;
            return this;
        }

        /// <summary>
        /// Checks if DBSecurityGroupName property is set
        /// </summary>
        /// <returns>true if DBSecurityGroupName property is set</returns>
        public bool IsSetDBSecurityGroupName()
        {
            return this.DBSecurityGroupNameField != null;
        }

        /// <summary>
        /// Gets and sets the DBSecurityGroupDescription property.
        /// Description for the DB Security Group.
        /// </summary>
        [XmlElementAttribute(ElementName = "DBSecurityGroupDescription")]
        public string DBSecurityGroupDescription
        {
            get { return this.DBSecurityGroupDescriptionField; }
            set { this.DBSecurityGroupDescriptionField = value; }
        }

        /// <summary>
        /// Sets the DBSecurityGroupDescription property
        /// </summary>
        /// <param name="DBSecurityGroupDescription">Description for the DB Security Group.</param>
        /// <returns>this instance</returns>
        public CreateDBSecurityGroupRequest WithDBSecurityGroupDescription(string DBSecurityGroupDescription)
        {
            this.DBSecurityGroupDescriptionField = DBSecurityGroupDescription;
            return this;
        }

        /// <summary>
        /// Checks if DBSecurityGroupDescription property is set
        /// </summary>
        /// <returns>true if DBSecurityGroupDescription property is set</returns>
        public bool IsSetDBSecurityGroupDescription()
        {
            return this.DBSecurityGroupDescriptionField != null;
        }

    }
}
