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
    /// Container for the parameters to the StartGameSessionPlacement operation.
    /// Places a request for a new game session in a queue (see <a>CreateGameSessionQueue</a>).
    /// When processing a placement request, Amazon GameLift searches for available resources
    /// on the queue's destinations, scanning each until it finds resources or the placement
    /// request times out.
    /// 
    ///  
    /// <para>
    /// A game session placement request can also request player sessions. When a new game
    /// session is successfully created, Amazon GameLift creates a player session for each
    /// player included in the request.
    /// </para>
    ///  
    /// <para>
    /// When placing a game session, by default Amazon GameLift tries each fleet in the order
    /// they are listed in the queue configuration. Ideally, a queue's destinations are listed
    /// in preference order.
    /// </para>
    ///  
    /// <para>
    /// Alternatively, when requesting a game session with players, you can also provide latency
    /// data for each player in relevant regions. Latency data indicates the performance lag
    /// a player experiences when connected to a fleet in the region. Amazon GameLift uses
    /// latency data to reorder the list of destinations to place the game session in a region
    /// with minimal lag. If latency data is provided for multiple players, Amazon GameLift
    /// calculates each region's average lag for all players and reorders to get the best
    /// game play across all players. 
    /// </para>
    ///  
    /// <para>
    /// To place a new game session request, specify the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The queue name and a set of game session properties and settings
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A unique ID (such as a UUID) for the placement. You use this ID to track the status
    /// of the placement request
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// (Optional) A set of IDs and player data for each player you want to join to the new
    /// game session
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Latency data for all players (if you want to optimize game play for the players)
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If successful, a new game session placement is created.
    /// </para>
    ///  
    /// <para>
    /// To track the status of a placement request, call <a>DescribeGameSessionPlacement</a>
    /// and check the request's status. If the status is <code>FULFILLED</code>, a new game
    /// session has been created and a game session ARN and region are referenced. If the
    /// placement request times out, you can resubmit the request or retry it with a different
    /// queue. 
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
    public partial class StartGameSessionPlacementRequest : AmazonGameLiftRequest
    {
        private List<DesiredPlayerSession> _desiredPlayerSessions = new List<DesiredPlayerSession>();
        private List<GameProperty> _gameProperties = new List<GameProperty>();
        private string _gameSessionData;
        private string _gameSessionName;
        private string _gameSessionQueueName;
        private int? _maximumPlayerSessionCount;
        private string _placementId;
        private List<PlayerLatency> _playerLatencies = new List<PlayerLatency>();

        /// <summary>
        /// Gets and sets the property DesiredPlayerSessions. 
        /// <para>
        /// Set of information on each player to create a player session for.
        /// </para>
        /// </summary>
        public List<DesiredPlayerSession> DesiredPlayerSessions
        {
            get { return this._desiredPlayerSessions; }
            set { this._desiredPlayerSessions = value; }
        }

        // Check to see if DesiredPlayerSessions property is set
        internal bool IsSetDesiredPlayerSessions()
        {
            return this._desiredPlayerSessions != null && this._desiredPlayerSessions.Count > 0; 
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
        /// Gets and sets the property GameSessionName. 
        /// <para>
        /// Descriptive label that is associated with a game session. Session names do not need
        /// to be unique.
        /// </para>
        /// </summary>
        public string GameSessionName
        {
            get { return this._gameSessionName; }
            set { this._gameSessionName = value; }
        }

        // Check to see if GameSessionName property is set
        internal bool IsSetGameSessionName()
        {
            return this._gameSessionName != null;
        }

        /// <summary>
        /// Gets and sets the property GameSessionQueueName. 
        /// <para>
        /// Name of the queue to use to place the new game session.
        /// </para>
        /// </summary>
        public string GameSessionQueueName
        {
            get { return this._gameSessionQueueName; }
            set { this._gameSessionQueueName = value; }
        }

        // Check to see if GameSessionQueueName property is set
        internal bool IsSetGameSessionQueueName()
        {
            return this._gameSessionQueueName != null;
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
        /// Gets and sets the property PlacementId. 
        /// <para>
        /// Unique identifier to assign to the new game session placement. This value is developer-defined.
        /// The value must be unique across all regions and cannot be reused unless you are resubmitting
        /// a canceled or timed-out placement request.
        /// </para>
        /// </summary>
        public string PlacementId
        {
            get { return this._placementId; }
            set { this._placementId = value; }
        }

        // Check to see if PlacementId property is set
        internal bool IsSetPlacementId()
        {
            return this._placementId != null;
        }

        /// <summary>
        /// Gets and sets the property PlayerLatencies. 
        /// <para>
        /// Set of values, expressed in milliseconds, indicating the amount of latency that a
        /// player experiences when connected to AWS regions. This information is used to try
        /// to place the new game session where it can offer the best possible gameplay experience
        /// for the players. 
        /// </para>
        /// </summary>
        public List<PlayerLatency> PlayerLatencies
        {
            get { return this._playerLatencies; }
            set { this._playerLatencies = value; }
        }

        // Check to see if PlayerLatencies property is set
        internal bool IsSetPlayerLatencies()
        {
            return this._playerLatencies != null && this._playerLatencies.Count > 0; 
        }

    }
}