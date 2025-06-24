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
    /// An alternate list of prioritized locations for use with a game session queue. When
    /// this property is included in a <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_StartGameSessionPlacement.html">StartGameSessionPlacement</a>
    /// request, the alternate list overrides the queue's default location priorities, as
    /// defined in the queue's <a href="gamelift/latest/apireference/API_PriorityConfiguration.html">PriorityConfiguration</a>
    /// setting (<i>LocationOrder</i>). The override is valid for an individual placement
    /// request only. Use this property only with queues that have a <c>PriorityConfiguration</c>
    /// setting that prioritizes <c>LOCATION</c> first. 
    /// 
    ///  <note> 
    /// <para>
    /// A priority configuration override list does not override a queue's FilterConfiguration
    /// setting, if the queue has one. Filter configurations are used to limit placements
    /// to a subset of the locations in a queue's destinations. If the override list includes
    /// a location that's not on in the <c>FilterConfiguration</c> allowed list, Amazon GameLift
    /// Servers won't attempt to place a game session there.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class PriorityConfigurationOverride
    {
        private List<string> _locationOrder = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private PlacementFallbackStrategy _placementFallbackStrategy;

        /// <summary>
        /// Gets and sets the property LocationOrder. 
        /// <para>
        /// A prioritized list of hosting locations. The list can include Amazon Web Services
        /// Regions (such as <c>us-west-2</c>), local zones, and custom locations (for Anywhere
        /// fleets). Each location must be listed only once. For details, see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-regions.html">Amazon
        /// GameLift Servers service locations.</a> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
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
        /// Gets and sets the property PlacementFallbackStrategy. 
        /// <para>
        /// Instructions for how to proceed if placement fails in every location on the priority
        /// override list. Valid strategies include: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DEFAULT_AFTER_SINGLE_PASS</c> -- After attempting to place a new game session
        /// in every location on the priority override list, try to place a game session in queue's
        /// other locations. This is the default behavior.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NONE</c> -- Limit placements to locations on the priority override list only.
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PlacementFallbackStrategy PlacementFallbackStrategy
        {
            get { return this._placementFallbackStrategy; }
            set { this._placementFallbackStrategy = value; }
        }

        // Check to see if PlacementFallbackStrategy property is set
        internal bool IsSetPlacementFallbackStrategy()
        {
            return this._placementFallbackStrategy != null;
        }

    }
}