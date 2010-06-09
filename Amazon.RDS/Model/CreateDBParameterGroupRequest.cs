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
    /// Creates a DB Parameter Group.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://rds.amazonaws.com/admin/2009-10-16/", IsNullable = false)]
    public class CreateDBParameterGroupRequest
    {
        private string DBParameterGroupNameField;
        private string engineField;
        private string descriptionField;

        /// <summary>
        /// Gets and sets the DBParameterGroupName property.
        /// Name of the DB Parameter Group.
        /// Must be 1 to 255 alphanumeric characters.
        /// First character must be a letter.
        /// May not end with a hyphen or contain two consecutive hyphens.
        /// </summary>
        [XmlElementAttribute(ElementName = "DBParameterGroupName")]
        public string DBParameterGroupName
        {
            get { return this.DBParameterGroupNameField ; }
            set { this.DBParameterGroupNameField= value; }
        }

        /// <summary>
        /// Sets the DBParameterGroupName property
        /// </summary>
        /// <param name="DBParameterGroupName">Name of the DB Parameter Group.
        /// Must be 1 to 255 alphanumeric characters.
        /// First character must be a letter.
        /// May not end with a hyphen or contain two consecutive hyphens.</param>
        /// <returns>this instance</returns>
        public CreateDBParameterGroupRequest WithDBParameterGroupName(string DBParameterGroupName)
        {
            this.DBParameterGroupNameField = DBParameterGroupName;
            return this;
        }

        /// <summary>
        /// Checks if DBParameterGroupName property is set
        /// </summary>
        /// <returns>true if DBParameterGroupName property is set</returns>
        public bool IsSetDBParameterGroupName()
        {
            return  this.DBParameterGroupNameField != null;
        }

        /// <summary>
        /// Gets and sets the Engine property.
        /// Name of the database engine this DB Parameter Group can be used with.
        /// Valid Values: MySQL5.1
        /// </summary>
        [XmlElementAttribute(ElementName = "Engine")]
        public string Engine
        {
            get { return this.engineField ; }
            set { this.engineField= value; }
        }

        /// <summary>
        /// Sets the Engine property
        /// </summary>
        /// <param name="engine">Name of the database engine this DB Parameter Group can be used with.
        /// Valid Values: MySQL5.1</param>
        /// <returns>this instance</returns>
        public CreateDBParameterGroupRequest WithEngine(string engine)
        {
            this.engineField = engine;
            return this;
        }

        /// <summary>
        /// Checks if Engine property is set
        /// </summary>
        /// <returns>true if Engine property is set</returns>
        public bool IsSetEngine()
        {
            return  this.engineField != null;
        }

        /// <summary>
        /// Gets and sets the Description property.
        /// Description for the DB Parameter Group.
        /// </summary>
        [XmlElementAttribute(ElementName = "Description")]
        public string Description
        {
            get { return this.descriptionField ; }
            set { this.descriptionField= value; }
        }

        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">Description for the DB Parameter Group.</param>
        /// <returns>this instance</returns>
        public CreateDBParameterGroupRequest WithDescription(string description)
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
            return  this.descriptionField != null;
        }

    }
}
