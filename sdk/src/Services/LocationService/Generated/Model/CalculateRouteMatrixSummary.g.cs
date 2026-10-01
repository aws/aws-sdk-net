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

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// A summary of the calculated route matrix.
    /// </summary>
    public partial class CalculateRouteMatrixSummary
    {
        /// <summary>
        /// Gets and sets the property DataSource. 
        /// <para>
        /// The data provider of traffic and road network data used to calculate the routes. Indicates
        /// one of the available providers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Esri</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Grab</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Here</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about data providers, see <a href="https://docs.aws.amazon.com/location/previous/developerguide/what-is-data-provider.html">Amazon
        /// Location Service data providers</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DataSource { get; set; }

        /// <summary>
        /// Checks to see if the DataSource property is set.
        /// </summary>
        internal bool IsSetDataSource() => this.DataSource != null;

        /// <summary>
        /// Gets and sets the property DistanceUnit. 
        /// <para>
        /// The unit of measurement for route distances.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DistanceUnit DistanceUnit { get; set; }

        /// <summary>
        /// Checks to see if the DistanceUnit property is set.
        /// </summary>
        internal bool IsSetDistanceUnit() => this.DistanceUnit != null;

        /// <summary>
        /// Gets and sets the property ErrorCount. 
        /// <para>
        /// The count of error results in the route matrix. If this number is 0, all routes were
        /// calculated successfully.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 160000)]
        public int? ErrorCount { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCount property is set.
        /// </summary>
        internal bool IsSetErrorCount() => this.ErrorCount.HasValue;

        /// <summary>
        /// Gets and sets the property RouteCount. 
        /// <para>
        /// The count of cells in the route matrix. Equal to the number of <c>DeparturePositions</c>
        /// multiplied by the number of <c>DestinationPositions</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 160000)]
        public int? RouteCount { get; set; }

        /// <summary>
        /// Checks to see if the RouteCount property is set.
        /// </summary>
        internal bool IsSetRouteCount() => this.RouteCount.HasValue;
    }
}
