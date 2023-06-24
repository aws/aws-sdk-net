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
 * Do not modify this file. This file is generated from the voice-id-2021-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.VoiceID.Model
{
    /// <summary>
    /// The fraud detection result produced by Voice ID, processed against the current session
    /// state and streamed audio of the speaker.
    /// </summary>
    public partial class FraudDetectionResult
    {
        private DateTime? _audioAggregationEndedAt;
        private DateTime? _audioAggregationStartedAt;
        private FraudDetectionConfiguration _configuration;
        private FraudDetectionDecision _decision;
        private string _fraudDetectionResultId;
        private List<string> _reasons = new List<string>();
        private FraudRiskDetails _riskDetails;

        /// <summary>
        /// Gets and sets the property AudioAggregationEndedAt. 
        /// <para>
        /// A timestamp of when audio aggregation ended for this fraud detection result.
        /// </para>
        /// </summary>
        public DateTime AudioAggregationEndedAt
        {
            get { return this._audioAggregationEndedAt.GetValueOrDefault(); }
            set { this._audioAggregationEndedAt = value; }
        }

        // Check to see if AudioAggregationEndedAt property is set
        internal bool IsSetAudioAggregationEndedAt()
        {
            return this._audioAggregationEndedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AudioAggregationStartedAt. 
        /// <para>
        /// A timestamp of when audio aggregation started for this fraud detection result.
        /// </para>
        /// </summary>
        public DateTime AudioAggregationStartedAt
        {
            get { return this._audioAggregationStartedAt.GetValueOrDefault(); }
            set { this._audioAggregationStartedAt = value; }
        }

        // Check to see if AudioAggregationStartedAt property is set
        internal bool IsSetAudioAggregationStartedAt()
        {
            return this._audioAggregationStartedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The <code>FraudDetectionConfiguration</code> used to generate this fraud detection
        /// result.
        /// </para>
        /// </summary>
        public FraudDetectionConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property Decision. 
        /// <para>
        /// The fraud detection decision produced by Voice ID, processed against the current session
        /// state and streamed audio of the speaker.
        /// </para>
        /// </summary>
        public FraudDetectionDecision Decision
        {
            get { return this._decision; }
            set { this._decision = value; }
        }

        // Check to see if Decision property is set
        internal bool IsSetDecision()
        {
            return this._decision != null;
        }

        /// <summary>
        /// Gets and sets the property FraudDetectionResultId. 
        /// <para>
        /// The unique identifier for this fraud detection result. Given there can be multiple
        /// fraud detections for a given session, this field helps in identifying if the returned
        /// result is from previous streaming activity or a new result. Note that in the absence
        /// of any new streaming activity or risk threshold changes, Voice ID always returns cached
        /// Fraud Detection result for this API.
        /// </para>
        /// </summary>
        [AWSProperty(Min=22, Max=22)]
        public string FraudDetectionResultId
        {
            get { return this._fraudDetectionResultId; }
            set { this._fraudDetectionResultId = value; }
        }

        // Check to see if FraudDetectionResultId property is set
        internal bool IsSetFraudDetectionResultId()
        {
            return this._fraudDetectionResultId != null;
        }

        /// <summary>
        /// Gets and sets the property Reasons. 
        /// <para>
        /// The reason speaker was flagged by the fraud detection system. This is only be populated
        /// if fraud detection Decision is <code>HIGH_RISK</code>, and the following possible
        /// values: <code>KNOWN_FRAUDSTER</code> and <code>VOICE_SPOOFING</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3)]
        public List<string> Reasons
        {
            get { return this._reasons; }
            set { this._reasons = value; }
        }

        // Check to see if Reasons property is set
        internal bool IsSetReasons()
        {
            return this._reasons != null && this._reasons.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RiskDetails. 
        /// <para>
        /// Details about each risk analyzed for this speaker. Currently, this contains KnownFraudsterRisk
        /// and VoiceSpoofingRisk details.
        /// </para>
        /// </summary>
        public FraudRiskDetails RiskDetails
        {
            get { return this._riskDetails; }
            set { this._riskDetails = value; }
        }

        // Check to see if RiskDetails property is set
        internal bool IsSetRiskDetails()
        {
            return this._riskDetails != null;
        }

    }
}