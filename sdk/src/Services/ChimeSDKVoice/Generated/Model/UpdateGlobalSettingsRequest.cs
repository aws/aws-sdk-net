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
    /// Container for the parameters to the UpdateGlobalSettings operation.
    /// Updates global settings for the Amazon Chime SDK Voice Connectors in an AWS account.
    /// </summary>
    public partial class UpdateGlobalSettingsRequest : AmazonChimeSDKVoiceRequest
    {
        private VoiceConnectorSettings _voiceConnector;

        /// <summary>
        /// Gets and sets the property VoiceConnector. 
        /// <para>
        /// The Voice Connector settings.
        /// </para>
        /// </summary>
        public VoiceConnectorSettings VoiceConnector
        {
            get { return this._voiceConnector; }
            set { this._voiceConnector = value; }
        }

        // Check to see if VoiceConnector property is set
        internal bool IsSetVoiceConnector()
        {
            return this._voiceConnector != null;
        }

    }
}