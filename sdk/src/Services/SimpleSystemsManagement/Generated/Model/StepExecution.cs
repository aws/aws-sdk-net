/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Detailed information about an the execution state of an Automation step.
    /// </summary>
    public partial class StepExecution
    {
        private string _action;
        private DateTime? _executionEndTime;
        private DateTime? _executionStartTime;
        private string _failureMessage;
        private Dictionary<string, string> _inputs = new Dictionary<string, string>();
        private Dictionary<string, List<string>> _outputs = new Dictionary<string, List<string>>();
        private string _response;
        private string _responseCode;
        private string _stepName;
        private AutomationExecutionStatus _stepStatus;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action this step performs. The action determines the behavior of the step.
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
        /// Gets and sets the property ExecutionEndTime. 
        /// <para>
        /// If a step has finished execution, this contains the time the execution ended. If the
        /// step has not yet concluded, this field is not populated.
        /// </para>
        /// </summary>
        public DateTime ExecutionEndTime
        {
            get { return this._executionEndTime.GetValueOrDefault(); }
            set { this._executionEndTime = value; }
        }

        // Check to see if ExecutionEndTime property is set
        internal bool IsSetExecutionEndTime()
        {
            return this._executionEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExecutionStartTime. 
        /// <para>
        /// If a step has begun execution, this contains the time the step started. If the step
        /// is in <code>Pending</code> status, this field is not populated.
        /// </para>
        /// </summary>
        public DateTime ExecutionStartTime
        {
            get { return this._executionStartTime.GetValueOrDefault(); }
            set { this._executionStartTime = value; }
        }

        // Check to see if ExecutionStartTime property is set
        internal bool IsSetExecutionStartTime()
        {
            return this._executionStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        /// If a step failed, this message explains why the execution failed.
        /// </para>
        /// </summary>
        public string FailureMessage
        {
            get { return this._failureMessage; }
            set { this._failureMessage = value; }
        }

        // Check to see if FailureMessage property is set
        internal bool IsSetFailureMessage()
        {
            return this._failureMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Inputs. 
        /// <para>
        /// Fully-resolved values passed into the step before execution.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Inputs
        {
            get { return this._inputs; }
            set { this._inputs = value; }
        }

        // Check to see if Inputs property is set
        internal bool IsSetInputs()
        {
            return this._inputs != null && this._inputs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Outputs. 
        /// <para>
        /// Returned values from the execution of the step.
        /// </para>
        /// </summary>
        public Dictionary<string, List<string>> Outputs
        {
            get { return this._outputs; }
            set { this._outputs = value; }
        }

        // Check to see if Outputs property is set
        internal bool IsSetOutputs()
        {
            return this._outputs != null && this._outputs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Response. 
        /// <para>
        /// A message associated with the response code for an execution.
        /// </para>
        /// </summary>
        public string Response
        {
            get { return this._response; }
            set { this._response = value; }
        }

        // Check to see if Response property is set
        internal bool IsSetResponse()
        {
            return this._response != null;
        }

        /// <summary>
        /// Gets and sets the property ResponseCode. 
        /// <para>
        /// The response code returned by the execution of the step.
        /// </para>
        /// </summary>
        public string ResponseCode
        {
            get { return this._responseCode; }
            set { this._responseCode = value; }
        }

        // Check to see if ResponseCode property is set
        internal bool IsSetResponseCode()
        {
            return this._responseCode != null;
        }

        /// <summary>
        /// Gets and sets the property StepName. 
        /// <para>
        /// The name of this execution step.
        /// </para>
        /// </summary>
        public string StepName
        {
            get { return this._stepName; }
            set { this._stepName = value; }
        }

        // Check to see if StepName property is set
        internal bool IsSetStepName()
        {
            return this._stepName != null;
        }

        /// <summary>
        /// Gets and sets the property StepStatus. 
        /// <para>
        /// The execution status for this step. Valid values include: <code>Pending</code>, <code>InProgress</code>,
        /// <code>Success</code>, <code>Cancelled</code>, <code>Failed</code>, and <code>TimedOut</code>.
        /// </para>
        /// </summary>
        public AutomationExecutionStatus StepStatus
        {
            get { return this._stepStatus; }
            set { this._stepStatus = value; }
        }

        // Check to see if StepStatus property is set
        internal bool IsSetStepStatus()
        {
            return this._stepStatus != null;
        }

    }
}