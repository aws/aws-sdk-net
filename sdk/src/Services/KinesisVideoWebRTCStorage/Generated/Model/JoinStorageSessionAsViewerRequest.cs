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
 * Do not modify this file. This file is generated from the kinesis-video-webrtc-storage-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisVideoWebRTCStorage.Model
{
    /// <summary>
    /// Container for the parameters to the JoinStorageSessionAsViewer operation.
    /// Join the ongoing one way-video and/or multi-way audio WebRTC session as a viewer
    /// for an input channel. If there’s no existing session for the channel, create a new
    /// streaming session and provide the Amazon Resource Name (ARN) of the signaling channel
    /// (<code>channelArn</code>) and client id (<code>clientId</code>). 
    /// 
    ///  
    /// <para>
    /// Currently for <code>SINGLE_MASTER</code> type, a video producing device is able to
    /// ingest both audio and video media into a stream, while viewers can only ingest audio.
    /// Both a video producing device and viewers can join a session first and wait for other
    /// participants. While participants are having peer to peer conversations through webRTC,
    /// the ingested media session will be stored into the Kinesis Video Stream. Multiple
    /// viewers are able to playback real-time media. 
    /// </para>
    ///  
    /// <para>
    /// Customers can also use existing Kinesis Video Streams features like <code>HLS</code>
    /// or <code>DASH</code> playback, Image generation, and more with ingested WebRTC media.
    /// If there’s an existing session with the same <code>clientId</code> that's found in
    /// the join session request, the new request takes precedence.
    /// </para>
    /// </summary>
    public partial class JoinStorageSessionAsViewerRequest : AmazonKinesisVideoWebRTCStorageRequest
    {
        private string _channelArn;
        private string _clientId;

        /// <summary>
        /// Gets and sets the property ChannelArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the signaling channel. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ClientId. 
        /// <para>
        ///  The unique identifier for the sender client. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ClientId
        {
            get { return this._clientId; }
            set { this._clientId = value; }
        }

        // Check to see if ClientId property is set
        internal bool IsSetClientId()
        {
            return this._clientId != null;
        }

    }
}