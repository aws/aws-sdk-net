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
    /// This is the response object from the DescribeBotAlias operation.
    /// </summary>
    public partial class DescribeBotAliasResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BotAliasHistoryEvents. 
        /// <para>
        /// A list of events that affect a bot alias. For example, an event is recorded when the
        /// version that the alias points to changes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BotAliasHistoryEvent> BotAliasHistoryEvents { get; set; } = AWSConfigs.InitializeCollections ? new List<BotAliasHistoryEvent>() : null;

        /// <summary>
        /// Checks to see if the BotAliasHistoryEvents property is set.
        /// </summary>
        internal bool IsSetBotAliasHistoryEvents() => this.BotAliasHistoryEvents != null && (this.BotAliasHistoryEvents.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BotAliasId. 
        /// <para>
        /// The identifier of the bot alias.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string BotAliasId { get; set; }

        /// <summary>
        /// Checks to see if the BotAliasId property is set.
        /// </summary>
        internal bool IsSetBotAliasId() => this.BotAliasId != null;

        /// <summary>
        /// Gets and sets the property BotAliasLocaleSettings. 
        /// <para>
        /// The locale settings that are unique to the alias.
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
        /// The name of the bot alias.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string BotAliasName { get; set; }

        /// <summary>
        /// Checks to see if the BotAliasName property is set.
        /// </summary>
        internal bool IsSetBotAliasName() => this.BotAliasName != null;

        /// <summary>
        /// Gets and sets the property BotAliasStatus. 
        /// <para>
        /// The current status of the alias. When the alias is <c>Available</c>, the alias is
        /// ready for use with your bot.
        /// </para>
        /// </summary>
        public BotAliasStatus BotAliasStatus { get; set; }

        /// <summary>
        /// Checks to see if the BotAliasStatus property is set.
        /// </summary>
        internal bool IsSetBotAliasStatus() => this.BotAliasStatus != null;

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The identifier of the bot associated with the bot alias.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string BotId { get; set; }

        /// <summary>
        /// Checks to see if the BotId property is set.
        /// </summary>
        internal bool IsSetBotId() => this.BotId != null;

        /// <summary>
        /// Gets and sets the property BotVersion. 
        /// <para>
        /// The version of the bot associated with the bot alias.
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
        /// Specifics of how Amazon Lex logs text and audio conversations with the bot associated
        /// with the alias.
        /// </para>
        /// </summary>
        public ConversationLogSettings ConversationLogSettings { get; set; }

        /// <summary>
        /// Checks to see if the ConversationLogSettings property is set.
        /// </summary>
        internal bool IsSetConversationLogSettings() => this.ConversationLogSettings != null;

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// A timestamp of the date and time that the alias was created.
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
        /// The description of the bot alias.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// A timestamp of the date and time that the alias was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDateTime() => this.LastUpdatedDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property ParentBotNetworks. 
        /// <para>
        /// A list of the networks to which the bot alias you described belongs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 30)]
        public List<ParentBotNetwork> ParentBotNetworks { get; set; } = AWSConfigs.InitializeCollections ? new List<ParentBotNetwork>() : null;

        /// <summary>
        /// Checks to see if the ParentBotNetworks property is set.
        /// </summary>
        internal bool IsSetParentBotNetworks() => this.ParentBotNetworks != null && (this.ParentBotNetworks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SentimentAnalysisSettings.
        /// </summary>
        public SentimentAnalysisSettings SentimentAnalysisSettings { get; set; }

        /// <summary>
        /// Checks to see if the SentimentAnalysisSettings property is set.
        /// </summary>
        internal bool IsSetSentimentAnalysisSettings() => this.SentimentAnalysisSettings != null;
    }
}
