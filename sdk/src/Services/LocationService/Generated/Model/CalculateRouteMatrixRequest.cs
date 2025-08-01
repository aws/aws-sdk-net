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
    /// Container for the parameters to the CalculateRouteMatrix operation.
    /// <a href="https://docs.aws.amazon.com/location/previous/developerguide/calculate-route-matrix.html">
    /// Calculates a route matrix</a> given the following required parameters: <c>DeparturePositions</c>
    /// and <c>DestinationPositions</c>. <c>CalculateRouteMatrix</c> calculates routes and
    /// returns the travel time and travel distance from each departure position to each destination
    /// position in the request. For example, given departure positions A and B, and destination
    /// positions X and Y, <c>CalculateRouteMatrix</c> will return time and distance for routes
    /// from A to X, A to Y, B to X, and B to Y (in that order). The number of results returned
    /// (and routes calculated) will be the number of <c>DeparturePositions</c> times the
    /// number of <c>DestinationPositions</c>.
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
    ///  <a href="https://docs.aws.amazon.com/location/previous/developerguide/departure-time.html">
    /// Specifying a departure time</a> using either <c>DepartureTime</c> or <c>DepartNow</c>.
    /// This calculates routes based on predictive traffic data at the given time. 
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
    ///  </li> </ul>
    /// </summary>
    public partial class CalculateRouteMatrixRequest : AmazonLocationServiceRequest
    {
        private string _calculatorName;
        private CalculateRouteCarModeOptions _carModeOptions;
        private bool? _departNow;
        private List<List<double>> _departurePositions = AWSConfigs.InitializeCollections ? new List<List<double>>() : null;
        private DateTime? _departureTime;
        private List<List<double>> _destinationPositions = AWSConfigs.InitializeCollections ? new List<List<double>>() : null;
        private DistanceUnit _distanceUnit;
        private string _key;
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
        /// the route matrix. You can't set both <c>DepartureTime</c> and <c>DepartNow</c>. If
        /// neither is set, the best time of day to travel with the best traffic conditions is
        /// used to calculate the route matrix.
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
        /// Gets and sets the property DeparturePositions. 
        /// <para>
        /// The list of departure (origin) positions for the route matrix. An array of points,
        /// each of which is itself a 2-value array defined in <a href="https://earth-info.nga.mil/GandG/wgs84/index.html">WGS
        /// 84</a> format: <c>[longitude, latitude]</c>. For example, <c>[-123.115, 49.285]</c>.
        /// </para>
        ///  <important> 
        /// <para>
        /// Depending on the data provider selected in the route calculator resource there may
        /// be additional restrictions on the inputs you can choose. See <a href="https://docs.aws.amazon.com/location/previous/developerguide/calculate-route-matrix.html#matrix-routing-position-limits">
        /// Position restrictions</a> in the <i>Amazon Location Service Developer Guide</i>.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// For route calculators that use Esri as the data provider, if you specify a departure
        /// that's not located on a road, Amazon Location <a href="https://docs.aws.amazon.com/location/previous/developerguide/snap-to-nearby-road.html">
        /// moves the position to the nearest road</a>. The snapped value is available in the
        /// result in <c>SnappedDeparturePositions</c>.
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
        [AWSProperty(Required=true, Min=1, Max=350)]
        public List<List<double>> DeparturePositions
        {
            get { return this._departurePositions; }
            set { this._departurePositions = value; }
        }

        // Check to see if DeparturePositions property is set
        internal bool IsSetDeparturePositions()
        {
            return this._departurePositions != null && (this._departurePositions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DepartureTime. 
        /// <para>
        /// Specifies the desired time of departure. Uses the given time to calculate the route
        /// matrix. You can't set both <c>DepartureTime</c> and <c>DepartNow</c>. If neither is
        /// set, the best time of day to travel with the best traffic conditions is used to calculate
        /// the route matrix.
        /// </para>
        ///  <note> 
        /// <para>
        /// Setting a departure time in the past returns a <c>400 ValidationException</c> error.
        /// </para>
        ///  </note> <ul> <li> 
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
        /// Gets and sets the property DestinationPositions. 
        /// <para>
        /// The list of destination positions for the route matrix. An array of points, each of
        /// which is itself a 2-value array defined in <a href="https://earth-info.nga.mil/GandG/wgs84/index.html">WGS
        /// 84</a> format: <c>[longitude, latitude]</c>. For example, <c>[-122.339, 47.615]</c>
        /// 
        /// </para>
        ///  <important> 
        /// <para>
        /// Depending on the data provider selected in the route calculator resource there may
        /// be additional restrictions on the inputs you can choose. See <a href="https://docs.aws.amazon.com/location/previous/developerguide/calculate-route-matrix.html#matrix-routing-position-limits">
        /// Position restrictions</a> in the <i>Amazon Location Service Developer Guide</i>.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// For route calculators that use Esri as the data provider, if you specify a destination
        /// that's not located on a road, Amazon Location <a href="https://docs.aws.amazon.com/location/previous/developerguide/snap-to-nearby-road.html">
        /// moves the position to the nearest road</a>. The snapped value is available in the
        /// result in <c>SnappedDestinationPositions</c>.
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
        [AWSProperty(Required=true, Min=1, Max=350)]
        public List<List<double>> DestinationPositions
        {
            get { return this._destinationPositions; }
            set { this._destinationPositions = value; }
        }

        // Check to see if DestinationPositions property is set
        internal bool IsSetDestinationPositions()
        {
            return this._destinationPositions != null && (this._destinationPositions.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property TravelMode. 
        /// <para>
        /// Specifies the mode of transport when calculating a route. Used in estimating the speed
        /// of travel and road compatibility.
        /// </para>
        ///  
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
        ///  </li> </ul> <note> 
        /// <para>
        ///  <c>Bicycle</c> or <c>Motorcycle</c> are only valid when using <c>Grab</c> as a data
        /// provider, and only within Southeast Asia.
        /// </para>
        ///  
        /// <para>
        ///  <c>Truck</c> is not available for Grab.
        /// </para>
        ///  
        /// <para>
        /// For more information about using Grab as a data provider, see <a href="https://docs.aws.amazon.com/location/previous/developerguide/grab.html">GrabMaps</a>
        /// in the <i>Amazon Location Service Developer Guide</i>.
        /// </para>
        ///  </note> 
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

    }
}