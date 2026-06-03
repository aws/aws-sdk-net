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
    /// Geometry of the routing boundary.
    /// </summary>
    public partial class RouteMatrixBoundaryGeometry
    {
        private RouteMatrixAutoCircle _autoCircle;
        private List<double> _boundingBox = AWSConfigs.InitializeCollections ? new List<double>() : null;
        private Circle _circle;
        private List<List<List<double>>> _polygon = AWSConfigs.InitializeCollections ? new List<List<List<double>>>() : null;

        /// <summary>
        /// Gets and sets the property AutoCircle. 
        /// <para>
        ///  <c>AutoCircle</c> requests the route matrix service to define a <c>Circle</c> boundary
        /// that best attempts to include most waypoints (<c>Origins</c> and <c>Destinations</c>)
        /// using the <c>AutoCircle</c> settings. Any waypoints outside of the auto-defined <c>Circle</c>
        /// boundary will be considered out of the routing boundary, which results in a route
        /// matrix entry error.
        /// </para>
        ///  
        /// <para>
        ///  <c>AutoCircle</c> is only used in the request to configure a <c>Circle</c> for the
        /// route calculation. The derived <c>Circle</c> will also be provided in the response.
        /// </para>
        /// </summary>
        public RouteMatrixAutoCircle AutoCircle
        {
            get { return this._autoCircle; }
            set { this._autoCircle = value; }
        }

        // Check to see if AutoCircle property is set
        internal bool IsSetAutoCircle()
        {
            return this._autoCircle != null;
        }

        /// <summary>
        /// Gets and sets the property BoundingBox. 
        /// <para>
        /// Geometry defined as a bounding box. The first pair represents the X and Y coordinates
        /// (longitude and latitude,) of the southwest corner of the bounding box; the second
        /// pair represents the X and Y coordinates (longitude and latitude) of the northeast
        /// corner.
        /// </para>
        ///  
        /// <para>
        /// Diagonal distance of the bounding box must be less than or equal to 400,000 meters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=4, Max=4)]
        public List<double> BoundingBox
        {
            get { return this._boundingBox; }
            set { this._boundingBox = value; }
        }

        // Check to see if BoundingBox property is set
        internal bool IsSetBoundingBox()
        {
            return this._boundingBox != null && (this._boundingBox.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Circle. 
        /// <para>
        /// Geometry defined as a circle. The circle defines the routing boundary area. Any waypoints
        /// outside the circle will result in a route matrix entry error.
        /// </para>
        ///  
        /// <para>
        /// You can specify a <c>Circle</c> directly in the request, or it will be auto-derived
        /// when <c>AutoCircle</c> is used. When <c>AutoCircle</c> is set in the request, the
        /// response routing boundary will return <c>Circle</c> derived from the <c>AutoCircle</c>
        /// settings.
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
        /// Gets and sets the property Polygon. 
        /// <para>
        /// Geometry defined as a polygon with only one linear ring. A linear ring is a closed
        /// sequence of four or more coordinates. The first and last coordinates are the same,
        /// forming a closed boundary. Each coordinate is a position in [longitude, latitude]
        /// format.
        /// </para>
        ///  
        /// <para>
        /// The structure is an array of linear rings (only 1 allowed). Each linear ring is an
        /// array of coordinates (minimum 4), and each coordinate is an array of two doubles [longitude,
        /// latitude].
        /// </para>
        ///  
        /// <para>
        /// Maximum distance between any two vertices must be less than or equal to 400,000 meters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
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