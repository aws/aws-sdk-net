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
    /// This is the response object from the CreateBot operation.
    /// </summary>
    public partial class CreateBotResponse : AmazonWebServiceResponse
    {
        private string _botId;
        private List<BotMember> _botMembers = new List<BotMember>();
        private string _botName;
        private BotStatus _botStatus;
        private Dictionary<string, string> _botTags = new Dictionary<string, string>();
        private BotType _botType;
        private DateTime? _creationDateTime;
        private DataPrivacy _dataPrivacy;
        private string _description;
        private int? _idleSessionTTLInSeconds;
        private string _roleArn;
        private Dictionary<string, string> _testBotAliasTags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// A unique identifier for a particular bot. You use this to identify the bot when you
        /// call other Amazon Lex API operations.
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
        /// Gets and sets the property BotMembers. 
        /// <para>
        /// The list of bots in a network that was created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<BotMember> BotMembers
        {
            get { return this._botMembers; }
            set { this._botMembers = value; }
        }

        // Check to see if BotMembers property is set
        internal bool IsSetBotMembers()
        {
            return this._botMembers != null && this._botMembers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property BotName. 
        /// <para>
        /// The name specified for the bot.
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
        /// Shows the current status of the bot. The bot is first in the <code>Creating</code>
        /// status. Once the bot is read for use, it changes to the <code>Available</code> status.
        /// After the bot is created, you can use the <code>DRAFT</code> version of the bot.
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
        /// Gets and sets the property BotTags. 
        /// <para>
        /// A list of tags associated with the bot.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> BotTags
        {
            get { return this._botTags; }
            set { this._botTags = value; }
        }

        // Check to see if BotTags property is set
        internal bool IsSetBotTags()
        {
            return this._botTags != null && this._botTags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property BotType. 
        /// <para>
        /// The type of a bot that was created.
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
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// A timestamp indicating the date and time that the bot was created.
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
        /// Gets and sets the property DataPrivacy. 
        /// <para>
        /// The data privacy settings specified for the bot.
        /// </para>
        /// </summary>
        public DataPrivacy DataPrivacy
        {
            get { return this._dataPrivacy; }
            set { this._dataPrivacy = value; }
        }

        // Check to see if DataPrivacy property is set
        internal bool IsSetDataPrivacy()
        {
            return this._dataPrivacy != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description specified for the bot.
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
        /// Gets and sets the property IdleSessionTTLInSeconds. 
        /// <para>
        /// The session idle time specified for the bot.
        /// </para>
        /// </summary>
        [AWSProperty(Min=60, Max=86400)]
        public int IdleSessionTTLInSeconds
        {
            get { return this._idleSessionTTLInSeconds.GetValueOrDefault(); }
            set { this._idleSessionTTLInSeconds = value; }
        }

        // Check to see if IdleSessionTTLInSeconds property is set
        internal bool IsSetIdleSessionTTLInSeconds()
        {
            return this._idleSessionTTLInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The IAM role specified for the bot.
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property TestBotAliasTags. 
        /// <para>
        /// A list of tags associated with the test alias for the bot.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> TestBotAliasTags
        {
            get { return this._testBotAliasTags; }
            set { this._testBotAliasTags = value; }
        }

        // Check to see if TestBotAliasTags property is set
        internal bool IsSetTestBotAliasTags()
        {
            return this._testBotAliasTags != null && this._testBotAliasTags.Count > 0; 
        }

    }
}