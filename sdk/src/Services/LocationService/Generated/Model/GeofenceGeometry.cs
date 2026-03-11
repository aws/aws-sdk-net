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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
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
namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Contains the geofence geometry details.
    /// 
    ///  
    /// <para>
    /// A geofence geometry can be a circle, a polygon, or a multipolygon. <c>Polygon</c>
    /// and <c>MultiPolygon</c> geometries can be defined using their respective parameters,
    /// or encoded in Geobuf format using the <c>Geobuf</c> parameter. Including multiple
    /// geometry types in the same request will return a validation error.
    /// </para>
    ///  <note> 
    /// <para>
    /// Amazon Location doesn't currently support polygons that cross the antimeridian.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GeofenceGeometry
    {
        private Circle _circle;
        private MemoryStream _geobuf;
        private List<List<List<List<double>>>> _multiPolygon = AWSConfigs.InitializeCollections ? new List<List<List<List<double>>>>() : null;
        private List<List<List<double>>> _polygon = AWSConfigs.InitializeCollections ? new List<List<List<double>>>() : null;

        /// <summary>
        /// Gets and sets the property Circle. 
        /// <para>
        /// A circle on the earth, as defined by a center point and a radius.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Circle Circle
        {
            get { return this._circle; }
            set { this._circle = value; }
        }

        // Check to see if Circle property is set
        internal bool IsSetCircle()
        {
            return this._circle != null;
        }

        /// <summary>
        /// Gets and sets the property Geobuf. 
        /// <para>
        /// Geobuf is a compact binary encoding for geographic data that provides lossless compression
        /// of GeoJSON polygons. The Geobuf must be Base64-encoded.
        /// </para>
        ///  
        /// <para>
        /// This parameter can contain a Geobuf-encoded GeoJSON geometry object of type <c>Polygon</c>
        /// <i>OR</i> <c>MultiPolygon</c>. For more information and specific configuration requirements
        /// for these object types, see <a href="https://docs.aws.amazon.com/location/latest/APIReference/API_WaypointGeofencing_GeofenceGeometry.html#location-Type-WaypointGeofencing_GeofenceGeometry-Polygon">Polygon</a>
        /// and <a href="https://docs.aws.amazon.com/location/latest/APIReference/API_WaypointGeofencing_GeofenceGeometry.html#location-Type-WaypointGeofencing_GeofenceGeometry-MultiPolygon">MultiPolygon</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The following limitations apply specifically to geometries defined using the <c>Geobuf</c>
        /// parameter, and supercede the corresponding limitations of the <c>Polygon</c> and <c>MultiPolygon</c>
        /// parameters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A <c>Polygon</c> in <c>Geobuf</c> format can have up to 25,000 rings and up to 100,000
        /// total vertices, including all vertices from all component rings.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <c>MultiPolygon</c> in <c>Geobuf</c> format can contain up to 10,000 <c>Polygons</c>
        /// and up to 100,000 total vertices, including all vertices from all component <c>Polygons</c>.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=700000)]
        public MemoryStream Geobuf
        {
            get { return this._geobuf; }
            set { this._geobuf = value; }
        }

        // Check to see if Geobuf property is set
        internal bool IsSetGeobuf()
        {
            return this._geobuf != null;
        }

        /// <summary>
        /// Gets and sets the property MultiPolygon. 
        /// <para>
        /// A <c>MultiPolygon</c> is a list of up to 250 <c>Polygon</c> elements which represent
        /// the shape of a geofence. The <c>Polygon</c> components of a <c>MultiPolygon</c> geometry
        /// can define separate geographical areas that are considered part of the same geofence,
        /// perimeters of larger exterior areas with smaller interior spaces that are excluded
        /// from the geofence, or some combination of these use cases to form complex geofence
        /// boundaries.
        /// </para>
        ///  
        /// <para>
        /// For more information and specific configuration requirements for the <c>Polygon</c>
        /// components that form a <c>MultiPolygon</c>, see <a href="https://docs.aws.amazon.com/location/latest/APIReference/API_WaypointGeofencing_GeofenceGeometry.html#location-Type-WaypointGeofencing_GeofenceGeometry-Polygon">Polygon</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The following additional requirements and limitations apply to geometries defined
        /// using the <c>MultiPolygon</c> parameter:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The entire <c>MultiPolygon</c> must consist of no more than 1,000 vertices, including
        /// all vertices from all component <c>Polygons</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each edge of a component <c>Polygon</c> must intersect no more than 5 edges from other
        /// <c>Polygons</c>. Parallel edges that are shared but do not cross are not counted toward
        /// this limit.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The total number of intersecting edges of component <c>Polygons</c> must be no more
        /// than 100,000. Parallel edges that are shared but do not cross are not counted toward
        /// this limit.
        /// </para>
        ///  </li> </ul> </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=250)]
        public List<List<List<List<double>>>> MultiPolygon
        {
            get { return this._multiPolygon; }
            set { this._multiPolygon = value; }
        }

        // Check to see if MultiPolygon property is set
        internal bool IsSetMultiPolygon()
        {
            return this._multiPolygon != null && (this._multiPolygon.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Polygon. 
        /// <para>
        /// A <c>Polygon</c> is a list of up to 250 linear rings which represent the shape of
        /// a geofence. This list <i>must</i> include 1 exterior ring (representing the outer
        /// perimeter of the geofence), and can optionally include up to 249 interior rings (representing
        /// polygonal spaces within the perimeter, which are excluded from the geofence area).
        /// </para>
        ///  
        /// <para>
        /// A linear ring is an array of 4 or more vertices, where the first and last vertex are
        /// the same (to form a closed boundary). Each vertex is a 2-dimensional point represented
        /// as an array of doubles of length 2: <c>[longitude, latitude]</c>.
        /// </para>
        ///  
        /// <para>
        /// Each linear ring is represented as an array of arrays of doubles (<c>[[longitude,
        /// latitude], [longitude, latitude], ...]</c>). The vertices for the exterior ring must
        /// be listed in <i>counter-clockwise</i> sequence. Vertices for all interior rings must
        /// be listed in <i>clockwise</i> sequence.
        /// </para>
        ///  
        /// <para>
        /// The list of linear rings that describe the entire <c>Polygon</c> is represented as
        /// an array of arrays of arrays of doubles (<c>[[[longitude, latitude], [longitude, latitude],
        /// ...], [[longitude, latitude], [longitude, latitude], ...], ...]</c>). The exterior
        /// ring must be listed first, before any interior rings.
        /// </para>
        ///  <note> 
        /// <para>
        /// The following additional requirements and limitations apply to geometries defined
        /// using the <c>Polygon</c> parameter:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The entire <c>Polygon</c> must consist of no more than 1,000 vertices, including all
        /// vertices from the exterior ring and all interior rings.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Rings must not touch or cross each other.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// All interior rings must be fully contained within the exterior ring.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Interior rings must not contain other interior rings.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// No ring is permitted to intersect itself.
        /// </para>
        ///  </li> </ul> </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=250)]
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

    }
}