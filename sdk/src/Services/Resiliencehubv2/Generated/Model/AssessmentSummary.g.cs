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

namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Contains summary information about a failure mode assessment.
    /// </summary>
    public partial class AssessmentSummary
    {
        /// <summary>
        /// Gets and sets the property Achievability. 
        /// <para>
        /// The achievability results from the assessment.
        /// </para>
        /// </summary>
        public Achievability Achievability { get; set; }

        /// <summary>
        /// Checks to see if the Achievability property is set.
        /// </summary>
        internal bool IsSetAchievability() => this.Achievability != null;

        /// <summary>
        /// Gets and sets the property AssessmentCost. 
        /// <para>
        /// The cost of the assessment.
        /// </para>
        /// </summary>
        public AssessmentCost AssessmentCost { get; set; }

        /// <summary>
        /// Checks to see if the AssessmentCost property is set.
        /// </summary>
        internal bool IsSetAssessmentCost() => this.AssessmentCost != null;

        /// <summary>
        /// Gets and sets the property AssessmentId. 
        /// <para>
        /// The unique identifier of the assessment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string AssessmentId { get; set; }

        /// <summary>
        /// Checks to see if the AssessmentId property is set.
        /// </summary>
        internal bool IsSetAssessmentId() => this.AssessmentId != null;

        /// <summary>
        /// Gets and sets the property AssessmentStatus. 
        /// <para>
        /// The current status of the assessment.
        /// </para>
        /// </summary>
        public AssessmentStatus AssessmentStatus { get; set; }

        /// <summary>
        /// Checks to see if the AssessmentStatus property is set.
        /// </summary>
        internal bool IsSetAssessmentStatus() => this.AssessmentStatus != null;

        /// <summary>
        /// Gets and sets the property AssessmentStep. 
        /// <para>
        /// The current step of the assessment process.
        /// </para>
        /// </summary>
        public AssessmentStep AssessmentStep { get; set; }

        /// <summary>
        /// Checks to see if the AssessmentStep property is set.
        /// </summary>
        internal bool IsSetAssessmentStep() => this.AssessmentStep != null;

        /// <summary>
        /// Gets and sets the property BillableAssessmentUnitCount. 
        /// <para>
        /// The number of billable assessment units consumed by the assessment.
        /// </para>
        /// </summary>
        public int? BillableAssessmentUnitCount { get; set; }

        /// <summary>
        /// Checks to see if the BillableAssessmentUnitCount property is set.
        /// </summary>
        internal bool IsSetBillableAssessmentUnitCount() => this.BillableAssessmentUnitCount.HasValue;

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The timestamp when the assessment ended.
        /// </para>
        /// </summary>
        public DateTime? EndedAt { get; set; }

        /// <summary>
        /// Checks to see if the EndedAt property is set.
        /// </summary>
        internal bool IsSetEndedAt() => this.EndedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The error code if the assessment failed.
        /// </para>
        /// </summary>
        public AssessmentErrorCode ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// A message describing the error if the assessment failed.
        /// </para>
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property ServiceArn.
        /// </summary>
        [AWSProperty(Required = true, Min = 31)]
        public string ServiceArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceArn property is set.
        /// </summary>
        internal bool IsSetServiceArn() => this.ServiceArn != null;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The timestamp when the assessment started.
        /// </para>
        /// </summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property TotalFindings. 
        /// <para>
        /// The total number of findings generated by the assessment.
        /// </para>
        /// </summary>
        public int? TotalFindings { get; set; }

        /// <summary>
        /// Checks to see if the TotalFindings property is set.
        /// </summary>
        internal bool IsSetTotalFindings() => this.TotalFindings.HasValue;
    }
}
