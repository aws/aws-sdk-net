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
    /// Container for the parameters to the CreatePlayerSession operation.
    /// Reserves an open player slot in a game session for a player. New player sessions can
    /// be created in any game session with an open slot that is in <code>ACTIVE</code> status
    /// and has a player creation policy of <code>ACCEPT_ALL</code>. You can add a group of
    /// players to a game session with <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_CreatePlayerSessions.html">CreatePlayerSessions</a>
    /// . 
    /// 
    ///  
    /// <para>
    /// To create a player session, specify a game session ID, player ID, and optionally a
    /// set of player data. 
    /// </para>
    ///  
    /// <para>
    /// If successful, a slot is reserved in the game session for the player and a new <code>PlayerSessions</code>
    /// object is returned with a player session ID. The player references the player session
    /// ID when sending a connection request to the game session, and the game server can
    /// use it to validate the player reservation with the GameLift service. Player sessions
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
    public partial class CreatePlayerSessionRequest : AmazonGameLiftRequest
    {
        private string _gameSessionId;
        private string _playerData;
        private string _playerId;

        /// <summary>
        /// Gets and sets the property GameSessionId. 
        /// <para>
        /// A unique identifier for the game session to add a player to.
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
        /// Gets and sets the property PlayerData. 
        /// <para>
        /// Developer-defined information related to a player. GameLift does not use this data,
        /// so it can be formatted as needed for use in the game.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string PlayerData
        {
            get { return this._playerData; }
            set { this._playerData = value; }
        }

        // Check to see if PlayerData property is set
        internal bool IsSetPlayerData()
        {
            return this._playerData != null;
        }

        /// <summary>
        /// Gets and sets the property PlayerId. 
        /// <para>
        /// A unique identifier for a player. Player IDs are developer-defined.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
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

    }
}