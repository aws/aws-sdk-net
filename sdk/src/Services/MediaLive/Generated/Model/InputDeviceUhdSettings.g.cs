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
    /// Settings that describe the active source from the input device, and the video characteristics
    /// of that source.
    /// </summary>
    public partial class InputDeviceUhdSettings
    {
        /// <summary>
        /// Gets and sets the property ActiveInput. If you specified Auto as the configured input,
        /// specifies which of the sources is currently active (SDI or HDMI).
        /// </summary>
        public InputDeviceActiveInput ActiveInput { get; set; }

        /// <summary>
        /// Checks to see if the ActiveInput property is set.
        /// </summary>
        internal bool IsSetActiveInput() => this.ActiveInput != null;

        /// <summary>
        /// Gets and sets the property AudioChannelPairs. An array of eight audio configurations,
        /// one for each audio pair in the source. Each audio configuration specifies either to
        /// exclude the pair, or to format it and include it in the output from the UHD device.
        /// Applies only when the device is configured as the source for a MediaConnect flow.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InputDeviceUhdAudioChannelPairConfig> AudioChannelPairs { get; set; } = AWSConfigs.InitializeCollections ? new List<InputDeviceUhdAudioChannelPairConfig>() : null;

        /// <summary>
        /// Checks to see if the AudioChannelPairs property is set.
        /// </summary>
        internal bool IsSetAudioChannelPairs() => this.AudioChannelPairs != null && (this.AudioChannelPairs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Codec. The codec for the video that the device produces.
        /// </summary>
        public InputDeviceCodec Codec { get; set; }

        /// <summary>
        /// Checks to see if the Codec property is set.
        /// </summary>
        internal bool IsSetCodec() => this.Codec != null;

        /// <summary>
        /// Gets and sets the property ConfiguredInput. The source at the input device that is
        /// currently active. You can specify this source.
        /// </summary>
        public InputDeviceConfiguredInput ConfiguredInput { get; set; }

        /// <summary>
        /// Checks to see if the ConfiguredInput property is set.
        /// </summary>
        internal bool IsSetConfiguredInput() => this.ConfiguredInput != null;

        /// <summary>
        /// Gets and sets the property DeviceState. The state of the input device.
        /// </summary>
        public InputDeviceState DeviceState { get; set; }

        /// <summary>
        /// Checks to see if the DeviceState property is set.
        /// </summary>
        internal bool IsSetDeviceState() => this.DeviceState != null;

        /// <summary>
        /// Gets and sets the property Framerate. The frame rate of the video source.
        /// </summary>
        public double? Framerate { get; set; }

        /// <summary>
        /// Checks to see if the Framerate property is set.
        /// </summary>
        internal bool IsSetFramerate() => this.Framerate.HasValue;

        /// <summary>
        /// Gets and sets the property Height. The height of the video source, in pixels.
        /// </summary>
        public int? Height { get; set; }

        /// <summary>
        /// Checks to see if the Height property is set.
        /// </summary>
        internal bool IsSetHeight() => this.Height.HasValue;

        /// <summary>
        /// Gets and sets the property InputResolution. The resolution of the Link device's source
        /// (HD or UHD). This value determines MediaLive resource allocation and billing for this
        /// input.
        /// </summary>
        public string InputResolution { get; set; }

        /// <summary>
        /// Checks to see if the InputResolution property is set.
        /// </summary>
        internal bool IsSetInputResolution() => this.InputResolution != null;

        /// <summary>
        /// Gets and sets the property LatencyMs. The Link device's buffer size (latency) in milliseconds
        /// (ms). You can specify this value.
        /// </summary>
        public int? LatencyMs { get; set; }

        /// <summary>
        /// Checks to see if the LatencyMs property is set.
        /// </summary>
        internal bool IsSetLatencyMs() => this.LatencyMs.HasValue;

        /// <summary>
        /// Gets and sets the property MaxBitrate. The current maximum bitrate for ingesting this
        /// source, in bits per second. You can specify this maximum.
        /// </summary>
        public int? MaxBitrate { get; set; }

        /// <summary>
        /// Checks to see if the MaxBitrate property is set.
        /// </summary>
        internal bool IsSetMaxBitrate() => this.MaxBitrate.HasValue;

        /// <summary>
        /// Gets and sets the property MediaconnectSettings. Information about the MediaConnect
        /// flow attached to the device. Returned only if the outputType is MEDIACONNECT_FLOW.
        /// </summary>
        public InputDeviceMediaConnectSettings MediaconnectSettings { get; set; }

        /// <summary>
        /// Checks to see if the MediaconnectSettings property is set.
        /// </summary>
        internal bool IsSetMediaconnectSettings() => this.MediaconnectSettings != null;

        /// <summary>
        /// Gets and sets the property ScanType. The scan type of the video source.
        /// </summary>
        public InputDeviceScanType ScanType { get; set; }

        /// <summary>
        /// Checks to see if the ScanType property is set.
        /// </summary>
        internal bool IsSetScanType() => this.ScanType != null;

        /// <summary>
        /// Gets and sets the property Width. The width of the video source, in pixels.
        /// </summary>
        public int? Width { get; set; }

        /// <summary>
        /// Checks to see if the Width property is set.
        /// </summary>
        internal bool IsSetWidth() => this.Width.HasValue;
    }
}
