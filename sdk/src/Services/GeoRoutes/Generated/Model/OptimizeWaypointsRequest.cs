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
    /// Container for the parameters to the OptimizeWaypoints operation.
    /// <c>OptimizeWaypoints</c> calculates the optimal order to travel between a set of
    /// waypoints to minimize either the travel time or the distance travelled during the
    /// journey, based on road network restrictions and the traffic pattern data.
    /// </summary>
    public partial class OptimizeWaypointsRequest : AmazonGeoRoutesRequest
    {
        private WaypointOptimizationAvoidanceOptions _avoid;
        private WaypointOptimizationClusteringOptions _clustering;
        private string _departureTime;
        private List<double> _destination = AWSConfigs.InitializeCollections ? new List<double>() : null;
        private WaypointOptimizationDestinationOptions _destinationOptions;
        private WaypointOptimizationDriverOptions _driver;
        private WaypointOptimizationExclusionOptions _exclude;
        private string _key;
        private WaypointOptimizationSequencingObjective _optimizeSequencingFor;
        private List<double> _origin = AWSConfigs.InitializeCollections ? new List<double>() : null;
        private WaypointOptimizationOriginOptions _originOptions;
        private WaypointOptimizationTrafficOptions _traffic;
        private WaypointOptimizationTravelMode _travelMode;
        private WaypointOptimizationTravelModeOptions _travelModeOptions;
        private List<WaypointOptimizationWaypoint> _waypoints = AWSConfigs.InitializeCollections ? new List<WaypointOptimizationWaypoint>() : null;

        /// <summary>
        /// Gets and sets the property Avoid. 
        /// <para>
        /// Features that are avoided. Avoidance is on a best-case basis. If an avoidance can't
        /// be satisfied for a particular case, this setting is ignored.
        /// </para>
        /// </summary>
        public WaypointOptimizationAvoidanceOptions Avoid
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
        /// Gets and sets the property Clustering. 
        /// <para>
        /// Clustering allows you to specify how nearby waypoints can be clustered to improve
        /// the optimized sequence.
        /// </para>
        /// </summary>
        public WaypointOptimizationClusteringOptions Clustering
        {
            get { return this._clustering; }
            set { this._clustering = value; }
        }

        // Check to see if Clustering property is set
        internal bool IsSetClustering()
        {
            return this._clustering != null;
        }

        /// <summary>
        /// Gets and sets the property DepartureTime. 
        /// <para>
        /// Departure time from the waypoint.
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
        /// The final position for the route in the World Geodetic System (WGS 84) format: <c>[longitude,
        /// latitude]</c>.
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
        /// Destination related options.
        /// </para>
        /// </summary>
        public WaypointOptimizationDestinationOptions DestinationOptions
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
        public WaypointOptimizationDriverOptions Driver
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
        public WaypointOptimizationExclusionOptions Exclude
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
        /// Gets and sets the property OptimizeSequencingFor. 
        /// <para>
        /// Specifies the optimization criteria for the calculated sequence.
        /// </para>
        ///  
        /// <para>
        /// Default Value: <c>FastestRoute</c>.
        /// </para>
        /// </summary>
        public WaypointOptimizationSequencingObjective OptimizeSequencingFor
        {
            get { return this._optimizeSequencingFor; }
            set { this._optimizeSequencingFor = value; }
        }

        // Check to see if OptimizeSequencingFor property is set
        internal bool IsSetOptimizeSequencingFor()
        {
            return this._optimizeSequencingFor != null;
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
        public WaypointOptimizationOriginOptions OriginOptions
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
        /// Gets and sets the property Traffic. 
        /// <para>
        /// Traffic-related options.
        /// </para>
        /// </summary>
        public WaypointOptimizationTrafficOptions Traffic
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
        public WaypointOptimizationTravelMode TravelMode
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
        public WaypointOptimizationTravelModeOptions TravelModeOptions
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
        /// Gets and sets the property Waypoints. 
        /// <para>
        /// List of waypoints between the <c>Origin</c> and <c>Destination</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<WaypointOptimizationWaypoint> Waypoints
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