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
    /// This object includes the full details of the original request plus the current status
    /// and start/end time stamps.
    /// </summary>
    public partial class GameSessionPlacement
    {
        private string _dnsName;
        private DateTime? _endTime;
        private List<GameProperty> _gameProperties = new List<GameProperty>();
        private string _gameSessionArn;
        private string _gameSessionData;
        private string _gameSessionId;
        private string _gameSessionName;
        private string _gameSessionQueueName;
        private string _gameSessionRegion;
        private string _ipAddress;
        private string _matchmakerData;
        private int? _maximumPlayerSessionCount;
        private List<PlacedPlayerSession> _placedPlayerSessions = new List<PlacedPlayerSession>();
        private string _placementId;
        private List<PlayerLatency> _playerLatencies = new List<PlayerLatency>();
        private int? _port;
        private DateTime? _startTime;
        private GameSessionPlacementState _status;

        /// <summary>
        /// Gets and sets the property DnsName. 
        /// <para>
        /// The DNS identifier assigned to the instance that is running the game session. Values
        /// have the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// TLS-enabled fleets: <code>&lt;unique identifier&gt;.&lt;region identifier&gt;.amazongamelift.com</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Non-TLS-enabled fleets: <code>ec2-&lt;unique identifier&gt;.compute.amazonaws.com</code>.
        /// (See <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-instance-addressing.html#concepts-public-addresses">Amazon
        /// EC2 Instance IP Addressing</a>.)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When connecting to a game session that is running on a TLS-enabled fleet, you must
        /// use the DNS name, not the IP address.
        /// </para>
        /// </summary>
        public string DnsName
        {
            get { return this._dnsName; }
            set { this._dnsName = value; }
        }

        // Check to see if DnsName property is set
        internal bool IsSetDnsName()
        {
            return this._dnsName != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// Time stamp indicating when this request was completed, canceled, or timed out.
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GameProperties. 
        /// <para>
        /// A set of custom properties for a game session, formatted as key:value pairs. These
        /// properties are passed to a game server process with a request to start a new game
        /// session (see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-sdk-server-api.html#gamelift-sdk-server-startsession">Start
        /// a Game Session</a>).
        /// </para>
        /// </summary>
        [AWSProperty(Max=16)]
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
        /// Gets and sets the property GameSessionArn. 
        /// <para>
        /// Identifier for the game session created by this placement request. This value is set
        /// once the new game session is placed (placement status is <code>FULFILLED</code>).
        /// This identifier is unique across all Regions. You can use this value as a <code>GameSessionId</code>
        /// value as needed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string GameSessionArn
        {
            get { return this._gameSessionArn; }
            set { this._gameSessionArn = value; }
        }

        // Check to see if GameSessionArn property is set
        internal bool IsSetGameSessionArn()
        {
            return this._gameSessionArn != null;
        }

        /// <summary>
        /// Gets and sets the property GameSessionData. 
        /// <para>
        /// A set of custom game session properties, formatted as a single string value. This
        /// data is passed to a game server process in the <code>GameSession</code> object with
        /// a request to start a new game session (see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-sdk-server-api.html#gamelift-sdk-server-startsession">Start
        /// a Game Session</a>).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=262144)]
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
        /// A unique identifier for the game session. This value is set once the new game session
        /// is placed (placement status is <code>FULFILLED</code>).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property GameSessionName. 
        /// <para>
        /// A descriptive label that is associated with a game session. Session names do not need
        /// to be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// A descriptive label that is associated with game session queue. Queue names must be
        /// unique within each Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property GameSessionRegion. 
        /// <para>
        /// Name of the Region where the game session created by this placement request is running.
        /// This value is set once the new game session is placed (placement status is <code>FULFILLED</code>).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string GameSessionRegion
        {
            get { return this._gameSessionRegion; }
            set { this._gameSessionRegion = value; }
        }

        // Check to see if GameSessionRegion property is set
        internal bool IsSetGameSessionRegion()
        {
            return this._gameSessionRegion != null;
        }

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// The IP address of the game session. To connect to a GameLift game server, an app needs
        /// both the IP address and port number. This value is set once the new game session is
        /// placed (placement status is <code>FULFILLED</code>). 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Information on the matchmaking process for this game. Data is in JSON syntax, formatted
        /// as a string. It identifies the matchmaking configuration used to create the match,
        /// and contains data on all players assigned to the match, including player attributes
        /// and team assignments. For more details on matchmaker data, see <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-server.html#match-server-data">Match
        /// Data</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=390000)]
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
        /// The maximum number of players that can be connected simultaneously to the game session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
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
        /// Gets and sets the property PlacedPlayerSessions. 
        /// <para>
        /// A collection of information on player sessions created in response to the game session
        /// placement request. These player sessions are created only once a new game session
        /// is successfully placed (placement status is <code>FULFILLED</code>). This information
        /// includes the player ID (as provided in the placement request) and the corresponding
        /// player session ID.
        /// </para>
        /// </summary>
        public List<PlacedPlayerSession> PlacedPlayerSessions
        {
            get { return this._placedPlayerSessions; }
            set { this._placedPlayerSessions = value; }
        }

        // Check to see if PlacedPlayerSessions property is set
        internal bool IsSetPlacedPlayerSessions()
        {
            return this._placedPlayerSessions != null && this._placedPlayerSessions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PlacementId. 
        /// <para>
        /// A unique identifier for a game session placement.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=48)]
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
        /// A set of values, expressed in milliseconds, that indicates the amount of latency that
        /// a player experiences when connected to Amazon Web Services Regions.
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

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number for the game session. To connect to a GameLift game server, an app
        /// needs both the IP address and port number. This value is set once the new game session
        /// is placed (placement status is <code>FULFILLED</code>).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=60000)]
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
        /// Gets and sets the property StartTime. 
        /// <para>
        /// Time stamp indicating when this request was placed in the queue. Format is a number
        /// expressed in Unix time as milliseconds (for example <code>"1469498468.057"</code>).
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Current status of the game session placement request.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>PENDING</b> -- The placement request is currently in the queue waiting to be processed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FULFILLED</b> -- A new game session and player sessions (if requested) have been
        /// successfully created. Values for <i>GameSessionArn</i> and <i>GameSessionRegion</i>
        /// are available. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>CANCELLED</b> -- The placement request was canceled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>TIMED_OUT</b> -- A new game session was not successfully created before the time
        /// limit expired. You can resubmit the placement request as needed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FAILED</b> -- GameLift is not able to complete the process of placing the game
        /// session. Common reasons are the game session terminated before the placement process
        /// was completed, or an unexpected internal error.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public GameSessionPlacementState Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}