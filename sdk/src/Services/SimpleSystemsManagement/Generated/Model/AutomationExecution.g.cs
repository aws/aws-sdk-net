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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Detailed information about the current state of an individual Automation execution.
    /// </summary>
    public partial class AutomationExecution
    {
        /// <summary>
        /// Gets and sets the property AlarmConfiguration. 
        /// <para>
        /// The details for the CloudWatch alarm applied to your automation.
        /// </para>
        /// </summary>
        public AlarmConfiguration AlarmConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AlarmConfiguration property is set.
        /// </summary>
        internal bool IsSetAlarmConfiguration() => this.AlarmConfiguration != null;

        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The ID of a State Manager association used in the Automation operation.
        /// </para>
        /// </summary>
        public string AssociationId { get; set; }

        /// <summary>
        /// Checks to see if the AssociationId property is set.
        /// </summary>
        internal bool IsSetAssociationId() => this.AssociationId != null;

        /// <summary>
        /// Gets and sets the property AutomationExecutionId. 
        /// <para>
        /// The execution ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string AutomationExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the AutomationExecutionId property is set.
        /// </summary>
        internal bool IsSetAutomationExecutionId() => this.AutomationExecutionId != null;

        /// <summary>
        /// Gets and sets the property AutomationExecutionStatus. 
        /// <para>
        /// The execution status of the Automation.
        /// </para>
        /// </summary>
        public AutomationExecutionStatus AutomationExecutionStatus { get; set; }

        /// <summary>
        /// Checks to see if the AutomationExecutionStatus property is set.
        /// </summary>
        internal bool IsSetAutomationExecutionStatus() => this.AutomationExecutionStatus != null;

        /// <summary>
        /// Gets and sets the property AutomationSubtype. 
        /// <para>
        /// The subtype of the Automation operation. Currently, the only supported value is <c>ChangeRequest</c>.
        /// </para>
        /// </summary>
        public AutomationSubtype AutomationSubtype { get; set; }

        /// <summary>
        /// Checks to see if the AutomationSubtype property is set.
        /// </summary>
        internal bool IsSetAutomationSubtype() => this.AutomationSubtype != null;

        /// <summary>
        /// Gets and sets the property ChangeRequestName. 
        /// <para>
        /// The name of the Change Manager change request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ChangeRequestName { get; set; }

        /// <summary>
        /// Checks to see if the ChangeRequestName property is set.
        /// </summary>
        internal bool IsSetChangeRequestName() => this.ChangeRequestName != null;

        /// <summary>
        /// Gets and sets the property CurrentAction. 
        /// <para>
        /// The action of the step that is currently running.
        /// </para>
        /// </summary>
        public string CurrentAction { get; set; }

        /// <summary>
        /// Checks to see if the CurrentAction property is set.
        /// </summary>
        internal bool IsSetCurrentAction() => this.CurrentAction != null;

        /// <summary>
        /// Gets and sets the property CurrentStepName. 
        /// <para>
        /// The name of the step that is currently running.
        /// </para>
        /// </summary>
        public string CurrentStepName { get; set; }

        /// <summary>
        /// Checks to see if the CurrentStepName property is set.
        /// </summary>
        internal bool IsSetCurrentStepName() => this.CurrentStepName != null;

        /// <summary>
        /// Gets and sets the property DocumentName. 
        /// <para>
        /// The name of the Automation runbook used during the execution.
        /// </para>
        /// </summary>
        public string DocumentName { get; set; }

        /// <summary>
        /// Checks to see if the DocumentName property is set.
        /// </summary>
        internal bool IsSetDocumentName() => this.DocumentName != null;

        /// <summary>
        /// Gets and sets the property DocumentVersion. 
        /// <para>
        /// The version of the document to use during execution.
        /// </para>
        /// </summary>
        public string DocumentVersion { get; set; }

        /// <summary>
        /// Checks to see if the DocumentVersion property is set.
        /// </summary>
        internal bool IsSetDocumentVersion() => this.DocumentVersion != null;

        /// <summary>
        /// Gets and sets the property ExecutedBy. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user who ran the automation.
        /// </para>
        /// </summary>
        public string ExecutedBy { get; set; }

        /// <summary>
        /// Checks to see if the ExecutedBy property is set.
        /// </summary>
        internal bool IsSetExecutedBy() => this.ExecutedBy != null;

        /// <summary>
        /// Gets and sets the property ExecutionEndTime. 
        /// <para>
        /// The time the execution finished.
        /// </para>
        /// </summary>
        public DateTime? ExecutionEndTime { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionEndTime property is set.
        /// </summary>
        internal bool IsSetExecutionEndTime() => this.ExecutionEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ExecutionStartTime. 
        /// <para>
        /// The time the execution started.
        /// </para>
        /// </summary>
        public DateTime? ExecutionStartTime { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionStartTime property is set.
        /// </summary>
        internal bool IsSetExecutionStartTime() => this.ExecutionStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        /// A message describing why an execution has failed, if the status is set to Failed.
        /// </para>
        /// </summary>
        public string FailureMessage { get; set; }

        /// <summary>
        /// Checks to see if the FailureMessage property is set.
        /// </summary>
        internal bool IsSetFailureMessage() => this.FailureMessage != null;

        /// <summary>
        /// Gets and sets the property MaxConcurrency. 
        /// <para>
        /// The <c>MaxConcurrency</c> value specified by the user when the execution started.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 7)]
        public string MaxConcurrency { get; set; }

        /// <summary>
        /// Checks to see if the MaxConcurrency property is set.
        /// </summary>
        internal bool IsSetMaxConcurrency() => this.MaxConcurrency != null;

        /// <summary>
        /// Gets and sets the property MaxErrors. 
        /// <para>
        /// The MaxErrors value specified by the user when the execution started.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 7)]
        public string MaxErrors { get; set; }

        /// <summary>
        /// Checks to see if the MaxErrors property is set.
        /// </summary>
        internal bool IsSetMaxErrors() => this.MaxErrors != null;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The automation execution mode.
        /// </para>
        /// </summary>
        public ExecutionMode Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;

        /// <summary>
        /// Gets and sets the property OpsItemId. 
        /// <para>
        /// The ID of an OpsItem that is created to represent a Change Manager change request.
        /// </para>
        /// </summary>
        public string OpsItemId { get; set; }

        /// <summary>
        /// Checks to see if the OpsItemId property is set.
        /// </summary>
        internal bool IsSetOpsItemId() => this.OpsItemId != null;

        /// <summary>
        /// Gets and sets the property Outputs. 
        /// <para>
        /// The list of execution outputs as defined in the Automation runbook.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public Dictionary<string, List<string>> Outputs { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the Outputs property is set.
        /// </summary>
        internal bool IsSetOutputs() => this.Outputs != null && (this.Outputs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The key-value map of execution parameters, which were supplied when calling <a>StartAutomationExecution</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public Dictionary<string, List<string>> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ParentAutomationExecutionId. 
        /// <para>
        /// The AutomationExecutionId of the parent automation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string ParentAutomationExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the ParentAutomationExecutionId property is set.
        /// </summary>
        internal bool IsSetParentAutomationExecutionId() => this.ParentAutomationExecutionId != null;

        /// <summary>
        /// Gets and sets the property ProgressCounters. 
        /// <para>
        /// An aggregate of step execution statuses displayed in the Amazon Web Services Systems
        /// Manager console for a multi-Region and multi-account Automation execution.
        /// </para>
        /// </summary>
        public ProgressCounters ProgressCounters { get; set; }

        /// <summary>
        /// Checks to see if the ProgressCounters property is set.
        /// </summary>
        internal bool IsSetProgressCounters() => this.ProgressCounters != null;

        /// <summary>
        /// Gets and sets the property ResolvedTargets. 
        /// <para>
        /// A list of resolved targets in the rate control execution.
        /// </para>
        /// </summary>
        public ResolvedTargets ResolvedTargets { get; set; }

        /// <summary>
        /// Checks to see if the ResolvedTargets property is set.
        /// </summary>
        internal bool IsSetResolvedTargets() => this.ResolvedTargets != null;

        /// <summary>
        /// Gets and sets the property Runbooks. 
        /// <para>
        /// Information about the Automation runbooks that are run as part of a runbook workflow.
        /// </para>
        ///  <note> 
        /// <para>
        /// The Automation runbooks specified for the runbook workflow can't run until all required
        /// approvals for the change request have been received.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<Runbook> Runbooks { get; set; } = AWSConfigs.InitializeCollections ? new List<Runbook>() : null;

        /// <summary>
        /// Checks to see if the Runbooks property is set.
        /// </summary>
        internal bool IsSetRunbooks() => this.Runbooks != null && (this.Runbooks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ScheduledTime. 
        /// <para>
        /// The date and time the Automation operation is scheduled to start.
        /// </para>
        /// </summary>
        public DateTime? ScheduledTime { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledTime property is set.
        /// </summary>
        internal bool IsSetScheduledTime() => this.ScheduledTime.HasValue;

        /// <summary>
        /// Gets and sets the property StepExecutions. 
        /// <para>
        /// A list of details about the current state of all steps that comprise an execution.
        /// An Automation runbook contains a list of steps that are run in order.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StepExecution> StepExecutions { get; set; } = AWSConfigs.InitializeCollections ? new List<StepExecution>() : null;

        /// <summary>
        /// Checks to see if the StepExecutions property is set.
        /// </summary>
        internal bool IsSetStepExecutions() => this.StepExecutions != null && (this.StepExecutions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StepExecutionsTruncated. 
        /// <para>
        /// A boolean value that indicates if the response contains the full list of the Automation
        /// step executions. If true, use the DescribeAutomationStepExecutions API operation to
        /// get the full list of step executions.
        /// </para>
        /// </summary>
        public bool? StepExecutionsTruncated { get; set; }

        /// <summary>
        /// Checks to see if the StepExecutionsTruncated property is set.
        /// </summary>
        internal bool IsSetStepExecutionsTruncated() => this.StepExecutionsTruncated.HasValue;

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The target of the execution.
        /// </para>
        /// </summary>
        public string Target { get; set; }

        /// <summary>
        /// Checks to see if the Target property is set.
        /// </summary>
        internal bool IsSetTarget() => this.Target != null;

        /// <summary>
        /// Gets and sets the property TargetLocations. 
        /// <para>
        /// The combination of Amazon Web Services Regions and/or Amazon Web Services accounts
        /// where you want to run the Automation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<TargetLocation> TargetLocations { get; set; } = AWSConfigs.InitializeCollections ? new List<TargetLocation>() : null;

        /// <summary>
        /// Checks to see if the TargetLocations property is set.
        /// </summary>
        internal bool IsSetTargetLocations() => this.TargetLocations != null && (this.TargetLocations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetLocationsURL. 
        /// <para>
        /// A publicly accessible URL for a file that contains the <c>TargetLocations</c> body.
        /// Currently, only files in presigned Amazon S3 buckets are supported
        /// </para>
        /// </summary>
        public string TargetLocationsURL { get; set; }

        /// <summary>
        /// Checks to see if the TargetLocationsURL property is set.
        /// </summary>
        internal bool IsSetTargetLocationsURL() => this.TargetLocationsURL != null;

        /// <summary>
        /// Gets and sets the property TargetMaps. 
        /// <para>
        /// The specified key-value mapping of document parameters to target resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 300)]
        public List<Dictionary<string, List<string>>> TargetMaps { get; set; } = AWSConfigs.InitializeCollections ? new List<Dictionary<string, List<string>>>() : null;

        /// <summary>
        /// Checks to see if the TargetMaps property is set.
        /// </summary>
        internal bool IsSetTargetMaps() => this.TargetMaps != null && (this.TargetMaps.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetParameterName. 
        /// <para>
        /// The parameter name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string TargetParameterName { get; set; }

        /// <summary>
        /// Checks to see if the TargetParameterName property is set.
        /// </summary>
        internal bool IsSetTargetParameterName() => this.TargetParameterName != null;

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// The specified targets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<Target> Targets { get; set; } = AWSConfigs.InitializeCollections ? new List<Target>() : null;

        /// <summary>
        /// Checks to see if the Targets property is set.
        /// </summary>
        internal bool IsSetTargets() => this.Targets != null && (this.Targets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TriggeredAlarms. 
        /// <para>
        /// The CloudWatch alarm that was invoked by the automation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<AlarmStateInformation> TriggeredAlarms { get; set; } = AWSConfigs.InitializeCollections ? new List<AlarmStateInformation>() : null;

        /// <summary>
        /// Checks to see if the TriggeredAlarms property is set.
        /// </summary>
        internal bool IsSetTriggeredAlarms() => this.TriggeredAlarms != null && (this.TriggeredAlarms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Variables. 
        /// <para>
        /// Variables defined for the automation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public Dictionary<string, List<string>> Variables { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the Variables property is set.
        /// </summary>
        internal bool IsSetVariables() => this.Variables != null && (this.Variables.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WarningMessage. 
        /// <para>
        /// A message that describes a non-critical issue that occurred during the automation
        /// execution.
        /// </para>
        /// </summary>
        public string WarningMessage { get; set; }

        /// <summary>
        /// Checks to see if the WarningMessage property is set.
        /// </summary>
        internal bool IsSetWarningMessage() => this.WarningMessage != null;
    }
}
