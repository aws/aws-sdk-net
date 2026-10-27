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
    /// This is the response object from the DescribeBotLocale operation.
    /// </summary>
    public partial class DescribeBotLocaleResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AudioFillerSettings. 
        /// <para>
        /// The audio filler settings configured for the bot locale.
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
        /// The identifier of the bot associated with the locale.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string BotId { get; set; }

        /// <summary>
        /// Checks to see if the BotId property is set.
        /// </summary>
        internal bool IsSetBotId() => this.BotId != null;

        /// <summary>
        /// Gets and sets the property BotLocaleHistoryEvents. 
        /// <para>
        /// History of changes, such as when a locale is used in an alias, that have taken place
        /// for the locale.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BotLocaleHistoryEvent> BotLocaleHistoryEvents { get; set; } = AWSConfigs.InitializeCollections ? new List<BotLocaleHistoryEvent>() : null;

        /// <summary>
        /// Checks to see if the BotLocaleHistoryEvents property is set.
        /// </summary>
        internal bool IsSetBotLocaleHistoryEvents() => this.BotLocaleHistoryEvents != null && (this.BotLocaleHistoryEvents.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BotLocaleStatus. 
        /// <para>
        /// The status of the bot. If the status is <c>Failed</c>, the reasons for the failure
        /// are listed in the <c>failureReasons</c> field.
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
        /// The version of the bot associated with the locale.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public string BotVersion { get; set; }

        /// <summary>
        /// Checks to see if the BotVersion property is set.
        /// </summary>
        internal bool IsSetBotVersion() => this.BotVersion != null;

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The date and time that the locale was created.
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
        /// The description of the locale.
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
        /// if <c>botLocaleStatus</c> is <c>Failed</c>, Amazon Lex explains why it failed to build
        /// the bot.
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
        /// Contains settings for Amazon Bedrock's generative AI features for your bot locale.
        /// </para>
        /// </summary>
        public GenerativeAISettings GenerativeAISettings { get; set; }

        /// <summary>
        /// Checks to see if the GenerativeAISettings property is set.
        /// </summary>
        internal bool IsSetGenerativeAISettings() => this.GenerativeAISettings != null;

        /// <summary>
        /// Gets and sets the property IntentsCount. 
        /// <para>
        /// The number of intents defined for the locale.
        /// </para>
        /// </summary>
        public int? IntentsCount { get; set; }

        /// <summary>
        /// Checks to see if the IntentsCount property is set.
        /// </summary>
        internal bool IsSetIntentsCount() => this.IntentsCount.HasValue;

        /// <summary>
        /// Gets and sets the property LastBuildSubmittedDateTime. 
        /// <para>
        /// The date and time that the locale was last submitted for building.
        /// </para>
        /// </summary>
        public DateTime? LastBuildSubmittedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastBuildSubmittedDateTime property is set.
        /// </summary>
        internal bool IsSetLastBuildSubmittedDateTime() => this.LastBuildSubmittedDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The date and time that the locale was last updated.
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
        /// The unique identifier of the described locale.
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
        /// The name of the locale.
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
        /// The confidence threshold where Amazon Lex inserts the <c>AMAZON.FallbackIntent</c>
        /// and <c>AMAZON.KendraSearchIntent</c> intents in the list of possible intents for an
        /// utterance.
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
        /// Gets and sets the property SlotTypesCount. 
        /// <para>
        /// The number of slot types defined for the locale.
        /// </para>
        /// </summary>
        public int? SlotTypesCount { get; set; }

        /// <summary>
        /// Checks to see if the SlotTypesCount property is set.
        /// </summary>
        internal bool IsSetSlotTypesCount() => this.SlotTypesCount.HasValue;

        /// <summary>
        /// Gets and sets the property SpeakerDiarizationSettings. 
        /// <para>
        /// The speaker diarization settings configured for the bot locale.
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
        /// The sensitivity level for voice activity detection (VAD) configured for the bot locale.
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
        /// The speech-to-text settings configured for the bot locale.
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
        /// The unified speech settings configured for the bot locale.
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
        /// The Amazon Polly voice Amazon Lex uses for voice interaction with the user.
        /// </para>
        /// </summary>
        public VoiceSettings VoiceSettings { get; set; }

        /// <summary>
        /// Checks to see if the VoiceSettings property is set.
        /// </summary>
        internal bool IsSetVoiceSettings() => this.VoiceSettings != null;
    }
}
