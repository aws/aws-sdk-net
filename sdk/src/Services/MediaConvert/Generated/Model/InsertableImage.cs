/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Settings for Insertable Image
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
        /// Gets and sets the property Duration. Use Duration (Duration) to set the time, in milliseconds,
        /// for the image to remain on the output video.
        /// </summary>
        public int Duration
        {
            get { return this._duration.GetValueOrDefault(); }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FadeIn. Use Fade in (FadeIut) to set the length, in milliseconds,
        /// of the inserted image fade in. If you don't specify a value for Fade in, the image
        /// will appear abruptly at the Start time.
        /// </summary>
        public int FadeIn
        {
            get { return this._fadeIn.GetValueOrDefault(); }
            set { this._fadeIn = value; }
        }

        // Check to see if FadeIn property is set
        internal bool IsSetFadeIn()
        {
            return this._fadeIn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FadeOut. Use Fade out (FadeOut) to set the length, in milliseconds,
        /// of the inserted image fade out. If you don't specify a value for Fade out, the image
        /// will disappear abruptly at the end of the inserted image duration.
        /// </summary>
        public int FadeOut
        {
            get { return this._fadeOut.GetValueOrDefault(); }
            set { this._fadeOut = value; }
        }

        // Check to see if FadeOut property is set
        internal bool IsSetFadeOut()
        {
            return this._fadeOut.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Height. Specify the Height (Height) of the inserted image.
        /// Use a value that is less than or equal to the video resolution height. Leave this
        /// setting blank to use the native height of the image.
        /// </summary>
        public int Height
        {
            get { return this._height.GetValueOrDefault(); }
            set { this._height = value; }
        }

        // Check to see if Height property is set
        internal bool IsSetHeight()
        {
            return this._height.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImageInserterInput. Use Image location (imageInserterInput)
        /// to specify the Amazon S3 location of the image to be inserted into the output. Use
        /// a 32 bit BMP, PNG, or TGA file that fits inside the video frame.
        /// </summary>
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
        /// Gets and sets the property ImageX. Use Left (ImageX) to set the distance, in pixels,
        /// between the inserted image and the left edge of the frame. Required for BMP, PNG and
        /// TGA input.
        /// </summary>
        public int ImageX
        {
            get { return this._imageX.GetValueOrDefault(); }
            set { this._imageX = value; }
        }

        // Check to see if ImageX property is set
        internal bool IsSetImageX()
        {
            return this._imageX.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImageY. Use Top (ImageY) to set the distance, in pixels,
        /// between the inserted image and the top edge of the video frame. Required for BMP,
        /// PNG and TGA input.
        /// </summary>
        public int ImageY
        {
            get { return this._imageY.GetValueOrDefault(); }
            set { this._imageY = value; }
        }

        // Check to see if ImageY property is set
        internal bool IsSetImageY()
        {
            return this._imageY.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Layer. Use Layer (Layer) to specify how overlapping inserted
        /// images appear. Images with higher values of layer appear on top of images with lower
        /// values of layer.
        /// </summary>
        public int Layer
        {
            get { return this._layer.GetValueOrDefault(); }
            set { this._layer = value; }
        }

        // Check to see if Layer property is set
        internal bool IsSetLayer()
        {
            return this._layer.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Opacity. Use Opacity (Opacity) to specify how much of the
        /// underlying video shows through the inserted image. 0 is transparent and 100 is fully
        /// opaque. Default is 50.
        /// </summary>
        public int Opacity
        {
            get { return this._opacity.GetValueOrDefault(); }
            set { this._opacity = value; }
        }

        // Check to see if Opacity property is set
        internal bool IsSetOpacity()
        {
            return this._opacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. Use Start time (StartTime) to specify the video
        /// timecode when the image is inserted in the output. This must be in timecode (HH:MM:SS:FF
        /// or HH:MM:SS;FF) format.
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
        /// Gets and sets the property Width. Specify the Width (Width) of the inserted image.
        /// Use a value that is less than or equal to the video resolution width. Leave this setting
        /// blank to use the native width of the image.
        /// </summary>
        public int Width
        {
            get { return this._width.GetValueOrDefault(); }
            set { this._width = value; }
        }

        // Check to see if Width property is set
        internal bool IsSetWidth()
        {
            return this._width.HasValue; 
        }

    }
}