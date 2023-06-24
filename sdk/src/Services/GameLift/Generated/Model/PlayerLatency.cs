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
    /// Regional latency information for a player, used when requesting a new game session.
    /// This value indicates the amount of time lag that exists when the player is connected
    /// to a fleet in the specified Region. The relative difference between a player's latency
    /// values for multiple Regions are used to determine which fleets are best suited to
    /// place a new game session for the player.
    /// </summary>
    public partial class PlayerLatency
    {
        private float? _latencyInMilliseconds;
        private string _playerId;
        private string _regionIdentifier;

        /// <summary>
        /// Gets and sets the property LatencyInMilliseconds. 
        /// <para>
        /// Amount of time that represents the time lag experienced by the player when connected
        /// to the specified Region.
        /// </para>
        /// </summary>
        public float LatencyInMilliseconds
        {
            get { return this._latencyInMilliseconds.GetValueOrDefault(); }
            set { this._latencyInMilliseconds = value; }
        }

        // Check to see if LatencyInMilliseconds property is set
        internal bool IsSetLatencyInMilliseconds()
        {
            return this._latencyInMilliseconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PlayerId. 
        /// <para>
        /// A unique identifier for a player associated with the latency data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string PlayerId
        {
            get { return this._playerId; }
            set { this._playerId = value; }
        }

        // Check to see if PlayerId property is set
        internal bool IsSetPlayerId()
        {
            return this._playerId != null;
        }

        /// <summary>
        /// Gets and sets the property RegionIdentifier. 
        /// <para>
        /// Name of the Region that is associated with the latency value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string RegionIdentifier
        {
            get { return this._regionIdentifier; }
            set { this._regionIdentifier = value; }
        }

        // Check to see if RegionIdentifier property is set
        internal bool IsSetRegionIdentifier()
        {
            return this._regionIdentifier != null;
        }

    }
}