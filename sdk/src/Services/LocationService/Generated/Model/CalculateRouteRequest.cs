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
    /// Container for the parameters to the CalculateRoute operation.
    /// <a href="https://docs.aws.amazon.com/location/latest/developerguide/calculate-route.html">Calculates
    /// a route</a> given the following required parameters: <code>DeparturePosition</code>
    /// and <code>DestinationPosition</code>. Requires that you first <a href="https://docs.aws.amazon.com/location-routes/latest/APIReference/API_CreateRouteCalculator.html">create
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
    ///  <a href="https://docs.aws.amazon.com/location/latest/developerguide/departure-time.html">Specifying
    /// a departure time</a> using either <code>DepartureTime</code> or <code>DepartNow</code>.
    /// This calculates a route based on predictive traffic data at the given time. 
    /// </para>
    ///  <note> 
    /// <para>
    /// You can't specify both <code>DepartureTime</code> and <code>DepartNow</code> in a
    /// single request. Specifying both parameters returns a validation error.
    /// </para>
    ///  </note> </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/location/latest/developerguide/travel-mode.html">Specifying
    /// a travel mode</a> using TravelMode sets the transportation mode used to calculate
    /// the routes. This also lets you specify additional route preferences in <code>CarModeOptions</code>
    /// if traveling by <code>Car</code>, or <code>TruckModeOptions</code> if traveling by
    /// <code>Truck</code>.
    /// </para>
    ///  <note> 
    /// <para>
    /// If you specify <code>walking</code> for the travel mode and your data provider is
    /// Esri, the start and destination must be within 40km.
    /// </para>
    ///  </note> </li> </ul>
    /// </summary>
    public partial class CalculateRouteRequest : AmazonLocationServiceRequest
    {
        private string _calculatorName;
        private CalculateRouteCarModeOptions _carModeOptions;
        private bool? _departNow;
        private List<double> _departurePosition = new List<double>();
        private DateTime? _departureTime;
        private List<double> _destinationPosition = new List<double>();
        private DistanceUnit _distanceUnit;
        private bool? _includeLegGeometry;
        private TravelMode _travelMode;
        private CalculateRouteTruckModeOptions _truckModeOptions;
        private List<List<double>> _waypointPositions = new List<List<double>>();

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
        /// Specifies route preferences when traveling by <code>Car</code>, such as avoiding routes
        /// that use ferries or tolls.
        /// </para>
        ///  
        /// <para>
        /// Requirements: <code>TravelMode</code> must be specified as <code>Car</code>.
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
        /// Default Value: <code>false</code> 
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>false</code> | <code>true</code> 
        /// </para>
        /// </summary>
        public bool DepartNow
        {
            get { return this._departNow.GetValueOrDefault(); }
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
        /// Geodetic System (WGS 84)</a> format: <code>[longitude, latitude]</code>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For example, <code>[-123.115, 49.285]</code> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// If you specify a departure that's not located on a road, Amazon Location <a href="https://docs.aws.amazon.com/location/latest/developerguide/snap-to-nearby-road.html">moves
        /// the position to the nearest road</a>. If Esri is the provider for your route calculator,
        /// specifying a route that is longer than 400 km returns a <code>400 RoutesValidationException</code>
        /// error.
        /// </para>
        ///  </note> 
        /// <para>
        /// Valid Values: <code>[-180 to 180,-90 to 90]</code> 
        /// </para>
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
            return this._departurePosition != null && this._departurePosition.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DepartureTime. 
        /// <para>
        /// Specifies the desired time of departure. Uses the given time to calculate the route.
        /// Otherwise, the best time of day to travel with the best traffic conditions is used
        /// to calculate the route.
        /// </para>
        ///  <note> 
        /// <para>
        /// Setting a departure time in the past returns a <code>400 ValidationException</code>
        /// error.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// In <a href="https://www.iso.org/iso-8601-date-and-time-format.html">ISO 8601</a> format:
        /// <code>YYYY-MM-DDThh:mm:ss.sssZ</code>. For example, <code>2020–07-2T12:15:20.000Z+01:00</code>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DateTime DepartureTime
        {
            get { return this._departureTime.GetValueOrDefault(); }
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
        /// Geodetic System (WGS 84)</a> format: <code>[longitude, latitude]</code>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  For example, <code>[-122.339, 47.615]</code> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// If you specify a destination that's not located on a road, Amazon Location <a href="https://docs.aws.amazon.com/location/latest/developerguide/snap-to-nearby-road.html">moves
        /// the position to the nearest road</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Valid Values: <code>[-180 to 180,-90 to 90]</code> 
        /// </para>
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
            return this._destinationPosition != null && this._destinationPosition.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DistanceUnit. 
        /// <para>
        /// Set the unit system to specify the distance.
        /// </para>
        ///  
        /// <para>
        /// Default Value: <code>Kilometers</code> 
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
        /// Default Value: <code>false</code> 
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>false</code> | <code>true</code> 
        /// </para>
        /// </summary>
        public bool IncludeLegGeometry
        {
            get { return this._includeLegGeometry.GetValueOrDefault(); }
            set { this._includeLegGeometry = value; }
        }

        // Check to see if IncludeLegGeometry property is set
        internal bool IsSetIncludeLegGeometry()
        {
            return this._includeLegGeometry.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TravelMode. 
        /// <para>
        /// Specifies the mode of transport when calculating a route. Used in estimating the speed
        /// of travel and road compatibility. You can choose <code>Car</code>, <code>Truck</code>,
        /// <code>Walking</code>, <code>Bicycle</code> or <code>Motorcycle</code> as options for
        /// the <code>TravelMode</code>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>Bicycle</code> and <code>Motorcycle</code> are only valid when using Grab as
        /// a data provider, and only within Southeast Asia.
        /// </para>
        ///  
        /// <para>
        ///  <code>Truck</code> is not available for Grab.
        /// </para>
        ///  
        /// <para>
        /// For more details on the using Grab for routing, including areas of coverage, see <a
        /// href="https://docs.aws.amazon.com/location/latest/developerguide/grab.html">GrabMaps</a>
        /// in the <i>Amazon Location Service Developer Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The <code>TravelMode</code> you specify also determines how you specify route preferences:
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If traveling by <code>Car</code> use the <code>CarModeOptions</code> parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If traveling by <code>Truck</code> use the <code>TruckModeOptions</code> parameter.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default Value: <code>Car</code> 
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
        /// Specifies route preferences when traveling by <code>Truck</code>, such as avoiding
        /// routes that use ferries or tolls, and truck specifications to consider when choosing
        /// an optimal road.
        /// </para>
        ///  
        /// <para>
        /// Requirements: <code>TravelMode</code> must be specified as <code>Truck</code>.
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
        /// For example, from the <code>DeparturePosition</code> <code>[-123.115, 49.285]</code>,
        /// the route follows the order that the waypoint positions are given <code>[[-122.757,
        /// 49.0021],[-122.349, 47.620]]</code> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// If you specify a waypoint position that's not located on a road, Amazon Location <a
        /// href="https://docs.aws.amazon.com/location/latest/developerguide/snap-to-nearby-road.html">moves
        /// the position to the nearest road</a>. 
        /// </para>
        ///  
        /// <para>
        /// Specifying more than 23 waypoints returns a <code>400 ValidationException</code> error.
        /// </para>
        ///  
        /// <para>
        /// If Esri is the provider for your route calculator, specifying a route that is longer
        /// than 400 km returns a <code>400 RoutesValidationException</code> error.
        /// </para>
        ///  </note> 
        /// <para>
        /// Valid Values: <code>[-180 to 180,-90 to 90]</code> 
        /// </para>
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
            return this._waypointPositions != null && this._waypointPositions.Count > 0; 
        }

    }
}