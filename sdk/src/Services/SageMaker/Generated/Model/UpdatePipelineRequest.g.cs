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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the UpdatePipeline operation. Updates a pipeline.
    /// </summary>
    public partial class UpdatePipelineRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property ParallelismConfiguration. 
        /// <para>
        /// If specified, it applies to all executions of this pipeline by default.
        /// </para>
        /// </summary>
        public ParallelismConfiguration ParallelismConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ParallelismConfiguration property is set.
        /// </summary>
        internal bool IsSetParallelismConfiguration() => this.ParallelismConfiguration != null;

        /// <summary>
        /// Gets and sets the property PipelineDefinition. 
        /// <para>
        /// The JSON pipeline definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1048576)]
        public string PipelineDefinition { get; set; }

        /// <summary>
        /// Checks to see if the PipelineDefinition property is set.
        /// </summary>
        internal bool IsSetPipelineDefinition() => this.PipelineDefinition != null;

        /// <summary>
        /// Gets and sets the property PipelineDefinitionS3Location. 
        /// <para>
        /// The location of the pipeline definition stored in Amazon S3. If specified, SageMaker
        /// will retrieve the pipeline definition from this location.
        /// </para>
        /// </summary>
        public PipelineDefinitionS3Location PipelineDefinitionS3Location { get; set; }

        /// <summary>
        /// Checks to see if the PipelineDefinitionS3Location property is set.
        /// </summary>
        internal bool IsSetPipelineDefinitionS3Location() => this.PipelineDefinitionS3Location != null;

        /// <summary>
        /// Gets and sets the property PipelineDescription. 
        /// <para>
        /// The description of the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 3072)]
        public string PipelineDescription { get; set; }

        /// <summary>
        /// Checks to see if the PipelineDescription property is set.
        /// </summary>
        internal bool IsSetPipelineDescription() => this.PipelineDescription != null;

        /// <summary>
        /// Gets and sets the property PipelineDisplayName. 
        /// <para>
        /// The display name of the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string PipelineDisplayName { get; set; }

        /// <summary>
        /// Checks to see if the PipelineDisplayName property is set.
        /// </summary>
        internal bool IsSetPipelineDisplayName() => this.PipelineDisplayName != null;

        /// <summary>
        /// Gets and sets the property PipelineName. 
        /// <para>
        /// The name of the pipeline to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string PipelineName { get; set; }

        /// <summary>
        /// Checks to see if the PipelineName property is set.
        /// </summary>
        internal bool IsSetPipelineName() => this.PipelineName != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that the pipeline uses to execute.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;
    }
}
