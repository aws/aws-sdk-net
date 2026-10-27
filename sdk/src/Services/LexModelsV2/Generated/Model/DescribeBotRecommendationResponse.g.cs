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
    /// This is the response object from the DescribeBotRecommendation operation.
    /// </summary>
    public partial class DescribeBotRecommendationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The identifier of the bot associated with the bot recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string BotId { get; set; }

        /// <summary>
        /// Checks to see if the BotId property is set.
        /// </summary>
        internal bool IsSetBotId() => this.BotId != null;

        /// <summary>
        /// Gets and sets the property BotRecommendationId. 
        /// <para>
        /// The identifier of the bot recommendation being described.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string BotRecommendationId { get; set; }

        /// <summary>
        /// Checks to see if the BotRecommendationId property is set.
        /// </summary>
        internal bool IsSetBotRecommendationId() => this.BotRecommendationId != null;

        /// <summary>
        /// Gets and sets the property BotRecommendationResults. 
        /// <para>
        /// The object representing the URL of the bot definition, the URL of the associated transcript
        /// and a statistical summary of the bot recommendation results.
        /// </para>
        /// </summary>
        public BotRecommendationResults BotRecommendationResults { get; set; }

        /// <summary>
        /// Checks to see if the BotRecommendationResults property is set.
        /// </summary>
        internal bool IsSetBotRecommendationResults() => this.BotRecommendationResults != null;

        /// <summary>
        /// Gets and sets the property BotRecommendationStatus. 
        /// <para>
        /// The status of the bot recommendation. If the status is Failed, then the reasons for
        /// the failure are listed in the failureReasons field. 
        /// </para>
        /// </summary>
        public BotRecommendationStatus BotRecommendationStatus { get; set; }

        /// <summary>
        /// Checks to see if the BotRecommendationStatus property is set.
        /// </summary>
        internal bool IsSetBotRecommendationStatus() => this.BotRecommendationStatus != null;

        /// <summary>
        /// Gets and sets the property BotVersion. 
        /// <para>
        /// The version of the bot associated with the bot recommendation.
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
        /// The date and time that the bot recommendation was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationDateTime property is set.
        /// </summary>
        internal bool IsSetCreationDateTime() => this.CreationDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property EncryptionSetting. 
        /// <para>
        /// The object representing the passwords that were used to encrypt the data related to
        /// the bot recommendation results, as well as the KMS key ARN used to encrypt the associated
        /// metadata.
        /// </para>
        /// </summary>
        public EncryptionSetting EncryptionSetting { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionSetting property is set.
        /// </summary>
        internal bool IsSetEncryptionSetting() => this.EncryptionSetting != null;

        /// <summary>
        /// Gets and sets the property FailureReasons. 
        /// <para>
        /// If botRecommendationStatus is Failed, Amazon Lex explains why.
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
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The date and time that the bot recommendation was last updated.
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
        /// The identifier of the language and locale of the bot recommendation to describe.
        /// </para>
        /// </summary>
        public string LocaleId { get; set; }

        /// <summary>
        /// Checks to see if the LocaleId property is set.
        /// </summary>
        internal bool IsSetLocaleId() => this.LocaleId != null;

        /// <summary>
        /// Gets and sets the property TranscriptSourceSetting. 
        /// <para>
        /// The object representing the Amazon S3 bucket containing the transcript, as well as
        /// the associated metadata.
        /// </para>
        /// </summary>
        public TranscriptSourceSetting TranscriptSourceSetting { get; set; }

        /// <summary>
        /// Checks to see if the TranscriptSourceSetting property is set.
        /// </summary>
        internal bool IsSetTranscriptSourceSetting() => this.TranscriptSourceSetting != null;
    }
}
