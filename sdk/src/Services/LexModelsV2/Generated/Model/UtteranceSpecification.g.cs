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
    /// An object containing information about a specific utterance.
    /// </summary>
    public partial class UtteranceSpecification
    {
        /// <summary>
        /// Gets and sets the property AssociatedIntentName. 
        /// <para>
        /// The name of the intent that the utterance is associated to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string AssociatedIntentName { get; set; }

        /// <summary>
        /// Checks to see if the AssociatedIntentName property is set.
        /// </summary>
        internal bool IsSetAssociatedIntentName() => this.AssociatedIntentName != null;

        /// <summary>
        /// Gets and sets the property AssociatedSlotName. 
        /// <para>
        /// The name of the slot that the utterance is associated to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string AssociatedSlotName { get; set; }

        /// <summary>
        /// Checks to see if the AssociatedSlotName property is set.
        /// </summary>
        internal bool IsSetAssociatedSlotName() => this.AssociatedSlotName != null;

        /// <summary>
        /// Gets and sets the property AudioVoiceDurationMillis. 
        /// <para>
        /// The duration in milliseconds of the audio associated with the utterance.
        /// </para>
        /// </summary>
        public long? AudioVoiceDurationMillis { get; set; }

        /// <summary>
        /// Checks to see if the AudioVoiceDurationMillis property is set.
        /// </summary>
        internal bool IsSetAudioVoiceDurationMillis() => this.AudioVoiceDurationMillis.HasValue;

        /// <summary>
        /// Gets and sets the property BotAliasId. 
        /// <para>
        /// The identifier of the alias of the bot that the utterance was made to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string BotAliasId { get; set; }

        /// <summary>
        /// Checks to see if the BotAliasId property is set.
        /// </summary>
        internal bool IsSetBotAliasId() => this.BotAliasId != null;

        /// <summary>
        /// Gets and sets the property BotResponseAudioVoiceId. 
        /// <para>
        /// The identifier for the audio of the bot response.
        /// </para>
        /// </summary>
        public string BotResponseAudioVoiceId { get; set; }

        /// <summary>
        /// Checks to see if the BotResponseAudioVoiceId property is set.
        /// </summary>
        internal bool IsSetBotResponseAudioVoiceId() => this.BotResponseAudioVoiceId != null;

        /// <summary>
        /// Gets and sets the property BotResponses. 
        /// <para>
        /// A list of objects containing information about the bot response to the utterance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UtteranceBotResponse> BotResponses { get; set; } = AWSConfigs.InitializeCollections ? new List<UtteranceBotResponse>() : null;

        /// <summary>
        /// Checks to see if the BotResponses property is set.
        /// </summary>
        internal bool IsSetBotResponses() => this.BotResponses != null && (this.BotResponses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BotVersion. 
        /// <para>
        /// The version of the bot that the utterance was made to.
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
        /// The channel that is integrated with the bot that the utterance was made to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string Channel { get; set; }

        /// <summary>
        /// Checks to see if the Channel property is set.
        /// </summary>
        internal bool IsSetChannel() => this.Channel != null;

        /// <summary>
        /// Gets and sets the property ConversationEndTime. 
        /// <para>
        /// The date and time when the conversation in which the utterance took place ended. A
        /// conversation is defined as a unique combination of a <c>sessionId</c> and an <c>originatingRequestId</c>.
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
        /// The date and time when the conversation in which the utterance took place began. A
        /// conversation is defined as a unique combination of a <c>sessionId</c> and an <c>originatingRequestId</c>.
        /// </para>
        /// </summary>
        public DateTime? ConversationStartTime { get; set; }

        /// <summary>
        /// Checks to see if the ConversationStartTime property is set.
        /// </summary>
        internal bool IsSetConversationStartTime() => this.ConversationStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property DialogActionType. 
        /// <para>
        /// The type of dialog action that the utterance is associated to. See the <c>type</c>
        /// field in <a href="https://docs.aws.amazon.com/lexv2/latest/APIReference/API_runtime_DialogAction.html">DialogAction</a>
        /// for more information.
        /// </para>
        /// </summary>
        public string DialogActionType { get; set; }

        /// <summary>
        /// Checks to see if the DialogActionType property is set.
        /// </summary>
        internal bool IsSetDialogActionType() => this.DialogActionType != null;

        /// <summary>
        /// Gets and sets the property InputType. 
        /// <para>
        /// The input type of the utterance. The possible values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PCM format: audio data must be in little-endian byte order.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>audio/l16; rate=16000; channels=1</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>audio/x-l16; sample-rate=16000; channel-count=1</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>audio/lpcm; sample-rate=8000; sample-size-bits=16; channel-count=1; is-big-endian=false</c>
        /// 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Opus format
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>audio/x-cbr-opus-with-preamble;preamble-size=0;bit-rate=256000;frame-size-milliseconds=4</c>
        /// 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Text format
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>text/plain; charset=utf-8</c> 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        public string InputType { get; set; }

        /// <summary>
        /// Checks to see if the InputType property is set.
        /// </summary>
        internal bool IsSetInputType() => this.InputType != null;

        /// <summary>
        /// Gets and sets the property IntentState. 
        /// <para>
        /// The state of the intent that the utterance is associated to.
        /// </para>
        /// </summary>
        public IntentState IntentState { get; set; }

        /// <summary>
        /// Checks to see if the IntentState property is set.
        /// </summary>
        internal bool IsSetIntentState() => this.IntentState != null;

        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The locale of the bot that the utterance was made to.
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
        ///  <c>Speech</c> – The session consisted of spoken dialogue.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Text</c> – The session consisted of written dialogue.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DTMF</c> – The session consisted of touch-tone keypad (Dual Tone Multi-Frequency)
        /// key presses.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MultiMode</c> – The session consisted of multiple modes.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AnalyticsModality Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;

        /// <summary>
        /// Gets and sets the property OutputType. 
        /// <para>
        /// The output type of the utterance. The possible values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>audio/mpeg</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>audio/ogg</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>audio/pcm (16 KHz)</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>audio/</c> (defaults to <c>mpeg</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>text/plain; charset=utf-8</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string OutputType { get; set; }

        /// <summary>
        /// Checks to see if the OutputType property is set.
        /// </summary>
        internal bool IsSetOutputType() => this.OutputType != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The identifier of the session that the utterance was made in.
        /// </para>
        /// </summary>
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property SlotsFilledInSession. 
        /// <para>
        /// The slots that have been filled in the session by the time of the utterance.
        /// </para>
        /// </summary>
        public string SlotsFilledInSession { get; set; }

        /// <summary>
        /// Checks to see if the SlotsFilledInSession property is set.
        /// </summary>
        internal bool IsSetSlotsFilledInSession() => this.SlotsFilledInSession != null;

        /// <summary>
        /// Gets and sets the property Utterance. 
        /// <para>
        /// The text of the utterance.
        /// </para>
        /// </summary>
        public string Utterance { get; set; }

        /// <summary>
        /// Checks to see if the Utterance property is set.
        /// </summary>
        internal bool IsSetUtterance() => this.Utterance != null;

        /// <summary>
        /// Gets and sets the property UtteranceRequestId. 
        /// <para>
        /// The identifier of the request associated with the utterance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string UtteranceRequestId { get; set; }

        /// <summary>
        /// Checks to see if the UtteranceRequestId property is set.
        /// </summary>
        internal bool IsSetUtteranceRequestId() => this.UtteranceRequestId != null;

        /// <summary>
        /// Gets and sets the property UtteranceTimestamp. 
        /// <para>
        /// The date and time when the utterance took place.
        /// </para>
        /// </summary>
        public DateTime? UtteranceTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the UtteranceTimestamp property is set.
        /// </summary>
        internal bool IsSetUtteranceTimestamp() => this.UtteranceTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property UtteranceUnderstood. 
        /// <para>
        /// Specifies whether the bot understood the utterance or not.
        /// </para>
        /// </summary>
        public bool? UtteranceUnderstood { get; set; }

        /// <summary>
        /// Checks to see if the UtteranceUnderstood property is set.
        /// </summary>
        internal bool IsSetUtteranceUnderstood() => this.UtteranceUnderstood.HasValue;
    }
}
