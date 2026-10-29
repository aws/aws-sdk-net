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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Metadata information about an evaluation search.
    /// </summary>
    public partial class EvaluationSearchMetadata
    {
        /// <summary>
        /// Gets and sets the property AcknowledgedBy. 
        /// <para>
        /// The agent who acknowledged the evaluation.
        /// </para>
        /// </summary>
        public string AcknowledgedBy { get; set; }

        /// <summary>
        /// Checks to see if the AcknowledgedBy property is set.
        /// </summary>
        internal bool IsSetAcknowledgedBy() => this.AcknowledgedBy != null;

        /// <summary>
        /// Gets and sets the property AcknowledgedTime. 
        /// <para>
        /// When the evaluation was acknowledged by the agent.
        /// </para>
        /// </summary>
        public DateTime? AcknowledgedTime { get; set; }

        /// <summary>
        /// Checks to see if the AcknowledgedTime property is set.
        /// </summary>
        internal bool IsSetAcknowledgedTime() => this.AcknowledgedTime.HasValue;

        /// <summary>
        /// Gets and sets the property AcknowledgerComment. 
        /// <para>
        /// The comment from the agent when they acknowledged the evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 3072)]
        public string AcknowledgerComment { get; set; }

        /// <summary>
        /// Checks to see if the AcknowledgerComment property is set.
        /// </summary>
        internal bool IsSetAcknowledgerComment() => this.AcknowledgerComment != null;

        /// <summary>
        /// Gets and sets the property AutoEvaluationEnabled. 
        /// <para>
        /// Whether auto-evaluation is enabled.
        /// </para>
        /// </summary>
        public bool? AutoEvaluationEnabled { get; set; }

        /// <summary>
        /// Checks to see if the AutoEvaluationEnabled property is set.
        /// </summary>
        internal bool IsSetAutoEvaluationEnabled() => this.AutoEvaluationEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property AutoEvaluationStatus. 
        /// <para>
        /// The status of the contact auto evaluation. 
        /// </para>
        /// </summary>
        public AutoEvaluationStatus AutoEvaluationStatus { get; set; }

        /// <summary>
        /// Checks to see if the AutoEvaluationStatus property is set.
        /// </summary>
        internal bool IsSetAutoEvaluationStatus() => this.AutoEvaluationStatus != null;

        /// <summary>
        /// Gets and sets the property CalibrationSessionId. 
        /// <para>
        /// The calibration session ID that this evaluation belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public string CalibrationSessionId { get; set; }

        /// <summary>
        /// Checks to see if the CalibrationSessionId property is set.
        /// </summary>
        internal bool IsSetCalibrationSessionId() => this.CalibrationSessionId != null;

        /// <summary>
        /// Gets and sets the property ContactAgentId. 
        /// <para>
        /// The unique ID of the agent who handled the contact.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public string ContactAgentId { get; set; }

        /// <summary>
        /// Checks to see if the ContactAgentId property is set.
        /// </summary>
        internal bool IsSetContactAgentId() => this.ContactAgentId != null;

        /// <summary>
        /// Gets and sets the property ContactId. 
        /// <para>
        /// The identifier of the contact in this instance of Connect Customer. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ContactId { get; set; }

        /// <summary>
        /// Checks to see if the ContactId property is set.
        /// </summary>
        internal bool IsSetContactId() => this.ContactId != null;

        /// <summary>
        /// Gets and sets the property ContactParticipantId. 
        /// <para>
        /// Identifier for a contact participant in the evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public string ContactParticipantId { get; set; }

        /// <summary>
        /// Checks to see if the ContactParticipantId property is set.
        /// </summary>
        internal bool IsSetContactParticipantId() => this.ContactParticipantId != null;

        /// <summary>
        /// Gets and sets the property ContactParticipantRole. 
        /// <para>
        /// Role of a contact participant in the evaluation.
        /// </para>
        /// </summary>
        public ContactParticipantRole ContactParticipantRole { get; set; }

        /// <summary>
        /// Checks to see if the ContactParticipantRole property is set.
        /// </summary>
        internal bool IsSetContactParticipantRole() => this.ContactParticipantRole != null;

        /// <summary>
        /// Gets and sets the property EarnedPoints. 
        /// <para>
        /// The points earned for the evaluation.
        /// </para>
        /// </summary>
        public int? EarnedPoints { get; set; }

        /// <summary>
        /// Checks to see if the EarnedPoints property is set.
        /// </summary>
        internal bool IsSetEarnedPoints() => this.EarnedPoints.HasValue;

        /// <summary>
        /// Gets and sets the property EvaluatorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the person who evaluated the contact.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EvaluatorArn { get; set; }

        /// <summary>
        /// Checks to see if the EvaluatorArn property is set.
        /// </summary>
        internal bool IsSetEvaluatorArn() => this.EvaluatorArn != null;

        /// <summary>
        /// Gets and sets the property MaxBasePoint. 
        /// <para>
        /// The maximum base points possible for the evaluation.
        /// </para>
        /// </summary>
        public int? MaxBasePoint { get; set; }

        /// <summary>
        /// Checks to see if the MaxBasePoint property is set.
        /// </summary>
        internal bool IsSetMaxBasePoint() => this.MaxBasePoint.HasValue;

        /// <summary>
        /// Gets and sets the property PerformanceCategory. 
        /// <para>
        /// The performance category for the evaluation score.
        /// </para>
        /// </summary>
        public PerformanceCategoryName PerformanceCategory { get; set; }

        /// <summary>
        /// Checks to see if the PerformanceCategory property is set.
        /// </summary>
        internal bool IsSetPerformanceCategory() => this.PerformanceCategory != null;

        /// <summary>
        /// Gets and sets the property ReviewId. 
        /// <para>
        /// Identifier for the review.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public string ReviewId { get; set; }

        /// <summary>
        /// Checks to see if the ReviewId property is set.
        /// </summary>
        internal bool IsSetReviewId() => this.ReviewId != null;

        /// <summary>
        /// Gets and sets the property SamplingJobId. 
        /// <para>
        /// Identifier of the sampling job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public string SamplingJobId { get; set; }

        /// <summary>
        /// Checks to see if the SamplingJobId property is set.
        /// </summary>
        internal bool IsSetSamplingJobId() => this.SamplingJobId != null;

        /// <summary>
        /// Gets and sets the property ScoreAutomaticFail. 
        /// <para>
        /// The flag that marks the item as automatic fail. If the item or a child item gets an
        /// automatic fail answer, this flag is true.
        /// </para>
        /// </summary>
        public bool? ScoreAutomaticFail { get; set; }

        /// <summary>
        /// Checks to see if the ScoreAutomaticFail property is set.
        /// </summary>
        internal bool IsSetScoreAutomaticFail() => this.ScoreAutomaticFail.HasValue;

        /// <summary>
        /// Gets and sets the property ScoreNotApplicable. 
        /// <para>
        /// The flag to mark the item as not applicable for scoring.
        /// </para>
        /// </summary>
        public bool? ScoreNotApplicable { get; set; }

        /// <summary>
        /// Checks to see if the ScoreNotApplicable property is set.
        /// </summary>
        internal bool IsSetScoreNotApplicable() => this.ScoreNotApplicable.HasValue;

        /// <summary>
        /// Gets and sets the property ScorePercentage. 
        /// <para>
        /// The total evaluation score expressed as a percentage.
        /// </para>
        /// </summary>
        public double? ScorePercentage { get; set; }

        /// <summary>
        /// Checks to see if the ScorePercentage property is set.
        /// </summary>
        internal bool IsSetScorePercentage() => this.ScorePercentage.HasValue;
    }
}
