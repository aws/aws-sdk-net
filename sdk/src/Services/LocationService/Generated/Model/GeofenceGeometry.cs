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

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Contains the geofence geometry details.
    /// 
    ///  <note> 
    /// <para>
    /// Limitation — Amazon Location does not currently support polygons with holes, multipolygons,
    /// polygons that are wound clockwise, or that cross the antimeridian. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GeofenceGeometry
    {
        private List<List<List<double>>> _polygon = new List<List<List<double>>>();

        /// <summary>
        /// Gets and sets the property Polygon. 
        /// <para>
        /// An array of 1 or more linear rings. A linear ring is an array of 4 or more vertices,
        /// where the first and last vertex are the same to form a closed boundary. Each vertex
        /// is a 2-dimensional point of the form: <code>[longitude, latitude]</code>. 
        /// </para>
        ///  
        /// <para>
        /// The first linear ring is an outer ring, describing the polygon's boundary. Subsequent
        /// linear rings may be inner or outer rings to describe holes and islands. Outer rings
        /// must list their vertices in counter-clockwise order around the ring's center, where
        /// the left side is the polygon's exterior. Inner rings must list their vertices in clockwise
        /// order, where the left side is the polygon's interior.
        /// </para>
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
            return this._polygon != null && this._polygon.Count > 0; 
        }

    }
}