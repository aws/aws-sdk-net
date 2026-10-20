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
    /// Container for the parameters to the CreateBotAlias operation. Creates an alias for
    /// the specified version of a bot. Use an alias to enable you to change the version of
    /// a bot without updating applications that use the bot. <para> For example, you can
    /// create an alias called "PROD" that your applications use to call the Amazon Lex bot.
    /// </para>
    /// </summary>
    public partial class CreateBotAliasRequest : AmazonLexModelsV2Request
    {
        /// <summary>
        /// Gets and sets the property BotAliasLocaleSettings. 
        /// <para>
        /// Maps configuration information to a specific locale. You can use this parameter to
        /// specify a specific Lambda function to run different functions in different locales.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public Dictionary<string, BotAliasLocaleSettings> BotAliasLocaleSettings { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, BotAliasLocaleSettings>() : null;

        /// <summary>
        /// Checks to see if the BotAliasLocaleSettings property is set.
        /// </summary>
        internal bool IsSetBotAliasLocaleSettings() => this.BotAliasLocaleSettings != null && (this.BotAliasLocaleSettings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BotAliasName. 
        /// <para>
        /// The alias to create. The name must be unique for the bot.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string BotAliasName { get; set; }

        /// <summary>
        /// Checks to see if the BotAliasName property is set.
        /// </summary>
        internal bool IsSetBotAliasName() => this.BotAliasName != null;

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The unique identifier of the bot that the alias applies to.
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
        /// The version of the bot that this alias points to. You can use the <a href="https://docs.aws.amazon.com/lexv2/latest/APIReference/API_UpdateBotAlias.html">UpdateBotAlias</a>
        /// operation to change the bot version associated with the alias.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public string BotVersion { get; set; }

        /// <summary>
        /// Checks to see if the BotVersion property is set.
        /// </summary>
        internal bool IsSetBotVersion() => this.BotVersion != null;

        /// <summary>
        /// Gets and sets the property ConversationLogSettings. 
        /// <para>
        /// Specifies whether Amazon Lex logs text and audio for a conversation with the bot.
        /// When you enable conversation logs, text logs store text input, transcripts of audio
        /// input, and associated metadata in Amazon CloudWatch Logs. Audio logs store audio input
        /// in Amazon S3.
        /// </para>
        /// </summary>
        public ConversationLogSettings ConversationLogSettings { get; set; }

        /// <summary>
        /// Checks to see if the ConversationLogSettings property is set.
        /// </summary>
        internal bool IsSetConversationLogSettings() => this.ConversationLogSettings != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the alias. Use this description to help identify the alias.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property SentimentAnalysisSettings.
        /// </summary>
        public SentimentAnalysisSettings SentimentAnalysisSettings { get; set; }

        /// <summary>
        /// Checks to see if the SentimentAnalysisSettings property is set.
        /// </summary>
        internal bool IsSetSentimentAnalysisSettings() => this.SentimentAnalysisSettings != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to add to the bot alias. You can only add tags when you create an alias,
        /// you can't use the <c>UpdateBotAlias</c> operation to update the tags on a bot alias.
        /// To update tags, use the <c>TagResource</c> operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
