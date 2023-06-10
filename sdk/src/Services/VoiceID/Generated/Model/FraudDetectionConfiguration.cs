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
    /// The configuration used for performing fraud detection over a speaker during a session.
    /// </summary>
    public partial class FraudDetectionConfiguration
    {
        private int? _riskThreshold;
        private string _watchlistId;

        /// <summary>
        /// Gets and sets the property RiskThreshold. 
        /// <para>
        /// Threshold value for determining whether the speaker is a fraudster. If the detected
        /// risk score calculated by Voice ID is higher than the threshold, the speaker is considered
        /// a fraudster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int RiskThreshold
        {
            get { return this._riskThreshold.GetValueOrDefault(); }
            set { this._riskThreshold = value; }
        }

        // Check to see if RiskThreshold property is set
        internal bool IsSetRiskThreshold()
        {
            return this._riskThreshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WatchlistId. 
        /// <para>
        /// The identifier of the watchlist against which fraud detection is performed. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=22, Max=22)]
        public string WatchlistId
        {
            get { return this._watchlistId; }
            set { this._watchlistId = value; }
        }

        // Check to see if WatchlistId property is set
        internal bool IsSetWatchlistId()
        {
            return this._watchlistId != null;
        }

    }
}