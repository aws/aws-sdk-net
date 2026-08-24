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

namespace Amazon.KinesisVideoWebRTCStorage.Model
{
    /// <summary>
    /// Container for the parameters to the JoinStorageSessionAsViewer operation. Join the
    /// ongoing one way-video and/or multi-way audio WebRTC session as a viewer for an input
    /// channel. If there’s no existing session for the channel, create a new streaming session
    /// and provide the Amazon Resource Name (ARN) of the signaling channel (<c>channelArn</c>)
    /// and client id (<c>clientId</c>). <para> Currently for <c>SINGLE_MASTER</c> type, a
    /// video producing device is able to ingest both audio and video media into a stream,
    /// while viewers can only ingest audio. Both a video producing device and viewers can
    /// join a session first and wait for other participants. While participants are having
    /// peer to peer conversations through WebRTC, the ingested media session will be stored
    /// into the Kinesis Video Stream. Multiple viewers are able to playback real-time media.
    /// </para> <para> Customers can also use existing Kinesis Video Streams features like
    /// <c>HLS</c> or <c>DASH</c> playback, Image generation, and more with ingested WebRTC
    /// media. If there’s an existing session with the same <c>clientId</c> that's found in
    /// the join session request, the new request takes precedence. </para>
    /// </summary>
    public partial class JoinStorageSessionAsViewerRequest : AmazonKinesisVideoWebRTCStorageRequest
    {
        /// <summary>
        /// Gets and sets the property ChannelArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the signaling channel. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ChannelArn { get; set; }

        /// <summary>
        /// Checks to see if the ChannelArn property is set.
        /// </summary>
        internal bool IsSetChannelArn() => this.ChannelArn != null;

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        ///  The unique identifier for the sender client. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;
    }
}
