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
    ///<summary>
    ///Information about the DB Parameter Group status.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://rds.amazonaws.com/doc/2010-01-01/", IsNullable = false)]
    public class DBParameterGroupStatus
    {
        private string DBParameterGroupNameField;
        private string parameterApplyStatusField;

        /// <summary>
        /// Gets and sets the DBParameterGroupName property.
        /// The name of the DB Parameter Group.
        /// </summary>
        [XmlElementAttribute(ElementName = "DBParameterGroupName")]
        public string DBParameterGroupName
        {
            get { return this.DBParameterGroupNameField; }
            set { this.DBParameterGroupNameField = value; }
        }

        /// <summary>
        /// Sets the DBParameterGroupName property
        /// </summary>
        /// <param name="DBParameterGroupName">The name of the DB Parameter Group.</param>
        /// <returns>this instance</returns>
        public DBParameterGroupStatus WithDBParameterGroupName(string DBParameterGroupName)
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
            return this.DBParameterGroupNameField != null;
        }

        /// <summary>
        /// Gets and sets the ParameterApplyStatus property.
        /// Status of the parameter updates.
        /// </summary>
        [XmlElementAttribute(ElementName = "ParameterApplyStatus")]
        public string ParameterApplyStatus
        {
            get { return this.parameterApplyStatusField; }
            set { this.parameterApplyStatusField = value; }
        }

        /// <summary>
        /// Sets the ParameterApplyStatus property
        /// </summary>
        /// <param name="parameterApplyStatus">Status of the parameter updates.</param>
        /// <returns>this instance</returns>
        public DBParameterGroupStatus WithParameterApplyStatus(string parameterApplyStatus)
        {
            this.parameterApplyStatusField = parameterApplyStatus;
            return this;
        }

        /// <summary>
        /// Checks if ParameterApplyStatus property is set
        /// </summary>
        /// <returns>true if ParameterApplyStatus property is set</returns>
        public bool IsSetParameterApplyStatus()
        {
            return this.parameterApplyStatusField != null;
        }

    }
}
