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
    /// This is the response object from the OptimizeWaypoints operation.
    /// </summary>
    public partial class OptimizeWaypointsResponse : AmazonWebServiceResponse
    {
        private List<WaypointOptimizationConnection> _connections = AWSConfigs.InitializeCollections ? new List<WaypointOptimizationConnection>() : null;
        private long? _distance;
        private long? _duration;
        private List<WaypointOptimizationImpedingWaypoint> _impedingWaypoints = AWSConfigs.InitializeCollections ? new List<WaypointOptimizationImpedingWaypoint>() : null;
        private List<WaypointOptimizationOptimizedWaypoint> _optimizedWaypoints = AWSConfigs.InitializeCollections ? new List<WaypointOptimizationOptimizedWaypoint>() : null;
        private string _pricingBucket;
        private WaypointOptimizationTimeBreakdown _timeBreakdown;

        /// <summary>
        /// Gets and sets the property Connections. 
        /// <para>
        /// Details about the connection from one waypoint to the next, within the optimized sequence.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<WaypointOptimizationConnection> Connections
        {
            get { return this._connections; }
            set { this._connections = value; }
        }

        // Check to see if Connections property is set
        internal bool IsSetConnections()
        {
            return this._connections != null && (this._connections.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Distance. 
        /// <para>
        /// Overall distance to travel the whole sequence.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=4294967295)]
        public long? Distance
        {
            get { return this._distance; }
            set { this._distance = value; }
        }

        // Check to see if Distance property is set
        internal bool IsSetDistance()
        {
            return this._distance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// Overall duration to travel the whole sequence.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>seconds</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=4294967295)]
        public long? Duration
        {
            get { return this._duration; }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImpedingWaypoints. 
        /// <para>
        /// Returns waypoints that caused the optimization problem to fail, and the constraints
        /// that were unsatisfied leading to the failure.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<WaypointOptimizationImpedingWaypoint> ImpedingWaypoints
        {
            get { return this._impedingWaypoints; }
            set { this._impedingWaypoints = value; }
        }

        // Check to see if ImpedingWaypoints property is set
        internal bool IsSetImpedingWaypoints()
        {
            return this._impedingWaypoints != null && (this._impedingWaypoints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OptimizedWaypoints. 
        /// <para>
        /// Waypoints in the order of the optimized sequence.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<WaypointOptimizationOptimizedWaypoint> OptimizedWaypoints
        {
            get { return this._optimizedWaypoints; }
            set { this._optimizedWaypoints = value; }
        }

        // Check to see if OptimizedWaypoints property is set
        internal bool IsSetOptimizedWaypoints()
        {
            return this._optimizedWaypoints != null && (this._optimizedWaypoints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PricingBucket. 
        /// <para>
        /// The pricing bucket for which the query is charged at.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PricingBucket
        {
            get { return this._pricingBucket; }
            set { this._pricingBucket = value; }
        }

        // Check to see if PricingBucket property is set
        internal bool IsSetPricingBucket()
        {
            return this._pricingBucket != null;
        }

        /// <summary>
        /// Gets and sets the property TimeBreakdown. 
        /// <para>
        /// Time breakdown for the sequence.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WaypointOptimizationTimeBreakdown TimeBreakdown
        {
            get { return this._timeBreakdown; }
            set { this._timeBreakdown = value; }
        }

        // Check to see if TimeBreakdown property is set
        internal bool IsSetTimeBreakdown()
        {
            return this._timeBreakdown != null;
        }

    }
}