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
    /// Container for the parameters to the CalculateRouteMatrix operation. Use <c>CalculateRouteMatrix</c>
    /// to compute results for all pairs of Origins to Destinations. Each row corresponds
    /// to one entry in Origins. Each entry in the row corresponds to the route from that
    /// entry in Origins to an entry in Destinations positions. <para> For more information,
    /// see <a href="https://docs.aws.amazon.com/location/latest/developerguide/calculate-route-matrix.html">Calculate
    /// route matrix</a> in the <i>Amazon Location Service Developer Guide</i>. </para>
    /// </summary>
    public partial class CalculateRouteMatrixRequest : AmazonGeoRoutesRequest
    {
        /// <summary>
        /// Gets and sets the property Allow. 
        /// <para>
        /// Features that are allowed while calculating a route.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public RouteMatrixAllowOptions Allow { get; set; }

        /// <summary>
        /// Checks to see if the Allow property is set.
        /// </summary>
        internal bool IsSetAllow() => this.Allow != null;

        /// <summary>
        /// Gets and sets the property Avoid. 
        /// <para>
        ///  Features that are avoided while calculating a route. Avoidance is on a best-case
        /// basis. If an avoidance can't be satisfied for a particular case, it violates the avoidance
        /// and the returned response produces a notice for the violation. For <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers, <c>ap-southeast-1</c> and <c>ap-southeast-5</c> regions support only <c>TollRoads</c>,
        /// <c>Ferries</c>, and <c>ControlledAccessHighways</c>. 
        /// </para>
        /// </summary>
        public RouteMatrixAvoidanceOptions Avoid { get; set; }

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
        /// Gets and sets the property Destinations. 
        /// <para>
        /// List of destinations for the route in World Geodetic System (WGS 84) format: [longitude,
        /// latitude].
        /// </para>
        ///  <note> 
        /// <para>
        /// Route calculations are billed for each origin and destination pair. If you use a large
        /// matrix of origins and destinations, your costs will increase accordingly. For more
        /// information, see <a href="https://docs.aws.amazon.com/location/latest/developerguide/routes-pricing.html">Routes
        /// pricing</a> in the <i>Amazon Location Service Developer Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The maximum number of destinations depends on the routing boundary configuration:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// With <c>RoutingBoundary.Geometry</c> set: maximum 500 destinations
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// With <c>RoutingBoundary.Unbounded</c> set to <c>true</c>: maximum 100 destinations
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers in <c>ap-southeast-1</c> and <c>ap-southeast-5</c>: maximum 350 destinations
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The total matrix size (origins × destinations) must not exceed:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// With <c>RoutingBoundary.Geometry</c>: 160,000
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// With <c>RoutingBoundary.Unbounded</c>: 100
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers in <c>ap-southeast-1</c> and <c>ap-southeast-5</c>: 122,500
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public List<RouteMatrixDestination> Destinations { get; set; } = AWSConfigs.InitializeCollections ? new List<RouteMatrixDestination>() : null;

        /// <summary>
        /// Checks to see if the Destinations property is set.
        /// </summary>
        internal bool IsSetDestinations() => this.Destinations != null && (this.Destinations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Exclude. 
        /// <para>
        ///  Features to be strictly excluded while calculating the route. Not supported in <c>ap-southeast-1</c>
        /// and <c>ap-southeast-5</c> regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        /// </summary>
        public RouteMatrixExclusionOptions Exclude { get; set; }

        /// <summary>
        /// Checks to see if the Exclude property is set.
        /// </summary>
        internal bool IsSetExclude() => this.Exclude != null;

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
        /// Gets and sets the property OptimizeRoutingFor. 
        /// <para>
        /// Controls the trade-off between finding the shortest travel time (<c>FastestRoute</c>)
        /// and the shortest distance (<c>ShortestRoute</c>) when calculating reachable areas.
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
        /// Gets and sets the property Origins. 
        /// <para>
        /// List of origins for the route in World Geodetic System (WGS 84) format: [longitude,
        /// latitude].
        /// </para>
        ///  <note> 
        /// <para>
        /// Route calculations are billed for each origin and destination pair. Using a large
        /// amount of Origins in a request can lead you to incur unexpected charges. For more
        /// information, see <a href="https://docs.aws.amazon.com/location/latest/developerguide/routes-pricing.html">Routes
        /// pricing</a> in the <i>Amazon Location Service Developer Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The maximum number of origins depends on the routing boundary configuration:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// With <c>RoutingBoundary.Geometry</c> set: maximum 500 origins
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// With <c>RoutingBoundary.Unbounded</c> set to <c>true</c>: maximum 15 origins
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers in <c>ap-southeast-1</c> and <c>ap-southeast-5</c>: maximum 350 origins
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The total matrix size (origins × destinations) must not exceed:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// With <c>RoutingBoundary.Geometry</c>: 160,000
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// With <c>RoutingBoundary.Unbounded</c>: 100
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers in <c>ap-southeast-1</c> and <c>ap-southeast-5</c>: 122,500
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public List<RouteMatrixOrigin> Origins { get; set; } = AWSConfigs.InitializeCollections ? new List<RouteMatrixOrigin>() : null;

        /// <summary>
        /// Checks to see if the Origins property is set.
        /// </summary>
        internal bool IsSetOrigins() => this.Origins != null && (this.Origins.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RoutingBoundary. 
        /// <para>
        ///  Boundary within which the matrix is to be calculated. All data, origins and destinations
        /// outside the boundary are considered invalid. For <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers, <c>ap-southeast-1</c> and <c>ap-southeast-5</c> regions support only <c>Unbounded</c>
        /// set to <c>true</c>. 
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>Unbounded set to true</c> 
        /// </para>
        ///  <note> 
        /// <para>
        /// When <c>AutoCircle</c> is set in the request, the response routing boundary will return
        /// <c>Circle</c> derived from the <c>AutoCircle</c> settings.
        /// </para>
        ///  </note>
        /// </summary>
        public RouteMatrixBoundary RoutingBoundary { get; set; }

        /// <summary>
        /// Checks to see if the RoutingBoundary property is set.
        /// </summary>
        internal bool IsSetRoutingBoundary() => this.RoutingBoundary != null;

        /// <summary>
        /// Gets and sets the property Traffic. 
        /// <para>
        ///  Traffic related options. Not supported in <c>ap-southeast-1</c> and <c>ap-southeast-5</c>
        /// regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        /// </summary>
        public RouteMatrixTrafficOptions Traffic { get; set; }

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
        /// <c>Pedestrian</c>, and <c>Scooter</c>. 
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>Car</c> 
        /// </para>
        /// </summary>
        public RouteMatrixTravelMode TravelMode { get; set; }

        /// <summary>
        /// Checks to see if the TravelMode property is set.
        /// </summary>
        internal bool IsSetTravelMode() => this.TravelMode != null;

        /// <summary>
        /// Gets and sets the property TravelModeOptions. 
        /// <para>
        ///  Travel mode related options for the provided travel mode. Not supported in <c>ap-southeast-1</c>
        /// and <c>ap-southeast-5</c> regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        /// </summary>
        public RouteMatrixTravelModeOptions TravelModeOptions { get; set; }

        /// <summary>
        /// Checks to see if the TravelModeOptions property is set.
        /// </summary>
        internal bool IsSetTravelModeOptions() => this.TravelModeOptions != null;
    }
}
