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

namespace Amazon.ChimeSDKMessaging.Model
{
    /// <summary>
    /// Container for the parameters to the PutChannelMembershipPreferences operation. Sets
    /// the membership preferences of an <c>AppInstanceUser</c> or <c>AppInstanceBot</c> for
    /// the specified channel. The user or bot must be a member of the channel. Only the user
    /// or bot who owns the membership can set preferences. Users or bots in the <c>AppInstanceAdmin</c>
    /// and channel moderator roles can't set preferences for other users. Banned users or
    /// bots can't set membership preferences for the channel from which they are banned.
    /// <note> <para> The x-amz-chime-bearer request header is mandatory. Use the ARN of an
    /// <c>AppInstanceUser</c> or <c>AppInstanceBot</c> that makes the API call as the value
    /// in the header. </para> </note>
    /// </summary>
    public partial class PutChannelMembershipPreferencesRequest : AmazonChimeSDKMessagingRequest
    {
        /// <summary>
        /// Gets and sets the property ChannelArn. 
        /// <para>
        /// The ARN of the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 1600)]
        public string ChannelArn { get; set; }

        /// <summary>
        /// Checks to see if the ChannelArn property is set.
        /// </summary>
        internal bool IsSetChannelArn() => this.ChannelArn != null;

        /// <summary>
        /// Gets and sets the property ChimeBearer. 
        /// <para>
        /// The ARN of the <c>AppInstanceUser</c> or <c>AppInstanceBot</c> that makes the API
        /// call.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 1600)]
        public string ChimeBearer { get; set; }

        /// <summary>
        /// Checks to see if the ChimeBearer property is set.
        /// </summary>
        internal bool IsSetChimeBearer() => this.ChimeBearer != null;

        /// <summary>
        /// Gets and sets the property MemberArn. 
        /// <para>
        /// The ARN of the member setting the preferences.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 1600)]
        public string MemberArn { get; set; }

        /// <summary>
        /// Checks to see if the MemberArn property is set.
        /// </summary>
        internal bool IsSetMemberArn() => this.MemberArn != null;

        /// <summary>
        /// Gets and sets the property Preferences. 
        /// <para>
        /// The channel membership preferences of an <c>AppInstanceUser</c> .
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ChannelMembershipPreferences Preferences { get; set; }

        /// <summary>
        /// Checks to see if the Preferences property is set.
        /// </summary>
        internal bool IsSetPreferences() => this.Preferences != null;
    }
}
