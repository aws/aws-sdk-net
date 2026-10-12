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

namespace Amazon.VoiceID.Model
{
    /// <summary>
    /// The authentication result produced by Voice ID, processed against the current session
    /// state and streamed audio of the speaker.
    /// </summary>
    public partial class AuthenticationResult
    {
        /// <summary>
        /// Gets and sets the property AudioAggregationEndedAt. 
        /// <para>
        /// A timestamp of when audio aggregation ended for this authentication result.
        /// </para>
        /// </summary>
        public DateTime? AudioAggregationEndedAt { get; set; }

        /// <summary>
        /// Checks to see if the AudioAggregationEndedAt property is set.
        /// </summary>
        internal bool IsSetAudioAggregationEndedAt() => this.AudioAggregationEndedAt.HasValue;

        /// <summary>
        /// Gets and sets the property AudioAggregationStartedAt. 
        /// <para>
        /// A timestamp of when audio aggregation started for this authentication result.
        /// </para>
        /// </summary>
        public DateTime? AudioAggregationStartedAt { get; set; }

        /// <summary>
        /// Checks to see if the AudioAggregationStartedAt property is set.
        /// </summary>
        internal bool IsSetAudioAggregationStartedAt() => this.AudioAggregationStartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property AuthenticationResultId. 
        /// <para>
        /// The unique identifier for this authentication result. Because there can be multiple
        /// authentications for a given session, this field helps to identify if the returned
        /// result is from a previous streaming activity or a new result. Note that in absence
        /// of any new streaming activity, <c>AcceptanceThreshold</c> changes, or <c>SpeakerId</c>
        /// changes, Voice ID always returns cached Authentication Result for this API.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 22, Max = 22)]
        public string AuthenticationResultId { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationResultId property is set.
        /// </summary>
        internal bool IsSetAuthenticationResultId() => this.AuthenticationResultId != null;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The <c>AuthenticationConfiguration</c> used to generate this authentication result.
        /// </para>
        /// </summary>
        public AuthenticationConfiguration Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property CustomerSpeakerId. 
        /// <para>
        /// The client-provided identifier for the speaker whose authentication result is produced.
        /// Only present if a <c>SpeakerId</c> is provided for the session.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 256)]
        public string CustomerSpeakerId { get; set; }

        /// <summary>
        /// Checks to see if the CustomerSpeakerId property is set.
        /// </summary>
        internal bool IsSetCustomerSpeakerId() => this.CustomerSpeakerId != null;

        /// <summary>
        /// Gets and sets the property Decision. 
        /// <para>
        /// The authentication decision produced by Voice ID, processed against the current session
        /// state and streamed audio of the speaker.
        /// </para>
        /// </summary>
        public AuthenticationDecision Decision { get; set; }

        /// <summary>
        /// Checks to see if the Decision property is set.
        /// </summary>
        internal bool IsSetDecision() => this.Decision != null;

        /// <summary>
        /// Gets and sets the property GeneratedSpeakerId. 
        /// <para>
        /// The service-generated identifier for the speaker whose authentication result is produced.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 25, Max = 25)]
        public string GeneratedSpeakerId { get; set; }

        /// <summary>
        /// Checks to see if the GeneratedSpeakerId property is set.
        /// </summary>
        internal bool IsSetGeneratedSpeakerId() => this.GeneratedSpeakerId != null;

        /// <summary>
        /// Gets and sets the property Score. 
        /// <para>
        /// The authentication score for the speaker whose authentication result is produced.
        /// This value is only present if the authentication decision is either <c>ACCEPT</c>
        /// or <c>REJECT</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public int? Score { get; set; }

        /// <summary>
        /// Checks to see if the Score property is set.
        /// </summary>
        internal bool IsSetScore() => this.Score.HasValue;
    }
}
