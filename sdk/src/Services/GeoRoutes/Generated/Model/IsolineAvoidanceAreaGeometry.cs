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
    /// Defines an area to avoid during calculations using one of several supported geometry
    /// types. The service will prefer routes that avoid these areas when possible.
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
        /// A rectangular area defined by its southwest and northeast corners: <c>[min longitude,
        /// min latitude, max longitude, max latitude]</c>.
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
        /// Gets and sets the property Corridor. 
        /// <para>
        /// A buffer zone around a line, defined by a series of coordinates and a radius in meters.
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
        /// A polygon defined by a list of coordinate rings. The first ring defines the outer
        /// boundary; subsequent rings will be ignored.
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

        /// <summary>
        /// Gets and sets the property PolylineCorridor. 
        /// <para>
        /// A buffer zone around a compressed polyline, defined by an encoded polyline string
        /// and a radius in meters. For more information on polyline encoding, see <a href="https://github.com/aws-geospatial/polyline">https://github.com/aws-geospatial/polyline</a>.
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
        /// A polygon defined by encoded polyline strings. The first string defines the outer
        /// boundary; subsequent strings will be ignored. For more information on polyline encoding,
        /// see <a href="https://github.com/aws-geospatial/polyline">https://github.com/aws-geospatial/polyline</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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