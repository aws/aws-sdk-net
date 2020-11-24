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
    /// Container for the parameters to the CreateChannelModerator operation.
    /// Creates a new <code>ChannelModerator</code>. A channel moderator can:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Add and remove other members of the channel.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Add and remove other moderators of the channel.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Add and remove user bans for the channel.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Redact messages in the channel.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// List messages in the channel.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateChannelModeratorRequest : AmazonChimeRequest
    {
        private string _channelArn;
        private string _channelModeratorArn;

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
        /// Gets and sets the property ChannelModeratorArn. 
        /// <para>
        /// The ARN of the moderator.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=1600)]
        public string ChannelModeratorArn
        {
            get { return this._channelModeratorArn; }
            set { this._channelModeratorArn = value; }
        }

        // Check to see if ChannelModeratorArn property is set
        internal bool IsSetChannelModeratorArn()
        {
            return this._channelModeratorArn != null;
        }

    }
}