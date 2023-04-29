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
    /// Container for the parameters to the GetChannelMessageStatus operation.
    /// Gets message status for a specified <code>messageId</code>. Use this API to determine
    /// the intermediate status of messages going through channel flow processing. The API
    /// provides an alternative to retrieving message status if the event was not received
    /// because a client wasn't connected to a websocket. 
    /// 
    ///  
    /// <para>
    /// Messages can have any one of these statuses.
    /// </para>
    ///  <dl> <dt>SENT</dt> <dd> 
    /// <para>
    /// Message processed successfully
    /// </para>
    ///  </dd> <dt>PENDING</dt> <dd> 
    /// <para>
    /// Ongoing processing
    /// </para>
    ///  </dd> <dt>FAILED</dt> <dd> 
    /// <para>
    /// Processing failed
    /// </para>
    ///  </dd> <dt>DENIED</dt> <dd> 
    /// <para>
    /// Messasge denied by the processor
    /// </para>
    ///  </dd> </dl> <note> <ul> <li> 
    /// <para>
    /// This API does not return statuses for denied messages, because we don't store them
    /// once the processor denies them. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Only the message sender can invoke this API.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the ARN of the
    /// <code>AppInstanceUser</code> or <code>AppInstanceBot</code> that makes the API call
    /// as the value in the header.
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class GetChannelMessageStatusRequest : AmazonChimeSDKMessagingRequest
    {
        private string _channelArn;
        private string _chimeBearer;
        private string _messageId;
        private string _subChannelId;

        /// <summary>
        /// Gets and sets the property ChannelArn. 
        /// <para>
        /// The ARN of the channel
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
        /// The <code>AppInstanceUserArn</code> of the user making the API call.
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
        /// The ID of the message.
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
        /// Only required when getting message status in a SubChannel that the user belongs to.
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