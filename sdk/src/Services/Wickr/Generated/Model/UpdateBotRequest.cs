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
    /// Container for the parameters to the UpdateBot operation.
    /// Updates the properties of an existing bot in a Wickr network. This operation allows
    /// you to modify the bot's display name, security group, password, or suspension status.
    /// </summary>
    public partial class UpdateBotRequest : AmazonWickrRequest
    {
        private string _botId;
        private string _challenge;
        private string _displayName;
        private string _groupId;
        private string _networkId;
        private bool? _suspend;

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The unique identifier of the bot to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
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
        /// Gets and sets the property Challenge. 
        /// <para>
        /// The new password for the bot account.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Challenge
        {
            get { return this._challenge; }
            set { this._challenge = value; }
        }

        // Check to see if Challenge property is set
        internal bool IsSetChallenge()
        {
            return this._challenge != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The new display name for the bot.
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
        /// The ID of the new security group to assign the bot to.
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
        /// Gets and sets the property NetworkId. 
        /// <para>
        /// The ID of the Wickr network containing the bot to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=8, Max=8)]
        public string NetworkId
        {
            get { return this._networkId; }
            set { this._networkId = value; }
        }

        // Check to see if NetworkId property is set
        internal bool IsSetNetworkId()
        {
            return this._networkId != null;
        }

        /// <summary>
        /// Gets and sets the property Suspend. 
        /// <para>
        /// Set to true to suspend the bot or false to unsuspend it. Omit this field for standard
        /// updates that don't affect suspension status.
        /// </para>
        /// </summary>
        public bool? Suspend
        {
            get { return this._suspend; }
            set { this._suspend = value; }
        }

        // Check to see if Suspend property is set
        internal bool IsSetSuspend()
        {
            return this._suspend.HasValue; 
        }

    }
}