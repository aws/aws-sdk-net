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
    /// Settings for MP4 container. You can create audio-only AAC outputs with this container.
    /// </summary>
    public partial class Mp4Settings
    {
        private CmfcAudioDuration _audioDuration;
        private Mp4CslgAtom _cslgAtom;
        private int? _cttsVersion;
        private Mp4FreeSpaceBox _freeSpaceBox;
        private Mp4MoovPlacement _moovPlacement;
        private string _mp4MajorBrand;

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
        /// Gets and sets the property CslgAtom. When enabled, file composition times will start
        /// at zero, composition times in the 'ctts' (composition time to sample) box for B-frames
        /// will be negative, and a 'cslg' (composition shift least greatest) box will be included
        /// per 14496-1 amendment 1. This improves compatibility with Apple players and tools.
        /// </summary>
        public Mp4CslgAtom CslgAtom
        {
            get { return this._cslgAtom; }
            set { this._cslgAtom = value; }
        }

        // Check to see if CslgAtom property is set
        internal bool IsSetCslgAtom()
        {
            return this._cslgAtom != null;
        }

        /// <summary>
        /// Gets and sets the property CttsVersion. Ignore this setting unless compliance to the
        /// CTTS box version specification matters in your workflow. Specify a value of 1 to set
        /// your CTTS box version to 1 and make your output compliant with the specification.
        /// When you specify a value of 1, you must also set CSLG atom (cslgAtom) to the value
        /// INCLUDE. Keep the default value 0 to set your CTTS box version to 0. This can provide
        /// backward compatibility for some players and packagers.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public int CttsVersion
        {
            get { return this._cttsVersion.GetValueOrDefault(); }
            set { this._cttsVersion = value; }
        }

        // Check to see if CttsVersion property is set
        internal bool IsSetCttsVersion()
        {
            return this._cttsVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FreeSpaceBox. Inserts a free-space box immediately after
        /// the moov box.
        /// </summary>
        public Mp4FreeSpaceBox FreeSpaceBox
        {
            get { return this._freeSpaceBox; }
            set { this._freeSpaceBox = value; }
        }

        // Check to see if FreeSpaceBox property is set
        internal bool IsSetFreeSpaceBox()
        {
            return this._freeSpaceBox != null;
        }

        /// <summary>
        /// Gets and sets the property MoovPlacement. If set to PROGRESSIVE_DOWNLOAD, the MOOV
        /// atom is relocated to the beginning of the archive as required for progressive downloading.
        /// Otherwise it is placed normally at the end.
        /// </summary>
        public Mp4MoovPlacement MoovPlacement
        {
            get { return this._moovPlacement; }
            set { this._moovPlacement = value; }
        }

        // Check to see if MoovPlacement property is set
        internal bool IsSetMoovPlacement()
        {
            return this._moovPlacement != null;
        }

        /// <summary>
        /// Gets and sets the property Mp4MajorBrand. Overrides the "Major Brand" field in the
        /// output file. Usually not necessary to specify.
        /// </summary>
        public string Mp4MajorBrand
        {
            get { return this._mp4MajorBrand; }
            set { this._mp4MajorBrand = value; }
        }

        // Check to see if Mp4MajorBrand property is set
        internal bool IsSetMp4MajorBrand()
        {
            return this._mp4MajorBrand != null;
        }

    }
}