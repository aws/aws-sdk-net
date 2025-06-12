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
 * Do not modify this file. This file is generated from the memorydb-2021-01-01.normal.json service model.
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
namespace Amazon.MemoryDB.Model
{
    /// <summary>
    /// Container for the parameters to the ResetParameterGroup operation.
    /// Modifies the parameters of a parameter group to the engine or system default value.
    /// You can reset specific parameters by submitting a list of parameter names. To reset
    /// the entire parameter group, specify the AllParameters and ParameterGroupName parameters.
    /// </summary>
    public partial class ResetParameterGroupRequest : AmazonMemoryDBRequest
    {
        private bool? _allParameters;
        private string _parameterGroupName;
        private List<string> _parameterNames = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AllParameters. 
        /// <para>
        /// If true, all parameters in the parameter group are reset to their default values.
        /// If false, only the parameters listed by ParameterNames are reset to their default
        /// values.
        /// </para>
        /// </summary>
        public bool? AllParameters
        {
            get { return this._allParameters; }
            set { this._allParameters = value; }
        }

        // Check to see if AllParameters property is set
        internal bool IsSetAllParameters()
        {
            return this._allParameters.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParameterGroupName. 
        /// <para>
        /// The name of the parameter group to reset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ParameterNames. 
        /// <para>
        /// An array of parameter names to reset to their default values. If AllParameters is
        /// true, do not use ParameterNames. If AllParameters is false, you must specify the name
        /// of at least one parameter to reset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ParameterNames
        {
            get { return this._parameterNames; }
            set { this._parameterNames = value; }
        }

        // Check to see if ParameterNames property is set
        internal bool IsSetParameterNames()
        {
            return this._parameterNames != null && (this._parameterNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}