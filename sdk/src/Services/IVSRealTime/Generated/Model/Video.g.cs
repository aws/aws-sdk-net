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

namespace Amazon.IVSRealTime.Model
{
    /// <summary>
    /// Settings for video.
    /// </summary>
    public partial class Video
    {
        /// <summary>
        /// Gets and sets the property Bitrate. 
        /// <para>
        /// Bitrate for generated output, in bps. Default: 2500000.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 8500000)]
        public int? Bitrate { get; set; }

        /// <summary>
        /// Checks to see if the Bitrate property is set.
        /// </summary>
        internal bool IsSetBitrate() => this.Bitrate.HasValue;

        /// <summary>
        /// Gets and sets the property Framerate. 
        /// <para>
        /// Video frame rate, in fps. Default: 30.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 60)]
        public float? Framerate { get; set; }

        /// <summary>
        /// Checks to see if the Framerate property is set.
        /// </summary>
        internal bool IsSetFramerate() => this.Framerate.HasValue;

        /// <summary>
        /// Gets and sets the property Height. 
        /// <para>
        /// Video-resolution height. This must be an even number. Note that the maximum value
        /// is determined by <c>width</c> times <c>height</c>, such that the maximum total pixels
        /// is 2073600 (1920x1080 or 1080x1920). Default: 720.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 1920)]
        public int? Height { get; set; }

        /// <summary>
        /// Checks to see if the Height property is set.
        /// </summary>
        internal bool IsSetHeight() => this.Height.HasValue;

        /// <summary>
        /// Gets and sets the property Width. 
        /// <para>
        /// Video-resolution width. This must be an even number. Note that the maximum value is
        /// determined by <c>width</c> times <c>height</c>, such that the maximum total pixels
        /// is 2073600 (1920x1080 or 1080x1920). Default: 1280.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 1920)]
        public int? Width { get; set; }

        /// <summary>
        /// Checks to see if the Width property is set.
        /// </summary>
        internal bool IsSetWidth() => this.Width.HasValue;
    }
}
