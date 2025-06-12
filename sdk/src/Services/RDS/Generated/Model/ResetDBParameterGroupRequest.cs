/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the ResetDBParameterGroup operation.
    /// Modifies the parameters of a DB parameter group to the engine/system default value.
    /// To reset specific parameters, provide a list of the following: <c>ParameterName</c>
    /// and <c>ApplyMethod</c>. To reset the entire DB parameter group, specify the <c>DBParameterGroup</c>
    /// name and <c>ResetAllParameters</c> parameters. When resetting the entire group, dynamic
    /// parameters are updated immediately and static parameters are set to <c>pending-reboot</c>
    /// to take effect on the next DB instance restart or <c>RebootDBInstance</c> request.
    /// </summary>
    public partial class ResetDBParameterGroupRequest : AmazonRDSRequest
    {
        private string _dbParameterGroupName;
        private List<Parameter> _parameters = AWSConfigs.InitializeCollections ? new List<Parameter>() : null;
        private bool? _resetAllParameters;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ResetDBParameterGroupRequest() { }

        /// <summary>
        /// Instantiates ResetDBParameterGroupRequest with the parameterized properties
        /// </summary>
        /// <param name="dbParameterGroupName">The name of the DB parameter group. Constraints: <ul> <li> Must match the name of an existing <c>DBParameterGroup</c>. </li> </ul></param>
        public ResetDBParameterGroupRequest(string dbParameterGroupName)
        {
            _dbParameterGroupName = dbParameterGroupName;
        }

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
        /// Must match the name of an existing <c>DBParameterGroup</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// To reset the entire DB parameter group, specify the <c>DBParameterGroup</c> name and
        /// <c>ResetAllParameters</c> parameters. To reset specific parameters, provide a list
        /// of the following: <c>ParameterName</c> and <c>ApplyMethod</c>. A maximum of 20 parameters
        /// can be modified in a single request.
        /// </para>
        ///  
        /// <para>
        ///  <b>MySQL</b> 
        /// </para>
        ///  
        /// <para>
        /// Valid Values (for Apply method): <c>immediate</c> | <c>pending-reboot</c> 
        /// </para>
        ///  
        /// <para>
        /// You can use the immediate value with dynamic parameters only. You can use the <c>pending-reboot</c>
        /// value for both dynamic and static parameters, and changes are applied when DB instance
        /// reboots.
        /// </para>
        ///  
        /// <para>
        ///  <b>MariaDB</b> 
        /// </para>
        ///  
        /// <para>
        /// Valid Values (for Apply method): <c>immediate</c> | <c>pending-reboot</c> 
        /// </para>
        ///  
        /// <para>
        /// You can use the immediate value with dynamic parameters only. You can use the <c>pending-reboot</c>
        /// value for both dynamic and static parameters, and changes are applied when DB instance
        /// reboots.
        /// </para>
        ///  
        /// <para>
        ///  <b>Oracle</b> 
        /// </para>
        ///  
        /// <para>
        /// Valid Values (for Apply method): <c>pending-reboot</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Parameter> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResetAllParameters. 
        /// <para>
        /// Specifies whether to reset all parameters in the DB parameter group to default values.
        /// By default, all parameters in the DB parameter group are reset to default values.
        /// </para>
        /// </summary>
        public bool? ResetAllParameters
        {
            get { return this._resetAllParameters; }
            set { this._resetAllParameters = value; }
        }

        // Check to see if ResetAllParameters property is set
        internal bool IsSetResetAllParameters()
        {
            return this._resetAllParameters.HasValue; 
        }

    }
}