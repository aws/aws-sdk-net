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
    /// Container for the parameters to the CreatePlayerSession operation.
    /// Adds a player to a game session and creates a player session record. Before a player
    /// can be added, a game session must have an <code>ACTIVE</code> status, have a creation
    /// policy of <code>ALLOW_ALL</code>, and have an open player slot. To add a group of
    /// players to a game session, use <a>CreatePlayerSessions</a>.
    /// 
    ///  
    /// <para>
    /// To create a player session, specify a game session ID, player ID, and optionally a
    /// string of player data. If successful, the player is added to the game session and
    /// a new <a>PlayerSession</a> object is returned. Player sessions cannot be updated.
    /// 
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
        /// Unique identifier for the game session to add a player to.
        /// </para>
        /// </summary>
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
        /// Developer-defined information related to a player. Amazon GameLift does not use this
        /// data, so it can be formatted as needed for use in the game.
        /// </para>
        /// </summary>
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
        /// Unique identifier for a player. Player IDs are developer-defined.
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

    }
}