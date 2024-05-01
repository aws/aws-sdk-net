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
    /// Hls Settings
    /// </summary>
    public partial class HlsSettings
    {
        private AudioOnlyHlsSettings _audioOnlyHlsSettings;
        private Fmp4HlsSettings _fmp4HlsSettings;
        private FrameCaptureHlsSettings _frameCaptureHlsSettings;
        private StandardHlsSettings _standardHlsSettings;

        /// <summary>
        /// Gets and sets the property AudioOnlyHlsSettings.
        /// </summary>
        public AudioOnlyHlsSettings AudioOnlyHlsSettings
        {
            get { return this._audioOnlyHlsSettings; }
            set { this._audioOnlyHlsSettings = value; }
        }

        // Check to see if AudioOnlyHlsSettings property is set
        internal bool IsSetAudioOnlyHlsSettings()
        {
            return this._audioOnlyHlsSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Fmp4HlsSettings.
        /// </summary>
        public Fmp4HlsSettings Fmp4HlsSettings
        {
            get { return this._fmp4HlsSettings; }
            set { this._fmp4HlsSettings = value; }
        }

        // Check to see if Fmp4HlsSettings property is set
        internal bool IsSetFmp4HlsSettings()
        {
            return this._fmp4HlsSettings != null;
        }

        /// <summary>
        /// Gets and sets the property FrameCaptureHlsSettings.
        /// </summary>
        public FrameCaptureHlsSettings FrameCaptureHlsSettings
        {
            get { return this._frameCaptureHlsSettings; }
            set { this._frameCaptureHlsSettings = value; }
        }

        // Check to see if FrameCaptureHlsSettings property is set
        internal bool IsSetFrameCaptureHlsSettings()
        {
            return this._frameCaptureHlsSettings != null;
        }

        /// <summary>
        /// Gets and sets the property StandardHlsSettings.
        /// </summary>
        public StandardHlsSettings StandardHlsSettings
        {
            get { return this._standardHlsSettings; }
            set { this._standardHlsSettings = value; }
        }

        // Check to see if StandardHlsSettings property is set
        internal bool IsSetStandardHlsSettings()
        {
            return this._standardHlsSettings != null;
        }

    }
}