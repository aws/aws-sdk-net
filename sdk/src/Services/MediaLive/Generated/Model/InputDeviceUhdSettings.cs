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
    /// Settings that describe the active source from the input device, and the video characteristics
    /// of that source.
    /// </summary>
    public partial class InputDeviceUhdSettings
    {
        private InputDeviceActiveInput _activeInput;
        private InputDeviceConfiguredInput _configuredInput;
        private InputDeviceState _deviceState;
        private double? _framerate;
        private int? _height;
        private int? _latencyMs;
        private int? _maxBitrate;
        private InputDeviceScanType _scanType;
        private int? _width;

        /// <summary>
        /// Gets and sets the property ActiveInput. If you specified Auto as the configured input,
        /// specifies which of the sources is currently active (SDI or HDMI).
        /// </summary>
        public InputDeviceActiveInput ActiveInput
        {
            get { return this._activeInput; }
            set { this._activeInput = value; }
        }

        // Check to see if ActiveInput property is set
        internal bool IsSetActiveInput()
        {
            return this._activeInput != null;
        }

        /// <summary>
        /// Gets and sets the property ConfiguredInput. The source at the input device that is
        /// currently active. You can specify this source.
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
        /// Gets and sets the property DeviceState. The state of the input device.
        /// </summary>
        public InputDeviceState DeviceState
        {
            get { return this._deviceState; }
            set { this._deviceState = value; }
        }

        // Check to see if DeviceState property is set
        internal bool IsSetDeviceState()
        {
            return this._deviceState != null;
        }

        /// <summary>
        /// Gets and sets the property Framerate. The frame rate of the video source.
        /// </summary>
        public double Framerate
        {
            get { return this._framerate.GetValueOrDefault(); }
            set { this._framerate = value; }
        }

        // Check to see if Framerate property is set
        internal bool IsSetFramerate()
        {
            return this._framerate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Height. The height of the video source, in pixels.
        /// </summary>
        public int Height
        {
            get { return this._height.GetValueOrDefault(); }
            set { this._height = value; }
        }

        // Check to see if Height property is set
        internal bool IsSetHeight()
        {
            return this._height.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatencyMs. The Link device's buffer size (latency) in milliseconds
        /// (ms). You can specify this value.
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
        /// Gets and sets the property MaxBitrate. The current maximum bitrate for ingesting this
        /// source, in bits per second. You can specify this maximum.
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
        /// Gets and sets the property ScanType. The scan type of the video source.
        /// </summary>
        public InputDeviceScanType ScanType
        {
            get { return this._scanType; }
            set { this._scanType = value; }
        }

        // Check to see if ScanType property is set
        internal bool IsSetScanType()
        {
            return this._scanType != null;
        }

        /// <summary>
        /// Gets and sets the property Width. The width of the video source, in pixels.
        /// </summary>
        public int Width
        {
            get { return this._width.GetValueOrDefault(); }
            set { this._width = value; }
        }

        // Check to see if Width property is set
        internal bool IsSetWidth()
        {
            return this._width.HasValue; 
        }

    }
}