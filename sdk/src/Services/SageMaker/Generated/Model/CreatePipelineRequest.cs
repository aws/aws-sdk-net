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
    /// Container for the parameters to the CreatePipeline operation.
    /// Creates a pipeline using a JSON pipeline definition.
    /// </summary>
    public partial class CreatePipelineRequest : AmazonSageMakerRequest
    {
        private string _clientRequestToken;
        private ParallelismConfiguration _parallelismConfiguration;
        private string _pipelineDefinition;
        private PipelineDefinitionS3Location _pipelineDefinitionS3Location;
        private string _pipelineDescription;
        private string _pipelineDisplayName;
        private string _pipelineName;
        private string _roleArn;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the operation. An idempotent operation completes no more than one time.
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
        /// This is the configuration that controls the parallelism of the pipeline. If specified,
        /// it applies to all runs of this pipeline by default.
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
        /// Gets and sets the property PipelineDefinition. 
        /// <para>
        /// The <a href="https://aws-sagemaker-mlops.github.io/sagemaker-model-building-pipeline-definition-JSON-schema/">JSON
        /// pipeline definition</a> of the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1048576)]
        public string PipelineDefinition
        {
            get { return this._pipelineDefinition; }
            set { this._pipelineDefinition = value; }
        }

        // Check to see if PipelineDefinition property is set
        internal bool IsSetPipelineDefinition()
        {
            return this._pipelineDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineDefinitionS3Location. 
        /// <para>
        /// The location of the pipeline definition stored in Amazon S3. If specified, SageMaker
        /// will retrieve the pipeline definition from this location.
        /// </para>
        /// </summary>
        public PipelineDefinitionS3Location PipelineDefinitionS3Location
        {
            get { return this._pipelineDefinitionS3Location; }
            set { this._pipelineDefinitionS3Location = value; }
        }

        // Check to see if PipelineDefinitionS3Location property is set
        internal bool IsSetPipelineDefinitionS3Location()
        {
            return this._pipelineDefinitionS3Location != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineDescription. 
        /// <para>
        /// A description of the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3072)]
        public string PipelineDescription
        {
            get { return this._pipelineDescription; }
            set { this._pipelineDescription = value; }
        }

        // Check to see if PipelineDescription property is set
        internal bool IsSetPipelineDescription()
        {
            return this._pipelineDescription != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineDisplayName. 
        /// <para>
        /// The display name of the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string PipelineDisplayName
        {
            get { return this._pipelineDisplayName; }
            set { this._pipelineDisplayName = value; }
        }

        // Check to see if PipelineDisplayName property is set
        internal bool IsSetPipelineDisplayName()
        {
            return this._pipelineDisplayName != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineName. 
        /// <para>
        /// The name of the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the role used by the pipeline to access and create
        /// resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to apply to the created pipeline.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}