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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
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
namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Custom prioritization settings for a game session queue to use when searching for
    /// available game servers to place new game sessions. This configuration replaces the
    /// default FleetIQ prioritization process. 
    /// 
    ///  
    /// <para>
    /// By default, a queue makes placements based on the following default prioritizations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If player latency data is included in a game session request, Amazon GameLift prioritizes
    /// placing game sessions where the average player latency is lowest. Amazon GameLift
    /// re-orders the queue's destinations and locations (for multi-location fleets) based
    /// on the following priorities: (1) the lowest average latency across all players, (2)
    /// the lowest hosting cost, (3) the queue's default destination order, and then (4),
    /// an alphabetic list of locations.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If player latency data is not included, Amazon GameLift prioritizes placing game sessions
    /// in the queue's first destination. If that fleet has multiple locations, the game session
    /// is placed on the first location (when listed alphabetically). Amazon GameLift re-orders
    /// the queue's destinations and locations (for multi-location fleets) based on the following
    /// priorities: (1) the queue's default destination order, and then (2) an alphabetic
    /// list of locations.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PriorityConfiguration
    {
        private List<string> _locationOrder = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _priorityOrder = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property LocationOrder. 
        /// <para>
        /// The prioritization order to use for fleet locations, when the <c>PriorityOrder</c>
        /// property includes <c>LOCATION</c>. Locations can include Amazon Web Services Region
        /// codes (such as <c>us-west-2</c>), local zones, and custom locations (for Anywhere
        /// fleets). Each location must be listed only once. For details, see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-regions.html">Amazon
        /// GameLift service locations.</a> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> LocationOrder
        {
            get { return this._locationOrder; }
            set { this._locationOrder = value; }
        }

        // Check to see if LocationOrder property is set
        internal bool IsSetLocationOrder()
        {
            return this._locationOrder != null && (this._locationOrder.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PriorityOrder. 
        /// <para>
        /// A custom sequence to use when prioritizing where to place new game sessions. Each
        /// priority type is listed once.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>LATENCY</c> -- Amazon GameLift prioritizes locations where the average player
        /// latency is lowest. Player latency data is provided in each game session placement
        /// request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COST</c> -- Amazon GameLift prioritizes destinations with the lowest current hosting
        /// costs. Cost is evaluated based on the location, instance type, and fleet type (Spot
        /// or On-Demand) of each destination in the queue.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DESTINATION</c> -- Amazon GameLift prioritizes based on the list order of destinations
        /// in the queue configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LOCATION</c> -- Amazon GameLift prioritizes based on the provided order of locations,
        /// as defined in <c>LocationOrder</c>. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=4)]
        public List<string> PriorityOrder
        {
            get { return this._priorityOrder; }
            set { this._priorityOrder = value; }
        }

        // Check to see if PriorityOrder property is set
        internal bool IsSetPriorityOrder()
        {
            return this._priorityOrder != null && (this._priorityOrder.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}