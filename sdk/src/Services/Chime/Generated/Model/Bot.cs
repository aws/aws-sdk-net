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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Chime.Model
{
    /// <summary>
    /// A resource that allows Enterprise account administrators to configure an interface
    /// to receive events from Amazon Chime.
    /// </summary>
    public partial class Bot
    {
        private string _botEmail;
        private string _botId;
        private BotType _botType;
        private DateTime? _createdTimestamp;
        private bool? _disabled;
        private string _displayName;
        private string _securityToken;
        private DateTime? _updatedTimestamp;
        private string _userId;

        /// <summary>
        /// Gets and sets the property BotEmail. 
        /// <para>
        /// The bot email address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string BotEmail
        {
            get { return this._botEmail; }
            set { this._botEmail = value; }
        }

        // Check to see if BotEmail property is set
        internal bool IsSetBotEmail()
        {
            return this._botEmail != null;
        }

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The bot ID.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property BotType. 
        /// <para>
        /// The bot type.
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
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The bot creation timestamp, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime CreatedTimestamp
        {
            get { return this._createdTimestamp.GetValueOrDefault(); }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Disabled. 
        /// <para>
        /// When true, the bot is stopped from running in your account.
        /// </para>
        /// </summary>
        public bool Disabled
        {
            get { return this._disabled.GetValueOrDefault(); }
            set { this._disabled = value; }
        }

        // Check to see if Disabled property is set
        internal bool IsSetDisabled()
        {
            return this._disabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The bot display name.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityToken. 
        /// <para>
        /// The security token used to authenticate Amazon Chime with the outgoing event endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string SecurityToken
        {
            get { return this._securityToken; }
            set { this._securityToken = value; }
        }

        // Check to see if SecurityToken property is set
        internal bool IsSetSecurityToken()
        {
            return this._securityToken != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedTimestamp. 
        /// <para>
        /// The updated bot timestamp, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime UpdatedTimestamp
        {
            get { return this._updatedTimestamp.GetValueOrDefault(); }
            set { this._updatedTimestamp = value; }
        }

        // Check to see if UpdatedTimestamp property is set
        internal bool IsSetUpdatedTimestamp()
        {
            return this._updatedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The unique ID for the bot user.
        /// </para>
        /// </summary>
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}