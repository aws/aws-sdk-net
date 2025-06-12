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
        /// Provides the circle that was used while calculating the route.
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
        /// Geometry defined as a circle. When request routing boundary was set as <c>AutoCircle</c>,
        /// the response routing boundary will return <c>Circle</c> derived from the <c>AutoCircle</c>
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
        /// Geometry defined as a polygon with only one linear ring.
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