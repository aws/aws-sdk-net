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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// The bounding box around the detected page or around an element on a document page.
    /// The left (x-coordinate) and top (y-coordinate) are coordinates that represent the
    /// top and left sides of the bounding box. Note that the upper-left corner of the image
    /// is the origin (0,0). 
    /// 
    ///  
    /// <para>
    /// For additional information, see <a href="https://docs.aws.amazon.com/textract/latest/dg/API_BoundingBox.html">BoundingBox</a>
    /// in the Amazon Textract API reference.
    /// </para>
    /// </summary>
    public partial class BoundingBox
    {
        private float? _height;
        private float? _left;
        private float? _top;
        private float? _width;

        /// <summary>
        /// Gets and sets the property Height. 
        /// <para>
        /// The height of the bounding box as a ratio of the overall document page height.
        /// </para>
        /// </summary>
        public float Height
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
        /// Gets and sets the property Left. 
        /// <para>
        /// The left coordinate of the bounding box as a ratio of overall document page width.
        /// </para>
        /// </summary>
        public float Left
        {
            get { return this._left.GetValueOrDefault(); }
            set { this._left = value; }
        }

        // Check to see if Left property is set
        internal bool IsSetLeft()
        {
            return this._left.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Top. 
        /// <para>
        /// The top coordinate of the bounding box as a ratio of overall document page height.
        /// </para>
        /// </summary>
        public float Top
        {
            get { return this._top.GetValueOrDefault(); }
            set { this._top = value; }
        }

        // Check to see if Top property is set
        internal bool IsSetTop()
        {
            return this._top.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Width. 
        /// <para>
        /// The width of the bounding box as a ratio of the overall document page width.
        /// </para>
        /// </summary>
        public float Width
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