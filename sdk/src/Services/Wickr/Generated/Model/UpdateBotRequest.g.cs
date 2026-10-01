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
    /// Container for the parameters to the UpdateBot operation. Updates the properties of
    /// an existing bot in a Wickr network. This operation allows you to modify the bot's
    /// display name, security group, password, or suspension status.
    /// </summary>
    public partial class UpdateBotRequest : AmazonWickrRequest
    {
        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The unique identifier of the bot to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public string BotId { get; set; }

        /// <summary>
        /// Checks to see if the BotId property is set.
        /// </summary>
        internal bool IsSetBotId() => this.BotId != null;

        /// <summary>
        /// Gets and sets the property Challenge. 
        /// <para>
        /// The new password for the bot account.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Challenge { get; set; }

        /// <summary>
        /// Checks to see if the Challenge property is set.
        /// </summary>
        internal bool IsSetChallenge() => this.Challenge != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The new display name for the bot.
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
        /// The ID of the new security group to assign the bot to.
        /// </para>
        /// </summary>
        public string GroupId { get; set; }

        /// <summary>
        /// Checks to see if the GroupId property is set.
        /// </summary>
        internal bool IsSetGroupId() => this.GroupId != null;

        /// <summary>
        /// Gets and sets the property NetworkId. 
        /// <para>
        /// The ID of the Wickr network containing the bot to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 8, Max = 8)]
        public string NetworkId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkId property is set.
        /// </summary>
        internal bool IsSetNetworkId() => this.NetworkId != null;

        /// <summary>
        /// Gets and sets the property Suspend. 
        /// <para>
        /// Set to true to suspend the bot or false to unsuspend it. Omit this field for standard
        /// updates that don't affect suspension status.
        /// </para>
        /// </summary>
        public bool? Suspend { get; set; }

        /// <summary>
        /// Checks to see if the Suspend property is set.
        /// </summary>
        internal bool IsSetSuspend() => this.Suspend.HasValue;
    }
}
