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

namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Container for the parameters to the RollbackStage operation. Rolls back a stage execution.
    /// </summary>
    public partial class RollbackStageRequest : AmazonCodePipelineRequest
    {
        /// <summary>
        /// Gets and sets the property PipelineName. 
        /// <para>
        /// The name of the pipeline for which the stage will be rolled back. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string PipelineName { get; set; }

        /// <summary>
        /// Checks to see if the PipelineName property is set.
        /// </summary>
        internal bool IsSetPipelineName() => this.PipelineName != null;

        /// <summary>
        /// Gets and sets the property StageName. 
        /// <para>
        /// The name of the stage in the pipeline to be rolled back. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string StageName { get; set; }

        /// <summary>
        /// Checks to see if the StageName property is set.
        /// </summary>
        internal bool IsSetStageName() => this.StageName != null;

        /// <summary>
        /// Gets and sets the property TargetPipelineExecutionId. 
        /// <para>
        /// The pipeline execution ID for the stage to be rolled back to. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TargetPipelineExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the TargetPipelineExecutionId property is set.
        /// </summary>
        internal bool IsSetTargetPipelineExecutionId() => this.TargetPipelineExecutionId != null;
    }
}
