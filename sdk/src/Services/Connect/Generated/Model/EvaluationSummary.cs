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
    /// Summary information about a contact evaluation.
    /// </summary>
    public partial class EvaluationSummary
    {
        private EvaluationAcknowledgementSummary _acknowledgement;
        private bool? _autoEvaluationEnabled;
        private AutoEvaluationStatus _autoEvaluationStatus;
        private string _calibrationSessionId;
        private EvaluationContactParticipant _contactParticipant;
        private DateTime? _createdTime;
        private string _evaluationArn;
        private string _evaluationFormId;
        private string _evaluationFormTitle;
        private string _evaluationId;
        private EvaluationType _evaluationType;
        private string _evaluatorArn;
        private DateTime? _lastModifiedTime;
        private EvaluationScore _score;
        private EvaluationStatus _status;

        /// <summary>
        /// Gets and sets the property Acknowledgement. 
        /// <para>
        /// Information related to evaluation acknowledgement.
        /// </para>
        /// </summary>
        public EvaluationAcknowledgementSummary Acknowledgement
        {
            get { return this._acknowledgement; }
            set { this._acknowledgement = value; }
        }

        // Check to see if Acknowledgement property is set
        internal bool IsSetAcknowledgement()
        {
            return this._acknowledgement != null;
        }

        /// <summary>
        /// Gets and sets the property AutoEvaluationEnabled. 
        /// <para>
        /// Whether automated evaluation is enabled.
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
        /// Gets and sets the property ContactParticipant. 
        /// <para>
        /// Information about a contact participant in the evaluation.
        /// </para>
        /// </summary>
        public EvaluationContactParticipant ContactParticipant
        {
            get { return this._contactParticipant; }
            set { this._contactParticipant = value; }
        }

        // Check to see if ContactParticipant property is set
        internal bool IsSetContactParticipant()
        {
            return this._contactParticipant != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The timestamp for when the evaluation was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreatedTime
        {
            get { return this._createdTime.GetValueOrDefault(); }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EvaluationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the contact evaluation resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EvaluationArn
        {
            get { return this._evaluationArn; }
            set { this._evaluationArn = value; }
        }

        // Check to see if EvaluationArn property is set
        internal bool IsSetEvaluationArn()
        {
            return this._evaluationArn != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationFormId. 
        /// <para>
        /// The unique identifier for the evaluation form.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public string EvaluationFormId
        {
            get { return this._evaluationFormId; }
            set { this._evaluationFormId = value; }
        }

        // Check to see if EvaluationFormId property is set
        internal bool IsSetEvaluationFormId()
        {
            return this._evaluationFormId != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationFormTitle. 
        /// <para>
        /// A title of the evaluation form.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EvaluationFormTitle
        {
            get { return this._evaluationFormTitle; }
            set { this._evaluationFormTitle = value; }
        }

        // Check to see if EvaluationFormTitle property is set
        internal bool IsSetEvaluationFormTitle()
        {
            return this._evaluationFormTitle != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationId. 
        /// <para>
        /// A unique identifier for the contact evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public string EvaluationId
        {
            get { return this._evaluationId; }
            set { this._evaluationId = value; }
        }

        // Check to see if EvaluationId property is set
        internal bool IsSetEvaluationId()
        {
            return this._evaluationId != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationType. 
        /// <para>
        /// Type of the evaluation. 
        /// </para>
        /// </summary>
        public EvaluationType EvaluationType
        {
            get { return this._evaluationType; }
            set { this._evaluationType = value; }
        }

        // Check to see if EvaluationType property is set
        internal bool IsSetEvaluationType()
        {
            return this._evaluationType != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluatorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user who last updated the evaluation.
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
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The timestamp for when the evaluation was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Score. 
        /// <para>
        /// The overall score of the contact evaluation.
        /// </para>
        /// </summary>
        public EvaluationScore Score
        {
            get { return this._score; }
            set { this._score = value; }
        }

        // Check to see if Score property is set
        internal bool IsSetScore()
        {
            return this._score != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the contact evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EvaluationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}