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
    /// A State Manager association defines the state that you want to maintain on your instances.
    /// For example, an association can specify that anti-virus software must be installed
    /// and running on your instances, or that certain ports must be closed. For static targets,
    /// the association specifies a schedule for when the configuration is reapplied. For
    /// dynamic targets, such as an AWS Resource Group or an AWS Autoscaling Group, State
    /// Manager applies the configuration when new instances are added to the group. The association
    /// also specifies actions to take when applying the configuration. For example, an association
    /// for anti-virus software might run once a day. If the software is not installed, then
    /// State Manager installs it. If the software is installed, but the service is not running,
    /// then the association might instruct State Manager to start the service.
    /// </summary>
    public partial class CreateAssociationRequest : AmazonSimpleSystemsManagementRequest
    {
        private bool? _applyOnlyAtCronInterval;
        private string _associationName;
        private string _automationTargetParameterName;
        private AssociationComplianceSeverity _complianceSeverity;
        private string _documentVersion;
        private string _instanceId;
        private string _maxConcurrency;
        private string _maxErrors;
        private string _name;
        private InstanceAssociationOutputLocation _outputLocation;
        private Dictionary<string, List<string>> _parameters = new Dictionary<string, List<string>>();
        private string _scheduleExpression;
        private AssociationSyncCompliance _syncCompliance;
        private List<TargetLocation> _targetLocations = new List<TargetLocation>();
        private List<Target> _targets = new List<Target>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateAssociationRequest() { }

        /// <summary>
        /// Instantiates CreateAssociationRequest with the parameterized properties
        /// </summary>
        /// <param name="instanceId">The instance ID. <note>  <code>InstanceId</code> has been deprecated. To specify an instance ID for an association, use the <code>Targets</code> parameter. Requests that include the parameter <code>InstanceID</code> with SSM documents that use schema version 2.0 or later will fail. In addition, if you use the parameter <code>InstanceId</code>, you cannot use the parameters <code>AssociationName</code>, <code>DocumentVersion</code>, <code>MaxErrors</code>, <code>MaxConcurrency</code>, <code>OutputLocation</code>, or <code>ScheduleExpression</code>. To use these parameters, you must use the <code>Targets</code> parameter. </note></param>
        /// <param name="name">The name of the SSM document that contains the configuration information for the instance. You can specify Command or Automation documents. You can specify AWS-predefined documents, documents you created, or a document that is shared with you from another account. For SSM documents that are shared with you from other AWS accounts, you must specify the complete SSM document ARN, in the following format:  <code>arn:<i>partition</i>:ssm:<i>region</i>:<i>account-id</i>:document/<i>document-name</i> </code>  For example:  <code>arn:aws:ssm:us-east-2:12345678912:document/My-Shared-Document</code>  For AWS-predefined documents and SSM documents you created in your account, you only need to specify the document name. For example, <code>AWS-ApplyPatchBaseline</code> or <code>My-Document</code>.</param>
        public CreateAssociationRequest(string instanceId, string name)
        {
            _instanceId = instanceId;
            _name = name;
        }

        /// <summary>
        /// Gets and sets the property ApplyOnlyAtCronInterval. 
        /// <para>
        /// By default, when you create a new associations, the system runs it immediately after
        /// it is created and then according to the schedule you specified. Specify this option
        /// if you don't want an association to run immediately after you create it. This parameter
        /// is not supported for rate expressions.
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
        /// Specify the target for the association. This target is required for associations that
        /// use an Automation document and target resources by using rate controls.
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
        /// The instance ID.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>InstanceId</code> has been deprecated. To specify an instance ID for an association,
        /// use the <code>Targets</code> parameter. Requests that include the parameter <code>InstanceID</code>
        /// with SSM documents that use schema version 2.0 or later will fail. In addition, if
        /// you use the parameter <code>InstanceId</code>, you cannot use the parameters <code>AssociationName</code>,
        /// <code>DocumentVersion</code>, <code>MaxErrors</code>, <code>MaxConcurrency</code>,
        /// <code>OutputLocation</code>, or <code>ScheduleExpression</code>. To use these parameters,
        /// you must use the <code>Targets</code> parameter.
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
        /// If a new instance starts and attempts to run an association while Systems Manager
        /// is running MaxConcurrency associations, the association is allowed to run. During
        /// the next association interval, the new instance will process its association within
        /// the limit specified for MaxConcurrency.
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
        /// error is returned. If you run an association on 50 instances and set MaxError to 10%,
        /// then the system stops sending the request when the sixth error is received.
        /// </para>
        ///  
        /// <para>
        /// Executions that are already running an association when MaxErrors is reached are allowed
        /// to complete, but some of these executions may fail as well. If you need to ensure
        /// that there won't be more than max-errors failed executions, set MaxConcurrency to
        /// 1 so that executions proceed one at a time.
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
        /// The name of the SSM document that contains the configuration information for the instance.
        /// You can specify Command or Automation documents.
        /// </para>
        ///  
        /// <para>
        /// You can specify AWS-predefined documents, documents you created, or a document that
        /// is shared with you from another account.
        /// </para>
        ///  
        /// <para>
        /// For SSM documents that are shared with you from other AWS accounts, you must specify
        /// the complete SSM document ARN, in the following format:
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
        /// For AWS-predefined documents and SSM documents you created in your account, you only
        /// need to specify the document name. For example, <code>AWS-ApplyPatchBaseline</code>
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
        /// An S3 bucket where you want to store the output details of the request.
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
        /// parameter for the <a>PutComplianceItems</a> API action. In this case, compliance data
        /// is not managed by State Manager. It is managed by your direct call to the <a>PutComplianceItems</a>
        /// API action.
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
        /// Gets and sets the property TargetLocations. 
        /// <para>
        /// A location is a combination of AWS Regions and AWS accounts where you want to run
        /// the association. Use this action to create an association in multiple Regions and
        /// multiple accounts.
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
        /// Gets and sets the property Targets. 
        /// <para>
        /// The targets for the association. You can target instances by using tags, AWS Resource
        /// Groups, all instances in an AWS account, or individual instance IDs. For more information
        /// about choosing targets for an association, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/systems-manager-state-manager-targets-and-rate-controls.html">Using
        /// targets and rate controls with State Manager associations</a> in the <i>AWS Systems
        /// Manager User Guide</i>.
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