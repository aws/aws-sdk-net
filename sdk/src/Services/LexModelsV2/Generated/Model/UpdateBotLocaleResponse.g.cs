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
    /// This is the response object from the UpdateBotLocale operation.
    /// </summary>
    public partial class UpdateBotLocaleResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AudioFillerSettings. 
        /// <para>
        /// The updated audio filler settings for the bot locale.
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
        /// The identifier of the bot that contains the updated locale.
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
        /// The current status of the locale. When the bot status is <c>Built</c> the locale is
        /// ready for use.
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
        /// The version of the bot that contains the updated locale.
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
        /// A timestamp of the date and time that the locale was created.
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
        /// The updated description of the locale.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FailureReasons. 
        /// <para>
        /// If the <c>botLocaleStatus</c> is <c>Failed</c>, the <c>failureReasons</c> field lists
        /// the errors that occurred while building the bot.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FailureReasons { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FailureReasons property is set.
        /// </summary>
        internal bool IsSetFailureReasons() => this.FailureReasons != null && (this.FailureReasons.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GenerativeAISettings. 
        /// <para>
        /// Contains settings for generative AI features powered by Amazon Bedrock for your bot
        /// locale.
        /// </para>
        /// </summary>
        public GenerativeAISettings GenerativeAISettings { get; set; }

        /// <summary>
        /// Checks to see if the GenerativeAISettings property is set.
        /// </summary>
        internal bool IsSetGenerativeAISettings() => this.GenerativeAISettings != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// A timestamp of the date and time that the locale was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDateTime() => this.LastUpdatedDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The language and locale of the updated bot locale.
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
        /// The updated locale name for the locale.
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
        /// The updated confidence threshold for inserting the <c>AMAZON.FallbackIntent</c> and
        /// <c>AMAZON.KendraSearchIntent</c> intents in the list of possible intents for an utterance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public double? NluIntentConfidenceThreshold { get; set; }

        /// <summary>
        /// Checks to see if the NluIntentConfidenceThreshold property is set.
        /// </summary>
        internal bool IsSetNluIntentConfidenceThreshold() => this.NluIntentConfidenceThreshold.HasValue;

        /// <summary>
        /// Gets and sets the property RecommendedActions. 
        /// <para>
        /// Recommended actions to take to resolve an error in the <c>failureReasons</c> field.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RecommendedActions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RecommendedActions property is set.
        /// </summary>
        internal bool IsSetRecommendedActions() => this.RecommendedActions != null && (this.RecommendedActions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SpeakerDiarizationSettings. 
        /// <para>
        /// The updated speaker diarization settings for the bot locale.
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
        /// The updated sensitivity level for voice activity detection (VAD) in the bot locale.
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
        /// The updated speech-to-text settings for the bot locale.
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
        /// The updated unified speech settings for the bot locale.
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
        /// The updated Amazon Polly voice to use for voice interaction with the user.
        /// </para>
        /// </summary>
        public VoiceSettings VoiceSettings { get; set; }

        /// <summary>
        /// Checks to see if the VoiceSettings property is set.
        /// </summary>
        internal bool IsSetVoiceSettings() => this.VoiceSettings != null;
    }
}
