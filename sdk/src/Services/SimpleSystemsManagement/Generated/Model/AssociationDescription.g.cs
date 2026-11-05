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
    /// Describes the parameters for a document.
    /// </summary>
    public partial class AssociationDescription
    {
        /// <summary>
        /// Gets and sets the property AlarmConfiguration.
        /// </summary>
        public AlarmConfiguration AlarmConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AlarmConfiguration property is set.
        /// </summary>
        internal bool IsSetAlarmConfiguration() => this.AlarmConfiguration != null;

        /// <summary>
        /// Gets and sets the property ApplyOnlyAtCronInterval. 
        /// <para>
        /// By default, when you create a new associations, the system runs it immediately after
        /// it is created and then according to the schedule you specified. Specify this option
        /// if you don't want an association to run immediately after you create it. This parameter
        /// isn't supported for rate expressions.
        /// </para>
        /// </summary>
        public bool? ApplyOnlyAtCronInterval { get; set; }

        /// <summary>
        /// Checks to see if the ApplyOnlyAtCronInterval property is set.
        /// </summary>
        internal bool IsSetApplyOnlyAtCronInterval() => this.ApplyOnlyAtCronInterval.HasValue;

        /// <summary>
        /// Gets and sets the property AssociationDispatchAssumeRole. 
        /// <para>
        /// A role used by association to take actions on your behalf. State Manager will assume
        /// this role and call required APIs when dispatching configurations to nodes. If not
        /// specified, <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/using-service-linked-roles.html">
        /// service-linked role for Systems Manager</a> will be used by default. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string AssociationDispatchAssumeRole { get; set; }

        /// <summary>
        /// Checks to see if the AssociationDispatchAssumeRole property is set.
        /// </summary>
        internal bool IsSetAssociationDispatchAssumeRole() => this.AssociationDispatchAssumeRole != null;

        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The association ID.
        /// </para>
        /// </summary>
        public string AssociationId { get; set; }

        /// <summary>
        /// Checks to see if the AssociationId property is set.
        /// </summary>
        internal bool IsSetAssociationId() => this.AssociationId != null;

        /// <summary>
        /// Gets and sets the property AssociationName. 
        /// <para>
        /// The association name.
        /// </para>
        /// </summary>
        public string AssociationName { get; set; }

        /// <summary>
        /// Checks to see if the AssociationName property is set.
        /// </summary>
        internal bool IsSetAssociationName() => this.AssociationName != null;

        /// <summary>
        /// Gets and sets the property AssociationVersion. 
        /// <para>
        /// The association version.
        /// </para>
        /// </summary>
        public string AssociationVersion { get; set; }

        /// <summary>
        /// Checks to see if the AssociationVersion property is set.
        /// </summary>
        internal bool IsSetAssociationVersion() => this.AssociationVersion != null;

        /// <summary>
        /// Gets and sets the property AutomationTargetParameterName. 
        /// <para>
        /// Choose the parameter that will define how your automation will branch out. This target
        /// is required for associations that use an Automation runbook and target resources by
        /// using rate controls. Automation is a tool in Amazon Web Services Systems Manager.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string AutomationTargetParameterName { get; set; }

        /// <summary>
        /// Checks to see if the AutomationTargetParameterName property is set.
        /// </summary>
        internal bool IsSetAutomationTargetParameterName() => this.AutomationTargetParameterName != null;

        /// <summary>
        /// Gets and sets the property CalendarNames. 
        /// <para>
        /// The names or Amazon Resource Names (ARNs) of the Change Calendar type documents your
        /// associations are gated under. The associations only run when that change calendar
        /// is open. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/systems-manager-change-calendar">Amazon
        /// Web Services Systems Manager Change Calendar</a> in the <i>Amazon Web Services Systems
        /// Manager User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CalendarNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CalendarNames property is set.
        /// </summary>
        internal bool IsSetCalendarNames() => this.CalendarNames != null && (this.CalendarNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ComplianceSeverity. 
        /// <para>
        /// The severity level that is assigned to the association.
        /// </para>
        /// </summary>
        public AssociationComplianceSeverity ComplianceSeverity { get; set; }

        /// <summary>
        /// Checks to see if the ComplianceSeverity property is set.
        /// </summary>
        internal bool IsSetComplianceSeverity() => this.ComplianceSeverity != null;

        /// <summary>
        /// Gets and sets the property Date. 
        /// <para>
        /// The date when the association was made.
        /// </para>
        /// </summary>
        public DateTime? Date { get; set; }

        /// <summary>
        /// Checks to see if the Date property is set.
        /// </summary>
        internal bool IsSetDate() => this.Date.HasValue;

        /// <summary>
        /// Gets and sets the property DocumentVersion. 
        /// <para>
        /// The document version.
        /// </para>
        /// </summary>
        public string DocumentVersion { get; set; }

        /// <summary>
        /// Checks to see if the DocumentVersion property is set.
        /// </summary>
        internal bool IsSetDocumentVersion() => this.DocumentVersion != null;

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// The number of hours that an association can run on specified targets. After the resulting
        /// cutoff time passes, associations that are currently running are cancelled, and no
        /// pending executions are started on remaining targets.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 24)]
        public int? Duration { get; set; }

        /// <summary>
        /// Checks to see if the Duration property is set.
        /// </summary>
        internal bool IsSetDuration() => this.Duration.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The managed node ID.
        /// </para>
        /// </summary>
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property LastExecutionDate. 
        /// <para>
        /// The date on which the association was last run.
        /// </para>
        /// </summary>
        public DateTime? LastExecutionDate { get; set; }

        /// <summary>
        /// Checks to see if the LastExecutionDate property is set.
        /// </summary>
        internal bool IsSetLastExecutionDate() => this.LastExecutionDate.HasValue;

        /// <summary>
        /// Gets and sets the property LastSuccessfulExecutionDate. 
        /// <para>
        /// The last date on which the association was successfully run.
        /// </para>
        /// </summary>
        public DateTime? LastSuccessfulExecutionDate { get; set; }

        /// <summary>
        /// Checks to see if the LastSuccessfulExecutionDate property is set.
        /// </summary>
        internal bool IsSetLastSuccessfulExecutionDate() => this.LastSuccessfulExecutionDate.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdateAssociationDate. 
        /// <para>
        /// The date when the association was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateAssociationDate { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateAssociationDate property is set.
        /// </summary>
        internal bool IsSetLastUpdateAssociationDate() => this.LastUpdateAssociationDate.HasValue;

        /// <summary>
        /// Gets and sets the property MaxConcurrency. 
        /// <para>
        /// The maximum number of targets allowed to run the association at the same time. You
        /// can specify a number, for example 10, or a percentage of the target set, for example
        /// 10%. The default value is 100%, which means all targets run the association at the
        /// same time.
        /// </para>
        ///  
        /// <para>
        /// If a new managed node starts and attempts to run an association while Systems Manager
        /// is running <c>MaxConcurrency</c> associations, the association is allowed to run.
        /// During the next association interval, the new managed node will process its association
        /// within the limit specified for <c>MaxConcurrency</c>.
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
        /// The number of errors that are allowed before the system stops sending requests to
        /// run the association on additional targets. You can specify either an absolute number
        /// of errors, for example 10, or a percentage of the target set, for example 10%. If
        /// you specify 3, for example, the system stops sending requests when the fourth error
        /// is received. If you specify 0, then the system stops sending requests after the first
        /// error is returned. If you run an association on 50 managed nodes and set <c>MaxError</c>
        /// to 10%, then the system stops sending the request when the sixth error is received.
        /// </para>
        ///  
        /// <para>
        /// Executions that are already running an association when <c>MaxErrors</c> is reached
        /// are allowed to complete, but some of these executions may fail as well. If you need
        /// to ensure that there won't be more than max-errors failed executions, set <c>MaxConcurrency</c>
        /// to 1 so that executions proceed one at a time.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 7)]
        public string MaxErrors { get; set; }

        /// <summary>
        /// Checks to see if the MaxErrors property is set.
        /// </summary>
        internal bool IsSetMaxErrors() => this.MaxErrors != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the SSM document.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OutputLocation. 
        /// <para>
        /// An S3 bucket where you want to store the output details of the request.
        /// </para>
        /// </summary>
        public InstanceAssociationOutputLocation OutputLocation { get; set; }

        /// <summary>
        /// Checks to see if the OutputLocation property is set.
        /// </summary>
        internal bool IsSetOutputLocation() => this.OutputLocation != null;

        /// <summary>
        /// Gets and sets the property Overview. 
        /// <para>
        /// Information about the association.
        /// </para>
        /// </summary>
        public AssociationOverview Overview { get; set; }

        /// <summary>
        /// Checks to see if the Overview property is set.
        /// </summary>
        internal bool IsSetOverview() => this.Overview != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A description of the parameters for a document. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, List<string>> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ScheduleExpression. 
        /// <para>
        /// A cron expression that specifies a schedule when the association runs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ScheduleExpression { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleExpression property is set.
        /// </summary>
        internal bool IsSetScheduleExpression() => this.ScheduleExpression != null;

        /// <summary>
        /// Gets and sets the property ScheduleOffset. 
        /// <para>
        /// Number of days to wait after the scheduled day to run an association.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 6)]
        public int? ScheduleOffset { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleOffset property is set.
        /// </summary>
        internal bool IsSetScheduleOffset() => this.ScheduleOffset.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The association status.
        /// </para>
        /// </summary>
        public AssociationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SyncCompliance. 
        /// <para>
        /// The mode for generating association compliance. You can specify <c>AUTO</c> or <c>MANUAL</c>.
        /// In <c>AUTO</c> mode, the system uses the status of the association execution to determine
        /// the compliance status. If the association execution runs successfully, then the association
        /// is <c>COMPLIANT</c>. If the association execution doesn't run successfully, the association
        /// is <c>NON-COMPLIANT</c>.
        /// </para>
        ///  
        /// <para>
        /// In <c>MANUAL</c> mode, you must specify the <c>AssociationId</c> as a parameter for
        /// the <a>PutComplianceItems</a> API operation. In this case, compliance data isn't managed
        /// by State Manager, a tool in Amazon Web Services Systems Manager. It is managed by
        /// your direct call to the <a>PutComplianceItems</a> API operation.
        /// </para>
        ///  
        /// <para>
        /// By default, all associations use <c>AUTO</c> mode.
        /// </para>
        /// </summary>
        public AssociationSyncCompliance SyncCompliance { get; set; }

        /// <summary>
        /// Checks to see if the SyncCompliance property is set.
        /// </summary>
        internal bool IsSetSyncCompliance() => this.SyncCompliance != null;

        /// <summary>
        /// Gets and sets the property TargetLocations. 
        /// <para>
        /// The combination of Amazon Web Services Regions and Amazon Web Services accounts where
        /// you want to run the association.
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
        /// Gets and sets the property TargetMaps. 
        /// <para>
        /// A key-value mapping of document parameters to target resources. Both Targets and TargetMaps
        /// can't be specified together.
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
        /// Gets and sets the property Targets. 
        /// <para>
        /// The managed nodes targeted by the request. 
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
        /// The CloudWatch alarm that was invoked during the association.
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
    }
}
