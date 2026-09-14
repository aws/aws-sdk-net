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
    /// The container of your media file. This information helps you understand the overall
    /// structure and details of your media, including format, duration, and track layout.
    /// </summary>
    public partial class Container
    {
        /// <summary>
        /// Gets and sets the property BitRate. The overall bit rate of your media file, in bits
        /// per second. This is derived from the file size and duration as (file size in bytes
        /// * 8) / duration in seconds.
        /// </summary>
        public long? BitRate { get; set; }

        /// <summary>
        /// Checks to see if the BitRate property is set.
        /// </summary>
        internal bool IsSetBitRate() => this.BitRate.HasValue;

        /// <summary>
        /// Gets and sets the property Duration. The total duration of your media file, in seconds.
        /// </summary>
        public double? Duration { get; set; }

        /// <summary>
        /// Checks to see if the Duration property is set.
        /// </summary>
        internal bool IsSetDuration() => this.Duration.HasValue;

        /// <summary>
        /// Gets and sets the property Format. The format of your media file. For example: MP4,
        /// QuickTime (MOV), Matroska (MKV), WebM, MXF, Wave, AVI, MPEG-TS, MPEG-PS, MP3, FLAC,
        /// ASF (Windows Media / WMA), or OGG. Note that this will be blank if your media file
        /// has a format that the MediaConvert Probe operation does not recognize.
        /// </summary>
        public Format Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property StartTimecode. The start timecode of the media file, in
        /// HH:MM:SS:FF format (or HH:MM:SS;FF for drop frame timecode). Note that this field
        /// is null when the container does not include an embedded start timecode.
        /// </summary>
        public string StartTimecode { get; set; }

        /// <summary>
        /// Checks to see if the StartTimecode property is set.
        /// </summary>
        internal bool IsSetStartTimecode() => this.StartTimecode != null;

        /// <summary>
        /// Gets and sets the property Tracks. Details about each track (video, audio, or data)
        /// in the media file.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Track> Tracks { get; set; } = AWSConfigs.InitializeCollections ? new List<Track>() : null;

        /// <summary>
        /// Checks to see if the Tracks property is set.
        /// </summary>
        internal bool IsSetTracks() => this.Tracks != null && (this.Tracks.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
