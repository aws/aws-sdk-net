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
    /// Details about a specific Automation execution.
    /// </summary>
    public partial class AutomationExecutionMetadata
    {
        private AlarmConfiguration _alarmConfiguration;
        private string _associationId;
        private string _automationExecutionId;
        private AutomationExecutionStatus _automationExecutionStatus;
        private AutomationSubtype _automationSubtype;
        private AutomationType _automationType;
        private string _changeRequestName;
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
        private string _opsItemId;
        private Dictionary<string, List<string>> _outputs = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private string _parentAutomationExecutionId;
        private ResolvedTargets _resolvedTargets;
        private List<Runbook> _runbooks = AWSConfigs.InitializeCollections ? new List<Runbook>() : null;
        private DateTime? _scheduledTime;
        private string _target;
        private string _targetLocationsURL;
        private List<Dictionary<string, List<string>>> _targetMaps = AWSConfigs.InitializeCollections ? new List<Dictionary<string, List<string>>>() : null;
        private string _targetParameterName;
        private List<Target> _targets = AWSConfigs.InitializeCollections ? new List<Target>() : null;
        private List<AlarmStateInformation> _triggeredAlarms = AWSConfigs.InitializeCollections ? new List<AlarmStateInformation>() : null;

        /// <summary>
        /// Gets and sets the property AlarmConfiguration. 
        /// <para>
        /// The details for the CloudWatch alarm applied to your automation.
        /// </para>
        /// </summary>
        public AlarmConfiguration AlarmConfiguration
        {
            get { return this._alarmConfiguration; }
            set { this._alarmConfiguration = value; }
        }

        // Check to see if AlarmConfiguration property is set
        internal bool IsSetAlarmConfiguration()
        {
            return this._alarmConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The ID of a State Manager association used in the Automation operation.
        /// </para>
        /// </summary>
        public string AssociationId
        {
            get { return this._associationId; }
            set { this._associationId = value; }
        }

        // Check to see if AssociationId property is set
        internal bool IsSetAssociationId()
        {
            return this._associationId != null;
        }

        /// <summary>
        /// Gets and sets the property AutomationExecutionId. 
        /// <para>
        /// The execution ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
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
        /// The status of the execution.
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
        /// Gets and sets the property AutomationSubtype. 
        /// <para>
        /// The subtype of the Automation operation. Currently, the only supported value is <c>ChangeRequest</c>.
        /// </para>
        /// </summary>
        public AutomationSubtype AutomationSubtype
        {
            get { return this._automationSubtype; }
            set { this._automationSubtype = value; }
        }

        // Check to see if AutomationSubtype property is set
        internal bool IsSetAutomationSubtype()
        {
            return this._automationSubtype != null;
        }

        /// <summary>
        /// Gets and sets the property AutomationType. 
        /// <para>
        /// Use this filter with <a>DescribeAutomationExecutions</a>. Specify either Local or
        /// CrossAccount. CrossAccount is an Automation that runs in multiple Amazon Web Services
        /// Regions and Amazon Web Services accounts. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/systems-manager-automation-multiple-accounts-and-regions.html">Running
        /// automations in multiple Amazon Web Services Regions and accounts</a> in the <i>Amazon
        /// Web Services Systems Manager User Guide</i>. 
        /// </para>
        /// </summary>
        public AutomationType AutomationType
        {
            get { return this._automationType; }
            set { this._automationType = value; }
        }

        // Check to see if AutomationType property is set
        internal bool IsSetAutomationType()
        {
            return this._automationType != null;
        }

        /// <summary>
        /// Gets and sets the property ChangeRequestName. 
        /// <para>
        /// The name of the Change Manager change request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ChangeRequestName
        {
            get { return this._changeRequestName; }
            set { this._changeRequestName = value; }
        }

        // Check to see if ChangeRequestName property is set
        internal bool IsSetChangeRequestName()
        {
            return this._changeRequestName != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentAction. 
        /// <para>
        /// The action of the step that is currently running.
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
        /// The name of the step that is currently running.
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
        /// The name of the Automation runbook used during execution.
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
        /// The IAM role ARN of the user who ran the automation.
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
        /// The time the execution finished. This isn't populated if the execution is still in
        /// progress.
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
        /// The time the execution started.
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
        /// Gets and sets the property FailureMessage. 
        /// <para>
        /// The list of execution outputs as defined in the Automation runbook.
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
        /// An S3 bucket where execution information is stored.
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
        /// The <c>MaxConcurrency</c> value specified by the user when starting the automation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=7)]
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
        /// The <c>MaxErrors</c> value specified by the user when starting the automation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=7)]
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
        /// Gets and sets the property OpsItemId. 
        /// <para>
        /// The ID of an OpsItem that is created to represent a Change Manager change request.
        /// </para>
        /// </summary>
        public string OpsItemId
        {
            get { return this._opsItemId; }
            set { this._opsItemId = value; }
        }

        // Check to see if OpsItemId property is set
        internal bool IsSetOpsItemId()
        {
            return this._opsItemId != null;
        }

        /// <summary>
        /// Gets and sets the property Outputs. 
        /// <para>
        /// The list of execution outputs as defined in the Automation runbook.
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
        /// Gets and sets the property ParentAutomationExecutionId. 
        /// <para>
        /// The execution ID of the parent automation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
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
        /// Gets and sets the property Runbooks. 
        /// <para>
        /// Information about the Automation runbooks that are run during a runbook workflow in
        /// Change Manager.
        /// </para>
        ///  <note> 
        /// <para>
        /// The Automation runbooks specified for the runbook workflow can't run until all required
        /// approvals for the change request have been received.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<Runbook> Runbooks
        {
            get { return this._runbooks; }
            set { this._runbooks = value; }
        }

        // Check to see if Runbooks property is set
        internal bool IsSetRunbooks()
        {
            return this._runbooks != null && (this._runbooks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScheduledTime. 
        /// <para>
        /// The date and time the Automation operation is scheduled to start.
        /// </para>
        /// </summary>
        public DateTime? ScheduledTime
        {
            get { return this._scheduledTime; }
            set { this._scheduledTime = value; }
        }

        // Check to see if ScheduledTime property is set
        internal bool IsSetScheduledTime()
        {
            return this._scheduledTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The list of execution outputs as defined in the Automation runbook.
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
        /// Gets and sets the property TargetLocationsURL. 
        /// <para>
        /// A publicly accessible URL for a file that contains the <c>TargetLocations</c> body.
        /// Currently, only files in presigned Amazon S3 buckets are supported
        /// </para>
        /// </summary>
        public string TargetLocationsURL
        {
            get { return this._targetLocationsURL; }
            set { this._targetLocationsURL = value; }
        }

        // Check to see if TargetLocationsURL property is set
        internal bool IsSetTargetLocationsURL()
        {
            return this._targetLocationsURL != null;
        }

        /// <summary>
        /// Gets and sets the property TargetMaps. 
        /// <para>
        /// The specified key-value mapping of document parameters to target resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=300)]
        public List<Dictionary<string, List<string>>> TargetMaps
        {
            get { return this._targetMaps; }
            set { this._targetMaps = value; }
        }

        // Check to see if TargetMaps property is set
        internal bool IsSetTargetMaps()
        {
            return this._targetMaps != null && (this._targetMaps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetParameterName. 
        /// <para>
        /// The list of execution outputs as defined in the Automation runbook.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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
        /// The targets defined by the user when starting the automation.
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
        /// Gets and sets the property TriggeredAlarms. 
        /// <para>
        /// The CloudWatch alarm that was invoked by the automation.
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

    }
}