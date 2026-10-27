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
    /// This is the response object from the GetWorkflowStepExecution operation.
    /// </summary>
    public partial class GetWorkflowStepExecutionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The name of the action that the specified step performs.
        /// </para>
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property AttemptNumber. 
        /// <para>
        /// The current attempt number for the specified runtime instance of the workflow step.
        /// The first run is attempt one. The number increases by one for each retry.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? AttemptNumber { get; set; }

        /// <summary>
        /// Checks to see if the AttemptNumber property is set.
        /// </summary>
        internal bool IsSetAttemptNumber() => this.AttemptNumber.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Describes the specified workflow step.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The timestamp when the specified runtime instance of the workflow step finished.
        /// </para>
        /// </summary>
        public string EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime != null;

        /// <summary>
        /// Gets and sets the property ImageBuildVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the image build version that owns the specified
        /// runtime instance of the workflow step.
        /// </para>
        /// </summary>
        public string ImageBuildVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the ImageBuildVersionArn property is set.
        /// </summary>
        internal bool IsSetImageBuildVersionArn() => this.ImageBuildVersionArn != null;

        /// <summary>
        /// Gets and sets the property Inputs. 
        /// <para>
        /// Input parameters that Image Builder provided for the specified runtime instance of
        /// the workflow step, as a JSON-encoded string.
        /// </para>
        /// </summary>
        public string Inputs { get; set; }

        /// <summary>
        /// Checks to see if the Inputs property is set.
        /// </summary>
        internal bool IsSetInputs() => this.Inputs != null;

        /// <summary>
        /// Gets and sets the property MaxAttempts. 
        /// <para>
        /// The maximum number of attempts allowed for the specified runtime instance of the workflow
        /// step, based on the retry configuration in the workflow document. If the step doesn't
        /// configure retries, the maximum is one attempt.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? MaxAttempts { get; set; }

        /// <summary>
        /// Checks to see if the MaxAttempts property is set.
        /// </summary>
        internal bool IsSetMaxAttempts() => this.MaxAttempts.HasValue;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The output message from the specified runtime instance of the workflow step, if applicable.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the specified runtime instance of the workflow step.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OnFailure. 
        /// <para>
        /// The action that the workflow takes if this step fails, as configured in the workflow
        /// document. <c>Abort</c> fails the workflow and rolls back completed steps. <c>Continue</c>
        /// proceeds to the next step. If the step doesn't set a value, it defaults to <c>Abort</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string OnFailure { get; set; }

        /// <summary>
        /// Checks to see if the OnFailure property is set.
        /// </summary>
        internal bool IsSetOnFailure() => this.OnFailure != null;

        /// <summary>
        /// Gets and sets the property Outputs. 
        /// <para>
        /// The output values that the specified runtime instance of the workflow step produced,
        /// as a JSON-encoded string. For example, a step that launches an instance outputs the
        /// instance ID. If the step failed, this field contains the error message.
        /// </para>
        /// </summary>
        public string Outputs { get; set; }

        /// <summary>
        /// Checks to see if the Outputs property is set.
        /// </summary>
        internal bool IsSetOutputs() => this.Outputs != null;

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The request ID that uniquely identifies this request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string RequestId { get; set; }

        /// <summary>
        /// Checks to see if the RequestId property is set.
        /// </summary>
        internal bool IsSetRequestId() => this.RequestId != null;

        /// <summary>
        /// Gets and sets the property RollbackStatus. 
        /// <para>
        /// Reports on the rollback status of the specified runtime instance of the workflow step,
        /// if applicable. Rollback runs when the workflow execution fails, and undoes the work
        /// that completed steps performed.
        /// </para>
        /// </summary>
        public WorkflowStepExecutionRollbackStatus RollbackStatus { get; set; }

        /// <summary>
        /// Checks to see if the RollbackStatus property is set.
        /// </summary>
        internal bool IsSetRollbackStatus() => this.RollbackStatus != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The timestamp when the specified runtime instance of the workflow step started.
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
        /// The current status for the specified runtime instance of the workflow step.
        /// </para>
        /// </summary>
        public WorkflowStepExecutionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StepExecutionId. 
        /// <para>
        /// The unique identifier for the runtime instance of the workflow step that you specified
        /// in the request.
        /// </para>
        /// </summary>
        public string StepExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the StepExecutionId property is set.
        /// </summary>
        internal bool IsSetStepExecutionId() => this.StepExecutionId != null;

        /// <summary>
        /// Gets and sets the property TimeoutSeconds. 
        /// <para>
        /// The maximum duration in seconds for this step to complete its action. If the workflow
        /// document doesn't set a timeout for the step, Image Builder applies the default timeout
        /// for the step's action. This field returns that value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 43200)]
        public int? TimeoutSeconds { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutSeconds property is set.
        /// </summary>
        internal bool IsSetTimeoutSeconds() => this.TimeoutSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property WorkflowBuildVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the build version for the Image Builder workflow
        /// resource that defines this workflow step.
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
        /// The unique identifier that Image Builder assigned to keep track of runtime details
        /// when it ran the workflow.
        /// </para>
        /// </summary>
        public string WorkflowExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowExecutionId property is set.
        /// </summary>
        internal bool IsSetWorkflowExecutionId() => this.WorkflowExecutionId != null;
    }
}
