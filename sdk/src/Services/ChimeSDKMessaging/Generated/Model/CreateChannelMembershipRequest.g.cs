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
    /// Container for the parameters to the CreateChannelMembership operation. Adds a member
    /// to a channel. The <c>InvitedBy</c> field in <c>ChannelMembership</c> is derived from
    /// the request header. A channel member can: <ul> <li> <para> List messages </para> </li>
    /// <li> <para> Send messages </para> </li> <li> <para> Receive messages </para> </li>
    /// <li> <para> Edit their own messages </para> </li> <li> <para> Leave the channel </para>
    /// </li> </ul> <para> Privacy settings impact this action as follows: </para> <ul> <li>
    /// <para> Public Channels: You do not need to be a member to list messages, but you must
    /// be a member to send messages. </para> </li> <li> <para> Private Channels: You must
    /// be a member to list or send messages. </para> </li> </ul> <note> <para> The <c>x-amz-chime-bearer</c>
    /// request header is mandatory. Use the ARN of the <c>AppInstanceUserArn</c> or <c>AppInstanceBot</c>
    /// that makes the API call as the value in the header. </para> </note>
    /// </summary>
    public partial class CreateChannelMembershipRequest : AmazonChimeSDKMessagingRequest
    {
        /// <summary>
        /// Gets and sets the property ChannelArn. 
        /// <para>
        /// The ARN of the channel to which you're adding users.
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
        /// The <c>AppInstanceUserArn</c> of the member you want to add to the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 1600)]
        public string MemberArn { get; set; }

        /// <summary>
        /// Checks to see if the MemberArn property is set.
        /// </summary>
        internal bool IsSetMemberArn() => this.MemberArn != null;

        /// <summary>
        /// Gets and sets the property SubChannelId. 
        /// <para>
        /// The ID of the SubChannel in the request.
        /// </para>
        ///  <note> 
        /// <para>
        /// Only required when creating membership in a SubChannel for a moderator in an elastic
        /// channel.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string SubChannelId { get; set; }

        /// <summary>
        /// Checks to see if the SubChannelId property is set.
        /// </summary>
        internal bool IsSetSubChannelId() => this.SubChannelId != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The membership type of a user, <c>DEFAULT</c> or <c>HIDDEN</c>. Default members are
        /// always returned as part of <c>ListChannelMemberships</c>. Hidden members are only
        /// returned if the type filter in <c>ListChannelMemberships</c> equals <c>HIDDEN</c>.
        /// Otherwise hidden members are not returned. This is only supported by moderators.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ChannelMembershipType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
