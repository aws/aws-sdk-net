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
    /// Contains the geometry details for each path between a pair of positions. Used in plotting
    /// a route leg on a map.
    /// </summary>
    public partial class LegGeometry
    {
        private List<List<double>> _lineString = new List<List<double>>();

        /// <summary>
        /// Gets and sets the property LineString. 
        /// <para>
        /// An ordered list of positions used to plot a route on a map. 
        /// </para>
        ///  
        /// <para>
        /// The first position is closest to the start position for the leg, and the last position
        /// is the closest to the end position for the leg.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For example, <code>[[-123.117, 49.284],[-123.115, 49.285],[-123.115, 49.285]]</code>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=2)]
        public List<List<double>> LineString
        {
            get { return this._lineString; }
            set { this._lineString = value; }
        }

        // Check to see if LineString property is set
        internal bool IsSetLineString()
        {
            return this._lineString != null && this._lineString.Count > 0; 
        }

    }
}