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
    /// Container for the parameters to the UpdateChannel operation.
    /// Updates a channel's configuration. Live channels cannot be updated. You must stop
    /// the ongoing stream, update the channel, and restart the stream for the changes to
    /// take effect.
    /// </summary>
    public partial class UpdateChannelRequest : AmazonIVSRequest
    {
        private string _arn;
        private bool? _authorized;
        private bool? _insecureIngest;
        private ChannelLatencyMode _latencyMode;
        private string _name;
        private TranscodePreset _preset;
        private string _recordingConfigurationArn;
        private ChannelType _type;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// ARN of the channel to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Whether the channel is private (enabled for playback authorization).
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
        /// up to Full HD. Use <code>LOW</code> for near-real-time interaction with viewers. (Note:
        /// In the Amazon IVS console, <code>LOW</code> and <code>NORMAL</code> correspond to
        /// Ultra-low and Standard, respectively.)
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
        /// Gets and sets the property Preset. 
        /// <para>
        /// Optional transcode preset for the channel. This is selectable only for <code>ADVANCED_HD</code>
        /// and <code>ADVANCED_SD</code> channel types. For those channel types, the default <code>preset</code>
        /// is <code>HIGHER_BANDWIDTH_DELIVERY</code>. For other channel types (<code>BASIC</code>
        /// and <code>STANDARD</code>), <code>preset</code> is the empty string (<code>""</code>).
        /// </para>
        /// </summary>
        public TranscodePreset Preset
        {
            get { return this._preset; }
            set { this._preset = value; }
        }

        // Check to see if Preset property is set
        internal bool IsSetPreset()
        {
            return this._preset != null;
        }

        /// <summary>
        /// Gets and sets the property RecordingConfigurationArn. 
        /// <para>
        /// Recording-configuration ARN. If this is set to an empty string, recording is disabled.
        /// A value other than an empty string indicates that recording is enabled
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
        /// Gets and sets the property Type. 
        /// <para>
        /// Channel type, which determines the allowable resolution and bitrate. <i>If you exceed
        /// the allowable input resolution or bitrate, the stream probably will disconnect immediately.</i>
        /// Some types generate multiple qualities (renditions) from the original input; this
        /// automatically gives viewers the best experience for their devices and network conditions.
        /// Some types provide transcoded video; transcoding allows higher playback quality across
        /// a range of download speeds. Default: <code>STANDARD</code>. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>BASIC</code>: Video is transmuxed: Amazon IVS delivers the original input quality
        /// to viewers. The viewer’s video-quality choice is limited to the original input. Input
        /// resolution can be up to 1080p and bitrate can be up to 1.5 Mbps for 480p and up to
        /// 3.5 Mbps for resolutions between 480p and 1080p. Original audio is passed through.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>STANDARD</code>: Video is transcoded: multiple qualities are generated from
        /// the original input, to automatically give viewers the best experience for their devices
        /// and network conditions. Transcoding allows higher playback quality across a range
        /// of download speeds. Resolution can be up to 1080p and bitrate can be up to 8.5 Mbps.
        /// Audio is transcoded only for renditions 360p and below; above that, audio is passed
        /// through. This is the default when you create a channel.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ADVANCED_SD</code>: Video is transcoded; multiple qualities are generated from
        /// the original input, to automatically give viewers the best experience for their devices
        /// and network conditions. Input resolution can be up to 1080p and bitrate can be up
        /// to 8.5 Mbps; output is capped at SD quality (480p). You can select an optional transcode
        /// preset (see below). Audio for all renditions is transcoded, and an audio-only rendition
        /// is available.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ADVANCED_HD</code>: Video is transcoded; multiple qualities are generated from
        /// the original input, to automatically give viewers the best experience for their devices
        /// and network conditions. Input resolution can be up to 1080p and bitrate can be up
        /// to 8.5 Mbps; output is capped at HD quality (720p). You can select an optional transcode
        /// preset (see below). Audio for all renditions is transcoded, and an audio-only rendition
        /// is available.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Optional <i>transcode presets</i> (available for the <code>ADVANCED</code> types)
        /// allow you to trade off available download bandwidth and video quality, to optimize
        /// the viewing experience. There are two presets:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Constrained bandwidth delivery</i> uses a lower bitrate for each quality level.
        /// Use it if you have low download bandwidth and/or simple video content (e.g., talking
        /// heads)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Higher bandwidth delivery</i> uses a higher bitrate for each quality level. Use
        /// it if you have high download bandwidth and/or complex video content (e.g., flashes
        /// and quick scene changes).
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