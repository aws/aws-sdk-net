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
    /// Container for the parameters to the CreateBot operation.
    /// Creates an Amazon Lex conversational bot.
    /// </summary>
    public partial class CreateBotRequest : AmazonLexModelsV2Request
    {
        private List<BotMember> _botMembers = new List<BotMember>();
        private string _botName;
        private Dictionary<string, string> _botTags = new Dictionary<string, string>();
        private BotType _botType;
        private DataPrivacy _dataPrivacy;
        private string _description;
        private int? _idleSessionTTLInSeconds;
        private string _roleArn;
        private Dictionary<string, string> _testBotAliasTags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property BotMembers. 
        /// <para>
        /// The list of bot members in a network to be created.
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
        /// The name of the bot. The bot name must be unique in the account that creates the bot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Gets and sets the property BotTags. 
        /// <para>
        /// A list of tags to add to the bot. You can only add tags when you create a bot. You
        /// can't use the <code>UpdateBot</code> operation to update tags. To update tags, use
        /// the <code>TagResource</code> operation.
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
        /// The type of a bot to create.
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
        /// Gets and sets the property DataPrivacy. 
        /// <para>
        /// Provides information on additional privacy protections Amazon Lex should use with
        /// the bot's data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// A description of the bot. It appears in lists to help you identify a particular bot.
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
        /// The time, in seconds, that Amazon Lex should keep information about a user's conversation
        /// with the bot. 
        /// </para>
        ///  
        /// <para>
        /// A user interaction remains active for the amount of time specified. If no conversation
        /// occurs during this time, the session expires and Amazon Lex deletes any data provided
        /// before the timeout.
        /// </para>
        ///  
        /// <para>
        /// You can specify between 60 (1 minute) and 86,400 (24 hours) seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=60, Max=86400)]
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
        /// The Amazon Resource Name (ARN) of an IAM role that has permission to access the bot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=32, Max=2048)]
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
        /// A list of tags to add to the test alias for a bot. You can only add tags when you
        /// create a bot. You can't use the <code>UpdateAlias</code> operation to update tags.
        /// To update tags on the test alias, use the <code>TagResource</code> operation.
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