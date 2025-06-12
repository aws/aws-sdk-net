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
    /// Steps of a leg that correspond to the travel portion of the leg.
    /// </summary>
    public partial class RouteVehicleLegDetails
    {
        private RouteVehicleArrival _arrival;
        private RouteVehicleDeparture _departure;
        private List<RouteVehicleIncident> _incidents = AWSConfigs.InitializeCollections ? new List<RouteVehicleIncident>() : null;
        private List<RouteVehicleNotice> _notices = AWSConfigs.InitializeCollections ? new List<RouteVehicleNotice>() : null;
        private List<RoutePassThroughWaypoint> _passThroughWaypoints = AWSConfigs.InitializeCollections ? new List<RoutePassThroughWaypoint>() : null;
        private List<RouteVehicleSpan> _spans = AWSConfigs.InitializeCollections ? new List<RouteVehicleSpan>() : null;
        private RouteVehicleSummary _summary;
        private List<RouteToll> _tolls = AWSConfigs.InitializeCollections ? new List<RouteToll>() : null;
        private List<RouteTollSystem> _tollSystems = AWSConfigs.InitializeCollections ? new List<RouteTollSystem>() : null;
        private List<RouteVehicleTravelStep> _travelSteps = AWSConfigs.InitializeCollections ? new List<RouteVehicleTravelStep>() : null;
        private List<string> _truckRoadTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<RouteZone> _zones = AWSConfigs.InitializeCollections ? new List<RouteZone>() : null;

        /// <summary>
        /// Gets and sets the property Arrival. 
        /// <para>
        /// Details corresponding to the arrival for the leg.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RouteVehicleArrival Arrival
        {
            get { return this._arrival; }
            set { this._arrival = value; }
        }

        // Check to see if Arrival property is set
        internal bool IsSetArrival()
        {
            return this._arrival != null;
        }

        /// <summary>
        /// Gets and sets the property Departure. 
        /// <para>
        /// Details corresponding to the departure for the leg.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RouteVehicleDeparture Departure
        {
            get { return this._departure; }
            set { this._departure = value; }
        }

        // Check to see if Departure property is set
        internal bool IsSetDeparture()
        {
            return this._departure != null;
        }

        /// <summary>
        /// Gets and sets the property Incidents. 
        /// <para>
        /// Incidents corresponding to this leg of the route.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RouteVehicleIncident> Incidents
        {
            get { return this._incidents; }
            set { this._incidents = value; }
        }

        // Check to see if Incidents property is set
        internal bool IsSetIncidents()
        {
            return this._incidents != null && (this._incidents.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Notices. 
        /// <para>
        /// Notices are additional information returned that indicate issues that occurred during
        /// route calculation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RouteVehicleNotice> Notices
        {
            get { return this._notices; }
            set { this._notices = value; }
        }

        // Check to see if Notices property is set
        internal bool IsSetNotices()
        {
            return this._notices != null && (this._notices.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PassThroughWaypoints. 
        /// <para>
        /// Waypoints that were passed through during the leg. This includes the waypoints that
        /// were configured with the PassThrough option.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RoutePassThroughWaypoint> PassThroughWaypoints
        {
            get { return this._passThroughWaypoints; }
            set { this._passThroughWaypoints = value; }
        }

        // Check to see if PassThroughWaypoints property is set
        internal bool IsSetPassThroughWaypoints()
        {
            return this._passThroughWaypoints != null && (this._passThroughWaypoints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Spans. 
        /// <para>
        /// Spans that were computed for the requested SpanAdditionalFeatures.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RouteVehicleSpan> Spans
        {
            get { return this._spans; }
            set { this._spans = value; }
        }

        // Check to see if Spans property is set
        internal bool IsSetSpans()
        {
            return this._spans != null && (this._spans.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Summary. 
        /// <para>
        /// Summarized details of the leg.
        /// </para>
        /// </summary>
        public RouteVehicleSummary Summary
        {
            get { return this._summary; }
            set { this._summary = value; }
        }

        // Check to see if Summary property is set
        internal bool IsSetSummary()
        {
            return this._summary != null;
        }

        /// <summary>
        /// Gets and sets the property Tolls. 
        /// <para>
        /// Toll related options.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RouteToll> Tolls
        {
            get { return this._tolls; }
            set { this._tolls = value; }
        }

        // Check to see if Tolls property is set
        internal bool IsSetTolls()
        {
            return this._tolls != null && (this._tolls.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TollSystems. 
        /// <para>
        /// Toll systems are authorities that collect payments for the toll.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RouteTollSystem> TollSystems
        {
            get { return this._tollSystems; }
            set { this._tollSystems = value; }
        }

        // Check to see if TollSystems property is set
        internal bool IsSetTollSystems()
        {
            return this._tollSystems != null && (this._tollSystems.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TravelSteps. 
        /// <para>
        /// Steps of a leg that must be performed before the travel portion of the leg.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RouteVehicleTravelStep> TravelSteps
        {
            get { return this._travelSteps; }
            set { this._travelSteps = value; }
        }

        // Check to see if TravelSteps property is set
        internal bool IsSetTravelSteps()
        {
            return this._travelSteps != null && (this._travelSteps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TruckRoadTypes. 
        /// <para>
        /// Truck road type identifiers. <c>BK1</c> through <c>BK4</c> apply only to Sweden. <c>A2,A4,B2,B4,C,D,ET2,ET4</c>
        /// apply only to Mexico.
        /// </para>
        ///  <note> 
        /// <para>
        /// There are currently no other supported values as of 26th April 2024.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=12)]
        public List<string> TruckRoadTypes
        {
            get { return this._truckRoadTypes; }
            set { this._truckRoadTypes = value; }
        }

        // Check to see if TruckRoadTypes property is set
        internal bool IsSetTruckRoadTypes()
        {
            return this._truckRoadTypes != null && (this._truckRoadTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Zones. 
        /// <para>
        /// Zones corresponding to this leg of the route.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RouteZone> Zones
        {
            get { return this._zones; }
            set { this._zones = value; }
        }

        // Check to see if Zones property is set
        internal bool IsSetZones()
        {
            return this._zones != null && (this._zones.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}