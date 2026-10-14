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
    /// Information about a label detected in a video analysis request and the time the label
    /// was detected in the video.
    /// </summary>
    public partial class LabelDetection
    {
        /// <summary>
        /// Gets and sets the property DurationMillis. 
        /// <para>
        /// The time duration of a segment in milliseconds, I.e. time elapsed from StartTimestampMillis
        /// to EndTimestampMillis.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? DurationMillis { get; set; }

        /// <summary>
        /// Checks to see if the DurationMillis property is set.
        /// </summary>
        internal bool IsSetDurationMillis() => this.DurationMillis.HasValue;

        /// <summary>
        /// Gets and sets the property EndTimestampMillis. 
        /// <para>
        /// The time in milliseconds defining the end of the timeline segment containing a continuously
        /// detected label.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? EndTimestampMillis { get; set; }

        /// <summary>
        /// Checks to see if the EndTimestampMillis property is set.
        /// </summary>
        internal bool IsSetEndTimestampMillis() => this.EndTimestampMillis.HasValue;

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// Details about the detected label.
        /// </para>
        /// </summary>
        public Label Label { get; set; }

        /// <summary>
        /// Checks to see if the Label property is set.
        /// </summary>
        internal bool IsSetLabel() => this.Label != null;

        /// <summary>
        /// Gets and sets the property StartTimestampMillis. 
        /// <para>
        /// The time in milliseconds defining the start of the timeline segment containing a continuously
        /// detected label.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? StartTimestampMillis { get; set; }

        /// <summary>
        /// Checks to see if the StartTimestampMillis property is set.
        /// </summary>
        internal bool IsSetStartTimestampMillis() => this.StartTimestampMillis.HasValue;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// Time, in milliseconds from the start of the video, that the label was detected. Note
        /// that <c>Timestamp</c> is not guaranteed to be accurate to the individual frame where
        /// the label first appears.
        /// </para>
        /// </summary>
        public long? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;
    }
}
