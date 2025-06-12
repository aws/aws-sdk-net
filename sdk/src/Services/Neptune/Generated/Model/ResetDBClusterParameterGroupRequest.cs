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
 * Do not modify this file. This file is generated from the neptune-2014-10-31.normal.json service model.
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
namespace Amazon.Neptune.Model
{
    /// <summary>
    /// Container for the parameters to the ResetDBClusterParameterGroup operation.
    /// Modifies the parameters of a DB cluster parameter group to the default value. To
    /// reset specific parameters submit a list of the following: <c>ParameterName</c> and
    /// <c>ApplyMethod</c>. To reset the entire DB cluster parameter group, specify the <c>DBClusterParameterGroupName</c>
    /// and <c>ResetAllParameters</c> parameters.
    /// 
    ///  
    /// <para>
    ///  When resetting the entire group, dynamic parameters are updated immediately and static
    /// parameters are set to <c>pending-reboot</c> to take effect on the next DB instance
    /// restart or <a>RebootDBInstance</a> request. You must call <a>RebootDBInstance</a>
    /// for every DB instance in your DB cluster that you want the updated static parameter
    /// to apply to.
    /// </para>
    /// </summary>
    public partial class ResetDBClusterParameterGroupRequest : AmazonNeptuneRequest
    {
        private string _dbClusterParameterGroupName;
        private List<Parameter> _parameters = AWSConfigs.InitializeCollections ? new List<Parameter>() : null;
        private bool? _resetAllParameters;

        /// <summary>
        /// Gets and sets the property DBClusterParameterGroupName. 
        /// <para>
        /// The name of the DB cluster parameter group to reset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DBClusterParameterGroupName
        {
            get { return this._dbClusterParameterGroupName; }
            set { this._dbClusterParameterGroupName = value; }
        }

        // Check to see if DBClusterParameterGroupName property is set
        internal bool IsSetDBClusterParameterGroupName()
        {
            return this._dbClusterParameterGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A list of parameter names in the DB cluster parameter group to reset to the default
        /// values. You can't use this parameter if the <c>ResetAllParameters</c> parameter is
        /// set to <c>true</c>.
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
        /// A value that is set to <c>true</c> to reset all parameters in the DB cluster parameter
        /// group to their default values, and <c>false</c> otherwise. You can't use this parameter
        /// if there is a list of parameter names specified for the <c>Parameters</c> parameter.
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