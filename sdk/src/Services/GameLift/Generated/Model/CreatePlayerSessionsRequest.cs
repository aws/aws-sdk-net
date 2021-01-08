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
    /// Container for the parameters to the CreatePlayerSessions operation.
    /// Reserves open slots in a game session for a group of players. Before players can be
    /// added, a game session must have an <code>ACTIVE</code> status, have a creation policy
    /// of <code>ALLOW_ALL</code>, and have an open player slot. To add a single player to
    /// a game session, use <a>CreatePlayerSession</a>. When a player connects to the game
    /// server and references a player session ID, the game server contacts the Amazon GameLift
    /// service to validate the player reservation and accept the player.
    /// 
    ///  
    /// <para>
    /// To create player sessions, specify a game session ID, a list of player IDs, and optionally
    /// a set of player data strings. If successful, a slot is reserved in the game session
    /// for each player and a set of new <a>PlayerSession</a> objects is returned. Player
    /// sessions cannot be updated.
    /// </para>
    ///  
    /// <para>
    ///  <i>Available in Amazon GameLift Local.</i> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreatePlayerSession</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>CreatePlayerSessions</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribePlayerSessions</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Game session placements
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>StartGameSessionPlacement</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeGameSessionPlacement</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>StopGameSessionPlacement</a> 
    /// </para>
    ///  </li> </ul> </li> </ul>
    /// </summary>
    public partial class CreatePlayerSessionsRequest : AmazonGameLiftRequest
    {
        private string _gameSessionId;
        private Dictionary<string, string> _playerDataMap = new Dictionary<string, string>();
        private List<string> _playerIds = new List<string>();

        /// <summary>
        /// Gets and sets the property GameSessionId. 
        /// <para>
        /// A unique identifier for the game session to add players to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string GameSessionId
        {
            get { return this._gameSessionId; }
            set { this._gameSessionId = value; }
        }

        // Check to see if GameSessionId property is set
        internal bool IsSetGameSessionId()
        {
            return this._gameSessionId != null;
        }

        /// <summary>
        /// Gets and sets the property PlayerDataMap. 
        /// <para>
        /// Map of string pairs, each specifying a player ID and a set of developer-defined information
        /// related to the player. Amazon GameLift does not use this data, so it can be formatted
        /// as needed for use in the game. Player data strings for player IDs not included in
        /// the <code>PlayerIds</code> parameter are ignored. 
        /// </para>
        /// </summary>
        public Dictionary<string, string> PlayerDataMap
        {
            get { return this._playerDataMap; }
            set { this._playerDataMap = value; }
        }

        // Check to see if PlayerDataMap property is set
        internal bool IsSetPlayerDataMap()
        {
            return this._playerDataMap != null && this._playerDataMap.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PlayerIds. 
        /// <para>
        /// List of unique identifiers for the players to be added.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=25)]
        public List<string> PlayerIds
        {
            get { return this._playerIds; }
            set { this._playerIds = value; }
        }

        // Check to see if PlayerIds property is set
        internal bool IsSetPlayerIds()
        {
            return this._playerIds != null && this._playerIds.Count > 0; 
        }

    }
}