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
    /// Summary information about a bot returned by the <a href="https://docs.aws.amazon.com/lexv2/latest/APIReference/API_ListBots.html">ListBots</a>
    /// operation.
    /// </summary>
    public partial class BotSummary
    {
        private string _botId;
        private string _botName;
        private BotStatus _botStatus;
        private BotType _botType;
        private string _description;
        private DateTime? _lastUpdatedDateTime;
        private string _latestBotVersion;

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The unique identifier assigned to the bot. Use this ID to get detailed information
        /// about the bot with the <a href="https://docs.aws.amazon.com/lexv2/latest/APIReference/API_DescribeBot.html">DescribeBot</a>
        /// operation.
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
        /// Gets and sets the property BotName. 
        /// <para>
        /// The name of the bot.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string BotName
        {
            get { return this._botName; }
            set { this._botName = value; }
        }

        // Check to see if BotName property is set
        internal bool IsSetBotName()
        {
            return this._botName != null;
        }

        /// <summary>
        /// Gets and sets the property BotStatus. 
        /// <para>
        /// The current status of the bot. When the status is <code>Available</code> the bot is
        /// ready for use.
        /// </para>
        /// </summary>
        public BotStatus BotStatus
        {
            get { return this._botStatus; }
            set { this._botStatus = value; }
        }

        // Check to see if BotStatus property is set
        internal bool IsSetBotStatus()
        {
            return this._botStatus != null;
        }

        /// <summary>
        /// Gets and sets the property BotType. 
        /// <para>
        /// The type of the bot.
        /// </para>
        /// </summary>
        public BotType BotType
        {
            get { return this._botType; }
            set { this._botType = value; }
        }

        // Check to see if BotType property is set
        internal bool IsSetBotType()
        {
            return this._botType != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the bot.
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
        /// The date and time that the bot was last updated.
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
        /// Gets and sets the property LatestBotVersion. 
        /// <para>
        /// The latest numerical version in use for the bot.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public string LatestBotVersion
        {
            get { return this._latestBotVersion; }
            set { this._latestBotVersion = value; }
        }

        // Check to see if LatestBotVersion property is set
        internal bool IsSetLatestBotVersion()
        {
            return this._latestBotVersion != null;
        }

    }
}