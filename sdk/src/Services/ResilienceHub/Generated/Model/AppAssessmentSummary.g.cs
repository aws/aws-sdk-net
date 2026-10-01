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
    /// Defines an application assessment summary.
    /// </summary>
    public partial class AppAssessmentSummary
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
        public string AppArn { get; set; }

        /// <summary>
        /// Checks to see if the AppArn property is set.
        /// </summary>
        internal bool IsSetAppArn() => this.AppArn != null;

        /// <summary>
        /// Gets and sets the property AppVersion. 
        /// <para>
        /// Version of an application.
        /// </para>
        /// </summary>
        public string AppVersion { get; set; }

        /// <summary>
        /// Checks to see if the AppVersion property is set.
        /// </summary>
        internal bool IsSetAppVersion() => this.AppVersion != null;

        /// <summary>
        /// Gets and sets the property AssessmentArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the assessment. The format for this ARN is: arn:<c>partition</c>:resiliencehub:<c>region</c>:<c>account</c>:app-assessment/<c>app-id</c>.
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">
        /// Amazon Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>
        /// guide.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AssessmentArn { get; set; }

        /// <summary>
        /// Checks to see if the AssessmentArn property is set.
        /// </summary>
        internal bool IsSetAssessmentArn() => this.AssessmentArn != null;

        /// <summary>
        /// Gets and sets the property AssessmentName. 
        /// <para>
        /// Name of the assessment.
        /// </para>
        /// </summary>
        public string AssessmentName { get; set; }

        /// <summary>
        /// Checks to see if the AssessmentName property is set.
        /// </summary>
        internal bool IsSetAssessmentName() => this.AssessmentName != null;

        /// <summary>
        /// Gets and sets the property AssessmentStatus. 
        /// <para>
        /// Current status of the assessment for the resiliency policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AssessmentStatus AssessmentStatus { get; set; }

        /// <summary>
        /// Checks to see if the AssessmentStatus property is set.
        /// </summary>
        internal bool IsSetAssessmentStatus() => this.AssessmentStatus != null;

        /// <summary>
        /// Gets and sets the property ComplianceStatus. 
        /// <para>
        /// Current status of compliance for the resiliency policy.
        /// </para>
        /// </summary>
        public ComplianceStatus ComplianceStatus { get; set; }

        /// <summary>
        /// Checks to see if the ComplianceStatus property is set.
        /// </summary>
        internal bool IsSetComplianceStatus() => this.ComplianceStatus != null;

        /// <summary>
        /// Gets and sets the property Cost. 
        /// <para>
        /// Cost for an application.
        /// </para>
        /// </summary>
        public Cost Cost { get; set; }

        /// <summary>
        /// Checks to see if the Cost property is set.
        /// </summary>
        internal bool IsSetCost() => this.Cost != null;

        /// <summary>
        /// Gets and sets the property DriftStatus. 
        /// <para>
        /// Indicates if compliance drifts (deviations) were detected while running an assessment
        /// for your application.
        /// </para>
        /// </summary>
        public DriftStatus DriftStatus { get; set; }

        /// <summary>
        /// Checks to see if the DriftStatus property is set.
        /// </summary>
        internal bool IsSetDriftStatus() => this.DriftStatus != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// End time for the action.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property Invoker. 
        /// <para>
        /// Entity that invoked the assessment.
        /// </para>
        /// </summary>
        public AssessmentInvoker Invoker { get; set; }

        /// <summary>
        /// Checks to see if the Invoker property is set.
        /// </summary>
        internal bool IsSetInvoker() => this.Invoker != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// Message from the assessment run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

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
        /// Gets and sets the property StartTime. 
        /// <para>
        /// Starting time for the action.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property VersionName. 
        /// <para>
        /// Name of an application version.
        /// </para>
        /// </summary>
        public string VersionName { get; set; }

        /// <summary>
        /// Checks to see if the VersionName property is set.
        /// </summary>
        internal bool IsSetVersionName() => this.VersionName != null;
    }
}
