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
    /// Container for the parameters to the DisassociateChannelFlow operation.
    /// Disassociates a channel flow from all its channels. Once disassociated, all messages
    /// to that channel stop going through the channel flow processor.
    /// 
    ///  <note> 
    /// <para>
    /// Only administrators or channel moderators can disassociate a channel flow.
    /// </para>
    ///  
    /// <para>
    /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the ARN of the
    /// <code>AppInstanceUser</code> or <code>AppInstanceBot</code> that makes the API call
    /// as the value in the header.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DisassociateChannelFlowRequest : AmazonChimeSDKMessagingRequest
    {
        private string _channelArn;
        private string _channelFlowArn;
        private string _chimeBearer;

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
        /// Gets and sets the property ChannelFlowArn. 
        /// <para>
        /// The ARN of the channel flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=1600)]
        public string ChannelFlowArn
        {
            get { return this._channelFlowArn; }
            set { this._channelFlowArn = value; }
        }

        // Check to see if ChannelFlowArn property is set
        internal bool IsSetChannelFlowArn()
        {
            return this._channelFlowArn != null;
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

    }
}