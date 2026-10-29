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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property ConversationAbandon. 
        /// <para>
        /// A boolean flag indicating whether the chat conversation was abandoned by a Participant.
        /// </para>
        /// </summary>
        public bool? ConversationAbandon { get; set; }

        /// <summary>
        /// Checks to see if the ConversationAbandon property is set.
        /// </summary>
        internal bool IsSetConversationAbandon() => this.ConversationAbandon.HasValue;

        /// <summary>
        /// Gets and sets the property LastMessageTimestamp. 
        /// <para>
        /// Timestamp of last chat message by Participant.
        /// </para>
        /// </summary>
        public DateTime? LastMessageTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastMessageTimestamp property is set.
        /// </summary>
        internal bool IsSetLastMessageTimestamp() => this.LastMessageTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResponseTimeInMillis. 
        /// <para>
        /// Maximum chat response time by Participant.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? MaxResponseTimeInMillis { get; set; }

        /// <summary>
        /// Checks to see if the MaxResponseTimeInMillis property is set.
        /// </summary>
        internal bool IsSetMaxResponseTimeInMillis() => this.MaxResponseTimeInMillis.HasValue;

        /// <summary>
        /// Gets and sets the property MessageLengthInChars. 
        /// <para>
        /// Number of chat characters sent by Participant.
        /// </para>
        /// </summary>
        public int? MessageLengthInChars { get; set; }

        /// <summary>
        /// Checks to see if the MessageLengthInChars property is set.
        /// </summary>
        internal bool IsSetMessageLengthInChars() => this.MessageLengthInChars.HasValue;

        /// <summary>
        /// Gets and sets the property MessagesSent. 
        /// <para>
        /// Number of chat messages sent by Participant.
        /// </para>
        /// </summary>
        public int? MessagesSent { get; set; }

        /// <summary>
        /// Checks to see if the MessagesSent property is set.
        /// </summary>
        internal bool IsSetMessagesSent() => this.MessagesSent.HasValue;

        /// <summary>
        /// Gets and sets the property NumResponses. 
        /// <para>
        /// Number of chat messages sent by Participant.
        /// </para>
        /// </summary>
        public int? NumResponses { get; set; }

        /// <summary>
        /// Checks to see if the NumResponses property is set.
        /// </summary>
        internal bool IsSetNumResponses() => this.NumResponses.HasValue;

        /// <summary>
        /// Gets and sets the property ParticipantId. 
        /// <para>
        /// The Participant's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ParticipantId { get; set; }

        /// <summary>
        /// Checks to see if the ParticipantId property is set.
        /// </summary>
        internal bool IsSetParticipantId() => this.ParticipantId != null;

        /// <summary>
        /// Gets and sets the property ParticipantType. 
        /// <para>
        /// Information about the conversation participant. Following are the participant types:
        /// [Agent, Customer, Supervisor].
        /// </para>
        /// </summary>
        public ParticipantType ParticipantType { get; set; }

        /// <summary>
        /// Checks to see if the ParticipantType property is set.
        /// </summary>
        internal bool IsSetParticipantType() => this.ParticipantType != null;

        /// <summary>
        /// Gets and sets the property TotalResponseTimeInMillis. 
        /// <para>
        /// Total chat response time by Participant.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? TotalResponseTimeInMillis { get; set; }

        /// <summary>
        /// Checks to see if the TotalResponseTimeInMillis property is set.
        /// </summary>
        internal bool IsSetTotalResponseTimeInMillis() => this.TotalResponseTimeInMillis.HasValue;
    }
}
