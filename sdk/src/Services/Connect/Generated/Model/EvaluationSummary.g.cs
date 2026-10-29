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
    /// Summary information about a contact evaluation.
    /// </summary>
    public partial class EvaluationSummary
    {
        /// <summary>
        /// Gets and sets the property Acknowledgement. 
        /// <para>
        /// Information related to evaluation acknowledgement.
        /// </para>
        /// </summary>
        public EvaluationAcknowledgementSummary Acknowledgement { get; set; }

        /// <summary>
        /// Checks to see if the Acknowledgement property is set.
        /// </summary>
        internal bool IsSetAcknowledgement() => this.Acknowledgement != null;

        /// <summary>
        /// Gets and sets the property AutoEvaluationEnabled. 
        /// <para>
        /// Whether automated evaluation is enabled.
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
        /// Gets and sets the property ContactParticipant. 
        /// <para>
        /// Information about a contact participant in the evaluation.
        /// </para>
        /// </summary>
        public EvaluationContactParticipant ContactParticipant { get; set; }

        /// <summary>
        /// Checks to see if the ContactParticipant property is set.
        /// </summary>
        internal bool IsSetContactParticipant() => this.ContactParticipant != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The timestamp for when the evaluation was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property EvaluationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the contact evaluation resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EvaluationArn { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationArn property is set.
        /// </summary>
        internal bool IsSetEvaluationArn() => this.EvaluationArn != null;

        /// <summary>
        /// Gets and sets the property EvaluationFormId. 
        /// <para>
        /// The unique identifier for the evaluation form.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 500)]
        public string EvaluationFormId { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationFormId property is set.
        /// </summary>
        internal bool IsSetEvaluationFormId() => this.EvaluationFormId != null;

        /// <summary>
        /// Gets and sets the property EvaluationFormTitle. 
        /// <para>
        /// A title of the evaluation form.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EvaluationFormTitle { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationFormTitle property is set.
        /// </summary>
        internal bool IsSetEvaluationFormTitle() => this.EvaluationFormTitle != null;

        /// <summary>
        /// Gets and sets the property EvaluationId. 
        /// <para>
        /// A unique identifier for the contact evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 500)]
        public string EvaluationId { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationId property is set.
        /// </summary>
        internal bool IsSetEvaluationId() => this.EvaluationId != null;

        /// <summary>
        /// Gets and sets the property EvaluationType. 
        /// <para>
        /// Type of the evaluation. 
        /// </para>
        /// </summary>
        public EvaluationType EvaluationType { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationType property is set.
        /// </summary>
        internal bool IsSetEvaluationType() => this.EvaluationType != null;

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
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The timestamp for when the evaluation was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the contact evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EvaluationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
