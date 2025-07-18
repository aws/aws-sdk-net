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
    /// Specify a rectangle of content to crop and use from your video overlay's input video.
    /// When you do, MediaConvert uses the cropped dimensions that you specify under X offset,
    /// Y offset, Width, and Height.
    /// </summary>
    public partial class VideoOverlayCrop
    {
        private int? _height;
        private VideoOverlayUnit _unit;
        private int? _width;
        private int? _x;
        private int? _y;

        /// <summary>
        /// Gets and sets the property Height. Specify the height of the video overlay cropping
        /// rectangle. To use the same height as your overlay input video: Keep blank, or enter
        /// 0. To specify a different height for the cropping rectangle: Enter an integer representing
        /// the Unit type that you choose, either Pixels or Percentage. For example, when you
        /// enter 100 and choose Pixels, the cropping rectangle will be 100 pixels high. When
        /// you enter 10, choose Percentage, and your overlay input video is 1920x1080, the cropping
        /// rectangle will be 108 pixels high.
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
        /// Gets and sets the property Unit. Specify the Unit type to use when you enter a value
        /// for X position, Y position, Width, or Height. You can choose Pixels or Percentage.
        /// Leave blank to use the default value, Pixels.
        /// </summary>
        public VideoOverlayUnit Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit != null;
        }

        /// <summary>
        /// Gets and sets the property Width. Specify the width of the video overlay cropping
        /// rectangle. To use the same width as your overlay input video: Keep blank, or enter
        /// 0. To specify a different width for the cropping rectangle: Enter an integer representing
        /// the Unit type that you choose, either Pixels or Percentage. For example, when you
        /// enter 100 and choose Pixels, the cropping rectangle will be 100 pixels wide. When
        /// you enter 10, choose Percentage, and your overlay input video is 1920x1080, the cropping
        /// rectangle will be 192 pixels wide.
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

        /// <summary>
        /// Gets and sets the property X. Specify the distance between the cropping rectangle
        /// and the left edge of your overlay video's frame. To position the cropping rectangle
        /// along the left edge: Keep blank, or enter 0. To position the cropping rectangle to
        /// the right, relative to the left edge of your overlay video's frame: Enter an integer
        /// representing the Unit type that you choose, either Pixels or Percentage. For example,
        /// when you enter 10 and choose Pixels, the cropping rectangle will be positioned 10
        /// pixels from the left edge of the overlay video's frame. When you enter 10, choose
        /// Percentage, and your overlay input video is 1920x1080, the cropping rectangle will
        /// be positioned 192 pixels from the left edge of the overlay video's frame.
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? X
        {
            get { return this._x; }
            set { this._x = value; }
        }

        // Check to see if X property is set
        internal bool IsSetX()
        {
            return this._x.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Y. Specify the distance between the cropping rectangle
        /// and the top edge of your overlay video's frame. To position the cropping rectangle
        /// along the top edge: Keep blank, or enter 0. To position the cropping rectangle down,
        /// relative to the top edge of your overlay video's frame: Enter an integer representing
        /// the Unit type that you choose, either Pixels or Percentage. For example, when you
        /// enter 10 and choose Pixels, the cropping rectangle will be positioned 10 pixels from
        /// the top edge of the overlay video's frame. When you enter 10, choose Percentage, and
        /// your overlay input video is 1920x1080, the cropping rectangle will be positioned 108
        /// pixels from the top edge of the overlay video's frame.
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? Y
        {
            get { return this._y; }
            set { this._y = value; }
        }

        // Check to see if Y property is set
        internal bool IsSetY()
        {
            return this._y.HasValue; 
        }

    }
}