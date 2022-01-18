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
    /// Returns the result of the route matrix calculation.
    /// </summary>
    public partial class CalculateRouteMatrixResponse : AmazonWebServiceResponse
    {
        private List<List<RouteMatrixEntry>> _routeMatrix = new List<List<RouteMatrixEntry>>();
        private List<List<double>> _snappedDeparturePositions = new List<List<double>>();
        private List<List<double>> _snappedDestinationPositions = new List<List<double>>();
        private CalculateRouteMatrixSummary _summary;

        /// <summary>
        /// Gets and sets the property RouteMatrix. 
        /// <para>
        /// The calculated route matrix containing the results for all pairs of <code>DeparturePositions</code>
        /// to <code>DestinationPositions</code>. Each row corresponds to one entry in <code>DeparturePositions</code>.
        /// Each entry in the row corresponds to the route from that entry in <code>DeparturePositions</code>
        /// to an entry in <code>DestinationPositions</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<List<RouteMatrixEntry>> RouteMatrix
        {
            get { return this._routeMatrix; }
            set { this._routeMatrix = value; }
        }

        // Check to see if RouteMatrix property is set
        internal bool IsSetRouteMatrix()
        {
            return this._routeMatrix != null && this._routeMatrix.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SnappedDeparturePositions. 
        /// <para>
        /// For routes calculated using an Esri route calculator resource, departure positions
        /// are snapped to the closest road. For Esri route calculator resources, this returns
        /// the list of departure/origin positions used for calculation of the <code>RouteMatrix</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=350)]
        public List<List<double>> SnappedDeparturePositions
        {
            get { return this._snappedDeparturePositions; }
            set { this._snappedDeparturePositions = value; }
        }

        // Check to see if SnappedDeparturePositions property is set
        internal bool IsSetSnappedDeparturePositions()
        {
            return this._snappedDeparturePositions != null && this._snappedDeparturePositions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SnappedDestinationPositions. 
        /// <para>
        /// The list of destination positions for the route matrix used for calculation of the
        /// <code>RouteMatrix</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=350)]
        public List<List<double>> SnappedDestinationPositions
        {
            get { return this._snappedDestinationPositions; }
            set { this._snappedDestinationPositions = value; }
        }

        // Check to see if SnappedDestinationPositions property is set
        internal bool IsSetSnappedDestinationPositions()
        {
            return this._snappedDestinationPositions != null && this._snappedDestinationPositions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Summary. 
        /// <para>
        /// Contains information about the route matrix, <code>DataSource</code>, <code>DistanceUnit</code>,
        /// <code>RouteCount</code> and <code>ErrorCount</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CalculateRouteMatrixSummary Summary
        {
            get { return this._summary; }
            set { this._summary = value; }
        }

        // Check to see if Summary property is set
        internal bool IsSetSummary()
        {
            return this._summary != null;
        }

    }
}