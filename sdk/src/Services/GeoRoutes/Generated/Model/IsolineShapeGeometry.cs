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
 * Do not modify this file. This file is generated from the geo-routes-2020-11-19.normal.json service model.
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
namespace Amazon.GeoRoutes.Model
{
    /// <summary>
    /// Geometry of the connection between different Isoline components.
    /// </summary>
    public partial class IsolineShapeGeometry
    {
        private List<List<List<double>>> _polygon = AWSConfigs.InitializeCollections ? new List<List<List<double>>>() : null;
        private List<string> _polylinePolygon = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Polygon. 
        /// <para>
        /// A list of Isoline Polygons, for each isoline polygon, it contains polygons of the
        /// first linear ring (the outer ring) and from 2nd item to the last item (the inner rings).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<List<List<double>>> Polygon
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
        /// Gets and sets the property PolylinePolygon. 
        /// <para>
        /// A list of Isoline PolylinePolygon, for each isoline PolylinePolygon, it contains PolylinePolygon
        /// of the first linear ring (the outer ring) and from 2nd item to the last item (the
        /// inner rings). For more information on polyline encoding, see <a href="https://github.com/heremaps/flexiblepolyline/blob/master/README.md">https://github.com/heremaps/flexiblepolyline/blob/master/README.md</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> PolylinePolygon
        {
            get { return this._polylinePolygon; }
            set { this._polylinePolygon = value; }
        }

        // Check to see if PolylinePolygon property is set
        internal bool IsSetPolylinePolygon()
        {
            return this._polylinePolygon != null && (this._polylinePolygon.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}