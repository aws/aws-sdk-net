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
    /// Important labels including names and route numbers that differentiate the current
    /// route from the alternatives presented.
    /// </summary>
    public partial class RouteMajorRoadLabel
    {
        private LocalizedString _roadName;
        private RouteNumber _routeNumber;

        /// <summary>
        /// Gets and sets the property RoadName. 
        /// <para>
        /// Name of the road (localized).
        /// </para>
        /// </summary>
        public LocalizedString RoadName
        {
            get { return this._roadName; }
            set { this._roadName = value; }
        }

        // Check to see if RoadName property is set
        internal bool IsSetRoadName()
        {
            return this._roadName != null;
        }

        /// <summary>
        /// Gets and sets the property RouteNumber. 
        /// <para>
        /// Route number of the road.
        /// </para>
        /// </summary>
        public RouteNumber RouteNumber
        {
            get { return this._routeNumber; }
            set { this._routeNumber = value; }
        }

        // Check to see if RouteNumber property is set
        internal bool IsSetRouteNumber()
        {
            return this._routeNumber != null;
        }

    }
}