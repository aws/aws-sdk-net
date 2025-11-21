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
    /// Options for WaypointOptimizationClustering.
    /// </summary>
    public partial class WaypointOptimizationClusteringOptions
    {
        private WaypointOptimizationClusteringAlgorithm _algorithm;
        private WaypointOptimizationDrivingDistanceOptions _drivingDistanceOptions;

        /// <summary>
        /// Gets and sets the property Algorithm. 
        /// <para>
        /// The algorithm to be used. <c>DrivingDistance</c> assigns all the waypoints that are
        /// within driving distance of each other into a single cluster. <c>TopologySegment</c>
        /// assigns all the waypoints that are within the same topology segment into a single
        /// cluster. A Topology segment is a linear stretch of road between two junctions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public WaypointOptimizationClusteringAlgorithm Algorithm
        {
            get { return this._algorithm; }
            set { this._algorithm = value; }
        }

        // Check to see if Algorithm property is set
        internal bool IsSetAlgorithm()
        {
            return this._algorithm != null;
        }

        /// <summary>
        /// Gets and sets the property DrivingDistanceOptions. 
        /// <para>
        /// Driving distance options to be used when the clustering algorithm is DrivingDistance.
        /// </para>
        /// </summary>
        public WaypointOptimizationDrivingDistanceOptions DrivingDistanceOptions
        {
            get { return this._drivingDistanceOptions; }
            set { this._drivingDistanceOptions = value; }
        }

        // Check to see if DrivingDistanceOptions property is set
        internal bool IsSetDrivingDistanceOptions()
        {
            return this._drivingDistanceOptions != null;
        }

    }
}