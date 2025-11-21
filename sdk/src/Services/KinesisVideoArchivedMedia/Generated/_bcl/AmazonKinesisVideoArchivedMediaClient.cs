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
 * Do not modify this file. This file is generated from the kinesis-video-archived-media-2017-09-30.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.KinesisVideoArchivedMedia.Model;
using Amazon.KinesisVideoArchivedMedia.Model.Internal.MarshallTransformations;
using Amazon.KinesisVideoArchivedMedia.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.KinesisVideoArchivedMedia
{
    /// <summary>
    /// <para>Implementation for accessing KinesisVideoArchivedMedia</para>
    ///
    /// 
    /// </summary>
    public partial class AmazonKinesisVideoArchivedMediaClient : AmazonServiceClient, IAmazonKinesisVideoArchivedMedia
    {
        private static IServiceMetadata serviceMetadata = new AmazonKinesisVideoArchivedMediaMetadata();
        private IKinesisVideoArchivedMediaPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IKinesisVideoArchivedMediaPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new KinesisVideoArchivedMediaPaginatorFactory(this);
                }
                return this._paginators;
            }
        }

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonKinesisVideoArchivedMediaEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonKinesisVideoArchivedMediaAuthSchemeHandler());
        }

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  GetClip


        /// <summary>
        /// Downloads an MP4 file (clip) containing the archived, on-demand media from the specified
        /// video stream over the specified time range. 
        /// 
        ///  
        /// <para>
        /// Both the StreamName and the StreamARN parameters are optional, but you must specify
        /// either the StreamName or the StreamARN when invoking this API operation. 
        /// </para>
        ///  
        /// <para>
        /// As a prerequisite to using GetCLip API, you must obtain an endpoint using <c>GetDataEndpoint</c>,
        /// specifying GET_CLIP for<code/> the <c>APIName</c> parameter. 
        /// </para>
        ///  
        /// <para>
        /// An Amazon Kinesis video stream has the following requirements for providing data through
        /// MP4:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The media must contain h.264 or h.265 encoded video and, optionally, AAC or G.711
        /// encoded audio. Specifically, the codec ID of track 1 should be <c>V_MPEG/ISO/AVC</c>
        /// (for h.264) or V_MPEGH/ISO/HEVC (for H.265). Optionally, the codec ID of track 2 should
        /// be <c>A_AAC</c> (for AAC) or A_MS/ACM (for G.711).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Data retention must be greater than 0.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The video track of each fragment must contain codec private data in the Advanced Video
        /// Coding (AVC) for H.264 format and HEVC for H.265 format. For more information, see
        /// <a href="https://www.iso.org/standard/55980.html">MPEG-4 specification ISO/IEC 14496-15</a>.
        /// For information about adapting stream data to a given format, see <a href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/producer-reference-nal.html">NAL
        /// Adaptation Flags</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The audio track (if present) of each fragment must contain codec private data in the
        /// AAC format (<a href="https://www.iso.org/standard/43345.html">AAC specification ISO/IEC
        /// 13818-7</a>) or the <a href="http://www-mmsp.ece.mcgill.ca/Documents/AudioFormats/WAVE/WAVE.html">MS
        /// Wave format</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can monitor the amount of outgoing data by monitoring the <c>GetClip.OutgoingBytes</c>
        /// Amazon CloudWatch metric. For information about using CloudWatch to monitor Kinesis
        /// Video Streams, see <a href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/monitoring.html">Monitoring
        /// Kinesis Video Streams</a>. For pricing information, see <a href="https://aws.amazon.com/kinesis/video-streams/pricing/">Amazon
        /// Kinesis Video Streams Pricing</a> and <a href="https://aws.amazon.com/pricing/"> Amazon
        /// Web Services Pricing</a>. Charges for outgoing Amazon Web Services data apply.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClip service method.</param>
        /// 
        /// <returns>The response from the GetClip service method, as returned by KinesisVideoArchivedMedia.</returns>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded a limit.
        /// Try making the call later. For information about limits, see <a href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/limits.html">Kinesis
        /// Video Streams Limits</a>.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.InvalidCodecPrivateDataException">
        /// The codec private data in at least one of the tracks of the video stream is not valid
        /// for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.InvalidMediaFrameException">
        /// One or more frames in the requested clip could not be parsed based on the specified
        /// codec.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.MissingCodecPrivateDataException">
        /// No codec private data was found in at least one of tracks of the video stream.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.NoDataRetentionException">
        /// <c>GetImages</c> was requested for a stream that does not retain data (that is, has
        /// a <c>DataRetentionInHours</c> of 0).
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.NotAuthorizedException">
        /// Status Code: 403, The caller is not authorized to perform an operation on the given
        /// stream, or the token has expired.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.ResourceNotFoundException">
        /// <c>GetImages</c> will throw this error when Kinesis Video Streams can't find the
        /// stream that you specified.
        /// 
        ///  
        /// <para>
        ///  <c>GetHLSStreamingSessionURL</c> and <c>GetDASHStreamingSessionURL</c> throw this
        /// error if a session with a <c>PlaybackMode</c> of <c>ON_DEMAND</c> or <c>LIVE_REPLAY</c>is
        /// requested for a stream that has no fragments within the requested time range, or if
        /// a session with a <c>PlaybackMode</c> of <c>LIVE</c> is requested for a stream that
        /// has no fragments within the last 30 seconds.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.UnsupportedStreamMediaTypeException">
        /// The type of the media (for example, h.264 or h.265 video or ACC or G.711 audio) could
        /// not be determined from the codec IDs of the tracks in the first fragment for a playback
        /// session. The codec ID for track 1 should be <c>V_MPEG/ISO/AVC</c> and, optionally,
        /// the codec ID for track 2 should be <c>A_AAC</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-video-archived-media-2017-09-30/GetClip">REST API Reference for GetClip Operation</seealso>
        public virtual GetClipResponse GetClip(GetClipRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetClipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClipResponseUnmarshaller.Instance;

            return Invoke<GetClipResponse>(request, options);
        }


        /// <summary>
        /// Downloads an MP4 file (clip) containing the archived, on-demand media from the specified
        /// video stream over the specified time range. 
        /// 
        ///  
        /// <para>
        /// Both the StreamName and the StreamARN parameters are optional, but you must specify
        /// either the StreamName or the StreamARN when invoking this API operation. 
        /// </para>
        ///  
        /// <para>
        /// As a prerequisite to using GetCLip API, you must obtain an endpoint using <c>GetDataEndpoint</c>,
        /// specifying GET_CLIP for<code/> the <c>APIName</c> parameter. 
        /// </para>
        ///  
        /// <para>
        /// An Amazon Kinesis video stream has the following requirements for providing data through
        /// MP4:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The media must contain h.264 or h.265 encoded video and, optionally, AAC or G.711
        /// encoded audio. Specifically, the codec ID of track 1 should be <c>V_MPEG/ISO/AVC</c>
        /// (for h.264) or V_MPEGH/ISO/HEVC (for H.265). Optionally, the codec ID of track 2 should
        /// be <c>A_AAC</c> (for AAC) or A_MS/ACM (for G.711).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Data retention must be greater than 0.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The video track of each fragment must contain codec private data in the Advanced Video
        /// Coding (AVC) for H.264 format and HEVC for H.265 format. For more information, see
        /// <a href="https://www.iso.org/standard/55980.html">MPEG-4 specification ISO/IEC 14496-15</a>.
        /// For information about adapting stream data to a given format, see <a href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/producer-reference-nal.html">NAL
        /// Adaptation Flags</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The audio track (if present) of each fragment must contain codec private data in the
        /// AAC format (<a href="https://www.iso.org/standard/43345.html">AAC specification ISO/IEC
        /// 13818-7</a>) or the <a href="http://www-mmsp.ece.mcgill.ca/Documents/AudioFormats/WAVE/WAVE.html">MS
        /// Wave format</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can monitor the amount of outgoing data by monitoring the <c>GetClip.OutgoingBytes</c>
        /// Amazon CloudWatch metric. For information about using CloudWatch to monitor Kinesis
        /// Video Streams, see <a href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/monitoring.html">Monitoring
        /// Kinesis Video Streams</a>. For pricing information, see <a href="https://aws.amazon.com/kinesis/video-streams/pricing/">Amazon
        /// Kinesis Video Streams Pricing</a> and <a href="https://aws.amazon.com/pricing/"> Amazon
        /// Web Services Pricing</a>. Charges for outgoing Amazon Web Services data apply.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClip service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetClip service method, as returned by KinesisVideoArchivedMedia.</returns>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded a limit.
        /// Try making the call later. For information about limits, see <a href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/limits.html">Kinesis
        /// Video Streams Limits</a>.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.InvalidCodecPrivateDataException">
        /// The codec private data in at least one of the tracks of the video stream is not valid
        /// for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.InvalidMediaFrameException">
        /// One or more frames in the requested clip could not be parsed based on the specified
        /// codec.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.MissingCodecPrivateDataException">
        /// No codec private data was found in at least one of tracks of the video stream.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.NoDataRetentionException">
        /// <c>GetImages</c> was requested for a stream that does not retain data (that is, has
        /// a <c>DataRetentionInHours</c> of 0).
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.NotAuthorizedException">
        /// Status Code: 403, The caller is not authorized to perform an operation on the given
        /// stream, or the token has expired.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.ResourceNotFoundException">
        /// <c>GetImages</c> will throw this error when Kinesis Video Streams can't find the
        /// stream that you specified.
        /// 
        ///  
        /// <para>
        ///  <c>GetHLSStreamingSessionURL</c> and <c>GetDASHStreamingSessionURL</c> throw this
        /// error if a session with a <c>PlaybackMode</c> of <c>ON_DEMAND</c> or <c>LIVE_REPLAY</c>is
        /// requested for a stream that has no fragments within the requested time range, or if
        /// a session with a <c>PlaybackMode</c> of <c>LIVE</c> is requested for a stream that
        /// has no fragments within the last 30 seconds.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.UnsupportedStreamMediaTypeException">
        /// The type of the media (for example, h.264 or h.265 video or ACC or G.711 audio) could
        /// not be determined from the codec IDs of the tracks in the first fragment for a playback
        /// session. The codec ID for track 1 should be <c>V_MPEG/ISO/AVC</c> and, optionally,
        /// the codec ID for track 2 should be <c>A_AAC</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-video-archived-media-2017-09-30/GetClip">REST API Reference for GetClip Operation</seealso>
        public virtual Task<GetClipResponse> GetClipAsync(GetClipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetClipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClipResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetClipResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDASHStreamingSessionURL


        /// <summary>
        /// Retrieves an MPEG Dynamic Adaptive Streaming over HTTP (DASH) URL for the stream.
        /// You can then open the URL in a media player to view the stream contents.
        /// 
        ///  
        /// <para>
        /// Both the <c>StreamName</c> and the <c>StreamARN</c> parameters are optional, but you
        /// must specify either the <c>StreamName</c> or the <c>StreamARN</c> when invoking this
        /// API operation.
        /// </para>
        ///  
        /// <para>
        /// An Amazon Kinesis video stream has the following requirements for providing data through
        /// MPEG-DASH:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The media must contain h.264 or h.265 encoded video and, optionally, AAC or G.711
        /// encoded audio. Specifically, the codec ID of track 1 should be <c>V_MPEG/ISO/AVC</c>
        /// (for h.264) or V_MPEGH/ISO/HEVC (for H.265). Optionally, the codec ID of track 2 should
        /// be <c>A_AAC</c> (for AAC) or A_MS/ACM (for G.711).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Data retention must be greater than 0.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The video track of each fragment must contain codec private data in the Advanced Video
        /// Coding (AVC) for H.264 format and HEVC for H.265 format. For more information, see
        /// <a href="https://www.iso.org/standard/55980.html">MPEG-4 specification ISO/IEC 14496-15</a>.
        /// For information about adapting stream data to a given format, see <a href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/producer-reference-nal.html">NAL
        /// Adaptation Flags</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The audio track (if present) of each fragment must contain codec private data in the
        /// AAC format (<a href="https://www.iso.org/standard/43345.html">AAC specification ISO/IEC
        /// 13818-7</a>) or the <a href="http://www-mmsp.ece.mcgill.ca/Documents/AudioFormats/WAVE/WAVE.html">MS
        /// Wave format</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following procedure shows how to use MPEG-DASH with Kinesis Video Streams:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Get an endpoint using <a href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/API_GetDataEndpoint.html">GetDataEndpoint</a>,
        /// specifying <c>GET_DASH_STREAMING_SESSION_URL</c> for the <c>APIName</c> parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Retrieve the MPEG-DASH URL using <c>GetDASHStreamingSessionURL</c>. Kinesis Video
        /// Streams creates an MPEG-DASH streaming session to be used for accessing content in
        /// a stream using the MPEG-DASH protocol. <c>GetDASHStreamingSessionURL</c> returns an
        /// authenticated URL (that includes an encrypted session token) for the session's MPEG-DASH
        /// <i>manifest</i> (the root resource needed for streaming with MPEG-DASH).
        /// </para>
        ///  <note> 
        /// <para>
        /// Don't share or store this token where an unauthorized entity can access it. The token
        /// provides access to the content of the stream. Safeguard the token with the same measures
        /// that you use with your Amazon Web Services credentials.
        /// </para>
        ///  </note> 
        /// <para>
        /// The media that is made available through the manifest consists only of the requested
        /// stream, time range, and format. No other media data (such as frames outside the requested
        /// window or alternate bitrates) is made available.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provide the URL (containing the encrypted session token) for the MPEG-DASH manifest
        /// to a media player that supports the MPEG-DASH protocol. Kinesis Video Streams makes
        /// the initialization fragment and media fragments available through the manifest URL.
        /// The initialization fragment contains the codec private data for the stream, and other
        /// data needed to set up the video or audio decoder and renderer. The media fragments
        /// contain encoded video frames or encoded audio samples.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The media player receives the authenticated URL and requests stream metadata and media
        /// data normally. When the media player requests data, it calls the following actions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>GetDASHManifest:</b> Retrieves an MPEG DASH manifest, which contains the metadata
        /// for the media that you want to playback.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>GetMP4InitFragment:</b> Retrieves the MP4 initialization fragment. The media player
        /// typically loads the initialization fragment before loading any media fragments. This
        /// fragment contains the "<c>fytp</c>" and "<c>moov</c>" MP4 atoms, and the child atoms
        /// that are needed to initialize the media player decoder.
        /// </para>
        ///  
        /// <para>
        /// The initialization fragment does not correspond to a fragment in a Kinesis video stream.
        /// It contains only the codec private data for the stream and respective track, which
        /// the media player needs to decode the media frames.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>GetMP4MediaFragment:</b> Retrieves MP4 media fragments. These fragments contain
        /// the "<c>moof</c>" and "<c>mdat</c>" MP4 atoms and their child atoms, containing the
        /// encoded fragment's media frames and their timestamps. 
        /// </para>
        ///  <note> 
        /// <para>
        /// After the first media fragment is made available in a streaming session, any fragments
        /// that don't contain the same codec private data cause an error to be returned when
        /// those different media fragments are loaded. Therefore, the codec private data should
        /// not change between fragments in a session. This also means that the session fails
        /// if the fragments in a stream change from having only video to having both audio and
        /// video.
        /// </para>
        ///  </note> 
        /// <para>
        /// Data retrieved with this action is billable. See <a href="https://aws.amazon.com/kinesis/video-streams/pricing/">Pricing</a>
        /// for details.
        /// </para>
        ///  </li> </ul> </li> </ol> <note> 
        /// <para>
        /// For restrictions that apply to MPEG-DASH sessions, see <a href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/limits.html">Kinesis
        /// Video Streams Limits</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can monitor the amount of data that the media player consumes by monitoring the
        /// <c>GetMP4MediaFragment.OutgoingBytes</c> Amazon CloudWatch metric. For information
        /// about using CloudWatch to monitor Kinesis Video Streams, see <a href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/monitoring.html">Monitoring
        /// Kinesis Video Streams</a>. For pricing information, see <a href="https://aws.amazon.com/kinesis/video-streams/pricing/">Amazon
        /// Kinesis Video Streams Pricing</a> and <a href="https://aws.amazon.com/pricing/">Amazon
        /// Web Services Pricing</a>. Charges for both HLS sessions and outgoing Amazon Web Services
        /// data apply.
        /// </para>
        ///  
        /// <para>
        /// For more information about HLS, see <a href="https://developer.apple.com/streaming/">HTTP
        /// Live Streaming</a> on the <a href="https://developer.apple.com">Apple Developer site</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If an error is thrown after invoking a Kinesis Video Streams archived media API, in
        /// addition to the HTTP status code and the response body, it includes the following
        /// pieces of information: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>x-amz-ErrorType</c> HTTP header – contains a more specific error type in addition
        /// to what the HTTP status code provides. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>x-amz-RequestId</c> HTTP header – if you want to report an issue to Amazon Web
        /// Services the support team can better diagnose the problem if given the Request Id.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Both the HTTP status code and the ErrorType header can be utilized to make programmatic
        /// decisions about whether errors are retry-able and under what conditions, as well as
        /// provide information on what actions the client programmer might need to take in order
        /// to successfully try again.
        /// </para>
        ///  
        /// <para>
        /// For more information, see the <b>Errors</b> section at the bottom of this topic, as
        /// well as <a href="https://docs.aws.amazon.com/kinesisvideostreams/latest/dg/CommonErrors.html">Common
        /// Errors</a>. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDASHStreamingSessionURL service method.</param>
        /// 
        /// <returns>The response from the GetDASHStreamingSessionURL service method, as returned by KinesisVideoArchivedMedia.</returns>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded a limit.
        /// Try making the call later. For information about limits, see <a href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/limits.html">Kinesis
        /// Video Streams Limits</a>.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.InvalidCodecPrivateDataException">
        /// The codec private data in at least one of the tracks of the video stream is not valid
        /// for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.MissingCodecPrivateDataException">
        /// No codec private data was found in at least one of tracks of the video stream.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.NoDataRetentionException">
        /// <c>GetImages</c> was requested for a stream that does not retain data (that is, has
        /// a <c>DataRetentionInHours</c> of 0).
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.NotAuthorizedException">
        /// Status Code: 403, The caller is not authorized to perform an operation on the given
        /// stream, or the token has expired.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.ResourceNotFoundException">
        /// <c>GetImages</c> will throw this error when Kinesis Video Streams can't find the
        /// stream that you specified.
        /// 
        ///  
        /// <para>
        ///  <c>GetHLSStreamingSessionURL</c> and <c>GetDASHStreamingSessionURL</c> throw this
        /// error if a session with a <c>PlaybackMode</c> of <c>ON_DEMAND</c> or <c>LIVE_REPLAY</c>is
        /// requested for a stream that has no fragments within the requested time range, or if
        /// a session with a <c>PlaybackMode</c> of <c>LIVE</c> is requested for a stream that
        /// has no fragments within the last 30 seconds.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.UnsupportedStreamMediaTypeException">
        /// The type of the media (for example, h.264 or h.265 video or ACC or G.711 audio) could
        /// not be determined from the codec IDs of the tracks in the first fragment for a playback
        /// session. The codec ID for track 1 should be <c>V_MPEG/ISO/AVC</c> and, optionally,
        /// the codec ID for track 2 should be <c>A_AAC</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-video-archived-media-2017-09-30/GetDASHStreamingSessionURL">REST API Reference for GetDASHStreamingSessionURL Operation</seealso>
        public virtual GetDASHStreamingSessionURLResponse GetDASHStreamingSessionURL(GetDASHStreamingSessionURLRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDASHStreamingSessionURLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDASHStreamingSessionURLResponseUnmarshaller.Instance;

            return Invoke<GetDASHStreamingSessionURLResponse>(request, options);
        }


        /// <summary>
        /// Retrieves an MPEG Dynamic Adaptive Streaming over HTTP (DASH) URL for the stream.
        /// You can then open the URL in a media player to view the stream contents.
        /// 
        ///  
        /// <para>
        /// Both the <c>StreamName</c> and the <c>StreamARN</c> parameters are optional, but you
        /// must specify either the <c>StreamName</c> or the <c>StreamARN</c> when invoking this
        /// API operation.
        /// </para>
        ///  
        /// <para>
        /// An Amazon Kinesis video stream has the following requirements for providing data through
        /// MPEG-DASH:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The media must contain h.264 or h.265 encoded video and, optionally, AAC or G.711
        /// encoded audio. Specifically, the codec ID of track 1 should be <c>V_MPEG/ISO/AVC</c>
        /// (for h.264) or V_MPEGH/ISO/HEVC (for H.265). Optionally, the codec ID of track 2 should
        /// be <c>A_AAC</c> (for AAC) or A_MS/ACM (for G.711).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Data retention must be greater than 0.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The video track of each fragment must contain codec private data in the Advanced Video
        /// Coding (AVC) for H.264 format and HEVC for H.265 format. For more information, see
        /// <a href="https://www.iso.org/standard/55980.html">MPEG-4 specification ISO/IEC 14496-15</a>.
        /// For information about adapting stream data to a given format, see <a href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/producer-reference-nal.html">NAL
        /// Adaptation Flags</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The audio track (if present) of each fragment must contain codec private data in the
        /// AAC format (<a href="https://www.iso.org/standard/43345.html">AAC specification ISO/IEC
        /// 13818-7</a>) or the <a href="http://www-mmsp.ece.mcgill.ca/Documents/AudioFormats/WAVE/WAVE.html">MS
        /// Wave format</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following procedure shows how to use MPEG-DASH with Kinesis Video Streams:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Get an endpoint using <a href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/API_GetDataEndpoint.html">GetDataEndpoint</a>,
        /// specifying <c>GET_DASH_STREAMING_SESSION_URL</c> for the <c>APIName</c> parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Retrieve the MPEG-DASH URL using <c>GetDASHStreamingSessionURL</c>. Kinesis Video
        /// Streams creates an MPEG-DASH streaming session to be used for accessing content in
        /// a stream using the MPEG-DASH protocol. <c>GetDASHStreamingSessionURL</c> returns an
        /// authenticated URL (that includes an encrypted session token) for the session's MPEG-DASH
        /// <i>manifest</i> (the root resource needed for streaming with MPEG-DASH).
        /// </para>
        ///  <note> 
        /// <para>
        /// Don't share or store this token where an unauthorized entity can access it. The token
        /// provides access to the content of the stream. Safeguard the token with the same measures
        /// that you use with your Amazon Web Services credentials.
        /// </para>
        ///  </note> 
        /// <para>
        /// The media that is made available through the manifest consists only of the requested
        /// stream, time range, and format. No other media data (such as frames outside the requested
        /// window or alternate bitrates) is made available.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provide the URL (containing the encrypted session token) for the MPEG-DASH manifest
        /// to a media player that supports the MPEG-DASH protocol. Kinesis Video Streams makes
        /// the initialization fragment and media fragments available through the manifest URL.
        /// The initialization fragment contains the codec private data for the stream, and other
        /// data needed to set up the video or audio decoder and renderer. The media fragments
        /// contain encoded video frames or encoded audio samples.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The media player receives the authenticated URL and requests stream metadata and media
        /// data normally. When the media player requests data, it calls the following actions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>GetDASHManifest:</b> Retrieves an MPEG DASH manifest, which contains the metadata
        /// for the media that you want to playback.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>GetMP4InitFragment:</b> Retrieves the MP4 initialization fragment. The media player
        /// typically loads the initialization fragment before loading any media fragments. This
        /// fragment contains the "<c>fytp</c>" and "<c>moov</c>" MP4 atoms, and the child atoms
        /// that are needed to initialize the media player decoder.
        /// </para>
        ///  
        /// <para>
        /// The initialization fragment does not correspond to a fragment in a Kinesis video stream.
        /// It contains only the codec private data for the stream and respective track, which
        /// the media player needs to decode the media frames.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>GetMP4MediaFragment:</b> Retrieves MP4 media fragments. These fragments contain
        /// the "<c>moof</c>" and "<c>mdat</c>" MP4 atoms and their child atoms, containing the
        /// encoded fragment's media frames and their timestamps. 
        /// </para>
        ///  <note> 
        /// <para>
        /// After the first media fragment is made available in a streaming session, any fragments
        /// that don't contain the same codec private data cause an error to be returned when
        /// those different media fragments are loaded. Therefore, the codec private data should
        /// not change between fragments in a session. This also means that the session fails
        /// if the fragments in a stream change from having only video to having both audio and
        /// video.
        /// </para>
        ///  </note> 
        /// <para>
        /// Data retrieved with this action is billable. See <a href="https://aws.amazon.com/kinesis/video-streams/pricing/">Pricing</a>
        /// for details.
        /// </para>
        ///  </li> </ul> </li> </ol> <note> 
        /// <para>
        /// For restrictions that apply to MPEG-DASH sessions, see <a href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/limits.html">Kinesis
        /// Video Streams Limits</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can monitor the amount of data that the media player consumes by monitoring the
        /// <c>GetMP4MediaFragment.OutgoingBytes</c> Amazon CloudWatch metric. For information
        /// about using CloudWatch to monitor Kinesis Video Streams, see <a href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/monitoring.html">Monitoring
        /// Kinesis Video Streams</a>. For pricing information, see <a href="https://aws.amazon.com/kinesis/video-streams/pricing/">Amazon
        /// Kinesis Video Streams Pricing</a> and <a href="https://aws.amazon.com/pricing/">Amazon
        /// Web Services Pricing</a>. Charges for both HLS sessions and outgoing Amazon Web Services
        /// data apply.
        /// </para>
        ///  
        /// <para>
        /// For more information about HLS, see <a href="https://developer.apple.com/streaming/">HTTP
        /// Live Streaming</a> on the <a href="https://developer.apple.com">Apple Developer site</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If an error is thrown after invoking a Kinesis Video Streams archived media API, in
        /// addition to the HTTP status code and the response body, it includes the following
        /// pieces of information: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>x-amz-ErrorType</c> HTTP header – contains a more specific error type in addition
        /// to what the HTTP status code provides. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>x-amz-RequestId</c> HTTP header – if you want to report an issue to Amazon Web
        /// Services the support team can better diagnose the problem if given the Request Id.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Both the HTTP status code and the ErrorType header can be utilized to make programmatic
        /// decisions about whether errors are retry-able and under what conditions, as well as
        /// provide information on what actions the client programmer might need to take in order
        /// to successfully try again.
        /// </para>
        ///  
        /// <para>
        /// For more information, see the <b>Errors</b> section at the bottom of this topic, as
        /// well as <a href="https://docs.aws.amazon.com/kinesisvideostreams/latest/dg/CommonErrors.html">Common
        /// Errors</a>. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDASHStreamingSessionURL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDASHStreamingSessionURL service method, as returned by KinesisVideoArchivedMedia.</returns>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded a limit.
        /// Try making the call later. For information about limits, see <a href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/limits.html">Kinesis
        /// Video Streams Limits</a>.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.InvalidCodecPrivateDataException">
        /// The codec private data in at least one of the tracks of the video stream is not valid
        /// for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.MissingCodecPrivateDataException">
        /// No codec private data was found in at least one of tracks of the video stream.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.NoDataRetentionException">
        /// <c>GetImages</c> was requested for a stream that does not retain data (that is, has
        /// a <c>DataRetentionInHours</c> of 0).
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.NotAuthorizedException">
        /// Status Code: 403, The caller is not authorized to perform an operation on the given
        /// stream, or the token has expired.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.ResourceNotFoundException">
        /// <c>GetImages</c> will throw this error when Kinesis Video Streams can't find the
        /// stream that you specified.
        /// 
        ///  
        /// <para>
        ///  <c>GetHLSStreamingSessionURL</c> and <c>GetDASHStreamingSessionURL</c> throw this
        /// error if a session with a <c>PlaybackMode</c> of <c>ON_DEMAND</c> or <c>LIVE_REPLAY</c>is
        /// requested for a stream that has no fragments within the requested time range, or if
        /// a session with a <c>PlaybackMode</c> of <c>LIVE</c> is requested for a stream that
        /// has no fragments within the last 30 seconds.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.UnsupportedStreamMediaTypeException">
        /// The type of the media (for example, h.264 or h.265 video or ACC or G.711 audio) could
        /// not be determined from the codec IDs of the tracks in the first fragment for a playback
        /// session. The codec ID for track 1 should be <c>V_MPEG/ISO/AVC</c> and, optionally,
        /// the codec ID for track 2 should be <c>A_AAC</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-video-archived-media-2017-09-30/GetDASHStreamingSessionURL">REST API Reference for GetDASHStreamingSessionURL Operation</seealso>
        public virtual Task<GetDASHStreamingSessionURLResponse> GetDASHStreamingSessionURLAsync(GetDASHStreamingSessionURLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDASHStreamingSessionURLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDASHStreamingSessionURLResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDASHStreamingSessionURLResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetHLSStreamingSessionURL


        /// <summary>
        /// Retrieves an HTTP Live Streaming (HLS) URL for the stream. You can then open the URL
        /// in a browser or media player to view the stream contents.
        /// 
        ///  
        /// <para>
        /// Both the <c>StreamName</c> and the <c>StreamARN</c> parameters are optional, but you
        /// must specify either the <c>StreamName</c> or the <c>StreamARN</c> when invoking this
        /// API operation.
        /// </para>
        ///  
        /// <para>
        /// An Amazon Kinesis video stream has the following requirements for providing data through
        /// HLS:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For streaming video, the media must contain H.264 or H.265 encoded video and, optionally,
        /// AAC encoded audio. Specifically, the codec ID of track 1 should be <c>V_MPEG/ISO/AVC</c>
        /// (for H.264) or <c>V_MPEG/ISO/HEVC</c> (for H.265). Optionally, the codec ID of track
        /// 2 should be <c>A_AAC</c>. For audio only streaming, the codec ID of track 1 should
        /// be <c>A_AAC</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Data retention must be greater than 0.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The video track of each fragment must contain codec private data in the Advanced Video
        /// Coding (AVC) for H.264 format or HEVC for H.265 format (<a href="https://www.iso.org/standard/55980.html">MPEG-4
        /// specification ISO/IEC 14496-15</a>). For information about adapting stream data to
        /// a given format, see <a href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/producer-reference-nal.html">NAL
        /// Adaptation Flags</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The audio track (if present) of each fragment must contain codec private data in the
        /// AAC format (<a href="https://www.iso.org/standard/43345.html">AAC specification ISO/IEC
        /// 13818-7</a>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Kinesis Video Streams HLS sessions contain fragments in the fragmented MPEG-4 form
        /// (also called fMP4 or CMAF) or the MPEG-2 form (also called TS chunks, which the HLS
        /// specification also supports). For more information about HLS fragment types, see the
        /// <a href="https://tools.ietf.org/html/draft-pantos-http-live-streaming-23">HLS specification</a>.
        /// </para>
        ///  
        /// <para>
        /// The following procedure shows how to use HLS with Kinesis Video Streams:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Get an endpoint using <a href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/API_GetDataEndpoint.html">GetDataEndpoint</a>,
        /// specifying <c>GET_HLS_STREAMING_SESSION_URL</c> for the <c>APIName</c> parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Retrieve the HLS URL using <c>GetHLSStreamingSessionURL</c>. Kinesis Video Streams
        /// creates an HLS streaming session to be used for accessing content in a stream using
        /// the HLS protocol. <c>GetHLSStreamingSessionURL</c> returns an authenticated URL (that
        /// includes an encrypted session token) for the session's HLS <i>master playlist</i>
        /// (the root resource needed for streaming with HLS).
        /// </para>
        ///  <note> 
        /// <para>
        /// Don't share or store this token where an unauthorized entity could access it. The
        /// token provides access to the content of the stream. Safeguard the token with the same
        /// measures that you would use with your Amazon Web Services credentials.
        /// </para>
        ///  </note> 
        /// <para>
        /// The media that is made available through the playlist consists only of the requested
        /// stream, time range, and format. No other media data (such as frames outside the requested
        /// window or alternate bitrates) is made available.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provide the URL (containing the encrypted session token) for the HLS master playlist
        /// to a media player that supports the HLS protocol. Kinesis Video Streams makes the
        /// HLS media playlist, initialization fragment, and media fragments available through
        /// the master playlist URL. The initialization fragment contains the codec private data
        /// for the stream, and other data needed to set up the video or audio decoder and renderer.
        /// The media fragments contain H.264-encoded video frames or AAC-encoded audio samples.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The media player receives the authenticated URL and requests stream metadata and media
        /// data normally. When the media player requests data, it calls the following actions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>GetHLSMasterPlaylist:</b> Retrieves an HLS master playlist, which contains a URL
        /// for the <c>GetHLSMediaPlaylist</c> action for each track, and additional metadata
        /// for the media player, including estimated bitrate and resolution.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>GetHLSMediaPlaylist:</b> Retrieves an HLS media playlist, which contains a URL
        /// to access the MP4 initialization fragment with the <c>GetMP4InitFragment</c> action,
        /// and URLs to access the MP4 media fragments with the <c>GetMP4MediaFragment</c> actions.
        /// The HLS media playlist also contains metadata about the stream that the player needs
        /// to play it, such as whether the <c>PlaybackMode</c> is <c>LIVE</c> or <c>ON_DEMAND</c>.
        /// The HLS media playlist is typically static for sessions with a <c>PlaybackType</c>
        /// of <c>ON_DEMAND</c>. The HLS media playlist is continually updated with new fragments
        /// for sessions with a <c>PlaybackType</c> of <c>LIVE</c>. There is a distinct HLS media
        /// playlist for the video track and the audio track (if applicable) that contains MP4
        /// media URLs for the specific track. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>GetMP4InitFragment:</b> Retrieves the MP4 initialization fragment. The media player
        /// typically loads the initialization fragment before loading any media fragments. This
        /// fragment contains the "<c>fytp</c>" and "<c>moov</c>" MP4 atoms, and the child atoms
        /// that are needed to initialize the media player decoder.
        /// </para>
        ///  
        /// <para>
        /// The initialization fragment does not correspond to a fragment in a Kinesis video stream.
        /// It contains only the codec private data for the stream and respective track, which
        /// the media player needs to decode the media frames.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>GetMP4MediaFragment:</b> Retrieves MP4 media fragments. These fragments contain
        /// the "<c>moof</c>" and "<c>mdat</c>" MP4 atoms and their child atoms, containing the
        /// encoded fragment's media frames and their timestamps. 
        /// </para>
        ///  <note> 
        /// <para>
        /// For the HLS streaming session, in-track codec private data (CPD) changes are supported.
        /// After the first media fragment is made available in a streaming session, fragments
        /// can contain CPD changes for each track. Therefore, the fragments in a session can
        /// have a different resolution, bit rate, or other information in the CPD without interrupting
        /// playback. However, any change made in the track number or track codec format can return
        /// an error when those different media fragments are loaded. For example, streaming will
        /// fail if the fragments in the stream change from having only video to having both audio
        /// and video, or if an AAC audio track is changed to an ALAW audio track. For each streaming
        /// session, only 500 CPD changes are allowed.
        /// </para>
        ///  </note> 
        /// <para>
        /// Data retrieved with this action is billable. For information, see <a href="https://aws.amazon.com/kinesis/video-streams/pricing/">Pricing</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>GetTSFragment:</b> Retrieves MPEG TS fragments containing both initialization
        /// and media data for all tracks in the stream.
        /// </para>
        ///  <note> 
        /// <para>
        /// If the <c>ContainerFormat</c> is <c>MPEG_TS</c>, this API is used instead of <c>GetMP4InitFragment</c>
        /// and <c>GetMP4MediaFragment</c> to retrieve stream media.
        /// </para>
        ///  </note> 
        /// <para>
        /// Data retrieved with this action is billable. For more information, see <a href="https://aws.amazon.com/kinesis/video-streams/pricing/">Kinesis
        /// Video Streams pricing</a>.
        /// </para>
        ///  </li> </ul> </li> </ol> 
        /// <para>
        /// A streaming session URL must not be shared between players. The service might throttle
        /// a session if multiple media players are sharing it. For connection limits, see <a
        /// href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/limits.html">Kinesis
        /// Video Streams Limits</a>.
        /// </para>
        ///  
        /// <para>
        /// You can monitor the amount of data that the media player consumes by monitoring the
        /// <c>GetMP4MediaFragment.OutgoingBytes</c> Amazon CloudWatch metric. For information
        /// about using CloudWatch to monitor Kinesis Video Streams, see <a href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/monitoring.html">Monitoring
        /// Kinesis Video Streams</a>. For pricing information, see <a href="https://aws.amazon.com/kinesis/video-streams/pricing/">Amazon
        /// Kinesis Video Streams Pricing</a> and <a href="https://aws.amazon.com/pricing/">Amazon
        /// Web Services Pricing</a>. Charges for both HLS sessions and outgoing Amazon Web Services
        /// data apply.
        /// </para>
        ///  
        /// <para>
        /// For more information about HLS, see <a href="https://developer.apple.com/streaming/">HTTP
        /// Live Streaming</a> on the <a href="https://developer.apple.com">Apple Developer site</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If an error is thrown after invoking a Kinesis Video Streams archived media API, in
        /// addition to the HTTP status code and the response body, it includes the following
        /// pieces of information: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>x-amz-ErrorType</c> HTTP header – contains a more specific error type in addition
        /// to what the HTTP status code provides. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>x-amz-RequestId</c> HTTP header – if you want to report an issue to Amazon Web
        /// Services, the support team can better diagnose the problem if given the Request Id.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Both the HTTP status code and the ErrorType header can be utilized to make programmatic
        /// decisions about whether errors are retry-able and under what conditions, as well as
        /// provide information on what actions the client programmer might need to take in order
        /// to successfully try again.
        /// </para>
        ///  
        /// <para>
        /// For more information, see the <b>Errors</b> section at the bottom of this topic, as
        /// well as <a href="https://docs.aws.amazon.com/kinesisvideostreams/latest/dg/CommonErrors.html">Common
        /// Errors</a>. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHLSStreamingSessionURL service method.</param>
        /// 
        /// <returns>The response from the GetHLSStreamingSessionURL service method, as returned by KinesisVideoArchivedMedia.</returns>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded a limit.
        /// Try making the call later. For information about limits, see <a href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/limits.html">Kinesis
        /// Video Streams Limits</a>.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.InvalidCodecPrivateDataException">
        /// The codec private data in at least one of the tracks of the video stream is not valid
        /// for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.MissingCodecPrivateDataException">
        /// No codec private data was found in at least one of tracks of the video stream.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.NoDataRetentionException">
        /// <c>GetImages</c> was requested for a stream that does not retain data (that is, has
        /// a <c>DataRetentionInHours</c> of 0).
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.NotAuthorizedException">
        /// Status Code: 403, The caller is not authorized to perform an operation on the given
        /// stream, or the token has expired.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.ResourceNotFoundException">
        /// <c>GetImages</c> will throw this error when Kinesis Video Streams can't find the
        /// stream that you specified.
        /// 
        ///  
        /// <para>
        ///  <c>GetHLSStreamingSessionURL</c> and <c>GetDASHStreamingSessionURL</c> throw this
        /// error if a session with a <c>PlaybackMode</c> of <c>ON_DEMAND</c> or <c>LIVE_REPLAY</c>is
        /// requested for a stream that has no fragments within the requested time range, or if
        /// a session with a <c>PlaybackMode</c> of <c>LIVE</c> is requested for a stream that
        /// has no fragments within the last 30 seconds.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.UnsupportedStreamMediaTypeException">
        /// The type of the media (for example, h.264 or h.265 video or ACC or G.711 audio) could
        /// not be determined from the codec IDs of the tracks in the first fragment for a playback
        /// session. The codec ID for track 1 should be <c>V_MPEG/ISO/AVC</c> and, optionally,
        /// the codec ID for track 2 should be <c>A_AAC</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-video-archived-media-2017-09-30/GetHLSStreamingSessionURL">REST API Reference for GetHLSStreamingSessionURL Operation</seealso>
        public virtual GetHLSStreamingSessionURLResponse GetHLSStreamingSessionURL(GetHLSStreamingSessionURLRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetHLSStreamingSessionURLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHLSStreamingSessionURLResponseUnmarshaller.Instance;

            return Invoke<GetHLSStreamingSessionURLResponse>(request, options);
        }


        /// <summary>
        /// Retrieves an HTTP Live Streaming (HLS) URL for the stream. You can then open the URL
        /// in a browser or media player to view the stream contents.
        /// 
        ///  
        /// <para>
        /// Both the <c>StreamName</c> and the <c>StreamARN</c> parameters are optional, but you
        /// must specify either the <c>StreamName</c> or the <c>StreamARN</c> when invoking this
        /// API operation.
        /// </para>
        ///  
        /// <para>
        /// An Amazon Kinesis video stream has the following requirements for providing data through
        /// HLS:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For streaming video, the media must contain H.264 or H.265 encoded video and, optionally,
        /// AAC encoded audio. Specifically, the codec ID of track 1 should be <c>V_MPEG/ISO/AVC</c>
        /// (for H.264) or <c>V_MPEG/ISO/HEVC</c> (for H.265). Optionally, the codec ID of track
        /// 2 should be <c>A_AAC</c>. For audio only streaming, the codec ID of track 1 should
        /// be <c>A_AAC</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Data retention must be greater than 0.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The video track of each fragment must contain codec private data in the Advanced Video
        /// Coding (AVC) for H.264 format or HEVC for H.265 format (<a href="https://www.iso.org/standard/55980.html">MPEG-4
        /// specification ISO/IEC 14496-15</a>). For information about adapting stream data to
        /// a given format, see <a href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/producer-reference-nal.html">NAL
        /// Adaptation Flags</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The audio track (if present) of each fragment must contain codec private data in the
        /// AAC format (<a href="https://www.iso.org/standard/43345.html">AAC specification ISO/IEC
        /// 13818-7</a>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Kinesis Video Streams HLS sessions contain fragments in the fragmented MPEG-4 form
        /// (also called fMP4 or CMAF) or the MPEG-2 form (also called TS chunks, which the HLS
        /// specification also supports). For more information about HLS fragment types, see the
        /// <a href="https://tools.ietf.org/html/draft-pantos-http-live-streaming-23">HLS specification</a>.
        /// </para>
        ///  
        /// <para>
        /// The following procedure shows how to use HLS with Kinesis Video Streams:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Get an endpoint using <a href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/API_GetDataEndpoint.html">GetDataEndpoint</a>,
        /// specifying <c>GET_HLS_STREAMING_SESSION_URL</c> for the <c>APIName</c> parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Retrieve the HLS URL using <c>GetHLSStreamingSessionURL</c>. Kinesis Video Streams
        /// creates an HLS streaming session to be used for accessing content in a stream using
        /// the HLS protocol. <c>GetHLSStreamingSessionURL</c> returns an authenticated URL (that
        /// includes an encrypted session token) for the session's HLS <i>master playlist</i>
        /// (the root resource needed for streaming with HLS).
        /// </para>
        ///  <note> 
        /// <para>
        /// Don't share or store this token where an unauthorized entity could access it. The
        /// token provides access to the content of the stream. Safeguard the token with the same
        /// measures that you would use with your Amazon Web Services credentials.
        /// </para>
        ///  </note> 
        /// <para>
        /// The media that is made available through the playlist consists only of the requested
        /// stream, time range, and format. No other media data (such as frames outside the requested
        /// window or alternate bitrates) is made available.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provide the URL (containing the encrypted session token) for the HLS master playlist
        /// to a media player that supports the HLS protocol. Kinesis Video Streams makes the
        /// HLS media playlist, initialization fragment, and media fragments available through
        /// the master playlist URL. The initialization fragment contains the codec private data
        /// for the stream, and other data needed to set up the video or audio decoder and renderer.
        /// The media fragments contain H.264-encoded video frames or AAC-encoded audio samples.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The media player receives the authenticated URL and requests stream metadata and media
        /// data normally. When the media player requests data, it calls the following actions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>GetHLSMasterPlaylist:</b> Retrieves an HLS master playlist, which contains a URL
        /// for the <c>GetHLSMediaPlaylist</c> action for each track, and additional metadata
        /// for the media player, including estimated bitrate and resolution.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>GetHLSMediaPlaylist:</b> Retrieves an HLS media playlist, which contains a URL
        /// to access the MP4 initialization fragment with the <c>GetMP4InitFragment</c> action,
        /// and URLs to access the MP4 media fragments with the <c>GetMP4MediaFragment</c> actions.
        /// The HLS media playlist also contains metadata about the stream that the player needs
        /// to play it, such as whether the <c>PlaybackMode</c> is <c>LIVE</c> or <c>ON_DEMAND</c>.
        /// The HLS media playlist is typically static for sessions with a <c>PlaybackType</c>
        /// of <c>ON_DEMAND</c>. The HLS media playlist is continually updated with new fragments
        /// for sessions with a <c>PlaybackType</c> of <c>LIVE</c>. There is a distinct HLS media
        /// playlist for the video track and the audio track (if applicable) that contains MP4
        /// media URLs for the specific track. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>GetMP4InitFragment:</b> Retrieves the MP4 initialization fragment. The media player
        /// typically loads the initialization fragment before loading any media fragments. This
        /// fragment contains the "<c>fytp</c>" and "<c>moov</c>" MP4 atoms, and the child atoms
        /// that are needed to initialize the media player decoder.
        /// </para>
        ///  
        /// <para>
        /// The initialization fragment does not correspond to a fragment in a Kinesis video stream.
        /// It contains only the codec private data for the stream and respective track, which
        /// the media player needs to decode the media frames.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>GetMP4MediaFragment:</b> Retrieves MP4 media fragments. These fragments contain
        /// the "<c>moof</c>" and "<c>mdat</c>" MP4 atoms and their child atoms, containing the
        /// encoded fragment's media frames and their timestamps. 
        /// </para>
        ///  <note> 
        /// <para>
        /// For the HLS streaming session, in-track codec private data (CPD) changes are supported.
        /// After the first media fragment is made available in a streaming session, fragments
        /// can contain CPD changes for each track. Therefore, the fragments in a session can
        /// have a different resolution, bit rate, or other information in the CPD without interrupting
        /// playback. However, any change made in the track number or track codec format can return
        /// an error when those different media fragments are loaded. For example, streaming will
        /// fail if the fragments in the stream change from having only video to having both audio
        /// and video, or if an AAC audio track is changed to an ALAW audio track. For each streaming
        /// session, only 500 CPD changes are allowed.
        /// </para>
        ///  </note> 
        /// <para>
        /// Data retrieved with this action is billable. For information, see <a href="https://aws.amazon.com/kinesis/video-streams/pricing/">Pricing</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>GetTSFragment:</b> Retrieves MPEG TS fragments containing both initialization
        /// and media data for all tracks in the stream.
        /// </para>
        ///  <note> 
        /// <para>
        /// If the <c>ContainerFormat</c> is <c>MPEG_TS</c>, this API is used instead of <c>GetMP4InitFragment</c>
        /// and <c>GetMP4MediaFragment</c> to retrieve stream media.
        /// </para>
        ///  </note> 
        /// <para>
        /// Data retrieved with this action is billable. For more information, see <a href="https://aws.amazon.com/kinesis/video-streams/pricing/">Kinesis
        /// Video Streams pricing</a>.
        /// </para>
        ///  </li> </ul> </li> </ol> 
        /// <para>
        /// A streaming session URL must not be shared between players. The service might throttle
        /// a session if multiple media players are sharing it. For connection limits, see <a
        /// href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/limits.html">Kinesis
        /// Video Streams Limits</a>.
        /// </para>
        ///  
        /// <para>
        /// You can monitor the amount of data that the media player consumes by monitoring the
        /// <c>GetMP4MediaFragment.OutgoingBytes</c> Amazon CloudWatch metric. For information
        /// about using CloudWatch to monitor Kinesis Video Streams, see <a href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/monitoring.html">Monitoring
        /// Kinesis Video Streams</a>. For pricing information, see <a href="https://aws.amazon.com/kinesis/video-streams/pricing/">Amazon
        /// Kinesis Video Streams Pricing</a> and <a href="https://aws.amazon.com/pricing/">Amazon
        /// Web Services Pricing</a>. Charges for both HLS sessions and outgoing Amazon Web Services
        /// data apply.
        /// </para>
        ///  
        /// <para>
        /// For more information about HLS, see <a href="https://developer.apple.com/streaming/">HTTP
        /// Live Streaming</a> on the <a href="https://developer.apple.com">Apple Developer site</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If an error is thrown after invoking a Kinesis Video Streams archived media API, in
        /// addition to the HTTP status code and the response body, it includes the following
        /// pieces of information: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>x-amz-ErrorType</c> HTTP header – contains a more specific error type in addition
        /// to what the HTTP status code provides. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>x-amz-RequestId</c> HTTP header – if you want to report an issue to Amazon Web
        /// Services, the support team can better diagnose the problem if given the Request Id.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Both the HTTP status code and the ErrorType header can be utilized to make programmatic
        /// decisions about whether errors are retry-able and under what conditions, as well as
        /// provide information on what actions the client programmer might need to take in order
        /// to successfully try again.
        /// </para>
        ///  
        /// <para>
        /// For more information, see the <b>Errors</b> section at the bottom of this topic, as
        /// well as <a href="https://docs.aws.amazon.com/kinesisvideostreams/latest/dg/CommonErrors.html">Common
        /// Errors</a>. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHLSStreamingSessionURL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetHLSStreamingSessionURL service method, as returned by KinesisVideoArchivedMedia.</returns>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded a limit.
        /// Try making the call later. For information about limits, see <a href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/limits.html">Kinesis
        /// Video Streams Limits</a>.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.InvalidCodecPrivateDataException">
        /// The codec private data in at least one of the tracks of the video stream is not valid
        /// for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.MissingCodecPrivateDataException">
        /// No codec private data was found in at least one of tracks of the video stream.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.NoDataRetentionException">
        /// <c>GetImages</c> was requested for a stream that does not retain data (that is, has
        /// a <c>DataRetentionInHours</c> of 0).
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.NotAuthorizedException">
        /// Status Code: 403, The caller is not authorized to perform an operation on the given
        /// stream, or the token has expired.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.ResourceNotFoundException">
        /// <c>GetImages</c> will throw this error when Kinesis Video Streams can't find the
        /// stream that you specified.
        /// 
        ///  
        /// <para>
        ///  <c>GetHLSStreamingSessionURL</c> and <c>GetDASHStreamingSessionURL</c> throw this
        /// error if a session with a <c>PlaybackMode</c> of <c>ON_DEMAND</c> or <c>LIVE_REPLAY</c>is
        /// requested for a stream that has no fragments within the requested time range, or if
        /// a session with a <c>PlaybackMode</c> of <c>LIVE</c> is requested for a stream that
        /// has no fragments within the last 30 seconds.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.UnsupportedStreamMediaTypeException">
        /// The type of the media (for example, h.264 or h.265 video or ACC or G.711 audio) could
        /// not be determined from the codec IDs of the tracks in the first fragment for a playback
        /// session. The codec ID for track 1 should be <c>V_MPEG/ISO/AVC</c> and, optionally,
        /// the codec ID for track 2 should be <c>A_AAC</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-video-archived-media-2017-09-30/GetHLSStreamingSessionURL">REST API Reference for GetHLSStreamingSessionURL Operation</seealso>
        public virtual Task<GetHLSStreamingSessionURLResponse> GetHLSStreamingSessionURLAsync(GetHLSStreamingSessionURLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetHLSStreamingSessionURLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHLSStreamingSessionURLResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetHLSStreamingSessionURLResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetImages


        /// <summary>
        /// Retrieves a list of images corresponding to each timestamp for a given time range,
        /// sampling interval, and image format configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImages service method.</param>
        /// 
        /// <returns>The response from the GetImages service method, as returned by KinesisVideoArchivedMedia.</returns>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded a limit.
        /// Try making the call later. For information about limits, see <a href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/limits.html">Kinesis
        /// Video Streams Limits</a>.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.NoDataRetentionException">
        /// <c>GetImages</c> was requested for a stream that does not retain data (that is, has
        /// a <c>DataRetentionInHours</c> of 0).
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.NotAuthorizedException">
        /// Status Code: 403, The caller is not authorized to perform an operation on the given
        /// stream, or the token has expired.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.ResourceNotFoundException">
        /// <c>GetImages</c> will throw this error when Kinesis Video Streams can't find the
        /// stream that you specified.
        /// 
        ///  
        /// <para>
        ///  <c>GetHLSStreamingSessionURL</c> and <c>GetDASHStreamingSessionURL</c> throw this
        /// error if a session with a <c>PlaybackMode</c> of <c>ON_DEMAND</c> or <c>LIVE_REPLAY</c>is
        /// requested for a stream that has no fragments within the requested time range, or if
        /// a session with a <c>PlaybackMode</c> of <c>LIVE</c> is requested for a stream that
        /// has no fragments within the last 30 seconds.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-video-archived-media-2017-09-30/GetImages">REST API Reference for GetImages Operation</seealso>
        public virtual GetImagesResponse GetImages(GetImagesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImagesResponseUnmarshaller.Instance;

            return Invoke<GetImagesResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a list of images corresponding to each timestamp for a given time range,
        /// sampling interval, and image format configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetImages service method, as returned by KinesisVideoArchivedMedia.</returns>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded a limit.
        /// Try making the call later. For information about limits, see <a href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/limits.html">Kinesis
        /// Video Streams Limits</a>.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.NoDataRetentionException">
        /// <c>GetImages</c> was requested for a stream that does not retain data (that is, has
        /// a <c>DataRetentionInHours</c> of 0).
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.NotAuthorizedException">
        /// Status Code: 403, The caller is not authorized to perform an operation on the given
        /// stream, or the token has expired.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.ResourceNotFoundException">
        /// <c>GetImages</c> will throw this error when Kinesis Video Streams can't find the
        /// stream that you specified.
        /// 
        ///  
        /// <para>
        ///  <c>GetHLSStreamingSessionURL</c> and <c>GetDASHStreamingSessionURL</c> throw this
        /// error if a session with a <c>PlaybackMode</c> of <c>ON_DEMAND</c> or <c>LIVE_REPLAY</c>is
        /// requested for a stream that has no fragments within the requested time range, or if
        /// a session with a <c>PlaybackMode</c> of <c>LIVE</c> is requested for a stream that
        /// has no fragments within the last 30 seconds.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-video-archived-media-2017-09-30/GetImages">REST API Reference for GetImages Operation</seealso>
        public virtual Task<GetImagesResponse> GetImagesAsync(GetImagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImagesResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetImagesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMediaForFragmentList


        /// <summary>
        /// Gets media for a list of fragments (specified by fragment number) from the archived
        /// data in an Amazon Kinesis video stream.
        /// 
        ///  <note> 
        /// <para>
        /// You must first call the <c>GetDataEndpoint</c> API to get an endpoint. Then send the
        /// <c>GetMediaForFragmentList</c> requests to this endpoint using the <a href="https://docs.aws.amazon.com/cli/latest/reference/">--endpoint-url
        /// parameter</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// For limits, see <a href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/limits.html">Kinesis
        /// Video Streams Limits</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If an error is thrown after invoking a Kinesis Video Streams archived media API, in
        /// addition to the HTTP status code and the response body, it includes the following
        /// pieces of information: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>x-amz-ErrorType</c> HTTP header – contains a more specific error type in addition
        /// to what the HTTP status code provides. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>x-amz-RequestId</c> HTTP header – if you want to report an issue to Amazon Web
        /// Services, the support team can better diagnose the problem if given the Request Id.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Both the HTTP status code and the ErrorType header can be utilized to make programmatic
        /// decisions about whether errors are retry-able and under what conditions, as well as
        /// provide information on what actions the client programmer might need to take in order
        /// to successfully try again.
        /// </para>
        ///  
        /// <para>
        /// For more information, see the <b>Errors</b> section at the bottom of this topic, as
        /// well as <a href="https://docs.aws.amazon.com/kinesisvideostreams/latest/dg/CommonErrors.html">Common
        /// Errors</a>. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMediaForFragmentList service method.</param>
        /// 
        /// <returns>The response from the GetMediaForFragmentList service method, as returned by KinesisVideoArchivedMedia.</returns>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded a limit.
        /// Try making the call later. For information about limits, see <a href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/limits.html">Kinesis
        /// Video Streams Limits</a>.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.NotAuthorizedException">
        /// Status Code: 403, The caller is not authorized to perform an operation on the given
        /// stream, or the token has expired.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.ResourceNotFoundException">
        /// <c>GetImages</c> will throw this error when Kinesis Video Streams can't find the
        /// stream that you specified.
        /// 
        ///  
        /// <para>
        ///  <c>GetHLSStreamingSessionURL</c> and <c>GetDASHStreamingSessionURL</c> throw this
        /// error if a session with a <c>PlaybackMode</c> of <c>ON_DEMAND</c> or <c>LIVE_REPLAY</c>is
        /// requested for a stream that has no fragments within the requested time range, or if
        /// a session with a <c>PlaybackMode</c> of <c>LIVE</c> is requested for a stream that
        /// has no fragments within the last 30 seconds.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-video-archived-media-2017-09-30/GetMediaForFragmentList">REST API Reference for GetMediaForFragmentList Operation</seealso>
        public virtual GetMediaForFragmentListResponse GetMediaForFragmentList(GetMediaForFragmentListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMediaForFragmentListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMediaForFragmentListResponseUnmarshaller.Instance;

            return Invoke<GetMediaForFragmentListResponse>(request, options);
        }


        /// <summary>
        /// Gets media for a list of fragments (specified by fragment number) from the archived
        /// data in an Amazon Kinesis video stream.
        /// 
        ///  <note> 
        /// <para>
        /// You must first call the <c>GetDataEndpoint</c> API to get an endpoint. Then send the
        /// <c>GetMediaForFragmentList</c> requests to this endpoint using the <a href="https://docs.aws.amazon.com/cli/latest/reference/">--endpoint-url
        /// parameter</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// For limits, see <a href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/limits.html">Kinesis
        /// Video Streams Limits</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If an error is thrown after invoking a Kinesis Video Streams archived media API, in
        /// addition to the HTTP status code and the response body, it includes the following
        /// pieces of information: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>x-amz-ErrorType</c> HTTP header – contains a more specific error type in addition
        /// to what the HTTP status code provides. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>x-amz-RequestId</c> HTTP header – if you want to report an issue to Amazon Web
        /// Services, the support team can better diagnose the problem if given the Request Id.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Both the HTTP status code and the ErrorType header can be utilized to make programmatic
        /// decisions about whether errors are retry-able and under what conditions, as well as
        /// provide information on what actions the client programmer might need to take in order
        /// to successfully try again.
        /// </para>
        ///  
        /// <para>
        /// For more information, see the <b>Errors</b> section at the bottom of this topic, as
        /// well as <a href="https://docs.aws.amazon.com/kinesisvideostreams/latest/dg/CommonErrors.html">Common
        /// Errors</a>. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMediaForFragmentList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMediaForFragmentList service method, as returned by KinesisVideoArchivedMedia.</returns>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded a limit.
        /// Try making the call later. For information about limits, see <a href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/limits.html">Kinesis
        /// Video Streams Limits</a>.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.NotAuthorizedException">
        /// Status Code: 403, The caller is not authorized to perform an operation on the given
        /// stream, or the token has expired.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.ResourceNotFoundException">
        /// <c>GetImages</c> will throw this error when Kinesis Video Streams can't find the
        /// stream that you specified.
        /// 
        ///  
        /// <para>
        ///  <c>GetHLSStreamingSessionURL</c> and <c>GetDASHStreamingSessionURL</c> throw this
        /// error if a session with a <c>PlaybackMode</c> of <c>ON_DEMAND</c> or <c>LIVE_REPLAY</c>is
        /// requested for a stream that has no fragments within the requested time range, or if
        /// a session with a <c>PlaybackMode</c> of <c>LIVE</c> is requested for a stream that
        /// has no fragments within the last 30 seconds.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-video-archived-media-2017-09-30/GetMediaForFragmentList">REST API Reference for GetMediaForFragmentList Operation</seealso>
        public virtual Task<GetMediaForFragmentListResponse> GetMediaForFragmentListAsync(GetMediaForFragmentListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMediaForFragmentListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMediaForFragmentListResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetMediaForFragmentListResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFragments


        /// <summary>
        /// Returns a list of <a>Fragment</a> objects from the specified stream and timestamp
        /// range within the archived data.
        /// 
        ///  
        /// <para>
        /// Listing fragments is eventually consistent. This means that even if the producer receives
        /// an acknowledgment that a fragment is persisted, the result might not be returned immediately
        /// from a request to <c>ListFragments</c>. However, results are typically available in
        /// less than one second.
        /// </para>
        ///  <note> 
        /// <para>
        /// You must first call the <c>GetDataEndpoint</c> API to get an endpoint. Then send the
        /// <c>ListFragments</c> requests to this endpoint using the <a href="https://docs.aws.amazon.com/cli/latest/reference/">--endpoint-url
        /// parameter</a>. 
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// If an error is thrown after invoking a Kinesis Video Streams archived media API, in
        /// addition to the HTTP status code and the response body, it includes the following
        /// pieces of information: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>x-amz-ErrorType</c> HTTP header – contains a more specific error type in addition
        /// to what the HTTP status code provides. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>x-amz-RequestId</c> HTTP header – if you want to report an issue to Amazon Web
        /// Services, the support team can better diagnose the problem if given the Request Id.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Both the HTTP status code and the ErrorType header can be utilized to make programmatic
        /// decisions about whether errors are retry-able and under what conditions, as well as
        /// provide information on what actions the client programmer might need to take in order
        /// to successfully try again.
        /// </para>
        ///  
        /// <para>
        /// For more information, see the <b>Errors</b> section at the bottom of this topic, as
        /// well as <a href="https://docs.aws.amazon.com/kinesisvideostreams/latest/dg/CommonErrors.html">Common
        /// Errors</a>. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFragments service method.</param>
        /// 
        /// <returns>The response from the ListFragments service method, as returned by KinesisVideoArchivedMedia.</returns>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded a limit.
        /// Try making the call later. For information about limits, see <a href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/limits.html">Kinesis
        /// Video Streams Limits</a>.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.NotAuthorizedException">
        /// Status Code: 403, The caller is not authorized to perform an operation on the given
        /// stream, or the token has expired.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.ResourceNotFoundException">
        /// <c>GetImages</c> will throw this error when Kinesis Video Streams can't find the
        /// stream that you specified.
        /// 
        ///  
        /// <para>
        ///  <c>GetHLSStreamingSessionURL</c> and <c>GetDASHStreamingSessionURL</c> throw this
        /// error if a session with a <c>PlaybackMode</c> of <c>ON_DEMAND</c> or <c>LIVE_REPLAY</c>is
        /// requested for a stream that has no fragments within the requested time range, or if
        /// a session with a <c>PlaybackMode</c> of <c>LIVE</c> is requested for a stream that
        /// has no fragments within the last 30 seconds.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-video-archived-media-2017-09-30/ListFragments">REST API Reference for ListFragments Operation</seealso>
        public virtual ListFragmentsResponse ListFragments(ListFragmentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFragmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFragmentsResponseUnmarshaller.Instance;

            return Invoke<ListFragmentsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of <a>Fragment</a> objects from the specified stream and timestamp
        /// range within the archived data.
        /// 
        ///  
        /// <para>
        /// Listing fragments is eventually consistent. This means that even if the producer receives
        /// an acknowledgment that a fragment is persisted, the result might not be returned immediately
        /// from a request to <c>ListFragments</c>. However, results are typically available in
        /// less than one second.
        /// </para>
        ///  <note> 
        /// <para>
        /// You must first call the <c>GetDataEndpoint</c> API to get an endpoint. Then send the
        /// <c>ListFragments</c> requests to this endpoint using the <a href="https://docs.aws.amazon.com/cli/latest/reference/">--endpoint-url
        /// parameter</a>. 
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// If an error is thrown after invoking a Kinesis Video Streams archived media API, in
        /// addition to the HTTP status code and the response body, it includes the following
        /// pieces of information: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>x-amz-ErrorType</c> HTTP header – contains a more specific error type in addition
        /// to what the HTTP status code provides. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>x-amz-RequestId</c> HTTP header – if you want to report an issue to Amazon Web
        /// Services, the support team can better diagnose the problem if given the Request Id.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Both the HTTP status code and the ErrorType header can be utilized to make programmatic
        /// decisions about whether errors are retry-able and under what conditions, as well as
        /// provide information on what actions the client programmer might need to take in order
        /// to successfully try again.
        /// </para>
        ///  
        /// <para>
        /// For more information, see the <b>Errors</b> section at the bottom of this topic, as
        /// well as <a href="https://docs.aws.amazon.com/kinesisvideostreams/latest/dg/CommonErrors.html">Common
        /// Errors</a>. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFragments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFragments service method, as returned by KinesisVideoArchivedMedia.</returns>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded a limit.
        /// Try making the call later. For information about limits, see <a href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/limits.html">Kinesis
        /// Video Streams Limits</a>.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.NotAuthorizedException">
        /// Status Code: 403, The caller is not authorized to perform an operation on the given
        /// stream, or the token has expired.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.ResourceNotFoundException">
        /// <c>GetImages</c> will throw this error when Kinesis Video Streams can't find the
        /// stream that you specified.
        /// 
        ///  
        /// <para>
        ///  <c>GetHLSStreamingSessionURL</c> and <c>GetDASHStreamingSessionURL</c> throw this
        /// error if a session with a <c>PlaybackMode</c> of <c>ON_DEMAND</c> or <c>LIVE_REPLAY</c>is
        /// requested for a stream that has no fragments within the requested time range, or if
        /// a session with a <c>PlaybackMode</c> of <c>LIVE</c> is requested for a stream that
        /// has no fragments within the last 30 seconds.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-video-archived-media-2017-09-30/ListFragments">REST API Reference for ListFragments Operation</seealso>
        public virtual Task<ListFragmentsResponse> ListFragmentsAsync(ListFragmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFragmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFragmentsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListFragmentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}