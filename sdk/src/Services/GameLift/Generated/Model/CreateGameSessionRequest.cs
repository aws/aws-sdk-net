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
    /// Container for the parameters to the CreateGameSession operation.
    /// Creates a multiplayer game session for players in a specific fleet location. This
    /// operation prompts an available server process to start a game session and retrieves
    /// connection information for the new game session. As an alternative, consider using
    /// the GameLift game session placement feature with <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_StartGameSessionPlacement.html">StartGameSessionPlacement</a>
    /// , which uses FleetIQ algorithms and queues to optimize the placement process.
    /// 
    ///  
    /// <para>
    /// When creating a game session, you specify exactly where you want to place it and provide
    /// a set of game session configuration settings. The fleet must be in <code>ACTIVE</code>
    /// status before a game session can be created in it. 
    /// </para>
    ///  
    /// <para>
    /// This operation can be used in the following ways: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// To create a game session on an instance in a fleet's home Region, provide a fleet
    /// or alias ID along with your game session configuration. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To create a game session on an instance in a fleet's remote location, provide a fleet
    /// or alias ID and a location name, along with your game session configuration. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If successful, a workflow is initiated to start a new game session. A <code>GameSession</code>
    /// object is returned containing the game session configuration and status. When the
    /// status is <code>ACTIVE</code>, game session connection information is provided and
    /// player sessions can be created for the game session. By default, newly created game
    /// sessions are open to new players. You can restrict new player access by using <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_UpdateGameSession.html">UpdateGameSession</a>
    /// to change the game session's player session creation policy.
    /// </para>
    ///  
    /// <para>
    /// Game session logs are retained for all active game sessions for 14 days. To access
    /// the logs, call <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_GetGameSessionLogUrl.html">GetGameSessionLogUrl</a>
    /// to download the log files.
    /// </para>
    ///  
    /// <para>
    ///  <i>Available in Amazon GameLift Local.</i> 
    /// </para>
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-sdk-server-api.html#gamelift-sdk-server-startsession">Start
    /// a game session</a> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
    /// APIs by task</a> 
    /// </para>
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
        private string _location;
        private int? _maximumPlayerSessionCount;
        private string _name;

        /// <summary>
        /// Gets and sets the property AliasId. 
        /// <para>
        /// A unique identifier for the alias associated with the fleet to create a game session
        /// in. You can use either the alias ID or ARN value. Each request must reference either
        /// a fleet ID or alias ID, but not both.
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
        /// A unique identifier for a player or entity creating the game session. This parameter
        /// is required when requesting a new game session on a fleet with a resource creation
        /// limit policy. This type of policy limits the number of concurrent active game sessions
        /// that one player can create within a certain time span. GameLift uses the CreatorId
        /// to evaluate the new request against the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// A unique identifier for the fleet to create a game session in. You can use either
        /// the fleet ID or ARN value. Each request must reference either a fleet ID or alias
        /// ID, but not both.
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
        /// Gets and sets the property GameSessionData. 
        /// <para>
        /// A set of custom game session properties, formatted as a single string value. This
        /// data is passed to a game server process with a request to start a new game session
        /// (see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-sdk-server-api.html#gamelift-sdk-server-startsession">Start
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
        ///  <i>This parameter is deprecated. Use <code>IdempotencyToken</code> instead.</i> 
        /// </para>
        ///  
        /// <para>
        /// Custom string that uniquely identifies a request for a new game session. Maximum token
        /// length is 48 characters. If provided, this string is included in the new game session's
        /// ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=48)]
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
        /// Custom string that uniquely identifies the new game session request. This is useful
        /// for ensuring that game session requests with the same idempotency token are processed
        /// only once. Subsequent requests with the same string return the original <code>GameSession</code>
        /// object, with an updated status. Maximum token length is 48 characters. If provided,
        /// this string is included in the new game session's ID. A game session ARN has the following
        /// format: <code>arn:aws:gamelift:&lt;region&gt;::gamesession/&lt;fleet ID&gt;/&lt;custom
        /// ID string or idempotency token&gt;</code>. Idempotency tokens remain in use for 30
        /// days after a game session has ended; game session objects are retained for this time
        /// period and then deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=48)]
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
        /// Gets and sets the property Location. 
        /// <para>
        /// A fleet's remote location to place the new game session in. If this parameter is not
        /// set, the new game session is placed in the fleet's home Region. Specify a remote location
        /// with an Amazon Web Services Region code such as <code>us-west-2</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property MaximumPlayerSessionCount. 
        /// <para>
        /// The maximum number of players that can be connected simultaneously to the game session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
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
        /// A descriptive label that is associated with a game session. Session names do not need
        /// to be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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