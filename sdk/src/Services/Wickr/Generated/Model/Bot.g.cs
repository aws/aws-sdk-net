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

namespace Amazon.Wickr.Model
{
    /// <summary>
    /// Represents a bot account in a Wickr network with all its informational fields.
    /// </summary>
    public partial class Bot
    {
        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The unique identifier of the bot.
        /// </para>
        /// </summary>
        public string BotId { get; set; }

        /// <summary>
        /// Checks to see if the BotId property is set.
        /// </summary>
        internal bool IsSetBotId() => this.BotId != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the bot that is visible to users.
        /// </para>
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The ID of the security group to which the bot belongs.
        /// </para>
        /// </summary>
        public string GroupId { get; set; }

        /// <summary>
        /// Checks to see if the GroupId property is set.
        /// </summary>
        internal bool IsSetGroupId() => this.GroupId != null;

        /// <summary>
        /// Gets and sets the property HasChallenge. 
        /// <para>
        /// Indicates whether the bot has a password set.
        /// </para>
        /// </summary>
        public bool? HasChallenge { get; set; }

        /// <summary>
        /// Checks to see if the HasChallenge property is set.
        /// </summary>
        internal bool IsSetHasChallenge() => this.HasChallenge.HasValue;

        /// <summary>
        /// Gets and sets the property LastLogin. 
        /// <para>
        /// The timestamp of the bot's last login.
        /// </para>
        /// </summary>
        public string LastLogin { get; set; }

        /// <summary>
        /// Checks to see if the LastLogin property is set.
        /// </summary>
        internal bool IsSetLastLogin() => this.LastLogin != null;

        /// <summary>
        /// Gets and sets the property Pubkey. 
        /// <para>
        /// The public key of the bot used for encryption.
        /// </para>
        /// </summary>
        public string Pubkey { get; set; }

        /// <summary>
        /// Checks to see if the Pubkey property is set.
        /// </summary>
        internal bool IsSetPubkey() => this.Pubkey != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the bot (1 for pending, 2 for active).
        /// </para>
        /// </summary>
        public int? Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status.HasValue;

        /// <summary>
        /// Gets and sets the property Suspended. 
        /// <para>
        /// Indicates whether the bot is currently suspended.
        /// </para>
        /// </summary>
        public bool? Suspended { get; set; }

        /// <summary>
        /// Checks to see if the Suspended property is set.
        /// </summary>
        internal bool IsSetSuspended() => this.Suspended.HasValue;

        /// <summary>
        /// Gets and sets the property Uname. 
        /// <para>
        /// The unique username hash identifier for the bot.
        /// </para>
        /// </summary>
        public string Uname { get; set; }

        /// <summary>
        /// Checks to see if the Uname property is set.
        /// </summary>
        internal bool IsSetUname() => this.Uname != null;

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The username of the bot.
        /// </para>
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Checks to see if the Username property is set.
        /// </summary>
        internal bool IsSetUsername() => this.Username != null;
    }
}
