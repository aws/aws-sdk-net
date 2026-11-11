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
    /// Information about the overall participant interactions at the contact level.
    /// </summary>
    public partial class ChatContactMetrics
    {
        /// <summary>
        /// Gets and sets the property AgentFirstResponseTimeInMillis. 
        /// <para>
        /// The time for an agent to respond after obtaining a chat contact.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? AgentFirstResponseTimeInMillis { get; set; }

        /// <summary>
        /// Checks to see if the AgentFirstResponseTimeInMillis property is set.
        /// </summary>
        internal bool IsSetAgentFirstResponseTimeInMillis() => this.AgentFirstResponseTimeInMillis.HasValue;

        /// <summary>
        /// Gets and sets the property AgentFirstResponseTimestamp. 
        /// <para>
        /// The agent first response timestamp for a chat contact.
        /// </para>
        /// </summary>
        public DateTime? AgentFirstResponseTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the AgentFirstResponseTimestamp property is set.
        /// </summary>
        internal bool IsSetAgentFirstResponseTimestamp() => this.AgentFirstResponseTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property ConversationCloseTimeInMillis. 
        /// <para>
        /// The time it took for a contact to end after the last customer message.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? ConversationCloseTimeInMillis { get; set; }

        /// <summary>
        /// Checks to see if the ConversationCloseTimeInMillis property is set.
        /// </summary>
        internal bool IsSetConversationCloseTimeInMillis() => this.ConversationCloseTimeInMillis.HasValue;

        /// <summary>
        /// Gets and sets the property ConversationTurnCount. 
        /// <para>
        /// The number of conversation turns in a chat contact, which represents the back-and-forth
        /// exchanges between customer and other participants.
        /// </para>
        /// </summary>
        public int? ConversationTurnCount { get; set; }

        /// <summary>
        /// Checks to see if the ConversationTurnCount property is set.
        /// </summary>
        internal bool IsSetConversationTurnCount() => this.ConversationTurnCount.HasValue;

        /// <summary>
        /// Gets and sets the property MultiParty. 
        /// <para>
        /// A boolean flag indicating whether multiparty chat or supervisor barge were enabled
        /// on this contact.
        /// </para>
        /// </summary>
        public bool? MultiParty { get; set; }

        /// <summary>
        /// Checks to see if the MultiParty property is set.
        /// </summary>
        internal bool IsSetMultiParty() => this.MultiParty.HasValue;

        /// <summary>
        /// Gets and sets the property TotalBotMessageLengthInChars. 
        /// <para>
        /// The total number of characters from bot and automated messages on a chat contact.
        /// </para>
        /// </summary>
        public int? TotalBotMessageLengthInChars { get; set; }

        /// <summary>
        /// Checks to see if the TotalBotMessageLengthInChars property is set.
        /// </summary>
        internal bool IsSetTotalBotMessageLengthInChars() => this.TotalBotMessageLengthInChars.HasValue;

        /// <summary>
        /// Gets and sets the property TotalBotMessages. 
        /// <para>
        /// The total number of bot and automated messages on a chat contact.
        /// </para>
        /// </summary>
        public int? TotalBotMessages { get; set; }

        /// <summary>
        /// Checks to see if the TotalBotMessages property is set.
        /// </summary>
        internal bool IsSetTotalBotMessages() => this.TotalBotMessages.HasValue;

        /// <summary>
        /// Gets and sets the property TotalMessages. 
        /// <para>
        /// The number of chat messages on the contact.
        /// </para>
        /// </summary>
        public int? TotalMessages { get; set; }

        /// <summary>
        /// Checks to see if the TotalMessages property is set.
        /// </summary>
        internal bool IsSetTotalMessages() => this.TotalMessages.HasValue;
    }
}
