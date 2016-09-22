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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the ResetClusterParameterGroup operation.
    /// Sets one or more parameters of the specified parameter group to their default values
    /// and sets the source values of the parameters to "engine-default". To reset the entire
    /// parameter group specify the <i>ResetAllParameters</i> parameter. For parameter changes
    /// to take effect you must reboot any associated clusters.
    /// </summary>
    public partial class ResetClusterParameterGroupRequest : AmazonRedshiftRequest
    {
        private string _parameterGroupName;
        private List<Parameter> _parameters = new List<Parameter>();
        private bool? _resetAllParameters;

        /// <summary>
        /// Gets and sets the property ParameterGroupName. 
        /// <para>
        /// The name of the cluster parameter group to be reset.
        /// </para>
        /// </summary>
        public string ParameterGroupName
        {
            get { return this._parameterGroupName; }
            set { this._parameterGroupName = value; }
        }

        // Check to see if ParameterGroupName property is set
        internal bool IsSetParameterGroupName()
        {
            return this._parameterGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// An array of names of parameters to be reset. If <i>ResetAllParameters</i> option is
        /// not used, then at least one parameter name must be supplied. 
        /// </para>
        ///  
        /// <para>
        /// Constraints: A maximum of 20 parameters can be reset in a single request.
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
        /// If <code>true</code>, all parameters in the specified parameter group will be reset
        /// to their default values. 
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