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
    /// Container for the parameters to the CreateChannelBan operation.
    /// Permanently bans a member from a channel. Moderators can't add banned members to a
    /// channel. To undo a ban, you first have to <code>DeleteChannelBan</code>, and then
    /// <code>CreateChannelMembership</code>. Bans are cleaned up when you delete users or
    /// channels. 
    /// 
    ///  
    /// <para>
    /// If you ban a user who is already part of a channel, that user is automatically kicked
    /// from the channel.
    /// </para>
    /// </summary>
    public partial class CreateChannelBanRequest : AmazonChimeRequest
    {
        private string _channelArn;
        private string _memberArn;

        /// <summary>
        /// Gets and sets the property ChannelArn. 
        /// <para>
        /// The ARN of the ban request.
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
        /// The ARN of the member being banned.
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

    }
}