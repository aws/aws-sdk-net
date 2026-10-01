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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Geometry of the area to be avoided.
    /// </summary>
    public partial class RouteAvoidanceAreaGeometry
    {
        /// <summary>
        /// Gets and sets the property BoundingBox. 
        /// <para>
        /// Geometry defined as a bounding box. The first pair represents the X and Y coordinates
        /// (longitude and latitude,) of the southwest corner of the bounding box; the second
        /// pair represents the X and Y coordinates (longitude and latitude) of the northeast
        /// corner.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 4, Max = 4)]
        public List<double> BoundingBox { get; set; } = AWSConfigs.InitializeCollections ? new List<double>() : null;

        /// <summary>
        /// Checks to see if the BoundingBox property is set.
        /// </summary>
        internal bool IsSetBoundingBox() => this.BoundingBox != null && (this.BoundingBox.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Corridor. 
        /// <para>
        /// Geometry defined as a corridor - a LineString with a radius that defines the width
        /// of the corridor.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Corridor Corridor { get; set; }

        /// <summary>
        /// Checks to see if the Corridor property is set.
        /// </summary>
        internal bool IsSetCorridor() => this.Corridor != null;

        /// <summary>
        /// Gets and sets the property Polygon. 
        /// <para>
        /// Geometry defined as a polygon with only one linear ring.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<List<List<double>>> Polygon { get; set; } = AWSConfigs.InitializeCollections ? new List<List<List<double>>>() : null;

        /// <summary>
        /// Checks to see if the Polygon property is set.
        /// </summary>
        internal bool IsSetPolygon() => this.Polygon != null && (this.Polygon.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PolylineCorridor. 
        /// <para>
        /// Geometry defined as an encoded corridor - an encoded polyline with a radius that defines
        /// the width of the corridor.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public PolylineCorridor PolylineCorridor { get; set; }

        /// <summary>
        /// Checks to see if the PolylineCorridor property is set.
        /// </summary>
        internal bool IsSetPolylineCorridor() => this.PolylineCorridor != null;

        /// <summary>
        /// Gets and sets the property PolylinePolygon. 
        /// <para>
        /// A list of Isoline PolylinePolygon, for each isoline PolylinePolygon, it contains PolylinePolygon
        /// of the first linear ring (the outer ring) and from 2nd item to the last item (the
        /// inner rings). For more information on polyline encoding, see <a href="https://github.com/aws-geospatial/polyline">https://github.com/aws-geospatial/polyline</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<string> PolylinePolygon { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PolylinePolygon property is set.
        /// </summary>
        internal bool IsSetPolylinePolygon() => this.PolylinePolygon != null && (this.PolylinePolygon.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
