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
    /// Container for the parameters to the CreateVoiceProfile operation.
    /// Creates a voice profile, which consists of an enrolled user and their latest voice
    /// print.
    /// 
    ///  <important> 
    /// <para>
    /// Before creating any voice profiles, you must provide all notices and obtain all consents
    /// from the speaker as required under applicable privacy and biometrics laws, and as
    /// required under the <a href="https://aws.amazon.com/service-terms/">AWS service terms</a>
    /// for the Amazon Chime SDK.
    /// </para>
    ///  </important> 
    /// <para>
    /// For more information about voice profiles and voice analytics, see <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/pstn-voice-analytics.html">Using
    /// Amazon Chime SDK Voice Analytics</a> in the <i>Amazon Chime SDK Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateVoiceProfileRequest : AmazonChimeSDKVoiceRequest
    {
        private string _speakerSearchTaskId;

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

    }
}