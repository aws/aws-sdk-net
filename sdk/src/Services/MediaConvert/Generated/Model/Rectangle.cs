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
    /// Use Rectangle to identify a specific area of the video frame.
    /// </summary>
    public partial class Rectangle
    {
        private int? _height;
        private int? _width;
        private int? _x;
        private int? _y;

        /// <summary>
        /// Gets and sets the property Height. Height of rectangle in pixels. Specify only even
        /// numbers.
        /// </summary>
        [AWSProperty(Min=2, Max=2147483647)]
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
        /// Gets and sets the property Width. Width of rectangle in pixels. Specify only even
        /// numbers.
        /// </summary>
        [AWSProperty(Min=2, Max=2147483647)]
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
        /// Gets and sets the property X. The distance, in pixels, between the rectangle and the
        /// left edge of the video frame. Specify only even numbers.
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
        /// Gets and sets the property Y. The distance, in pixels, between the rectangle and the
        /// top edge of the video frame. Specify only even numbers.
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