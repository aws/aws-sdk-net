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
    /// Represents a player in matchmaking. When starting a matchmaking request, a player
    /// has a player ID, attributes, and may have latency data. Team information is added
    /// after a match has been successfully completed.
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
        /// A set of values, expressed in milliseconds, that indicates the amount of latency that
        /// a player experiences when connected to @aws; Regions. If this property is present,
        /// FlexMatch considers placing the match only in Regions for which latency is reported.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If a matchmaker has a rule that evaluates player latency, players must report latency
        /// in order to be matched. If no latency is reported in this scenario, FlexMatch assumes
        /// that no Regions are available to the player and the ticket is not matchable. 
        /// </para>
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
        /// A collection of key:value pairs containing player information for use in matchmaking.
        /// Player attribute keys must match the <i>playerAttributes</i> used in a matchmaking
        /// rule set. Example: <code>"PlayerAttributes": {"skill": {"N": "23"}, "gameMode": {"S":
        /// "deathmatch"}}</code>.
        /// </para>
        ///  
        /// <para>
        /// You can provide up to 10 <code>PlayerAttributes</code>.
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
        /// A unique identifier for a player
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
        /// Gets and sets the property Team. 
        /// <para>
        /// Name of the team that the player is assigned to in a match. Team names are defined
        /// in a matchmaking rule set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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