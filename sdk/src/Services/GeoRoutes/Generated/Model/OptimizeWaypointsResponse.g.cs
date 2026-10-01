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
    /// This is the response object from the OptimizeWaypoints operation.
    /// </summary>
    public partial class OptimizeWaypointsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Connections. 
        /// <para>
        /// Details about the connection from one waypoint to the next, within the optimized sequence.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<WaypointOptimizationConnection> Connections { get; set; } = AWSConfigs.InitializeCollections ? new List<WaypointOptimizationConnection>() : null;

        /// <summary>
        /// Checks to see if the Connections property is set.
        /// </summary>
        internal bool IsSetConnections() => this.Connections != null && (this.Connections.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Distance. 
        /// <para>
        /// Overall distance to travel the whole sequence.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0, Max = 4294967295)]
        public long? Distance { get; set; }

        /// <summary>
        /// Checks to see if the Distance property is set.
        /// </summary>
        internal bool IsSetDistance() => this.Distance.HasValue;

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
        [AWSProperty(Required = true, Sensitive = true, Min = 0, Max = 4294967295)]
        public long? Duration { get; set; }

        /// <summary>
        /// Checks to see if the Duration property is set.
        /// </summary>
        internal bool IsSetDuration() => this.Duration.HasValue;

        /// <summary>
        /// Gets and sets the property ImpedingWaypoints. 
        /// <para>
        /// Returns waypoints that caused the optimization problem to fail, and the constraints
        /// that were unsatisfied leading to the failure.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<WaypointOptimizationImpedingWaypoint> ImpedingWaypoints { get; set; } = AWSConfigs.InitializeCollections ? new List<WaypointOptimizationImpedingWaypoint>() : null;

        /// <summary>
        /// Checks to see if the ImpedingWaypoints property is set.
        /// </summary>
        internal bool IsSetImpedingWaypoints() => this.ImpedingWaypoints != null && (this.ImpedingWaypoints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OptimizedWaypoints. 
        /// <para>
        /// Waypoints in the order of the optimized sequence.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<WaypointOptimizationOptimizedWaypoint> OptimizedWaypoints { get; set; } = AWSConfigs.InitializeCollections ? new List<WaypointOptimizationOptimizedWaypoint>() : null;

        /// <summary>
        /// Checks to see if the OptimizedWaypoints property is set.
        /// </summary>
        internal bool IsSetOptimizedWaypoints() => this.OptimizedWaypoints != null && (this.OptimizedWaypoints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PricingBucket. 
        /// <para>
        /// The pricing bucket for which the query is charged at.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PricingBucket { get; set; }

        /// <summary>
        /// Checks to see if the PricingBucket property is set.
        /// </summary>
        internal bool IsSetPricingBucket() => this.PricingBucket != null;

        /// <summary>
        /// Gets and sets the property TimeBreakdown. 
        /// <para>
        /// Time breakdown for the sequence.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public WaypointOptimizationTimeBreakdown TimeBreakdown { get; set; }

        /// <summary>
        /// Checks to see if the TimeBreakdown property is set.
        /// </summary>
        internal bool IsSetTimeBreakdown() => this.TimeBreakdown != null;
    }
}
