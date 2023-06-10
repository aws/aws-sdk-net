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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateBotAlias operation.
    /// Creates an alias for the specified version of a bot. Use an alias to enable you to
    /// change the version of a bot without updating applications that use the bot.
    /// 
    ///  
    /// <para>
    /// For example, you can create an alias called "PROD" that your applications use to call
    /// the Amazon Lex bot. 
    /// </para>
    /// </summary>
    public partial class CreateBotAliasRequest : AmazonLexModelsV2Request
    {
        private Dictionary<string, BotAliasLocaleSettings> _botAliasLocaleSettings = new Dictionary<string, BotAliasLocaleSettings>();
        private string _botAliasName;
        private string _botId;
        private string _botVersion;
        private ConversationLogSettings _conversationLogSettings;
        private string _description;
        private SentimentAnalysisSettings _sentimentAnalysisSettings;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property BotAliasLocaleSettings. 
        /// <para>
        /// Maps configuration information to a specific locale. You can use this parameter to
        /// specify a specific Lambda function to run different functions in different locales.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public Dictionary<string, BotAliasLocaleSettings> BotAliasLocaleSettings
        {
            get { return this._botAliasLocaleSettings; }
            set { this._botAliasLocaleSettings = value; }
        }

        // Check to see if BotAliasLocaleSettings property is set
        internal bool IsSetBotAliasLocaleSettings()
        {
            return this._botAliasLocaleSettings != null && this._botAliasLocaleSettings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property BotAliasName. 
        /// <para>
        /// The alias to create. The name must be unique for the bot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string BotAliasName
        {
            get { return this._botAliasName; }
            set { this._botAliasName = value; }
        }

        // Check to see if BotAliasName property is set
        internal bool IsSetBotAliasName()
        {
            return this._botAliasName != null;
        }

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The unique identifier of the bot that the alias applies to.
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
        /// The version of the bot that this alias points to. You can use the <a href="https://docs.aws.amazon.com/lexv2/latest/APIReference/API_UpdateBotAlias.html">UpdateBotAlias</a>
        /// operation to change the bot version associated with the alias.
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
        /// Gets and sets the property ConversationLogSettings. 
        /// <para>
        /// Specifies whether Amazon Lex logs text and audio for a conversation with the bot.
        /// When you enable conversation logs, text logs store text input, transcripts of audio
        /// input, and associated metadata in Amazon CloudWatch Logs. Audio logs store audio input
        /// in Amazon S3.
        /// </para>
        /// </summary>
        public ConversationLogSettings ConversationLogSettings
        {
            get { return this._conversationLogSettings; }
            set { this._conversationLogSettings = value; }
        }

        // Check to see if ConversationLogSettings property is set
        internal bool IsSetConversationLogSettings()
        {
            return this._conversationLogSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the alias. Use this description to help identify the alias.
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
        /// Gets and sets the property SentimentAnalysisSettings.
        /// </summary>
        public SentimentAnalysisSettings SentimentAnalysisSettings
        {
            get { return this._sentimentAnalysisSettings; }
            set { this._sentimentAnalysisSettings = value; }
        }

        // Check to see if SentimentAnalysisSettings property is set
        internal bool IsSetSentimentAnalysisSettings()
        {
            return this._sentimentAnalysisSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to add to the bot alias. You can only add tags when you create an alias,
        /// you can't use the <code>UpdateBotAlias</code> operation to update the tags on a bot
        /// alias. To update tags, use the <code>TagResource</code> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}