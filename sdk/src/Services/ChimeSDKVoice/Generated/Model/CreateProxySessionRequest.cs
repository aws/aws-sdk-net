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
    /// Container for the parameters to the CreateProxySession operation.
    /// Creates a proxy session for the specified Amazon Chime SDK Voice Connector for the
    /// specified participant phone numbers.
    /// </summary>
    public partial class CreateProxySessionRequest : AmazonChimeSDKVoiceRequest
    {
        private List<string> _capabilities = new List<string>();
        private int? _expiryMinutes;
        private GeoMatchLevel _geoMatchLevel;
        private GeoMatchParams _geoMatchParams;
        private string _name;
        private NumberSelectionBehavior _numberSelectionBehavior;
        private List<string> _participantPhoneNumbers = new List<string>();
        private string _voiceConnectorId;

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// The proxy session's capabilities.
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
        /// Gets and sets the property GeoMatchLevel. 
        /// <para>
        /// The preference for matching the country or area code of the proxy phone number with
        /// that of the first participant.
        /// </para>
        /// </summary>
        public GeoMatchLevel GeoMatchLevel
        {
            get { return this._geoMatchLevel; }
            set { this._geoMatchLevel = value; }
        }

        // Check to see if GeoMatchLevel property is set
        internal bool IsSetGeoMatchLevel()
        {
            return this._geoMatchLevel != null;
        }

        /// <summary>
        /// Gets and sets the property GeoMatchParams. 
        /// <para>
        /// The country and area code for the proxy phone number.
        /// </para>
        /// </summary>
        public GeoMatchParams GeoMatchParams
        {
            get { return this._geoMatchParams; }
            set { this._geoMatchParams = value; }
        }

        // Check to see if GeoMatchParams property is set
        internal bool IsSetGeoMatchParams()
        {
            return this._geoMatchParams != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the proxy session.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NumberSelectionBehavior. 
        /// <para>
        /// The preference for proxy phone number reuse, or stickiness, between the same participants
        /// across sessions.
        /// </para>
        /// </summary>
        public NumberSelectionBehavior NumberSelectionBehavior
        {
            get { return this._numberSelectionBehavior; }
            set { this._numberSelectionBehavior = value; }
        }

        // Check to see if NumberSelectionBehavior property is set
        internal bool IsSetNumberSelectionBehavior()
        {
            return this._numberSelectionBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property ParticipantPhoneNumbers. 
        /// <para>
        /// The participant phone numbers.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=2)]
        public List<string> ParticipantPhoneNumbers
        {
            get { return this._participantPhoneNumbers; }
            set { this._participantPhoneNumbers = value; }
        }

        // Check to see if ParticipantPhoneNumbers property is set
        internal bool IsSetParticipantPhoneNumbers()
        {
            return this._participantPhoneNumbers != null && this._participantPhoneNumbers.Count > 0; 
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