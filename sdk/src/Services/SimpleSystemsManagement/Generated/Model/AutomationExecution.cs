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
    /// Detailed information about the current state of an individual Automation execution.
    /// </summary>
    public partial class AutomationExecution
    {
        private string _automationExecutionId;
        private AutomationExecutionStatus _automationExecutionStatus;
        private string _currentAction;
        private string _currentStepName;
        private string _documentName;
        private string _documentVersion;
        private string _executedBy;
        private DateTime? _executionEndTime;
        private DateTime? _executionStartTime;
        private string _failureMessage;
        private string _maxConcurrency;
        private string _maxErrors;
        private ExecutionMode _mode;
        private Dictionary<string, List<string>> _outputs = new Dictionary<string, List<string>>();
        private Dictionary<string, List<string>> _parameters = new Dictionary<string, List<string>>();
        private string _parentAutomationExecutionId;
        private ResolvedTargets _resolvedTargets;
        private List<StepExecution> _stepExecutions = new List<StepExecution>();
        private bool? _stepExecutionsTruncated;
        private string _target;
        private List<Dictionary<string, List<string>>> _targetMaps = new List<Dictionary<string, List<string>>>();
        private string _targetParameterName;
        private List<Target> _targets = new List<Target>();

        /// <summary>
        /// Gets and sets the property AutomationExecutionId. 
        /// <para>
        /// The execution ID.
        /// </para>
        /// </summary>
        public string AutomationExecutionId
        {
            get { return this._automationExecutionId; }
            set { this._automationExecutionId = value; }
        }

        // Check to see if AutomationExecutionId property is set
        internal bool IsSetAutomationExecutionId()
        {
            return this._automationExecutionId != null;
        }

        /// <summary>
        /// Gets and sets the property AutomationExecutionStatus. 
        /// <para>
        /// The execution status of the Automation.
        /// </para>
        /// </summary>
        public AutomationExecutionStatus AutomationExecutionStatus
        {
            get { return this._automationExecutionStatus; }
            set { this._automationExecutionStatus = value; }
        }

        // Check to see if AutomationExecutionStatus property is set
        internal bool IsSetAutomationExecutionStatus()
        {
            return this._automationExecutionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentAction. 
        /// <para>
        /// The action of the currently executing step.
        /// </para>
        /// </summary>
        public string CurrentAction
        {
            get { return this._currentAction; }
            set { this._currentAction = value; }
        }

        // Check to see if CurrentAction property is set
        internal bool IsSetCurrentAction()
        {
            return this._currentAction != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentStepName. 
        /// <para>
        /// The name of the currently executing step.
        /// </para>
        /// </summary>
        public string CurrentStepName
        {
            get { return this._currentStepName; }
            set { this._currentStepName = value; }
        }

        // Check to see if CurrentStepName property is set
        internal bool IsSetCurrentStepName()
        {
            return this._currentStepName != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentName. 
        /// <para>
        /// The name of the Automation document used during the execution.
        /// </para>
        /// </summary>
        public string DocumentName
        {
            get { return this._documentName; }
            set { this._documentName = value; }
        }

        // Check to see if DocumentName property is set
        internal bool IsSetDocumentName()
        {
            return this._documentName != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentVersion. 
        /// <para>
        /// The version of the document to use during execution.
        /// </para>
        /// </summary>
        public string DocumentVersion
        {
            get { return this._documentVersion; }
            set { this._documentVersion = value; }
        }

        // Check to see if DocumentVersion property is set
        internal bool IsSetDocumentVersion()
        {
            return this._documentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutedBy. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user who executed the automation.
        /// </para>
        /// </summary>
        public string ExecutedBy
        {
            get { return this._executedBy; }
            set { this._executedBy = value; }
        }

        // Check to see if ExecutedBy property is set
        internal bool IsSetExecutedBy()
        {
            return this._executedBy != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionEndTime. 
        /// <para>
        /// The time the execution finished.
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
        /// The time the execution started.
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
        /// A message describing why an execution has failed, if the status is set to Failed.
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
        /// Gets and sets the property MaxConcurrency. 
        /// <para>
        /// The MaxConcurrency value specified by the user when the execution started.
        /// </para>
        /// </summary>
        public string MaxConcurrency
        {
            get { return this._maxConcurrency; }
            set { this._maxConcurrency = value; }
        }

        // Check to see if MaxConcurrency property is set
        internal bool IsSetMaxConcurrency()
        {
            return this._maxConcurrency != null;
        }

        /// <summary>
        /// Gets and sets the property MaxErrors. 
        /// <para>
        /// The MaxErrors value specified by the user when the execution started.
        /// </para>
        /// </summary>
        public string MaxErrors
        {
            get { return this._maxErrors; }
            set { this._maxErrors = value; }
        }

        // Check to see if MaxErrors property is set
        internal bool IsSetMaxErrors()
        {
            return this._maxErrors != null;
        }

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The automation execution mode.
        /// </para>
        /// </summary>
        public ExecutionMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

        /// <summary>
        /// Gets and sets the property Outputs. 
        /// <para>
        /// The list of execution outputs as defined in the automation document.
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
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The key-value map of execution parameters, which were supplied when calling StartAutomationExecution.
        /// </para>
        /// </summary>
        public Dictionary<string, List<string>> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ParentAutomationExecutionId. 
        /// <para>
        /// The AutomationExecutionId of the parent automation.
        /// </para>
        /// </summary>
        public string ParentAutomationExecutionId
        {
            get { return this._parentAutomationExecutionId; }
            set { this._parentAutomationExecutionId = value; }
        }

        // Check to see if ParentAutomationExecutionId property is set
        internal bool IsSetParentAutomationExecutionId()
        {
            return this._parentAutomationExecutionId != null;
        }

        /// <summary>
        /// Gets and sets the property ResolvedTargets. 
        /// <para>
        /// A list of resolved targets in the rate control execution.
        /// </para>
        /// </summary>
        public ResolvedTargets ResolvedTargets
        {
            get { return this._resolvedTargets; }
            set { this._resolvedTargets = value; }
        }

        // Check to see if ResolvedTargets property is set
        internal bool IsSetResolvedTargets()
        {
            return this._resolvedTargets != null;
        }

        /// <summary>
        /// Gets and sets the property StepExecutions. 
        /// <para>
        /// A list of details about the current state of all steps that comprise an execution.
        /// An Automation document contains a list of steps that are executed in order.
        /// </para>
        /// </summary>
        public List<StepExecution> StepExecutions
        {
            get { return this._stepExecutions; }
            set { this._stepExecutions = value; }
        }

        // Check to see if StepExecutions property is set
        internal bool IsSetStepExecutions()
        {
            return this._stepExecutions != null && this._stepExecutions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StepExecutionsTruncated. 
        /// <para>
        /// A boolean value that indicates if the response contains the full list of the Automation
        /// step executions. If true, use the DescribeAutomationStepExecutions API action to get
        /// the full list of step executions.
        /// </para>
        /// </summary>
        public bool StepExecutionsTruncated
        {
            get { return this._stepExecutionsTruncated.GetValueOrDefault(); }
            set { this._stepExecutionsTruncated = value; }
        }

        // Check to see if StepExecutionsTruncated property is set
        internal bool IsSetStepExecutionsTruncated()
        {
            return this._stepExecutionsTruncated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The target of the execution.
        /// </para>
        /// </summary>
        public string Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

        /// <summary>
        /// Gets and sets the property TargetMaps. 
        /// <para>
        /// The specified key-value mapping of document parameters to target resources.
        /// </para>
        /// </summary>
        public List<Dictionary<string, List<string>>> TargetMaps
        {
            get { return this._targetMaps; }
            set { this._targetMaps = value; }
        }

        // Check to see if TargetMaps property is set
        internal bool IsSetTargetMaps()
        {
            return this._targetMaps != null && this._targetMaps.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TargetParameterName. 
        /// <para>
        /// The parameter name.
        /// </para>
        /// </summary>
        public string TargetParameterName
        {
            get { return this._targetParameterName; }
            set { this._targetParameterName = value; }
        }

        // Check to see if TargetParameterName property is set
        internal bool IsSetTargetParameterName()
        {
            return this._targetParameterName != null;
        }

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// The specified targets.
        /// </para>
        /// </summary>
        public List<Target> Targets
        {
            get { return this._targets; }
            set { this._targets = value; }
        }

        // Check to see if Targets property is set
        internal bool IsSetTargets()
        {
            return this._targets != null && this._targets.Count > 0; 
        }

    }
}