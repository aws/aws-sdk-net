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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
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
        private int? _duration;
        private int? _fadeIn;
        private int? _fadeOut;
        private int? _height;
        private string _imageInserterInput;
        private int? _imageX;
        private int? _imageY;
        private int? _layer;
        private int? _opacity;
        private string _startTime;
        private int? _width;

        /// <summary>
        /// Gets and sets the property Duration. Specify the time, in milliseconds, for the image
        /// to remain on the output video. This duration includes fade-in time but not fade-out
        /// time.
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? Duration
        {
            get { return this._duration; }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FadeIn. Specify the length of time, in milliseconds, between
        /// the Start time that you specify for the image insertion and the time that the image
        /// appears at full opacity. Full opacity is the level that you specify for the opacity
        /// setting. If you don't specify a value for Fade-in, the image will appear abruptly
        /// at the overlay start time.
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? FadeIn
        {
            get { return this._fadeIn; }
            set { this._fadeIn = value; }
        }

        // Check to see if FadeIn property is set
        internal bool IsSetFadeIn()
        {
            return this._fadeIn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FadeOut. Specify the length of time, in milliseconds, between
        /// the end of the time that you have specified for the image overlay Duration and when
        /// the overlaid image has faded to total transparency. If you don't specify a value for
        /// Fade-out, the image will disappear abruptly at the end of the inserted image duration.
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? FadeOut
        {
            get { return this._fadeOut; }
            set { this._fadeOut = value; }
        }

        // Check to see if FadeOut property is set
        internal bool IsSetFadeOut()
        {
            return this._fadeOut.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Height. Specify the height of the inserted image in pixels.
        /// If you specify a value that's larger than the video resolution height, the service
        /// will crop your overlaid image to fit. To use the native height of the image, keep
        /// this setting blank.
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? Height
        {
            get { return this._height; }
            set { this._height = value; }
        }

        // Check to see if Height property is set
        internal bool IsSetHeight()
        {
            return this._height.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImageInserterInput. Specify the HTTP, HTTPS, or Amazon
        /// S3 location of the image that you want to overlay on the video. Use a PNG or TGA file.
        /// </summary>
        [AWSProperty(Min=14)]
        public string ImageInserterInput
        {
            get { return this._imageInserterInput; }
            set { this._imageInserterInput = value; }
        }

        // Check to see if ImageInserterInput property is set
        internal bool IsSetImageInserterInput()
        {
            return this._imageInserterInput != null;
        }

        /// <summary>
        /// Gets and sets the property ImageX. Specify the distance, in pixels, between the inserted
        /// image and the left edge of the video frame. Required for any image overlay that you
        /// specify.
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? ImageX
        {
            get { return this._imageX; }
            set { this._imageX = value; }
        }

        // Check to see if ImageX property is set
        internal bool IsSetImageX()
        {
            return this._imageX.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImageY. Specify the distance, in pixels, between the overlaid
        /// image and the top edge of the video frame. Required for any image overlay that you
        /// specify.
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? ImageY
        {
            get { return this._imageY; }
            set { this._imageY = value; }
        }

        // Check to see if ImageY property is set
        internal bool IsSetImageY()
        {
            return this._imageY.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Layer. Specify how overlapping inserted images appear.
        /// Images with higher values for Layer appear on top of images with lower values for
        /// Layer.
        /// </summary>
        [AWSProperty(Min=0, Max=99)]
        public int? Layer
        {
            get { return this._layer; }
            set { this._layer = value; }
        }

        // Check to see if Layer property is set
        internal bool IsSetLayer()
        {
            return this._layer.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Opacity. Use Opacity to specify how much of the underlying
        /// video shows through the inserted image. 0 is transparent and 100 is fully opaque.
        /// Default is 50.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int? Opacity
        {
            get { return this._opacity; }
            set { this._opacity = value; }
        }

        // Check to see if Opacity property is set
        internal bool IsSetOpacity()
        {
            return this._opacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. Specify the timecode of the frame that you want
        /// the overlay to first appear on. This must be in timecode (HH:MM:SS:FF or HH:MM:SS;FF)
        /// format. Remember to take into account your timecode source settings.
        /// </summary>
        public string StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime != null;
        }

        /// <summary>
        /// Gets and sets the property Width. Specify the width of the inserted image in pixels.
        /// If you specify a value that's larger than the video resolution width, the service
        /// will crop your overlaid image to fit. To use the native width of the image, keep this
        /// setting blank.
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? Width
        {
            get { return this._width; }
            set { this._width = value; }
        }

        // Check to see if Width property is set
        internal bool IsSetWidth()
        {
            return this._width.HasValue; 
        }

    }
}