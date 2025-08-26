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
    /// Container for the parameters to the CalculateRoutes operation.
    /// <c>CalculateRoutes</c> computes routes given the following required parameters: <c>Origin</c>
    /// and <c>Destination</c>.
    /// </summary>
    public partial class CalculateRoutesRequest : AmazonGeoRoutesRequest
    {
        private RouteAllowOptions _allow;
        private string _arrivalTime;
        private RouteAvoidanceOptions _avoid;
        private bool? _departNow;
        private string _departureTime;
        private List<double> _destination = AWSConfigs.InitializeCollections ? new List<double>() : null;
        private RouteDestinationOptions _destinationOptions;
        private RouteDriverOptions _driver;
        private RouteExclusionOptions _exclude;
        private MeasurementSystem _instructionsMeasurementSystem;
        private string _key;
        private List<string> _languages = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _legAdditionalFeatures = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private GeometryFormat _legGeometryFormat;
        private int? _maxAlternatives;
        private RoutingObjective _optimizeRoutingFor;
        private List<double> _origin = AWSConfigs.InitializeCollections ? new List<double>() : null;
        private RouteOriginOptions _originOptions;
        private List<string> _spanAdditionalFeatures = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private RouteTollOptions _tolls;
        private RouteTrafficOptions _traffic;
        private RouteTravelMode _travelMode;
        private RouteTravelModeOptions _travelModeOptions;
        private RouteTravelStepType _travelStepType;
        private List<RouteWaypoint> _waypoints = AWSConfigs.InitializeCollections ? new List<RouteWaypoint>() : null;

        /// <summary>
        /// Gets and sets the property Allow. 
        /// <para>
        /// Features that are allowed while calculating a route.
        /// </para>
        /// </summary>
        public RouteAllowOptions Allow
        {
            get { return this._allow; }
            set { this._allow = value; }
        }

        // Check to see if Allow property is set
        internal bool IsSetAllow()
        {
            return this._allow != null;
        }

        /// <summary>
        /// Gets and sets the property ArrivalTime. 
        /// <para>
        /// Time of arrival at the destination.
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
        [AWSProperty(Sensitive=true)]
        public string ArrivalTime
        {
            get { return this._arrivalTime; }
            set { this._arrivalTime = value; }
        }

        // Check to see if ArrivalTime property is set
        internal bool IsSetArrivalTime()
        {
            return this._arrivalTime != null;
        }

        /// <summary>
        /// Gets and sets the property Avoid. 
        /// <para>
        /// Features that are avoided while calculating a route. Avoidance is on a best-case basis.
        /// If an avoidance can't be satisfied for a particular case, it violates the avoidance
        /// and the returned response produces a notice for the violation.
        /// </para>
        /// </summary>
        public RouteAvoidanceOptions Avoid
        {
            get { return this._avoid; }
            set { this._avoid = value; }
        }

        // Check to see if Avoid property is set
        internal bool IsSetAvoid()
        {
            return this._avoid != null;
        }

        /// <summary>
        /// Gets and sets the property DepartNow. 
        /// <para>
        /// Uses the current time as the time of departure.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public bool? DepartNow
        {
            get { return this._departNow; }
            set { this._departNow = value; }
        }

        // Check to see if DepartNow property is set
        internal bool IsSetDepartNow()
        {
            return this._departNow.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DepartureTime. 
        /// <para>
        /// Time of departure from thr origin.
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
        [AWSProperty(Sensitive=true)]
        public string DepartureTime
        {
            get { return this._departureTime; }
            set { this._departureTime = value; }
        }

        // Check to see if DepartureTime property is set
        internal bool IsSetDepartureTime()
        {
            return this._departureTime != null;
        }

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The final position for the route. In the World Geodetic System (WGS 84) format: <c>[longitude,
        /// latitude]</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=2, Max=2)]
        public List<double> Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null && (this._destination.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DestinationOptions. 
        /// <para>
        /// Destination related options.
        /// </para>
        /// </summary>
        public RouteDestinationOptions DestinationOptions
        {
            get { return this._destinationOptions; }
            set { this._destinationOptions = value; }
        }

        // Check to see if DestinationOptions property is set
        internal bool IsSetDestinationOptions()
        {
            return this._destinationOptions != null;
        }

        /// <summary>
        /// Gets and sets the property Driver. 
        /// <para>
        /// Driver related options.
        /// </para>
        /// </summary>
        public RouteDriverOptions Driver
        {
            get { return this._driver; }
            set { this._driver = value; }
        }

        // Check to see if Driver property is set
        internal bool IsSetDriver()
        {
            return this._driver != null;
        }

        /// <summary>
        /// Gets and sets the property Exclude. 
        /// <para>
        /// Features to be strictly excluded while calculating the route.
        /// </para>
        /// </summary>
        public RouteExclusionOptions Exclude
        {
            get { return this._exclude; }
            set { this._exclude = value; }
        }

        // Check to see if Exclude property is set
        internal bool IsSetExclude()
        {
            return this._exclude != null;
        }

        /// <summary>
        /// Gets and sets the property InstructionsMeasurementSystem. 
        /// <para>
        /// Measurement system to be used for instructions within steps in the response.
        /// </para>
        /// </summary>
        public MeasurementSystem InstructionsMeasurementSystem
        {
            get { return this._instructionsMeasurementSystem; }
            set { this._instructionsMeasurementSystem = value; }
        }

        // Check to see if InstructionsMeasurementSystem property is set
        internal bool IsSetInstructionsMeasurementSystem()
        {
            return this._instructionsMeasurementSystem != null;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// Optional: The API key to be used for authorization. Either an API key or valid SigV4
        /// signature must be provided when making a request. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=1000)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Languages. 
        /// <para>
        /// List of languages for instructions within steps in the response.
        /// </para>
        ///  <note> 
        /// <para>
        /// Instructions in the requested language are returned only if they are available.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> Languages
        {
            get { return this._languages; }
            set { this._languages = value; }
        }

        // Check to see if Languages property is set
        internal bool IsSetLanguages()
        {
            return this._languages != null && (this._languages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LegAdditionalFeatures. 
        /// <para>
        /// A list of optional additional parameters such as timezone that can be requested for
        /// each result.
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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=9)]
        public List<string> LegAdditionalFeatures
        {
            get { return this._legAdditionalFeatures; }
            set { this._legAdditionalFeatures = value; }
        }

        // Check to see if LegAdditionalFeatures property is set
        internal bool IsSetLegAdditionalFeatures()
        {
            return this._legAdditionalFeatures != null && (this._legAdditionalFeatures.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LegGeometryFormat. 
        /// <para>
        /// Specifies the format of the geometry returned for each leg of the route. You can choose
        /// between two different geometry encoding formats.
        /// </para>
        ///  
        /// <para>
        ///  <c>FlexiblePolyline</c>: A compact and precise encoding format for the leg geometry.
        /// For more information on the format, see the GitHub repository for <a href="https://github.com/heremaps/flexible-polyline">
        /// <c>FlexiblePolyline</c> </a>.
        /// </para>
        ///  
        /// <para>
        ///  <c>Simple</c>: A less compact encoding, which is easier to decode but may be less
        /// precise and result in larger payloads.
        /// </para>
        /// </summary>
        public GeometryFormat LegGeometryFormat
        {
            get { return this._legGeometryFormat; }
            set { this._legGeometryFormat = value; }
        }

        // Check to see if LegGeometryFormat property is set
        internal bool IsSetLegGeometryFormat()
        {
            return this._legGeometryFormat != null;
        }

        /// <summary>
        /// Gets and sets the property MaxAlternatives. 
        /// <para>
        /// Maximum number of alternative routes to be provided in the response, if available.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public int? MaxAlternatives
        {
            get { return this._maxAlternatives; }
            set { this._maxAlternatives = value; }
        }

        // Check to see if MaxAlternatives property is set
        internal bool IsSetMaxAlternatives()
        {
            return this._maxAlternatives.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OptimizeRoutingFor. 
        /// <para>
        /// Specifies the optimization criteria for calculating a route.
        /// </para>
        ///  
        /// <para>
        /// Default Value: <c>FastestRoute</c> 
        /// </para>
        /// </summary>
        public RoutingObjective OptimizeRoutingFor
        {
            get { return this._optimizeRoutingFor; }
            set { this._optimizeRoutingFor = value; }
        }

        // Check to see if OptimizeRoutingFor property is set
        internal bool IsSetOptimizeRoutingFor()
        {
            return this._optimizeRoutingFor != null;
        }

        /// <summary>
        /// Gets and sets the property Origin. 
        /// <para>
        /// The start position for the route.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=2, Max=2)]
        public List<double> Origin
        {
            get { return this._origin; }
            set { this._origin = value; }
        }

        // Check to see if Origin property is set
        internal bool IsSetOrigin()
        {
            return this._origin != null && (this._origin.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OriginOptions. 
        /// <para>
        /// Origin related options.
        /// </para>
        /// </summary>
        public RouteOriginOptions OriginOptions
        {
            get { return this._originOptions; }
            set { this._originOptions = value; }
        }

        // Check to see if OriginOptions property is set
        internal bool IsSetOriginOptions()
        {
            return this._originOptions != null;
        }

        /// <summary>
        /// Gets and sets the property SpanAdditionalFeatures. 
        /// <para>
        /// A list of optional features such as SpeedLimit that can be requested for a Span. A
        /// span is a section of a Leg for which the requested features have the same values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=24)]
        public List<string> SpanAdditionalFeatures
        {
            get { return this._spanAdditionalFeatures; }
            set { this._spanAdditionalFeatures = value; }
        }

        // Check to see if SpanAdditionalFeatures property is set
        internal bool IsSetSpanAdditionalFeatures()
        {
            return this._spanAdditionalFeatures != null && (this._spanAdditionalFeatures.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tolls. 
        /// <para>
        /// Toll related options.
        /// </para>
        /// </summary>
        public RouteTollOptions Tolls
        {
            get { return this._tolls; }
            set { this._tolls = value; }
        }

        // Check to see if Tolls property is set
        internal bool IsSetTolls()
        {
            return this._tolls != null;
        }

        /// <summary>
        /// Gets and sets the property Traffic. 
        /// <para>
        /// Traffic related options.
        /// </para>
        /// </summary>
        public RouteTrafficOptions Traffic
        {
            get { return this._traffic; }
            set { this._traffic = value; }
        }

        // Check to see if Traffic property is set
        internal bool IsSetTraffic()
        {
            return this._traffic != null;
        }

        /// <summary>
        /// Gets and sets the property TravelMode. 
        /// <para>
        /// Specifies the mode of transport when calculating a route. Used in estimating the speed
        /// of travel and road compatibility.
        /// </para>
        ///  
        /// <para>
        /// Default Value: <c>Car</c> 
        /// </para>
        /// </summary>
        public RouteTravelMode TravelMode
        {
            get { return this._travelMode; }
            set { this._travelMode = value; }
        }

        // Check to see if TravelMode property is set
        internal bool IsSetTravelMode()
        {
            return this._travelMode != null;
        }

        /// <summary>
        /// Gets and sets the property TravelModeOptions. 
        /// <para>
        /// Travel mode related options for the provided travel mode.
        /// </para>
        /// </summary>
        public RouteTravelModeOptions TravelModeOptions
        {
            get { return this._travelModeOptions; }
            set { this._travelModeOptions = value; }
        }

        // Check to see if TravelModeOptions property is set
        internal bool IsSetTravelModeOptions()
        {
            return this._travelModeOptions != null;
        }

        /// <summary>
        /// Gets and sets the property TravelStepType. 
        /// <para>
        /// Type of step returned by the response. Default provides basic steps intended for web
        /// based applications. TurnByTurn provides detailed instructions with more granularity
        /// intended for a turn based navigation system.
        /// </para>
        /// </summary>
        public RouteTravelStepType TravelStepType
        {
            get { return this._travelStepType; }
            set { this._travelStepType = value; }
        }

        // Check to see if TravelStepType property is set
        internal bool IsSetTravelStepType()
        {
            return this._travelStepType != null;
        }

        /// <summary>
        /// Gets and sets the property Waypoints. 
        /// <para>
        /// List of waypoints between the Origin and Destination.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RouteWaypoint> Waypoints
        {
            get { return this._waypoints; }
            set { this._waypoints = value; }
        }

        // Check to see if Waypoints property is set
        internal bool IsSetWaypoints()
        {
            return this._waypoints != null && (this._waypoints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}