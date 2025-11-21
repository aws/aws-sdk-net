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
    /// Container for the parameters to the CalculateRouteMatrix operation.
    /// Use <c>CalculateRouteMatrix</c> to compute results for all pairs of Origins to Destinations.
    /// Each row corresponds to one entry in Origins. Each entry in the row corresponds to
    /// the route from that entry in Origins to an entry in Destinations positions.
    /// </summary>
    public partial class CalculateRouteMatrixRequest : AmazonGeoRoutesRequest
    {
        private RouteMatrixAllowOptions _allow;
        private RouteMatrixAvoidanceOptions _avoid;
        private bool? _departNow;
        private string _departureTime;
        private List<RouteMatrixDestination> _destinations = AWSConfigs.InitializeCollections ? new List<RouteMatrixDestination>() : null;
        private RouteMatrixExclusionOptions _exclude;
        private string _key;
        private RoutingObjective _optimizeRoutingFor;
        private List<RouteMatrixOrigin> _origins = AWSConfigs.InitializeCollections ? new List<RouteMatrixOrigin>() : null;
        private RouteMatrixBoundary _routingBoundary;
        private RouteMatrixTrafficOptions _traffic;
        private RouteMatrixTravelMode _travelMode;
        private RouteMatrixTravelModeOptions _travelModeOptions;

        /// <summary>
        /// Gets and sets the property Allow. 
        /// <para>
        /// Features that are allowed while calculating a route.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public RouteMatrixAllowOptions Allow
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
        /// Gets and sets the property Avoid. 
        /// <para>
        /// Features that are avoided while calculating a route. Avoidance is on a best-case basis.
        /// If an avoidance can't be satisfied for a particular case, it violates the avoidance
        /// and the returned response produces a notice for the violation.
        /// </para>
        /// </summary>
        public RouteMatrixAvoidanceOptions Avoid
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
        /// Gets and sets the property Destinations. 
        /// <para>
        /// List of destinations for the route.
        /// </para>
        ///  <note> 
        /// <para>
        /// Route calculations are billed for each origin and destination pair. If you use a large
        /// matrix of origins and destinations, your costs will increase accordingly. See <a href="https://docs.aws.amazon.com/location/latest/developerguide/routes-pricing.html`">
        /// Amazon Location's pricing page</a> for more information.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<RouteMatrixDestination> Destinations
        {
            get { return this._destinations; }
            set { this._destinations = value; }
        }

        // Check to see if Destinations property is set
        internal bool IsSetDestinations()
        {
            return this._destinations != null && (this._destinations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Exclude. 
        /// <para>
        /// Features to be strictly excluded while calculating the route.
        /// </para>
        /// </summary>
        public RouteMatrixExclusionOptions Exclude
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
        /// Gets and sets the property Origins. 
        /// <para>
        /// The position in longitude and latitude for the origin.
        /// </para>
        ///  <note> 
        /// <para>
        /// Route calculations are billed for each origin and destination pair. Using a large
        /// amount of Origins in a request can lead you to incur unexpected charges. See <a href="https://docs.aws.amazon.com/location/latest/developerguide/routes-pricing.html`">
        /// Amazon Location's pricing page</a> for more information.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<RouteMatrixOrigin> Origins
        {
            get { return this._origins; }
            set { this._origins = value; }
        }

        // Check to see if Origins property is set
        internal bool IsSetOrigins()
        {
            return this._origins != null && (this._origins.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RoutingBoundary. 
        /// <para>
        /// Boundary within which the matrix is to be calculated. All data, origins and destinations
        /// outside the boundary are considered invalid.
        /// </para>
        ///  <note> 
        /// <para>
        /// When request routing boundary was set as AutoCircle, the response routing boundary
        /// will return Circle derived from the AutoCircle settings.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public RouteMatrixBoundary RoutingBoundary
        {
            get { return this._routingBoundary; }
            set { this._routingBoundary = value; }
        }

        // Check to see if RoutingBoundary property is set
        internal bool IsSetRoutingBoundary()
        {
            return this._routingBoundary != null;
        }

        /// <summary>
        /// Gets and sets the property Traffic. 
        /// <para>
        /// Traffic related options.
        /// </para>
        /// </summary>
        public RouteMatrixTrafficOptions Traffic
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
        public RouteMatrixTravelMode TravelMode
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
        public RouteMatrixTravelModeOptions TravelModeOptions
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