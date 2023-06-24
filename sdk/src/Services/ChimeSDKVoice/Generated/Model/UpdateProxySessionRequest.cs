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
    /// Container for the parameters to the UpdateProxySession operation.
    /// Updates the specified proxy session details, such as voice or SMS capabilities.
    /// </summary>
    public partial class UpdateProxySessionRequest : AmazonChimeSDKVoiceRequest
    {
        private List<string> _capabilities = new List<string>();
        private int? _expiryMinutes;
        private string _proxySessionId;
        private string _voiceConnectorId;

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// The proxy session capabilities.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Capabilities
        {
            get { return this._capabilities; }
            set { this._capabilities = value; }
        }

        // Check to see if Capabilities property is set
        internal bool IsSetCapabilities()
        {
            return this._capabilities != null && this._capabilities.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ExpiryMinutes. 
        /// <para>
        /// The number of minutes allowed for the proxy session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int ExpiryMinutes
        {
            get { return this._expiryMinutes.GetValueOrDefault(); }
            set { this._expiryMinutes = value; }
        }

        // Check to see if ExpiryMinutes property is set
        internal bool IsSetExpiryMinutes()
        {
            return this._expiryMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProxySessionId. 
        /// <para>
        /// The proxy session ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ProxySessionId
        {
            get { return this._proxySessionId; }
            set { this._proxySessionId = value; }
        }

        // Check to see if ProxySessionId property is set
        internal bool IsSetProxySessionId()
        {
            return this._proxySessionId != null;
        }

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

    }
}