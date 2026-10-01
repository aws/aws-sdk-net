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
    /// These settings apply to a specific graphic overlay. You can include multiple overlays
    /// in your job.
    /// </summary>
    public partial class InsertableImage
    {
        /// <summary>
        /// Gets and sets the property Duration. Specify the time, in milliseconds, for the image
        /// to remain on the output video. This duration includes fade-in time but not fade-out
        /// time.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? Duration { get; set; }

        /// <summary>
        /// Checks to see if the Duration property is set.
        /// </summary>
        internal bool IsSetDuration() => this.Duration.HasValue;

        /// <summary>
        /// Gets and sets the property FadeIn. Specify the length of time, in milliseconds, between
        /// the Start time that you specify for the image insertion and the time that the image
        /// appears at full opacity. Full opacity is the level that you specify for the opacity
        /// setting. If you don't specify a value for Fade-in, the image will appear abruptly
        /// at the overlay start time.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? FadeIn { get; set; }

        /// <summary>
        /// Checks to see if the FadeIn property is set.
        /// </summary>
        internal bool IsSetFadeIn() => this.FadeIn.HasValue;

        /// <summary>
        /// Gets and sets the property FadeOut. Specify the length of time, in milliseconds, between
        /// the end of the time that you have specified for the image overlay Duration and when
        /// the overlaid image has faded to total transparency. If you don't specify a value for
        /// Fade-out, the image will disappear abruptly at the end of the inserted image duration.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? FadeOut { get; set; }

        /// <summary>
        /// Checks to see if the FadeOut property is set.
        /// </summary>
        internal bool IsSetFadeOut() => this.FadeOut.HasValue;

        /// <summary>
        /// Gets and sets the property Height. Specify the height of the inserted image in pixels.
        /// If you specify a value that's larger than the video resolution height, the service
        /// will crop your overlaid image to fit. To use the native height of the image, keep
        /// this setting blank.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? Height { get; set; }

        /// <summary>
        /// Checks to see if the Height property is set.
        /// </summary>
        internal bool IsSetHeight() => this.Height.HasValue;

        /// <summary>
        /// Gets and sets the property ImageInserterInput. Specify the HTTP, HTTPS, or Amazon
        /// S3 location of the image that you want to overlay on the video. Use a PNG or TGA file.
        /// </summary>
        [AWSProperty(Min = 14)]
        public string ImageInserterInput { get; set; }

        /// <summary>
        /// Checks to see if the ImageInserterInput property is set.
        /// </summary>
        internal bool IsSetImageInserterInput() => this.ImageInserterInput != null;

        /// <summary>
        /// Gets and sets the property ImageX. Specify the distance, in pixels, between the inserted
        /// image and the left edge of the video frame. Required for any image overlay that you
        /// specify.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? ImageX { get; set; }

        /// <summary>
        /// Checks to see if the ImageX property is set.
        /// </summary>
        internal bool IsSetImageX() => this.ImageX.HasValue;

        /// <summary>
        /// Gets and sets the property ImageY. Specify the distance, in pixels, between the overlaid
        /// image and the top edge of the video frame. Required for any image overlay that you
        /// specify.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? ImageY { get; set; }

        /// <summary>
        /// Checks to see if the ImageY property is set.
        /// </summary>
        internal bool IsSetImageY() => this.ImageY.HasValue;

        /// <summary>
        /// Gets and sets the property Layer. Specify how overlapping inserted images appear.
        /// Images with higher values for Layer appear on top of images with lower values for
        /// Layer.
        /// </summary>
        [AWSProperty(Min = 0, Max = 99)]
        public int? Layer { get; set; }

        /// <summary>
        /// Checks to see if the Layer property is set.
        /// </summary>
        internal bool IsSetLayer() => this.Layer.HasValue;

        /// <summary>
        /// Gets and sets the property Opacity. Use Opacity to specify how much of the underlying
        /// video shows through the inserted image. 0 is transparent and 100 is fully opaque.
        /// Default is 50.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public int? Opacity { get; set; }

        /// <summary>
        /// Checks to see if the Opacity property is set.
        /// </summary>
        internal bool IsSetOpacity() => this.Opacity.HasValue;

        /// <summary>
        /// Gets and sets the property StartTime. Specify the timecode of the frame that you want
        /// the overlay to first appear on. This must be in timecode (HH:MM:SS:FF or HH:MM:SS;FF)
        /// format. Remember to take into account your timecode source settings.
        /// </summary>
        public string StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime != null;

        /// <summary>
        /// Gets and sets the property Width. Specify the width of the inserted image in pixels.
        /// If you specify a value that's larger than the video resolution width, the service
        /// will crop your overlaid image to fit. To use the native width of the image, keep this
        /// setting blank.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? Width { get; set; }

        /// <summary>
        /// Checks to see if the Width property is set.
        /// </summary>
        internal bool IsSetWidth() => this.Width.HasValue;
    }
}
