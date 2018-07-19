/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisVideoArchivedMedia.Model
{
    /// <summary>
    /// Container for the parameters to the GetHLSStreamingSessionURL operation.
    /// Retrieves an HTTP Live Streaming (HLS) URL for the stream. You can then open the URL
    /// in a browser or media player to view the stream contents.
    /// 
    ///  
    /// <para>
    /// You must specify either the <code>StreamName</code> or the <code>StreamARN</code>.
    /// </para>
    ///  
    /// <para>
    /// An Amazon Kinesis video stream has the following requirements for providing data through
    /// HLS:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The media type must be <code>video/h264</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Data retention must be greater than 0.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The fragments must contain codec private data in the AVC (Advanced Video Coding) for
    /// H.264 format (<a href="https://www.iso.org/standard/55980.html">MPEG-4 specification
    /// ISO/IEC 14496-15</a>). For information about adapting stream data to a given format,
    /// see <a href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/latest/dg/producer-reference-nal.html">NAL
    /// Adaptation Flags</a>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Kinesis Video Streams HLS sessions contain fragments in the fragmented MPEG-4 form
    /// (also called fMP4 or CMAF), rather than the MPEG-2 form (also called TS chunks, which
    /// the HLS specification also supports). For more information about HLS fragment types,
    /// see the <a href="https://tools.ietf.org/html/draft-pantos-http-live-streaming-23">HLS
    /// specification</a>.
    /// </para>
    ///  
    /// <para>
    /// The following procedure shows how to use HLS with Kinesis Video Streams:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Get an endpoint using <a href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/API_GetDataEndpoint.html">GetDataEndpoint</a>,
    /// specifying <code>GET_HLS_STREAMING_SESSION_URL</code> for the <code>APIName</code>
    /// parameter.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Retrieve the HLS URL using <code>GetHLSStreamingSessionURL</code>. Kinesis Video Streams
    /// creates an HLS streaming session to be used for accessing content in a stream using
    /// the HLS protocol. <code>GetHLSStreamingSessionURL</code> returns an authenticated
    /// URL (that includes an encrypted session token) for the session's HLS <i>master playlist</i>
    /// (the root resource needed for streaming with HLS).
    /// </para>
    ///  <note> 
    /// <para>
    /// Don't share or store this token where an unauthorized entity could access it. The
    /// token provides access to the content of the stream. Safeguard the token with the same
    /// measures that you would use with your AWS credentials.
    /// </para>
    ///  </note> 
    /// <para>
    /// The media that is made available through the playlist consists only of the requested
    /// stream, time range, and format. No other media data (such as frames outside the requested
    /// window or alternate bit rates) is made available.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Provide the URL (containing the encrypted session token) for the HLS master playlist
    /// to a media player that supports the HLS protocol. Kinesis Video Streams makes the
    /// HLS media playlist, initialization fragment, and media fragments available through
    /// the master playlist URL. The initialization fragment contains the codec private data
    /// for the stream, and other data needed to set up the video decoder and renderer. The
    /// media fragments contain H.264-encoded video frames and time stamps.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The media player receives the authenticated URL and requests stream metadata and media
    /// data normally. When the media player requests data, it calls the following actions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>GetHLSMasterPlaylist:</b> Retrieves an HLS master playlist, which contains a URL
    /// for the <code>GetHLSMediaPlaylist</code> action, and additional metadata for the media
    /// player, including estimated bit rate and resolution.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>GetHLSMediaPlaylist:</b> Retrieves an HLS media playlist, which contains a URL
    /// to access the MP4 initialization fragment with the <code>GetMP4InitFragment</code>
    /// action, and URLs to access the MP4 media fragments with the <code>GetMP4MediaFragment</code>
    /// actions. The HLS media playlist also contains metadata about the stream that the player
    /// needs to play it, such as whether the <code>PlaybackMode</code> is <code>LIVE</code>
    /// or <code>ON_DEMAND</code>. The HLS media playlist is typically static for sessions
    /// with a <code>PlaybackType</code> of <code>ON_DEMAND</code>. The HLS media playlist
    /// is continually updated with new fragments for sessions with a <code>PlaybackType</code>
    /// of <code>LIVE</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>GetMP4InitFragment:</b> Retrieves the MP4 initialization fragment. The media player
    /// typically loads the initialization fragment before loading any media fragments. This
    /// fragment contains the "<code>fytp</code>" and "<code>moov</code>" MP4 atoms, and the
    /// child atoms that are needed to initialize the media player decoder.
    /// </para>
    ///  
    /// <para>
    /// The initialization fragment does not correspond to a fragment in a Kinesis video stream.
    /// It contains only the codec private data for the stream, which the media player needs
    /// to decode video frames.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>GetMP4MediaFragment:</b> Retrieves MP4 media fragments. These fragments contain
    /// the "<code>moof</code>" and "<code>mdat</code>" MP4 atoms and their child atoms, containing
    /// the encoded fragment's video frames and their time stamps. 
    /// </para>
    ///  <note> 
    /// <para>
    /// After the first media fragment is made available in a streaming session, any fragments
    /// that don't contain the same codec private data are excluded in the HLS media playlist.
    /// Therefore, the codec private data does not change between fragments in a session.
    /// </para>
    ///  </note> 
    /// <para>
    /// Data retrieved with this action is billable. See <a href="aws.amazon.comkinesis/video-streams/pricing/">Pricing</a>
    /// for details.
    /// </para>
    ///  </li> </ul> </li> </ol> <note> 
    /// <para>
    /// The following restrictions apply to HLS sessions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// A streaming session URL should not be shared between players. The service might throttle
    /// a session if multiple media players are sharing it. For connection limits, see <a
    /// href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/limits.html">Kinesis
    /// Video Streams Limits</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A Kinesis video stream can have a maximum of five active HLS streaming sessions. If
    /// a new session is created when the maximum number of sessions is already active, the
    /// oldest (earliest created) session is closed. The number of active <code>GetMedia</code>
    /// connections on a Kinesis video stream does not count against this limit, and the number
    /// of active HLS sessions does not count against the active <code>GetMedia</code> connection
    /// limit.
    /// </para>
    ///  </li> </ul> </note> 
    /// <para>
    /// You can monitor the amount of data that the media player consumes by monitoring the
    /// <code>GetMP4MediaFragment.OutgoingBytes</code> Amazon CloudWatch metric. For information
    /// about using CloudWatch to monitor Kinesis Video Streams, see <a href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/monitoring.html">Monitoring
    /// Kinesis Video Streams</a>. For pricing information, see <a href="https://aws.amazon.com/kinesis/video-streams/pricing/">Amazon
    /// Kinesis Video Streams Pricing</a> and <a href="https://aws.amazon.com/pricing/">AWS
    /// Pricing</a>. Charges for both HLS sessions and outgoing AWS data apply.
    /// </para>
    ///  
    /// <para>
    /// For more information about HLS, see <a href="https://developer.apple.com/streaming/">HTTP
    /// Live Streaming</a> on the <a href="https://developer.apple.com">Apple Developer site</a>.
    /// </para>
    /// </summary>
    public partial class GetHLSStreamingSessionURLRequest : AmazonKinesisVideoArchivedMediaRequest
    {
        private DiscontinuityMode _discontinuityMode;
        private int? _expires;
        private HLSFragmentSelector _hlsFragmentSelector;
        private long? _maxMediaPlaylistFragmentResults;
        private PlaybackMode _playbackMode;
        private string _streamARN;
        private string _streamName;

        /// <summary>
        /// Gets and sets the property DiscontinuityMode. 
        /// <para>
        /// Specifies when flags marking discontinuities between fragments will be added to the
        /// media playlists. The default is <code>ALWAYS</code> when <a>HLSFragmentSelector</a>
        /// is <code>SERVER_TIMESTAMP</code>, and <code>NEVER</code> when it is <code>PRODUCER_TIMESTAMP</code>.
        /// </para>
        ///  
        /// <para>
        /// Media players typically build a timeline of media content to play, based on the time
        /// stamps of each fragment. This means that if there is any overlap between fragments
        /// (as is typical if <a>HLSFragmentSelector</a> is <code>SERVER_TIMESTAMP</code>), the
        /// media player timeline has small gaps between fragments in some places, and overwrites
        /// frames in other places. When there are discontinuity flags between fragments, the
        /// media player is expected to reset the timeline, resulting in the fragment being played
        /// immediately after the previous fragment. We recommend that you always have discontinuity
        /// flags between fragments if the fragment time stamps are not accurate or if fragments
        /// might be missing. You should not place discontinuity flags between fragments for the
        /// player timeline to accurately map to the producer time stamps.
        /// </para>
        /// </summary>
        public DiscontinuityMode DiscontinuityMode
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
        /// Gets and sets the property Expires. 
        /// <para>
        /// The time in seconds until the requested session expires. This value can be between
        /// 300 (5 minutes) and 43200 (12 hours).
        /// </para>
        ///  
        /// <para>
        /// When a session expires, no new calls to <code>GetHLSMasterPlaylist</code>, <code>GetHLSMediaPlaylist</code>,
        /// <code>GetMP4InitFragment</code>, or <code>GetMP4MediaFragment</code> can be made for
        /// that session.
        /// </para>
        ///  
        /// <para>
        /// The default is 300 (5 minutes).
        /// </para>
        /// </summary>
        public int Expires
        {
            get { return this._expires.GetValueOrDefault(); }
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
        /// The time range of the requested fragment, and the source of the time stamps.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required if <code>PlaybackMode</code> is <code>ON_DEMAND</code>.
        /// This parameter is optional if <code>PlaybackMode</code> is <code>LIVE</code>. If <code>PlaybackMode</code>
        /// is <code>LIVE</code>, the <code>FragmentSelectorType</code> can be set, but the <code>TimestampRange</code>
        /// should not be set. If <code>PlaybackMode</code> is <code>ON_DEMAND</code>, both <code>FragmentSelectorType</code>
        /// and <code>TimestampRange</code> must be set.
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
        /// When the <code>PlaybackMode</code> is <code>LIVE</code>, the most recent fragments
        /// are returned up to this value. When the <code>PlaybackMode</code> is <code>ON_DEMAND</code>,
        /// the oldest fragments are returned, up to this maximum number.
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
        /// The default is 5 fragments if <code>PlaybackMode</code> is <code>LIVE</code>, and
        /// 1,000 if <code>PlaybackMode</code> is <code>ON_DEMAND</code>. 
        /// </para>
        ///  
        /// <para>
        /// The maximum value of 1,000 fragments corresponds to more than 16 minutes of video
        /// on streams with 1-second fragments, and more than 2 1/2 hours of video on streams
        /// with 10-second fragments.
        /// </para>
        /// </summary>
        public long MaxMediaPlaylistFragmentResults
        {
            get { return this._maxMediaPlaylistFragmentResults.GetValueOrDefault(); }
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
        /// Whether to retrieve live or archived, on-demand data.
        /// </para>
        ///  
        /// <para>
        /// Features of the two types of session include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <code>LIVE</code> </b>: For sessions of this type, the HLS media playlist is
        /// continually updated with the latest fragments as they become available. We recommend
        /// that the media player retrieve a new playlist on a one-second interval. When this
        /// type of session is played in a media player, the user interface typically displays
        /// a "live" notification, with no scrubber control for choosing the position in the playback
        /// window to display.
        /// </para>
        ///  <note> 
        /// <para>
        /// In <code>LIVE</code> mode, the newest available fragments are included in an HLS media
        /// playlist, even if there is a gap between fragments (that is, if a fragment is missing).
        /// A gap like this might cause a media player to halt or cause a jump in playback. In
        /// this mode, fragments are not added to the HLS media playlist if they are older than
        /// the newest fragment in the playlist. If the missing fragment becomes available after
        /// a subsequent fragment is added to the playlist, the older fragment is not added, and
        /// the gap is not filled.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <b> <code>ON_DEMAND</code> </b>: For sessions of this type, the HLS media playlist
        /// contains all the fragments for the session, up to the number that is specified in
        /// <code>MaxMediaPlaylistFragmentResults</code>. The playlist must be retrieved only
        /// once for each session. When this type of session is played in a media player, the
        /// user interface typically displays a scrubber control for choosing the position in
        /// the playback window to display.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// In both playback modes, if <code>FragmentSelectorType</code> is <code>PRODUCER_TIMESTAMP</code>,
        /// and if there are multiple fragments with the same start time stamp, the fragment that
        /// has the larger fragment number (that is, the newer fragment) is included in the HLS
        /// media playlist. The other fragments are not included. Fragments that have different
        /// time stamps but have overlapping durations are still included in the HLS media playlist.
        /// This can lead to unexpected behavior in the media player.
        /// </para>
        ///  
        /// <para>
        /// The default is <code>LIVE</code>.
        /// </para>
        /// </summary>
        public PlaybackMode PlaybackMode
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
        /// You must specify either the <code>StreamName</code> or the <code>StreamARN</code>.
        /// </para>
        /// </summary>
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
        /// You must specify either the <code>StreamName</code> or the <code>StreamARN</code>.
        /// </para>
        /// </summary>
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