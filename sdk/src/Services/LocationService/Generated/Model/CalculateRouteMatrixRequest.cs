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
    /// Container for the parameters to the CalculateRouteMatrix operation.
    /// <a href="https://docs.aws.amazon.com/location/latest/developerguide/calculate-route-matrix.html">
    /// Calculates a route matrix</a> given the following required parameters: <code>DeparturePositions</code>
    /// and <code>DestinationPositions</code>. <code>CalculateRouteMatrix</code> calculates
    /// routes and returns the travel time and travel distance from each departure position
    /// to each destination position in the request. For example, given departure positions
    /// A and B, and destination positions X and Y, <code>CalculateRouteMatrix</code> will
    /// return time and distance for routes from A to X, A to Y, B to X, and B to Y (in that
    /// order). The number of results returned (and routes calculated) will be the number
    /// of <code>DeparturePositions</code> times the number of <code>DestinationPositions</code>.
    /// 
    ///  <note> 
    /// <para>
    /// Your account is charged for each route calculated, not the number of requests.
    /// </para>
    ///  </note> 
    /// <para>
    /// Requires that you first <a href="https://docs.aws.amazon.com/location-routes/latest/APIReference/API_CreateRouteCalculator.html">create
    /// a route calculator resource</a>.
    /// </para>
    ///  
    /// <para>
    /// By default, a request that doesn't specify a departure time uses the best time of
    /// day to travel with the best traffic conditions when calculating routes.
    /// </para>
    ///  
    /// <para>
    /// Additional options include:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/location/latest/developerguide/departure-time.html">
    /// Specifying a departure time</a> using either <code>DepartureTime</code> or <code>DepartNow</code>.
    /// This calculates routes based on predictive traffic data at the given time. 
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
    ///  </li> </ul>
    /// </summary>
    public partial class CalculateRouteMatrixRequest : AmazonLocationServiceRequest
    {
        private string _calculatorName;
        private CalculateRouteCarModeOptions _carModeOptions;
        private bool? _departNow;
        private List<List<double>> _departurePositions = new List<List<double>>();
        private DateTime? _departureTime;
        private List<List<double>> _destinationPositions = new List<List<double>>();
        private DistanceUnit _distanceUnit;
        private TravelMode _travelMode;
        private CalculateRouteTruckModeOptions _truckModeOptions;

        /// <summary>
        /// Gets and sets the property CalculatorName. 
        /// <para>
        /// The name of the route calculator resource that you want to use to calculate the route
        /// matrix. 
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
        /// the route matrix. You can't set both <code>DepartureTime</code> and <code>DepartNow</code>.
        /// If neither is set, the best time of day to travel with the best traffic conditions
        /// is used to calculate the route matrix.
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
        /// Gets and sets the property DeparturePositions. 
        /// <para>
        /// The list of departure (origin) positions for the route matrix. An array of points,
        /// each of which is itself a 2-value array defined in <a href="https://earth-info.nga.mil/GandG/wgs84/index.html">WGS
        /// 84</a> format: <code>[longitude, latitude]</code>. For example, <code>[-123.115, 49.285]</code>.
        /// </para>
        ///  <important> 
        /// <para>
        /// Depending on the data provider selected in the route calculator resource there may
        /// be additional restrictions on the inputs you can choose. See <a href="https://docs.aws.amazon.com/location/latest/developerguide/calculate-route-matrix.html#matrix-routing-position-limits">
        /// Position restrictions</a> in the <i>Amazon Location Service Developer Guide</i>.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// For route calculators that use Esri as the data provider, if you specify a departure
        /// that's not located on a road, Amazon Location <a href="https://docs.aws.amazon.com/location/latest/developerguide/snap-to-nearby-road.html">
        /// moves the position to the nearest road</a>. The snapped value is available in the
        /// result in <code>SnappedDeparturePositions</code>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Valid Values: <code>[-180 to 180,-90 to 90]</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=350)]
        public List<List<double>> DeparturePositions
        {
            get { return this._departurePositions; }
            set { this._departurePositions = value; }
        }

        // Check to see if DeparturePositions property is set
        internal bool IsSetDeparturePositions()
        {
            return this._departurePositions != null && this._departurePositions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DepartureTime. 
        /// <para>
        /// Specifies the desired time of departure. Uses the given time to calculate the route
        /// matrix. You can't set both <code>DepartureTime</code> and <code>DepartNow</code>.
        /// If neither is set, the best time of day to travel with the best traffic conditions
        /// is used to calculate the route matrix.
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
        /// Gets and sets the property DestinationPositions. 
        /// <para>
        /// The list of destination positions for the route matrix. An array of points, each of
        /// which is itself a 2-value array defined in <a href="https://earth-info.nga.mil/GandG/wgs84/index.html">WGS
        /// 84</a> format: <code>[longitude, latitude]</code>. For example, <code>[-122.339, 47.615]</code>
        /// 
        /// </para>
        ///  <important> 
        /// <para>
        /// Depending on the data provider selected in the route calculator resource there may
        /// be additional restrictions on the inputs you can choose. See <a href="https://docs.aws.amazon.com/location/latest/developerguide/calculate-route-matrix.html#matrix-routing-position-limits">
        /// Position restrictions</a> in the <i>Amazon Location Service Developer Guide</i>.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// For route calculators that use Esri as the data provider, if you specify a destination
        /// that's not located on a road, Amazon Location <a href="https://docs.aws.amazon.com/location/latest/developerguide/snap-to-nearby-road.html">
        /// moves the position to the nearest road</a>. The snapped value is available in the
        /// result in <code>SnappedDestinationPositions</code>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Valid Values: <code>[-180 to 180,-90 to 90]</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=350)]
        public List<List<double>> DestinationPositions
        {
            get { return this._destinationPositions; }
            set { this._destinationPositions = value; }
        }

        // Check to see if DestinationPositions property is set
        internal bool IsSetDestinationPositions()
        {
            return this._destinationPositions != null && this._destinationPositions.Count > 0; 
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
        /// Gets and sets the property TravelMode. 
        /// <para>
        /// Specifies the mode of transport when calculating a route. Used in estimating the speed
        /// of travel and road compatibility.
        /// </para>
        ///  
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
        ///  </li> </ul> <note> 
        /// <para>
        ///  <code>Bicycle</code> or <code>Motorcycle</code> are only valid when using <code>Grab</code>
        /// as a data provider, and only within Southeast Asia.
        /// </para>
        ///  
        /// <para>
        ///  <code>Truck</code> is not available for Grab.
        /// </para>
        ///  
        /// <para>
        /// For more information about using Grab as a data provider, see <a href="https://docs.aws.amazon.com/location/latest/developerguide/grab.html">GrabMaps</a>
        /// in the <i>Amazon Location Service Developer Guide</i>.
        /// </para>
        ///  </note> 
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

    }
}