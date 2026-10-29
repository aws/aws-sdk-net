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
    /// Metadata information about a contact evaluation.
    /// </summary>
    public partial class EvaluationMetadata
    {
        /// <summary>
        /// Gets and sets the property Acknowledgement. 
        /// <para>
        /// Information related to evaluation acknowledgement.
        /// </para>
        /// </summary>
        public EvaluationAcknowledgement Acknowledgement { get; set; }

        /// <summary>
        /// Checks to see if the Acknowledgement property is set.
        /// </summary>
        internal bool IsSetAcknowledgement() => this.Acknowledgement != null;

        /// <summary>
        /// Gets and sets the property AutoEvaluation. 
        /// <para>
        /// Information related to automated evaluation.
        /// </para>
        /// </summary>
        public AutoEvaluationDetails AutoEvaluation { get; set; }

        /// <summary>
        /// Checks to see if the AutoEvaluation property is set.
        /// </summary>
        internal bool IsSetAutoEvaluation() => this.AutoEvaluation != null;

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
        /// The identifier of the agent who performed the contact.
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
        /// Gets and sets the property ContactParticipant. 
        /// <para>
        /// Information about a contact participant in this evaluation.
        /// </para>
        /// </summary>
        public EvaluationContactParticipant ContactParticipant { get; set; }

        /// <summary>
        /// Checks to see if the ContactParticipant property is set.
        /// </summary>
        internal bool IsSetContactParticipant() => this.ContactParticipant != null;

        /// <summary>
        /// Gets and sets the property EvaluatorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user who last updated the evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EvaluatorArn { get; set; }

        /// <summary>
        /// Checks to see if the EvaluatorArn property is set.
        /// </summary>
        internal bool IsSetEvaluatorArn() => this.EvaluatorArn != null;

        /// <summary>
        /// Gets and sets the property Review. 
        /// <para>
        /// Information about reviews of this evaluation.
        /// </para>
        /// </summary>
        public EvaluationReviewMetadata Review { get; set; }

        /// <summary>
        /// Checks to see if the Review property is set.
        /// </summary>
        internal bool IsSetReview() => this.Review != null;

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
        /// Gets and sets the property Score. 
        /// <para>
        /// The overall score of the contact evaluation.
        /// </para>
        /// </summary>
        public EvaluationScore Score { get; set; }

        /// <summary>
        /// Checks to see if the Score property is set.
        /// </summary>
        internal bool IsSetScore() => this.Score != null;
    }
}
