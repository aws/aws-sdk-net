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

namespace Amazon.GeoRoutes.Model
{
    /// <summary>
    /// Steps of a leg that correspond to the travel portion of the leg.
    /// </summary>
    public partial class RouteVehicleLegDetails
    {
        /// <summary>
        /// Gets and sets the property AfterTravelSteps. 
        /// <para>
        /// Steps of a leg that must be performed after the travel portion of the leg.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<RouteVehicleAfterTravelStep> AfterTravelSteps { get; set; } = AWSConfigs.InitializeCollections ? new List<RouteVehicleAfterTravelStep>() : null;

        /// <summary>
        /// Checks to see if the AfterTravelSteps property is set.
        /// </summary>
        internal bool IsSetAfterTravelSteps() => this.AfterTravelSteps != null && (this.AfterTravelSteps.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Arrival. 
        /// <para>
        /// Details corresponding to the arrival for the leg.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RouteVehicleArrival Arrival { get; set; }

        /// <summary>
        /// Checks to see if the Arrival property is set.
        /// </summary>
        internal bool IsSetArrival() => this.Arrival != null;

        /// <summary>
        /// Gets and sets the property Departure. 
        /// <para>
        /// Details corresponding to the departure for the leg.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RouteVehicleDeparture Departure { get; set; }

        /// <summary>
        /// Checks to see if the Departure property is set.
        /// </summary>
        internal bool IsSetDeparture() => this.Departure != null;

        /// <summary>
        /// Gets and sets the property Incidents. 
        /// <para>
        ///  Incidents corresponding to this leg of the route. Not supported in <c>ap-southeast-1</c>
        /// and <c>ap-southeast-5</c> regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<RouteVehicleIncident> Incidents { get; set; } = AWSConfigs.InitializeCollections ? new List<RouteVehicleIncident>() : null;

        /// <summary>
        /// Checks to see if the Incidents property is set.
        /// </summary>
        internal bool IsSetIncidents() => this.Incidents != null && (this.Incidents.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Notices. 
        /// <para>
        ///  Notices are additional information returned that indicate issues that occurred during
        /// route calculation. Not supported in <c>ap-southeast-1</c> and <c>ap-southeast-5</c>
        /// regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<RouteVehicleNotice> Notices { get; set; } = AWSConfigs.InitializeCollections ? new List<RouteVehicleNotice>() : null;

        /// <summary>
        /// Checks to see if the Notices property is set.
        /// </summary>
        internal bool IsSetNotices() => this.Notices != null && (this.Notices.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PassThroughWaypoints. 
        /// <para>
        /// Waypoints that were passed through during the leg. This includes the waypoints that
        /// were configured with the PassThrough option.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<RoutePassThroughWaypoint> PassThroughWaypoints { get; set; } = AWSConfigs.InitializeCollections ? new List<RoutePassThroughWaypoint>() : null;

        /// <summary>
        /// Checks to see if the PassThroughWaypoints property is set.
        /// </summary>
        internal bool IsSetPassThroughWaypoints() => this.PassThroughWaypoints != null && (this.PassThroughWaypoints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Spans. 
        /// <para>
        ///  Spans that were computed for the requested SpanAdditionalFeatures. Not supported
        /// in <c>ap-southeast-1</c> and <c>ap-southeast-5</c> regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<RouteVehicleSpan> Spans { get; set; } = AWSConfigs.InitializeCollections ? new List<RouteVehicleSpan>() : null;

        /// <summary>
        /// Checks to see if the Spans property is set.
        /// </summary>
        internal bool IsSetSpans() => this.Spans != null && (this.Spans.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Summary. 
        /// <para>
        /// Summarized details of the leg.
        /// </para>
        /// </summary>
        public RouteVehicleSummary Summary { get; set; }

        /// <summary>
        /// Checks to see if the Summary property is set.
        /// </summary>
        internal bool IsSetSummary() => this.Summary != null;

        /// <summary>
        /// Gets and sets the property TollSystems. 
        /// <para>
        ///  Toll systems are authorities that collect payments for the toll. Not supported in
        /// <c>ap-southeast-1</c> and <c>ap-southeast-5</c> regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<RouteTollSystem> TollSystems { get; set; } = AWSConfigs.InitializeCollections ? new List<RouteTollSystem>() : null;

        /// <summary>
        /// Checks to see if the TollSystems property is set.
        /// </summary>
        internal bool IsSetTollSystems() => this.TollSystems != null && (this.TollSystems.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tolls. 
        /// <para>
        ///  Toll related options. Not supported in <c>ap-southeast-1</c> and <c>ap-southeast-5</c>
        /// regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<RouteToll> Tolls { get; set; } = AWSConfigs.InitializeCollections ? new List<RouteToll>() : null;

        /// <summary>
        /// Checks to see if the Tolls property is set.
        /// </summary>
        internal bool IsSetTolls() => this.Tolls != null && (this.Tolls.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TravelSteps. 
        /// <para>
        /// Steps of a leg that must be performed before the travel portion of the leg.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<RouteVehicleTravelStep> TravelSteps { get; set; } = AWSConfigs.InitializeCollections ? new List<RouteVehicleTravelStep>() : null;

        /// <summary>
        /// Checks to see if the TravelSteps property is set.
        /// </summary>
        internal bool IsSetTravelSteps() => this.TravelSteps != null && (this.TravelSteps.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TruckRoadTypes. 
        /// <para>
        ///  Truck road type identifiers. <c>BK1</c> through <c>BK4</c> apply only to Sweden.
        /// <c>A2,A4,B2,B4,C,D,ET2,ET4</c> apply only to Mexico. Not supported in <c>ap-southeast-1</c>
        /// and <c>ap-southeast-5</c> regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        ///  <note> 
        /// <para>
        /// There are currently no other supported values as of 26th April 2024.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 12)]
        public List<string> TruckRoadTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TruckRoadTypes property is set.
        /// </summary>
        internal bool IsSetTruckRoadTypes() => this.TruckRoadTypes != null && (this.TruckRoadTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Zones. 
        /// <para>
        ///  Zones corresponding to this leg of the route. Not supported in <c>ap-southeast-1</c>
        /// and <c>ap-southeast-5</c> regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<RouteZone> Zones { get; set; } = AWSConfigs.InitializeCollections ? new List<RouteZone>() : null;

        /// <summary>
        /// Checks to see if the Zones property is set.
        /// </summary>
        internal bool IsSetZones() => this.Zones != null && (this.Zones.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
