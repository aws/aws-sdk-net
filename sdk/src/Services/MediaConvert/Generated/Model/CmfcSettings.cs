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
    /// Settings for MP4 segments in CMAF
    /// </summary>
    public partial class CmfcSettings
    {
        private CmfcAudioDuration _audioDuration;
        private CmfcIFrameOnlyManifest _iFrameOnlyManifest;
        private CmfcScte35Esam _scte35Esam;
        private CmfcScte35Source _scte35Source;

        /// <summary>
        /// Gets and sets the property AudioDuration. Specify this setting only when your output
        /// will be consumed by a downstream repackaging workflow that is sensitive to very small
        /// duration differences between video and audio. For this situation, choose Match video
        /// duration (MATCH_VIDEO_DURATION). In all other cases, keep the default value, Default
        /// codec duration (DEFAULT_CODEC_DURATION). When you choose Match video duration, MediaConvert
        /// pads the output audio streams with silence or trims them to ensure that the total
        /// duration of each audio stream is at least as long as the total duration of the video
        /// stream. After padding or trimming, the audio stream duration is no more than one frame
        /// longer than the video stream. MediaConvert applies audio padding or trimming only
        /// to the end of the last segment of the output. For unsegmented outputs, MediaConvert
        /// adds padding only to the end of the file. When you keep the default value, any minor
        /// discrepancies between audio and video duration will depend on your output audio codec.
        /// </summary>
        public CmfcAudioDuration AudioDuration
        {
            get { return this._audioDuration; }
            set { this._audioDuration = value; }
        }

        // Check to see if AudioDuration property is set
        internal bool IsSetAudioDuration()
        {
            return this._audioDuration != null;
        }

        /// <summary>
        /// Gets and sets the property IFrameOnlyManifest. Choose Include (INCLUDE) to have MediaConvert
        /// generate an HLS child manifest that lists only the I-frames for this rendition, in
        /// addition to your regular manifest for this rendition. You might use this manifest
        /// as part of a workflow that creates preview functions for your video. MediaConvert
        /// adds both the I-frame only child manifest and the regular child manifest to the parent
        /// manifest. When you don't need the I-frame only child manifest, keep the default value
        /// Exclude (EXCLUDE).
        /// </summary>
        public CmfcIFrameOnlyManifest IFrameOnlyManifest
        {
            get { return this._iFrameOnlyManifest; }
            set { this._iFrameOnlyManifest = value; }
        }

        // Check to see if IFrameOnlyManifest property is set
        internal bool IsSetIFrameOnlyManifest()
        {
            return this._iFrameOnlyManifest != null;
        }

        /// <summary>
        /// Gets and sets the property Scte35Esam. Use this setting only when you specify SCTE-35
        /// markers from ESAM. Choose INSERT to put SCTE-35 markers in this output at the insertion
        /// points that you specify in an ESAM XML document. Provide the document in the setting
        /// SCC XML (sccXml).
        /// </summary>
        public CmfcScte35Esam Scte35Esam
        {
            get { return this._scte35Esam; }
            set { this._scte35Esam = value; }
        }

        // Check to see if Scte35Esam property is set
        internal bool IsSetScte35Esam()
        {
            return this._scte35Esam != null;
        }

        /// <summary>
        /// Gets and sets the property Scte35Source. Ignore this setting unless you have SCTE-35
        /// markers in your input video file. Choose Passthrough (PASSTHROUGH) if you want SCTE-35
        /// markers that appear in your input to also appear in this output. Choose None (NONE)
        /// if you don't want those SCTE-35 markers in this output.
        /// </summary>
        public CmfcScte35Source Scte35Source
        {
            get { return this._scte35Source; }
            set { this._scte35Source = value; }
        }

        // Check to see if Scte35Source property is set
        internal bool IsSetScte35Source()
        {
            return this._scte35Source != null;
        }

    }
}