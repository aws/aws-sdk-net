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
    /// Container for the parameters to the DeleteChannelMessage operation.
    /// Deletes a channel message. Only admins can perform this action. Deletion makes messages
    /// inaccessible immediately. A background process deletes any revisions created by <code>UpdateChannelMessage</code>.
    /// 
    ///  <note> 
    /// <para>
    /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the ARN of the
    /// <code>AppInstanceUser</code> or <code>AppInstanceBot</code> that makes the API call
    /// as the value in the header.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeleteChannelMessageRequest : AmazonChimeSDKMessagingRequest
    {
        private string _channelArn;
        private string _chimeBearer;
        private string _messageId;
        private string _subChannelId;

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
        /// Gets and sets the property MessageId. 
        /// <para>
        /// The ID of the message being deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string MessageId
        {
            get { return this._messageId; }
            set { this._messageId = value; }
        }

        // Check to see if MessageId property is set
        internal bool IsSetMessageId()
        {
            return this._messageId != null;
        }

        /// <summary>
        /// Gets and sets the property SubChannelId. 
        /// <para>
        /// The ID of the SubChannel in the request.
        /// </para>
        ///  <note> 
        /// <para>
        /// Only required when deleting messages in a SubChannel that the user belongs to.
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

    }
}