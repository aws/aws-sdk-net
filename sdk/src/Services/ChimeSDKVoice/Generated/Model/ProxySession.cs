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
    /// The proxy session for an Amazon Chime SDK Voice Connector.
    /// </summary>
    public partial class ProxySession
    {
        private List<string> _capabilities = new List<string>();
        private DateTime? _createdTimestamp;
        private DateTime? _endedTimestamp;
        private int? _expiryMinutes;
        private GeoMatchLevel _geoMatchLevel;
        private GeoMatchParams _geoMatchParams;
        private string _name;
        private NumberSelectionBehavior _numberSelectionBehavior;
        private List<Participant> _participants = new List<Participant>();
        private string _proxySessionId;
        private ProxySessionStatus _status;
        private DateTime? _updatedTimestamp;
        private string _voiceConnectorId;

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// The proxy session capabilities.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The created time stamp, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime CreatedTimestamp
        {
            get { return this._createdTimestamp.GetValueOrDefault(); }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndedTimestamp. 
        /// <para>
        /// The ended time stamp, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime EndedTimestamp
        {
            get { return this._endedTimestamp.GetValueOrDefault(); }
            set { this._endedTimestamp = value; }
        }

        // Check to see if EndedTimestamp property is set
        internal bool IsSetEndedTimestamp()
        {
            return this._endedTimestamp.HasValue; 
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
        /// The proxy session name.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
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
        /// Gets and sets the property Participants. 
        /// <para>
        /// The proxy session participants.
        /// </para>
        /// </summary>
        public List<Participant> Participants
        {
            get { return this._participants; }
            set { this._participants = value; }
        }

        // Check to see if Participants property is set
        internal bool IsSetParticipants()
        {
            return this._participants != null && this._participants.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ProxySessionId. 
        /// <para>
        /// The proxy session ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The proxy session status.
        /// </para>
        /// </summary>
        public ProxySessionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedTimestamp. 
        /// <para>
        /// The updated time stamp, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime UpdatedTimestamp
        {
            get { return this._updatedTimestamp.GetValueOrDefault(); }
            set { this._updatedTimestamp = value; }
        }

        // Check to see if UpdatedTimestamp property is set
        internal bool IsSetUpdatedTimestamp()
        {
            return this._updatedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VoiceConnectorId. 
        /// <para>
        /// The Voice Connector ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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