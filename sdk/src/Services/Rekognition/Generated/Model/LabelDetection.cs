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
    /// Information about a label detected in a video analysis request and the time the label
    /// was detected in the video.
    /// </summary>
    public partial class LabelDetection
    {
        private long? _durationMillis;
        private long? _endTimestampMillis;
        private Label _label;
        private long? _startTimestampMillis;
        private long? _timestamp;

        /// <summary>
        /// Gets and sets the property DurationMillis. 
        /// <para>
        /// The time duration of a segment in milliseconds, I.e. time elapsed from StartTimestampMillis
        /// to EndTimestampMillis.
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
        /// Gets and sets the property EndTimestampMillis. 
        /// <para>
        /// The time in milliseconds defining the end of the timeline segment containing a continuously
        /// detected label.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
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
        /// Gets and sets the property Label. 
        /// <para>
        /// Details about the detected label.
        /// </para>
        /// </summary>
        public Label Label
        {
            get { return this._label; }
            set { this._label = value; }
        }

        // Check to see if Label property is set
        internal bool IsSetLabel()
        {
            return this._label != null;
        }

        /// <summary>
        /// Gets and sets the property StartTimestampMillis. 
        /// <para>
        /// The time in milliseconds defining the start of the timeline segment containing a continuously
        /// detected label.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
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
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// Time, in milliseconds from the start of the video, that the label was detected. Note
        /// that <code>Timestamp</code> is not guaranteed to be accurate to the individual frame
        /// where the label first appears.
        /// </para>
        /// </summary>
        public long Timestamp
        {
            get { return this._timestamp.GetValueOrDefault(); }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

    }
}