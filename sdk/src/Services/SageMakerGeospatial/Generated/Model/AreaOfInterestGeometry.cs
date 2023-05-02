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
 * Do not modify this file. This file is generated from the sagemaker-geospatial-2020-05-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMakerGeospatial.Model
{
    /// <summary>
    /// A GeoJSON object representing the geographic extent in the coordinate space.
    /// </summary>
    public partial class AreaOfInterestGeometry
    {
        private MultiPolygonGeometryInput _multiPolygonGeometry;
        private PolygonGeometryInput _polygonGeometry;

        /// <summary>
        /// Gets and sets the property MultiPolygonGeometry. 
        /// <para>
        /// The structure representing the MultiPolygon Geometry.
        /// </para>
        /// </summary>
        public MultiPolygonGeometryInput MultiPolygonGeometry
        {
            get { return this._multiPolygonGeometry; }
            set { this._multiPolygonGeometry = value; }
        }

        // Check to see if MultiPolygonGeometry property is set
        internal bool IsSetMultiPolygonGeometry()
        {
            return this._multiPolygonGeometry != null;
        }

        /// <summary>
        /// Gets and sets the property PolygonGeometry. 
        /// <para>
        /// The structure representing Polygon Geometry.
        /// </para>
        /// </summary>
        public PolygonGeometryInput PolygonGeometry
        {
            get { return this._polygonGeometry; }
            set { this._polygonGeometry = value; }
        }

        // Check to see if PolygonGeometry property is set
        internal bool IsSetPolygonGeometry()
        {
            return this._polygonGeometry != null;
        }

    }
}