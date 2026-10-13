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
    /// Information about a video that Amazon Rekognition analyzed. <c>Videometadata</c> is
    /// returned in every page of paginated responses from a Amazon Rekognition video operation.
    /// </summary>
    public partial class VideoMetadata
    {
        /// <summary>
        /// Gets and sets the property Codec. 
        /// <para>
        /// Type of compression used in the analyzed video. 
        /// </para>
        /// </summary>
        public string Codec { get; set; }

        /// <summary>
        /// Checks to see if the Codec property is set.
        /// </summary>
        internal bool IsSetCodec() => this.Codec != null;

        /// <summary>
        /// Gets and sets the property ColorRange. 
        /// <para>
        ///  A description of the range of luminance values in a video, either LIMITED (16 to
        /// 235) or FULL (0 to 255). 
        /// </para>
        /// </summary>
        public VideoColorRange ColorRange { get; set; }

        /// <summary>
        /// Checks to see if the ColorRange property is set.
        /// </summary>
        internal bool IsSetColorRange() => this.ColorRange != null;

        /// <summary>
        /// Gets and sets the property DurationMillis. 
        /// <para>
        /// Length of the video in milliseconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? DurationMillis { get; set; }

        /// <summary>
        /// Checks to see if the DurationMillis property is set.
        /// </summary>
        internal bool IsSetDurationMillis() => this.DurationMillis.HasValue;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// Format of the analyzed video. Possible values are MP4, MOV and AVI. 
        /// </para>
        /// </summary>
        public string Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property FrameHeight. 
        /// <para>
        /// Vertical pixel dimension of the video.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? FrameHeight { get; set; }

        /// <summary>
        /// Checks to see if the FrameHeight property is set.
        /// </summary>
        internal bool IsSetFrameHeight() => this.FrameHeight.HasValue;

        /// <summary>
        /// Gets and sets the property FrameRate. 
        /// <para>
        /// Number of frames per second in the video.
        /// </para>
        /// </summary>
        public float? FrameRate { get; set; }

        /// <summary>
        /// Checks to see if the FrameRate property is set.
        /// </summary>
        internal bool IsSetFrameRate() => this.FrameRate.HasValue;

        /// <summary>
        /// Gets and sets the property FrameWidth. 
        /// <para>
        /// Horizontal pixel dimension of the video.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? FrameWidth { get; set; }

        /// <summary>
        /// Checks to see if the FrameWidth property is set.
        /// </summary>
        internal bool IsSetFrameWidth() => this.FrameWidth.HasValue;
    }
}
