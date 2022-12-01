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
    /// Reserves open slots in a game session for a group of players. New player sessions
    /// can be created in any game session with an open slot that is in <code>ACTIVE</code>
    /// status and has a player creation policy of <code>ACCEPT_ALL</code>. To add a single
    /// player to a game session, use <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_CreatePlayerSession.html">CreatePlayerSession</a>
    /// 
    /// 
    ///  
    /// <para>
    /// To create player sessions, specify a game session ID and a list of player IDs. Optionally,
    /// provide a set of player data for each player ID. 
    /// </para>
    ///  
    /// <para>
    /// If successful, a slot is reserved in the game session for each player, and new <code>PlayerSession</code>
    /// objects are returned with player session IDs. Each player references their player
    /// session ID when sending a connection request to the game session, and the game server
    /// can use it to validate the player reservation with the GameLift service. Player sessions
    /// cannot be updated.
    /// </para>
    ///  
    /// <para>
    /// The maximum number of players per game session is 200. It is not adjustable. 
    /// </para>
    ///  
    /// <para>
    ///  <b>Related actions</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
    /// APIs by task</a> 
    /// </para>
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
        /// as needed for use in the game. Any player data strings for player IDs that are not
        /// included in the <code>PlayerIds</code> parameter are ignored. 
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