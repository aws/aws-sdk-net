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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.VoiceID.Model
{
    /// <summary>
    /// The fraud detection configuration to be used during the batch speaker enrollment job.
    /// </summary>
    public partial class EnrollmentJobFraudDetectionConfig
    {
        private FraudDetectionAction _fraudDetectionAction;
        private int? _riskThreshold;
        private List<string> _watchlistIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property FraudDetectionAction. 
        /// <para>
        /// The action to take when the given speaker is flagged by the fraud detection system.
        /// The default value is <c>FAIL</c>, which fails the speaker enrollment. Changing this
        /// value to <c>IGNORE</c> results in the speaker being enrolled even if they are flagged
        /// by the fraud detection system.
        /// </para>
        /// </summary>
        public FraudDetectionAction FraudDetectionAction
        {
            get { return this._fraudDetectionAction; }
            set { this._fraudDetectionAction = value; }
        }

        // Check to see if FraudDetectionAction property is set
        internal bool IsSetFraudDetectionAction()
        {
            return this._fraudDetectionAction != null;
        }

        /// <summary>
        /// Gets and sets the property RiskThreshold. 
        /// <para>
        /// Threshold value for determining whether the speaker is a high risk to be fraudulent.
        /// If the detected risk score calculated by Voice ID is greater than or equal to the
        /// threshold, the speaker is considered a fraudster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int? RiskThreshold
        {
            get { return this._riskThreshold; }
            set { this._riskThreshold = value; }
        }

        // Check to see if RiskThreshold property is set
        internal bool IsSetRiskThreshold()
        {
            return this._riskThreshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WatchlistIds. 
        /// <para>
        /// The identifier of watchlists against which fraud detection is performed. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> WatchlistIds
        {
            get { return this._watchlistIds; }
            set { this._watchlistIds = value; }
        }

        // Check to see if WatchlistIds property is set
        internal bool IsSetWatchlistIds()
        {
            return this._watchlistIds != null && (this._watchlistIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}