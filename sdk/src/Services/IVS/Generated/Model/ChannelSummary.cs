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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.IVS.Model
{
    /// <summary>
    /// Summary information about a channel.
    /// </summary>
    public partial class ChannelSummary
    {
        private string _arn;
        private bool? _authorized;
        private bool? _insecureIngest;
        private ChannelLatencyMode _latencyMode;
        private string _name;
        private string _playbackRestrictionPolicyArn;
        private TranscodePreset _preset;
        private string _recordingConfigurationArn;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
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
        /// Whether the channel is private (enabled for playback authorization). Default: <c>false</c>.
        /// </para>
        /// </summary>
        public bool? Authorized
        {
            get { return this._authorized; }
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
        /// Whether the channel allows insecure RTMP ingest. Default: <c>false</c>.
        /// </para>
        /// </summary>
        public bool? InsecureIngest
        {
            get { return this._insecureIngest; }
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
        /// Channel latency mode. Use <c>NORMAL</c> to broadcast and deliver live video up to
        /// Full HD. Use <c>LOW</c> for near-real-time interaction with viewers. Default: <c>LOW</c>.
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
        /// Gets and sets the property PlaybackRestrictionPolicyArn. 
        /// <para>
        /// Playback-restriction-policy ARN. A valid ARN value here both specifies the ARN and
        /// enables playback restriction. Default: "" (empty string, no playback restriction policy
        /// is applied).
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string PlaybackRestrictionPolicyArn
        {
            get { return this._playbackRestrictionPolicyArn; }
            set { this._playbackRestrictionPolicyArn = value; }
        }

        // Check to see if PlaybackRestrictionPolicyArn property is set
        internal bool IsSetPlaybackRestrictionPolicyArn()
        {
            return this._playbackRestrictionPolicyArn != null;
        }

        /// <summary>
        /// Gets and sets the property Preset. 
        /// <para>
        /// Optional transcode preset for the channel. This is selectable only for <c>ADVANCED_HD</c>
        /// and <c>ADVANCED_SD</c> channel types. For those channel types, the default <c>preset</c>
        /// is <c>HIGHER_BANDWIDTH_DELIVERY</c>. For other channel types (<c>BASIC</c> and <c>STANDARD</c>),
        /// <c>preset</c> is the empty string (<c>""</c>).
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
        /// Recording-configuration ARN. A valid ARN value here both specifies the ARN and enables
        /// recording. Default: "" (empty string, recording is disabled).
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
        /// Tags attached to the resource. Array of 1-50 maps, each of the form <c>string:string
        /// (key:value)</c>. See <a href="https://docs.aws.amazon.com/tag-editor/latest/userguide/best-practices-and-strats.html">Best
        /// practices and strategies</a> in <i>Tagging Amazon Web Services Resources and Tag Editor</i>
        /// for details, including restrictions that apply to tags and "Tag naming limits and
        /// requirements"; Amazon IVS has no service-specific constraints beyond what is documented
        /// there.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Channel type, which determines the allowable resolution and bitrate. <i>If you exceed
        /// the allowable input resolution or bitrate, the stream probably will disconnect immediately.</i>
        /// Default: <c>STANDARD</c>. For details, see <a href="https://docs.aws.amazon.com/ivs/latest/LowLatencyAPIReference/channel-types.html">Channel
        /// Types</a>.
        /// </para>
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