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
    /// Contains details produced as a result of performing known fraudster risk analysis
    /// on a speaker.
    /// </summary>
    public partial class KnownFraudsterRisk
    {
        private string _generatedFraudsterId;
        private int? _riskScore;

        /// <summary>
        /// Gets and sets the property GeneratedFraudsterId. 
        /// <para>
        /// The identifier of the fraudster that is the closest match to the speaker. If there
        /// are no fraudsters registered in a given domain, or if there are no fraudsters with
        /// a non-zero RiskScore, this value is <c>null</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=25, Max=25)]
        public string GeneratedFraudsterId
        {
            get { return this._generatedFraudsterId; }
            set { this._generatedFraudsterId = value; }
        }

        // Check to see if GeneratedFraudsterId property is set
        internal bool IsSetGeneratedFraudsterId()
        {
            return this._generatedFraudsterId != null;
        }

        /// <summary>
        /// Gets and sets the property RiskScore. 
        /// <para>
        /// The score indicating the likelihood the speaker is a known fraudster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public int? RiskScore
        {
            get { return this._riskScore; }
            set { this._riskScore = value; }
        }

        // Check to see if RiskScore property is set
        internal bool IsSetRiskScore()
        {
            return this._riskScore.HasValue; 
        }

    }
}