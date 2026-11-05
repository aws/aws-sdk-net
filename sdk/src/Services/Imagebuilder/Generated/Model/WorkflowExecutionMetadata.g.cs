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

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Metadata that includes details and status from this runtime instance of the workflow.
    /// </summary>
    public partial class WorkflowExecutionMetadata
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The timestamp when this runtime instance of the workflow finished.
        /// </para>
        /// </summary>
        public string EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The runtime output message from the workflow, if applicable.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property ParallelGroup. 
        /// <para>
        /// The name of the test group that included the test workflow resource at runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ParallelGroup { get; set; }

        /// <summary>
        /// Checks to see if the ParallelGroup property is set.
        /// </summary>
        internal bool IsSetParallelGroup() => this.ParallelGroup != null;

        /// <summary>
        /// Gets and sets the property Retried. 
        /// <para>
        /// Indicates whether a retry of the image build superseded this runtime instance of the
        /// workflow. When you retry a failed image build, Image Builder sets this flag to <c>true</c>
        /// on the original workflow executions that the retry re-ran.
        /// </para>
        /// </summary>
        public bool? Retried { get; set; }

        /// <summary>
        /// Checks to see if the Retried property is set.
        /// </summary>
        internal bool IsSetRetried() => this.Retried.HasValue;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The timestamp when the runtime instance of this workflow started.
        /// </para>
        /// </summary>
        public string StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current runtime status for this workflow.
        /// </para>
        /// </summary>
        public WorkflowExecutionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TotalStepCount. 
        /// <para>
        /// The total number of steps that the workflow document defines for this runtime instance
        /// of the workflow. Image Builder sets this count before any steps run. The sum of succeeded,
        /// skipped, and failed steps only reaches this total if every step finishes in one of
        /// those states.
        /// </para>
        /// </summary>
        public int? TotalStepCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalStepCount property is set.
        /// </summary>
        internal bool IsSetTotalStepCount() => this.TotalStepCount.HasValue;

        /// <summary>
        /// Gets and sets the property TotalStepsFailed. 
        /// <para>
        /// A runtime count for the number of steps in the workflow that failed.
        /// </para>
        /// </summary>
        public int? TotalStepsFailed { get; set; }

        /// <summary>
        /// Checks to see if the TotalStepsFailed property is set.
        /// </summary>
        internal bool IsSetTotalStepsFailed() => this.TotalStepsFailed.HasValue;

        /// <summary>
        /// Gets and sets the property TotalStepsSkipped. 
        /// <para>
        /// A runtime count for the number of steps in the workflow that were skipped.
        /// </para>
        /// </summary>
        public int? TotalStepsSkipped { get; set; }

        /// <summary>
        /// Checks to see if the TotalStepsSkipped property is set.
        /// </summary>
        internal bool IsSetTotalStepsSkipped() => this.TotalStepsSkipped.HasValue;

        /// <summary>
        /// Gets and sets the property TotalStepsSucceeded. 
        /// <para>
        /// A runtime count for the number of steps in the workflow that ran successfully.
        /// </para>
        /// </summary>
        public int? TotalStepsSucceeded { get; set; }

        /// <summary>
        /// Checks to see if the TotalStepsSucceeded property is set.
        /// </summary>
        internal bool IsSetTotalStepsSucceeded() => this.TotalStepsSucceeded.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Indicates what type of workflow that Image Builder ran for this runtime instance of
        /// the workflow.
        /// </para>
        /// </summary>
        public WorkflowType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property WorkflowBuildVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the workflow resource build version that ran.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string WorkflowBuildVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowBuildVersionArn property is set.
        /// </summary>
        internal bool IsSetWorkflowBuildVersionArn() => this.WorkflowBuildVersionArn != null;

        /// <summary>
        /// Gets and sets the property WorkflowExecutionId. 
        /// <para>
        /// Unique identifier that Image Builder assigns to keep track of runtime resources each
        /// time it runs a workflow.
        /// </para>
        /// </summary>
        public string WorkflowExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowExecutionId property is set.
        /// </summary>
        internal bool IsSetWorkflowExecutionId() => this.WorkflowExecutionId != null;
    }
}
