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
    /// A rectangle defined by position (x, y) and dimensions (width, height) in pixels.Used
    /// for output positioning and input cropping.
    /// </summary>
    public partial class VideoPositionRectangle
    {
        private int? _height;
        private int? _width;
        private int? _x;
        private int? _y;

        /// <summary>
        /// Gets and sets the property Height. Height in pixels. Must be an even number.
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Width. Width in pixels. Must be an even number.
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property X. Left offset in pixels. Must be an even number.
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Y. Top offset in pixels. Must be an even number.
        /// </summary>
        [AWSProperty(Required=true)]
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