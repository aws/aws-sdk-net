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
    /// Container for the parameters to the CalculateIsolines operation.
    /// Calculates areas that can be reached within specified time or distance thresholds
    /// from a given point. For example, you can use this operation to determine the area
    /// within a 30-minute drive of a store location, find neighborhoods within walking distance
    /// of a school, or identify delivery zones based on drive time.
    /// 
    ///  
    /// <para>
    /// Isolines (also known as isochrones for time-based calculations) are useful for various
    /// applications including:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Service area visualization - Show customers the area you can serve within promised
    /// delivery times
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Site selection - Analyze potential business locations based on population within travel
    /// distance
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Site selection - Determine areas that can be reached within specified response times
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// Route preferences such as avoiding toll roads or ferries are treated as preferences
    /// rather than absolute restrictions. If a viable route cannot be calculated while honoring
    /// all preferences, some may be ignored.
    /// </para>
    ///  </note> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/location/latest/developerguide/calculate-isolines.html">Calculate
    /// isolines</a> in the <i>Amazon Location Service Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class CalculateIsolinesRequest : AmazonGeoRoutesRequest
    {
        private IsolineAllowOptions _allow;
        private string _arrivalTime;
        private IsolineAvoidanceOptions _avoid;
        private bool? _departNow;
        private string _departureTime;
        private List<double> _destination = AWSConfigs.InitializeCollections ? new List<double>() : null;
        private IsolineDestinationOptions _destinationOptions;
        private GeometryFormat _isolineGeometryFormat;
        private IsolineGranularityOptions _isolineGranularity;
        private string _key;
        private IsolineOptimizationObjective _optimizeIsolineFor;
        private RoutingObjective _optimizeRoutingFor;
        private List<double> _origin = AWSConfigs.InitializeCollections ? new List<double>() : null;
        private IsolineOriginOptions _originOptions;
        private IsolineThresholds _thresholds;
        private IsolineTrafficOptions _traffic;
        private IsolineTravelMode _travelMode;
        private IsolineTravelModeOptions _travelModeOptions;

        /// <summary>
        /// Gets and sets the property Allow. 
        /// <para>
        /// Enables special road types or features that should be considered for routing even
        /// if they might be restricted by default for the selected travel mode. These include
        /// high-occupancy vehicle and toll lanes.
        /// </para>
        /// </summary>
        public IsolineAllowOptions Allow
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
        /// Determine areas from which <c>Destination</c> can be reached by this time, taking
        /// into account predicted traffic conditions and working backward to account for congestion
        /// patterns. This attribute cannot be used together with <c>DepartureTime</c> or <c>DepartNow</c>.
        /// Specified as an ISO-8601 timestamp with timezone offset.
        /// </para>
        ///  
        /// <para>
        /// Time format: <c>YYYY-MM-DDThh:mm:ss.sssZ | YYYY-MM-DDThh:mm:ss.sss+hh:mm</c> 
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
        /// Specifies road types, features, or areas to avoid (if possible) when calculating reachable
        /// areas. These are treated as preferences rather than strict constraints—if a route
        /// cannot be calculated without using an avoided feature, that avoidance preference may
        /// be ignored.
        /// </para>
        /// </summary>
        public IsolineAvoidanceOptions Avoid
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
        /// When true, uses the current time as the departure time and takes current traffic conditions
        /// into account. This attribute cannot be used together with <c>DepartureTime</c> or
        /// <c>ArrivalTime</c>.
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
        /// Determine areas that can be reached when departing at this time, taking into account
        /// predicted traffic conditions. This attribute cannot be used together with <c>ArrivalTime</c>
        /// or <c>DepartNow</c>. Specified as an ISO-8601 timestamp with timezone offset.
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
        /// An optional destination point, specified as <c>[longitude, latitude]</c> coordinates.
        /// When provided, the service calculates areas from which this destination can be reached
        /// within the specified thresholds. This reverses the usual isoline calculation to show
        /// areas that could reach your location, rather than areas you could reach from your
        /// location. Either <c>Origin</c> or <c>Destination</c> must be provided.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=2, Max=2)]
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
        /// Options that control how the destination point is matched to the road network and
        /// how routes can approach it. These options help improve travel time accuracy by accounting
        /// for real-world access to the destination.
        /// </para>
        /// </summary>
        public IsolineDestinationOptions DestinationOptions
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
        /// Gets and sets the property IsolineGeometryFormat. 
        /// <para>
        /// The format of the returned IsolineGeometry. 
        /// </para>
        ///  
        /// <para>
        /// Default value:<c>FlexiblePolyline</c> 
        /// </para>
        /// </summary>
        public GeometryFormat IsolineGeometryFormat
        {
            get { return this._isolineGeometryFormat; }
            set { this._isolineGeometryFormat = value; }
        }

        // Check to see if IsolineGeometryFormat property is set
        internal bool IsSetIsolineGeometryFormat()
        {
            return this._isolineGeometryFormat != null;
        }

        /// <summary>
        /// Gets and sets the property IsolineGranularity. 
        /// <para>
        /// Controls the detail level of the generated isolines. Higher granularity produces smoother
        /// shapes but requires more processing time and results in larger responses.
        /// </para>
        /// </summary>
        public IsolineGranularityOptions IsolineGranularity
        {
            get { return this._isolineGranularity; }
            set { this._isolineGranularity = value; }
        }

        // Check to see if IsolineGranularity property is set
        internal bool IsSetIsolineGranularity()
        {
            return this._isolineGranularity != null;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// An Amazon Location Service API Key with access to this action. If omitted, the request
        /// must be signed using Signature Version 4.
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
        /// Gets and sets the property OptimizeIsolineFor. 
        /// <para>
        /// Controls the trade-off between calculation speed and isoline precision. Choose <c>
        /// FastCalculation</c> for quicker results with less detail, <c>AccurateCalculation</c>
        /// for more precise results, or <c>BalancedCalculation</c> for a middle ground.
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>BalancedCalculation</c> 
        /// </para>
        /// </summary>
        public IsolineOptimizationObjective OptimizeIsolineFor
        {
            get { return this._optimizeIsolineFor; }
            set { this._optimizeIsolineFor = value; }
        }

        // Check to see if OptimizeIsolineFor property is set
        internal bool IsSetOptimizeIsolineFor()
        {
            return this._optimizeIsolineFor != null;
        }

        /// <summary>
        /// Gets and sets the property OptimizeRoutingFor. 
        /// <para>
        /// Determines whether routes prioritize shortest travel time (<c>FastestRoute</c>) or
        /// shortest physical distance (<c>ShortestRoute</c>) when calculating reachable areas.
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>FastestRoute</c> 
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
        /// The starting point for isoline calculations, specified as <c>[longitude, latitude]</c>
        /// coordinates. For example, this could be a store location, service center, or any point
        /// from which you want to calculate reachable areas. Either <c>Origin</c> or <c>Destination</c>
        /// must be provided.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=2, Max=2)]
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
        /// Options that control how the origin point is matched to the road network and how routes
        /// can depart from it. These options help improve travel time accuracy by accounting
        /// for real-world access from the origin.
        /// </para>
        /// </summary>
        public IsolineOriginOptions OriginOptions
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
        /// Gets and sets the property Thresholds. 
        /// <para>
        /// The distance or time thresholds used to determine reachable areas. You can specify
        /// up to five thresholds (which all must be the same type) to calculate multiple isolines
        /// in a single request. For example, to determine the areas that are reachable within
        /// 10 and 20 minutes of the origin, specify time thresholds of 600 and 1200 seconds.
        /// </para>
        ///  
        /// <para>
        /// You incur a calculation charge for each threshold. Using a large number of thresholds
        /// in a request can lead to unexpected charges. For more information, see <a href="https://docs.aws.amazon.com/location/latest/developerguide/routes-pricing.html">Routes
        /// pricing</a> in the <i>Amazon Location Service Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IsolineThresholds Thresholds
        {
            get { return this._thresholds; }
            set { this._thresholds = value; }
        }

        // Check to see if Thresholds property is set
        internal bool IsSetThresholds()
        {
            return this._thresholds != null;
        }

        /// <summary>
        /// Gets and sets the property Traffic. 
        /// <para>
        /// Configures how real-time and historical traffic data affects isoline calculations.
        /// Traffic patterns can significantly impact reachable areas, especially during peak
        /// hours.
        /// </para>
        /// </summary>
        public IsolineTrafficOptions Traffic
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
        /// The mode of transportation to use for calculations. This affects which road types
        /// or features can be used, estimated speed, and the traffic levels that are applied.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Car</c>—Standard passenger vehicle routing using roads accessible to cars
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Pedestrian</c>—Walking routes using pedestrian paths, sidewalks, and crossings
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Scooter</c>—Light two-wheeled vehicle routing using roads and paths accessible
        /// to scooters
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Truck</c>—Commercial truck routing considering vehicle dimensions, weight restrictions,
        /// and hazardous material regulations
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The mode <c>Scooter</c> also applies to motorcycles; set this to <c>Scooter</c> when
        /// calculating isolines for motorcycles.
        /// </para>
        ///  </note> 
        /// <para>
        /// Default value: <c>Car</c> 
        /// </para>
        /// </summary>
        public IsolineTravelMode TravelMode
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
        /// Additional attributes that refine how reachable areas are calculated based on specific
        /// vehicle characteristics. These options help produce more accurate results by accounting
        /// for real-world constraints and capabilities.
        /// </para>
        ///  
        /// <para>
        /// For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For trucks (<c>Truck</c>), specify dimensions, weight limits, and hazardous cargo
        /// restrictions to ensure isolines only include roads that can physically and legally
        /// accommodate the vehicle
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cars (<c>Car</c>), set maximum speed capabilities or indicate high-occupancy vehicle
        /// eligibility to better estimate reachable areas
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For scooters (<c>Scooter</c>), specify engine type and speed limitations to more accurately
        /// model their travel capabilities
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Without these options, calculations use default assumptions that may not match your
        /// specific use case.
        /// </para>
        /// </summary>
        public IsolineTravelModeOptions TravelModeOptions
        {
            get { return this._travelModeOptions; }
            set { this._travelModeOptions = value; }
        }

        // Check to see if TravelModeOptions property is set
        internal bool IsSetTravelModeOptions()
        {
            return this._travelModeOptions != null;
        }

    }
}