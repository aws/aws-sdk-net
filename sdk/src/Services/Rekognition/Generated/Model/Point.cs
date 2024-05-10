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
    /// The X and Y coordinates of a point on an image or video frame. The X and Y values
    /// are ratios of the overall image size or video resolution. For example, if an input
    /// image is 700x200 and the values are X=0.5 and Y=0.25, then the point is at the (350,50)
    /// pixel coordinate on the image.
    /// 
    ///  
    /// <para>
    /// An array of <c>Point</c> objects makes up a <c>Polygon</c>. A <c>Polygon</c> is returned
    /// by <a>DetectText</a> and by <a>DetectCustomLabels</a> <c>Polygon</c> represents a
    /// fine-grained polygon around a detected item. For more information, see Geometry in
    /// the Amazon Rekognition Developer Guide. 
    /// </para>
    /// </summary>
    public partial class Point
    {
        private float? _x;
        private float? _y;

        /// <summary>
        /// Gets and sets the property X. 
        /// <para>
        /// The value of the X coordinate for a point on a <c>Polygon</c>.
        /// </para>
        /// </summary>
        public float? X
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
        /// Gets and sets the property Y. 
        /// <para>
        /// The value of the Y coordinate for a point on a <c>Polygon</c>.
        /// </para>
        /// </summary>
        public float? Y
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