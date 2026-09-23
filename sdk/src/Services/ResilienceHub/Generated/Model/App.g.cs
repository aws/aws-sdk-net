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

namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Defines an Resilience Hub application.
    /// </summary>
    public partial class App
    {
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
        [AWSProperty(Required = true)]
        public string AppArn { get; set; }

        /// <summary>
        /// Checks to see if the AppArn property is set.
        /// </summary>
        internal bool IsSetAppArn() => this.AppArn != null;

        /// <summary>
        /// Gets and sets the property AssessmentSchedule. 
        /// <para>
        /// Assessment execution schedule with 'Daily' or 'Disabled' values. 
        /// </para>
        /// </summary>
        public AppAssessmentScheduleType AssessmentSchedule { get; set; }

        /// <summary>
        /// Checks to see if the AssessmentSchedule property is set.
        /// </summary>
        internal bool IsSetAssessmentSchedule() => this.AssessmentSchedule != null;

        /// <summary>
        /// Gets and sets the property AwsApplicationArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of Resource Groups group that is integrated with an AppRegistry
        /// application. For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">
        /// Amazon Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>
        /// guide.
        /// </para>
        /// </summary>
        public string AwsApplicationArn { get; set; }

        /// <summary>
        /// Checks to see if the AwsApplicationArn property is set.
        /// </summary>
        internal bool IsSetAwsApplicationArn() => this.AwsApplicationArn != null;

        /// <summary>
        /// Gets and sets the property ComplianceStatus. 
        /// <para>
        /// Current status of compliance for the resiliency policy.
        /// </para>
        /// </summary>
        public AppComplianceStatusType ComplianceStatus { get; set; }

        /// <summary>
        /// Checks to see if the ComplianceStatus property is set.
        /// </summary>
        internal bool IsSetComplianceStatus() => this.ComplianceStatus != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Date and time when the application was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Optional description for an application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DriftStatus. 
        /// <para>
        /// Indicates if compliance drifts (deviations) were detected while running an assessment
        /// for your application.
        /// </para>
        /// </summary>
        public AppDriftStatusType DriftStatus { get; set; }

        /// <summary>
        /// Checks to see if the DriftStatus property is set.
        /// </summary>
        internal bool IsSetDriftStatus() => this.DriftStatus != null;

        /// <summary>
        /// Gets and sets the property EventSubscriptions. 
        /// <para>
        /// The list of events you would like to subscribe and get notification for. Currently,
        /// Resilience Hub supports notifications only for <b>Drift detected</b> and <b>Scheduled
        /// assessment failure</b> events.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<EventSubscription> EventSubscriptions { get; set; } = AWSConfigs.InitializeCollections ? new List<EventSubscription>() : null;

        /// <summary>
        /// Checks to see if the EventSubscriptions property is set.
        /// </summary>
        internal bool IsSetEventSubscriptions() => this.EventSubscriptions != null && (this.EventSubscriptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastAppComplianceEvaluationTime. 
        /// <para>
        /// Date and time the most recent compliance evaluation.
        /// </para>
        /// </summary>
        public DateTime? LastAppComplianceEvaluationTime { get; set; }

        /// <summary>
        /// Checks to see if the LastAppComplianceEvaluationTime property is set.
        /// </summary>
        internal bool IsSetLastAppComplianceEvaluationTime() => this.LastAppComplianceEvaluationTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastDriftEvaluationTime. 
        /// <para>
        /// Indicates the last time that a drift was evaluated.
        /// </para>
        /// </summary>
        public DateTime? LastDriftEvaluationTime { get; set; }

        /// <summary>
        /// Checks to see if the LastDriftEvaluationTime property is set.
        /// </summary>
        internal bool IsSetLastDriftEvaluationTime() => this.LastDriftEvaluationTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastResiliencyScoreEvaluationTime. 
        /// <para>
        /// Date and time the most recent resiliency score evaluation.
        /// </para>
        /// </summary>
        public DateTime? LastResiliencyScoreEvaluationTime { get; set; }

        /// <summary>
        /// Checks to see if the LastResiliencyScoreEvaluationTime property is set.
        /// </summary>
        internal bool IsSetLastResiliencyScoreEvaluationTime() => this.LastResiliencyScoreEvaluationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name for the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PermissionModel. 
        /// <para>
        /// Defines the roles and credentials that Resilience Hub would use while creating the
        /// application, importing its resources, and running an assessment.
        /// </para>
        /// </summary>
        public PermissionModel PermissionModel { get; set; }

        /// <summary>
        /// Checks to see if the PermissionModel property is set.
        /// </summary>
        internal bool IsSetPermissionModel() => this.PermissionModel != null;

        /// <summary>
        /// Gets and sets the property PolicyArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the resiliency policy. The format for this ARN is: arn:<c>partition</c>:resiliencehub:<c>region</c>:<c>account</c>:resiliency-policy/<c>policy-id</c>.
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">
        /// Amazon Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>
        /// guide.
        /// </para>
        /// </summary>
        public string PolicyArn { get; set; }

        /// <summary>
        /// Checks to see if the PolicyArn property is set.
        /// </summary>
        internal bool IsSetPolicyArn() => this.PolicyArn != null;

        /// <summary>
        /// Gets and sets the property ResiliencyScore. 
        /// <para>
        /// Current resiliency score for the application.
        /// </para>
        /// </summary>
        public double? ResiliencyScore { get; set; }

        /// <summary>
        /// Checks to see if the ResiliencyScore property is set.
        /// </summary>
        internal bool IsSetResiliencyScore() => this.ResiliencyScore.HasValue;

        /// <summary>
        /// Gets and sets the property RpoInSecs. 
        /// <para>
        /// Recovery Point Objective (RPO) in seconds.
        /// </para>
        /// </summary>
        public int? RpoInSecs { get; set; }

        /// <summary>
        /// Checks to see if the RpoInSecs property is set.
        /// </summary>
        internal bool IsSetRpoInSecs() => this.RpoInSecs.HasValue;

        /// <summary>
        /// Gets and sets the property RtoInSecs. 
        /// <para>
        /// Recovery Time Objective (RTO) in seconds.
        /// </para>
        /// </summary>
        public int? RtoInSecs { get; set; }

        /// <summary>
        /// Checks to see if the RtoInSecs property is set.
        /// </summary>
        internal bool IsSetRtoInSecs() => this.RtoInSecs.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of the application.
        /// </para>
        /// </summary>
        public AppStatusType Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags assigned to the resource. A tag is a label that you assign to an Amazon Web Services
        /// resource. Each tag consists of a key/value pair.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
