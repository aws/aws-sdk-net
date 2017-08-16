/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Object used in matchmaking to represent a player. When starting a matchmaking request,
    /// a player has a player ID and may have latency data. Team information is added after
    /// a match has been successfully completed.
    /// </summary>
    public partial class Player
    {
        private Dictionary<string, int> _latencyInMs = new Dictionary<string, int>();
        private Dictionary<string, AttributeValue> _playerAttributes = new Dictionary<string, AttributeValue>();
        private string _playerId;
        private string _team;

        /// <summary>
        /// Gets and sets the property LatencyInMs. 
        /// <para>
        /// Set of values, expressed in milliseconds, indicating the amount of latency that a
        /// player experiences when connected to AWS regions. If this property is present, FlexMatch
        /// considers placing the match only in regions that are included in the object map. If
        /// not present (that is, null), FlexMatch ignores latency issues and may place the match
        /// in any region in the queue.
        /// </para>
        ///  <note> 
        /// <para>
        /// If this property contains an empty map, FlexMatch assumes that no regions are available
        /// to the player. In this scenario, the ticket is not matchable and always times out
        /// unless canceled. 
        /// </para>
        ///  </note>
        /// </summary>
        public Dictionary<string, int> LatencyInMs
        {
            get { return this._latencyInMs; }
            set { this._latencyInMs = value; }
        }

        // Check to see if LatencyInMs property is set
        internal bool IsSetLatencyInMs()
        {
            return this._latencyInMs != null && this._latencyInMs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PlayerAttributes. 
        /// <para>
        /// Collection of name:value pairs containing player information for use in matchmaking.
        /// Player attribute names need to match <i>playerAttributes</i> names in the rule set
        /// being used. Example: <code>"PlayerAttributes": {"skill": {"N": "23"}, "gameMode":
        /// {"S": "deathmatch"}}</code>.
        /// </para>
        /// </summary>
        public Dictionary<string, AttributeValue> PlayerAttributes
        {
            get { return this._playerAttributes; }
            set { this._playerAttributes = value; }
        }

        // Check to see if PlayerAttributes property is set
        internal bool IsSetPlayerAttributes()
        {
            return this._playerAttributes != null && this._playerAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PlayerId. 
        /// <para>
        /// Unique identifier for a player
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Team. 
        /// <para>
        /// Name of the team that the player is assigned to in a match. Team names are defined
        /// in a matchmaking rule set.
        /// </para>
        /// </summary>
        public string Team
        {
            get { return this._team; }
            set { this._team = value; }
        }

        // Check to see if Team property is set
        internal bool IsSetTeam()
        {
            return this._team != null;
        }

    }
}