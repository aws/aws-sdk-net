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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.KinesisVideoWebRTCStorage.Model
{
    /// <summary>
    /// Container for the parameters to the JoinStorageSession operation.
    /// <note> 
    /// <para>
    /// Before using this API, you must call the <c>GetSignalingChannelEndpoint</c> API to
    /// request the WEBRTC endpoint. You then specify the endpoint and region in your <c>JoinStorageSession</c>
    /// API request.
    /// </para>
    ///  </note> 
    /// <para>
    /// Join the ongoing one way-video and/or multi-way audio WebRTC session as a video producing
    /// device for an input channel. If there’s no existing session for the channel, a new
    /// streaming session needs to be created, and the Amazon Resource Name (ARN) of the signaling
    /// channel must be provided. 
    /// </para>
    ///  
    /// <para>
    /// Currently for the <c>SINGLE_MASTER</c> type, a video producing device is able to ingest
    /// both audio and video media into a stream. Only video producing devices can join the
    /// session and record media.
    /// </para>
    ///  <important> 
    /// <para>
    /// Both audio and video tracks are currently required for WebRTC ingestion.
    /// </para>
    ///  
    /// <para>
    /// Current requirements:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Video track: H.264
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Audio track: Opus
    /// </para>
    ///  </li> </ul> </important> 
    /// <para>
    /// The resulting ingested video in the Kinesis video stream will have the following parameters:
    /// H.264 video and AAC audio.
    /// </para>
    ///  
    /// <para>
    /// Once a master participant has negotiated a connection through WebRTC, the ingested
    /// media session will be stored in the Kinesis video stream. Multiple viewers are then
    /// able to play back real-time media through our Playback APIs.
    /// </para>
    ///  
    /// <para>
    /// You can also use existing Kinesis Video Streams features like <c>HLS</c> or <c>DASH</c>
    /// playback, image generation via <a href="https://docs.aws.amazon.com/kinesisvideostreams/latest/dg/gs-getImages.html">GetImages</a>,
    /// and more with ingested WebRTC media.
    /// </para>
    ///  <note> 
    /// <para>
    /// S3 image delivery and notifications are not currently supported.
    /// </para>
    ///  </note> <note> 
    /// <para>
    /// Assume that only one video producing device client can be associated with a session
    /// for the channel. If more than one client joins the session of a specific channel as
    /// a video producing device, the most recent client request takes precedence. 
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>Additional information</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Idempotent</b> - This API is not idempotent.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Retry behavior</b> - This is counted as a new API call.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Concurrent calls</b> - Concurrent calls are allowed. An offer is sent once per
    /// each call.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class JoinStorageSessionRequest : AmazonKinesisVideoWebRTCStorageRequest
    {
        private string _channelArn;

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

    }
}