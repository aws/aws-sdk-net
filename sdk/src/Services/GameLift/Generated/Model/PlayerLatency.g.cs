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
    /// Regional latency information for a player, used when requesting a new game session.
    /// This value indicates the amount of time lag that exists when the player is connected
    /// to a fleet in the specified location (an Amazon Web Services Region or a custom location
    /// for Amazon GameLift Servers Anywhere fleets). The relative difference between a player's
    /// latency values for multiple locations are used to determine which fleets are best
    /// suited to place a new game session for the player.
    /// </summary>
    public partial class PlayerLatency
    {
        /// <summary>
        /// Gets and sets the property LatencyInMilliseconds. 
        /// <para>
        /// Amount of time that represents the time lag experienced by the player when connected
        /// to the specified Region.
        /// </para>
        /// </summary>
        public float? LatencyInMilliseconds { get; set; }

        /// <summary>
        /// Checks to see if the LatencyInMilliseconds property is set.
        /// </summary>
        internal bool IsSetLatencyInMilliseconds() => this.LatencyInMilliseconds.HasValue;

        /// <summary>
        /// Gets and sets the property PlayerId. 
        /// <para>
        /// A unique identifier for a player associated with the latency data.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string PlayerId { get; set; }

        /// <summary>
        /// Checks to see if the PlayerId property is set.
        /// </summary>
        internal bool IsSetPlayerId() => this.PlayerId != null;

        /// <summary>
        /// Gets and sets the property RegionIdentifier. 
        /// <para>
        /// Name of the Region or custom location that is associated with the latency value. For
        /// Amazon GameLift Servers Anywhere fleets, use the custom location name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string RegionIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the RegionIdentifier property is set.
        /// </summary>
        internal bool IsSetRegionIdentifier() => this.RegionIdentifier != null;
    }
}
