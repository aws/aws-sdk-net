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
    /// When you include Video generator, MediaConvert creates a video input with black frames.
    /// Use this setting if you do not have a video input or if you want to add black video
    /// frames before, or after, other inputs. You can specify Video generator, or you can
    /// specify an Input file, but you cannot specify both. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/video-generator.html
    /// </summary>
    public partial class InputVideoGenerator
    {
        /// <summary>
        /// Gets and sets the property Channels. Specify the number of audio channels to include
        /// in your video generator input. MediaConvert creates these audio channels as silent
        /// audio within a single audio track. Enter an integer from 1 to 32.
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public int? Channels { get; set; }

        /// <summary>
        /// Checks to see if the Channels property is set.
        /// </summary>
        internal bool IsSetChannels() => this.Channels.HasValue;

        /// <summary>
        /// Gets and sets the property Duration. Specify the duration, in milliseconds, for your
        /// video generator input. Enter an integer from 1 to 86400000.
        /// </summary>
        [AWSProperty(Min = 1, Max = 86400000)]
        public int? Duration { get; set; }

        /// <summary>
        /// Checks to see if the Duration property is set.
        /// </summary>
        internal bool IsSetDuration() => this.Duration.HasValue;

        /// <summary>
        /// Gets and sets the property FramerateDenominator. Specify the denominator of the fraction
        /// that represents the frame rate for your video generator input. When you do, you must
        /// also specify a value for Frame rate numerator. MediaConvert uses a default frame rate
        /// of 29.97 when you leave Frame rate numerator and Frame rate denominator blank.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1001)]
        public int? FramerateDenominator { get; set; }

        /// <summary>
        /// Checks to see if the FramerateDenominator property is set.
        /// </summary>
        internal bool IsSetFramerateDenominator() => this.FramerateDenominator.HasValue;

        /// <summary>
        /// Gets and sets the property FramerateNumerator. Specify the numerator of the fraction
        /// that represents the frame rate for your video generator input. When you do, you must
        /// also specify a value for Frame rate denominator. MediaConvert uses a default frame
        /// rate of 29.97 when you leave Frame rate numerator and Frame rate denominator blank.
        /// </summary>
        [AWSProperty(Min = 1, Max = 60000)]
        public int? FramerateNumerator { get; set; }

        /// <summary>
        /// Checks to see if the FramerateNumerator property is set.
        /// </summary>
        internal bool IsSetFramerateNumerator() => this.FramerateNumerator.HasValue;

        /// <summary>
        /// Gets and sets the property Height. Specify the height, in pixels, for your video generator
        /// input. This is useful for positioning when you include one or more video overlays
        /// for this input. To use the default resolution 540x360: Leave both width and height
        /// blank. To specify a height: Enter an even integer from 32 to 8192. When you do, you
        /// must also specify a value for width.
        /// </summary>
        [AWSProperty(Min = 32, Max = 8192)]
        public int? Height { get; set; }

        /// <summary>
        /// Checks to see if the Height property is set.
        /// </summary>
        internal bool IsSetHeight() => this.Height.HasValue;

        /// <summary>
        /// Gets and sets the property ImageInput. Specify the HTTP, HTTPS, or Amazon S3 location
        /// of the image that you want to overlay on the video. Use a PNG or TGA file.
        /// </summary>
        [AWSProperty(Min = 14)]
        public string ImageInput { get; set; }

        /// <summary>
        /// Checks to see if the ImageInput property is set.
        /// </summary>
        internal bool IsSetImageInput() => this.ImageInput != null;

        /// <summary>
        /// Gets and sets the property SampleRate. Specify the audio sample rate, in Hz, for the
        /// silent audio in your video generator input. Enter an integer from 32000 to 48000.
        /// </summary>
        [AWSProperty(Min = 32000, Max = 48000)]
        public int? SampleRate { get; set; }

        /// <summary>
        /// Checks to see if the SampleRate property is set.
        /// </summary>
        internal bool IsSetSampleRate() => this.SampleRate.HasValue;

        /// <summary>
        /// Gets and sets the property Width. Specify the width, in pixels, for your video generator
        /// input. This is useful for positioning when you include one or more video overlays
        /// for this input. To use the default resolution 540x360: Leave both width and height
        /// blank. To specify a width: Enter an even integer from 32 to 8192. When you do, you
        /// must also specify a value for height.
        /// </summary>
        [AWSProperty(Min = 32, Max = 8192)]
        public int? Width { get; set; }

        /// <summary>
        /// Checks to see if the Width property is set.
        /// </summary>
        internal bool IsSetWidth() => this.Width.HasValue;
    }
}
