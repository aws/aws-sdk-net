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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.KinesisVideoArchivedMedia.Model
{
    /// <summary>
    /// Container for the parameters to the GetHLSStreamingSessionURL operation.
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
    public partial class GetHLSStreamingSessionURLRequest : AmazonKinesisVideoArchivedMediaRequest
    {
        private ContainerFormat _containerFormat;
        private HLSDiscontinuityMode _discontinuityMode;
        private HLSDisplayFragmentTimestamp _displayFragmentTimestamp;
        private int? _expires;
        private HLSFragmentSelector _hlsFragmentSelector;
        private long? _maxMediaPlaylistFragmentResults;
        private HLSPlaybackMode _playbackMode;
        private string _streamARN;
        private string _streamName;

        /// <summary>
        /// Gets and sets the property ContainerFormat. 
        /// <para>
        /// Specifies which format should be used for packaging the media. Specifying the <c>FRAGMENTED_MP4</c>
        /// container format packages the media into MP4 fragments (fMP4 or CMAF). This is the
        /// recommended packaging because there is minimal packaging overhead. The other container
        /// format option is <c>MPEG_TS</c>. HLS has supported MPEG TS chunks since it was released
        /// and is sometimes the only supported packaging on older HLS players. MPEG TS typically
        /// has a 5-25 percent packaging overhead. This means MPEG TS typically requires 5-25
        /// percent more bandwidth and cost than fMP4.
        /// </para>
        ///  
        /// <para>
        /// The default is <c>FRAGMENTED_MP4</c>.
        /// </para>
        /// </summary>
        public ContainerFormat ContainerFormat
        {
            get { return this._containerFormat; }
            set { this._containerFormat = value; }
        }

        // Check to see if ContainerFormat property is set
        internal bool IsSetContainerFormat()
        {
            return this._containerFormat != null;
        }

        /// <summary>
        /// Gets and sets the property DiscontinuityMode. 
        /// <para>
        /// Specifies when flags marking discontinuities between fragments are added to the media
        /// playlists.
        /// </para>
        ///  
        /// <para>
        /// Media players typically build a timeline of media content to play, based on the timestamps
        /// of each fragment. This means that if there is any overlap or gap between fragments
        /// (as is typical if <a>HLSFragmentSelector</a> is set to <c>SERVER_TIMESTAMP</c>), the
        /// media player timeline will also have small gaps between fragments in some places,
        /// and will overwrite frames in other places. Gaps in the media player timeline can cause
        /// playback to stall and overlaps can cause playback to be jittery. When there are discontinuity
        /// flags between fragments, the media player is expected to reset the timeline, resulting
        /// in the next fragment being played immediately after the previous fragment. 
        /// </para>
        ///  
        /// <para>
        /// The following modes are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ALWAYS</c>: a discontinuity marker is placed between every fragment in the HLS
        /// media playlist. It is recommended to use a value of <c>ALWAYS</c> if the fragment
        /// timestamps are not accurate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NEVER</c>: no discontinuity markers are placed anywhere. It is recommended to
        /// use a value of <c>NEVER</c> to ensure the media player timeline most accurately maps
        /// to the producer timestamps. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ON_DISCONTINUITY</c>: a discontinuity marker is placed between fragments that
        /// have a gap or overlap of more than 50 milliseconds. For most playback scenarios, it
        /// is recommended to use a value of <c>ON_DISCONTINUITY</c> so that the media player
        /// timeline is only reset when there is a significant issue with the media timeline (e.g.
        /// a missing fragment).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The default is <c>ALWAYS</c> when <a>HLSFragmentSelector</a> is set to <c>SERVER_TIMESTAMP</c>,
        /// and <c>NEVER</c> when it is set to <c>PRODUCER_TIMESTAMP</c>.
        /// </para>
        /// </summary>
        public HLSDiscontinuityMode DiscontinuityMode
        {
            get { return this._discontinuityMode; }
            set { this._discontinuityMode = value; }
        }

        // Check to see if DiscontinuityMode property is set
        internal bool IsSetDiscontinuityMode()
        {
            return this._discontinuityMode != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayFragmentTimestamp. 
        /// <para>
        /// Specifies when the fragment start timestamps should be included in the HLS media playlist.
        /// Typically, media players report the playhead position as a time relative to the start
        /// of the first fragment in the playback session. However, when the start timestamps
        /// are included in the HLS media playlist, some media players might report the current
        /// playhead as an absolute time based on the fragment timestamps. This can be useful
        /// for creating a playback experience that shows viewers the wall-clock time of the media.
        /// </para>
        ///  
        /// <para>
        /// The default is <c>NEVER</c>. When <a>HLSFragmentSelector</a> is <c>SERVER_TIMESTAMP</c>,
        /// the timestamps will be the server start timestamps. Similarly, when <a>HLSFragmentSelector</a>
        /// is <c>PRODUCER_TIMESTAMP</c>, the timestamps will be the producer start timestamps.
        /// 
        /// </para>
        /// </summary>
        public HLSDisplayFragmentTimestamp DisplayFragmentTimestamp
        {
            get { return this._displayFragmentTimestamp; }
            set { this._displayFragmentTimestamp = value; }
        }

        // Check to see if DisplayFragmentTimestamp property is set
        internal bool IsSetDisplayFragmentTimestamp()
        {
            return this._displayFragmentTimestamp != null;
        }

        /// <summary>
        /// Gets and sets the property Expires. 
        /// <para>
        /// The time in seconds until the requested session expires. This value can be between
        /// 300 (5 minutes) and 43200 (12 hours).
        /// </para>
        ///  
        /// <para>
        /// When a session expires, no new calls to <c>GetHLSMasterPlaylist</c>, <c>GetHLSMediaPlaylist</c>,
        /// <c>GetMP4InitFragment</c>, <c>GetMP4MediaFragment</c>, or <c>GetTSFragment</c> can
        /// be made for that session.
        /// </para>
        ///  
        /// <para>
        /// The default is 300 (5 minutes).
        /// </para>
        /// </summary>
        [AWSProperty(Min=300, Max=43200)]
        public int? Expires
        {
            get { return this._expires; }
            set { this._expires = value; }
        }

        // Check to see if Expires property is set
        internal bool IsSetExpires()
        {
            return this._expires.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HLSFragmentSelector. 
        /// <para>
        /// The time range of the requested fragment and the source of the timestamps.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required if <c>PlaybackMode</c> is <c>ON_DEMAND</c> or <c>LIVE_REPLAY</c>.
        /// This parameter is optional if PlaybackMode is<code/> <c>LIVE</c>. If <c>PlaybackMode</c>
        /// is <c>LIVE</c>, the <c>FragmentSelectorType</c> can be set, but the <c>TimestampRange</c>
        /// should not be set. If <c>PlaybackMode</c> is <c>ON_DEMAND</c> or <c>LIVE_REPLAY</c>,
        /// both <c>FragmentSelectorType</c> and <c>TimestampRange</c> must be set.
        /// </para>
        /// </summary>
        public HLSFragmentSelector HLSFragmentSelector
        {
            get { return this._hlsFragmentSelector; }
            set { this._hlsFragmentSelector = value; }
        }

        // Check to see if HLSFragmentSelector property is set
        internal bool IsSetHLSFragmentSelector()
        {
            return this._hlsFragmentSelector != null;
        }

        /// <summary>
        /// Gets and sets the property MaxMediaPlaylistFragmentResults. 
        /// <para>
        /// The maximum number of fragments that are returned in the HLS media playlists.
        /// </para>
        ///  
        /// <para>
        /// When the <c>PlaybackMode</c> is <c>LIVE</c>, the most recent fragments are returned
        /// up to this value. When the <c>PlaybackMode</c> is <c>ON_DEMAND</c>, the oldest fragments
        /// are returned, up to this maximum number.
        /// </para>
        ///  
        /// <para>
        /// When there are a higher number of fragments available in a live HLS media playlist,
        /// video players often buffer content before starting playback. Increasing the buffer
        /// size increases the playback latency, but it decreases the likelihood that rebuffering
        /// will occur during playback. We recommend that a live HLS media playlist have a minimum
        /// of 3 fragments and a maximum of 10 fragments.
        /// </para>
        ///  
        /// <para>
        /// The default is 5 fragments if <c>PlaybackMode</c> is <c>LIVE</c> or <c>LIVE_REPLAY</c>,
        /// and 1,000 if <c>PlaybackMode</c> is <c>ON_DEMAND</c>. 
        /// </para>
        ///  
        /// <para>
        /// The maximum value of 5,000 fragments corresponds to more than 80 minutes of video
        /// on streams with 1-second fragments, and more than 13 hours of video on streams with
        /// 10-second fragments.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5000)]
        public long? MaxMediaPlaylistFragmentResults
        {
            get { return this._maxMediaPlaylistFragmentResults; }
            set { this._maxMediaPlaylistFragmentResults = value; }
        }

        // Check to see if MaxMediaPlaylistFragmentResults property is set
        internal bool IsSetMaxMediaPlaylistFragmentResults()
        {
            return this._maxMediaPlaylistFragmentResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PlaybackMode. 
        /// <para>
        /// Whether to retrieve live, live replay, or archived, on-demand data.
        /// </para>
        ///  
        /// <para>
        /// Features of the three types of sessions include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <c>LIVE</c> </b>: For sessions of this type, the HLS media playlist is continually
        /// updated with the latest fragments as they become available. We recommend that the
        /// media player retrieve a new playlist on a one-second interval. When this type of session
        /// is played in a media player, the user interface typically displays a "live" notification,
        /// with no scrubber control for choosing the position in the playback window to display.
        /// </para>
        ///  <note> 
        /// <para>
        /// In <c>LIVE</c> mode, the newest available fragments are included in an HLS media playlist,
        /// even if there is a gap between fragments (that is, if a fragment is missing). A gap
        /// like this might cause a media player to halt or cause a jump in playback. In this
        /// mode, fragments are not added to the HLS media playlist if they are older than the
        /// newest fragment in the playlist. If the missing fragment becomes available after a
        /// subsequent fragment is added to the playlist, the older fragment is not added, and
        /// the gap is not filled.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <b> <c>LIVE_REPLAY</c> </b>: For sessions of this type, the HLS media playlist is
        /// updated similarly to how it is updated for <c>LIVE</c> mode except that it starts
        /// by including fragments from a given start time. Instead of fragments being added as
        /// they are ingested, fragments are added as the duration of the next fragment elapses.
        /// For example, if the fragments in the session are two seconds long, then a new fragment
        /// is added to the media playlist every two seconds. This mode is useful to be able to
        /// start playback from when an event is detected and continue live streaming media that
        /// has not yet been ingested as of the time of the session creation. This mode is also
        /// useful to stream previously archived media without being limited by the 1,000 fragment
        /// limit in the <c>ON_DEMAND</c> mode. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>ON_DEMAND</c> </b>: For sessions of this type, the HLS media playlist contains
        /// all the fragments for the session, up to the number that is specified in <c>MaxMediaPlaylistFragmentResults</c>.
        /// The playlist must be retrieved only once for each session. When this type of session
        /// is played in a media player, the user interface typically displays a scrubber control
        /// for choosing the position in the playback window to display.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// In all playback modes, if <c>FragmentSelectorType</c> is <c>PRODUCER_TIMESTAMP</c>,
        /// and if there are multiple fragments with the same start timestamp, the fragment that
        /// has the largest fragment number (that is, the newest fragment) is included in the
        /// HLS media playlist. The other fragments are not included. Fragments that have different
        /// timestamps but have overlapping durations are still included in the HLS media playlist.
        /// This can lead to unexpected behavior in the media player.
        /// </para>
        ///  
        /// <para>
        /// The default is <c>LIVE</c>.
        /// </para>
        /// </summary>
        public HLSPlaybackMode PlaybackMode
        {
            get { return this._playbackMode; }
            set { this._playbackMode = value; }
        }

        // Check to see if PlaybackMode property is set
        internal bool IsSetPlaybackMode()
        {
            return this._playbackMode != null;
        }

        /// <summary>
        /// Gets and sets the property StreamARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the stream for which to retrieve the HLS master
        /// playlist URL.
        /// </para>
        ///  
        /// <para>
        /// You must specify either the <c>StreamName</c> or the <c>StreamARN</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string StreamARN
        {
            get { return this._streamARN; }
            set { this._streamARN = value; }
        }

        // Check to see if StreamARN property is set
        internal bool IsSetStreamARN()
        {
            return this._streamARN != null;
        }

        /// <summary>
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The name of the stream for which to retrieve the HLS master playlist URL.
        /// </para>
        ///  
        /// <para>
        /// You must specify either the <c>StreamName</c> or the <c>StreamARN</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string StreamName
        {
            get { return this._streamName; }
            set { this._streamName = value; }
        }

        // Check to see if StreamName property is set
        internal bool IsSetStreamName()
        {
            return this._streamName != null;
        }

    }
}