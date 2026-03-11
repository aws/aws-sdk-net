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
    /// The optimized waypoint.
    /// </summary>
    public partial class WaypointOptimizationOptimizedWaypoint
    {
        private string _arrivalTime;
        private int? _clusterIndex;
        private string _departureTime;
        private string _id;
        private List<double> _position = AWSConfigs.InitializeCollections ? new List<double>() : null;

        /// <summary>
        /// Gets and sets the property ArrivalTime. 
        /// <para>
        /// Estimated time of arrival at the destination.
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
        /// Gets and sets the property ClusterIndex. 
        /// <para>
        /// Index of the cluster the waypoint is associated with. The index is included in the
        /// response only if clustering was performed while processing the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? ClusterIndex
        {
            get { return this._clusterIndex; }
            set { this._clusterIndex = value; }
        }

        // Check to see if ClusterIndex property is set
        internal bool IsSetClusterIndex()
        {
            return this._clusterIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DepartureTime. 
        /// <para>
        /// Estimated time of departure from thr origin.
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
        [AWSProperty(Required=true, Sensitive=true)]
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The waypoint Id.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Position. 
        /// <para>
        /// Position defined as <c>[longitude, latitude]</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=2, Max=2)]
        public List<double> Position
        {
            get { return this._position; }
            set { this._position = value; }
        }

        // Check to see if Position property is set
        internal bool IsSetPosition()
        {
            return this._position != null && (this._position.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}