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
    /// Container for the parameters to the CreateChannelModerator operation. Creates a new
    /// <c>ChannelModerator</c>. A channel moderator can: <ul> <li> <para> Add and remove
    /// other members of the channel. </para> </li> <li> <para> Add and remove other moderators
    /// of the channel. </para> </li> <li> <para> Add and remove user bans for the channel.
    /// </para> </li> <li> <para> Redact messages in the channel. </para> </li> <li> <para>
    /// List messages in the channel. </para> </li> </ul> <note> <para> The <c>x-amz-chime-bearer</c>
    /// request header is mandatory. Use the ARN of the <c>AppInstanceUser</c> or <c>AppInstanceBot</c>of
    /// the user that makes the API call as the value in the header. </para> </note>
    /// </summary>
    public partial class CreateChannelModeratorRequest : AmazonChimeSDKMessagingRequest
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
        /// Gets and sets the property ChannelModeratorArn. 
        /// <para>
        /// The <c>AppInstanceUserArn</c> of the moderator.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 1600)]
        public string ChannelModeratorArn { get; set; }

        /// <summary>
        /// Checks to see if the ChannelModeratorArn property is set.
        /// </summary>
        internal bool IsSetChannelModeratorArn() => this.ChannelModeratorArn != null;

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
    }
}
