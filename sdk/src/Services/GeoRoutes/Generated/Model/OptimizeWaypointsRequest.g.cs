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
    /// Container for the parameters to the OptimizeWaypoints operation. <c>OptimizeWaypoints</c>
    /// calculates the optimal order to travel between a set of waypoints to minimize either
    /// the travel time or the distance travelled during the journey, based on road network
    /// restrictions and the traffic pattern data. <para> For more information, see <a href="https://docs.aws.amazon.com/location/latest/developerguide/actions-optimize-waypoints.html">Optimize
    /// waypoints</a> in the <i>Amazon Location Service Developer Guide</i>. </para>
    /// </summary>
    public partial class OptimizeWaypointsRequest : AmazonGeoRoutesRequest
    {
        /// <summary>
        /// Gets and sets the property Avoid. 
        /// <para>
        /// Features that are avoided. Avoidance is on a best-case basis. If an avoidance can't
        /// be satisfied for a particular case, this setting is ignored.
        /// </para>
        /// </summary>
        public WaypointOptimizationAvoidanceOptions Avoid { get; set; }

        /// <summary>
        /// Checks to see if the Avoid property is set.
        /// </summary>
        internal bool IsSetAvoid() => this.Avoid != null;

        /// <summary>
        /// Gets and sets the property Clustering. 
        /// <para>
        /// Clustering allows you to specify how nearby waypoints can be clustered to improve
        /// the optimized sequence.
        /// </para>
        /// </summary>
        public WaypointOptimizationClusteringOptions Clustering { get; set; }

        /// <summary>
        /// Checks to see if the Clustering property is set.
        /// </summary>
        internal bool IsSetClustering() => this.Clustering != null;

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
        [AWSProperty(Sensitive = true)]
        public string DepartureTime { get; set; }

        /// <summary>
        /// Checks to see if the DepartureTime property is set.
        /// </summary>
        internal bool IsSetDepartureTime() => this.DepartureTime != null;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The final position for the route in the World Geodetic System (WGS 84) format: <c>[longitude,
        /// latitude]</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 2, Max = 2)]
        public List<double> Destination { get; set; } = AWSConfigs.InitializeCollections ? new List<double>() : null;

        /// <summary>
        /// Checks to see if the Destination property is set.
        /// </summary>
        internal bool IsSetDestination() => this.Destination != null && (this.Destination.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DestinationOptions. 
        /// <para>
        /// Destination related options.
        /// </para>
        /// </summary>
        public WaypointOptimizationDestinationOptions DestinationOptions { get; set; }

        /// <summary>
        /// Checks to see if the DestinationOptions property is set.
        /// </summary>
        internal bool IsSetDestinationOptions() => this.DestinationOptions != null;

        /// <summary>
        /// Gets and sets the property Driver. 
        /// <para>
        /// Driver related options.
        /// </para>
        /// </summary>
        public WaypointOptimizationDriverOptions Driver { get; set; }

        /// <summary>
        /// Checks to see if the Driver property is set.
        /// </summary>
        internal bool IsSetDriver() => this.Driver != null;

        /// <summary>
        /// Gets and sets the property Exclude. 
        /// <para>
        /// Features to be strictly excluded while calculating the route.
        /// </para>
        /// </summary>
        public WaypointOptimizationExclusionOptions Exclude { get; set; }

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
        /// Gets and sets the property OptimizeSequencingFor. 
        /// <para>
        /// Specifies the optimization criteria for the calculated sequence.
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>FastestRoute</c>.
        /// </para>
        /// </summary>
        public WaypointOptimizationSequencingObjective OptimizeSequencingFor { get; set; }

        /// <summary>
        /// Checks to see if the OptimizeSequencingFor property is set.
        /// </summary>
        internal bool IsSetOptimizeSequencingFor() => this.OptimizeSequencingFor != null;

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
        /// Origin related options.
        /// </para>
        /// </summary>
        public WaypointOptimizationOriginOptions OriginOptions { get; set; }

        /// <summary>
        /// Checks to see if the OriginOptions property is set.
        /// </summary>
        internal bool IsSetOriginOptions() => this.OriginOptions != null;

        /// <summary>
        /// Gets and sets the property Traffic. 
        /// <para>
        /// Traffic-related options.
        /// </para>
        /// </summary>
        public WaypointOptimizationTrafficOptions Traffic { get; set; }

        /// <summary>
        /// Checks to see if the Traffic property is set.
        /// </summary>
        internal bool IsSetTraffic() => this.Traffic != null;

        /// <summary>
        /// Gets and sets the property TravelMode. 
        /// <para>
        /// Specifies the mode of transport when calculating a route. Used in estimating the speed
        /// of travel and road compatibility.
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>Car</c> 
        /// </para>
        /// </summary>
        public WaypointOptimizationTravelMode TravelMode { get; set; }

        /// <summary>
        /// Checks to see if the TravelMode property is set.
        /// </summary>
        internal bool IsSetTravelMode() => this.TravelMode != null;

        /// <summary>
        /// Gets and sets the property TravelModeOptions. 
        /// <para>
        /// Travel mode related options for the provided travel mode.
        /// </para>
        /// </summary>
        public WaypointOptimizationTravelModeOptions TravelModeOptions { get; set; }

        /// <summary>
        /// Checks to see if the TravelModeOptions property is set.
        /// </summary>
        internal bool IsSetTravelModeOptions() => this.TravelModeOptions != null;

        /// <summary>
        /// Gets and sets the property Waypoints. 
        /// <para>
        /// List of waypoints between the <c>Origin</c> and <c>Destination</c>, in World Geodetic
        /// System (WGS 84) format: [longitude, latitude].
        /// </para>
        ///  
        /// <para>
        /// The maximum number of waypoints allowed per request:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Maximum 50 waypoints per request
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum 20 waypoints when using constraints (<c>AccessHours</c>, <c>AppointmentTime</c>,
        /// <c>ServiceDuration</c>, <c>Heading</c>, <c>SideOfStreet</c>, <c>Before</c>)
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<WaypointOptimizationWaypoint> Waypoints { get; set; } = AWSConfigs.InitializeCollections ? new List<WaypointOptimizationWaypoint>() : null;

        /// <summary>
        /// Checks to see if the Waypoints property is set.
        /// </summary>
        internal bool IsSetWaypoints() => this.Waypoints != null && (this.Waypoints.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
