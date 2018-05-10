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
    /// Properties describing a game session.
    /// 
    ///  
    /// <para>
    /// A game session in ACTIVE status can host players. When a game session ends, its status
    /// is set to <code>TERMINATED</code>. 
    /// </para>
    ///  
    /// <para>
    /// Once the session ends, the game session object is retained for 30 days. This means
    /// you can reuse idempotency token values after this time. Game session logs are retained
    /// for 14 days.
    /// </para>
    ///  
    /// <para>
    /// Game-session-related operations include:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateGameSession</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeGameSessions</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeGameSessionDetails</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>SearchGameSessions</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateGameSession</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetGameSessionLogUrl</a> 
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
    public partial class GameSession
    {
        private DateTime? _creationTime;
        private string _creatorId;
        private int? _currentPlayerSessionCount;
        private string _fleetId;
        private List<GameProperty> _gameProperties = new List<GameProperty>();
        private string _gameSessionData;
        private string _gameSessionId;
        private string _ipAddress;
        private string _matchmakerData;
        private int? _maximumPlayerSessionCount;
        private string _name;
        private PlayerSessionCreationPolicy _playerSessionCreationPolicy;
        private int? _port;
        private GameSessionStatus _status;
        private GameSessionStatusReason _statusReason;
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
        /// Gets and sets the property CreatorId. 
        /// <para>
        /// Unique identifier for a player. This ID is used to enforce a resource protection policy
        /// (if one exists), that limits the number of game sessions a player can create.
        /// </para>
        /// </summary>
        public string CreatorId
        {
            get { return this._creatorId; }
            set { this._creatorId = value; }
        }

        // Check to see if CreatorId property is set
        internal bool IsSetCreatorId()
        {
            return this._creatorId != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentPlayerSessionCount. 
        /// <para>
        /// Number of players currently in the game session.
        /// </para>
        /// </summary>
        public int CurrentPlayerSessionCount
        {
            get { return this._currentPlayerSessionCount.GetValueOrDefault(); }
            set { this._currentPlayerSessionCount = value; }
        }

        // Check to see if CurrentPlayerSessionCount property is set
        internal bool IsSetCurrentPlayerSessionCount()
        {
            return this._currentPlayerSessionCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// Unique identifier for a fleet that the game session is running on.
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
        /// Gets and sets the property GameProperties. 
        /// <para>
        /// Set of custom properties for a game session, formatted as key:value pairs. These properties
        /// are passed to a game server process in the <a>GameSession</a> object with a request
        /// to start a new game session (see <a href="http://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-sdk-server-api.html#gamelift-sdk-server-startsession">Start
        /// a Game Session</a>). You can search for active game sessions based on this custom
        /// data with <a>SearchGameSessions</a>.
        /// </para>
        /// </summary>
        public List<GameProperty> GameProperties
        {
            get { return this._gameProperties; }
            set { this._gameProperties = value; }
        }

        // Check to see if GameProperties property is set
        internal bool IsSetGameProperties()
        {
            return this._gameProperties != null && this._gameProperties.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property GameSessionData. 
        /// <para>
        /// Set of custom game session properties, formatted as a single string value. This data
        /// is passed to a game server process in the <a>GameSession</a> object with a request
        /// to start a new game session (see <a href="http://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-sdk-server-api.html#gamelift-sdk-server-startsession">Start
        /// a Game Session</a>).
        /// </para>
        /// </summary>
        public string GameSessionData
        {
            get { return this._gameSessionData; }
            set { this._gameSessionData = value; }
        }

        // Check to see if GameSessionData property is set
        internal bool IsSetGameSessionData()
        {
            return this._gameSessionData != null;
        }

        /// <summary>
        /// Gets and sets the property GameSessionId. 
        /// <para>
        /// Unique identifier for the game session. A game session ARN has the following format:
        /// <code>arn:aws:gamelift:&lt;region&gt;::gamesession/&lt;fleet ID&gt;/&lt;custom ID
        /// string or idempotency token&gt;</code>.
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
        /// Gets and sets the property MatchmakerData. 
        /// <para>
        /// Information about the matchmaking process that was used to create the game session.
        /// It is in JSON syntax, formatted as a string. In addition the matchmaking configuration
        /// used, it contains data on all players assigned to the match, including player attributes
        /// and team assignments. For more details on matchmaker data, see <a href="http://docs.aws.amazon.com/gamelift/latest/developerguide/match-server.html#match-server-data">Match
        /// Data</a>. Matchmaker data is useful when requesting match backfills, and is updated
        /// whenever new players are added during a successful backfill (see <a>StartMatchBackfill</a>).
        /// 
        /// </para>
        /// </summary>
        public string MatchmakerData
        {
            get { return this._matchmakerData; }
            set { this._matchmakerData = value; }
        }

        // Check to see if MatchmakerData property is set
        internal bool IsSetMatchmakerData()
        {
            return this._matchmakerData != null;
        }

        /// <summary>
        /// Gets and sets the property MaximumPlayerSessionCount. 
        /// <para>
        /// Maximum number of players that can be connected simultaneously to the game session.
        /// </para>
        /// </summary>
        public int MaximumPlayerSessionCount
        {
            get { return this._maximumPlayerSessionCount.GetValueOrDefault(); }
            set { this._maximumPlayerSessionCount = value; }
        }

        // Check to see if MaximumPlayerSessionCount property is set
        internal bool IsSetMaximumPlayerSessionCount()
        {
            return this._maximumPlayerSessionCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Descriptive label that is associated with a game session. Session names do not need
        /// to be unique.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PlayerSessionCreationPolicy. 
        /// <para>
        /// Indicates whether or not the game session is accepting new players.
        /// </para>
        /// </summary>
        public PlayerSessionCreationPolicy PlayerSessionCreationPolicy
        {
            get { return this._playerSessionCreationPolicy; }
            set { this._playerSessionCreationPolicy = value; }
        }

        // Check to see if PlayerSessionCreationPolicy property is set
        internal bool IsSetPlayerSessionCreationPolicy()
        {
            return this._playerSessionCreationPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// Port number for the game session. To connect to a Amazon GameLift game server, an
        /// app needs both the IP address and port number.
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
        /// Current status of the game session. A game session must have an <code>ACTIVE</code>
        /// status to have player sessions.
        /// </para>
        /// </summary>
        public GameSessionStatus Status
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
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Provides additional information about game session status. <code>INTERRUPTED</code>
        /// indicates that the game session was hosted on a spot instance that was reclaimed,
        /// causing the active game session to be terminated.
        /// </para>
        /// </summary>
        public GameSessionStatusReason StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
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