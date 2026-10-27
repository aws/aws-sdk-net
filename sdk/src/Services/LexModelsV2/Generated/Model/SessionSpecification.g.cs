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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// An object containing information about a specific session.
    /// </summary>
    public partial class SessionSpecification
    {
        /// <summary>
        /// Gets and sets the property BotAliasId. 
        /// <para>
        /// The identifier of the alias of the bot that the session was held with.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string BotAliasId { get; set; }

        /// <summary>
        /// Checks to see if the BotAliasId property is set.
        /// </summary>
        internal bool IsSetBotAliasId() => this.BotAliasId != null;

        /// <summary>
        /// Gets and sets the property BotVersion. 
        /// <para>
        /// The version of the bot that the session was held with.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public string BotVersion { get; set; }

        /// <summary>
        /// Checks to see if the BotVersion property is set.
        /// </summary>
        internal bool IsSetBotVersion() => this.BotVersion != null;

        /// <summary>
        /// Gets and sets the property Channel. 
        /// <para>
        /// The channel that is integrated with the bot that the session was held with.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string Channel { get; set; }

        /// <summary>
        /// Checks to see if the Channel property is set.
        /// </summary>
        internal bool IsSetChannel() => this.Channel != null;

        /// <summary>
        /// Gets and sets the property ConversationDurationSeconds. 
        /// <para>
        /// The duration of the conversation in seconds. A conversation is defined as a unique
        /// combination of a <c>sessionId</c> and an <c>originatingRequestId</c>.
        /// </para>
        /// </summary>
        public long? ConversationDurationSeconds { get; set; }

        /// <summary>
        /// Checks to see if the ConversationDurationSeconds property is set.
        /// </summary>
        internal bool IsSetConversationDurationSeconds() => this.ConversationDurationSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property ConversationEndState. 
        /// <para>
        /// The final state of the conversation. A conversation is defined as a unique combination
        /// of a <c>sessionId</c> and an <c>originatingRequestId</c>.
        /// </para>
        /// </summary>
        public ConversationEndState ConversationEndState { get; set; }

        /// <summary>
        /// Checks to see if the ConversationEndState property is set.
        /// </summary>
        internal bool IsSetConversationEndState() => this.ConversationEndState != null;

        /// <summary>
        /// Gets and sets the property ConversationEndTime. 
        /// <para>
        /// The date and time when the conversation ended. A conversation is defined as a unique
        /// combination of a <c>sessionId</c> and an <c>originatingRequestId</c>.
        /// </para>
        /// </summary>
        public DateTime? ConversationEndTime { get; set; }

        /// <summary>
        /// Checks to see if the ConversationEndTime property is set.
        /// </summary>
        internal bool IsSetConversationEndTime() => this.ConversationEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ConversationStartTime. 
        /// <para>
        /// The date and time when the conversation began. A conversation is defined as a unique
        /// combination of a <c>sessionId</c> and an <c>originatingRequestId</c>.
        /// </para>
        /// </summary>
        public DateTime? ConversationStartTime { get; set; }

        /// <summary>
        /// Checks to see if the ConversationStartTime property is set.
        /// </summary>
        internal bool IsSetConversationStartTime() => this.ConversationStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property InvokedIntentSamples. 
        /// <para>
        /// A list of objects containing the name of an intent that was invoked.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InvokedIntentSample> InvokedIntentSamples { get; set; } = AWSConfigs.InitializeCollections ? new List<InvokedIntentSample>() : null;

        /// <summary>
        /// Checks to see if the InvokedIntentSamples property is set.
        /// </summary>
        internal bool IsSetInvokedIntentSamples() => this.InvokedIntentSamples != null && (this.InvokedIntentSamples.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The locale of the bot that the session was held with.
        /// </para>
        /// </summary>
        public string LocaleId { get; set; }

        /// <summary>
        /// Checks to see if the LocaleId property is set.
        /// </summary>
        internal bool IsSetLocaleId() => this.LocaleId != null;

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
        public AnalyticsModality Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;

        /// <summary>
        /// Gets and sets the property NumberOfTurns. 
        /// <para>
        /// The number of turns that the session took.
        /// </para>
        /// </summary>
        public long? NumberOfTurns { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfTurns property is set.
        /// </summary>
        internal bool IsSetNumberOfTurns() => this.NumberOfTurns.HasValue;

        /// <summary>
        /// Gets and sets the property OriginatingRequestId. 
        /// <para>
        /// The identifier of the first request in a session.
        /// </para>
        /// </summary>
        public string OriginatingRequestId { get; set; }

        /// <summary>
        /// Checks to see if the OriginatingRequestId property is set.
        /// </summary>
        internal bool IsSetOriginatingRequestId() => this.OriginatingRequestId != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The identifier of the session.
        /// </para>
        /// </summary>
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;
    }
}
