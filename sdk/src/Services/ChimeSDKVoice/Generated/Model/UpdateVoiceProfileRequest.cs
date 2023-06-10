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
    /// Container for the parameters to the UpdateVoiceProfile operation.
    /// Updates the specified voice profile’s voice print and refreshes its expiration timestamp.
    /// 
    ///  <important> 
    /// <para>
    /// As a condition of using this feature, you acknowledge that the collection, use, storage,
    /// and retention of your caller’s biometric identifiers and biometric information (“biometric
    /// data”) in the form of a digital voiceprint requires the caller’s informed consent
    /// via a written release. Such consent is required under various state laws, including
    /// biometrics laws in Illinois, Texas, Washington and other state privacy laws.
    /// </para>
    ///  
    /// <para>
    /// You must provide a written release to each caller through a process that clearly reflects
    /// each caller’s informed consent before using Amazon Chime SDK Voice Insights service,
    /// as required under the terms of your agreement with AWS governing your use of the service.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class UpdateVoiceProfileRequest : AmazonChimeSDKVoiceRequest
    {
        private string _speakerSearchTaskId;
        private string _voiceProfileId;

        /// <summary>
        /// Gets and sets the property SpeakerSearchTaskId. 
        /// <para>
        /// The ID of the speaker search task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string SpeakerSearchTaskId
        {
            get { return this._speakerSearchTaskId; }
            set { this._speakerSearchTaskId = value; }
        }

        // Check to see if SpeakerSearchTaskId property is set
        internal bool IsSetSpeakerSearchTaskId()
        {
            return this._speakerSearchTaskId != null;
        }

        /// <summary>
        /// Gets and sets the property VoiceProfileId. 
        /// <para>
        /// The profile ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string VoiceProfileId
        {
            get { return this._voiceProfileId; }
            set { this._voiceProfileId = value; }
        }

        // Check to see if VoiceProfileId property is set
        internal bool IsSetVoiceProfileId()
        {
            return this._voiceProfileId != null;
        }

    }
}