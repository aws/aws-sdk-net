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
    /// Container for the parameters to the UpdatePipeline operation.
    /// Updates an existing pipeline in the specified workspace. Only the fields provided
    /// in the request are updated; fields not included in the request are preserved unchanged.
    /// You can update the pipeline description, environment variables, and the list of compute
    /// nodes independently.
    /// </summary>
    public partial class UpdatePipelineRequest : AmazonIoTSiteWiseRequest
    {
        private List<ComputeNode> _computations = AWSConfigs.InitializeCollections ? new List<ComputeNode>() : null;
        private string _description;
        private Dictionary<string, string> _environmentVariables = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _pipelineName;
        private string _workspaceName;

        /// <summary>
        /// Gets and sets the property Computations. 
        /// <para>
        /// Updated list of compute nodes forming the pipeline DAG.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<ComputeNode> Computations
        {
            get { return this._computations; }
            set { this._computations = value; }
        }

        // Check to see if Computations property is set
        internal bool IsSetComputations()
        {
            return this._computations != null && (this._computations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A new description for the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentVariables. 
        /// <para>
        /// Updated environment variables shared across all compute nodes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=20)]
        public Dictionary<string, string> EnvironmentVariables
        {
            get { return this._environmentVariables; }
            set { this._environmentVariables = value; }
        }

        // Check to see if EnvironmentVariables property is set
        internal bool IsSetEnvironmentVariables()
        {
            return this._environmentVariables != null && (this._environmentVariables.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PipelineName. 
        /// <para>
        /// The name of the pipeline to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string PipelineName
        {
            get { return this._pipelineName; }
            set { this._pipelineName = value; }
        }

        // Check to see if PipelineName property is set
        internal bool IsSetPipelineName()
        {
            return this._pipelineName != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// The name of the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string WorkspaceName
        {
            get { return this._workspaceName; }
            set { this._workspaceName = value; }
        }

        // Check to see if WorkspaceName property is set
        internal bool IsSetWorkspaceName()
        {
            return this._workspaceName != null;
        }

    }
}