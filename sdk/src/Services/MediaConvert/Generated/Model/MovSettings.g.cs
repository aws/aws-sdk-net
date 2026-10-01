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

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// These settings relate to your QuickTime MOV output container.
    /// </summary>
    public partial class MovSettings
    {
        /// <summary>
        /// Gets and sets the property AudioDuration. Specify this setting only when your output
        /// will be consumed by a downstream repackaging workflow that is sensitive to very small
        /// duration differences between video and audio. For this situation, choose Match video
        /// duration. In all other cases, keep the default value, Default codec duration. When
        /// you choose Match video duration, MediaConvert pads the output audio streams with silence
        /// or trims them to ensure that the total duration of each audio stream is at least as
        /// long as the total duration of the video stream. After padding or trimming, the audio
        /// stream duration is no more than one frame longer than the video stream. MediaConvert
        /// applies audio padding or trimming only to the end of the last segment of the output.
        /// For unsegmented outputs, MediaConvert adds padding only to the end of the file. When
        /// you keep the default value, any minor discrepancies between audio and video duration
        /// will depend on your output audio codec.
        /// </summary>
        public CmfcAudioDuration AudioDuration { get; set; }

        /// <summary>
        /// Checks to see if the AudioDuration property is set.
        /// </summary>
        internal bool IsSetAudioDuration() => this.AudioDuration != null;

        /// <summary>
        /// Gets and sets the property ClapAtom. When enabled, include 'clap' atom if appropriate
        /// for the video output settings.
        /// </summary>
        public MovClapAtom ClapAtom { get; set; }

        /// <summary>
        /// Checks to see if the ClapAtom property is set.
        /// </summary>
        internal bool IsSetClapAtom() => this.ClapAtom != null;

        /// <summary>
        /// Gets and sets the property CslgAtom. When enabled, file composition times will start
        /// at zero, composition times in the 'ctts' (composition time to sample) box for B-frames
        /// will be negative, and a 'cslg' (composition shift least greatest) box will be included
        /// per 14496-1 amendment 1. This improves compatibility with Apple players and tools.
        /// </summary>
        public MovCslgAtom CslgAtom { get; set; }

        /// <summary>
        /// Checks to see if the CslgAtom property is set.
        /// </summary>
        internal bool IsSetCslgAtom() => this.CslgAtom != null;

        /// <summary>
        /// Gets and sets the property Mpeg2FourCCControl. When set to XDCAM, writes MPEG2 video
        /// streams into the QuickTime file using XDCAM fourcc codes. This increases compatibility
        /// with Apple editors and players, but may decrease compatibility with other players.
        /// Only applicable when the video codec is MPEG2.
        /// </summary>
        public MovMpeg2FourCCControl Mpeg2FourCCControl { get; set; }

        /// <summary>
        /// Checks to see if the Mpeg2FourCCControl property is set.
        /// </summary>
        internal bool IsSetMpeg2FourCCControl() => this.Mpeg2FourCCControl != null;

        /// <summary>
        /// Gets and sets the property PaddingControl. Unless you need Omneon compatibility: Keep
        /// the default value, None. To make this output compatible with Omneon: Choose Omneon.
        /// When you do, MediaConvert increases the length of the 'elst' edit list atom. Note
        /// that this might cause file rejections when a recipient of the output file doesn't
        /// expect this extra padding.
        /// </summary>
        public MovPaddingControl PaddingControl { get; set; }

        /// <summary>
        /// Checks to see if the PaddingControl property is set.
        /// </summary>
        internal bool IsSetPaddingControl() => this.PaddingControl != null;

        /// <summary>
        /// Gets and sets the property Reference. Always keep the default value (SELF_CONTAINED)
        /// for this setting.
        /// </summary>
        public MovReference Reference { get; set; }

        /// <summary>
        /// Checks to see if the Reference property is set.
        /// </summary>
        internal bool IsSetReference() => this.Reference != null;
    }
}
