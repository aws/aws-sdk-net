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
    ///  
    /// <para>
    /// A geofence geometry is made up of either a polygon or a circle. Can be either a polygon
    /// or a circle. Including both will return a validation error.
    /// </para>
    ///  <note> 
    /// <para>
    /// Amazon Location doesn't currently support polygons with holes, multipolygons, polygons
    /// that are wound clockwise, or that cross the antimeridian. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GeofenceGeometry
    {
        private Circle _circle;
        private List<List<List<double>>> _polygon = new List<List<List<double>>>();

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
        /// Gets and sets the property Polygon. 
        /// <para>
        /// A polygon is a list of linear rings which are each made up of a list of vertices.
        /// </para>
        ///  
        /// <para>
        /// Each vertex is a 2-dimensional point of the form: <code>[longitude, latitude]</code>.
        /// This is represented as an array of doubles of length 2 (so <code>[double, double]</code>).
        /// </para>
        ///  
        /// <para>
        /// An array of 4 or more vertices, where the first and last vertex are the same (to form
        /// a closed boundary), is called a linear ring. The linear ring vertices must be listed
        /// in counter-clockwise order around the ring’s interior. The linear ring is represented
        /// as an array of vertices, or an array of arrays of doubles (<code>[[double, double],
        /// ...]</code>).
        /// </para>
        ///  
        /// <para>
        /// A geofence consists of a single linear ring. To allow for future expansion, the Polygon
        /// parameter takes an array of linear rings, which is represented as an array of arrays
        /// of arrays of doubles (<code>[[[double, double], ...], ...]</code>).
        /// </para>
        ///  
        /// <para>
        /// A linear ring for use in geofences can consist of between 4 and 1,000 vertices.
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