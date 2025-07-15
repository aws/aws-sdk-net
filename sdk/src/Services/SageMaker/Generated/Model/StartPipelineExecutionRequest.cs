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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the StartPipelineExecution operation.
    /// Starts a pipeline execution.
    /// </summary>
    public partial class StartPipelineExecutionRequest : AmazonSageMakerRequest
    {
        private string _clientRequestToken;
        private ParallelismConfiguration _parallelismConfiguration;
        private string _pipelineExecutionDescription;
        private string _pipelineExecutionDisplayName;
        private string _pipelineName;
        private List<Parameter> _pipelineParameters = AWSConfigs.InitializeCollections ? new List<Parameter>() : null;
        private long? _pipelineVersionId;
        private SelectiveExecutionConfig _selectiveExecutionConfig;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the operation. An idempotent operation completes no more than once.
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=128)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property ParallelismConfiguration. 
        /// <para>
        /// This configuration, if specified, overrides the parallelism configuration of the parent
        /// pipeline for this specific run.
        /// </para>
        /// </summary>
        public ParallelismConfiguration ParallelismConfiguration
        {
            get { return this._parallelismConfiguration; }
            set { this._parallelismConfiguration = value; }
        }

        // Check to see if ParallelismConfiguration property is set
        internal bool IsSetParallelismConfiguration()
        {
            return this._parallelismConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineExecutionDescription. 
        /// <para>
        /// The description of the pipeline execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3072)]
        public string PipelineExecutionDescription
        {
            get { return this._pipelineExecutionDescription; }
            set { this._pipelineExecutionDescription = value; }
        }

        // Check to see if PipelineExecutionDescription property is set
        internal bool IsSetPipelineExecutionDescription()
        {
            return this._pipelineExecutionDescription != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineExecutionDisplayName. 
        /// <para>
        /// The display name of the pipeline execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=82)]
        public string PipelineExecutionDisplayName
        {
            get { return this._pipelineExecutionDisplayName; }
            set { this._pipelineExecutionDisplayName = value; }
        }

        // Check to see if PipelineExecutionDisplayName property is set
        internal bool IsSetPipelineExecutionDisplayName()
        {
            return this._pipelineExecutionDisplayName != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineName. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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
        /// Gets and sets the property PipelineParameters. 
        /// <para>
        /// Contains a list of pipeline parameters. This list can be empty. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Parameter> PipelineParameters
        {
            get { return this._pipelineParameters; }
            set { this._pipelineParameters = value; }
        }

        // Check to see if PipelineParameters property is set
        internal bool IsSetPipelineParameters()
        {
            return this._pipelineParameters != null && (this._pipelineParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PipelineVersionId. 
        /// <para>
        /// The ID of the pipeline version to start execution from.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long? PipelineVersionId
        {
            get { return this._pipelineVersionId; }
            set { this._pipelineVersionId = value; }
        }

        // Check to see if PipelineVersionId property is set
        internal bool IsSetPipelineVersionId()
        {
            return this._pipelineVersionId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SelectiveExecutionConfig. 
        /// <para>
        /// The selective execution configuration applied to the pipeline run.
        /// </para>
        /// </summary>
        public SelectiveExecutionConfig SelectiveExecutionConfig
        {
            get { return this._selectiveExecutionConfig; }
            set { this._selectiveExecutionConfig = value; }
        }

        // Check to see if SelectiveExecutionConfig property is set
        internal bool IsSetSelectiveExecutionConfig()
        {
            return this._selectiveExecutionConfig != null;
        }

    }
}