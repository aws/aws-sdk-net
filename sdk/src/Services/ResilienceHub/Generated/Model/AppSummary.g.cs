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
    /// Defines an application summary.
    /// </summary>
    public partial class AppSummary
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
        ///  Assessment execution schedule with 'Daily' or 'Disabled' values. 
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
        /// The current status of compliance for the resiliency policy.
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
        /// Date and time when the app was created.
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
        /// The optional description for an app.
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
        /// Gets and sets the property LastAppComplianceEvaluationTime. 
        /// <para>
        /// Date and time of the most recent compliance evaluation.
        /// </para>
        /// </summary>
        public DateTime? LastAppComplianceEvaluationTime { get; set; }

        /// <summary>
        /// Checks to see if the LastAppComplianceEvaluationTime property is set.
        /// </summary>
        internal bool IsSetLastAppComplianceEvaluationTime() => this.LastAppComplianceEvaluationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ResiliencyScore. 
        /// <para>
        /// The current resiliency score for the application.
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
    }
}
