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
    /// This is the response object from the DescribeBotVersion operation.
    /// </summary>
    public partial class DescribeBotVersionResponse : AmazonWebServiceResponse
    {
        private string _botId;
        private List<BotMember> _botMembers = new List<BotMember>();
        private string _botName;
        private BotStatus _botStatus;
        private BotType _botType;
        private string _botVersion;
        private DateTime? _creationDateTime;
        private DataPrivacy _dataPrivacy;
        private string _description;
        private List<string> _failureReasons = new List<string>();
        private int? _idleSessionTTLInSeconds;
        private List<ParentBotNetwork> _parentBotNetworks = new List<ParentBotNetwork>();
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The identifier of the bot that contains the version.
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
        /// The members of bot network in the version that was described.
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
        /// The name of the bot that contains the version.
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
        /// The current status of the bot. When the status is <code>Available</code>, the bot
        /// version is ready for use.
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
        /// The type of the bot in the version that was described.
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
        /// Gets and sets the property BotVersion. 
        /// <para>
        /// The version of the bot that was described.
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
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// A timestamp of the date and time that the bot version was created.
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
        /// Data privacy settings for the bot version.
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
        /// Gets and sets the property FailureReasons. 
        /// <para>
        /// If the <code>botStatus</code> is <code>Failed</code>, this contains a list of reasons
        /// that the version couldn't be built.
        /// </para>
        /// </summary>
        public List<string> FailureReasons
        {
            get { return this._failureReasons; }
            set { this._failureReasons = value; }
        }

        // Check to see if FailureReasons property is set
        internal bool IsSetFailureReasons()
        {
            return this._failureReasons != null && this._failureReasons.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IdleSessionTTLInSeconds. 
        /// <para>
        /// The number of seconds that a session with the bot remains active before it is discarded
        /// by Amazon Lex.
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
        /// Gets and sets the property ParentBotNetworks. 
        /// <para>
        /// A list of the networks to which the bot version you described belongs.
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
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role that has permission to access the bot
        /// version.
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

    }
}