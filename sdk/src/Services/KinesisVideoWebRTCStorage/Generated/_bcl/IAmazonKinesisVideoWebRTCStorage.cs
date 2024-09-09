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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.KinesisVideoWebRTCStorage.Model;

#pragma warning disable CS1570
namespace Amazon.KinesisVideoWebRTCStorage
{
    /// <summary>
    /// <para>Interface for accessing KinesisVideoWebRTCStorage</para>
    ///
    /// webrtc 
    /// <para>
    ///  
    /// 
    /// 
    /// </para>
    /// </summary>
    public partial interface IAmazonKinesisVideoWebRTCStorage : IAmazonService, IDisposable
    {


        
        #region  JoinStorageSession


        /// <summary>
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
        /// <param name="request">Container for the necessary parameters to execute the JoinStorageSession service method.</param>
        /// 
        /// <returns>The response from the JoinStorageSession service method, as returned by KinesisVideoWebRTCStorage.</returns>
        /// <exception cref="Amazon.KinesisVideoWebRTCStorage.Model.AccessDeniedException">
        /// You do not have required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoWebRTCStorage.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoWebRTCStorage.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoWebRTCStorage.Model.ResourceNotFoundException">
        /// The specified resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-video-webrtc-storage-2018-05-10/JoinStorageSession">REST API Reference for JoinStorageSession Operation</seealso>
        JoinStorageSessionResponse JoinStorageSession(JoinStorageSessionRequest request);



        /// <summary>
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
        /// <param name="request">Container for the necessary parameters to execute the JoinStorageSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the JoinStorageSession service method, as returned by KinesisVideoWebRTCStorage.</returns>
        /// <exception cref="Amazon.KinesisVideoWebRTCStorage.Model.AccessDeniedException">
        /// You do not have required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoWebRTCStorage.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoWebRTCStorage.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoWebRTCStorage.Model.ResourceNotFoundException">
        /// The specified resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-video-webrtc-storage-2018-05-10/JoinStorageSession">REST API Reference for JoinStorageSession Operation</seealso>
        Task<JoinStorageSessionResponse> JoinStorageSessionAsync(JoinStorageSessionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  JoinStorageSessionAsViewer


        /// <summary>
        /// Join the ongoing one way-video and/or multi-way audio WebRTC session as a viewer
        /// for an input channel. If there’s no existing session for the channel, create a new
        /// streaming session and provide the Amazon Resource Name (ARN) of the signaling channel
        /// (<c>channelArn</c>) and client id (<c>clientId</c>). 
        /// 
        ///  
        /// <para>
        /// Currently for <c>SINGLE_MASTER</c> type, a video producing device is able to ingest
        /// both audio and video media into a stream, while viewers can only ingest audio. Both
        /// a video producing device and viewers can join a session first and wait for other participants.
        /// While participants are having peer to peer conversations through WebRTC, the ingested
        /// media session will be stored into the Kinesis Video Stream. Multiple viewers are able
        /// to playback real-time media. 
        /// </para>
        ///  
        /// <para>
        /// Customers can also use existing Kinesis Video Streams features like <c>HLS</c> or
        /// <c>DASH</c> playback, Image generation, and more with ingested WebRTC media. If there’s
        /// an existing session with the same <c>clientId</c> that's found in the join session
        /// request, the new request takes precedence.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the JoinStorageSessionAsViewer service method.</param>
        /// 
        /// <returns>The response from the JoinStorageSessionAsViewer service method, as returned by KinesisVideoWebRTCStorage.</returns>
        /// <exception cref="Amazon.KinesisVideoWebRTCStorage.Model.AccessDeniedException">
        /// You do not have required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoWebRTCStorage.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoWebRTCStorage.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoWebRTCStorage.Model.ResourceNotFoundException">
        /// The specified resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-video-webrtc-storage-2018-05-10/JoinStorageSessionAsViewer">REST API Reference for JoinStorageSessionAsViewer Operation</seealso>
        JoinStorageSessionAsViewerResponse JoinStorageSessionAsViewer(JoinStorageSessionAsViewerRequest request);



        /// <summary>
        /// Join the ongoing one way-video and/or multi-way audio WebRTC session as a viewer
        /// for an input channel. If there’s no existing session for the channel, create a new
        /// streaming session and provide the Amazon Resource Name (ARN) of the signaling channel
        /// (<c>channelArn</c>) and client id (<c>clientId</c>). 
        /// 
        ///  
        /// <para>
        /// Currently for <c>SINGLE_MASTER</c> type, a video producing device is able to ingest
        /// both audio and video media into a stream, while viewers can only ingest audio. Both
        /// a video producing device and viewers can join a session first and wait for other participants.
        /// While participants are having peer to peer conversations through WebRTC, the ingested
        /// media session will be stored into the Kinesis Video Stream. Multiple viewers are able
        /// to playback real-time media. 
        /// </para>
        ///  
        /// <para>
        /// Customers can also use existing Kinesis Video Streams features like <c>HLS</c> or
        /// <c>DASH</c> playback, Image generation, and more with ingested WebRTC media. If there’s
        /// an existing session with the same <c>clientId</c> that's found in the join session
        /// request, the new request takes precedence.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the JoinStorageSessionAsViewer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the JoinStorageSessionAsViewer service method, as returned by KinesisVideoWebRTCStorage.</returns>
        /// <exception cref="Amazon.KinesisVideoWebRTCStorage.Model.AccessDeniedException">
        /// You do not have required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoWebRTCStorage.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoWebRTCStorage.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoWebRTCStorage.Model.ResourceNotFoundException">
        /// The specified resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-video-webrtc-storage-2018-05-10/JoinStorageSessionAsViewer">REST API Reference for JoinStorageSessionAsViewer Operation</seealso>
        Task<JoinStorageSessionAsViewerResponse> JoinStorageSessionAsViewerAsync(JoinStorageSessionAsViewerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}