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
    /// Container for the parameters to the UpdateBotLocale operation.
    /// Updates the settings that a bot has for a specific locale.
    /// </summary>
    public partial class UpdateBotLocaleRequest : AmazonLexModelsV2Request
    {
        private string _botId;
        private string _botVersion;
        private string _description;
        private GenerativeAISettings _generativeaiSettings;
        private string _localeId;
        private double? _nluIntentConfidenceThreshold;
        private VoiceSettings _voiceSettings;

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The unique identifier of the bot that contains the locale.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=10)]
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
        /// Gets and sets the property BotVersion. 
        /// <para>
        /// The version of the bot that contains the locale to be updated. The version can only
        /// be the <c>DRAFT</c> version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=5)]
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The new description of the locale.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property GenerativeAISettings. 
        /// <para>
        /// Contains settings for generative AI features powered by Amazon Bedrock for your bot
        /// locale. Use this object to turn generative AI features on and off. Pricing may differ
        /// if you turn a feature on. For more information, see LINK.
        /// </para>
        /// </summary>
        public GenerativeAISettings GenerativeAISettings
        {
            get { return this._generativeaiSettings; }
            set { this._generativeaiSettings = value; }
        }

        // Check to see if GenerativeAISettings property is set
        internal bool IsSetGenerativeAISettings()
        {
            return this._generativeaiSettings != null;
        }

        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The identifier of the language and locale to update. The string must match one of
        /// the supported locales. For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/how-languages.html">Supported
        /// languages</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property NluIntentConfidenceThreshold. 
        /// <para>
        /// The new confidence threshold where Amazon Lex inserts the <c>AMAZON.FallbackIntent</c>
        /// and <c>AMAZON.KendraSearchIntent</c> intents in the list of possible intents for an
        /// utterance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1)]
        public double? NluIntentConfidenceThreshold
        {
            get { return this._nluIntentConfidenceThreshold; }
            set { this._nluIntentConfidenceThreshold = value; }
        }

        // Check to see if NluIntentConfidenceThreshold property is set
        internal bool IsSetNluIntentConfidenceThreshold()
        {
            return this._nluIntentConfidenceThreshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VoiceSettings. 
        /// <para>
        /// The new Amazon Polly voice Amazon Lex should use for voice interaction with the user.
        /// </para>
        /// </summary>
        public VoiceSettings VoiceSettings
        {
            get { return this._voiceSettings; }
            set { this._voiceSettings = value; }
        }

        // Check to see if VoiceSettings property is set
        internal bool IsSetVoiceSettings()
        {
            return this._voiceSettings != null;
        }

    }
}