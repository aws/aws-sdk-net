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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// An object containing information about a specific session.
    /// </summary>
    public partial class SessionSpecification
    {
        private string _botAliasId;
        private string _botVersion;
        private string _channel;
        private long? _conversationDurationSeconds;
        private ConversationEndState _conversationEndState;
        private DateTime? _conversationEndTime;
        private DateTime? _conversationStartTime;
        private List<InvokedIntentSample> _invokedIntentSamples = AWSConfigs.InitializeCollections ? new List<InvokedIntentSample>() : null;
        private string _localeId;
        private AnalyticsModality _mode;
        private long? _numberOfTurns;
        private string _originatingRequestId;
        private string _sessionId;

        /// <summary>
        /// Gets and sets the property BotAliasId. 
        /// <para>
        /// The identifier of the alias of the bot that the session was held with.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=10)]
        public string BotAliasId
        {
            get { return this._botAliasId; }
            set { this._botAliasId = value; }
        }

        // Check to see if BotAliasId property is set
        internal bool IsSetBotAliasId()
        {
            return this._botAliasId != null;
        }

        /// <summary>
        /// Gets and sets the property BotVersion. 
        /// <para>
        /// The version of the bot that the session was held with.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public string BotVersion
        {
            get { return this._botVersion; }
            set { this._botVersion = value; }
        }

        // Check to see if BotVersion property is set
        internal bool IsSetBotVersion()
        {
            return this._botVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Channel. 
        /// <para>
        /// The channel that is integrated with the bot that the session was held with.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string Channel
        {
            get { return this._channel; }
            set { this._channel = value; }
        }

        // Check to see if Channel property is set
        internal bool IsSetChannel()
        {
            return this._channel != null;
        }

        /// <summary>
        /// Gets and sets the property ConversationDurationSeconds. 
        /// <para>
        /// The duration of the conversation in seconds. A conversation is defined as a unique
        /// combination of a <c>sessionId</c> and an <c>originatingRequestId</c>.
        /// </para>
        /// </summary>
        public long? ConversationDurationSeconds
        {
            get { return this._conversationDurationSeconds; }
            set { this._conversationDurationSeconds = value; }
        }

        // Check to see if ConversationDurationSeconds property is set
        internal bool IsSetConversationDurationSeconds()
        {
            return this._conversationDurationSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConversationEndState. 
        /// <para>
        /// The final state of the conversation. A conversation is defined as a unique combination
        /// of a <c>sessionId</c> and an <c>originatingRequestId</c>.
        /// </para>
        /// </summary>
        public ConversationEndState ConversationEndState
        {
            get { return this._conversationEndState; }
            set { this._conversationEndState = value; }
        }

        // Check to see if ConversationEndState property is set
        internal bool IsSetConversationEndState()
        {
            return this._conversationEndState != null;
        }

        /// <summary>
        /// Gets and sets the property ConversationEndTime. 
        /// <para>
        /// The date and time when the conversation ended. A conversation is defined as a unique
        /// combination of a <c>sessionId</c> and an <c>originatingRequestId</c>.
        /// </para>
        /// </summary>
        public DateTime? ConversationEndTime
        {
            get { return this._conversationEndTime; }
            set { this._conversationEndTime = value; }
        }

        // Check to see if ConversationEndTime property is set
        internal bool IsSetConversationEndTime()
        {
            return this._conversationEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConversationStartTime. 
        /// <para>
        /// The date and time when the conversation began. A conversation is defined as a unique
        /// combination of a <c>sessionId</c> and an <c>originatingRequestId</c>.
        /// </para>
        /// </summary>
        public DateTime? ConversationStartTime
        {
            get { return this._conversationStartTime; }
            set { this._conversationStartTime = value; }
        }

        // Check to see if ConversationStartTime property is set
        internal bool IsSetConversationStartTime()
        {
            return this._conversationStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InvokedIntentSamples. 
        /// <para>
        /// A list of objects containing the name of an intent that was invoked.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InvokedIntentSample> InvokedIntentSamples
        {
            get { return this._invokedIntentSamples; }
            set { this._invokedIntentSamples = value; }
        }

        // Check to see if InvokedIntentSamples property is set
        internal bool IsSetInvokedIntentSamples()
        {
            return this._invokedIntentSamples != null && (this._invokedIntentSamples.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The locale of the bot that the session was held with.
        /// </para>
        /// </summary>
        public string LocaleId
        {
            get { return this._localeId; }
            set { this._localeId = value; }
        }

        // Check to see if LocaleId property is set
        internal bool IsSetLocaleId()
        {
            return this._localeId != null;
        }

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The mode of the session. The possible values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Speech</c> – The session was spoken.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Text</c> – The session was written.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DTMF</c> – The session used a touch-tone keypad (Dual Tone Multi-Frequency).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MultiMode</c> – The session used multiple modes.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AnalyticsModality Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfTurns. 
        /// <para>
        /// The number of turns that the session took.
        /// </para>
        /// </summary>
        public long? NumberOfTurns
        {
            get { return this._numberOfTurns; }
            set { this._numberOfTurns = value; }
        }

        // Check to see if NumberOfTurns property is set
        internal bool IsSetNumberOfTurns()
        {
            return this._numberOfTurns.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OriginatingRequestId. 
        /// <para>
        /// The identifier of the first request in a session.
        /// </para>
        /// </summary>
        public string OriginatingRequestId
        {
            get { return this._originatingRequestId; }
            set { this._originatingRequestId = value; }
        }

        // Check to see if OriginatingRequestId property is set
        internal bool IsSetOriginatingRequestId()
        {
            return this._originatingRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The identifier of the session.
        /// </para>
        /// </summary>
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

    }
}