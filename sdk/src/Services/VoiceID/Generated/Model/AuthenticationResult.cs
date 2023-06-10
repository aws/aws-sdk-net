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
    /// The authentication result produced by Voice ID, processed against the current session
    /// state and streamed audio of the speaker.
    /// </summary>
    public partial class AuthenticationResult
    {
        private DateTime? _audioAggregationEndedAt;
        private DateTime? _audioAggregationStartedAt;
        private string _authenticationResultId;
        private AuthenticationConfiguration _configuration;
        private string _customerSpeakerId;
        private AuthenticationDecision _decision;
        private string _generatedSpeakerId;
        private int? _score;

        /// <summary>
        /// Gets and sets the property AudioAggregationEndedAt. 
        /// <para>
        /// A timestamp of when audio aggregation ended for this authentication result.
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
        /// A timestamp of when audio aggregation started for this authentication result.
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
        /// Gets and sets the property AuthenticationResultId. 
        /// <para>
        /// The unique identifier for this authentication result. Because there can be multiple
        /// authentications for a given session, this field helps to identify if the returned
        /// result is from a previous streaming activity or a new result. Note that in absence
        /// of any new streaming activity, <code>AcceptanceThreshold</code> changes, or <code>SpeakerId</code>
        /// changes, Voice ID always returns cached Authentication Result for this API.
        /// </para>
        /// </summary>
        [AWSProperty(Min=22, Max=22)]
        public string AuthenticationResultId
        {
            get { return this._authenticationResultId; }
            set { this._authenticationResultId = value; }
        }

        // Check to see if AuthenticationResultId property is set
        internal bool IsSetAuthenticationResultId()
        {
            return this._authenticationResultId != null;
        }

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The <code>AuthenticationConfiguration</code> used to generate this authentication
        /// result.
        /// </para>
        /// </summary>
        public AuthenticationConfiguration Configuration
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
        /// Gets and sets the property CustomerSpeakerId. 
        /// <para>
        /// The client-provided identifier for the speaker whose authentication result is produced.
        /// Only present if a <code>SpeakerId</code> is provided for the session.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=256)]
        public string CustomerSpeakerId
        {
            get { return this._customerSpeakerId; }
            set { this._customerSpeakerId = value; }
        }

        // Check to see if CustomerSpeakerId property is set
        internal bool IsSetCustomerSpeakerId()
        {
            return this._customerSpeakerId != null;
        }

        /// <summary>
        /// Gets and sets the property Decision. 
        /// <para>
        /// The authentication decision produced by Voice ID, processed against the current session
        /// state and streamed audio of the speaker.
        /// </para>
        /// </summary>
        public AuthenticationDecision Decision
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
        /// Gets and sets the property GeneratedSpeakerId. 
        /// <para>
        /// The service-generated identifier for the speaker whose authentication result is produced.
        /// </para>
        /// </summary>
        [AWSProperty(Min=25, Max=25)]
        public string GeneratedSpeakerId
        {
            get { return this._generatedSpeakerId; }
            set { this._generatedSpeakerId = value; }
        }

        // Check to see if GeneratedSpeakerId property is set
        internal bool IsSetGeneratedSpeakerId()
        {
            return this._generatedSpeakerId != null;
        }

        /// <summary>
        /// Gets and sets the property Score. 
        /// <para>
        /// The authentication score for the speaker whose authentication result is produced.
        /// This value is only present if the authentication decision is either <code>ACCEPT</code>
        /// or <code>REJECT</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int Score
        {
            get { return this._score.GetValueOrDefault(); }
            set { this._score = value; }
        }

        // Check to see if Score property is set
        internal bool IsSetScore()
        {
            return this._score.HasValue; 
        }

    }
}