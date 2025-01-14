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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the StartGameSessionPlacement operation.
    /// Makes a request to start a new game session using a game session queue. When processing
    /// a placement request in a queue, Amazon GameLift finds the best possible available
    /// resource to host the game session and prompts the resource to start the game session.
    /// 
    /// 
    ///  
    /// <para>
    ///  <b>Request options</b> 
    /// </para>
    ///  
    /// <para>
    /// Call this API with the following minimum parameters: <i>GameSessionQueueName</i>,
    /// <i>MaximumPlayerSessionCount</i>, and <i>PlacementID</i>. You can also include game
    /// session data (data formatted as strings) or game properties (data formatted as key-value
    /// pairs) to pass to the new game session.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You can change how Amazon GameLift chooses a hosting resource for the new game session.
    /// Prioritizing resources for game session placements is defined when you configure a
    /// game session queue. You can use the default prioritization process or specify a custom
    /// process by providing a <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_PriorityConfiguration.html">
    /// PriorityConfiguration</a> when you create or update a queue.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Prioritize based on resource cost and location, using the queue's configured priority
    /// settings. Call this API with the minimum parameters.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Prioritize based on latency. Include a set of values for <i>PlayerLatencies</i>. You
    /// can provide latency data with or without player session data. This option instructs
    /// Amazon GameLift to reorder the queue's prioritized locations list based on the latency
    /// data. If latency data is provided for multiple players, Amazon GameLift calculates
    /// each location's average latency for all players and reorders to find the lowest latency
    /// across all players. Don't include latency data if you're providing a custom list of
    /// locations.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Prioritize based on a custom list of locations. If you're using a queue that's configured
    /// to prioritize location first (see <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_PriorityConfiguration.html">PriorityConfiguration</a>
    /// for game session queues), use the <i>PriorityConfigurationOverride</i> parameter to
    /// substitute a different location list for this placement request. When prioritizing
    /// placements by location, Amazon GameLift searches each location in prioritized order
    /// to find an available hosting resource for the new game session. You can choose whether
    /// to use the override list for the first placement attempt only or for all attempts.
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// You can request new player sessions for a group of players. Include the <i>DesiredPlayerSessions</i>
    /// parameter and include at minimum a unique player ID for each. You can also include
    /// player-specific data to pass to the new game session. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Result</b> 
    /// </para>
    ///  
    /// <para>
    /// If successful, this request generates a new game session placement request and adds
    /// it to the game session queue for Amazon GameLift to process in turn. You can track
    /// the status of individual placement requests by calling <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeGameSessionPlacement.html">DescribeGameSessionPlacement</a>.
    /// A new game session is running if the status is <c>FULFILLED</c> and the request returns
    /// the game session connection information (IP address and port). If you include player
    /// session data, Amazon GameLift creates a player session for each player ID in the request.
    /// </para>
    ///  
    /// <para>
    /// The request results in a <c>BadRequestException</c> in the following situations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If the request includes both <i>PlayerLatencies</i> and <i>PriorityConfigurationOverride</i>
    /// parameters.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the request includes the <i>PriorityConfigurationOverride</i> parameter and designates
    /// a queue doesn't prioritize locations.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Amazon GameLift continues to retry each placement request until it reaches the queue's
    /// timeout setting. If a request times out, you can resubmit the request to the same
    /// queue or try a different queue. 
    /// </para>
    /// </summary>
    public partial class StartGameSessionPlacementRequest : AmazonGameLiftRequest
    {
        private List<DesiredPlayerSession> _desiredPlayerSessions = AWSConfigs.InitializeCollections ? new List<DesiredPlayerSession>() : null;
        private List<GameProperty> _gameProperties = AWSConfigs.InitializeCollections ? new List<GameProperty>() : null;
        private string _gameSessionData;
        private string _gameSessionName;
        private string _gameSessionQueueName;
        private int? _maximumPlayerSessionCount;
        private string _placementId;
        private List<PlayerLatency> _playerLatencies = AWSConfigs.InitializeCollections ? new List<PlayerLatency>() : null;
        private PriorityConfigurationOverride _priorityConfigurationOverride;

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
            return this._desiredPlayerSessions != null && (this._desiredPlayerSessions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GameProperties. 
        /// <para>
        /// A set of key-value pairs that can store custom data in a game session. For example:
        /// <c>{"Key": "difficulty", "Value": "novice"}</c>.
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
            return this._gameProperties != null && (this._gameProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GameSessionData. 
        /// <para>
        /// A set of custom game session properties, formatted as a single string value. This
        /// data is passed to a game server process with a request to start a new game session.
        /// For more information, see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-sdk-server-api.html#gamelift-sdk-server-startsession">Start
        /// a game session</a>.
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
        /// Name of the queue to use to place the new game session. You can use either the queue
        /// name or ARN value. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// Gets and sets the property PlacementId. 
        /// <para>
        /// A unique identifier to assign to the new game session placement. This value is developer-defined.
        /// The value must be unique across all Regions and cannot be reused.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=48)]
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
        /// a player experiences when connected to Amazon Web Services Regions. This information
        /// is used to try to place the new game session where it can offer the best possible
        /// gameplay experience for the players. 
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
            return this._playerLatencies != null && (this._playerLatencies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PriorityConfigurationOverride. 
        /// <para>
        /// A prioritized list of locations to use for the game session placement and instructions
        /// on how to use it. This list overrides a queue's prioritized location list for this
        /// game session placement request only. You can include Amazon Web Services Regions,
        /// local zones, and custom locations (for Anywhere fleets). Choose a fallback strategy
        /// to instruct Amazon GameLift to use the override list for the first placement attempt
        /// only or for all placement attempts.
        /// </para>
        /// </summary>
        public PriorityConfigurationOverride PriorityConfigurationOverride
        {
            get { return this._priorityConfigurationOverride; }
            set { this._priorityConfigurationOverride = value; }
        }

        // Check to see if PriorityConfigurationOverride property is set
        internal bool IsSetPriorityConfigurationOverride()
        {
            return this._priorityConfigurationOverride != null;
        }

    }
}