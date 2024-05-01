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
    /// Indicates the location of the landmark on the face.
    /// </summary>
    public partial class Landmark
    {
        private LandmarkType _type;
        private float? _x;
        private float? _y;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Type of landmark.
        /// </para>
        /// </summary>
        public LandmarkType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property X. 
        /// <para>
        /// The x-coordinate of the landmark expressed as a ratio of the width of the image. The
        /// x-coordinate is measured from the left-side of the image. For example, if the image
        /// is 700 pixels wide and the x-coordinate of the landmark is at 350 pixels, this value
        /// is 0.5. 
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
        /// The y-coordinate of the landmark expressed as a ratio of the height of the image.
        /// The y-coordinate is measured from the top of the image. For example, if the image
        /// height is 200 pixels and the y-coordinate of the landmark is at 50 pixels, this value
        /// is 0.25.
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