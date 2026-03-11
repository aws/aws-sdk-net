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
 * Do not modify this file. This file is generated from the wickr-2024-02-01.normal.json service model.
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
namespace Amazon.Wickr.Model
{
    /// <summary>
    /// This is the response object from the GetBot operation.
    /// </summary>
    public partial class GetBotResponse : AmazonWebServiceResponse
    {
        private string _botId;
        private string _displayName;
        private string _groupId;
        private bool? _hasChallenge;
        private string _lastLogin;
        private string _pubkey;
        private int? _status;
        private bool? _suspended;
        private string _uname;
        private string _username;

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The unique identifier of the bot.
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
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the bot that is visible to users.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The ID of the security group to which the bot belongs.
        /// </para>
        /// </summary>
        public string GroupId
        {
            get { return this._groupId; }
            set { this._groupId = value; }
        }

        // Check to see if GroupId property is set
        internal bool IsSetGroupId()
        {
            return this._groupId != null;
        }

        /// <summary>
        /// Gets and sets the property HasChallenge. 
        /// <para>
        /// Indicates whether the bot has a password set.
        /// </para>
        /// </summary>
        public bool? HasChallenge
        {
            get { return this._hasChallenge; }
            set { this._hasChallenge = value; }
        }

        // Check to see if HasChallenge property is set
        internal bool IsSetHasChallenge()
        {
            return this._hasChallenge.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastLogin. 
        /// <para>
        /// The timestamp of the bot's last login.
        /// </para>
        /// </summary>
        public string LastLogin
        {
            get { return this._lastLogin; }
            set { this._lastLogin = value; }
        }

        // Check to see if LastLogin property is set
        internal bool IsSetLastLogin()
        {
            return this._lastLogin != null;
        }

        /// <summary>
        /// Gets and sets the property Pubkey. 
        /// <para>
        /// The public key of the bot used for encryption.
        /// </para>
        /// </summary>
        public string Pubkey
        {
            get { return this._pubkey; }
            set { this._pubkey = value; }
        }

        // Check to see if Pubkey property is set
        internal bool IsSetPubkey()
        {
            return this._pubkey != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the bot (1 for pending, 2 for active).
        /// </para>
        /// </summary>
        public int? Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Suspended. 
        /// <para>
        /// Indicates whether the bot is currently suspended.
        /// </para>
        /// </summary>
        public bool? Suspended
        {
            get { return this._suspended; }
            set { this._suspended = value; }
        }

        // Check to see if Suspended property is set
        internal bool IsSetSuspended()
        {
            return this._suspended.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Uname. 
        /// <para>
        /// The unique username hash identifier for the bot.
        /// </para>
        /// </summary>
        public string Uname
        {
            get { return this._uname; }
            set { this._uname = value; }
        }

        // Check to see if Uname property is set
        internal bool IsSetUname()
        {
            return this._uname != null;
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The username of the bot.
        /// </para>
        /// </summary>
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

    }
}