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
    /// Container for the parameters to the DescribeGameSessions operation.
    /// Retrieves a set of one or more game sessions in a specific fleet location. You can
    /// optionally filter the results by current game session status. Alternatively, use <a>SearchGameSessions</a>
    /// to request a set of active game sessions that are filtered by certain criteria. To
    /// retrieve the protection policy for game sessions, use <a>DescribeGameSessionDetails</a>.
    /// 
    ///  
    /// <para>
    /// This operation is not designed to be continually called to track game session status.
    /// This practice can cause you to exceed your API limit, which results in errors. Instead,
    /// you must configure configure an Amazon Simple Notification Service (SNS) topic to
    /// receive notifications from FlexMatch or queues. Continuously polling with <code>DescribeGameSessions</code>
    /// should only be used for games in development with low game session usage. 
    /// </para>
    ///  
    /// <para>
    /// This operation can be used in the following ways: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// To retrieve all game sessions that are currently running on all locations in a fleet,
    /// provide a fleet or alias ID, with an optional status filter. This approach returns
    /// all game sessions in the fleet's home Region and all remote locations.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To retrieve all game sessions that are currently running on a specific fleet location,
    /// provide a fleet or alias ID and a location name, with optional status filter. The
    /// location can be the fleet's home Region or any remote location.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To retrieve a specific game session, provide the game session ID. This approach looks
    /// for the game session ID in all fleets that reside in the Amazon Web Services Region
    /// defined in the request.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Use the pagination parameters to retrieve results as a set of sequential pages. 
    /// </para>
    ///  
    /// <para>
    /// If successful, a <code>GameSession</code> object is returned for each game session
    /// that matches the request.
    /// </para>
    ///  
    /// <para>
    /// This operation is not designed to be continually called to track matchmaking ticket
    /// status. This practice can cause you to exceed your API limit, which results in errors.
    /// Instead, as a best practice, set up an Amazon Simple Notification Service to receive
    /// notifications, and provide the topic ARN in the matchmaking configuration. Continuously
    /// poling ticket status with <a>DescribeGameSessions</a> should only be used for games
    /// in development with low matchmaking usage.
    /// </para>
    ///  
    /// <para>
    ///  <i>Available in Amazon Web Services Local.</i> 
    /// </para>
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-sdk-client-api.html#gamelift-sdk-client-api-find">Find
    /// a game session</a> 
    /// </para>
    ///  
    /// <para>
    ///  <b>Related actions</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a>CreateGameSession</a> | <a>DescribeGameSessions</a> | <a>DescribeGameSessionDetails</a>
    /// | <a>SearchGameSessions</a> | <a>UpdateGameSession</a> | <a>GetGameSessionLogUrl</a>
    /// | <a>StartGameSessionPlacement</a> | <a>DescribeGameSessionPlacement</a> | <a>StopGameSessionPlacement</a>
    /// | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
    /// APIs by task</a> 
    /// </para>
    /// </summary>
    public partial class DescribeGameSessionsRequest : AmazonGameLiftRequest
    {
        private string _aliasId;
        private string _fleetId;
        private string _gameSessionId;
        private int? _limit;
        private string _location;
        private string _nextToken;
        private string _statusFilter;

        /// <summary>
        /// Gets and sets the property AliasId. 
        /// <para>
        /// A unique identifier for the alias associated with the fleet to retrieve game sessions
        /// for. You can use either the alias ID or ARN value.
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
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for the fleet to retrieve game sessions for. You can use either
        /// the fleet ID or ARN value. 
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
        /// A unique identifier for the game session to retrieve. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of results to return. Use this parameter with <code>NextToken</code>
        /// to get results as a set of sequential pages.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// A fleet location to get game session details for. You can specify a fleet's home Region
        /// or a remote location. Use the Amazon Web Services Region code format, such as <code>us-west-2</code>.
        /// 
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates the start of the next sequential page of results. Use the token
        /// that is returned with a previous call to this operation. To start at the beginning
        /// of the result set, do not specify a value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property StatusFilter. 
        /// <para>
        /// Game session status to filter results on. You can filter on the following states:
        /// <code>ACTIVE</code>, <code>TERMINATED</code>, <code>ACTIVATING</code>, and <code>TERMINATING</code>.
        /// The last two are transitory and used for only very brief periods of time. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string StatusFilter
        {
            get { return this._statusFilter; }
            set { this._statusFilter = value; }
        }

        // Check to see if StatusFilter property is set
        internal bool IsSetStatusFilter()
        {
            return this._statusFilter != null;
        }

    }
}