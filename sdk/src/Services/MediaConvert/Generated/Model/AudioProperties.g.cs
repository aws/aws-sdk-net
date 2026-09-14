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
    /// Details about the media file's audio track.
    /// </summary>
    public partial class AudioProperties
    {
        /// <summary>
        /// Gets and sets the property BitDepth. The bit depth of the audio track.
        /// </summary>
        public int? BitDepth { get; set; }

        /// <summary>
        /// Checks to see if the BitDepth property is set.
        /// </summary>
        internal bool IsSetBitDepth() => this.BitDepth.HasValue;

        /// <summary>
        /// Gets and sets the property BitRate. The bit rate of the audio track, in bits per second.
        /// </summary>
        public long? BitRate { get; set; }

        /// <summary>
        /// Checks to see if the BitRate property is set.
        /// </summary>
        internal bool IsSetBitRate() => this.BitRate.HasValue;

        /// <summary>
        /// Gets and sets the property ChannelLayout. The audio channel layout of the track, such
        /// as "mono", "stereo", "5.1", or "7.1". Object-based or immersive audio is reported
        /// as "5.1.4" or "7.1.4".
        /// </summary>
        public string ChannelLayout { get; set; }

        /// <summary>
        /// Checks to see if the ChannelLayout property is set.
        /// </summary>
        internal bool IsSetChannelLayout() => this.ChannelLayout != null;

        /// <summary>
        /// Gets and sets the property Channels. The number of audio channels in the audio track.
        /// </summary>
        public int? Channels { get; set; }

        /// <summary>
        /// Checks to see if the Channels property is set.
        /// </summary>
        internal bool IsSetChannels() => this.Channels.HasValue;

        /// <summary>
        /// Gets and sets the property FrameRate. The frame rate of the video or audio track,
        /// expressed as a fraction with numerator and denominator values.
        /// </summary>
        public FrameRate FrameRate { get; set; }

        /// <summary>
        /// Checks to see if the FrameRate property is set.
        /// </summary>
        internal bool IsSetFrameRate() => this.FrameRate != null;

        /// <summary>
        /// Gets and sets the property LanguageCode. The language code of the audio track, in
        /// three character ISO 639-3 format.
        /// </summary>
        public string LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;

        /// <summary>
        /// Gets and sets the property ObjectCount. The number of audio objects in an object-based
        /// or immersive audio track. This field is present for codecs that support object-based
        /// audio, such as E-AC-3 with Joint Object Coding (JOC) or IAMF. This field is null when
        /// the audio track does not contain object-based audio metadata.
        /// </summary>
        public int? ObjectCount { get; set; }

        /// <summary>
        /// Checks to see if the ObjectCount property is set.
        /// </summary>
        internal bool IsSetObjectCount() => this.ObjectCount.HasValue;

        /// <summary>
        /// Gets and sets the property SampleRate. The sample rate of the audio track.
        /// </summary>
        public int? SampleRate { get; set; }

        /// <summary>
        /// Checks to see if the SampleRate property is set.
        /// </summary>
        internal bool IsSetSampleRate() => this.SampleRate.HasValue;
    }
}
