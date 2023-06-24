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

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Custom prioritization settings for use by a game session queue when placing new game
    /// sessions with available game servers. When defined, this configuration replaces the
    /// default FleetIQ prioritization process, which is as follows:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// If player latency data is included in a game session request, destinations and locations
    /// are prioritized first based on lowest average latency (1), then on lowest hosting
    /// cost (2), then on destination list order (3), and finally on location (alphabetical)
    /// (4). This approach ensures that the queue's top priority is to place game sessions
    /// where average player latency is lowest, and--if latency is the same--where the hosting
    /// cost is less, etc.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If player latency data is not included, destinations and locations are prioritized
    /// first on destination list order (1), and then on location (alphabetical) (2). This
    /// approach ensures that the queue's top priority is to place game sessions on the first
    /// destination fleet listed. If that fleet has multiple locations, the game session is
    /// placed on the first location (when listed alphabetically).
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Changing the priority order will affect how game sessions are placed.
    /// </para>
    /// </summary>
    public partial class PriorityConfiguration
    {
        private List<string> _locationOrder = new List<string>();
        private List<string> _priorityOrder = new List<string>();

        /// <summary>
        /// Gets and sets the property LocationOrder. 
        /// <para>
        /// The prioritization order to use for fleet locations, when the <code>PriorityOrder</code>
        /// property includes <code>LOCATION</code>. Locations are identified by Amazon Web Services
        /// Region codes such as <code>us-west-2</code>. Each location can only be listed once.
        /// 
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
            return this._locationOrder != null && this._locationOrder.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PriorityOrder. 
        /// <para>
        /// The recommended sequence to use when prioritizing where to place new game sessions.
        /// Each type can only be listed once.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>LATENCY</code> -- FleetIQ prioritizes locations where the average player latency
        /// (provided in each game session request) is lowest. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>COST</code> -- FleetIQ prioritizes destinations with the lowest current hosting
        /// costs. Cost is evaluated based on the location, instance type, and fleet type (Spot
        /// or On-Demand) for each destination in the queue.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DESTINATION</code> -- FleetIQ prioritizes based on the order that destinations
        /// are listed in the queue configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LOCATION</code> -- FleetIQ prioritizes based on the provided order of locations,
        /// as defined in <code>LocationOrder</code>. 
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
            return this._priorityOrder != null && this._priorityOrder.Count > 0; 
        }

    }
}