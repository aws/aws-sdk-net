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
    /// Container for the parameters to the RetryStageExecution operation. You can retry a
    /// stage that has failed without having to run a pipeline again from the beginning. You
    /// do this by either retrying the failed actions in a stage or by retrying all actions
    /// in the stage starting from the first action in the stage. When you retry the failed
    /// actions in a stage, all actions that are still in progress continue working, and failed
    /// actions are triggered again. When you retry a failed stage from the first action in
    /// the stage, the stage cannot have any actions in progress. Before a stage can be retried,
    /// it must either have all actions failed or some actions failed and some succeeded.
    /// </summary>
    public partial class RetryStageExecutionRequest : AmazonCodePipelineRequest
    {
        /// <summary>
        /// Gets and sets the property PipelineExecutionId. 
        /// <para>
        /// The ID of the pipeline execution in the failed stage to be retried. Use the <a>GetPipelineState</a>
        /// action to retrieve the current pipelineExecutionId of the failed stage
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PipelineExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the PipelineExecutionId property is set.
        /// </summary>
        internal bool IsSetPipelineExecutionId() => this.PipelineExecutionId != null;

        /// <summary>
        /// Gets and sets the property PipelineName. 
        /// <para>
        /// The name of the pipeline that contains the failed stage.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string PipelineName { get; set; }

        /// <summary>
        /// Checks to see if the PipelineName property is set.
        /// </summary>
        internal bool IsSetPipelineName() => this.PipelineName != null;

        /// <summary>
        /// Gets and sets the property RetryMode. 
        /// <para>
        /// The scope of the retry attempt.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StageRetryMode RetryMode { get; set; }

        /// <summary>
        /// Checks to see if the RetryMode property is set.
        /// </summary>
        internal bool IsSetRetryMode() => this.RetryMode != null;

        /// <summary>
        /// Gets and sets the property StageName. 
        /// <para>
        /// The name of the failed stage to be retried.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string StageName { get; set; }

        /// <summary>
        /// Checks to see if the StageName property is set.
        /// </summary>
        internal bool IsSetStageName() => this.StageName != null;
    }
}
