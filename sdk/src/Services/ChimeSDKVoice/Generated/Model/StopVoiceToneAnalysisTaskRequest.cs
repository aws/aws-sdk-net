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
 * Do not modify this file. This file is generated from the chime-sdk-voice-2022-08-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// Container for the parameters to the StopVoiceToneAnalysisTask operation.
    /// Stops a voice tone analysis task.
    /// </summary>
    public partial class StopVoiceToneAnalysisTaskRequest : AmazonChimeSDKVoiceRequest
    {
        private string _voiceConnectorId;
        private string _voiceToneAnalysisTaskId;

        /// <summary>
        /// Gets and sets the property VoiceConnectorId. 
        /// <para>
        /// The Voice Connector ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string VoiceConnectorId
        {
            get { return this._voiceConnectorId; }
            set { this._voiceConnectorId = value; }
        }

        // Check to see if VoiceConnectorId property is set
        internal bool IsSetVoiceConnectorId()
        {
            return this._voiceConnectorId != null;
        }

        /// <summary>
        /// Gets and sets the property VoiceToneAnalysisTaskId. 
        /// <para>
        /// The ID of the voice tone analysis task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string VoiceToneAnalysisTaskId
        {
            get { return this._voiceToneAnalysisTaskId; }
            set { this._voiceToneAnalysisTaskId = value; }
        }

        // Check to see if VoiceToneAnalysisTaskId property is set
        internal bool IsSetVoiceToneAnalysisTaskId()
        {
            return this._voiceToneAnalysisTaskId != null;
        }

    }
}