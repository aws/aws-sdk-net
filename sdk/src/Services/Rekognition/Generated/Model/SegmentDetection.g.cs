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

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// A technical cue or shot detection segment detected in a video. An array of <c>SegmentDetection</c>
    /// objects containing all segments detected in a stored video is returned by <a>GetSegmentDetection</a>.
    /// </summary>
    public partial class SegmentDetection
    {
        /// <summary>
        /// Gets and sets the property DurationFrames. 
        /// <para>
        ///  The duration of a video segment, expressed in frames. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? DurationFrames { get; set; }

        /// <summary>
        /// Checks to see if the DurationFrames property is set.
        /// </summary>
        internal bool IsSetDurationFrames() => this.DurationFrames.HasValue;

        /// <summary>
        /// Gets and sets the property DurationMillis. 
        /// <para>
        /// The duration of the detected segment in milliseconds. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? DurationMillis { get; set; }

        /// <summary>
        /// Checks to see if the DurationMillis property is set.
        /// </summary>
        internal bool IsSetDurationMillis() => this.DurationMillis.HasValue;

        /// <summary>
        /// Gets and sets the property DurationSMPTE. 
        /// <para>
        /// The duration of the timecode for the detected segment in SMPTE format.
        /// </para>
        /// </summary>
        public string DurationSMPTE { get; set; }

        /// <summary>
        /// Checks to see if the DurationSMPTE property is set.
        /// </summary>
        internal bool IsSetDurationSMPTE() => this.DurationSMPTE != null;

        /// <summary>
        /// Gets and sets the property EndFrameNumber. 
        /// <para>
        ///  The frame number at the end of a video segment, using a frame index that starts with
        /// 0. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? EndFrameNumber { get; set; }

        /// <summary>
        /// Checks to see if the EndFrameNumber property is set.
        /// </summary>
        internal bool IsSetEndFrameNumber() => this.EndFrameNumber.HasValue;

        /// <summary>
        /// Gets and sets the property EndTimecodeSMPTE. 
        /// <para>
        /// The frame-accurate SMPTE timecode, from the start of a video, for the end of a detected
        /// segment. <c>EndTimecode</c> is in <i>HH:MM:SS:fr</i> format (and <i>;fr</i> for drop
        /// frame-rates).
        /// </para>
        /// </summary>
        public string EndTimecodeSMPTE { get; set; }

        /// <summary>
        /// Checks to see if the EndTimecodeSMPTE property is set.
        /// </summary>
        internal bool IsSetEndTimecodeSMPTE() => this.EndTimecodeSMPTE != null;

        /// <summary>
        /// Gets and sets the property EndTimestampMillis. 
        /// <para>
        /// The end time of the detected segment, in milliseconds, from the start of the video.
        /// This value is rounded down.
        /// </para>
        /// </summary>
        public long? EndTimestampMillis { get; set; }

        /// <summary>
        /// Checks to see if the EndTimestampMillis property is set.
        /// </summary>
        internal bool IsSetEndTimestampMillis() => this.EndTimestampMillis.HasValue;

        /// <summary>
        /// Gets and sets the property ShotSegment. 
        /// <para>
        /// If the segment is a shot detection, contains information about the shot detection.
        /// </para>
        /// </summary>
        public ShotSegment ShotSegment { get; set; }

        /// <summary>
        /// Checks to see if the ShotSegment property is set.
        /// </summary>
        internal bool IsSetShotSegment() => this.ShotSegment != null;

        /// <summary>
        /// Gets and sets the property StartFrameNumber. 
        /// <para>
        ///  The frame number of the start of a video segment, using a frame index that starts
        /// with 0. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? StartFrameNumber { get; set; }

        /// <summary>
        /// Checks to see if the StartFrameNumber property is set.
        /// </summary>
        internal bool IsSetStartFrameNumber() => this.StartFrameNumber.HasValue;

        /// <summary>
        /// Gets and sets the property StartTimecodeSMPTE. 
        /// <para>
        /// The frame-accurate SMPTE timecode, from the start of a video, for the start of a detected
        /// segment. <c>StartTimecode</c> is in <i>HH:MM:SS:fr</i> format (and <i>;fr</i> for
        /// drop frame-rates). 
        /// </para>
        /// </summary>
        public string StartTimecodeSMPTE { get; set; }

        /// <summary>
        /// Checks to see if the StartTimecodeSMPTE property is set.
        /// </summary>
        internal bool IsSetStartTimecodeSMPTE() => this.StartTimecodeSMPTE != null;

        /// <summary>
        /// Gets and sets the property StartTimestampMillis. 
        /// <para>
        /// The start time of the detected segment in milliseconds from the start of the video.
        /// This value is rounded down. For example, if the actual timestamp is 100.6667 milliseconds,
        /// Amazon Rekognition Video returns a value of 100 millis.
        /// </para>
        /// </summary>
        public long? StartTimestampMillis { get; set; }

        /// <summary>
        /// Checks to see if the StartTimestampMillis property is set.
        /// </summary>
        internal bool IsSetStartTimestampMillis() => this.StartTimestampMillis.HasValue;

        /// <summary>
        /// Gets and sets the property TechnicalCueSegment. 
        /// <para>
        /// If the segment is a technical cue, contains information about the technical cue.
        /// </para>
        /// </summary>
        public TechnicalCueSegment TechnicalCueSegment { get; set; }

        /// <summary>
        /// Checks to see if the TechnicalCueSegment property is set.
        /// </summary>
        internal bool IsSetTechnicalCueSegment() => this.TechnicalCueSegment != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the segment. Valid values are <c>TECHNICAL_CUE</c> and <c>SHOT</c>.
        /// </para>
        /// </summary>
        public SegmentType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
