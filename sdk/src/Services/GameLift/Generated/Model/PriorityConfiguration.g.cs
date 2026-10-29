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

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Custom prioritization settings to use with a game session queue. Prioritization settings
    /// determine how the queue selects a game hosting resource to start a new game session.
    /// This configuration replaces the default prioritization process for queues.
    /// 
    ///  
    /// <para>
    /// By default, a queue makes game session placements based on the following criteria:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// When a game session request does not include player latency data, Amazon GameLift
    /// Servers places game sessions based on the following priorities: (1) the queue's default
    /// destination order, and (2) for multi-location fleets, an alphabetic list of locations.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// When a game session request includes player latency data, Amazon GameLift Servers
    /// re-orders the queue's destinations to make placements where the average player latency
    /// is lowest. It reorders based on the following priorities: (1) the lowest average latency
    /// across all players, (2) the lowest hosting cost, (3) the queue's default destination
    /// order, and (4) for multi-location fleets, an alphabetic list of locations.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PriorityConfiguration
    {
        /// <summary>
        /// Gets and sets the property LocationOrder. 
        /// <para>
        /// The prioritization order to use for fleet locations, when the <c>PriorityOrder</c>
        /// property includes <c>LOCATION</c>. Locations can include Amazon Web Services Region
        /// codes (such as <c>us-west-2</c>), local zones, and custom locations (for Anywhere
        /// fleets). Each location must be listed only once. For details, see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-regions.html">Amazon
        /// GameLift Servers service locations.</a> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<string> LocationOrder { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LocationOrder property is set.
        /// </summary>
        internal bool IsSetLocationOrder() => this.LocationOrder != null && (this.LocationOrder.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PriorityOrder. 
        /// <para>
        /// A custom sequence to use when prioritizing where to place new game sessions. Each
        /// priority type is listed once.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>LATENCY</c> -- Amazon GameLift Servers prioritizes locations where the average
        /// player latency is lowest. Player latency data is provided in each game session placement
        /// request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COST</c> -- Amazon GameLift Servers prioritizes queue destinations with the lowest
        /// current hosting costs. Cost is evaluated based on the destination's location, instance
        /// type, and fleet type (Spot or On-Demand).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DESTINATION</c> -- Amazon GameLift Servers prioritizes based on the list order
        /// of destinations in the queue configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LOCATION</c> -- Amazon GameLift Servers prioritizes based on the provided order
        /// of locations, as defined in <c>LocationOrder</c>. 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 4)]
        public List<string> PriorityOrder { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PriorityOrder property is set.
        /// </summary>
        internal bool IsSetPriorityOrder() => this.PriorityOrder != null && (this.PriorityOrder.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
