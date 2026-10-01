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
    /// Details about each track (video, audio, or data) in the media file.
    /// </summary>
    public partial class Track
    {
        /// <summary>
        /// Gets and sets the property AudioProperties. Details about the media file's audio track.
        /// </summary>
        public AudioProperties AudioProperties { get; set; }

        /// <summary>
        /// Checks to see if the AudioProperties property is set.
        /// </summary>
        internal bool IsSetAudioProperties() => this.AudioProperties != null;

        /// <summary>
        /// Gets and sets the property Codec. The codec of the audio or video track, or caption
        /// format of the data track.
        /// </summary>
        public Codec Codec { get; set; }

        /// <summary>
        /// Checks to see if the Codec property is set.
        /// </summary>
        internal bool IsSetCodec() => this.Codec != null;

        /// <summary>
        /// Gets and sets the property DataProperties. Details about the media file's data track.
        /// </summary>
        public DataProperties DataProperties { get; set; }

        /// <summary>
        /// Checks to see if the DataProperties property is set.
        /// </summary>
        internal bool IsSetDataProperties() => this.DataProperties != null;

        /// <summary>
        /// Gets and sets the property Duration. The duration of the track, in seconds.
        /// </summary>
        public double? Duration { get; set; }

        /// <summary>
        /// Checks to see if the Duration property is set.
        /// </summary>
        internal bool IsSetDuration() => this.Duration.HasValue;

        /// <summary>
        /// Gets and sets the property Index. The unique index number of the track, starting at
        /// 1.
        /// </summary>
        public int? Index { get; set; }

        /// <summary>
        /// Checks to see if the Index property is set.
        /// </summary>
        internal bool IsSetIndex() => this.Index.HasValue;

        /// <summary>
        /// Gets and sets the property TrackType. The type of track: video, audio, or data.
        /// </summary>
        public TrackType TrackType { get; set; }

        /// <summary>
        /// Checks to see if the TrackType property is set.
        /// </summary>
        internal bool IsSetTrackType() => this.TrackType != null;

        /// <summary>
        /// Gets and sets the property VideoProperties. Details about the media file's video track.
        /// </summary>
        public VideoProperties VideoProperties { get; set; }

        /// <summary>
        /// Checks to see if the VideoProperties property is set.
        /// </summary>
        internal bool IsSetVideoProperties() => this.VideoProperties != null;
    }
}
