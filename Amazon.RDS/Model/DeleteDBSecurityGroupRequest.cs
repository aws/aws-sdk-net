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
    /// <summary>
    /// Deletes a DB Security Group.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://rds.amazonaws.com/admin/2009-10-16/", IsNullable = false)]
    public class DeleteDBSecurityGroupRequest
    {
        private string DBSecurityGroupNameField;

        /// <summary>
        /// Gets and sets the DBSecurityGroupName property.
        /// Name of the database security group to delete.
        /// </summary>
        [XmlElementAttribute(ElementName = "DBSecurityGroupName")]
        public string DBSecurityGroupName
        {
            get { return this.DBSecurityGroupNameField ; }
            set { this.DBSecurityGroupNameField= value; }
        }

        /// <summary>
        /// Sets the DBSecurityGroupName property
        /// </summary>
        /// <param name="DBSecurityGroupName">Name of the database security group to delete.</param>
        /// <returns>this instance</returns>
        public DeleteDBSecurityGroupRequest WithDBSecurityGroupName(string DBSecurityGroupName)
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
            return  this.DBSecurityGroupNameField != null;
        }

    }
}
