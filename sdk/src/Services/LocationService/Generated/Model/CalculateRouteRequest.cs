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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Container for the parameters to the CalculateRoute operation.
    /// <a href="https://docs.aws.amazon.com/location/previous/developerguide/calculate-route.html">Calculates
    /// a route</a> given the following required parameters: <c>DeparturePosition</c> and
    /// <c>DestinationPosition</c>. Requires that you first <a href="https://docs.aws.amazon.com/location-routes/latest/APIReference/API_CreateRouteCalculator.html">create
    /// a route calculator resource</a>.
    /// 
    ///  
    /// <para>
    /// By default, a request that doesn't specify a departure time uses the best time of
    /// day to travel with the best traffic conditions when calculating the route.
    /// </para>
    ///  
    /// <para>
    /// Additional options include:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/location/previous/developerguide/departure-time.html">Specifying
    /// a departure time</a> using either <c>DepartureTime</c> or <c>DepartNow</c>. This calculates
    /// a route based on predictive traffic data at the given time. 
    /// </para>
    ///  <note> 
    /// <para>
    /// You can't specify both <c>DepartureTime</c> and <c>DepartNow</c> in a single request.
    /// Specifying both parameters returns a validation error.
    /// </para>
    ///  </note> </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/location/previous/developerguide/travel-mode.html">Specifying
    /// a travel mode</a> using TravelMode sets the transportation mode used to calculate
    /// the routes. This also lets you specify additional route preferences in <c>CarModeOptions</c>
    /// if traveling by <c>Car</c>, or <c>TruckModeOptions</c> if traveling by <c>Truck</c>.
    /// </para>
    ///  <note> 
    /// <para>
    /// If you specify <c>walking</c> for the travel mode and your data provider is Esri,
    /// the start and destination must be within 40km.
    /// </para>
    ///  </note> </li> </ul>
    /// </summary>
    public partial class CalculateRouteRequest : AmazonLocationServiceRequest
    {
        private DateTime? _arrivalTime;
        private string _calculatorName;
        private CalculateRouteCarModeOptions _carModeOptions;
        private bool? _departNow;
        private List<double> _departurePosition = AWSConfigs.InitializeCollections ? new List<double>() : null;
        private DateTime? _departureTime;
        private List<double> _destinationPosition = AWSConfigs.InitializeCollections ? new List<double>() : null;
        private DistanceUnit _distanceUnit;
        private bool? _includeLegGeometry;
        private string _key;
        private OptimizationMode _optimizeFor;
        private TravelMode _travelMode;
        private CalculateRouteTruckModeOptions _truckModeOptions;
        private List<List<double>> _waypointPositions = AWSConfigs.InitializeCollections ? new List<List<double>>() : null;

        /// <summary>
        /// Gets and sets the property ArrivalTime. 
        /// <para>
        /// Specifies the desired time of arrival. Uses the given time to calculate the route.
        /// Otherwise, the best time of day to travel with the best traffic conditions is used
        /// to calculate the route.
        /// </para>
        ///  <note> 
        /// <para>
        /// ArrivalTime is not supported Esri.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public DateTime? ArrivalTime
        {
            get { return this._arrivalTime; }
            set { this._arrivalTime = value; }
        }

        // Check to see if ArrivalTime property is set
        internal bool IsSetArrivalTime()
        {
            return this._arrivalTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CalculatorName. 
        /// <para>
        /// The name of the route calculator resource that you want to use to calculate the route.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string CalculatorName
        {
            get { return this._calculatorName; }
            set { this._calculatorName = value; }
        }

        // Check to see if CalculatorName property is set
        internal bool IsSetCalculatorName()
        {
            return this._calculatorName != null;
        }

        /// <summary>
        /// Gets and sets the property CarModeOptions. 
        /// <para>
        /// Specifies route preferences when traveling by <c>Car</c>, such as avoiding routes
        /// that use ferries or tolls.
        /// </para>
        ///  
        /// <para>
        /// Requirements: <c>TravelMode</c> must be specified as <c>Car</c>.
        /// </para>
        /// </summary>
        public CalculateRouteCarModeOptions CarModeOptions
        {
            get { return this._carModeOptions; }
            set { this._carModeOptions = value; }
        }

        // Check to see if CarModeOptions property is set
        internal bool IsSetCarModeOptions()
        {
            return this._carModeOptions != null;
        }

        /// <summary>
        /// Gets and sets the property DepartNow. 
        /// <para>
        /// Sets the time of departure as the current time. Uses the current time to calculate
        /// a route. Otherwise, the best time of day to travel with the best traffic conditions
        /// is used to calculate the route.
        /// </para>
        ///  
        /// <para>
        /// Default Value: <c>false</c> 
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>false</c> | <c>true</c> 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DeparturePosition. 
        /// <para>
        /// The start position for the route. Defined in <a href="https://earth-info.nga.mil/index.php?dir=wgs84&amp;action=wgs84">World
        /// Geodetic System (WGS 84)</a> format: <c>[longitude, latitude]</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For example, <c>[-123.115, 49.285]</c> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// If you specify a departure that's not located on a road, Amazon Location <a href="https://docs.aws.amazon.com/location/previous/developerguide/snap-to-nearby-road.html">moves
        /// the position to the nearest road</a>. If Esri is the provider for your route calculator,
        /// specifying a route that is longer than 400 km returns a <c>400 RoutesValidationException</c>
        /// error.
        /// </para>
        ///  </note> 
        /// <para>
        /// Valid Values: <c>[-180 to 180,-90 to 90]</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=2, Max=2)]
        public List<double> DeparturePosition
        {
            get { return this._departurePosition; }
            set { this._departurePosition = value; }
        }

        // Check to see if DeparturePosition property is set
        internal bool IsSetDeparturePosition()
        {
            return this._departurePosition != null && (this._departurePosition.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DepartureTime. 
        /// <para>
        /// Specifies the desired time of departure. Uses the given time to calculate the route.
        /// Otherwise, the best time of day to travel with the best traffic conditions is used
        /// to calculate the route.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// In <a href="https://www.iso.org/iso-8601-date-and-time-format.html">ISO 8601</a> format:
        /// <c>YYYY-MM-DDThh:mm:ss.sssZ</c>. For example, <c>2020–07-2T12:15:20.000Z+01:00</c>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public DateTime? DepartureTime
        {
            get { return this._departureTime; }
            set { this._departureTime = value; }
        }

        // Check to see if DepartureTime property is set
        internal bool IsSetDepartureTime()
        {
            return this._departureTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DestinationPosition. 
        /// <para>
        /// The finish position for the route. Defined in <a href="https://earth-info.nga.mil/index.php?dir=wgs84&amp;action=wgs84">World
        /// Geodetic System (WGS 84)</a> format: <c>[longitude, latitude]</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  For example, <c>[-122.339, 47.615]</c> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// If you specify a destination that's not located on a road, Amazon Location <a href="https://docs.aws.amazon.com/location/previous/developerguide/snap-to-nearby-road.html">moves
        /// the position to the nearest road</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Valid Values: <c>[-180 to 180,-90 to 90]</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=2, Max=2)]
        public List<double> DestinationPosition
        {
            get { return this._destinationPosition; }
            set { this._destinationPosition = value; }
        }

        // Check to see if DestinationPosition property is set
        internal bool IsSetDestinationPosition()
        {
            return this._destinationPosition != null && (this._destinationPosition.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DistanceUnit. 
        /// <para>
        /// Set the unit system to specify the distance.
        /// </para>
        ///  
        /// <para>
        /// Default Value: <c>Kilometers</c> 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property IncludeLegGeometry. 
        /// <para>
        /// Set to include the geometry details in the result for each path between a pair of
        /// positions.
        /// </para>
        ///  
        /// <para>
        /// Default Value: <c>false</c> 
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>false</c> | <c>true</c> 
        /// </para>
        /// </summary>
        public bool? IncludeLegGeometry
        {
            get { return this._includeLegGeometry; }
            set { this._includeLegGeometry = value; }
        }

        // Check to see if IncludeLegGeometry property is set
        internal bool IsSetIncludeLegGeometry()
        {
            return this._includeLegGeometry.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The optional <a href="https://docs.aws.amazon.com/location/previous/developerguide/using-apikeys.html">API
        /// key</a> to authorize the request.
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
        /// Gets and sets the property OptimizeFor. 
        /// <para>
        /// Specifies the distance to optimize for when calculating a route.
        /// </para>
        /// </summary>
        public OptimizationMode OptimizeFor
        {
            get { return this._optimizeFor; }
            set { this._optimizeFor = value; }
        }

        // Check to see if OptimizeFor property is set
        internal bool IsSetOptimizeFor()
        {
            return this._optimizeFor != null;
        }

        /// <summary>
        /// Gets and sets the property TravelMode. 
        /// <para>
        /// Specifies the mode of transport when calculating a route. Used in estimating the speed
        /// of travel and road compatibility. You can choose <c>Car</c>, <c>Truck</c>, <c>Walking</c>,
        /// <c>Bicycle</c> or <c>Motorcycle</c> as options for the <c>TravelMode</c>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>Bicycle</c> and <c>Motorcycle</c> are only valid when using Grab as a data provider,
        /// and only within Southeast Asia.
        /// </para>
        ///  
        /// <para>
        ///  <c>Truck</c> is not available for Grab.
        /// </para>
        ///  
        /// <para>
        /// For more details on the using Grab for routing, including areas of coverage, see <a
        /// href="https://docs.aws.amazon.com/location/previous/developerguide/grab.html">GrabMaps</a>
        /// in the <i>Amazon Location Service Developer Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The <c>TravelMode</c> you specify also determines how you specify route preferences:
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If traveling by <c>Car</c> use the <c>CarModeOptions</c> parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If traveling by <c>Truck</c> use the <c>TruckModeOptions</c> parameter.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default Value: <c>Car</c> 
        /// </para>
        /// </summary>
        public TravelMode TravelMode
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
        /// Gets and sets the property TruckModeOptions. 
        /// <para>
        /// Specifies route preferences when traveling by <c>Truck</c>, such as avoiding routes
        /// that use ferries or tolls, and truck specifications to consider when choosing an optimal
        /// road.
        /// </para>
        ///  
        /// <para>
        /// Requirements: <c>TravelMode</c> must be specified as <c>Truck</c>.
        /// </para>
        /// </summary>
        public CalculateRouteTruckModeOptions TruckModeOptions
        {
            get { return this._truckModeOptions; }
            set { this._truckModeOptions = value; }
        }

        // Check to see if TruckModeOptions property is set
        internal bool IsSetTruckModeOptions()
        {
            return this._truckModeOptions != null;
        }

        /// <summary>
        /// Gets and sets the property WaypointPositions. 
        /// <para>
        /// Specifies an ordered list of up to 23 intermediate positions to include along a route
        /// between the departure position and destination position. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For example, from the <c>DeparturePosition</c> <c>[-123.115, 49.285]</c>, the route
        /// follows the order that the waypoint positions are given <c>[[-122.757, 49.0021],[-122.349,
        /// 47.620]]</c> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// If you specify a waypoint position that's not located on a road, Amazon Location <a
        /// href="https://docs.aws.amazon.com/location/previous/developerguide/snap-to-nearby-road.html">moves
        /// the position to the nearest road</a>. 
        /// </para>
        ///  
        /// <para>
        /// Specifying more than 23 waypoints returns a <c>400 ValidationException</c> error.
        /// </para>
        ///  
        /// <para>
        /// If Esri is the provider for your route calculator, specifying a route that is longer
        /// than 400 km returns a <c>400 RoutesValidationException</c> error.
        /// </para>
        ///  </note> 
        /// <para>
        /// Valid Values: <c>[-180 to 180,-90 to 90]</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=23)]
        public List<List<double>> WaypointPositions
        {
            get { return this._waypointPositions; }
            set { this._waypointPositions = value; }
        }

        // Check to see if WaypointPositions property is set
        internal bool IsSetWaypointPositions()
        {
            return this._waypointPositions != null && (this._waypointPositions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}