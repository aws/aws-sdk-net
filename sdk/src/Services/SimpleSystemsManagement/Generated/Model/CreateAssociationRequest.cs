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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAssociation operation.
    /// A State Manager association defines the state that you want to maintain on your managed
    /// nodes. For example, an association can specify that anti-virus software must be installed
    /// and running on your managed nodes, or that certain ports must be closed. For static
    /// targets, the association specifies a schedule for when the configuration is reapplied.
    /// For dynamic targets, such as an Amazon Web Services resource group or an Amazon Web
    /// Services autoscaling group, State Manager, a capability of Amazon Web Services Systems
    /// Manager applies the configuration when new managed nodes are added to the group. The
    /// association also specifies actions to take when applying the configuration. For example,
    /// an association for anti-virus software might run once a day. If the software isn't
    /// installed, then State Manager installs it. If the software is installed, but the service
    /// isn't running, then the association might instruct State Manager to start the service.
    /// </summary>
    public partial class CreateAssociationRequest : AmazonSimpleSystemsManagementRequest
    {
        private AlarmConfiguration _alarmConfiguration;
        private bool? _applyOnlyAtCronInterval;
        private string _associationName;
        private string _automationTargetParameterName;
        private List<string> _calendarNames = new List<string>();
        private AssociationComplianceSeverity _complianceSeverity;
        private string _documentVersion;
        private string _instanceId;
        private string _maxConcurrency;
        private string _maxErrors;
        private string _name;
        private InstanceAssociationOutputLocation _outputLocation;
        private Dictionary<string, List<string>> _parameters = new Dictionary<string, List<string>>();
        private string _scheduleExpression;
        private int? _scheduleOffset;
        private AssociationSyncCompliance _syncCompliance;
        private List<Tag> _tags = new List<Tag>();
        private List<TargetLocation> _targetLocations = new List<TargetLocation>();
        private List<Dictionary<string, List<string>>> _targetMaps = new List<Dictionary<string, List<string>>>();
        private List<Target> _targets = new List<Target>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateAssociationRequest() { }

        /// <summary>
        /// Instantiates CreateAssociationRequest with the parameterized properties
        /// </summary>
        /// <param name="instanceId">The managed node ID. <note>  <code>InstanceId</code> has been deprecated. To specify a managed node ID for an association, use the <code>Targets</code> parameter. Requests that include the parameter <code>InstanceID</code> with Systems Manager documents (SSM documents) that use schema version 2.0 or later will fail. In addition, if you use the parameter <code>InstanceId</code>, you can't use the parameters <code>AssociationName</code>, <code>DocumentVersion</code>, <code>MaxErrors</code>, <code>MaxConcurrency</code>, <code>OutputLocation</code>, or <code>ScheduleExpression</code>. To use these parameters, you must use the <code>Targets</code> parameter. </note></param>
        /// <param name="name">The name of the SSM Command document or Automation runbook that contains the configuration information for the managed node. You can specify Amazon Web Services-predefined documents, documents you created, or a document that is shared with you from another Amazon Web Services account. For Systems Manager documents (SSM documents) that are shared with you from other Amazon Web Services accounts, you must specify the complete SSM document ARN, in the following format:  <code>arn:<i>partition</i>:ssm:<i>region</i>:<i>account-id</i>:document/<i>document-name</i> </code>  For example:  <code>arn:aws:ssm:us-east-2:12345678912:document/My-Shared-Document</code>  For Amazon Web Services-predefined documents and SSM documents you created in your account, you only need to specify the document name. For example, <code>AWS-ApplyPatchBaseline</code> or <code>My-Document</code>.</param>
        public CreateAssociationRequest(string instanceId, string name)
        {
            _instanceId = instanceId;
            _name = name;
        }

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
        /// By default, when you create a new association, the system runs it immediately after
        /// it is created and then according to the schedule you specified. Specify this option
        /// if you don't want an association to run immediately after you create it. This parameter
        /// isn't supported for rate expressions.
        /// </para>
        /// </summary>
        public bool ApplyOnlyAtCronInterval
        {
            get { return this._applyOnlyAtCronInterval.GetValueOrDefault(); }
            set { this._applyOnlyAtCronInterval = value; }
        }

        // Check to see if ApplyOnlyAtCronInterval property is set
        internal bool IsSetApplyOnlyAtCronInterval()
        {
            return this._applyOnlyAtCronInterval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AssociationName. 
        /// <para>
        /// Specify a descriptive name for the association.
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
        /// Gets and sets the property AutomationTargetParameterName. 
        /// <para>
        /// Choose the parameter that will define how your automation will branch out. This target
        /// is required for associations that use an Automation runbook and target resources by
        /// using rate controls. Automation is a capability of Amazon Web Services Systems Manager.
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
        /// Web Services Systems Manager Change Calendar</a>.
        /// </para>
        /// </summary>
        public List<string> CalendarNames
        {
            get { return this._calendarNames; }
            set { this._calendarNames = value; }
        }

        // Check to see if CalendarNames property is set
        internal bool IsSetCalendarNames()
        {
            return this._calendarNames != null && this._calendarNames.Count > 0; 
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
        /// The document version you want to associate with the target(s). Can be a specific version
        /// or the default version.
        /// </para>
        ///  <important> 
        /// <para>
        /// State Manager doesn't support running associations that use a new version of a document
        /// if that document is shared from another account. State Manager always runs the <code>default</code>
        /// version of a document if shared from another account, even though the Systems Manager
        /// console shows that a new version was processed. If you want to run an association
        /// using a new version of a document shared form another account, you must set the document
        /// version to <code>default</code>.
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
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The managed node ID.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>InstanceId</code> has been deprecated. To specify a managed node ID for an
        /// association, use the <code>Targets</code> parameter. Requests that include the parameter
        /// <code>InstanceID</code> with Systems Manager documents (SSM documents) that use schema
        /// version 2.0 or later will fail. In addition, if you use the parameter <code>InstanceId</code>,
        /// you can't use the parameters <code>AssociationName</code>, <code>DocumentVersion</code>,
        /// <code>MaxErrors</code>, <code>MaxConcurrency</code>, <code>OutputLocation</code>,
        /// or <code>ScheduleExpression</code>. To use these parameters, you must use the <code>Targets</code>
        /// parameter.
        /// </para>
        ///  </note>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
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
        /// is running <code>MaxConcurrency</code> associations, the association is allowed to
        /// run. During the next association interval, the new managed node will process its association
        /// within the limit specified for <code>MaxConcurrency</code>.
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
        /// error is returned. If you run an association on 50 managed nodes and set <code>MaxError</code>
        /// to 10%, then the system stops sending the request when the sixth error is received.
        /// </para>
        ///  
        /// <para>
        /// Executions that are already running an association when <code>MaxErrors</code> is
        /// reached are allowed to complete, but some of these executions may fail as well. If
        /// you need to ensure that there won't be more than max-errors failed executions, set
        /// <code>MaxConcurrency</code> to 1 so that executions proceed one at a time.
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
        /// a document that is shared with you from another Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        /// For Systems Manager documents (SSM documents) that are shared with you from other
        /// Amazon Web Services accounts, you must specify the complete SSM document ARN, in the
        /// following format:
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:<i>partition</i>:ssm:<i>region</i>:<i>account-id</i>:document/<i>document-name</i>
        /// </code> 
        /// </para>
        ///  
        /// <para>
        /// For example:
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:ssm:us-east-2:12345678912:document/My-Shared-Document</code> 
        /// </para>
        ///  
        /// <para>
        /// For Amazon Web Services-predefined documents and SSM documents you created in your
        /// account, you only need to specify the document name. For example, <code>AWS-ApplyPatchBaseline</code>
        /// or <code>My-Document</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// An Amazon Simple Storage Service (Amazon S3) bucket where you want to store the output
        /// details of the request.
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
        /// The parameters for the runtime configuration of the document.
        /// </para>
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
            return this._parameters != null && this._parameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ScheduleExpression. 
        /// <para>
        /// A cron expression when the association will be applied to the target(s).
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
        /// if you specified a cron schedule of <code>cron(0 0 ? * THU#2 *)</code>, you could
        /// specify an offset of 3 to run the association each Sunday after the second Thursday
        /// of the month. For more information about cron schedules for associations, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/reference-cron-and-rate-expressions.html">Reference:
        /// Cron and rate expressions for Systems Manager</a> in the <i>Amazon Web Services Systems
        /// Manager User Guide</i>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// To use offsets, you must specify the <code>ApplyOnlyAtCronInterval</code> parameter.
        /// This option tells the system not to run an association immediately after you create
        /// it. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=6)]
        public int ScheduleOffset
        {
            get { return this._scheduleOffset.GetValueOrDefault(); }
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
        /// The mode for generating association compliance. You can specify <code>AUTO</code>
        /// or <code>MANUAL</code>. In <code>AUTO</code> mode, the system uses the status of the
        /// association execution to determine the compliance status. If the association execution
        /// runs successfully, then the association is <code>COMPLIANT</code>. If the association
        /// execution doesn't run successfully, the association is <code>NON-COMPLIANT</code>.
        /// </para>
        ///  
        /// <para>
        /// In <code>MANUAL</code> mode, you must specify the <code>AssociationId</code> as a
        /// parameter for the <a>PutComplianceItems</a> API operation. In this case, compliance
        /// data isn't managed by State Manager. It is managed by your direct call to the <a>PutComplianceItems</a>
        /// API operation.
        /// </para>
        ///  
        /// <para>
        /// By default, all associations use <code>AUTO</code> mode.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Adds or overwrites one or more tags for a State Manager association. <i>Tags</i> are
        /// metadata that you can assign to your Amazon Web Services resources. Tags enable you
        /// to categorize your resources in different ways, for example, by purpose, owner, or
        /// environment. Each tag consists of a key and an optional value, both of which you define.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TargetLocations. 
        /// <para>
        /// A location is a combination of Amazon Web Services Regions and Amazon Web Services
        /// accounts where you want to run the association. Use this action to create an association
        /// in multiple Regions and multiple accounts.
        /// </para>
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
            return this._targetLocations != null && this._targetLocations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TargetMaps. 
        /// <para>
        /// A key-value mapping of document parameters to target resources. Both Targets and TargetMaps
        /// can't be specified together.
        /// </para>
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
            return this._targetMaps != null && this._targetMaps.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// The targets for the association. You can target managed nodes by using tags, Amazon
        /// Web Services resource groups, all managed nodes in an Amazon Web Services account,
        /// or individual managed node IDs. You can target all managed nodes in an Amazon Web
        /// Services account by specifying the <code>InstanceIds</code> key with a value of <code>*</code>.
        /// For more information about choosing targets for an association, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/systems-manager-state-manager-targets-and-rate-controls.html">Using
        /// targets and rate controls with State Manager associations</a> in the <i>Amazon Web
        /// Services Systems Manager User Guide</i>.
        /// </para>
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
            return this._targets != null && this._targets.Count > 0; 
        }

    }
}