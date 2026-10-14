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
    /// This is the response object from the DescribePipeline operation.
    /// </summary>
    public partial class DescribePipelineResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedBy.
        /// </summary>
        public UserContext CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when the pipeline was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedBy.
        /// </summary>
        public UserContext LastModifiedBy { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedBy property is set.
        /// </summary>
        internal bool IsSetLastModifiedBy() => this.LastModifiedBy != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The time when the pipeline was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastRunTime. 
        /// <para>
        /// The time when the pipeline was last run.
        /// </para>
        /// </summary>
        public DateTime? LastRunTime { get; set; }

        /// <summary>
        /// Checks to see if the LastRunTime property is set.
        /// </summary>
        internal bool IsSetLastRunTime() => this.LastRunTime.HasValue;

        /// <summary>
        /// Gets and sets the property ParallelismConfiguration. 
        /// <para>
        /// Lists the parallelism configuration applied to the pipeline.
        /// </para>
        /// </summary>
        public ParallelismConfiguration ParallelismConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ParallelismConfiguration property is set.
        /// </summary>
        internal bool IsSetParallelismConfiguration() => this.ParallelismConfiguration != null;

        /// <summary>
        /// Gets and sets the property PipelineArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string PipelineArn { get; set; }

        /// <summary>
        /// Checks to see if the PipelineArn property is set.
        /// </summary>
        internal bool IsSetPipelineArn() => this.PipelineArn != null;

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
        /// The name of the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string PipelineName { get; set; }

        /// <summary>
        /// Checks to see if the PipelineName property is set.
        /// </summary>
        internal bool IsSetPipelineName() => this.PipelineName != null;

        /// <summary>
        /// Gets and sets the property PipelineStatus. 
        /// <para>
        /// The status of the pipeline execution.
        /// </para>
        /// </summary>
        public PipelineStatus PipelineStatus { get; set; }

        /// <summary>
        /// Checks to see if the PipelineStatus property is set.
        /// </summary>
        internal bool IsSetPipelineStatus() => this.PipelineStatus != null;

        /// <summary>
        /// Gets and sets the property PipelineVersionDescription. 
        /// <para>
        /// The description of the pipeline version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 3072)]
        public string PipelineVersionDescription { get; set; }

        /// <summary>
        /// Checks to see if the PipelineVersionDescription property is set.
        /// </summary>
        internal bool IsSetPipelineVersionDescription() => this.PipelineVersionDescription != null;

        /// <summary>
        /// Gets and sets the property PipelineVersionDisplayName. 
        /// <para>
        /// The display name of the pipeline version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 82)]
        public string PipelineVersionDisplayName { get; set; }

        /// <summary>
        /// Checks to see if the PipelineVersionDisplayName property is set.
        /// </summary>
        internal bool IsSetPipelineVersionDisplayName() => this.PipelineVersionDisplayName != null;

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
