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
    /// Container for the parameters to the PutChannelMembershipPreferences operation.
    /// Sets the membership preferences of an <code>AppInstanceUser</code> or <code>AppIntanceBot</code>
    /// for the specified channel. The user or bot must be a member of the channel. Only the
    /// user or bot who owns the membership can set preferences. Users or bots in the <code>AppInstanceAdmin</code>
    /// and channel moderator roles can't set preferences for other users or users. Banned
    /// users or bots can't set membership preferences for the channel from which they are
    /// banned.
    /// 
    ///  <note> 
    /// <para>
    /// The x-amz-chime-bearer request header is mandatory. Use the ARN of an <code>AppInstanceUser</code>
    /// or <code>AppInstanceBot</code> that makes the API call as the value in the header.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class PutChannelMembershipPreferencesRequest : AmazonChimeSDKMessagingRequest
    {
        private string _channelArn;
        private string _chimeBearer;
        private string _memberArn;
        private ChannelMembershipPreferences _preferences;

        /// <summary>
        /// Gets and sets the property ChannelArn. 
        /// <para>
        /// The ARN of the channel.
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
        /// Gets and sets the property MemberArn. 
        /// <para>
        /// The ARN of the member setting the preferences.
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
        /// Gets and sets the property Preferences. 
        /// <para>
        /// The channel membership preferences of an <code>AppInstanceUser</code> .
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ChannelMembershipPreferences Preferences
        {
            get { return this._preferences; }
            set { this._preferences = value; }
        }

        // Check to see if Preferences property is set
        internal bool IsSetPreferences()
        {
            return this._preferences != null;
        }

    }
}