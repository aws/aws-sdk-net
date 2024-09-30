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
    /// position of video overlay
    /// </summary>
    public partial class VideoOverlayPosition
    {
        private int? _height;
        private VideoOverlayUnit _unit;
        private int? _width;
        private int? _xPosition;
        private int? _yPosition;

        /// <summary>
        /// Gets and sets the property Height. To scale your video overlay to the same height
        /// as the base input video: Leave blank. To scale the height of your video overlay to
        /// a different height: Enter an integer representing the Unit type that you choose, either
        /// Pixels or Percentage. For example, when you enter 360 and choose Pixels, your video
        /// overlay will be rendered with a height of 360. When you enter 50, choose Percentage,
        /// and your overlay's source has a height of 1080, your video overlay will be rendered
        /// with a height of 540. To scale your overlay to a specific height while automatically
        /// maintaining its original aspect ratio, enter a value for Height and leave Width blank.
        /// </summary>
        [AWSProperty(Min=-1, Max=2147483647)]
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
        /// Gets and sets the property Width. To scale your video overlay to the same width as
        /// the base input video: Leave blank. To scale the width of your video overlay to a different
        /// width: Enter an integer representing the Unit type that you choose, either Pixels
        /// or Percentage. For example, when you enter 640 and choose Pixels, your video overlay
        /// will scale to a height of 640 pixels. When you enter 50, choose Percentage, and your
        /// overlay's source has a width of 1920, your video overlay will scale to a width of
        /// 960. To scale your overlay to a specific width while automatically maintaining its
        /// original aspect ratio, enter a value for Width and leave Height blank.
        /// </summary>
        [AWSProperty(Min=-1, Max=2147483647)]
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
        /// Gets and sets the property XPosition. To position the left edge of your video overlay
        /// along the left edge of the base input video's frame: Keep blank, or enter 0. To position
        /// the left edge of your video overlay to the right, relative to the left edge of the
        /// base input video's frame: Enter an integer representing the Unit type that you choose,
        /// either Pixels or Percentage. For example, when you enter 10 and choose Pixels, your
        /// video overlay will be positioned 10 pixels from the left edge of the base input video's
        /// frame. When you enter 10, choose Percentage, and your base input video is 1920x1080,
        /// your video overlay will be positioned 192 pixels from the left edge of the base input
        /// video's frame.
        /// </summary>
        [AWSProperty(Min=-2147483648, Max=2147483647)]
        public int? XPosition
        {
            get { return this._xPosition; }
            set { this._xPosition = value; }
        }

        // Check to see if XPosition property is set
        internal bool IsSetXPosition()
        {
            return this._xPosition.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property YPosition. To position the top edge of your video overlay
        /// along the top edge of the base input video's frame: Keep blank, or enter 0. To position
        /// the top edge of your video overlay down, relative to the top edge of the base input
        /// video's frame: Enter an integer representing the Unit type that you choose, either
        /// Pixels or Percentage. For example, when you enter 10 and choose Pixels, your video
        /// overlay will be positioned 10 pixels from the top edge of the base input video's frame.
        /// When you enter 10, choose Percentage, and your underlying video is 1920x1080, your
        /// video overlay will be positioned 108 pixels from the top edge of the base input video's
        /// frame.
        /// </summary>
        [AWSProperty(Min=-2147483648, Max=2147483647)]
        public int? YPosition
        {
            get { return this._yPosition; }
            set { this._yPosition = value; }
        }

        // Check to see if YPosition property is set
        internal bool IsSetYPosition()
        {
            return this._yPosition.HasValue; 
        }

    }
}