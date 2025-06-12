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
    /// An object containing information about a specific utterance.
    /// </summary>
    public partial class UtteranceSpecification
    {
        private string _associatedIntentName;
        private string _associatedSlotName;
        private long? _audioVoiceDurationMillis;
        private string _botAliasId;
        private string _botResponseAudioVoiceId;
        private List<UtteranceBotResponse> _botResponses = AWSConfigs.InitializeCollections ? new List<UtteranceBotResponse>() : null;
        private string _botVersion;
        private string _channel;
        private DateTime? _conversationEndTime;
        private DateTime? _conversationStartTime;
        private string _dialogActionType;
        private string _inputType;
        private IntentState _intentState;
        private string _localeId;
        private AnalyticsModality _mode;
        private string _outputType;
        private string _sessionId;
        private string _slotsFilledInSession;
        private string _utterance;
        private string _utteranceRequestId;
        private DateTime? _utteranceTimestamp;
        private bool? _utteranceUnderstood;

        /// <summary>
        /// Gets and sets the property AssociatedIntentName. 
        /// <para>
        /// The name of the intent that the utterance is associated to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string AssociatedIntentName
        {
            get { return this._associatedIntentName; }
            set { this._associatedIntentName = value; }
        }

        // Check to see if AssociatedIntentName property is set
        internal bool IsSetAssociatedIntentName()
        {
            return this._associatedIntentName != null;
        }

        /// <summary>
        /// Gets and sets the property AssociatedSlotName. 
        /// <para>
        /// The name of the slot that the utterance is associated to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string AssociatedSlotName
        {
            get { return this._associatedSlotName; }
            set { this._associatedSlotName = value; }
        }

        // Check to see if AssociatedSlotName property is set
        internal bool IsSetAssociatedSlotName()
        {
            return this._associatedSlotName != null;
        }

        /// <summary>
        /// Gets and sets the property AudioVoiceDurationMillis. 
        /// <para>
        /// The duration in milliseconds of the audio associated with the utterance.
        /// </para>
        /// </summary>
        public long? AudioVoiceDurationMillis
        {
            get { return this._audioVoiceDurationMillis; }
            set { this._audioVoiceDurationMillis = value; }
        }

        // Check to see if AudioVoiceDurationMillis property is set
        internal bool IsSetAudioVoiceDurationMillis()
        {
            return this._audioVoiceDurationMillis.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BotAliasId. 
        /// <para>
        /// The identifier of the alias of the bot that the utterance was made to.
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
        /// Gets and sets the property BotResponseAudioVoiceId. 
        /// <para>
        /// The identifier for the audio of the bot response.
        /// </para>
        /// </summary>
        public string BotResponseAudioVoiceId
        {
            get { return this._botResponseAudioVoiceId; }
            set { this._botResponseAudioVoiceId = value; }
        }

        // Check to see if BotResponseAudioVoiceId property is set
        internal bool IsSetBotResponseAudioVoiceId()
        {
            return this._botResponseAudioVoiceId != null;
        }

        /// <summary>
        /// Gets and sets the property BotResponses. 
        /// <para>
        /// A list of objects containing information about the bot response to the utterance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UtteranceBotResponse> BotResponses
        {
            get { return this._botResponses; }
            set { this._botResponses = value; }
        }

        // Check to see if BotResponses property is set
        internal bool IsSetBotResponses()
        {
            return this._botResponses != null && (this._botResponses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BotVersion. 
        /// <para>
        /// The version of the bot that the utterance was made to.
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
        /// The channel that is integrated with the bot that the utterance was made to.
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
        /// Gets and sets the property ConversationEndTime. 
        /// <para>
        /// The date and time when the conversation in which the utterance took place ended. A
        /// conversation is defined as a unique combination of a <c>sessionId</c> and an <c>originatingRequestId</c>.
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
        /// The date and time when the conversation in which the utterance took place began. A
        /// conversation is defined as a unique combination of a <c>sessionId</c> and an <c>originatingRequestId</c>.
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
        /// Gets and sets the property DialogActionType. 
        /// <para>
        /// The type of dialog action that the utterance is associated to. See the <c>type</c>
        /// field in <a href="https://docs.aws.amazon.com/lexv2/latest/APIReference/API_runtime_DialogAction.html">DialogAction</a>
        /// for more information.
        /// </para>
        /// </summary>
        public string DialogActionType
        {
            get { return this._dialogActionType; }
            set { this._dialogActionType = value; }
        }

        // Check to see if DialogActionType property is set
        internal bool IsSetDialogActionType()
        {
            return this._dialogActionType != null;
        }

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
        public string InputType
        {
            get { return this._inputType; }
            set { this._inputType = value; }
        }

        // Check to see if InputType property is set
        internal bool IsSetInputType()
        {
            return this._inputType != null;
        }

        /// <summary>
        /// Gets and sets the property IntentState. 
        /// <para>
        /// The state of the intent that the utterance is associated to.
        /// </para>
        /// </summary>
        public IntentState IntentState
        {
            get { return this._intentState; }
            set { this._intentState = value; }
        }

        // Check to see if IntentState property is set
        internal bool IsSetIntentState()
        {
            return this._intentState != null;
        }

        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The locale of the bot that the utterance was made to.
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
        public string OutputType
        {
            get { return this._outputType; }
            set { this._outputType = value; }
        }

        // Check to see if OutputType property is set
        internal bool IsSetOutputType()
        {
            return this._outputType != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The identifier of the session that the utterance was made in.
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

        /// <summary>
        /// Gets and sets the property SlotsFilledInSession. 
        /// <para>
        /// The slots that have been filled in the session by the time of the utterance.
        /// </para>
        /// </summary>
        public string SlotsFilledInSession
        {
            get { return this._slotsFilledInSession; }
            set { this._slotsFilledInSession = value; }
        }

        // Check to see if SlotsFilledInSession property is set
        internal bool IsSetSlotsFilledInSession()
        {
            return this._slotsFilledInSession != null;
        }

        /// <summary>
        /// Gets and sets the property Utterance. 
        /// <para>
        /// The text of the utterance.
        /// </para>
        /// </summary>
        public string Utterance
        {
            get { return this._utterance; }
            set { this._utterance = value; }
        }

        // Check to see if Utterance property is set
        internal bool IsSetUtterance()
        {
            return this._utterance != null;
        }

        /// <summary>
        /// Gets and sets the property UtteranceRequestId. 
        /// <para>
        /// The identifier of the request associated with the utterance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=10)]
        public string UtteranceRequestId
        {
            get { return this._utteranceRequestId; }
            set { this._utteranceRequestId = value; }
        }

        // Check to see if UtteranceRequestId property is set
        internal bool IsSetUtteranceRequestId()
        {
            return this._utteranceRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property UtteranceTimestamp. 
        /// <para>
        /// The date and time when the utterance took place.
        /// </para>
        /// </summary>
        public DateTime? UtteranceTimestamp
        {
            get { return this._utteranceTimestamp; }
            set { this._utteranceTimestamp = value; }
        }

        // Check to see if UtteranceTimestamp property is set
        internal bool IsSetUtteranceTimestamp()
        {
            return this._utteranceTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UtteranceUnderstood. 
        /// <para>
        /// Specifies whether the bot understood the utterance or not.
        /// </para>
        /// </summary>
        public bool? UtteranceUnderstood
        {
            get { return this._utteranceUnderstood; }
            set { this._utteranceUnderstood = value; }
        }

        // Check to see if UtteranceUnderstood property is set
        internal bool IsSetUtteranceUnderstood()
        {
            return this._utteranceUnderstood.HasValue; 
        }

    }
}