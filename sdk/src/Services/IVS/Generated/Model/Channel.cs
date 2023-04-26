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
 * Do not modify this file. This file is generated from the ivs-2020-07-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IVS.Model
{
    /// <summary>
    /// Object specifying a channel.
    /// </summary>
    public partial class Channel
    {
        private string _arn;
        private bool? _authorized;
        private string _ingestEndpoint;
        private bool? _insecureIngest;
        private ChannelLatencyMode _latencyMode;
        private string _name;
        private string _playbackUrl;
        private string _recordingConfigurationArn;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private ChannelType _type;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Channel ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Authorized. 
        /// <para>
        /// Whether the channel is private (enabled for playback authorization). Default: <code>false</code>.
        /// </para>
        /// </summary>
        public bool Authorized
        {
            get { return this._authorized.GetValueOrDefault(); }
            set { this._authorized = value; }
        }

        // Check to see if Authorized property is set
        internal bool IsSetAuthorized()
        {
            return this._authorized.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IngestEndpoint. 
        /// <para>
        /// Channel ingest endpoint, part of the definition of an ingest server, used when you
        /// set up streaming software.
        /// </para>
        /// </summary>
        public string IngestEndpoint
        {
            get { return this._ingestEndpoint; }
            set { this._ingestEndpoint = value; }
        }

        // Check to see if IngestEndpoint property is set
        internal bool IsSetIngestEndpoint()
        {
            return this._ingestEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property InsecureIngest. 
        /// <para>
        /// Whether the channel allows insecure RTMP ingest. Default: <code>false</code>.
        /// </para>
        /// </summary>
        public bool InsecureIngest
        {
            get { return this._insecureIngest.GetValueOrDefault(); }
            set { this._insecureIngest = value; }
        }

        // Check to see if InsecureIngest property is set
        internal bool IsSetInsecureIngest()
        {
            return this._insecureIngest.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatencyMode. 
        /// <para>
        /// Channel latency mode. Use <code>NORMAL</code> to broadcast and deliver live video
        /// up to Full HD. Use <code>LOW</code> for near-real-time interaction with viewers. Default:
        /// <code>LOW</code>. (Note: In the Amazon IVS console, <code>LOW</code> and <code>NORMAL</code>
        /// correspond to Ultra-low and Standard, respectively.)
        /// </para>
        /// </summary>
        public ChannelLatencyMode LatencyMode
        {
            get { return this._latencyMode; }
            set { this._latencyMode = value; }
        }

        // Check to see if LatencyMode property is set
        internal bool IsSetLatencyMode()
        {
            return this._latencyMode != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Channel name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PlaybackUrl. 
        /// <para>
        /// Channel playback URL.
        /// </para>
        /// </summary>
        public string PlaybackUrl
        {
            get { return this._playbackUrl; }
            set { this._playbackUrl = value; }
        }

        // Check to see if PlaybackUrl property is set
        internal bool IsSetPlaybackUrl()
        {
            return this._playbackUrl != null;
        }

        /// <summary>
        /// Gets and sets the property RecordingConfigurationArn. 
        /// <para>
        /// Recording-configuration ARN. A value other than an empty string indicates that recording
        /// is enabled. Default: "" (empty string, recording is disabled).
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string RecordingConfigurationArn
        {
            get { return this._recordingConfigurationArn; }
            set { this._recordingConfigurationArn = value; }
        }

        // Check to see if RecordingConfigurationArn property is set
        internal bool IsSetRecordingConfigurationArn()
        {
            return this._recordingConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags attached to the resource. Array of 1-50 maps, each of the form <code>string:string
        /// (key:value)</code>. See <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services Resources</a> for more information, including restrictions that
        /// apply to tags and "Tag naming limits and requirements"; Amazon IVS has no service-specific
        /// constraints beyond what is documented there.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Channel type, which determines the allowable resolution and bitrate. <i>If you exceed
        /// the allowable resolution or bitrate, the stream probably will disconnect immediately.</i>
        /// Default: <code>STANDARD</code>. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>STANDARD</code>: Video is transcoded: multiple qualities are generated from
        /// the original input, to automatically give viewers the best experience for their devices
        /// and network conditions. Transcoding allows higher playback quality across a range
        /// of download speeds. Resolution can be up to 1080p and bitrate can be up to 8.5 Mbps.
        /// Audio is transcoded only for renditions 360p and below; above that, audio is passed
        /// through. This is the default.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>BASIC</code>: Video is transmuxed: Amazon IVS delivers the original input to
        /// viewers. The viewer’s video-quality choice is limited to the original input. Resolution
        /// can be up to 1080p and bitrate can be up to 1.5 Mbps for 480p and up to 3.5 Mbps for
        /// resolutions between 480p and 1080p.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ChannelType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}