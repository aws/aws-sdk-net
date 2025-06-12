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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The details of the environment configuration parameter.
    /// </summary>
    public partial class EnvironmentConfigurationParametersDetails
    {
        private List<EnvironmentConfigurationParameter> _parameterOverrides = AWSConfigs.InitializeCollections ? new List<EnvironmentConfigurationParameter>() : null;
        private List<EnvironmentConfigurationParameter> _resolvedParameters = AWSConfigs.InitializeCollections ? new List<EnvironmentConfigurationParameter>() : null;
        private string _ssmPath;

        /// <summary>
        /// Gets and sets the property ParameterOverrides. 
        /// <para>
        /// The parameter overrides.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EnvironmentConfigurationParameter> ParameterOverrides
        {
            get { return this._parameterOverrides; }
            set { this._parameterOverrides = value; }
        }

        // Check to see if ParameterOverrides property is set
        internal bool IsSetParameterOverrides()
        {
            return this._parameterOverrides != null && (this._parameterOverrides.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResolvedParameters. 
        /// <para>
        /// The resolved environment configuration parameters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EnvironmentConfigurationParameter> ResolvedParameters
        {
            get { return this._resolvedParameters; }
            set { this._resolvedParameters = value; }
        }

        // Check to see if ResolvedParameters property is set
        internal bool IsSetResolvedParameters()
        {
            return this._resolvedParameters != null && (this._resolvedParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SsmPath. 
        /// <para>
        /// Ssm path environment configuration parameters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string SsmPath
        {
            get { return this._ssmPath; }
            set { this._ssmPath = value; }
        }

        // Check to see if SsmPath property is set
        internal bool IsSetSsmPath()
        {
            return this._ssmPath != null;
        }

    }
}