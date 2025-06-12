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
    /// Defines an application assessment.
    /// </summary>
    public partial class AppAssessment
    {
        private string _appArn;
        private string _appVersion;
        private string _assessmentArn;
        private string _assessmentName;
        private AssessmentStatus _assessmentStatus;
        private Dictionary<string, DisruptionCompliance> _compliance = AWSConfigs.InitializeCollections ? new Dictionary<string, DisruptionCompliance>() : null;
        private ComplianceStatus _complianceStatus;
        private Cost _cost;
        private DriftStatus _driftStatus;
        private DateTime? _endTime;
        private AssessmentInvoker _invoker;
        private string _message;
        private ResiliencyPolicy _policy;
        private ResiliencyScore _resiliencyScore;
        private ResourceErrorsDetails _resourceErrorsDetails;
        private DateTime? _startTime;
        private AssessmentSummary _summary;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _versionName;

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
        /// Gets and sets the property AppVersion. 
        /// <para>
        /// Version of an application.
        /// </para>
        /// </summary>
        public string AppVersion
        {
            get { return this._appVersion; }
            set { this._appVersion = value; }
        }

        // Check to see if AppVersion property is set
        internal bool IsSetAppVersion()
        {
            return this._appVersion != null;
        }

        /// <summary>
        /// Gets and sets the property AssessmentArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the assessment. The format for this ARN is: arn:<c>partition</c>:resiliencehub:<c>region</c>:<c>account</c>:app-assessment/<c>app-id</c>.
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">
        /// Amazon Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>
        /// guide.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AssessmentArn
        {
            get { return this._assessmentArn; }
            set { this._assessmentArn = value; }
        }

        // Check to see if AssessmentArn property is set
        internal bool IsSetAssessmentArn()
        {
            return this._assessmentArn != null;
        }

        /// <summary>
        /// Gets and sets the property AssessmentName. 
        /// <para>
        /// Name of the assessment.
        /// </para>
        /// </summary>
        public string AssessmentName
        {
            get { return this._assessmentName; }
            set { this._assessmentName = value; }
        }

        // Check to see if AssessmentName property is set
        internal bool IsSetAssessmentName()
        {
            return this._assessmentName != null;
        }

        /// <summary>
        /// Gets and sets the property AssessmentStatus. 
        /// <para>
        /// Current status of the assessment for the resiliency policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AssessmentStatus AssessmentStatus
        {
            get { return this._assessmentStatus; }
            set { this._assessmentStatus = value; }
        }

        // Check to see if AssessmentStatus property is set
        internal bool IsSetAssessmentStatus()
        {
            return this._assessmentStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Compliance. 
        /// <para>
        /// Application compliance against the resiliency policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, DisruptionCompliance> Compliance
        {
            get { return this._compliance; }
            set { this._compliance = value; }
        }

        // Check to see if Compliance property is set
        internal bool IsSetCompliance()
        {
            return this._compliance != null && (this._compliance.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ComplianceStatus. 
        /// <para>
        /// Current status of the compliance for the resiliency policy.
        /// </para>
        /// </summary>
        public ComplianceStatus ComplianceStatus
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
        /// Gets and sets the property Cost. 
        /// <para>
        /// Cost for the application.
        /// </para>
        /// </summary>
        public Cost Cost
        {
            get { return this._cost; }
            set { this._cost = value; }
        }

        // Check to see if Cost property is set
        internal bool IsSetCost()
        {
            return this._cost != null;
        }

        /// <summary>
        /// Gets and sets the property DriftStatus. 
        /// <para>
        /// Indicates if compliance drifts (deviations) were detected while running an assessment
        /// for your application.
        /// </para>
        /// </summary>
        public DriftStatus DriftStatus
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
        /// Gets and sets the property EndTime. 
        /// <para>
        /// End time for the action.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Invoker. 
        /// <para>
        /// The entity that invoked the assessment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AssessmentInvoker Invoker
        {
            get { return this._invoker; }
            set { this._invoker = value; }
        }

        // Check to see if Invoker property is set
        internal bool IsSetInvoker()
        {
            return this._invoker != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// Error or warning message from the assessment execution
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// Resiliency policy of an application.
        /// </para>
        /// </summary>
        public ResiliencyPolicy Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null;
        }

        /// <summary>
        /// Gets and sets the property ResiliencyScore. 
        /// <para>
        /// Current resiliency score for an application.
        /// </para>
        /// </summary>
        public ResiliencyScore ResiliencyScore
        {
            get { return this._resiliencyScore; }
            set { this._resiliencyScore = value; }
        }

        // Check to see if ResiliencyScore property is set
        internal bool IsSetResiliencyScore()
        {
            return this._resiliencyScore != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceErrorsDetails. 
        /// <para>
        ///  A resource error object containing a list of errors retrieving an application's resources.
        /// 
        /// </para>
        /// </summary>
        public ResourceErrorsDetails ResourceErrorsDetails
        {
            get { return this._resourceErrorsDetails; }
            set { this._resourceErrorsDetails = value; }
        }

        // Check to see if ResourceErrorsDetails property is set
        internal bool IsSetResourceErrorsDetails()
        {
            return this._resourceErrorsDetails != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// Starting time for the action.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Summary. 
        /// <para>
        /// Indicates the AI-generated summary for the Resilience Hub assessment, providing a
        /// concise overview that highlights the top risks and recommendations.
        /// </para>
        ///  <note> 
        /// <para>
        /// This property is available only in the US East (N. Virginia) Region.
        /// </para>
        ///  </note>
        /// </summary>
        public AssessmentSummary Summary
        {
            get { return this._summary; }
            set { this._summary = value; }
        }

        // Check to see if Summary property is set
        internal bool IsSetSummary()
        {
            return this._summary != null;
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

        /// <summary>
        /// Gets and sets the property VersionName. 
        /// <para>
        /// Version name of the published application.
        /// </para>
        /// </summary>
        public string VersionName
        {
            get { return this._versionName; }
            set { this._versionName = value; }
        }

        // Check to see if VersionName property is set
        internal bool IsSetVersionName()
        {
            return this._versionName != null;
        }

    }
}