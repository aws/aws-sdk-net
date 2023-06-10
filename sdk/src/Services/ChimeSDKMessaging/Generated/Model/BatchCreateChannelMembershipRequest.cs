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
 * Do not modify this file. This file is generated from the chime-sdk-messaging-2021-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKMessaging.Model
{
    /// <summary>
    /// Container for the parameters to the BatchCreateChannelMembership operation.
    /// Adds a specified number of users and bots to a channel.
    /// </summary>
    public partial class BatchCreateChannelMembershipRequest : AmazonChimeSDKMessagingRequest
    {
        private string _channelArn;
        private string _chimeBearer;
        private List<string> _memberArns = new List<string>();
        private string _subChannelId;
        private ChannelMembershipType _type;

        /// <summary>
        /// Gets and sets the property ChannelArn. 
        /// <para>
        /// The ARN of the channel to which you're adding users or bots.
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
        /// Gets and sets the property ChimeBearer. 
        /// <para>
        /// The ARN of the <code>AppInstanceUser</code> or <code>AppInstanceBot</code> that makes
        /// the API call.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=1600)]
        public string ChimeBearer
        {
            get { return this._chimeBearer; }
            set { this._chimeBearer = value; }
        }

        // Check to see if ChimeBearer property is set
        internal bool IsSetChimeBearer()
        {
            return this._chimeBearer != null;
        }

        /// <summary>
        /// Gets and sets the property MemberArns. 
        /// <para>
        /// The ARNs of the members you want to add to the channel. Only <code>AppInstanceUsers</code>
        /// and <code>AppInstanceBots</code> can be added as a channel member.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<string> MemberArns
        {
            get { return this._memberArns; }
            set { this._memberArns = value; }
        }

        // Check to see if MemberArns property is set
        internal bool IsSetMemberArns()
        {
            return this._memberArns != null && this._memberArns.Count > 0; 
        }

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
        [AWSProperty(Min=1, Max=128)]
        public string SubChannelId
        {
            get { return this._subChannelId; }
            set { this._subChannelId = value; }
        }

        // Check to see if SubChannelId property is set
        internal bool IsSetSubChannelId()
        {
            return this._subChannelId != null;
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