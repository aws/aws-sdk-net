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
 * Do not modify this file. This file is generated from the textract-2018-06-27.normal.json service model.
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
namespace Amazon.Textract.Model
{
    /// <summary>
    /// Information about where the following items are located on a document page: detected
    /// page, text, key-value pairs, tables, table cells, and selection elements.
    /// </summary>
    public partial class Geometry
    {
        private BoundingBox _boundingBox;
        private List<Point> _polygon = AWSConfigs.InitializeCollections ? new List<Point>() : null;
        private float? _rotationAngle;

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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Point> Polygon
        {
            get { return this._polygon; }
            set { this._polygon = value; }
        }

        // Check to see if Polygon property is set
        internal bool IsSetPolygon()
        {
            return this._polygon != null && (this._polygon.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RotationAngle. 
        /// <para>
        /// Provides a numerical value corresponding to the rotation of the text.
        /// </para>
        /// </summary>
        public float? RotationAngle
        {
            get { return this._rotationAngle; }
            set { this._rotationAngle = value; }
        }

        // Check to see if RotationAngle property is set
        internal bool IsSetRotationAngle()
        {
            return this._rotationAngle.HasValue; 
        }

    }
}