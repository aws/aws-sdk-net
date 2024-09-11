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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Video Codec Settings
    /// </summary>
    public partial class VideoCodecSettings
    {
        private Av1Settings _av1Settings;
        private FrameCaptureSettings _frameCaptureSettings;
        private H264Settings _h264Settings;
        private H265Settings _h265Settings;
        private Mpeg2Settings _mpeg2Settings;

        /// <summary>
        /// Gets and sets the property Av1Settings.
        /// </summary>
        public Av1Settings Av1Settings
        {
            get { return this._av1Settings; }
            set { this._av1Settings = value; }
        }

        // Check to see if Av1Settings property is set
        internal bool IsSetAv1Settings()
        {
            return this._av1Settings != null;
        }

        /// <summary>
        /// Gets and sets the property FrameCaptureSettings.
        /// </summary>
        public FrameCaptureSettings FrameCaptureSettings
        {
            get { return this._frameCaptureSettings; }
            set { this._frameCaptureSettings = value; }
        }

        // Check to see if FrameCaptureSettings property is set
        internal bool IsSetFrameCaptureSettings()
        {
            return this._frameCaptureSettings != null;
        }

        /// <summary>
        /// Gets and sets the property H264Settings.
        /// </summary>
        public H264Settings H264Settings
        {
            get { return this._h264Settings; }
            set { this._h264Settings = value; }
        }

        // Check to see if H264Settings property is set
        internal bool IsSetH264Settings()
        {
            return this._h264Settings != null;
        }

        /// <summary>
        /// Gets and sets the property H265Settings.
        /// </summary>
        public H265Settings H265Settings
        {
            get { return this._h265Settings; }
            set { this._h265Settings = value; }
        }

        // Check to see if H265Settings property is set
        internal bool IsSetH265Settings()
        {
            return this._h265Settings != null;
        }

        /// <summary>
        /// Gets and sets the property Mpeg2Settings.
        /// </summary>
        public Mpeg2Settings Mpeg2Settings
        {
            get { return this._mpeg2Settings; }
            set { this._mpeg2Settings = value; }
        }

        // Check to see if Mpeg2Settings property is set
        internal bool IsSetMpeg2Settings()
        {
            return this._mpeg2Settings != null;
        }

    }
}