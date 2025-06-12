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
    /// This is the response object from the UpdateBotAlias operation.
    /// </summary>
    public partial class UpdateBotAliasResponse : AmazonWebServiceResponse
    {
        private string _botAliasId;
        private Dictionary<string, BotAliasLocaleSettings> _botAliasLocaleSettings = AWSConfigs.InitializeCollections ? new Dictionary<string, BotAliasLocaleSettings>() : null;
        private string _botAliasName;
        private BotAliasStatus _botAliasStatus;
        private string _botId;
        private string _botVersion;
        private ConversationLogSettings _conversationLogSettings;
        private DateTime? _creationDateTime;
        private string _description;
        private DateTime? _lastUpdatedDateTime;
        private SentimentAnalysisSettings _sentimentAnalysisSettings;

        /// <summary>
        /// Gets and sets the property BotAliasId. 
        /// <para>
        /// The identifier of the updated bot alias.
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
        /// The updated Lambda functions to use in each locale for the bot alias.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._botAliasLocaleSettings != null && (this._botAliasLocaleSettings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BotAliasName. 
        /// <para>
        /// The updated name of the bot alias.
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
        /// The current status of the bot alias. When the status is <c>Available</c> the alias
        /// is ready for use.
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
        /// The identifier of the bot with the updated alias.
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
        /// The updated version of the bot that the alias points to.
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
        /// The updated settings for storing conversation logs in Amazon CloudWatch Logs and Amazon
        /// S3 buckets.
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
        /// A timestamp of the date and time that the bot was created.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated description of the bot alias.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2000)]
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
        /// A timestamp of the date and time that the bot was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime
        {
            get { return this._lastUpdatedDateTime; }
            set { this._lastUpdatedDateTime = value; }
        }

        // Check to see if LastUpdatedDateTime property is set
        internal bool IsSetLastUpdatedDateTime()
        {
            return this._lastUpdatedDateTime.HasValue; 
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