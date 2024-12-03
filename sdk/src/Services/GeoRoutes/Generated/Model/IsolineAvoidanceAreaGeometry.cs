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
    /// The avoidance geometry, to be included while calculating the route.
    /// </summary>
    public partial class IsolineAvoidanceAreaGeometry
    {
        private List<double> _boundingBox = AWSConfigs.InitializeCollections ? new List<double>() : null;
        private Corridor _corridor;
        private List<List<List<double>>> _polygon = AWSConfigs.InitializeCollections ? new List<List<List<double>>>() : null;
        private PolylineCorridor _polylineCorridor;
        private List<string> _polylinePolygon = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property BoundingBox. 
        /// <para>
        /// Geometry defined as a bounding box. The first pair represents the X and Y coordinates
        /// (longitude and latitude,) of the southwest corner of the bounding box; the second
        /// pair represents the X and Y coordinates (longitude and latitude) of the northeast
        /// corner.
        /// </para>
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
        /// Gets and sets the property Corridor. 
        /// <para>
        /// Geometry defined as a corridor - a LineString with a radius that defines the width
        /// of the corridor.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Corridor Corridor
        {
            get { return this._corridor; }
            set { this._corridor = value; }
        }

        // Check to see if Corridor property is set
        internal bool IsSetCorridor()
        {
            return this._corridor != null;
        }

        /// <summary>
        /// Gets and sets the property Polygon. 
        /// <para>
        /// A list of Polygon will be excluded for calculating isolines, the list can only contain
        /// 1 polygon.
        /// </para>
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

        /// <summary>
        /// Gets and sets the property PolylineCorridor. 
        /// <para>
        /// Geometry defined as an encoded corridor – a polyline with a radius that defines the
        /// width of the corridor. For more information on polyline encoding, see <a href="https://github.com/heremaps/flexiblepolyline/blob/master/README.md">https://github.com/heremaps/flexiblepolyline/blob/master/README.md</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public PolylineCorridor PolylineCorridor
        {
            get { return this._polylineCorridor; }
            set { this._polylineCorridor = value; }
        }

        // Check to see if PolylineCorridor property is set
        internal bool IsSetPolylineCorridor()
        {
            return this._polylineCorridor != null;
        }

        /// <summary>
        /// Gets and sets the property PolylinePolygon. 
        /// <para>
        /// A list of PolylinePolygon's that are excluded for calculating isolines, the list can
        /// only contain 1 polygon. For more information on polyline encoding, see <a href="https://github.com/heremaps/flexiblepolyline/blob/master/README.md">https://github.com/heremaps/flexiblepolyline/blob/master/README.md</a>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
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