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
    /// Container for the parameters to the UpdateAssociation operation.
    /// Updates an association. You can update the association name and version, the document
    /// version, schedule, parameters, and Amazon Simple Storage Service (Amazon S3) output.
    /// When you call <c>UpdateAssociation</c>, the system removes all optional parameters
    /// from the request and overwrites the association with null values for those parameters.
    /// This is by design. You must specify all optional parameters in the call, even if you
    /// are not changing the parameters. This includes the <c>Name</c> parameter. Before calling
    /// this API action, we recommend that you call the <a>DescribeAssociation</a> API operation
    /// and make a note of all optional parameters required for your <c>UpdateAssociation</c>
    /// call.
    /// 
    ///  
    /// <para>
    /// In order to call this API operation, a user, group, or role must be granted permission
    /// to call the <a>DescribeAssociation</a> API operation. If you don't have permission
    /// to call <c>DescribeAssociation</c>, then you receive the following error: <c>An error
    /// occurred (AccessDeniedException) when calling the UpdateAssociation operation: User:
    /// &lt;user_arn&gt; isn't authorized to perform: ssm:DescribeAssociation on resource:
    /// &lt;resource_arn&gt;</c> 
    /// </para>
    ///  <important> 
    /// <para>
    /// When you update an association, the association immediately runs against the specified
    /// targets. You can add the <c>ApplyOnlyAtCronInterval</c> parameter to run the association
    /// during the next schedule run.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class UpdateAssociationRequest : AmazonSimpleSystemsManagementRequest
    {
        private AlarmConfiguration _alarmConfiguration;
        private bool? _applyOnlyAtCronInterval;
        private string _associationId;
        private string _associationName;
        private string _associationVersion;
        private string _automationTargetParameterName;
        private List<string> _calendarNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private AssociationComplianceSeverity _complianceSeverity;
        private string _documentVersion;
        private int? _duration;
        private string _maxConcurrency;
        private string _maxErrors;
        private string _name;
        private InstanceAssociationOutputLocation _outputLocation;
        private Dictionary<string, List<string>> _parameters = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private string _scheduleExpression;
        private int? _scheduleOffset;
        private AssociationSyncCompliance _syncCompliance;
        private List<TargetLocation> _targetLocations = AWSConfigs.InitializeCollections ? new List<TargetLocation>() : null;
        private List<Dictionary<string, List<string>>> _targetMaps = AWSConfigs.InitializeCollections ? new List<Dictionary<string, List<string>>>() : null;
        private List<Target> _targets = AWSConfigs.InitializeCollections ? new List<Target>() : null;

        /// <summary>
        /// Gets and sets the property AlarmConfiguration.
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
        /// Gets and sets the property ApplyOnlyAtCronInterval. 
        /// <para>
        /// By default, when you update an association, the system runs it immediately after it
        /// is updated and then according to the schedule you specified. Specify <c>true</c> for
        /// <c>ApplyOnlyAtCronInterval</c> if you want the association to run only according to
        /// the schedule you specified.
        /// </para>
        ///  
        /// <para>
        /// If you chose this option when you created an association and later you edit that association
        /// or you make changes to the Automation runbook or SSM document on which that association
        /// is based, State Manager applies the association at the next specified cron interval.
        /// For example, if you chose the <c>Latest</c> version of an SSM document when you created
        /// an association and you edit the association by choosing a different document version
        /// on the Documents page, State Manager applies the association at the next specified
        /// cron interval if you previously set <c>ApplyOnlyAtCronInterval</c> to <c>true</c>.
        /// If this option wasn't selected, State Manager immediately runs the association.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/state-manager-about.html#state-manager-about-scheduling">Understanding
        /// when associations are applied to resources</a> and <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/state-manager-about.html#runbook-target-updates">About
        /// target updates with Automation runbooks</a> in the <i>Amazon Web Services Systems
        /// Manager User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This parameter isn't supported for rate expressions.
        /// </para>
        ///  
        /// <para>
        /// You can reset this parameter. To do so, specify the <c>no-apply-only-at-cron-interval</c>
        /// parameter when you update the association from the command line. This parameter forces
        /// the association to run immediately after updating it and according to the interval
        /// specified.
        /// </para>
        /// </summary>
        public bool? ApplyOnlyAtCronInterval
        {
            get { return this._applyOnlyAtCronInterval; }
            set { this._applyOnlyAtCronInterval = value; }
        }

        // Check to see if ApplyOnlyAtCronInterval property is set
        internal bool IsSetApplyOnlyAtCronInterval()
        {
            return this._applyOnlyAtCronInterval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The ID of the association you want to update. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property AssociationName. 
        /// <para>
        /// The name of the association that you want to update.
        /// </para>
        /// </summary>
        public string AssociationName
        {
            get { return this._associationName; }
            set { this._associationName = value; }
        }

        // Check to see if AssociationName property is set
        internal bool IsSetAssociationName()
        {
            return this._associationName != null;
        }

        /// <summary>
        /// Gets and sets the property AssociationVersion. 
        /// <para>
        /// This parameter is provided for concurrency control purposes. You must specify the
        /// latest association version in the service. If you want to ensure that this request
        /// succeeds, either specify <c>$LATEST</c>, or omit this parameter.
        /// </para>
        /// </summary>
        public string AssociationVersion
        {
            get { return this._associationVersion; }
            set { this._associationVersion = value; }
        }

        // Check to see if AssociationVersion property is set
        internal bool IsSetAssociationVersion()
        {
            return this._associationVersion != null;
        }

        /// <summary>
        /// Gets and sets the property AutomationTargetParameterName. 
        /// <para>
        /// Choose the parameter that will define how your automation will branch out. This target
        /// is required for associations that use an Automation runbook and target resources by
        /// using rate controls. Automation is a tool in Amazon Web Services Systems Manager.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string AutomationTargetParameterName
        {
            get { return this._automationTargetParameterName; }
            set { this._automationTargetParameterName = value; }
        }

        // Check to see if AutomationTargetParameterName property is set
        internal bool IsSetAutomationTargetParameterName()
        {
            return this._automationTargetParameterName != null;
        }

        /// <summary>
        /// Gets and sets the property CalendarNames. 
        /// <para>
        /// The names or Amazon Resource Names (ARNs) of the Change Calendar type documents you
        /// want to gate your associations under. The associations only run when that change calendar
        /// is open. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/systems-manager-change-calendar">Amazon
        /// Web Services Systems Manager Change Calendar</a> in the <i>Amazon Web Services Systems
        /// Manager User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CalendarNames
        {
            get { return this._calendarNames; }
            set { this._calendarNames = value; }
        }

        // Check to see if CalendarNames property is set
        internal bool IsSetCalendarNames()
        {
            return this._calendarNames != null && (this._calendarNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ComplianceSeverity. 
        /// <para>
        /// The severity level to assign to the association.
        /// </para>
        /// </summary>
        public AssociationComplianceSeverity ComplianceSeverity
        {
            get { return this._complianceSeverity; }
            set { this._complianceSeverity = value; }
        }

        // Check to see if ComplianceSeverity property is set
        internal bool IsSetComplianceSeverity()
        {
            return this._complianceSeverity != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentVersion. 
        /// <para>
        /// The document version you want update for the association. 
        /// </para>
        ///  <important> 
        /// <para>
        /// State Manager doesn't support running associations that use a new version of a document
        /// if that document is shared from another account. State Manager always runs the <c>default</c>
        /// version of a document if shared from another account, even though the Systems Manager
        /// console shows that a new version was processed. If you want to run an association
        /// using a new version of a document shared form another account, you must set the document
        /// version to <c>default</c>.
        /// </para>
        ///  </important>
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
        /// Gets and sets the property Duration. 
        /// <para>
        /// The number of hours the association can run before it is canceled. Duration applies
        /// to associations that are currently running, and any pending and in progress commands
        /// on all targets. If a target was taken offline for the association to run, it is made
        /// available again immediately, without a reboot. 
        /// </para>
        ///  
        /// <para>
        /// The <c>Duration</c> parameter applies only when both these conditions are true:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The association for which you specify a duration is cancelable according to the parameters
        /// of the SSM command document or Automation runbook associated with this execution.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The command specifies the <c> <a href="https://docs.aws.amazon.com/systems-manager/latest/APIReference/API_UpdateAssociation.html#systemsmanager-UpdateAssociation-request-ApplyOnlyAtCronInterval">ApplyOnlyAtCronInterval</a>
        /// </c> parameter, which means that the association doesn't run immediately after it
        /// is updated, but only according to the specified schedule.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=24)]
        public int? Duration
        {
            get { return this._duration; }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration.HasValue; 
        }

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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the SSM Command document or Automation runbook that contains the configuration
        /// information for the managed node.
        /// </para>
        ///  
        /// <para>
        /// You can specify Amazon Web Services-predefined documents, documents you created, or
        /// a document that is shared with you from another account.
        /// </para>
        ///  
        /// <para>
        /// For Systems Manager document (SSM document) that are shared with you from other Amazon
        /// Web Services accounts, you must specify the complete SSM document ARN, in the following
        /// format:
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:ssm:<i>region</i>:<i>account-id</i>:document/<i>document-name</i> </c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// For example:
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:ssm:us-east-2:12345678912:document/My-Shared-Document</c> 
        /// </para>
        ///  
        /// <para>
        /// For Amazon Web Services-predefined documents and SSM documents you created in your
        /// account, you only need to specify the document name. For example, <c>AWS-ApplyPatchBaseline</c>
        /// or <c>My-Document</c>.
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
        /// Gets and sets the property OutputLocation. 
        /// <para>
        /// An S3 bucket where you want to store the results of this request.
        /// </para>
        /// </summary>
        public InstanceAssociationOutputLocation OutputLocation
        {
            get { return this._outputLocation; }
            set { this._outputLocation = value; }
        }

        // Check to see if OutputLocation property is set
        internal bool IsSetOutputLocation()
        {
            return this._outputLocation != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The parameters you want to update for the association. If you create a parameter using
        /// Parameter Store, a tool in Amazon Web Services Systems Manager, you can reference
        /// the parameter using <c>{{ssm:parameter-name}}</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, List<string>> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScheduleExpression. 
        /// <para>
        /// The cron expression used to schedule the association that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ScheduleExpression
        {
            get { return this._scheduleExpression; }
            set { this._scheduleExpression = value; }
        }

        // Check to see if ScheduleExpression property is set
        internal bool IsSetScheduleExpression()
        {
            return this._scheduleExpression != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduleOffset. 
        /// <para>
        /// Number of days to wait after the scheduled day to run an association. For example,
        /// if you specified a cron schedule of <c>cron(0 0 ? * THU#2 *)</c>, you could specify
        /// an offset of 3 to run the association each Sunday after the second Thursday of the
        /// month. For more information about cron schedules for associations, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/reference-cron-and-rate-expressions.html">Reference:
        /// Cron and rate expressions for Systems Manager</a> in the <i>Amazon Web Services Systems
        /// Manager User Guide</i>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// To use offsets, you must specify the <c>ApplyOnlyAtCronInterval</c> parameter. This
        /// option tells the system not to run an association immediately after you create it.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=6)]
        public int? ScheduleOffset
        {
            get { return this._scheduleOffset; }
            set { this._scheduleOffset = value; }
        }

        // Check to see if ScheduleOffset property is set
        internal bool IsSetScheduleOffset()
        {
            return this._scheduleOffset.HasValue; 
        }

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
        public AssociationSyncCompliance SyncCompliance
        {
            get { return this._syncCompliance; }
            set { this._syncCompliance = value; }
        }

        // Check to see if SyncCompliance property is set
        internal bool IsSetSyncCompliance()
        {
            return this._syncCompliance != null;
        }

        /// <summary>
        /// Gets and sets the property TargetLocations. 
        /// <para>
        /// A location is a combination of Amazon Web Services Regions and Amazon Web Services
        /// accounts where you want to run the association. Use this action to update an association
        /// in multiple Regions and multiple accounts.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<TargetLocation> TargetLocations
        {
            get { return this._targetLocations; }
            set { this._targetLocations = value; }
        }

        // Check to see if TargetLocations property is set
        internal bool IsSetTargetLocations()
        {
            return this._targetLocations != null && (this._targetLocations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetMaps. 
        /// <para>
        /// A key-value mapping of document parameters to target resources. Both Targets and TargetMaps
        /// can't be specified together.
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
        /// Gets and sets the property Targets. 
        /// <para>
        /// The targets of the association.
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

    }
}