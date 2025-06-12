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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
        private FailureDetails _failureDetails;
        private string _failureMessage;
        private Dictionary<string, string> _inputs = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private bool? _isCritical;
        private bool? _isEnd;
        private int? _maxAttempts;
        private string _nextStep;
        private string _onFailure;
        private Dictionary<string, List<string>> _outputs = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private Dictionary<string, List<string>> _overriddenParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private ParentStepDetails _parentStepDetails;
        private string _response;
        private string _responseCode;
        private string _stepExecutionId;
        private string _stepName;
        private AutomationExecutionStatus _stepStatus;
        private TargetLocation _targetLocation;
        private List<Target> _targets = AWSConfigs.InitializeCollections ? new List<Target>() : null;
        private long? _timeoutSeconds;
        private List<AlarmStateInformation> _triggeredAlarms = AWSConfigs.InitializeCollections ? new List<AlarmStateInformation>() : null;
        private List<string> _validNextSteps = AWSConfigs.InitializeCollections ? new List<string>() : null;

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
        /// step hasn't yet concluded, this field isn't populated.
        /// </para>
        /// </summary>
        public DateTime? ExecutionEndTime
        {
            get { return this._executionEndTime; }
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
        /// is in Pending status, this field isn't populated.
        /// </para>
        /// </summary>
        public DateTime? ExecutionStartTime
        {
            get { return this._executionStartTime; }
            set { this._executionStartTime = value; }
        }

        // Check to see if ExecutionStartTime property is set
        internal bool IsSetExecutionStartTime()
        {
            return this._executionStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureDetails. 
        /// <para>
        /// Information about the Automation failure.
        /// </para>
        /// </summary>
        public FailureDetails FailureDetails
        {
            get { return this._failureDetails; }
            set { this._failureDetails = value; }
        }

        // Check to see if FailureDetails property is set
        internal bool IsSetFailureDetails()
        {
            return this._failureDetails != null;
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Inputs
        {
            get { return this._inputs; }
            set { this._inputs = value; }
        }

        // Check to see if Inputs property is set
        internal bool IsSetInputs()
        {
            return this._inputs != null && (this._inputs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IsCritical. 
        /// <para>
        /// The flag which can be used to help decide whether the failure of current step leads
        /// to the Automation failure.
        /// </para>
        /// </summary>
        public bool? IsCritical
        {
            get { return this._isCritical; }
            set { this._isCritical = value; }
        }

        // Check to see if IsCritical property is set
        internal bool IsSetIsCritical()
        {
            return this._isCritical.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsEnd. 
        /// <para>
        /// The flag which can be used to end automation no matter whether the step succeeds or
        /// fails.
        /// </para>
        /// </summary>
        public bool? IsEnd
        {
            get { return this._isEnd; }
            set { this._isEnd = value; }
        }

        // Check to see if IsEnd property is set
        internal bool IsSetIsEnd()
        {
            return this._isEnd.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxAttempts. 
        /// <para>
        /// The maximum number of tries to run the action of the step. The default value is <c>1</c>.
        /// </para>
        /// </summary>
        public int? MaxAttempts
        {
            get { return this._maxAttempts; }
            set { this._maxAttempts = value; }
        }

        // Check to see if MaxAttempts property is set
        internal bool IsSetMaxAttempts()
        {
            return this._maxAttempts.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextStep. 
        /// <para>
        /// The next step after the step succeeds.
        /// </para>
        /// </summary>
        public string NextStep
        {
            get { return this._nextStep; }
            set { this._nextStep = value; }
        }

        // Check to see if NextStep property is set
        internal bool IsSetNextStep()
        {
            return this._nextStep != null;
        }

        /// <summary>
        /// Gets and sets the property OnFailure. 
        /// <para>
        /// The action to take if the step fails. The default value is <c>Abort</c>.
        /// </para>
        /// </summary>
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
        /// Returned values from the execution of the step.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public Dictionary<string, List<string>> Outputs
        {
            get { return this._outputs; }
            set { this._outputs = value; }
        }

        // Check to see if Outputs property is set
        internal bool IsSetOutputs()
        {
            return this._outputs != null && (this._outputs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OverriddenParameters. 
        /// <para>
        /// A user-specified list of parameters to override when running a step.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public Dictionary<string, List<string>> OverriddenParameters
        {
            get { return this._overriddenParameters; }
            set { this._overriddenParameters = value; }
        }

        // Check to see if OverriddenParameters property is set
        internal bool IsSetOverriddenParameters()
        {
            return this._overriddenParameters != null && (this._overriddenParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ParentStepDetails. 
        /// <para>
        /// Information about the parent step.
        /// </para>
        /// </summary>
        public ParentStepDetails ParentStepDetails
        {
            get { return this._parentStepDetails; }
            set { this._parentStepDetails = value; }
        }

        // Check to see if ParentStepDetails property is set
        internal bool IsSetParentStepDetails()
        {
            return this._parentStepDetails != null;
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
        /// Gets and sets the property StepExecutionId. 
        /// <para>
        /// The unique ID of a step execution.
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
        /// The execution status for this step.
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

        /// <summary>
        /// Gets and sets the property TargetLocation. 
        /// <para>
        /// The combination of Amazon Web Services Regions and Amazon Web Services accounts targeted
        /// by the current Automation execution.
        /// </para>
        /// </summary>
        public TargetLocation TargetLocation
        {
            get { return this._targetLocation; }
            set { this._targetLocation = value; }
        }

        // Check to see if TargetLocation property is set
        internal bool IsSetTargetLocation()
        {
            return this._targetLocation != null;
        }

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// The targets for the step execution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<Target> Targets
        {
            get { return this._targets; }
            set { this._targets = value; }
        }

        // Check to see if Targets property is set
        internal bool IsSetTargets()
        {
            return this._targets != null && (this._targets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TimeoutSeconds. 
        /// <para>
        /// The timeout seconds of the step.
        /// </para>
        /// </summary>
        public long? TimeoutSeconds
        {
            get { return this._timeoutSeconds; }
            set { this._timeoutSeconds = value; }
        }

        // Check to see if TimeoutSeconds property is set
        internal bool IsSetTimeoutSeconds()
        {
            return this._timeoutSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TriggeredAlarms. 
        /// <para>
        /// The CloudWatch alarms that were invoked by the automation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<AlarmStateInformation> TriggeredAlarms
        {
            get { return this._triggeredAlarms; }
            set { this._triggeredAlarms = value; }
        }

        // Check to see if TriggeredAlarms property is set
        internal bool IsSetTriggeredAlarms()
        {
            return this._triggeredAlarms != null && (this._triggeredAlarms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ValidNextSteps. 
        /// <para>
        /// Strategies used when step fails, we support Continue and Abort. Abort will fail the
        /// automation when the step fails. Continue will ignore the failure of current step and
        /// allow automation to run the next step. With conditional branching, we add step:stepName
        /// to support the automation to go to another specific step.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ValidNextSteps
        {
            get { return this._validNextSteps; }
            set { this._validNextSteps = value; }
        }

        // Check to see if ValidNextSteps property is set
        internal bool IsSetValidNextSteps()
        {
            return this._validNextSteps != null && (this._validNextSteps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}