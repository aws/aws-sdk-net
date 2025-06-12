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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
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
namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Defines an Resilience Hub application.
    /// </summary>
    public partial class App
    {
        private string _appArn;
        private AppAssessmentScheduleType _assessmentSchedule;
        private string _awsApplicationArn;
        private AppComplianceStatusType _complianceStatus;
        private DateTime? _creationTime;
        private string _description;
        private AppDriftStatusType _driftStatus;
        private List<EventSubscription> _eventSubscriptions = AWSConfigs.InitializeCollections ? new List<EventSubscription>() : null;
        private DateTime? _lastAppComplianceEvaluationTime;
        private DateTime? _lastDriftEvaluationTime;
        private DateTime? _lastResiliencyScoreEvaluationTime;
        private string _name;
        private PermissionModel _permissionModel;
        private string _policyArn;
        private double? _resiliencyScore;
        private int? _rpoInSecs;
        private int? _rtoInSecs;
        private AppStatusType _status;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AppArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the Resilience Hub application. The format for this
        /// ARN is: arn:<c>partition</c>:resiliencehub:<c>region</c>:<c>account</c>:app/<c>app-id</c>.
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">
        /// Amazon Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>
        /// guide.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AppArn
        {
            get { return this._appArn; }
            set { this._appArn = value; }
        }

        // Check to see if AppArn property is set
        internal bool IsSetAppArn()
        {
            return this._appArn != null;
        }

        /// <summary>
        /// Gets and sets the property AssessmentSchedule. 
        /// <para>
        /// Assessment execution schedule with 'Daily' or 'Disabled' values. 
        /// </para>
        /// </summary>
        public AppAssessmentScheduleType AssessmentSchedule
        {
            get { return this._assessmentSchedule; }
            set { this._assessmentSchedule = value; }
        }

        // Check to see if AssessmentSchedule property is set
        internal bool IsSetAssessmentSchedule()
        {
            return this._assessmentSchedule != null;
        }

        /// <summary>
        /// Gets and sets the property AwsApplicationArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of Resource Groups group that is integrated with an AppRegistry
        /// application. For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">
        /// Amazon Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>
        /// guide.
        /// </para>
        /// </summary>
        public string AwsApplicationArn
        {
            get { return this._awsApplicationArn; }
            set { this._awsApplicationArn = value; }
        }

        // Check to see if AwsApplicationArn property is set
        internal bool IsSetAwsApplicationArn()
        {
            return this._awsApplicationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ComplianceStatus. 
        /// <para>
        /// Current status of compliance for the resiliency policy.
        /// </para>
        /// </summary>
        public AppComplianceStatusType ComplianceStatus
        {
            get { return this._complianceStatus; }
            set { this._complianceStatus = value; }
        }

        // Check to see if ComplianceStatus property is set
        internal bool IsSetComplianceStatus()
        {
            return this._complianceStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Date and time when the application was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Optional description for an application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DriftStatus. 
        /// <para>
        /// Indicates if compliance drifts (deviations) were detected while running an assessment
        /// for your application.
        /// </para>
        /// </summary>
        public AppDriftStatusType DriftStatus
        {
            get { return this._driftStatus; }
            set { this._driftStatus = value; }
        }

        // Check to see if DriftStatus property is set
        internal bool IsSetDriftStatus()
        {
            return this._driftStatus != null;
        }

        /// <summary>
        /// Gets and sets the property EventSubscriptions. 
        /// <para>
        /// The list of events you would like to subscribe and get notification for. Currently,
        /// Resilience Hub supports notifications only for <b>Drift detected</b> and <b>Scheduled
        /// assessment failure</b> events.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<EventSubscription> EventSubscriptions
        {
            get { return this._eventSubscriptions; }
            set { this._eventSubscriptions = value; }
        }

        // Check to see if EventSubscriptions property is set
        internal bool IsSetEventSubscriptions()
        {
            return this._eventSubscriptions != null && (this._eventSubscriptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastAppComplianceEvaluationTime. 
        /// <para>
        /// Date and time the most recent compliance evaluation.
        /// </para>
        /// </summary>
        public DateTime? LastAppComplianceEvaluationTime
        {
            get { return this._lastAppComplianceEvaluationTime; }
            set { this._lastAppComplianceEvaluationTime = value; }
        }

        // Check to see if LastAppComplianceEvaluationTime property is set
        internal bool IsSetLastAppComplianceEvaluationTime()
        {
            return this._lastAppComplianceEvaluationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastDriftEvaluationTime. 
        /// <para>
        /// Indicates the last time that a drift was evaluated.
        /// </para>
        /// </summary>
        public DateTime? LastDriftEvaluationTime
        {
            get { return this._lastDriftEvaluationTime; }
            set { this._lastDriftEvaluationTime = value; }
        }

        // Check to see if LastDriftEvaluationTime property is set
        internal bool IsSetLastDriftEvaluationTime()
        {
            return this._lastDriftEvaluationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastResiliencyScoreEvaluationTime. 
        /// <para>
        /// Date and time the most recent resiliency score evaluation.
        /// </para>
        /// </summary>
        public DateTime? LastResiliencyScoreEvaluationTime
        {
            get { return this._lastResiliencyScoreEvaluationTime; }
            set { this._lastResiliencyScoreEvaluationTime = value; }
        }

        // Check to see if LastResiliencyScoreEvaluationTime property is set
        internal bool IsSetLastResiliencyScoreEvaluationTime()
        {
            return this._lastResiliencyScoreEvaluationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name for the application.
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
        /// Gets and sets the property PermissionModel. 
        /// <para>
        /// Defines the roles and credentials that Resilience Hub would use while creating the
        /// application, importing its resources, and running an assessment.
        /// </para>
        /// </summary>
        public PermissionModel PermissionModel
        {
            get { return this._permissionModel; }
            set { this._permissionModel = value; }
        }

        // Check to see if PermissionModel property is set
        internal bool IsSetPermissionModel()
        {
            return this._permissionModel != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the resiliency policy. The format for this ARN is: arn:<c>partition</c>:resiliencehub:<c>region</c>:<c>account</c>:resiliency-policy/<c>policy-id</c>.
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">
        /// Amazon Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>
        /// guide.
        /// </para>
        /// </summary>
        public string PolicyArn
        {
            get { return this._policyArn; }
            set { this._policyArn = value; }
        }

        // Check to see if PolicyArn property is set
        internal bool IsSetPolicyArn()
        {
            return this._policyArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResiliencyScore. 
        /// <para>
        /// Current resiliency score for the application.
        /// </para>
        /// </summary>
        public double? ResiliencyScore
        {
            get { return this._resiliencyScore; }
            set { this._resiliencyScore = value; }
        }

        // Check to see if ResiliencyScore property is set
        internal bool IsSetResiliencyScore()
        {
            return this._resiliencyScore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RpoInSecs. 
        /// <para>
        /// Recovery Point Objective (RPO) in seconds.
        /// </para>
        /// </summary>
        public int? RpoInSecs
        {
            get { return this._rpoInSecs; }
            set { this._rpoInSecs = value; }
        }

        // Check to see if RpoInSecs property is set
        internal bool IsSetRpoInSecs()
        {
            return this._rpoInSecs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RtoInSecs. 
        /// <para>
        /// Recovery Time Objective (RTO) in seconds.
        /// </para>
        /// </summary>
        public int? RtoInSecs
        {
            get { return this._rtoInSecs; }
            set { this._rtoInSecs = value; }
        }

        // Check to see if RtoInSecs property is set
        internal bool IsSetRtoInSecs()
        {
            return this._rtoInSecs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of the application.
        /// </para>
        /// </summary>
        public AppStatusType Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags assigned to the resource. A tag is a label that you assign to an Amazon Web Services
        /// resource. Each tag consists of a key/value pair.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}