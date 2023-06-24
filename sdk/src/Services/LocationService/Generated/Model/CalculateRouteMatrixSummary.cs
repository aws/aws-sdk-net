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
    /// A summary of the calculated route matrix.
    /// </summary>
    public partial class CalculateRouteMatrixSummary
    {
        private string _dataSource;
        private DistanceUnit _distanceUnit;
        private int? _errorCount;
        private int? _routeCount;

        /// <summary>
        /// Gets and sets the property DataSource. 
        /// <para>
        /// The data provider of traffic and road network data used to calculate the routes. Indicates
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
        /// Gets and sets the property ErrorCount. 
        /// <para>
        /// The count of error results in the route matrix. If this number is 0, all routes were
        /// calculated successfully.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=160000)]
        public int ErrorCount
        {
            get { return this._errorCount.GetValueOrDefault(); }
            set { this._errorCount = value; }
        }

        // Check to see if ErrorCount property is set
        internal bool IsSetErrorCount()
        {
            return this._errorCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RouteCount. 
        /// <para>
        /// The count of cells in the route matrix. Equal to the number of <code>DeparturePositions</code>
        /// multiplied by the number of <code>DestinationPositions</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=160000)]
        public int RouteCount
        {
            get { return this._routeCount.GetValueOrDefault(); }
            set { this._routeCount = value; }
        }

        // Check to see if RouteCount property is set
        internal bool IsSetRouteCount()
        {
            return this._routeCount.HasValue; 
        }

    }
}