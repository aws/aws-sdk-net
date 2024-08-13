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
    /// This is the response object from the StartBotRecommendation operation.
    /// </summary>
    public partial class StartBotRecommendationResponse : AmazonWebServiceResponse
    {
        private string _botId;
        private string _botRecommendationId;
        private BotRecommendationStatus _botRecommendationStatus;
        private string _botVersion;
        private DateTime? _creationDateTime;
        private EncryptionSetting _encryptionSetting;
        private string _localeId;
        private TranscriptSourceSetting _transcriptSourceSetting;

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The unique identifier of the bot containing the bot recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=10)]
        public string BotId
        {
            get { return this._botId; }
            set { this._botId = value; }
        }

        // Check to see if BotId property is set
        internal bool IsSetBotId()
        {
            return this._botId != null;
        }

        /// <summary>
        /// Gets and sets the property BotRecommendationId. 
        /// <para>
        /// The identifier of the bot recommendation that you have created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=10)]
        public string BotRecommendationId
        {
            get { return this._botRecommendationId; }
            set { this._botRecommendationId = value; }
        }

        // Check to see if BotRecommendationId property is set
        internal bool IsSetBotRecommendationId()
        {
            return this._botRecommendationId != null;
        }

        /// <summary>
        /// Gets and sets the property BotRecommendationStatus. 
        /// <para>
        /// The status of the bot recommendation.
        /// </para>
        ///  
        /// <para>
        /// If the status is Failed, then the reasons for the failure are listed in the failureReasons
        /// field. 
        /// </para>
        /// </summary>
        public BotRecommendationStatus BotRecommendationStatus
        {
            get { return this._botRecommendationStatus; }
            set { this._botRecommendationStatus = value; }
        }

        // Check to see if BotRecommendationStatus property is set
        internal bool IsSetBotRecommendationStatus()
        {
            return this._botRecommendationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property BotVersion. 
        /// <para>
        /// The version of the bot containing the bot recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=5)]
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
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// A timestamp of the date and time that the bot recommendation was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime
        {
            get { return this._creationDateTime; }
            set { this._creationDateTime = value; }
        }

        // Check to see if CreationDateTime property is set
        internal bool IsSetCreationDateTime()
        {
            return this._creationDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EncryptionSetting. 
        /// <para>
        /// The object representing the passwords that were used to encrypt the data related to
        /// the bot recommendation results, as well as the KMS key ARN used to encrypt the associated
        /// metadata.
        /// </para>
        /// </summary>
        public EncryptionSetting EncryptionSetting
        {
            get { return this._encryptionSetting; }
            set { this._encryptionSetting = value; }
        }

        // Check to see if EncryptionSetting property is set
        internal bool IsSetEncryptionSetting()
        {
            return this._encryptionSetting != null;
        }

        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The identifier of the language and locale of the bot recommendation to start. The
        /// string must match one of the supported locales. For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/how-languages.html">Supported
        /// languages</a> 
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
        /// Gets and sets the property TranscriptSourceSetting. 
        /// <para>
        /// The object representing the Amazon S3 bucket containing the transcript, as well as
        /// the associated metadata.
        /// </para>
        /// </summary>
        public TranscriptSourceSetting TranscriptSourceSetting
        {
            get { return this._transcriptSourceSetting; }
            set { this._transcriptSourceSetting = value; }
        }

        // Check to see if TranscriptSourceSetting property is set
        internal bool IsSetTranscriptSourceSetting()
        {
            return this._transcriptSourceSetting != null;
        }

    }
}