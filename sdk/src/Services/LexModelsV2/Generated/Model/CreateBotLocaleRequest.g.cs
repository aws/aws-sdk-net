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
    /// Container for the parameters to the CreateBotLocale operation. Creates a locale in
    /// the bot. The locale contains the intents and slot types that the bot uses in conversations
    /// with users in the specified language and locale. You must add a locale to a bot before
    /// you can add intents and slot types to the bot.
    /// </summary>
    public partial class CreateBotLocaleRequest : AmazonLexModelsV2Request
    {
        /// <summary>
        /// Gets and sets the property AudioFillerSettings. 
        /// <para>
        /// Audio filler settings to configure for the new bot locale. When enabled, Amazon Lex
        /// plays a brief background audio filler during speech-to-speech interactions to mask
        /// processing delays. Requires <c>unifiedSpeechSettings</c> (speech-to-speech) to be
        /// configured on the bot locale.
        /// </para>
        /// </summary>
        public AudioFillerSettings AudioFillerSettings { get; set; }

        /// <summary>
        /// Checks to see if the AudioFillerSettings property is set.
        /// </summary>
        internal bool IsSetAudioFillerSettings() => this.AudioFillerSettings != null;

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The identifier of the bot to create the locale for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 10)]
        public string BotId { get; set; }

        /// <summary>
        /// Checks to see if the BotId property is set.
        /// </summary>
        internal bool IsSetBotId() => this.BotId != null;

        /// <summary>
        /// Gets and sets the property BotVersion. 
        /// <para>
        /// The version of the bot to create the locale for. This can only be the draft version
        /// of the bot.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 5)]
        public string BotVersion { get; set; }

        /// <summary>
        /// Checks to see if the BotVersion property is set.
        /// </summary>
        internal bool IsSetBotVersion() => this.BotVersion != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the bot locale. Use this to help identify the bot locale in lists.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property GenerativeAISettings.
        /// </summary>
        public GenerativeAISettings GenerativeAISettings { get; set; }

        /// <summary>
        /// Checks to see if the GenerativeAISettings property is set.
        /// </summary>
        internal bool IsSetGenerativeAISettings() => this.GenerativeAISettings != null;

        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The identifier of the language and locale that the bot will be used in. The string
        /// must match one of the supported locales. All of the intents, slot types, and slots
        /// used in the bot must have the same locale. For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/how-languages.html">Supported
        /// languages</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LocaleId { get; set; }

        /// <summary>
        /// Checks to see if the LocaleId property is set.
        /// </summary>
        internal bool IsSetLocaleId() => this.LocaleId != null;

        /// <summary>
        /// Gets and sets the property NluIntentConfidenceThreshold. 
        /// <para>
        /// Determines the threshold where Amazon Lex will insert the <c>AMAZON.FallbackIntent</c>,
        /// <c>AMAZON.KendraSearchIntent</c>, or both when returning alternative intents. <c>AMAZON.FallbackIntent</c>
        /// and <c>AMAZON.KendraSearchIntent</c> are only inserted if they are configured for
        /// the bot.
        /// </para>
        ///  
        /// <para>
        /// For example, suppose a bot is configured with the confidence threshold of 0.80 and
        /// the <c>AMAZON.FallbackIntent</c>. Amazon Lex returns three alternative intents with
        /// the following confidence scores: IntentA (0.70), IntentB (0.60), IntentC (0.50). The
        /// response from the <c>RecognizeText</c> operation would be:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// AMAZON.FallbackIntent
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IntentA
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IntentB
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IntentC
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1)]
        public double? NluIntentConfidenceThreshold { get; set; }

        /// <summary>
        /// Checks to see if the NluIntentConfidenceThreshold property is set.
        /// </summary>
        internal bool IsSetNluIntentConfidenceThreshold() => this.NluIntentConfidenceThreshold.HasValue;

        /// <summary>
        /// Gets and sets the property SpeakerDiarizationSettings. 
        /// <para>
        /// The speaker diarization settings to configure for the new bot locale. When enabled,
        /// Amazon Lex restricts speech detection to the primary (loudest) speaker during streaming
        /// audio conversations.
        /// </para>
        /// </summary>
        public SpeakerDiarizationSettings SpeakerDiarizationSettings { get; set; }

        /// <summary>
        /// Checks to see if the SpeakerDiarizationSettings property is set.
        /// </summary>
        internal bool IsSetSpeakerDiarizationSettings() => this.SpeakerDiarizationSettings != null;

        /// <summary>
        /// Gets and sets the property SpeechDetectionSensitivity. 
        /// <para>
        /// The sensitivity level for voice activity detection (VAD) in the bot locale. This setting
        /// helps optimize speech recognition accuracy by adjusting how the system responds to
        /// background noise during voice interactions.
        /// </para>
        /// </summary>
        public SpeechDetectionSensitivity SpeechDetectionSensitivity { get; set; }

        /// <summary>
        /// Checks to see if the SpeechDetectionSensitivity property is set.
        /// </summary>
        internal bool IsSetSpeechDetectionSensitivity() => this.SpeechDetectionSensitivity != null;

        /// <summary>
        /// Gets and sets the property SpeechRecognitionSettings. 
        /// <para>
        /// Speech-to-text settings to configure for the new bot locale.
        /// </para>
        /// </summary>
        public SpeechRecognitionSettings SpeechRecognitionSettings { get; set; }

        /// <summary>
        /// Checks to see if the SpeechRecognitionSettings property is set.
        /// </summary>
        internal bool IsSetSpeechRecognitionSettings() => this.SpeechRecognitionSettings != null;

        /// <summary>
        /// Gets and sets the property UnifiedSpeechSettings. 
        /// <para>
        /// Unified speech settings to configure for the new bot locale.
        /// </para>
        /// </summary>
        public UnifiedSpeechSettings UnifiedSpeechSettings { get; set; }

        /// <summary>
        /// Checks to see if the UnifiedSpeechSettings property is set.
        /// </summary>
        internal bool IsSetUnifiedSpeechSettings() => this.UnifiedSpeechSettings != null;

        /// <summary>
        /// Gets and sets the property VoiceSettings. 
        /// <para>
        /// The Amazon Polly voice ID that Amazon Lex uses for voice interaction with the user.
        /// </para>
        /// </summary>
        public VoiceSettings VoiceSettings { get; set; }

        /// <summary>
        /// Checks to see if the VoiceSettings property is set.
        /// </summary>
        internal bool IsSetVoiceSettings() => this.VoiceSettings != null;
    }
}
