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
    /// Container for the parameters to the CreateGameSession operation.
    /// Creates a multiplayer game session for players. This action creates a game session
    /// record and assigns an available server process in the specified fleet to host the
    /// game session. A fleet must have an <code>ACTIVE</code> status before a game session
    /// can be created in it.
    /// 
    ///  
    /// <para>
    /// To create a game session, specify either fleet ID or alias ID and indicate a maximum
    /// number of players to allow in the game session. You can also provide a name and game-specific
    /// properties for this game session. If successful, a <a>GameSession</a> object is returned
    /// containing the game session properties and other settings you specified.
    /// </para>
    ///  
    /// <para>
    ///  <b>Idempotency tokens.</b> You can add a token that uniquely identifies game session
    /// requests. This is useful for ensuring that game session requests are idempotent. Multiple
    /// requests with the same idempotency token are processed only once; subsequent requests
    /// return the original result. All response values are the same with the exception of
    /// game session status, which may change.
    /// </para>
    ///  
    /// <para>
    ///  <b>Resource creation limits.</b> If you are creating a game session on a fleet with
    /// a resource creation limit policy in force, then you must specify a creator ID. Without
    /// this ID, Amazon GameLift has no way to evaluate the policy for this new game session
    /// request.
    /// </para>
    ///  
    /// <para>
    ///  <b>Player acceptance policy.</b> By default, newly created game sessions are open
    /// to new players. You can restrict new player access by using <a>UpdateGameSession</a>
    /// to change the game session's player session creation policy.
    /// </para>
    ///  
    /// <para>
    ///  <b>Game session logs.</b> Logs are retained for all active game sessions for 14 days.
    /// To access the logs, call <a>GetGameSessionLogUrl</a> to download the log files.
    /// </para>
    ///  
    /// <para>
    ///  <i>Available in Amazon GameLift Local.</i> 
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
    public partial class CreateGameSessionRequest : AmazonGameLiftRequest
    {
        private string _aliasId;
        private string _creatorId;
        private string _fleetId;
        private List<GameProperty> _gameProperties = new List<GameProperty>();
        private string _gameSessionData;
        private string _gameSessionId;
        private string _idempotencyToken;
        private int? _maximumPlayerSessionCount;
        private string _name;

        /// <summary>
        /// Gets and sets the property AliasId. 
        /// <para>
        /// Unique identifier for an alias associated with the fleet to create a game session
        /// in. Each request must reference either a fleet ID or alias ID, but not both.
        /// </para>
        /// </summary>
        public string AliasId
        {
            get { return this._aliasId; }
            set { this._aliasId = value; }
        }

        // Check to see if AliasId property is set
        internal bool IsSetAliasId()
        {
            return this._aliasId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatorId. 
        /// <para>
        /// Unique identifier for a player or entity creating the game session. This ID is used
        /// to enforce a resource protection policy (if one exists) that limits the number of
        /// concurrent active game sessions one player can have.
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
        /// Gets and sets the property FleetId. 
        /// <para>
        /// Unique identifier for a fleet to create a game session in. Each request must reference
        /// either a fleet ID or alias ID, but not both.
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
        /// a Game Session</a>).
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
        ///  <i>This parameter is no longer preferred. Please use <code>IdempotencyToken</code>
        /// instead.</i> Custom string that uniquely identifies a request for a new game session.
        /// Maximum token length is 48 characters. If provided, this string is included in the
        /// new game session's ID. (A game session ARN has the following format: <code>arn:aws:gamelift:&lt;region&gt;::gamesession/&lt;fleet
        /// ID&gt;/&lt;custom ID string or idempotency token&gt;</code>.) 
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
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// Custom string that uniquely identifies a request for a new game session. Maximum token
        /// length is 48 characters. If provided, this string is included in the new game session's
        /// ID. (A game session ARN has the following format: <code>arn:aws:gamelift:&lt;region&gt;::gamesession/&lt;fleet
        /// ID&gt;/&lt;custom ID string or idempotency token&gt;</code>.) Idempotency tokens remain
        /// in use for 30 days after a game session has ended; game session objects are retained
        /// for this time period and then deleted.
        /// </para>
        /// </summary>
        public string IdempotencyToken
        {
            get { return this._idempotencyToken; }
            set { this._idempotencyToken = value; }
        }

        // Check to see if IdempotencyToken property is set
        internal bool IsSetIdempotencyToken()
        {
            return this._idempotencyToken != null;
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

    }
}