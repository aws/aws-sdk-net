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
    /// Frame Capture Settings
    /// </summary>
    public partial class FrameCaptureSettings
    {
        /// <summary>
        /// Gets and sets the property CaptureInterval. The frequency at which to capture frames
        /// for inclusion in the output. May be specified in either seconds or milliseconds, as
        /// specified by captureIntervalUnits.
        /// </summary>
        public int? CaptureInterval { get; set; }

        /// <summary>
        /// Checks to see if the CaptureInterval property is set.
        /// </summary>
        internal bool IsSetCaptureInterval() => this.CaptureInterval.HasValue;

        /// <summary>
        /// Gets and sets the property CaptureIntervalUnits. Unit for the frame capture interval.
        /// </summary>
        public FrameCaptureIntervalUnit CaptureIntervalUnits { get; set; }

        /// <summary>
        /// Checks to see if the CaptureIntervalUnits property is set.
        /// </summary>
        internal bool IsSetCaptureIntervalUnits() => this.CaptureIntervalUnits != null;

        /// <summary>
        /// Gets and sets the property TimecodeBurninSettings. Timecode burn-in settings
        /// </summary>
        public TimecodeBurninSettings TimecodeBurninSettings { get; set; }

        /// <summary>
        /// Checks to see if the TimecodeBurninSettings property is set.
        /// </summary>
        internal bool IsSetTimecodeBurninSettings() => this.TimecodeBurninSettings != null;
    }
}
