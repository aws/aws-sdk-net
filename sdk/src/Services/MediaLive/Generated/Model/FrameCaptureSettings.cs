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
    /// Frame Capture Settings
    /// </summary>
    public partial class FrameCaptureSettings
    {
        private int? _captureInterval;
        private FrameCaptureIntervalUnit _captureIntervalUnits;
        private TimecodeBurninSettings _timecodeBurninSettings;

        /// <summary>
        /// Gets and sets the property CaptureInterval. The frequency at which to capture frames
        /// for inclusion in the output. May be specified in either seconds or milliseconds, as
        /// specified by captureIntervalUnits.
        /// </summary>
        [AWSProperty(Min=1, Max=3600000)]
        public int CaptureInterval
        {
            get { return this._captureInterval.GetValueOrDefault(); }
            set { this._captureInterval = value; }
        }

        // Check to see if CaptureInterval property is set
        internal bool IsSetCaptureInterval()
        {
            return this._captureInterval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CaptureIntervalUnits. Unit for the frame capture interval.
        /// </summary>
        public FrameCaptureIntervalUnit CaptureIntervalUnits
        {
            get { return this._captureIntervalUnits; }
            set { this._captureIntervalUnits = value; }
        }

        // Check to see if CaptureIntervalUnits property is set
        internal bool IsSetCaptureIntervalUnits()
        {
            return this._captureIntervalUnits != null;
        }

        /// <summary>
        /// Gets and sets the property TimecodeBurninSettings. Timecode burn-in settings
        /// </summary>
        public TimecodeBurninSettings TimecodeBurninSettings
        {
            get { return this._timecodeBurninSettings; }
            set { this._timecodeBurninSettings = value; }
        }

        // Check to see if TimecodeBurninSettings property is set
        internal bool IsSetTimecodeBurninSettings()
        {
            return this._timecodeBurninSettings != null;
        }

    }
}