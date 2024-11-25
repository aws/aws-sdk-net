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
    /// Summarized details of the route.
    /// </summary>
    public partial class RouteVehicleSummary
    {
        private RouteVehicleOverviewSummary _overview;
        private RouteVehicleTravelOnlySummary _travelOnly;

        /// <summary>
        /// Gets and sets the property Overview. 
        /// <para>
        /// Summarized details for the leg including before travel, travel and after travel steps.
        /// </para>
        /// </summary>
        public RouteVehicleOverviewSummary Overview
        {
            get { return this._overview; }
            set { this._overview = value; }
        }

        // Check to see if Overview property is set
        internal bool IsSetOverview()
        {
            return this._overview != null;
        }

        /// <summary>
        /// Gets and sets the property TravelOnly. 
        /// <para>
        /// Summarized details for the leg including travel steps only. The Distance for the travel
        /// only portion of the journey is in meters
        /// </para>
        /// </summary>
        public RouteVehicleTravelOnlySummary TravelOnly
        {
            get { return this._travelOnly; }
            set { this._travelOnly = value; }
        }

        // Check to see if TravelOnly property is set
        internal bool IsSetTravelOnly()
        {
            return this._travelOnly != null;
        }

    }
}