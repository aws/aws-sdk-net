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
    /// Information about the location of items on a document page.
    /// 
    ///  
    /// <para>
    /// For additional information, see <a href="https://docs.aws.amazon.com/textract/latest/dg/API_Geometry.html">Geometry</a>
    /// in the Amazon Textract API reference.
    /// </para>
    /// </summary>
    public partial class Geometry
    {
        private BoundingBox _boundingBox;
        private List<Point> _polygon = new List<Point>();

        /// <summary>
        /// Gets and sets the property BoundingBox. 
        /// <para>
        /// An axis-aligned coarse representation of the location of the recognized item on the
        /// document page.
        /// </para>
        /// </summary>
        public BoundingBox BoundingBox
        {
            get { return this._boundingBox; }
            set { this._boundingBox = value; }
        }

        // Check to see if BoundingBox property is set
        internal bool IsSetBoundingBox()
        {
            return this._boundingBox != null;
        }

        /// <summary>
        /// Gets and sets the property Polygon. 
        /// <para>
        /// Within the bounding box, a fine-grained polygon around the recognized item.
        /// </para>
        /// </summary>
        public List<Point> Polygon
        {
            get { return this._polygon; }
            set { this._polygon = value; }
        }

        // Check to see if Polygon property is set
        internal bool IsSetPolygon()
        {
            return this._polygon != null && this._polygon.Count > 0; 
        }

    }
}