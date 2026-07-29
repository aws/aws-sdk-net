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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Environment variables provided as input for a pipeline execution.
    /// </summary>
    public partial class ExecutionEnvironmentVariables
    {
        private Dictionary<string, Dictionary<string, string>> _computeNodes = AWSConfigs.InitializeCollections ? new Dictionary<string, Dictionary<string, string>>() : null;
        private Dictionary<string, string> _global = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ComputeNodes. 
        /// <para>
        /// Per-compute-node environment variable overrides. Each entry maps a compute node name
        /// to its environment variable overrides.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, Dictionary<string, string>> ComputeNodes
        {
            get { return this._computeNodes; }
            set { this._computeNodes = value; }
        }

        // Check to see if ComputeNodes property is set
        internal bool IsSetComputeNodes()
        {
            return this._computeNodes != null && (this._computeNodes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Global. 
        /// <para>
        /// Global environment variables that apply to all compute nodes in the pipeline execution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=20)]
        public Dictionary<string, string> Global
        {
            get { return this._global; }
            set { this._global = value; }
        }

        // Check to see if Global property is set
        internal bool IsSetGlobal()
        {
            return this._global != null && (this._global.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}