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
    /// Runtime details and status for the workflow step.
    /// </summary>
    public partial class WorkflowStepMetadata
    {
        private string _action;
        private string _description;
        private string _endTime;
        private string _inputs;
        private string _message;
        private string _name;
        private string _outputs;
        private WorkflowStepExecutionRollbackStatus _rollbackStatus;
        private string _startTime;
        private WorkflowStepExecutionStatus _status;
        private string _stepExecutionId;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The step action name.
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
        /// Description of the workflow step.
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
        /// The timestamp when the workflow step finished.
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
        /// Gets and sets the property Inputs. 
        /// <para>
        /// Input parameters that Image Builder provides for the workflow step.
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
        /// Detailed output message that the workflow step provides at runtime.
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
        /// The name of the workflow step.
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
        /// Gets and sets the property Outputs. 
        /// <para>
        /// The file names that the workflow step created as output for this runtime instance
        /// of the workflow.
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
        /// Gets and sets the property RollbackStatus. 
        /// <para>
        /// Reports on the rollback status of the step, if applicable.
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
        /// The timestamp when the workflow step started.
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
        /// Runtime status for the workflow step.
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
        /// A unique identifier for the workflow step, assigned at runtime.
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

    }
}