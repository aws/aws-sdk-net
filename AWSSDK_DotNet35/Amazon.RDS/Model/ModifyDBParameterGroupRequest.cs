/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the rds-2013-09-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyDBParameterGroup operation.
    /// Modifies the parameters of a DB parameter group. To modify more than one parameter,
    /// submit a list of the following: <code>ParameterName</code>, <code>ParameterValue</code>,
    /// and <code>ApplyMethod</code>. A maximum of 20 parameters can be modified in a single
    /// request.
    /// </summary>
    public partial class ModifyDBParameterGroupRequest : AmazonRDSRequest
    {
        private string _dBParameterGroupName;
        private List<Parameter> _parameters = new List<Parameter>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ModifyDBParameterGroupRequest() { }

        /// <summary>
        /// Instantiates ModifyDBParameterGroupRequest with the parameterized properties
        /// </summary>
        /// <param name="dbParameterGroupName"> The name of the DB parameter group.  Constraints: <ul> <li>Must be the name of an existing DB parameter group</li> <li>Must be 1 to 255 alphanumeric characters</li> <li>First character must be a letter</li> <li>Cannot end with a hyphen or contain two consecutive hyphens</li> </ul></param>
        /// <param name="parameters"> An array of parameter names, values, and the apply method for the parameter update. At least one parameter name, value, and apply method must be supplied; subsequent arguments are optional. A maximum of 20 parameters may be modified in a single request.  Valid Values (for the application method): <code>immediate | pending-reboot</code></param>
        public ModifyDBParameterGroupRequest(string dbParameterGroupName, List<Parameter> parameters)
        {
            _dBParameterGroupName = dbParameterGroupName;
            _parameters = parameters;
        }

        /// <summary>
        /// Gets and sets the property DBParameterGroupName. 
        /// <para>
        ///  The name of the DB parameter group. 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li>Must be the name of an existing DB parameter group</li> <li>Must be 1 to
        /// 255 alphanumeric characters</li> <li>First character must be a letter</li> <li>Cannot
        /// end with a hyphen or contain two consecutive hyphens</li> </ul>
        /// </summary>
        public string DBParameterGroupName
        {
            get { return this._dBParameterGroupName; }
            set { this._dBParameterGroupName = value; }
        }

        // Check to see if DBParameterGroupName property is set
        internal bool IsSetDBParameterGroupName()
        {
            return this._dBParameterGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        ///  An array of parameter names, values, and the apply method for the parameter update.
        /// At least one parameter name, value, and apply method must be supplied; subsequent
        /// arguments are optional. A maximum of 20 parameters may be modified in a single request.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Valid Values (for the application method): <code>immediate | pending-reboot</code>
        /// </para>
        /// </summary>
        public List<Parameter> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

    }
}