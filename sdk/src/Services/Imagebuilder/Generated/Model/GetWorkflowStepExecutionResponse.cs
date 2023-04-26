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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// This is the response object from the GetWorkflowStepExecution operation.
    /// </summary>
    public partial class GetWorkflowStepExecutionResponse : AmazonWebServiceResponse
    {
        private string _action;
        private string _description;
        private string _endTime;
        private string _imageBuildVersionArn;
        private string _inputs;
        private string _message;
        private string _name;
        private string _onFailure;
        private string _outputs;
        private string _requestId;
        private WorkflowStepExecutionRollbackStatus _rollbackStatus;
        private string _startTime;
        private WorkflowStepExecutionStatus _status;
        private string _stepExecutionId;
        private int? _timeoutSeconds;
        private string _workflowBuildVersionArn;
        private string _workflowExecutionId;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The name of the action that the specified step performs.
        /// </para>
        /// </summary>
        public string Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Describes the specified workflow step.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The timestamp when the specified runtime instance of the workflow step finished.
        /// </para>
        /// </summary>
        public string EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime != null;
        }

        /// <summary>
        /// Gets and sets the property ImageBuildVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the image resource build version that the specified
        /// runtime instance of the workflow step creates.
        /// </para>
        /// </summary>
        public string ImageBuildVersionArn
        {
            get { return this._imageBuildVersionArn; }
            set { this._imageBuildVersionArn = value; }
        }

        // Check to see if ImageBuildVersionArn property is set
        internal bool IsSetImageBuildVersionArn()
        {
            return this._imageBuildVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property Inputs. 
        /// <para>
        /// Input parameters that Image Builder provided for the specified runtime instance of
        /// the workflow step.
        /// </para>
        /// </summary>
        public string Inputs
        {
            get { return this._inputs; }
            set { this._inputs = value; }
        }

        // Check to see if Inputs property is set
        internal bool IsSetInputs()
        {
            return this._inputs != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The output message from the specified runtime instance of the workflow step, if applicable.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the specified runtime instance of the workflow step.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OnFailure. 
        /// <para>
        /// The action to perform if the workflow step fails.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string OnFailure
        {
            get { return this._onFailure; }
            set { this._onFailure = value; }
        }

        // Check to see if OnFailure property is set
        internal bool IsSetOnFailure()
        {
            return this._onFailure != null;
        }

        /// <summary>
        /// Gets and sets the property Outputs. 
        /// <para>
        /// The file names that the specified runtime version of the workflow step created as
        /// output.
        /// </para>
        /// </summary>
        public string Outputs
        {
            get { return this._outputs; }
            set { this._outputs = value; }
        }

        // Check to see if Outputs property is set
        internal bool IsSetOutputs()
        {
            return this._outputs != null;
        }

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The request ID that uniquely identifies this request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

        /// <summary>
        /// Gets and sets the property RollbackStatus. 
        /// <para>
        /// Reports on the rollback status of the specified runtime version of the workflow step,
        /// if applicable.
        /// </para>
        /// </summary>
        public WorkflowStepExecutionRollbackStatus RollbackStatus
        {
            get { return this._rollbackStatus; }
            set { this._rollbackStatus = value; }
        }

        // Check to see if RollbackStatus property is set
        internal bool IsSetRollbackStatus()
        {
            return this._rollbackStatus != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The timestamp when the specified runtime version of the workflow step started.
        /// </para>
        /// </summary>
        public string StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status for the specified runtime version of the workflow step.
        /// </para>
        /// </summary>
        public WorkflowStepExecutionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StepExecutionId. 
        /// <para>
        /// The unique identifier for the runtime version of the workflow step that you specified
        /// in the request.
        /// </para>
        /// </summary>
        public string StepExecutionId
        {
            get { return this._stepExecutionId; }
            set { this._stepExecutionId = value; }
        }

        // Check to see if StepExecutionId property is set
        internal bool IsSetStepExecutionId()
        {
            return this._stepExecutionId != null;
        }

        /// <summary>
        /// Gets and sets the property TimeoutSeconds. 
        /// <para>
        /// The maximum duration in seconds for this step to complete its action.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=43200)]
        public int TimeoutSeconds
        {
            get { return this._timeoutSeconds.GetValueOrDefault(); }
            set { this._timeoutSeconds = value; }
        }

        // Check to see if TimeoutSeconds property is set
        internal bool IsSetTimeoutSeconds()
        {
            return this._timeoutSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WorkflowBuildVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the build version for the Image Builder workflow
        /// resource that defines this workflow step.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string WorkflowBuildVersionArn
        {
            get { return this._workflowBuildVersionArn; }
            set { this._workflowBuildVersionArn = value; }
        }

        // Check to see if WorkflowBuildVersionArn property is set
        internal bool IsSetWorkflowBuildVersionArn()
        {
            return this._workflowBuildVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowExecutionId. 
        /// <para>
        /// The unique identifier that Image Builder assigned to keep track of runtime details
        /// when it ran the workflow.
        /// </para>
        /// </summary>
        public string WorkflowExecutionId
        {
            get { return this._workflowExecutionId; }
            set { this._workflowExecutionId = value; }
        }

        // Check to see if WorkflowExecutionId property is set
        internal bool IsSetWorkflowExecutionId()
        {
            return this._workflowExecutionId != null;
        }

    }
}