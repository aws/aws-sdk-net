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

namespace Amazon.KinesisVideoWebRTCStorage
{
    /// <summary>
    /// Interface for accessing KinesisVideoWebRTCStorage
    ///
    /// 
    /// </summary>
    public partial interface IAmazonKinesisVideoWebRTCStorage : IAmazonService, IDisposable
    {
                
        #region  JoinStorageSession



        /// <summary>
        /// Join the ongoing one way-video and/or multi-way audio WebRTC session as a video producing
        /// device for an input channel. If there’s no existing session for the channel, a new
        /// streaming session needs to be created, and the Amazon Resource Name (ARN) of the signaling
        /// channel must be provided. 
        /// 
        ///  
        /// <para>
        /// Currently for the <code>SINGLE_MASTER</code> type, a video producing device is able
        /// to ingest both audio and video media into a stream, while viewers can only ingest
        /// audio. Both a video producing device and viewers can join the session first, and wait
        /// for other participants.
        /// </para>
        ///  
        /// <para>
        /// While participants are having peer to peer conversations through webRTC, the ingested
        /// media session will be stored into the Kinesis Video Stream. Multiple viewers are able
        /// to playback real-time media.
        /// </para>
        ///  
        /// <para>
        /// Customers can also use existing Kinesis Video Streams features like <code>HLS</code>
        /// or <code>DASH</code> playback, Image generation, and more with ingested WebRTC media.
        /// </para>
        ///  <note> 
        /// <para>
        /// Assume that only one video producing device client can be associated with a session
        /// for the channel. If more than one client joins the session of a specific channel as
        /// a video producing device, the most recent client request takes precedence. 
        /// </para>
        ///  </note>
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
        Task<JoinStorageSessionResponse> JoinStorageSessionAsync(JoinStorageSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}