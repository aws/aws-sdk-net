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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Specifies DRM settings for DASH outputs.
    /// </summary>
    public partial class DashIsoEncryptionSettings
    {
        private DashIsoPlaybackDeviceCompatibility _playbackDeviceCompatibility;
        private SpekeKeyProvider _spekeKeyProvider;

        /// <summary>
        /// Gets and sets the property PlaybackDeviceCompatibility. This setting can improve the
        /// compatibility of your output with video players on obsolete devices. It applies only
        /// to DASH H.264 outputs with DRM encryption. Choose Unencrypted SEI (UNENCRYPTED_SEI)
        /// only to correct problems with playback on older devices. Otherwise, keep the default
        /// setting CENC v1 (CENC_V1). If you choose Unencrypted SEI, for that output, the service
        /// will exclude the access unit delimiter and will leave the SEI NAL units unencrypted.
        /// </summary>
        public DashIsoPlaybackDeviceCompatibility PlaybackDeviceCompatibility
        {
            get { return this._playbackDeviceCompatibility; }
            set { this._playbackDeviceCompatibility = value; }
        }

        // Check to see if PlaybackDeviceCompatibility property is set
        internal bool IsSetPlaybackDeviceCompatibility()
        {
            return this._playbackDeviceCompatibility != null;
        }

        /// <summary>
        /// Gets and sets the property SpekeKeyProvider. If your output group type is HLS, DASH,
        /// or Microsoft Smooth, use these settings when doing DRM encryption with a SPEKE-compliant
        /// key provider. If your output group type is CMAF, use the SpekeKeyProviderCmaf settings
        /// instead.
        /// </summary>
        public SpekeKeyProvider SpekeKeyProvider
        {
            get { return this._spekeKeyProvider; }
            set { this._spekeKeyProvider = value; }
        }

        // Check to see if SpekeKeyProvider property is set
        internal bool IsSetSpekeKeyProvider()
        {
            return this._spekeKeyProvider != null;
        }

    }
}