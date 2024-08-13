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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
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
namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Identifies the bounding box around the label, face, text, object of interest, or personal
    /// protective equipment. The <c>left</c> (x-coordinate) and <c>top</c> (y-coordinate)
    /// are coordinates representing the top and left sides of the bounding box. Note that
    /// the upper-left corner of the image is the origin (0,0). 
    /// 
    ///  
    /// <para>
    /// The <c>top</c> and <c>left</c> values returned are ratios of the overall image size.
    /// For example, if the input image is 700x200 pixels, and the top-left coordinate of
    /// the bounding box is 350x50 pixels, the API returns a <c>left</c> value of 0.5 (350/700)
    /// and a <c>top</c> value of 0.25 (50/200).
    /// </para>
    ///  
    /// <para>
    /// The <c>width</c> and <c>height</c> values represent the dimensions of the bounding
    /// box as a ratio of the overall image dimension. For example, if the input image is
    /// 700x200 pixels, and the bounding box width is 70 pixels, the width returned is 0.1.
    /// 
    /// </para>
    ///  <note> 
    /// <para>
    ///  The bounding box coordinates can have negative values. For example, if Amazon Rekognition
    /// is able to detect a face that is at the image edge and is only partially visible,
    /// the service can return coordinates that are outside the image bounds and, depending
    /// on the image edge, you might get negative values or values greater than 1 for the
    /// <c>left</c> or <c>top</c> values. 
    /// </para>
    ///  </note>
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
        /// Height of the bounding box as a ratio of the overall image height.
        /// </para>
        /// </summary>
        public float? Height
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
        /// Gets and sets the property Left. 
        /// <para>
        /// Left coordinate of the bounding box as a ratio of overall image width.
        /// </para>
        /// </summary>
        public float? Left
        {
            get { return this._left; }
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
        /// Top coordinate of the bounding box as a ratio of overall image height.
        /// </para>
        /// </summary>
        public float? Top
        {
            get { return this._top; }
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
        /// Width of the bounding box as a ratio of the overall image width.
        /// </para>
        /// </summary>
        public float? Width
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