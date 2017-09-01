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
    /// Properties describing a player session. Player session objects are created either
    /// by creating a player session for a specific game session, or as part of a game session
    /// placement. A player session represents either a player reservation for a game session
    /// (status <code>RESERVED</code>) or actual player activity in a game session (status
    /// <code>ACTIVE</code>). A player session object (including player data) is automatically
    /// passed to a game session when the player connects to the game session and is validated.
    /// 
    ///  
    /// <para>
    /// When a player disconnects, the player session status changes to <code>COMPLETED</code>.
    /// Once the session ends, the player session object is retained for 30 days and then
    /// removed.
    /// </para>
    ///  
    /// <para>
    /// Player-session-related operations include:
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
    public partial class PlayerSession
    {
        private DateTime? _creationTime;
        private string _fleetId;
        private string _gameSessionId;
        private string _ipAddress;
        private string _playerData;
        private string _playerId;
        private string _playerSessionId;
        private int? _port;
        private PlayerSessionStatus _status;
        private DateTime? _terminationTime;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Time stamp indicating when this data object was created. Format is a number expressed
        /// in Unix time as milliseconds (for example "1469498468.057").
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// Unique identifier for a fleet that the player's game session is running on.
        /// </para>
        /// </summary>
        public string FleetId
        {
            get { return this._fleetId; }
            set { this._fleetId = value; }
        }

        // Check to see if FleetId property is set
        internal bool IsSetFleetId()
        {
            return this._fleetId != null;
        }

        /// <summary>
        /// Gets and sets the property GameSessionId. 
        /// <para>
        /// Unique identifier for the game session that the player session is connected to.
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
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// IP address of the game session. To connect to a Amazon GameLift game server, an app
        /// needs both the IP address and port number.
        /// </para>
        /// </summary>
        public string IpAddress
        {
            get { return this._ipAddress; }
            set { this._ipAddress = value; }
        }

        // Check to see if IpAddress property is set
        internal bool IsSetIpAddress()
        {
            return this._ipAddress != null;
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
        /// Unique identifier for a player that is associated with this player session.
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
        /// Gets and sets the property PlayerSessionId. 
        /// <para>
        /// Unique identifier for a player session.
        /// </para>
        /// </summary>
        public string PlayerSessionId
        {
            get { return this._playerSessionId; }
            set { this._playerSessionId = value; }
        }

        // Check to see if PlayerSessionId property is set
        internal bool IsSetPlayerSessionId()
        {
            return this._playerSessionId != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// Port number for the game session. To connect to a Amazon GameLift server process,
        /// an app needs both the IP address and port number.
        /// </para>
        /// </summary>
        public int Port
        {
            get { return this._port.GetValueOrDefault(); }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Current status of the player session.
        /// </para>
        ///  
        /// <para>
        /// Possible player session statuses include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>RESERVED</b> -- The player session request has been received, but the player has
        /// not yet connected to the server process and/or been validated. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ACTIVE</b> -- The player has been validated by the server process and is currently
        /// connected.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>COMPLETED</b> -- The player connection has been dropped.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>TIMEDOUT</b> -- A player session request was received, but the player did not
        /// connect and/or was not validated within the timeout limit (60 seconds).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PlayerSessionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TerminationTime. 
        /// <para>
        /// Time stamp indicating when this data object was terminated. Format is a number expressed
        /// in Unix time as milliseconds (for example "1469498468.057").
        /// </para>
        /// </summary>
        public DateTime TerminationTime
        {
            get { return this._terminationTime.GetValueOrDefault(); }
            set { this._terminationTime = value; }
        }

        // Check to see if TerminationTime property is set
        internal bool IsSetTerminationTime()
        {
            return this._terminationTime.HasValue; 
        }

    }
}