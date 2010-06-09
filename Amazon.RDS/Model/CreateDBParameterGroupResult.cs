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
    public class CreateDBParameterGroupResult
    {
        private DBParameterGroup DBParameterGroupField;

        /// <summary>
        /// Gets and sets the DBParameterGroup property.
        /// </summary>
        [XmlElementAttribute(ElementName = "DBParameterGroup")]
        public DBParameterGroup DBParameterGroup
        {
            get { return this.DBParameterGroupField ; }
            set { this.DBParameterGroupField = value; }
        }

        /// <summary>
        /// Sets the DBParameterGroup property
        /// </summary>
        /// <param name="DBParameterGroup">DBParameterGroup property</param>
        /// <returns>this instance</returns>
        public CreateDBParameterGroupResult WithDBParameterGroup(DBParameterGroup DBParameterGroup)
        {
            this.DBParameterGroupField = DBParameterGroup;
            return this;
        }

        /// <summary>
        /// Checks if DBParameterGroup property is set
        /// </summary>
        /// <returns>true if DBParameterGroup property is set</returns>
        public bool IsSetDBParameterGroup()
        {
            return this.DBParameterGroupField != null;
        }

    }
}
