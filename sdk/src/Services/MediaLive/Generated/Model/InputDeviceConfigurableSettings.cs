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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Configurable settings for the input device.
    /// </summary>
    public partial class InputDeviceConfigurableSettings
    {
        private InputDeviceCodec _codec;
        private InputDeviceConfiguredInput _configuredInput;
        private int? _latencyMs;
        private int? _maxBitrate;
        private InputDeviceMediaConnectConfigurableSettings _mediaconnectSettings;

        /// <summary>
        /// Gets and sets the property Codec. Choose the codec for the video that the device produces.
        /// Only UHD devices can specify this parameter.
        /// </summary>
        public InputDeviceCodec Codec
        {
            get { return this._codec; }
            set { this._codec = value; }
        }

        // Check to see if Codec property is set
        internal bool IsSetCodec()
        {
            return this._codec != null;
        }

        /// <summary>
        /// Gets and sets the property ConfiguredInput. The input source that you want to use.
        /// If the device has a source connected to only one of its input ports, or if you don't
        /// care which source the device sends, specify Auto. If the device has sources connected
        /// to both its input ports, and you want to use a specific source, specify the source.
        /// </summary>
        public InputDeviceConfiguredInput ConfiguredInput
        {
            get { return this._configuredInput; }
            set { this._configuredInput = value; }
        }

        // Check to see if ConfiguredInput property is set
        internal bool IsSetConfiguredInput()
        {
            return this._configuredInput != null;
        }

        /// <summary>
        /// Gets and sets the property LatencyMs. The Link device's buffer size (latency) in milliseconds
        /// (ms).
        /// </summary>
        public int LatencyMs
        {
            get { return this._latencyMs.GetValueOrDefault(); }
            set { this._latencyMs = value; }
        }

        // Check to see if LatencyMs property is set
        internal bool IsSetLatencyMs()
        {
            return this._latencyMs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxBitrate. The maximum bitrate in bits per second. Set
        /// a value here to throttle the bitrate of the source video.
        /// </summary>
        public int MaxBitrate
        {
            get { return this._maxBitrate.GetValueOrDefault(); }
            set { this._maxBitrate = value; }
        }

        // Check to see if MaxBitrate property is set
        internal bool IsSetMaxBitrate()
        {
            return this._maxBitrate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MediaconnectSettings. To attach this device to a MediaConnect
        /// flow, specify these parameters. To detach an existing flow, enter {} for the value
        /// of mediaconnectSettings. Only UHD devices can specify this parameter.
        /// </summary>
        public InputDeviceMediaConnectConfigurableSettings MediaconnectSettings
        {
            get { return this._mediaconnectSettings; }
            set { this._mediaconnectSettings = value; }
        }

        // Check to see if MediaconnectSettings property is set
        internal bool IsSetMediaconnectSettings()
        {
            return this._mediaconnectSettings != null;
        }

    }
}