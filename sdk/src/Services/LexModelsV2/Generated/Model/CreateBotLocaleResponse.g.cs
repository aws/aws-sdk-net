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
    /// This is the response object from the CreateBotLocale operation.
    /// </summary>
    public partial class CreateBotLocaleResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AudioFillerSettings. 
        /// <para>
        /// The audio filler settings configured for the created bot locale.
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
        /// The specified bot identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string BotId { get; set; }

        /// <summary>
        /// Checks to see if the BotId property is set.
        /// </summary>
        internal bool IsSetBotId() => this.BotId != null;

        /// <summary>
        /// Gets and sets the property BotLocaleStatus. 
        /// <para>
        /// The status of the bot.
        /// </para>
        ///  
        /// <para>
        /// When the status is <c>Creating</c> the bot locale is being configured. When the status
        /// is <c>Building</c> Amazon Lex is building the bot for testing and use.
        /// </para>
        ///  
        /// <para>
        /// If the status of the bot is <c>ReadyExpressTesting</c>, you can test the bot using
        /// the exact utterances specified in the bots' intents. When the bot is ready for full
        /// testing or to run, the status is <c>Built</c>.
        /// </para>
        ///  
        /// <para>
        /// If there was a problem with building the bot, the status is <c>Failed</c>. If the
        /// bot was saved but not built, the status is <c>NotBuilt</c>.
        /// </para>
        /// </summary>
        public BotLocaleStatus BotLocaleStatus { get; set; }

        /// <summary>
        /// Checks to see if the BotLocaleStatus property is set.
        /// </summary>
        internal bool IsSetBotLocaleStatus() => this.BotLocaleStatus != null;

        /// <summary>
        /// Gets and sets the property BotVersion. 
        /// <para>
        /// The specified bot version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 5)]
        public string BotVersion { get; set; }

        /// <summary>
        /// Checks to see if the BotVersion property is set.
        /// </summary>
        internal bool IsSetBotVersion() => this.BotVersion != null;

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// A timestamp specifying the date and time that the bot locale was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationDateTime property is set.
        /// </summary>
        internal bool IsSetCreationDateTime() => this.CreationDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The specified description of the bot locale.
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
        /// The specified locale identifier.
        /// </para>
        /// </summary>
        public string LocaleId { get; set; }

        /// <summary>
        /// Checks to see if the LocaleId property is set.
        /// </summary>
        internal bool IsSetLocaleId() => this.LocaleId != null;

        /// <summary>
        /// Gets and sets the property LocaleName. 
        /// <para>
        /// The specified locale name.
        /// </para>
        /// </summary>
        public string LocaleName { get; set; }

        /// <summary>
        /// Checks to see if the LocaleName property is set.
        /// </summary>
        internal bool IsSetLocaleName() => this.LocaleName != null;

        /// <summary>
        /// Gets and sets the property NluIntentConfidenceThreshold. 
        /// <para>
        /// The specified confidence threshold for inserting the <c>AMAZON.FallbackIntent</c>
        /// and <c>AMAZON.KendraSearchIntent</c> intents.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public double? NluIntentConfidenceThreshold { get; set; }

        /// <summary>
        /// Checks to see if the NluIntentConfidenceThreshold property is set.
        /// </summary>
        internal bool IsSetNluIntentConfidenceThreshold() => this.NluIntentConfidenceThreshold.HasValue;

        /// <summary>
        /// Gets and sets the property SpeakerDiarizationSettings. 
        /// <para>
        /// The speaker diarization settings configured for the created bot locale.
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
        /// The sensitivity level for voice activity detection (VAD) that was specified for the
        /// bot locale.
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
        /// The speech-to-text settings configured for the created bot locale.
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
        /// The unified speech settings configured for the created bot locale.
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
