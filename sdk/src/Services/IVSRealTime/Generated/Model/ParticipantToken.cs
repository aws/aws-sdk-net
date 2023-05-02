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
 * Do not modify this file. This file is generated from the ivs-realtime-2020-07-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IVSRealTime.Model
{
    /// <summary>
    /// Object specifying a participant token in a stage.
    /// </summary>
    public partial class ParticipantToken
    {
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();
        private List<string> _capabilities = new List<string>();
        private int? _duration;
        private DateTime? _expirationTime;
        private string _participantId;
        private string _token;
        private string _userId;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// Application-provided attributes to encode into the token and attach to a stage. <i>This
        /// field is exposed to all stage participants and should not be used for personally identifying,
        /// confidential, or sensitive information.</i> 
        /// </para>
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// Set of capabilities that the user is allowed to perform in the stage.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
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
        /// Gets and sets the property Duration. 
        /// <para>
        /// Duration (in minutes), after which the participant token expires. Default: 60 (1 hour).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20160)]
        public int Duration
        {
            get { return this._duration.GetValueOrDefault(); }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExpirationTime. 
        /// <para>
        /// ISO 8601 timestamp (returned as a string) for when this token expires.
        /// </para>
        /// </summary>
        public DateTime ExpirationTime
        {
            get { return this._expirationTime.GetValueOrDefault(); }
            set { this._expirationTime = value; }
        }

        // Check to see if ExpirationTime property is set
        internal bool IsSetExpirationTime()
        {
            return this._expirationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParticipantId. 
        /// <para>
        /// Unique identifier for this participant token, assigned by IVS.
        /// </para>
        /// </summary>
        public string ParticipantId
        {
            get { return this._participantId; }
            set { this._participantId = value; }
        }

        // Check to see if ParticipantId property is set
        internal bool IsSetParticipantId()
        {
            return this._participantId != null;
        }

        /// <summary>
        /// Gets and sets the property Token. 
        /// <para>
        /// The issued client token, encrypted.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Token
        {
            get { return this._token; }
            set { this._token = value; }
        }

        // Check to see if Token property is set
        internal bool IsSetToken()
        {
            return this._token != null;
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// Name to help identify the token. This can be any UTF-8 encoded text. <i>This field
        /// is exposed to all stage participants and should not be used for personally identifying,
        /// confidential, or sensitive information.</i> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}