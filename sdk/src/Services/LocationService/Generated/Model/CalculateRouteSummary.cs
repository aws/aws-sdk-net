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
    /// A summary of the calculated route.
    /// </summary>
    public partial class CalculateRouteSummary
    {
        private string _dataSource;
        private double? _distance;
        private DistanceUnit _distanceUnit;
        private double? _durationSeconds;
        private List<double> _routeBBox = new List<double>();

        /// <summary>
        /// Gets and sets the property DataSource. 
        /// <para>
        /// The data provider of traffic and road network data used to calculate the route. Indicates
        /// one of the available providers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Esri</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Grab</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Here</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about data providers, see <a href="https://docs.aws.amazon.com/location/latest/developerguide/what-is-data-provider.html">Amazon
        /// Location Service data providers</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DataSource
        {
            get { return this._dataSource; }
            set { this._dataSource = value; }
        }

        // Check to see if DataSource property is set
        internal bool IsSetDataSource()
        {
            return this._dataSource != null;
        }

        /// <summary>
        /// Gets and sets the property Distance. 
        /// <para>
        /// The total distance covered by the route. The sum of the distance travelled between
        /// every stop on the route.
        /// </para>
        ///  <note> 
        /// <para>
        /// If Esri is the data source for the route calculator, the route distance can’t be greater
        /// than 400 km. If the route exceeds 400 km, the response is a <code>400 RoutesValidationException</code>
        /// error.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public double Distance
        {
            get { return this._distance.GetValueOrDefault(); }
            set { this._distance = value; }
        }

        // Check to see if Distance property is set
        internal bool IsSetDistance()
        {
            return this._distance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DistanceUnit. 
        /// <para>
        /// The unit of measurement for route distances.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DistanceUnit DistanceUnit
        {
            get { return this._distanceUnit; }
            set { this._distanceUnit = value; }
        }

        // Check to see if DistanceUnit property is set
        internal bool IsSetDistanceUnit()
        {
            return this._distanceUnit != null;
        }

        /// <summary>
        /// Gets and sets the property DurationSeconds. 
        /// <para>
        /// The total travel time for the route measured in seconds. The sum of the travel time
        /// between every stop on the route.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public double DurationSeconds
        {
            get { return this._durationSeconds.GetValueOrDefault(); }
            set { this._durationSeconds = value; }
        }

        // Check to see if DurationSeconds property is set
        internal bool IsSetDurationSeconds()
        {
            return this._durationSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RouteBBox. 
        /// <para>
        /// Specifies a geographical box surrounding a route. Used to zoom into a route when displaying
        /// it in a map. For example, <code>[min x, min y, max x, max y]</code>.
        /// </para>
        ///  
        /// <para>
        /// The first 2 <code>bbox</code> parameters describe the lower southwest corner: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The first <code>bbox</code> position is the X coordinate or longitude of the lower
        /// southwest corner. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The second <code>bbox</code> position is the Y coordinate or latitude of the lower
        /// southwest corner. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The next 2 <code>bbox</code> parameters describe the upper northeast corner: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The third <code>bbox</code> position is the X coordinate, or longitude of the upper
        /// northeast corner. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The fourth <code>bbox</code> position is the Y coordinate, or latitude of the upper
        /// northeast corner. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=4, Max=4)]
        public List<double> RouteBBox
        {
            get { return this._routeBBox; }
            set { this._routeBBox = value; }
        }

        // Check to see if RouteBBox property is set
        internal bool IsSetRouteBBox()
        {
            return this._routeBBox != null && this._routeBBox.Count > 0; 
        }

    }
}