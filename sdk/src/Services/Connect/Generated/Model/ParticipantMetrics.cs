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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about a participant's interactions in a contact.
    /// </summary>
    public partial class ParticipantMetrics
    {
        private bool? _conversationAbandon;
        private DateTime? _lastMessageTimestamp;
        private long? _maxResponseTimeInMillis;
        private int? _messageLengthInChars;
        private int? _messagesSent;
        private int? _numResponses;
        private string _participantId;
        private ParticipantType _participantType;
        private long? _totalResponseTimeInMillis;

        /// <summary>
        /// Gets and sets the property ConversationAbandon. 
        /// <para>
        /// A boolean flag indicating whether the chat conversation was abandoned by a Participant.
        /// </para>
        /// </summary>
        public bool? ConversationAbandon
        {
            get { return this._conversationAbandon; }
            set { this._conversationAbandon = value; }
        }

        // Check to see if ConversationAbandon property is set
        internal bool IsSetConversationAbandon()
        {
            return this._conversationAbandon.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastMessageTimestamp. 
        /// <para>
        /// Timestamp of last chat message by Participant.
        /// </para>
        /// </summary>
        public DateTime? LastMessageTimestamp
        {
            get { return this._lastMessageTimestamp; }
            set { this._lastMessageTimestamp = value; }
        }

        // Check to see if LastMessageTimestamp property is set
        internal bool IsSetLastMessageTimestamp()
        {
            return this._lastMessageTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResponseTimeInMillis. 
        /// <para>
        /// Maximum chat response time by Participant.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? MaxResponseTimeInMillis
        {
            get { return this._maxResponseTimeInMillis; }
            set { this._maxResponseTimeInMillis = value; }
        }

        // Check to see if MaxResponseTimeInMillis property is set
        internal bool IsSetMaxResponseTimeInMillis()
        {
            return this._maxResponseTimeInMillis.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MessageLengthInChars. 
        /// <para>
        /// Number of chat characters sent by Participant.
        /// </para>
        /// </summary>
        public int? MessageLengthInChars
        {
            get { return this._messageLengthInChars; }
            set { this._messageLengthInChars = value; }
        }

        // Check to see if MessageLengthInChars property is set
        internal bool IsSetMessageLengthInChars()
        {
            return this._messageLengthInChars.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MessagesSent. 
        /// <para>
        /// Number of chat messages sent by Participant.
        /// </para>
        /// </summary>
        public int? MessagesSent
        {
            get { return this._messagesSent; }
            set { this._messagesSent = value; }
        }

        // Check to see if MessagesSent property is set
        internal bool IsSetMessagesSent()
        {
            return this._messagesSent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumResponses. 
        /// <para>
        /// Number of chat messages sent by Participant.
        /// </para>
        /// </summary>
        public int? NumResponses
        {
            get { return this._numResponses; }
            set { this._numResponses = value; }
        }

        // Check to see if NumResponses property is set
        internal bool IsSetNumResponses()
        {
            return this._numResponses.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParticipantId. 
        /// <para>
        /// The Participant's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property ParticipantType. 
        /// <para>
        /// Information about the conversation participant. Following are the participant types:
        /// [Agent, Customer, Supervisor].
        /// </para>
        /// </summary>
        public ParticipantType ParticipantType
        {
            get { return this._participantType; }
            set { this._participantType = value; }
        }

        // Check to see if ParticipantType property is set
        internal bool IsSetParticipantType()
        {
            return this._participantType != null;
        }

        /// <summary>
        /// Gets and sets the property TotalResponseTimeInMillis. 
        /// <para>
        /// Total chat response time by Participant.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? TotalResponseTimeInMillis
        {
            get { return this._totalResponseTimeInMillis; }
            set { this._totalResponseTimeInMillis = value; }
        }

        // Check to see if TotalResponseTimeInMillis property is set
        internal bool IsSetTotalResponseTimeInMillis()
        {
            return this._totalResponseTimeInMillis.HasValue; 
        }

    }
}