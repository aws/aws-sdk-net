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
    /// Modifies the parameters of a DB Parameter Group. To modify more than one parameter, submit a list of the following: ParameterName, ParameterValue, and ApplyMethod.
    /// You can modify a maximum of 20 parameters in a single request.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://rds.amazonaws.com/doc/2010-01-01/", IsNullable = false)]
    public class ModifyDBParameterGroupRequest
    {
        private string DBParameterGroupNameField;
        private List<Parameter> parametersField;

        /// <summary>
        /// Gets and sets the DBParameterGroupName property.
        /// Name of the database parameter group.
        /// Must contain from 1 to 255 alphanumeric characters or hyphens.
        /// First character must be a letter.
        /// May not end with a hyphen or contain two consecutive hyphens.
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
        /// <param name="DBParameterGroupName">Name of the database parameter group.
        /// Must contain from 1 to 255 alphanumeric characters or hyphens.
        /// First character must be a letter.
        /// May not end with a hyphen or contain two consecutive hyphens.</param>
        /// <returns>this instance</returns>
        public ModifyDBParameterGroupRequest WithDBParameterGroupName(string DBParameterGroupName)
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
        /// Gets and sets the Parameters property.
        /// An array of parameter names, values, and the apply method for the parameter update. At least one parameter
        /// name, value, and apply method must be supplied; subsequent arguments are optional. A maximum of 20 parameters
        /// may be updated in a single call.
        /// Valid values (for Apply method): immediate | pending-reboot
        /// </summary>
        [XmlElementAttribute(ElementName = "Parameters")]
        public List<Parameter> Parameters
        {
            get
            {
                if (this.parametersField == null)
                {
                    this.parametersField = new List<Parameter>();
                }
                return this.parametersField;
            }
            set { this.parametersField = value; }
        }

        /// <summary>
        /// Sets the Parameters property
        /// </summary>
        /// <param name="list">An array of parameter names, values, and the apply method for the parameter update. At least one parameter
        /// name, value, and apply method must be supplied; subsequent arguments are optional. A maximum of 20 parameters
        /// may be updated in a single call.
        /// Valid values (for Apply method): immediate | pending-reboot</param>
        /// <returns>this instance</returns>
        public ModifyDBParameterGroupRequest WithParameters(params Parameter[] list)
        {
            foreach (Parameter item in list)
            {
                Parameters.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Parameters property is set
        /// </summary>
        /// <returns>true if Parameters property is set</returns>
        public bool IsSetParameters()
        {
            return (Parameters.Count > 0);
        }

    }
}
