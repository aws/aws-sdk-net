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
    /// Container for the parameters to the CreateChannelMembership operation.
    /// Adds a user to a channel. The <code>InvitedBy</code> response field is derived from
    /// the request header. A channel member can:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// List messages
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Send messages
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Receive messages
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Edit their own messages
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Leave the channel
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Privacy settings impact this action as follows:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Public Channels: You do not need to be a member to list messages, but you must be
    /// a member to send messages.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Private Channels: You must be a member to list or send messages.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateChannelMembershipRequest : AmazonChimeRequest
    {
        private string _channelArn;
        private string _memberArn;
        private ChannelMembershipType _type;

        /// <summary>
        /// Gets and sets the property ChannelArn. 
        /// <para>
        /// The ARN of the channel to which you're adding users.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=1600)]
        public string ChannelArn
        {
            get { return this._channelArn; }
            set { this._channelArn = value; }
        }

        // Check to see if ChannelArn property is set
        internal bool IsSetChannelArn()
        {
            return this._channelArn != null;
        }

        /// <summary>
        /// Gets and sets the property MemberArn. 
        /// <para>
        /// The ARN of the member you want to add to the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=1600)]
        public string MemberArn
        {
            get { return this._memberArn; }
            set { this._memberArn = value; }
        }

        // Check to see if MemberArn property is set
        internal bool IsSetMemberArn()
        {
            return this._memberArn != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The membership type of a user, <code>DEFAULT</code> or <code>HIDDEN</code>. Default
        /// members are always returned as part of <code>ListChannelMemberships</code>. Hidden
        /// members are only returned if the type filter in <code>ListChannelMemberships</code>
        /// equals <code>HIDDEN</code>. Otherwise hidden members are not returned. This is only
        /// supported by moderators.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ChannelMembershipType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}