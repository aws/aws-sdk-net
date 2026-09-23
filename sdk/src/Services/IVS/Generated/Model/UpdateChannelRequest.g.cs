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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the UpdateChannel operation. Updates a channel's configuration.
    /// Live channels cannot be updated. You must stop the ongoing stream, update the channel,
    /// and restart the stream for the changes to take effect.
    /// </summary>
    public partial class UpdateChannelRequest : AmazonIVSRequest
    {
        /// <summary>
        /// Gets and sets the property AdConfigurationArn. 
        /// <para>
        /// ARN of the ad configuration associated with the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string AdConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the AdConfigurationArn property is set.
        /// </summary>
        internal bool IsSetAdConfigurationArn() => this.AdConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// ARN of the channel to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Authorized. 
        /// <para>
        /// Whether the channel is private (enabled for playback authorization).
        /// </para>
        /// </summary>
        public bool? Authorized { get; set; }

        /// <summary>
        /// Checks to see if the Authorized property is set.
        /// </summary>
        internal bool IsSetAuthorized() => this.Authorized.HasValue;

        /// <summary>
        /// Gets and sets the property ContainerFormat. 
        /// <para>
        /// Indicates which content-packaging format is used (MPEG-TS or fMP4). If <c>multitrackInputConfiguration</c>
        /// is specified and <c>enabled</c> is <c>true</c>, then <c>containerFormat</c> is required
        /// and must be set to <c>FRAGMENTED_MP4</c>. Otherwise, <c>containerFormat</c> may be
        /// set to <c>TS</c> or <c>FRAGMENTED_MP4</c>. Default: <c>TS</c>.
        /// </para>
        /// </summary>
        public ContainerFormat ContainerFormat { get; set; }

        /// <summary>
        /// Checks to see if the ContainerFormat property is set.
        /// </summary>
        internal bool IsSetContainerFormat() => this.ContainerFormat != null;

        /// <summary>
        /// Gets and sets the property InsecureIngest. 
        /// <para>
        /// Whether the channel allows insecure RTMP and SRT ingest. Default: <c>false</c>.
        /// </para>
        /// </summary>
        public bool? InsecureIngest { get; set; }

        /// <summary>
        /// Checks to see if the InsecureIngest property is set.
        /// </summary>
        internal bool IsSetInsecureIngest() => this.InsecureIngest.HasValue;

        /// <summary>
        /// Gets and sets the property LatencyMode. 
        /// <para>
        /// Channel latency mode. Use <c>NORMAL</c> to broadcast and deliver live video up to
        /// Full HD. Use <c>LOW</c> for near-real-time interaction with viewers.
        /// </para>
        /// </summary>
        public ChannelLatencyMode LatencyMode { get; set; }

        /// <summary>
        /// Checks to see if the LatencyMode property is set.
        /// </summary>
        internal bool IsSetLatencyMode() => this.LatencyMode != null;

        /// <summary>
        /// Gets and sets the property MultitrackInputConfiguration. 
        /// <para>
        /// Object specifying multitrack input configuration. Default: no multitrack input configuration
        /// is specified.
        /// </para>
        /// </summary>
        public MultitrackInputConfiguration MultitrackInputConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the MultitrackInputConfiguration property is set.
        /// </summary>
        internal bool IsSetMultitrackInputConfiguration() => this.MultitrackInputConfiguration != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Channel name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PlaybackRestrictionPolicyArn. 
        /// <para>
        /// Playback-restriction-policy ARN. A valid ARN value here both specifies the ARN and
        /// enables playback restriction. If this is set to an empty string, playback restriction
        /// policy is disabled.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string PlaybackRestrictionPolicyArn { get; set; }

        /// <summary>
        /// Checks to see if the PlaybackRestrictionPolicyArn property is set.
        /// </summary>
        internal bool IsSetPlaybackRestrictionPolicyArn() => this.PlaybackRestrictionPolicyArn != null;

        /// <summary>
        /// Gets and sets the property Preset. 
        /// <para>
        /// Optional transcode preset for the channel. This is selectable only for <c>ADVANCED_HD</c>
        /// and <c>ADVANCED_SD</c> channel types. For those channel types, the default <c>preset</c>
        /// is <c>HIGHER_BANDWIDTH_DELIVERY</c>. For other channel types (<c>BASIC</c> and <c>STANDARD</c>),
        /// <c>preset</c> is the empty string (<c>""</c>).
        /// </para>
        /// </summary>
        public TranscodePreset Preset { get; set; }

        /// <summary>
        /// Checks to see if the Preset property is set.
        /// </summary>
        internal bool IsSetPreset() => this.Preset != null;

        /// <summary>
        /// Gets and sets the property RecordingConfigurationArn. 
        /// <para>
        /// Recording-configuration ARN. A valid ARN value here both specifies the ARN and enables
        /// recording. If this is set to an empty string, recording is disabled.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string RecordingConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the RecordingConfigurationArn property is set.
        /// </summary>
        internal bool IsSetRecordingConfigurationArn() => this.RecordingConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Channel type, which determines the allowable resolution and bitrate. <i>If you exceed
        /// the allowable input resolution or bitrate, the stream probably will disconnect immediately.</i>
        /// Default: <c>STANDARD</c>. For details, see <a href="https://docs.aws.amazon.com/ivs/latest/LowLatencyUserGuide/channel-types.html">Channel
        /// Types</a>.
        /// </para>
        /// </summary>
        public ChannelType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
