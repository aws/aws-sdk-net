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
    /// Video Codec Settings
    /// </summary>
    public partial class VideoCodecSettings
    {
        /// <summary>
        /// Gets and sets the property Av1Settings.
        /// </summary>
        public Av1Settings Av1Settings { get; set; }

        /// <summary>
        /// Checks to see if the Av1Settings property is set.
        /// </summary>
        internal bool IsSetAv1Settings() => this.Av1Settings != null;

        /// <summary>
        /// Gets and sets the property FrameCaptureSettings.
        /// </summary>
        public FrameCaptureSettings FrameCaptureSettings { get; set; }

        /// <summary>
        /// Checks to see if the FrameCaptureSettings property is set.
        /// </summary>
        internal bool IsSetFrameCaptureSettings() => this.FrameCaptureSettings != null;

        /// <summary>
        /// Gets and sets the property H264Settings.
        /// </summary>
        public H264Settings H264Settings { get; set; }

        /// <summary>
        /// Checks to see if the H264Settings property is set.
        /// </summary>
        internal bool IsSetH264Settings() => this.H264Settings != null;

        /// <summary>
        /// Gets and sets the property H265Settings.
        /// </summary>
        public H265Settings H265Settings { get; set; }

        /// <summary>
        /// Checks to see if the H265Settings property is set.
        /// </summary>
        internal bool IsSetH265Settings() => this.H265Settings != null;

        /// <summary>
        /// Gets and sets the property Mpeg2Settings.
        /// </summary>
        public Mpeg2Settings Mpeg2Settings { get; set; }

        /// <summary>
        /// Checks to see if the Mpeg2Settings property is set.
        /// </summary>
        internal bool IsSetMpeg2Settings() => this.Mpeg2Settings != null;
    }
}
