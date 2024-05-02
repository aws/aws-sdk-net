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
    /// Container for the parameters to the GetDASHStreamingSessionURL operation.
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
    public partial class GetDASHStreamingSessionURLRequest : AmazonKinesisVideoArchivedMediaRequest
    {
        private DASHFragmentSelector _dashFragmentSelector;
        private DASHDisplayFragmentNumber _displayFragmentNumber;
        private DASHDisplayFragmentTimestamp _displayFragmentTimestamp;
        private int? _expires;
        private long? _maxManifestFragmentResults;
        private DASHPlaybackMode _playbackMode;
        private string _streamARN;
        private string _streamName;

        /// <summary>
        /// Gets and sets the property DASHFragmentSelector. 
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
        public DASHFragmentSelector DASHFragmentSelector
        {
            get { return this._dashFragmentSelector; }
            set { this._dashFragmentSelector = value; }
        }

        // Check to see if DASHFragmentSelector property is set
        internal bool IsSetDASHFragmentSelector()
        {
            return this._dashFragmentSelector != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayFragmentNumber. 
        /// <para>
        /// Fragments are identified in the manifest file based on their sequence number in the
        /// session. If DisplayFragmentNumber is set to <c>ALWAYS</c>, the Kinesis Video Streams
        /// fragment number is added to each S element in the manifest file with the attribute
        /// name “kvs:fn”. These fragment numbers can be used for logging or for use with other
        /// APIs (e.g. <c>GetMedia</c> and <c>GetMediaForFragmentList</c>). A custom MPEG-DASH
        /// media player is necessary to leverage these this custom attribute.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>NEVER</c>.
        /// </para>
        /// </summary>
        public DASHDisplayFragmentNumber DisplayFragmentNumber
        {
            get { return this._displayFragmentNumber; }
            set { this._displayFragmentNumber = value; }
        }

        // Check to see if DisplayFragmentNumber property is set
        internal bool IsSetDisplayFragmentNumber()
        {
            return this._displayFragmentNumber != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayFragmentTimestamp. 
        /// <para>
        /// Per the MPEG-DASH specification, the wall-clock time of fragments in the manifest
        /// file can be derived using attributes in the manifest itself. However, typically, MPEG-DASH
        /// compatible media players do not properly handle gaps in the media timeline. Kinesis
        /// Video Streams adjusts the media timeline in the manifest file to enable playback of
        /// media with discontinuities. Therefore, the wall-clock time derived from the manifest
        /// file may be inaccurate. If DisplayFragmentTimestamp is set to <c>ALWAYS</c>, the accurate
        /// fragment timestamp is added to each S element in the manifest file with the attribute
        /// name “kvs:ts”. A custom MPEG-DASH media player is necessary to leverage this custom
        /// attribute.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>NEVER</c>. When <a>DASHFragmentSelector</a> is <c>SERVER_TIMESTAMP</c>,
        /// the timestamps will be the server start timestamps. Similarly, when <a>DASHFragmentSelector</a>
        /// is <c>PRODUCER_TIMESTAMP</c>, the timestamps will be the producer start timestamps.
        /// 
        /// </para>
        /// </summary>
        public DASHDisplayFragmentTimestamp DisplayFragmentTimestamp
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
        /// When a session expires, no new calls to <c>GetDashManifest</c>, <c>GetMP4InitFragment</c>,
        /// or <c>GetMP4MediaFragment</c> can be made for that session.
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
        /// Gets and sets the property MaxManifestFragmentResults. 
        /// <para>
        /// The maximum number of fragments that are returned in the MPEG-DASH manifest.
        /// </para>
        ///  
        /// <para>
        /// When the <c>PlaybackMode</c> is <c>LIVE</c>, the most recent fragments are returned
        /// up to this value. When the <c>PlaybackMode</c> is <c>ON_DEMAND</c>, the oldest fragments
        /// are returned, up to this maximum number.
        /// </para>
        ///  
        /// <para>
        /// When there are a higher number of fragments available in a live MPEG-DASH manifest,
        /// video players often buffer content before starting playback. Increasing the buffer
        /// size increases the playback latency, but it decreases the likelihood that rebuffering
        /// will occur during playback. We recommend that a live MPEG-DASH manifest have a minimum
        /// of 3 fragments and a maximum of 10 fragments.
        /// </para>
        ///  
        /// <para>
        /// The default is 5 fragments if <c>PlaybackMode</c> is <c>LIVE</c> or <c>LIVE_REPLAY</c>,
        /// and 1,000 if <c>PlaybackMode</c> is <c>ON_DEMAND</c>. 
        /// </para>
        ///  
        /// <para>
        /// The maximum value of 1,000 fragments corresponds to more than 16 minutes of video
        /// on streams with 1-second fragments, and more than 2 1/2 hours of video on streams
        /// with 10-second fragments.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5000)]
        public long? MaxManifestFragmentResults
        {
            get { return this._maxManifestFragmentResults; }
            set { this._maxManifestFragmentResults = value; }
        }

        // Check to see if MaxManifestFragmentResults property is set
        internal bool IsSetMaxManifestFragmentResults()
        {
            return this._maxManifestFragmentResults.HasValue; 
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
        ///  <b> <c>LIVE</c> </b>: For sessions of this type, the MPEG-DASH manifest is continually
        /// updated with the latest fragments as they become available. We recommend that the
        /// media player retrieve a new manifest on a one-second interval. When this type of session
        /// is played in a media player, the user interface typically displays a "live" notification,
        /// with no scrubber control for choosing the position in the playback window to display.
        /// </para>
        ///  <note> 
        /// <para>
        /// In <c>LIVE</c> mode, the newest available fragments are included in an MPEG-DASH manifest,
        /// even if there is a gap between fragments (that is, if a fragment is missing). A gap
        /// like this might cause a media player to halt or cause a jump in playback. In this
        /// mode, fragments are not added to the MPEG-DASH manifest if they are older than the
        /// newest fragment in the playlist. If the missing fragment becomes available after a
        /// subsequent fragment is added to the manifest, the older fragment is not added, and
        /// the gap is not filled.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <b> <c>LIVE_REPLAY</c> </b>: For sessions of this type, the MPEG-DASH manifest is
        /// updated similarly to how it is updated for <c>LIVE</c> mode except that it starts
        /// by including fragments from a given start time. Instead of fragments being added as
        /// they are ingested, fragments are added as the duration of the next fragment elapses.
        /// For example, if the fragments in the session are two seconds long, then a new fragment
        /// is added to the manifest every two seconds. This mode is useful to be able to start
        /// playback from when an event is detected and continue live streaming media that has
        /// not yet been ingested as of the time of the session creation. This mode is also useful
        /// to stream previously archived media without being limited by the 1,000 fragment limit
        /// in the <c>ON_DEMAND</c> mode. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>ON_DEMAND</c> </b>: For sessions of this type, the MPEG-DASH manifest contains
        /// all the fragments for the session, up to the number that is specified in <c>MaxManifestFragmentResults</c>.
        /// The manifest must be retrieved only once for each session. When this type of session
        /// is played in a media player, the user interface typically displays a scrubber control
        /// for choosing the position in the playback window to display.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// In all playback modes, if <c>FragmentSelectorType</c> is <c>PRODUCER_TIMESTAMP</c>,
        /// and if there are multiple fragments with the same start timestamp, the fragment that
        /// has the larger fragment number (that is, the newer fragment) is included in the MPEG-DASH
        /// manifest. The other fragments are not included. Fragments that have different timestamps
        /// but have overlapping durations are still included in the MPEG-DASH manifest. This
        /// can lead to unexpected behavior in the media player.
        /// </para>
        ///  
        /// <para>
        /// The default is <c>LIVE</c>.
        /// </para>
        /// </summary>
        public DASHPlaybackMode PlaybackMode
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
        /// The Amazon Resource Name (ARN) of the stream for which to retrieve the MPEG-DASH manifest
        /// URL.
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
        /// The name of the stream for which to retrieve the MPEG-DASH manifest URL.
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