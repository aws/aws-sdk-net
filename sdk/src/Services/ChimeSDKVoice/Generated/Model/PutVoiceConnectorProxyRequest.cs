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
    /// Container for the parameters to the PutVoiceConnectorProxy operation.
    /// Puts the specified proxy configuration to the specified Amazon Chime SDK Voice Connector.
    /// </summary>
    public partial class PutVoiceConnectorProxyRequest : AmazonChimeSDKVoiceRequest
    {
        private int? _defaultSessionExpiryMinutes;
        private bool? _disabled;
        private string _fallBackPhoneNumber;
        private List<string> _phoneNumberPoolCountries = new List<string>();
        private string _voiceConnectorId;

        /// <summary>
        /// Gets and sets the property DefaultSessionExpiryMinutes. 
        /// <para>
        /// The default number of minutes allowed for proxy session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int DefaultSessionExpiryMinutes
        {
            get { return this._defaultSessionExpiryMinutes.GetValueOrDefault(); }
            set { this._defaultSessionExpiryMinutes = value; }
        }

        // Check to see if DefaultSessionExpiryMinutes property is set
        internal bool IsSetDefaultSessionExpiryMinutes()
        {
            return this._defaultSessionExpiryMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Disabled. 
        /// <para>
        /// When true, stops proxy sessions from being created on the specified Amazon Chime SDK
        /// Voice Connector.
        /// </para>
        /// </summary>
        public bool Disabled
        {
            get { return this._disabled.GetValueOrDefault(); }
            set { this._disabled = value; }
        }

        // Check to see if Disabled property is set
        internal bool IsSetDisabled()
        {
            return this._disabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FallBackPhoneNumber. 
        /// <para>
        /// The phone number to route calls to after a proxy session expires.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string FallBackPhoneNumber
        {
            get { return this._fallBackPhoneNumber; }
            set { this._fallBackPhoneNumber = value; }
        }

        // Check to see if FallBackPhoneNumber property is set
        internal bool IsSetFallBackPhoneNumber()
        {
            return this._fallBackPhoneNumber != null;
        }

        /// <summary>
        /// Gets and sets the property PhoneNumberPoolCountries. 
        /// <para>
        /// The countries for proxy phone numbers to be selected from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<string> PhoneNumberPoolCountries
        {
            get { return this._phoneNumberPoolCountries; }
            set { this._phoneNumberPoolCountries = value; }
        }

        // Check to see if PhoneNumberPoolCountries property is set
        internal bool IsSetPhoneNumberPoolCountries()
        {
            return this._phoneNumberPoolCountries != null && this._phoneNumberPoolCountries.Count > 0; 
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