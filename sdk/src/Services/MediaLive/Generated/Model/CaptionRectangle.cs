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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Caption Rectangle
    /// </summary>
    public partial class CaptionRectangle
    {
        private double? _height;
        private double? _leftOffset;
        private double? _topOffset;
        private double? _width;

        /// <summary>
        /// Gets and sets the property Height. See the description in leftOffset.For height, specify
        /// the entire height of the rectangle as a percentage of the underlying frame height.
        /// For example, \"80\" means the rectangle height is 80% of the underlying frame height.
        /// The topOffset and rectangleHeight must add up to 100% or less.This field corresponds
        /// to tts:extent - Y in the TTML standard.
        /// </summary>
        [AWSProperty(Required=true)]
        public double? Height
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
        /// Gets and sets the property LeftOffset. Applies only if you plan to convert these source
        /// captions to EBU-TT-D or TTML in an output. (Make sure to leave the default if you
        /// don't have either of these formats in the output.) You can define a display rectangle
        /// for the captions that is smaller than the underlying video frame. You define the rectangle
        /// by specifying the position of the left edge, top edge, bottom edge, and right edge
        /// of the rectangle, all within the underlying video frame. The units for the measurements
        /// are percentages.If you specify a value for one of these fields, you must specify a
        /// value for all of them.For leftOffset, specify the position of the left edge of the
        /// rectangle, as a percentage of the underlying frame width, and relative to the left
        /// edge of the frame. For example, \"10\" means the measurement is 10% of the underlying
        /// frame width. The rectangle left edge starts at that position from the left edge of
        /// the frame.This field corresponds to tts:origin - X in the TTML standard.
        /// </summary>
        [AWSProperty(Required=true)]
        public double? LeftOffset
        {
            get { return this._leftOffset; }
            set { this._leftOffset = value; }
        }

        // Check to see if LeftOffset property is set
        internal bool IsSetLeftOffset()
        {
            return this._leftOffset.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TopOffset. See the description in leftOffset.For topOffset,
        /// specify the position of the top edge of the rectangle, as a percentage of the underlying
        /// frame height, and relative to the top edge of the frame. For example, \"10\" means
        /// the measurement is 10% of the underlying frame height. The rectangle top edge starts
        /// at that position from the top edge of the frame.This field corresponds to tts:origin
        /// - Y in the TTML standard.
        /// </summary>
        [AWSProperty(Required=true)]
        public double? TopOffset
        {
            get { return this._topOffset; }
            set { this._topOffset = value; }
        }

        // Check to see if TopOffset property is set
        internal bool IsSetTopOffset()
        {
            return this._topOffset.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Width. See the description in leftOffset.For width, specify
        /// the entire width of the rectangle as a percentage of the underlying frame width. For
        /// example, \"80\" means the rectangle width is 80% of the underlying frame width. The
        /// leftOffset and rectangleWidth must add up to 100% or less.This field corresponds to
        /// tts:extent - X in the TTML standard.
        /// </summary>
        [AWSProperty(Required=true)]
        public double? Width
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