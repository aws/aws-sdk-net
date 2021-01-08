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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// A technical cue or shot detection segment detected in a video. An array of <code>SegmentDetection</code>
    /// objects containing all segments detected in a stored video is returned by <a>GetSegmentDetection</a>.
    /// </summary>
    public partial class SegmentDetection
    {
        private long? _durationMillis;
        private string _durationSMPTE;
        private string _endTimecodeSMPTE;
        private long? _endTimestampMillis;
        private ShotSegment _shotSegment;
        private string _startTimecodeSMPTE;
        private long? _startTimestampMillis;
        private TechnicalCueSegment _technicalCueSegment;
        private SegmentType _type;

        /// <summary>
        /// Gets and sets the property DurationMillis. 
        /// <para>
        /// The duration of the detected segment in milliseconds. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long DurationMillis
        {
            get { return this._durationMillis.GetValueOrDefault(); }
            set { this._durationMillis = value; }
        }

        // Check to see if DurationMillis property is set
        internal bool IsSetDurationMillis()
        {
            return this._durationMillis.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DurationSMPTE. 
        /// <para>
        /// The duration of the timecode for the detected segment in SMPTE format.
        /// </para>
        /// </summary>
        public string DurationSMPTE
        {
            get { return this._durationSMPTE; }
            set { this._durationSMPTE = value; }
        }

        // Check to see if DurationSMPTE property is set
        internal bool IsSetDurationSMPTE()
        {
            return this._durationSMPTE != null;
        }

        /// <summary>
        /// Gets and sets the property EndTimecodeSMPTE. 
        /// <para>
        /// The frame-accurate SMPTE timecode, from the start of a video, for the end of a detected
        /// segment. <code>EndTimecode</code> is in <i>HH:MM:SS:fr</i> format (and <i>;fr</i>
        /// for drop frame-rates).
        /// </para>
        /// </summary>
        public string EndTimecodeSMPTE
        {
            get { return this._endTimecodeSMPTE; }
            set { this._endTimecodeSMPTE = value; }
        }

        // Check to see if EndTimecodeSMPTE property is set
        internal bool IsSetEndTimecodeSMPTE()
        {
            return this._endTimecodeSMPTE != null;
        }

        /// <summary>
        /// Gets and sets the property EndTimestampMillis. 
        /// <para>
        /// The end time of the detected segment, in milliseconds, from the start of the video.
        /// This value is rounded down.
        /// </para>
        /// </summary>
        public long EndTimestampMillis
        {
            get { return this._endTimestampMillis.GetValueOrDefault(); }
            set { this._endTimestampMillis = value; }
        }

        // Check to see if EndTimestampMillis property is set
        internal bool IsSetEndTimestampMillis()
        {
            return this._endTimestampMillis.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ShotSegment. 
        /// <para>
        /// If the segment is a shot detection, contains information about the shot detection.
        /// </para>
        /// </summary>
        public ShotSegment ShotSegment
        {
            get { return this._shotSegment; }
            set { this._shotSegment = value; }
        }

        // Check to see if ShotSegment property is set
        internal bool IsSetShotSegment()
        {
            return this._shotSegment != null;
        }

        /// <summary>
        /// Gets and sets the property StartTimecodeSMPTE. 
        /// <para>
        /// The frame-accurate SMPTE timecode, from the start of a video, for the start of a detected
        /// segment. <code>StartTimecode</code> is in <i>HH:MM:SS:fr</i> format (and <i>;fr</i>
        /// for drop frame-rates). 
        /// </para>
        /// </summary>
        public string StartTimecodeSMPTE
        {
            get { return this._startTimecodeSMPTE; }
            set { this._startTimecodeSMPTE = value; }
        }

        // Check to see if StartTimecodeSMPTE property is set
        internal bool IsSetStartTimecodeSMPTE()
        {
            return this._startTimecodeSMPTE != null;
        }

        /// <summary>
        /// Gets and sets the property StartTimestampMillis. 
        /// <para>
        /// The start time of the detected segment in milliseconds from the start of the video.
        /// This value is rounded down. For example, if the actual timestamp is 100.6667 milliseconds,
        /// Amazon Rekognition Video returns a value of 100 millis.
        /// </para>
        /// </summary>
        public long StartTimestampMillis
        {
            get { return this._startTimestampMillis.GetValueOrDefault(); }
            set { this._startTimestampMillis = value; }
        }

        // Check to see if StartTimestampMillis property is set
        internal bool IsSetStartTimestampMillis()
        {
            return this._startTimestampMillis.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TechnicalCueSegment. 
        /// <para>
        /// If the segment is a technical cue, contains information about the technical cue.
        /// </para>
        /// </summary>
        public TechnicalCueSegment TechnicalCueSegment
        {
            get { return this._technicalCueSegment; }
            set { this._technicalCueSegment = value; }
        }

        // Check to see if TechnicalCueSegment property is set
        internal bool IsSetTechnicalCueSegment()
        {
            return this._technicalCueSegment != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the segment. Valid values are <code>TECHNICAL_CUE</code> and <code>SHOT</code>.
        /// </para>
        /// </summary>
        public SegmentType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}