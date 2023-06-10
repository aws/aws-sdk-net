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
    /// An occurrence during a stage session.
    /// </summary>
    public partial class Event
    {
        private EventErrorCode _errorCode;
        private DateTime? _eventTime;
        private EventName _name;
        private string _participantId;
        private string _remoteParticipantId;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// If the event is an error event, the error code is provided to give insight into the
        /// specific error that occurred. If the event is not an error event, this field is null.
        /// <code>INSUFFICIENT_CAPABILITIES</code> indicates that the participant tried to take
        /// an action that the participant’s token is not allowed to do. For more information
        /// about participant capabilities, see the <code>capabilities</code> field in <a>CreateParticipantToken</a>.
        /// </para>
        /// </summary>
        public EventErrorCode ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property EventTime. 
        /// <para>
        /// ISO 8601 timestamp (returned as a string) for when the event occurred.
        /// </para>
        /// </summary>
        public DateTime EventTime
        {
            get { return this._eventTime.GetValueOrDefault(); }
            set { this._eventTime = value; }
        }

        // Check to see if EventTime property is set
        internal bool IsSetEventTime()
        {
            return this._eventTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the event.
        /// </para>
        /// </summary>
        public EventName Name
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
        /// Gets and sets the property ParticipantId. 
        /// <para>
        /// Unique identifier for the participant who triggered the event. This is assigned by
        /// IVS.
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
        /// Gets and sets the property RemoteParticipantId. 
        /// <para>
        /// Unique identifier for the remote participant. For a subscribe event, this is the publisher.
        /// For a publish or join event, this is null. This is assigned by IVS.
        /// </para>
        /// </summary>
        public string RemoteParticipantId
        {
            get { return this._remoteParticipantId; }
            set { this._remoteParticipantId = value; }
        }

        // Check to see if RemoteParticipantId property is set
        internal bool IsSetRemoteParticipantId()
        {
            return this._remoteParticipantId != null;
        }

    }
}