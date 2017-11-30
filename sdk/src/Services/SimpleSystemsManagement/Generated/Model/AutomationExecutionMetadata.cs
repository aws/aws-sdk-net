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
    /// Details about a specific Automation execution.
    /// </summary>
    public partial class AutomationExecutionMetadata
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
        private string _logFile;
        private string _maxConcurrency;
        private string _maxErrors;
        private ExecutionMode _mode;
        private Dictionary<string, List<string>> _outputs = new Dictionary<string, List<string>>();
        private string _parentAutomationExecutionId;
        private ResolvedTargets _resolvedTargets;
        private string _target;
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
        /// The status of the execution. Valid values include: Running, Succeeded, Failed, Timed
        /// out, or Cancelled.
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
        /// The name of the Automation document used during execution.
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
        /// The document version used during the execution.
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
        /// The IAM role ARN of the user who executed the Automation.
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
        /// The time the execution finished. This is not populated if the execution is still in
        /// progress.
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
        /// The time the execution started.&gt;
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
        /// The list of execution outputs as defined in the Automation document.
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
        /// Gets and sets the property LogFile. 
        /// <para>
        /// An Amazon S3 bucket where execution information is stored.
        /// </para>
        /// </summary>
        public string LogFile
        {
            get { return this._logFile; }
            set { this._logFile = value; }
        }

        // Check to see if LogFile property is set
        internal bool IsSetLogFile()
        {
            return this._logFile != null;
        }

        /// <summary>
        /// Gets and sets the property MaxConcurrency. 
        /// <para>
        /// The MaxConcurrency value specified by the user when starting the Automation.
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
        /// The MaxErrors value specified by the user when starting the Automation.
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
        /// The Automation execution mode.
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
        /// The list of execution outputs as defined in the Automation document.
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
        /// Gets and sets the property ParentAutomationExecutionId. 
        /// <para>
        /// The ExecutionId of the parent Automation.
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
        /// A list of targets that resolved during the execution.
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
        /// Gets and sets the property Target. 
        /// <para>
        /// The list of execution outputs as defined in the Automation document.
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
        /// Gets and sets the property TargetParameterName. 
        /// <para>
        /// The list of execution outputs as defined in the Automation document.
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
        /// The targets defined by the user when starting the Automation.
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