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
    /// Details regarding various fraud risk analyses performed against the current session
    /// state and streamed audio of the speaker.
    /// </summary>
    public partial class FraudRiskDetails
    {
        private KnownFraudsterRisk _knownFraudsterRisk;
        private VoiceSpoofingRisk _voiceSpoofingRisk;

        /// <summary>
        /// Gets and sets the property KnownFraudsterRisk. 
        /// <para>
        /// The details resulting from 'Known Fraudster Risk' analysis of the speaker.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KnownFraudsterRisk KnownFraudsterRisk
        {
            get { return this._knownFraudsterRisk; }
            set { this._knownFraudsterRisk = value; }
        }

        // Check to see if KnownFraudsterRisk property is set
        internal bool IsSetKnownFraudsterRisk()
        {
            return this._knownFraudsterRisk != null;
        }

        /// <summary>
        /// Gets and sets the property VoiceSpoofingRisk. 
        /// <para>
        /// The details resulting from 'Voice Spoofing Risk' analysis of the speaker.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VoiceSpoofingRisk VoiceSpoofingRisk
        {
            get { return this._voiceSpoofingRisk; }
            set { this._voiceSpoofingRisk = value; }
        }

        // Check to see if VoiceSpoofingRisk property is set
        internal bool IsSetVoiceSpoofingRisk()
        {
            return this._voiceSpoofingRisk != null;
        }

    }
}