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
    /// An execution of a step in a pipeline.
    /// </summary>
    public partial class PipelineExecutionStep
    {
        /// <summary>
        /// Gets and sets the property AttemptCount. 
        /// <para>
        /// The current attempt of the execution step. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/pipelines-retry-policy.html">Retry
        /// Policy for SageMaker Pipelines steps</a>.
        /// </para>
        /// </summary>
        public int? AttemptCount { get; set; }

        /// <summary>
        /// Checks to see if the AttemptCount property is set.
        /// </summary>
        internal bool IsSetAttemptCount() => this.AttemptCount.HasValue;

        /// <summary>
        /// Gets and sets the property CacheHitResult. 
        /// <para>
        /// If this pipeline execution step was cached, details on the cache hit.
        /// </para>
        /// </summary>
        public CacheHitResult CacheHitResult { get; set; }

        /// <summary>
        /// Checks to see if the CacheHitResult property is set.
        /// </summary>
        internal bool IsSetCacheHitResult() => this.CacheHitResult != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time that the step stopped executing.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason why the step failed execution. This is only returned if the step failed
        /// its execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property IterationContext. 
        /// <para>
        /// The context for the iteration of a ForEach step that generated this step execution.
        /// </para>
        /// </summary>
        public IterationContext IterationContext { get; set; }

        /// <summary>
        /// Checks to see if the IterationContext property is set.
        /// </summary>
        internal bool IsSetIterationContext() => this.IterationContext != null;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Metadata to run the pipeline step.
        /// </para>
        /// </summary>
        public PipelineExecutionStepMetadata Metadata { get; set; }

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => this.Metadata != null;

        /// <summary>
        /// Gets and sets the property SelectiveExecutionResult. 
        /// <para>
        /// The ARN from an execution of the current pipeline from which results are reused for
        /// this step.
        /// </para>
        /// </summary>
        public SelectiveExecutionResult SelectiveExecutionResult { get; set; }

        /// <summary>
        /// Checks to see if the SelectiveExecutionResult property is set.
        /// </summary>
        internal bool IsSetSelectiveExecutionResult() => this.SelectiveExecutionResult != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time that the step started executing.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property StepDescription. 
        /// <para>
        /// The description of the step.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 3072)]
        public string StepDescription { get; set; }

        /// <summary>
        /// Checks to see if the StepDescription property is set.
        /// </summary>
        internal bool IsSetStepDescription() => this.StepDescription != null;

        /// <summary>
        /// Gets and sets the property StepDisplayName. 
        /// <para>
        /// The display name of the step.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string StepDisplayName { get; set; }

        /// <summary>
        /// Checks to see if the StepDisplayName property is set.
        /// </summary>
        internal bool IsSetStepDisplayName() => this.StepDisplayName != null;

        /// <summary>
        /// Gets and sets the property StepName. 
        /// <para>
        /// The name of the step that is executed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string StepName { get; set; }

        /// <summary>
        /// Checks to see if the StepName property is set.
        /// </summary>
        internal bool IsSetStepName() => this.StepName != null;

        /// <summary>
        /// Gets and sets the property StepStatus. 
        /// <para>
        /// The status of the step execution.
        /// </para>
        /// </summary>
        public StepStatus StepStatus { get; set; }

        /// <summary>
        /// Checks to see if the StepStatus property is set.
        /// </summary>
        internal bool IsSetStepStatus() => this.StepStatus != null;
    }
}
