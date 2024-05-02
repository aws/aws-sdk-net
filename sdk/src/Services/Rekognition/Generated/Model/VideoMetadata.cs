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
    /// Information about a video that Amazon Rekognition analyzed. <c>Videometadata</c> is
    /// returned in every page of paginated responses from a Amazon Rekognition video operation.
    /// </summary>
    public partial class VideoMetadata
    {
        private string _codec;
        private VideoColorRange _colorRange;
        private long? _durationMillis;
        private string _format;
        private long? _frameHeight;
        private float? _frameRate;
        private long? _frameWidth;

        /// <summary>
        /// Gets and sets the property Codec. 
        /// <para>
        /// Type of compression used in the analyzed video. 
        /// </para>
        /// </summary>
        public string Codec
        {
            get { return this._codec; }
            set { this._codec = value; }
        }

        // Check to see if Codec property is set
        internal bool IsSetCodec()
        {
            return this._codec != null;
        }

        /// <summary>
        /// Gets and sets the property ColorRange. 
        /// <para>
        ///  A description of the range of luminance values in a video, either LIMITED (16 to
        /// 235) or FULL (0 to 255). 
        /// </para>
        /// </summary>
        public VideoColorRange ColorRange
        {
            get { return this._colorRange; }
            set { this._colorRange = value; }
        }

        // Check to see if ColorRange property is set
        internal bool IsSetColorRange()
        {
            return this._colorRange != null;
        }

        /// <summary>
        /// Gets and sets the property DurationMillis. 
        /// <para>
        /// Length of the video in milliseconds.
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
        /// Gets and sets the property Format. 
        /// <para>
        /// Format of the analyzed video. Possible values are MP4, MOV and AVI. 
        /// </para>
        /// </summary>
        public string Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property FrameHeight. 
        /// <para>
        /// Vertical pixel dimension of the video.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? FrameHeight
        {
            get { return this._frameHeight; }
            set { this._frameHeight = value; }
        }

        // Check to see if FrameHeight property is set
        internal bool IsSetFrameHeight()
        {
            return this._frameHeight.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FrameRate. 
        /// <para>
        /// Number of frames per second in the video.
        /// </para>
        /// </summary>
        public float? FrameRate
        {
            get { return this._frameRate; }
            set { this._frameRate = value; }
        }

        // Check to see if FrameRate property is set
        internal bool IsSetFrameRate()
        {
            return this._frameRate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FrameWidth. 
        /// <para>
        /// Horizontal pixel dimension of the video.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? FrameWidth
        {
            get { return this._frameWidth; }
            set { this._frameWidth = value; }
        }

        // Check to see if FrameWidth property is set
        internal bool IsSetFrameWidth()
        {
            return this._frameWidth.HasValue; 
        }

    }
}