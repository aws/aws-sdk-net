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
    /// Container for the parameters to the UpdateBotLocale operation. Updates the settings
    /// that a bot has for a specific locale.
    /// </summary>
    public partial class UpdateBotLocaleRequest : AmazonLexModelsV2Request
    {
        /// <summary>
        /// Gets and sets the property AudioFillerSettings. 
        /// <para>
        /// Updated audio filler settings to apply to the bot locale. When enabled, requires <c>unifiedSpeechSettings</c>
        /// (speech-to-speech) to be configured on the bot locale.
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
        /// The unique identifier of the bot that contains the locale.
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
        /// The version of the bot that contains the locale to be updated. The version can only
        /// be the <c>DRAFT</c> version.
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
        /// The new description of the locale.
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
        /// <para>
        /// Contains settings for generative AI features powered by Amazon Bedrock for your bot
        /// locale. Use this object to turn generative AI features on and off. Pricing may differ
        /// if you turn a feature on. For more information, see LINK.
        /// </para>
        /// </summary>
        public GenerativeAISettings GenerativeAISettings { get; set; }

        /// <summary>
        /// Checks to see if the GenerativeAISettings property is set.
        /// </summary>
        internal bool IsSetGenerativeAISettings() => this.GenerativeAISettings != null;

        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The identifier of the language and locale to update. The string must match one of
        /// the supported locales. For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/how-languages.html">Supported
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
        /// The new confidence threshold where Amazon Lex inserts the <c>AMAZON.FallbackIntent</c>
        /// and <c>AMAZON.KendraSearchIntent</c> intents in the list of possible intents for an
        /// utterance.
        /// </para>
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
        /// The updated speaker diarization settings to apply to the bot locale. If you omit this
        /// field, Amazon Lex keeps the setting currently stored on the bot locale. To turn speaker
        /// diarization off, set <c>enabled</c> to <c>false</c> explicitly.
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
        /// The new sensitivity level for voice activity detection (VAD) in the bot locale. This
        /// setting helps optimize speech recognition accuracy by adjusting how the system responds
        /// to background noise during voice interactions.
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
        /// Updated speech-to-text settings to apply to the bot locale.
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
        /// Updated unified speech settings to apply to the bot locale.
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
        /// The new Amazon Polly voice Amazon Lex should use for voice interaction with the user.
        /// </para>
        /// </summary>
        public VoiceSettings VoiceSettings { get; set; }

        /// <summary>
        /// Checks to see if the VoiceSettings property is set.
        /// </summary>
        internal bool IsSetVoiceSettings() => this.VoiceSettings != null;
    }
}
