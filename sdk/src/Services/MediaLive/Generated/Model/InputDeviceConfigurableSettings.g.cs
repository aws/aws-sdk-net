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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Configurable settings for the input device.
    /// </summary>
    public partial class InputDeviceConfigurableSettings
    {
        /// <summary>
        /// Gets and sets the property AudioChannelPairs. An array of eight audio configurations,
        /// one for each audio pair in the source. Set up each audio configuration either to exclude
        /// the pair, or to format it and include it in the output from the device. This parameter
        /// applies only to UHD devices, and only when the device is configured as the source
        /// for a MediaConnect flow. For an HD device, you configure the audio by setting up audio
        /// selectors in the channel configuration.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InputDeviceConfigurableAudioChannelPairConfig> AudioChannelPairs { get; set; } = AWSConfigs.InitializeCollections ? new List<InputDeviceConfigurableAudioChannelPairConfig>() : null;

        /// <summary>
        /// Checks to see if the AudioChannelPairs property is set.
        /// </summary>
        internal bool IsSetAudioChannelPairs() => this.AudioChannelPairs != null && (this.AudioChannelPairs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Codec. Choose the codec for the video that the device produces.
        /// Only UHD devices can specify this parameter.
        /// </summary>
        public InputDeviceCodec Codec { get; set; }

        /// <summary>
        /// Checks to see if the Codec property is set.
        /// </summary>
        internal bool IsSetCodec() => this.Codec != null;

        /// <summary>
        /// Gets and sets the property ConfiguredInput. The input source that you want to use.
        /// If the device has a source connected to only one of its input ports, or if you don't
        /// care which source the device sends, specify Auto. If the device has sources connected
        /// to both its input ports, and you want to use a specific source, specify the source.
        /// </summary>
        public InputDeviceConfiguredInput ConfiguredInput { get; set; }

        /// <summary>
        /// Checks to see if the ConfiguredInput property is set.
        /// </summary>
        internal bool IsSetConfiguredInput() => this.ConfiguredInput != null;

        /// <summary>
        /// Gets and sets the property InputResolution. Choose the resolution of the Link device's
        /// source (HD or UHD). Make sure the resolution matches the current source from the device.
        /// This value determines MediaLive resource allocation and billing for this input. Only
        /// UHD devices can specify this parameter.
        /// </summary>
        public string InputResolution { get; set; }

        /// <summary>
        /// Checks to see if the InputResolution property is set.
        /// </summary>
        internal bool IsSetInputResolution() => this.InputResolution != null;

        /// <summary>
        /// Gets and sets the property LatencyMs. The Link device's buffer size (latency) in milliseconds
        /// (ms).
        /// </summary>
        public int? LatencyMs { get; set; }

        /// <summary>
        /// Checks to see if the LatencyMs property is set.
        /// </summary>
        internal bool IsSetLatencyMs() => this.LatencyMs.HasValue;

        /// <summary>
        /// Gets and sets the property MaxBitrate. The maximum bitrate in bits per second. Set
        /// a value here to throttle the bitrate of the source video.
        /// </summary>
        public int? MaxBitrate { get; set; }

        /// <summary>
        /// Checks to see if the MaxBitrate property is set.
        /// </summary>
        internal bool IsSetMaxBitrate() => this.MaxBitrate.HasValue;

        /// <summary>
        /// Gets and sets the property MediaconnectSettings. To attach this device to a MediaConnect
        /// flow, specify these parameters. To detach an existing flow, enter {} for the value
        /// of mediaconnectSettings. Only UHD devices can specify this parameter.
        /// </summary>
        public InputDeviceMediaConnectConfigurableSettings MediaconnectSettings { get; set; }

        /// <summary>
        /// Checks to see if the MediaconnectSettings property is set.
        /// </summary>
        internal bool IsSetMediaconnectSettings() => this.MediaconnectSettings != null;
    }
}
