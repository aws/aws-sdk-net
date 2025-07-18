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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Information about an inappropriate, unwanted, or offensive content label detection
    /// in a stored video.
    /// </summary>
    public partial class ContentModerationDetection
    {
        private List<ContentType> _contentTypes = AWSConfigs.InitializeCollections ? new List<ContentType>() : null;
        private long? _durationMillis;
        private long? _endTimestampMillis;
        private ModerationLabel _moderationLabel;
        private long? _startTimestampMillis;
        private long? _timestamp;

        /// <summary>
        /// Gets and sets the property ContentTypes. 
        /// <para>
        /// A list of predicted results for the type of content an image contains. For example,
        /// the image content might be from animation, sports, or a video game.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<ContentType> ContentTypes
        {
            get { return this._contentTypes; }
            set { this._contentTypes = value; }
        }

        // Check to see if ContentTypes property is set
        internal bool IsSetContentTypes()
        {
            return this._contentTypes != null && (this._contentTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DurationMillis. 
        /// <para>
        ///  The time duration of a segment in milliseconds, I.e. time elapsed from StartTimestampMillis
        /// to EndTimestampMillis. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? DurationMillis
        {
            get { return this._durationMillis; }
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
        ///  The time in milliseconds defining the end of the timeline segment containing a continuously
        /// detected moderation label. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? EndTimestampMillis
        {
            get { return this._endTimestampMillis; }
            set { this._endTimestampMillis = value; }
        }

        // Check to see if EndTimestampMillis property is set
        internal bool IsSetEndTimestampMillis()
        {
            return this._endTimestampMillis.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModerationLabel. 
        /// <para>
        /// The content moderation label detected by in the stored video.
        /// </para>
        /// </summary>
        public ModerationLabel ModerationLabel
        {
            get { return this._moderationLabel; }
            set { this._moderationLabel = value; }
        }

        // Check to see if ModerationLabel property is set
        internal bool IsSetModerationLabel()
        {
            return this._moderationLabel != null;
        }

        /// <summary>
        /// Gets and sets the property StartTimestampMillis. 
        /// <para>
        /// The time in milliseconds defining the start of the timeline segment containing a continuously
        /// detected moderation label.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? StartTimestampMillis
        {
            get { return this._startTimestampMillis; }
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
        /// Time, in milliseconds from the beginning of the video, that the content moderation
        /// label was detected. Note that <c>Timestamp</c> is not guaranteed to be accurate to
        /// the individual frame where the moderated content first appears.
        /// </para>
        /// </summary>
        public long? Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

    }
}