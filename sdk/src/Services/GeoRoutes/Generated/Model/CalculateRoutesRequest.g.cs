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
    /// Container for the parameters to the CalculateRoutes operation. <c>CalculateRoutes</c>
    /// computes routes given the following required parameters: <c>Origin</c> and <c>Destination</c>.
    /// <para> For more information, see <a href="https://docs.aws.amazon.com/location/latest/developerguide/calculate-routes.html">Calculate
    /// routes</a> in the <i>Amazon Location Service Developer Guide</i>. </para>
    /// </summary>
    public partial class CalculateRoutesRequest : AmazonGeoRoutesRequest
    {
        /// <summary>
        /// Gets and sets the property Allow. 
        /// <para>
        ///  Features that are allowed while calculating a route. Not supported in <c>ap-southeast-1</c>
        /// and <c>ap-southeast-5</c> regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        /// </summary>
        public RouteAllowOptions Allow { get; set; }

        /// <summary>
        /// Checks to see if the Allow property is set.
        /// </summary>
        internal bool IsSetAllow() => this.Allow != null;

        /// <summary>
        /// Gets and sets the property ArrivalTime. 
        /// <para>
        ///  Time of arrival at the destination. Not supported in <c>ap-southeast-1</c> and <c>ap-southeast-5</c>
        /// regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        ///  
        /// <para>
        /// Time format:<c>YYYY-MM-DDThh:mm:ss.sssZ | YYYY-MM-DDThh:mm:ss.sss+hh:mm</c> 
        /// </para>
        ///  
        /// <para>
        /// Examples:
        /// </para>
        ///  
        /// <para>
        ///  <c>2020-04-22T17:57:24Z</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>2020-04-22T17:57:24+02:00</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string ArrivalTime { get; set; }

        /// <summary>
        /// Checks to see if the ArrivalTime property is set.
        /// </summary>
        internal bool IsSetArrivalTime() => this.ArrivalTime != null;

        /// <summary>
        /// Gets and sets the property Avoid. 
        /// <para>
        ///  Features that are avoided while calculating a route. Avoidance is on a best-case
        /// basis. If an avoidance can't be satisfied for a particular case, it violates the avoidance
        /// and the returned response produces a notice for the violation. For <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers, <c>ap-southeast-1</c> and <c>ap-southeast-5</c> regions support only <c>ControlledAccessHighways</c>,
        /// <c>Ferries</c>, and <c>TollRoads</c> 
        /// </para>
        /// </summary>
        public RouteAvoidanceOptions Avoid { get; set; }

        /// <summary>
        /// Checks to see if the Avoid property is set.
        /// </summary>
        internal bool IsSetAvoid() => this.Avoid != null;

        /// <summary>
        /// Gets and sets the property DepartNow. 
        /// <para>
        /// Uses the current time as the time of departure.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public bool? DepartNow { get; set; }

        /// <summary>
        /// Checks to see if the DepartNow property is set.
        /// </summary>
        internal bool IsSetDepartNow() => this.DepartNow.HasValue;

        /// <summary>
        /// Gets and sets the property DepartureTime. 
        /// <para>
        /// Time of departure from the origin.
        /// </para>
        ///  
        /// <para>
        /// Time format:<c>YYYY-MM-DDThh:mm:ss.sssZ | YYYY-MM-DDThh:mm:ss.sss+hh:mm</c> 
        /// </para>
        ///  
        /// <para>
        /// Examples:
        /// </para>
        ///  
        /// <para>
        ///  <c>2020-04-22T17:57:24Z</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>2020-04-22T17:57:24+02:00</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string DepartureTime { get; set; }

        /// <summary>
        /// Checks to see if the DepartureTime property is set.
        /// </summary>
        internal bool IsSetDepartureTime() => this.DepartureTime != null;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The final position for the route. In the World Geodetic System (WGS 84) format: <c>[longitude,
        /// latitude]</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 2, Max = 2)]
        public List<double> Destination { get; set; } = AWSConfigs.InitializeCollections ? new List<double>() : null;

        /// <summary>
        /// Checks to see if the Destination property is set.
        /// </summary>
        internal bool IsSetDestination() => this.Destination != null && (this.Destination.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DestinationOptions. 
        /// <para>
        ///  Destination related options. Not supported in <c>ap-southeast-1</c> and <c>ap-southeast-5</c>
        /// regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        /// </summary>
        public RouteDestinationOptions DestinationOptions { get; set; }

        /// <summary>
        /// Checks to see if the DestinationOptions property is set.
        /// </summary>
        internal bool IsSetDestinationOptions() => this.DestinationOptions != null;

        /// <summary>
        /// Gets and sets the property Driver. 
        /// <para>
        ///  Driver related options. Not supported in <c>ap-southeast-1</c> and <c>ap-southeast-5</c>
        /// regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        /// </summary>
        public RouteDriverOptions Driver { get; set; }

        /// <summary>
        /// Checks to see if the Driver property is set.
        /// </summary>
        internal bool IsSetDriver() => this.Driver != null;

        /// <summary>
        /// Gets and sets the property Exclude. 
        /// <para>
        ///  Features to be strictly excluded while calculating the route. Not supported in <c>ap-southeast-1</c>
        /// and <c>ap-southeast-5</c> regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        /// </summary>
        public RouteExclusionOptions Exclude { get; set; }

        /// <summary>
        /// Checks to see if the Exclude property is set.
        /// </summary>
        internal bool IsSetExclude() => this.Exclude != null;

        /// <summary>
        /// Gets and sets the property InstructionsMeasurementSystem. 
        /// <para>
        /// Measurement system to be used for instructions within steps in the response.
        /// </para>
        /// </summary>
        public MeasurementSystem InstructionsMeasurementSystem { get; set; }

        /// <summary>
        /// Checks to see if the InstructionsMeasurementSystem property is set.
        /// </summary>
        internal bool IsSetInstructionsMeasurementSystem() => this.InstructionsMeasurementSystem != null;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// Optional: The API key to be used for authorization. Either an API key or valid SigV4
        /// signature must be provided when making a request. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 1000)]
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property Languages. 
        /// <para>
        ///  List of languages for instructions within steps in the response. Not supported in
        /// <c>ap-southeast-1</c> and <c>ap-southeast-5</c> regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Instructions in the requested language are returned only if they are available.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<string> Languages { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Languages property is set.
        /// </summary>
        internal bool IsSetLanguages() => this.Languages != null && (this.Languages.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LegAdditionalFeatures. 
        /// <para>
        ///  A list of optional additional parameters such as timezone that can be requested for
        /// each result. For <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers, <c>ap-southeast-1</c> and <c>ap-southeast-5</c> regions support only <c>PassThroughWaypoints</c>,
        /// <c>Summary</c>, and <c>TravelStepInstructions</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Elevation</c>: Retrieves the elevation information for each location.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Incidents</c>: Provides information on traffic incidents along the route.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PassThroughWaypoints</c>: Indicates waypoints that are passed through without
        /// stopping.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Summary</c>: Returns a summary of the route, including distance and duration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Tolls</c>: Supplies toll cost information along the route.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TravelStepInstructions</c>: Provides step-by-step instructions for travel along
        /// the route.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TruckRoadTypes</c>: Returns information about road types suitable for trucks.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TypicalDuration</c>: Gives typical travel duration based on historical data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Zones</c>: Specifies the time zone information for each waypoint.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 12)]
        public List<string> LegAdditionalFeatures { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LegAdditionalFeatures property is set.
        /// </summary>
        internal bool IsSetLegAdditionalFeatures() => this.LegAdditionalFeatures != null && (this.LegAdditionalFeatures.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LegGeometryFormat. 
        /// <para>
        /// Specifies the format of the geometry returned for each leg of the route. You can choose
        /// between two different geometry encoding formats.
        /// </para>
        ///  
        /// <para>
        ///  <c>FlexiblePolyline</c>: A compact and precise encoding format for the leg geometry.
        /// For more information on the format, see the GitHub repository for <a href="https://github.com/aws-geospatial/polyline">https://github.com/aws-geospatial/polyline</a>.
        /// </para>
        ///  
        /// <para>
        ///  <c>Simple</c>: A less compact encoding, which is easier to decode but may be less
        /// precise and result in larger payloads.
        /// </para>
        /// </summary>
        public GeometryFormat LegGeometryFormat { get; set; }

        /// <summary>
        /// Checks to see if the LegGeometryFormat property is set.
        /// </summary>
        internal bool IsSetLegGeometryFormat() => this.LegGeometryFormat != null;

        /// <summary>
        /// Gets and sets the property MaxAlternatives. 
        /// <para>
        /// Maximum number of alternative routes to be provided in the response, if available.
        /// For <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers, <c>ap-southeast-1</c> and <c>ap-southeast-5</c> regions support only up
        /// to 3 alternative routes. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public int? MaxAlternatives { get; set; }

        /// <summary>
        /// Checks to see if the MaxAlternatives property is set.
        /// </summary>
        internal bool IsSetMaxAlternatives() => this.MaxAlternatives.HasValue;

        /// <summary>
        /// Gets and sets the property OptimizeRoutingFor. 
        /// <para>
        /// Controls the trade-off between achieving the shortest travel time (<c>FastestRoute</c>)
        /// and achieving the shortest physical distance ((<c>ShortestRoute</c>) when calculating
        /// each route in the matrix.
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>FastestRoute</c> 
        /// </para>
        /// </summary>
        public RoutingObjective OptimizeRoutingFor { get; set; }

        /// <summary>
        /// Checks to see if the OptimizeRoutingFor property is set.
        /// </summary>
        internal bool IsSetOptimizeRoutingFor() => this.OptimizeRoutingFor != null;

        /// <summary>
        /// Gets and sets the property Origin. 
        /// <para>
        /// The start position for the route in World Geodetic System (WGS 84) format: [longitude,
        /// latitude].
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 2, Max = 2)]
        public List<double> Origin { get; set; } = AWSConfigs.InitializeCollections ? new List<double>() : null;

        /// <summary>
        /// Checks to see if the Origin property is set.
        /// </summary>
        internal bool IsSetOrigin() => this.Origin != null && (this.Origin.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OriginOptions. 
        /// <para>
        ///  Specifies how the origin point should be matched to the road network and any routing
        /// constraints that apply when the traveler is departing the origin. Not supported in
        /// <c>ap-southeast-1</c> and <c>ap-southeast-5</c> regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        /// </summary>
        public RouteOriginOptions OriginOptions { get; set; }

        /// <summary>
        /// Checks to see if the OriginOptions property is set.
        /// </summary>
        internal bool IsSetOriginOptions() => this.OriginOptions != null;

        /// <summary>
        /// Gets and sets the property SpanAdditionalFeatures. 
        /// <para>
        ///  A list of optional features such as <c>SpeedLimit</c> that can be requested for a
        /// Span. A span is a section of a Leg for which the requested features have the same
        /// values. Not supported in <c>ap-southeast-1</c> and <c>ap-southeast-5</c> regions for
        /// <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 24)]
        public List<string> SpanAdditionalFeatures { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SpanAdditionalFeatures property is set.
        /// </summary>
        internal bool IsSetSpanAdditionalFeatures() => this.SpanAdditionalFeatures != null && (this.SpanAdditionalFeatures.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tolls. 
        /// <para>
        ///  Toll related options. Not supported in <c>ap-southeast-1</c> and <c>ap-southeast-5</c>
        /// regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        /// </summary>
        public RouteTollOptions Tolls { get; set; }

        /// <summary>
        /// Checks to see if the Tolls property is set.
        /// </summary>
        internal bool IsSetTolls() => this.Tolls != null;

        /// <summary>
        /// Gets and sets the property Traffic. 
        /// <para>
        ///  Traffic related options. Not supported in <c>ap-southeast-1</c> and <c>ap-southeast-5</c>
        /// regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        /// </summary>
        public RouteTrafficOptions Traffic { get; set; }

        /// <summary>
        /// Checks to see if the Traffic property is set.
        /// </summary>
        internal bool IsSetTraffic() => this.Traffic != null;

        /// <summary>
        /// Gets and sets the property TravelMode. 
        /// <para>
        ///  Specifies the mode of transport when calculating a route. Used in estimating the
        /// speed of travel and road compatibility. For <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers, <c>ap-southeast-1</c> and <c>ap-southeast-5</c> regions support only <c>Car</c>,
        /// <c>Pedestrian</c>, and <c>Scooter</c> values. 
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>Car</c> 
        /// </para>
        /// </summary>
        public RouteTravelMode TravelMode { get; set; }

        /// <summary>
        /// Checks to see if the TravelMode property is set.
        /// </summary>
        internal bool IsSetTravelMode() => this.TravelMode != null;

        /// <summary>
        /// Gets and sets the property TravelModeOptions. 
        /// <para>
        ///  Travel mode related options for the provided travel mode. For <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers, <c>ap-southeast-1</c> and <c>ap-southeast-5</c> regions support only <c>Car</c>
        /// and <c>Pedestrian</c> travel mode options. 
        /// </para>
        /// </summary>
        public RouteTravelModeOptions TravelModeOptions { get; set; }

        /// <summary>
        /// Checks to see if the TravelModeOptions property is set.
        /// </summary>
        internal bool IsSetTravelModeOptions() => this.TravelModeOptions != null;

        /// <summary>
        /// Gets and sets the property TravelStepType. 
        /// <para>
        /// Type of step returned by the response. <c>Default</c> provides basic steps intended
        /// for web based applications. <c>TurnByTurn</c> provides detailed instructions with
        /// more granularity intended for a turn based navigation system. For <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers, <c>ap-southeast-1</c> and <c>ap-southeast-5</c> regions <c>Default</c>
        /// does not return any steps. 
        /// </para>
        /// </summary>
        public RouteTravelStepType TravelStepType { get; set; }

        /// <summary>
        /// Checks to see if the TravelStepType property is set.
        /// </summary>
        internal bool IsSetTravelStepType() => this.TravelStepType != null;

        /// <summary>
        /// Gets and sets the property Waypoints. 
        /// <para>
        ///  List of waypoints between the Origin and Destination. For <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers, <c>ap-southeast-1</c> and <c>ap-southeast-5</c> regions max length is <c>100</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Max length: <c>23</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RouteWaypoint> Waypoints { get; set; } = AWSConfigs.InitializeCollections ? new List<RouteWaypoint>() : null;

        /// <summary>
        /// Checks to see if the Waypoints property is set.
        /// </summary>
        internal bool IsSetWaypoints() => this.Waypoints != null && (this.Waypoints.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
