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
 * Do not modify this file. This file is generated from the neptune-2018-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Neptune.Model
{
    /// <summary>
    /// Container for the parameters to the ResetDBParameterGroup operation.
    /// Modifies the parameters of a DB parameter group to the engine/system default value.
    /// To reset specific parameters, provide a list of the following: <code>ParameterName</code>
    /// and <code>ApplyMethod</code>. To reset the entire DB parameter group, specify the
    /// <code>DBParameterGroup</code> name and <code>ResetAllParameters</code> parameters.
    /// When resetting the entire group, dynamic parameters are updated immediately and static
    /// parameters are set to <code>pending-reboot</code> to take effect on the next DB instance
    /// restart or <code>RebootDBInstance</code> request.
    /// </summary>
    public partial class ResetDBParameterGroupRequest : AmazonNeptuneRequest
    {
        private string _dbParameterGroupName;
        private List<Parameter> _parameters = new List<Parameter>();
        private bool? _resetAllParameters;

        /// <summary>
        /// Gets and sets the property DBParameterGroupName. 
        /// <para>
        /// The name of the DB parameter group.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must match the name of an existing DBParameterGroup.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string DBParameterGroupName
        {
            get { return this._dbParameterGroupName; }
            set { this._dbParameterGroupName = value; }
        }

        // Check to see if DBParameterGroupName property is set
        internal bool IsSetDBParameterGroupName()
        {
            return this._dbParameterGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// To reset the entire DB parameter group, specify the <code>DBParameterGroup</code>
        /// name and <code>ResetAllParameters</code> parameters. To reset specific parameters,
        /// provide a list of the following: <code>ParameterName</code> and <code>ApplyMethod</code>.
        /// A maximum of 20 parameters can be modified in a single request.
        /// </para>
        ///  
        /// <para>
        ///  <b>MySQL</b> 
        /// </para>
        ///  
        /// <para>
        /// Valid Values (for Apply method): <code>immediate</code> | <code>pending-reboot</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can use the immediate value with dynamic parameters only. You can use the <code>pending-reboot</code>
        /// value for both dynamic and static parameters, and changes are applied when DB instance
        /// reboots.
        /// </para>
        ///  
        /// <para>
        ///  <b>MariaDB</b> 
        /// </para>
        ///  
        /// <para>
        /// Valid Values (for Apply method): <code>immediate</code> | <code>pending-reboot</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can use the immediate value with dynamic parameters only. You can use the <code>pending-reboot</code>
        /// value for both dynamic and static parameters, and changes are applied when DB instance
        /// reboots.
        /// </para>
        ///  
        /// <para>
        ///  <b>Oracle</b> 
        /// </para>
        ///  
        /// <para>
        /// Valid Values (for Apply method): <code>pending-reboot</code> 
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

        /// <summary>
        /// Gets and sets the property ResetAllParameters. 
        /// <para>
        ///  Specifies whether (<code>true</code>) or not (<code>false</code>) to reset all parameters
        /// in the DB parameter group to default values. 
        /// </para>
        ///  
        /// <para>
        /// Default: <code>true</code> 
        /// </para>
        /// </summary>
        public bool ResetAllParameters
        {
            get { return this._resetAllParameters.GetValueOrDefault(); }
            set { this._resetAllParameters = value; }
        }

        // Check to see if ResetAllParameters property is set
        internal bool IsSetResetAllParameters()
        {
            return this._resetAllParameters.HasValue; 
        }

    }
}