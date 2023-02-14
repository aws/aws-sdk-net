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
    /// Places uses a point geometry to specify a location or a Place.
    /// </summary>
    public partial class PlaceGeometry
    {
        private List<double> _point = new List<double>();

        /// <summary>
        /// Gets and sets the property Point. 
        /// <para>
        /// A single point geometry specifies a location for a Place using <a href="https://gisgeography.com/wgs84-world-geodetic-system/">WGS
        /// 84</a> coordinates:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>x</i> — Specifies the x coordinate or longitude. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>y</i> — Specifies the y coordinate or latitude. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=2, Max=2)]
        public List<double> Point
        {
            get { return this._point; }
            set { this._point = value; }
        }

        // Check to see if Point property is set
        internal bool IsSetPoint()
        {
            return this._point != null && this._point.Count > 0; 
        }

    }
}