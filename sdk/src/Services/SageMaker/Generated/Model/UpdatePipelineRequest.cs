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
    /// Container for the parameters to the UpdatePipeline operation.
    /// Updates a pipeline.
    /// </summary>
    public partial class UpdatePipelineRequest : AmazonSageMakerRequest
    {
        private ParallelismConfiguration _parallelismConfiguration;
        private string _pipelineDefinition;
        private PipelineDefinitionS3Location _pipelineDefinitionS3Location;
        private string _pipelineDescription;
        private string _pipelineDisplayName;
        private string _pipelineName;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property ParallelismConfiguration. 
        /// <para>
        /// If specified, it applies to all executions of this pipeline by default.
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
        /// The JSON pipeline definition.
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
        /// The description of the pipeline.
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
        /// The name of the pipeline to update.
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
        /// The Amazon Resource Name (ARN) that the pipeline uses to execute.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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

    }
}