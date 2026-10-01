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
    /// Represents the shape of a reachable area. The geometry can be provided either as coordinate
    /// pairs (<c>Polygon</c>) or in encoded format (<c>PolylinePolygon</c>), matching the
    /// format specified in the request.
    /// </summary>
    public partial class IsolineShapeGeometry
    {
        /// <summary>
        /// Gets and sets the property Polygon. 
        /// <para>
        /// A series of coordinate rings defining the reachable area when Simple geometry format
        /// is requested. Each ring is a list of <c>[longitude, latitude]</c> coordinate pairs.
        /// The first ring defines the outer boundary; subsequent rings define holes representing
        /// unreachable areas.
        /// </para>
        ///  <note> 
        /// <para>
        /// Polygon and PolylinePolygon are mutually exclusive properties.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<List<List<double>>> Polygon { get; set; } = AWSConfigs.InitializeCollections ? new List<List<List<double>>>() : null;

        /// <summary>
        /// Checks to see if the Polygon property is set.
        /// </summary>
        internal bool IsSetPolygon() => this.Polygon != null && (this.Polygon.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PolylinePolygon. 
        /// <para>
        /// An encoded representation of the reachable area when FlexiblePolyline geometry format
        /// is requested. Provides a compact representation suitable for transmission and storage.
        /// The first string defines the outer boundary; subsequent strings define holes representing
        /// unreachable areas. For more information on polyline encoding, see <a href="https://github.com/aws-geospatial/polyline">https://github.com/aws-geospatial/polyline</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Polygon and PolylinePolygon are mutually exclusive properties.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<string> PolylinePolygon { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PolylinePolygon property is set.
        /// </summary>
        internal bool IsSetPolylinePolygon() => this.PolylinePolygon != null && (this.PolylinePolygon.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
