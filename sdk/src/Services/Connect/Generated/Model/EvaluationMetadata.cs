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
    /// Metadata information about a contact evaluation.
    /// </summary>
    public partial class EvaluationMetadata
    {
        private EvaluationAcknowledgement _acknowledgement;
        private AutoEvaluationDetails _autoEvaluation;
        private string _calibrationSessionId;
        private string _contactAgentId;
        private string _contactId;
        private string _evaluatorArn;
        private EvaluationScore _score;

        /// <summary>
        /// Gets and sets the property Acknowledgement. 
        /// <para>
        /// Information related to evaluation acknowledgement.
        /// </para>
        /// </summary>
        public EvaluationAcknowledgement Acknowledgement
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
        /// Gets and sets the property AutoEvaluation. 
        /// <para>
        /// Information related to automated evaluation.
        /// </para>
        /// </summary>
        public AutoEvaluationDetails AutoEvaluation
        {
            get { return this._autoEvaluation; }
            set { this._autoEvaluation = value; }
        }

        // Check to see if AutoEvaluation property is set
        internal bool IsSetAutoEvaluation()
        {
            return this._autoEvaluation != null;
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
        /// The identifier of the agent who performed the contact.
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

    }
}