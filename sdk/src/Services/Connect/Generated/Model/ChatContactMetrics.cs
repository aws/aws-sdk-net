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
    /// Information about the overall participant interactions at the contact level.
    /// </summary>
    public partial class ChatContactMetrics
    {
        private long? _agentFirstResponseTimeInMillis;
        private DateTime? _agentFirstResponseTimestamp;
        private long? _conversationCloseTimeInMillis;
        private int? _conversationTurnCount;
        private bool? _multiParty;
        private int? _totalBotMessageLengthInChars;
        private int? _totalBotMessages;
        private int? _totalMessages;

        /// <summary>
        /// Gets and sets the property AgentFirstResponseTimeInMillis. 
        /// <para>
        /// The time for an agent to respond after obtaining a chat contact.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? AgentFirstResponseTimeInMillis
        {
            get { return this._agentFirstResponseTimeInMillis; }
            set { this._agentFirstResponseTimeInMillis = value; }
        }

        // Check to see if AgentFirstResponseTimeInMillis property is set
        internal bool IsSetAgentFirstResponseTimeInMillis()
        {
            return this._agentFirstResponseTimeInMillis.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AgentFirstResponseTimestamp. 
        /// <para>
        /// The agent first response timestamp for a chat contact.
        /// </para>
        /// </summary>
        public DateTime? AgentFirstResponseTimestamp
        {
            get { return this._agentFirstResponseTimestamp; }
            set { this._agentFirstResponseTimestamp = value; }
        }

        // Check to see if AgentFirstResponseTimestamp property is set
        internal bool IsSetAgentFirstResponseTimestamp()
        {
            return this._agentFirstResponseTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConversationCloseTimeInMillis. 
        /// <para>
        /// The time it took for a contact to end after the last customer message.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? ConversationCloseTimeInMillis
        {
            get { return this._conversationCloseTimeInMillis; }
            set { this._conversationCloseTimeInMillis = value; }
        }

        // Check to see if ConversationCloseTimeInMillis property is set
        internal bool IsSetConversationCloseTimeInMillis()
        {
            return this._conversationCloseTimeInMillis.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConversationTurnCount. 
        /// <para>
        /// The number of conversation turns in a chat contact, which represents the back-and-forth
        /// exchanges between customer and other participants.
        /// </para>
        /// </summary>
        public int? ConversationTurnCount
        {
            get { return this._conversationTurnCount; }
            set { this._conversationTurnCount = value; }
        }

        // Check to see if ConversationTurnCount property is set
        internal bool IsSetConversationTurnCount()
        {
            return this._conversationTurnCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MultiParty. 
        /// <para>
        /// A boolean flag indicating whether multiparty chat or supervisor barge were enabled
        /// on this contact.
        /// </para>
        /// </summary>
        public bool? MultiParty
        {
            get { return this._multiParty; }
            set { this._multiParty = value; }
        }

        // Check to see if MultiParty property is set
        internal bool IsSetMultiParty()
        {
            return this._multiParty.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalBotMessageLengthInChars. 
        /// <para>
        /// The total number of characters from bot and automated messages on a chat contact.
        /// </para>
        /// </summary>
        public int? TotalBotMessageLengthInChars
        {
            get { return this._totalBotMessageLengthInChars; }
            set { this._totalBotMessageLengthInChars = value; }
        }

        // Check to see if TotalBotMessageLengthInChars property is set
        internal bool IsSetTotalBotMessageLengthInChars()
        {
            return this._totalBotMessageLengthInChars.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalBotMessages. 
        /// <para>
        /// The total number of bot and automated messages on a chat contact.
        /// </para>
        /// </summary>
        public int? TotalBotMessages
        {
            get { return this._totalBotMessages; }
            set { this._totalBotMessages = value; }
        }

        // Check to see if TotalBotMessages property is set
        internal bool IsSetTotalBotMessages()
        {
            return this._totalBotMessages.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalMessages. 
        /// <para>
        /// The number of chat messages on the contact.
        /// </para>
        /// </summary>
        public int? TotalMessages
        {
            get { return this._totalMessages; }
            set { this._totalMessages = value; }
        }

        // Check to see if TotalMessages property is set
        internal bool IsSetTotalMessages()
        {
            return this._totalMessages.HasValue; 
        }

    }
}