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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
        private string _acknowledgedBy;
        private DateTime? _acknowledgedTime;
        private string _acknowledgerComment;
        private bool? _autoEvaluationEnabled;
        private AutoEvaluationStatus _autoEvaluationStatus;
        private string _calibrationSessionId;
        private string _contactAgentId;
        private string _contactId;
        private string _contactParticipantId;
        private ContactParticipantRole _contactParticipantRole;
        private string _evaluatorArn;
        private string _reviewId;
        private string _samplingJobId;
        private bool? _scoreAutomaticFail;
        private bool? _scoreNotApplicable;
        private double? _scorePercentage;

        /// <summary>
        /// Gets and sets the property AcknowledgedBy. 
        /// <para>
        /// The agent who acknowledged the evaluation.
        /// </para>
        /// </summary>
        public string AcknowledgedBy
        {
            get { return this._acknowledgedBy; }
            set { this._acknowledgedBy = value; }
        }

        // Check to see if AcknowledgedBy property is set
        internal bool IsSetAcknowledgedBy()
        {
            return this._acknowledgedBy != null;
        }

        /// <summary>
        /// Gets and sets the property AcknowledgedTime. 
        /// <para>
        /// When the evaluation was acknowledged by the agent.
        /// </para>
        /// </summary>
        public DateTime AcknowledgedTime
        {
            get { return this._acknowledgedTime.GetValueOrDefault(); }
            set { this._acknowledgedTime = value; }
        }

        // Check to see if AcknowledgedTime property is set
        internal bool IsSetAcknowledgedTime()
        {
            return this._acknowledgedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AcknowledgerComment. 
        /// <para>
        /// The comment from the agent when they acknowledged the evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3072)]
        public string AcknowledgerComment
        {
            get { return this._acknowledgerComment; }
            set { this._acknowledgerComment = value; }
        }

        // Check to see if AcknowledgerComment property is set
        internal bool IsSetAcknowledgerComment()
        {
            return this._acknowledgerComment != null;
        }

        /// <summary>
        /// Gets and sets the property AutoEvaluationEnabled. 
        /// <para>
        /// Whether auto-evaluation is enabled.
        /// </para>
        /// </summary>
        public bool AutoEvaluationEnabled
        {
            get { return this._autoEvaluationEnabled.GetValueOrDefault(); }
            set { this._autoEvaluationEnabled = value; }
        }

        // Check to see if AutoEvaluationEnabled property is set
        internal bool IsSetAutoEvaluationEnabled()
        {
            return this._autoEvaluationEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AutoEvaluationStatus. 
        /// <para>
        /// The status of the contact auto evaluation. 
        /// </para>
        /// </summary>
        public AutoEvaluationStatus AutoEvaluationStatus
        {
            get { return this._autoEvaluationStatus; }
            set { this._autoEvaluationStatus = value; }
        }

        // Check to see if AutoEvaluationStatus property is set
        internal bool IsSetAutoEvaluationStatus()
        {
            return this._autoEvaluationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CalibrationSessionId. 
        /// <para>
        /// The calibration session ID that this evaluation belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public string CalibrationSessionId
        {
            get { return this._calibrationSessionId; }
            set { this._calibrationSessionId = value; }
        }

        // Check to see if CalibrationSessionId property is set
        internal bool IsSetCalibrationSessionId()
        {
            return this._calibrationSessionId != null;
        }

        /// <summary>
        /// Gets and sets the property ContactAgentId. 
        /// <para>
        /// The unique ID of the agent who handled the contact.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public string ContactAgentId
        {
            get { return this._contactAgentId; }
            set { this._contactAgentId = value; }
        }

        // Check to see if ContactAgentId property is set
        internal bool IsSetContactAgentId()
        {
            return this._contactAgentId != null;
        }

        /// <summary>
        /// Gets and sets the property ContactId. 
        /// <para>
        /// The identifier of the contact in this instance of Amazon Connect. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ContactId
        {
            get { return this._contactId; }
            set { this._contactId = value; }
        }

        // Check to see if ContactId property is set
        internal bool IsSetContactId()
        {
            return this._contactId != null;
        }

        /// <summary>
        /// Gets and sets the property ContactParticipantId. 
        /// <para>
        /// Identifier for a contact participant in the evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public string ContactParticipantId
        {
            get { return this._contactParticipantId; }
            set { this._contactParticipantId = value; }
        }

        // Check to see if ContactParticipantId property is set
        internal bool IsSetContactParticipantId()
        {
            return this._contactParticipantId != null;
        }

        /// <summary>
        /// Gets and sets the property ContactParticipantRole. 
        /// <para>
        /// Role of a contact participant in the evaluation.
        /// </para>
        /// </summary>
        public ContactParticipantRole ContactParticipantRole
        {
            get { return this._contactParticipantRole; }
            set { this._contactParticipantRole = value; }
        }

        // Check to see if ContactParticipantRole property is set
        internal bool IsSetContactParticipantRole()
        {
            return this._contactParticipantRole != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluatorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the person who evaluated the contact.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EvaluatorArn
        {
            get { return this._evaluatorArn; }
            set { this._evaluatorArn = value; }
        }

        // Check to see if EvaluatorArn property is set
        internal bool IsSetEvaluatorArn()
        {
            return this._evaluatorArn != null;
        }

        /// <summary>
        /// Gets and sets the property ReviewId. 
        /// <para>
        /// Identifier for the review.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public string ReviewId
        {
            get { return this._reviewId; }
            set { this._reviewId = value; }
        }

        // Check to see if ReviewId property is set
        internal bool IsSetReviewId()
        {
            return this._reviewId != null;
        }

        /// <summary>
        /// Gets and sets the property SamplingJobId. 
        /// <para>
        /// Identifier of the sampling job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public string SamplingJobId
        {
            get { return this._samplingJobId; }
            set { this._samplingJobId = value; }
        }

        // Check to see if SamplingJobId property is set
        internal bool IsSetSamplingJobId()
        {
            return this._samplingJobId != null;
        }

        /// <summary>
        /// Gets and sets the property ScoreAutomaticFail. 
        /// <para>
        /// The flag that marks the item as automatic fail. If the item or a child item gets an
        /// automatic fail answer, this flag is true.
        /// </para>
        /// </summary>
        public bool ScoreAutomaticFail
        {
            get { return this._scoreAutomaticFail.GetValueOrDefault(); }
            set { this._scoreAutomaticFail = value; }
        }

        // Check to see if ScoreAutomaticFail property is set
        internal bool IsSetScoreAutomaticFail()
        {
            return this._scoreAutomaticFail.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScoreNotApplicable. 
        /// <para>
        /// The flag to mark the item as not applicable for scoring.
        /// </para>
        /// </summary>
        public bool ScoreNotApplicable
        {
            get { return this._scoreNotApplicable.GetValueOrDefault(); }
            set { this._scoreNotApplicable = value; }
        }

        // Check to see if ScoreNotApplicable property is set
        internal bool IsSetScoreNotApplicable()
        {
            return this._scoreNotApplicable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScorePercentage. 
        /// <para>
        /// The total evaluation score expressed as a percentage.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public double ScorePercentage
        {
            get { return this._scorePercentage.GetValueOrDefault(); }
            set { this._scorePercentage = value; }
        }

        // Check to see if ScorePercentage property is set
        internal bool IsSetScorePercentage()
        {
            return this._scorePercentage.HasValue; 
        }

    }
}