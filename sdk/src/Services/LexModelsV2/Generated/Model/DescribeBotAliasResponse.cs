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
    /// This is the response object from the DescribeBotAlias operation.
    /// </summary>
    public partial class DescribeBotAliasResponse : AmazonWebServiceResponse
    {
        private List<BotAliasHistoryEvent> _botAliasHistoryEvents = new List<BotAliasHistoryEvent>();
        private string _botAliasId;
        private Dictionary<string, BotAliasLocaleSettings> _botAliasLocaleSettings = new Dictionary<string, BotAliasLocaleSettings>();
        private string _botAliasName;
        private BotAliasStatus _botAliasStatus;
        private string _botId;
        private string _botVersion;
        private ConversationLogSettings _conversationLogSettings;
        private DateTime? _creationDateTime;
        private string _description;
        private DateTime? _lastUpdatedDateTime;
        private List<ParentBotNetwork> _parentBotNetworks = new List<ParentBotNetwork>();
        private SentimentAnalysisSettings _sentimentAnalysisSettings;

        /// <summary>
        /// Gets and sets the property BotAliasHistoryEvents. 
        /// <para>
        /// A list of events that affect a bot alias. For example, an event is recorded when the
        /// version that the alias points to changes.
        /// </para>
        /// </summary>
        public List<BotAliasHistoryEvent> BotAliasHistoryEvents
        {
            get { return this._botAliasHistoryEvents; }
            set { this._botAliasHistoryEvents = value; }
        }

        // Check to see if BotAliasHistoryEvents property is set
        internal bool IsSetBotAliasHistoryEvents()
        {
            return this._botAliasHistoryEvents != null && this._botAliasHistoryEvents.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property BotAliasId. 
        /// <para>
        /// The identifier of the bot alias.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=10)]
        public string BotAliasId
        {
            get { return this._botAliasId; }
            set { this._botAliasId = value; }
        }

        // Check to see if BotAliasId property is set
        internal bool IsSetBotAliasId()
        {
            return this._botAliasId != null;
        }

        /// <summary>
        /// Gets and sets the property BotAliasLocaleSettings. 
        /// <para>
        /// The locale settings that are unique to the alias.
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
        /// The name of the bot alias.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property BotAliasStatus. 
        /// <para>
        /// The current status of the alias. When the alias is <code>Available</code>, the alias
        /// is ready for use with your bot.
        /// </para>
        /// </summary>
        public BotAliasStatus BotAliasStatus
        {
            get { return this._botAliasStatus; }
            set { this._botAliasStatus = value; }
        }

        // Check to see if BotAliasStatus property is set
        internal bool IsSetBotAliasStatus()
        {
            return this._botAliasStatus != null;
        }

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The identifier of the bot associated with the bot alias.
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
        /// Gets and sets the property BotVersion. 
        /// <para>
        /// The version of the bot associated with the bot alias.
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
        /// Specifics of how Amazon Lex logs text and audio conversations with the bot associated
        /// with the alias.
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
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// A timestamp of the date and time that the alias was created.
        /// </para>
        /// </summary>
        public DateTime CreationDateTime
        {
            get { return this._creationDateTime.GetValueOrDefault(); }
            set { this._creationDateTime = value; }
        }

        // Check to see if CreationDateTime property is set
        internal bool IsSetCreationDateTime()
        {
            return this._creationDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the bot alias.
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
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// A timestamp of the date and time that the alias was last updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedDateTime
        {
            get { return this._lastUpdatedDateTime.GetValueOrDefault(); }
            set { this._lastUpdatedDateTime = value; }
        }

        // Check to see if LastUpdatedDateTime property is set
        internal bool IsSetLastUpdatedDateTime()
        {
            return this._lastUpdatedDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParentBotNetworks. 
        /// <para>
        /// A list of the networks to which the bot alias you described belongs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=30)]
        public List<ParentBotNetwork> ParentBotNetworks
        {
            get { return this._parentBotNetworks; }
            set { this._parentBotNetworks = value; }
        }

        // Check to see if ParentBotNetworks property is set
        internal bool IsSetParentBotNetworks()
        {
            return this._parentBotNetworks != null && this._parentBotNetworks.Count > 0; 
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

    }
}