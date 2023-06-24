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
    /// Container for the parameters to the DescribePlayerSessions operation.
    /// Retrieves properties for one or more player sessions. 
    /// 
    ///  
    /// <para>
    /// This action can be used in the following ways: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// To retrieve a specific player session, provide the player session ID only.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To retrieve all player sessions in a game session, provide the game session ID only.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To retrieve all player sessions for a specific player, provide a player ID only.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To request player sessions, specify either a player session ID, game session ID, or
    /// player ID. You can filter this request by player session status. Use the pagination
    /// parameters to retrieve results as a set of sequential pages. 
    /// </para>
    ///  
    /// <para>
    /// If successful, a <code>PlayerSession</code> object is returned for each session that
    /// matches the request.
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
    public partial class DescribePlayerSessionsRequest : AmazonGameLiftRequest
    {
        private string _gameSessionId;
        private int? _limit;
        private string _nextToken;
        private string _playerId;
        private string _playerSessionId;
        private string _playerSessionStatusFilter;

        /// <summary>
        /// Gets and sets the property GameSessionId. 
        /// <para>
        /// A unique identifier for the game session to retrieve player sessions for.
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
        /// to get results as a set of sequential pages. If a player session ID is specified,
        /// this parameter is ignored.
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates the start of the next sequential page of results. Use the token
        /// that is returned with a previous call to this operation. To start at the beginning
        /// of the result set, do not specify a value. If a player session ID is specified, this
        /// parameter is ignored.
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
        /// Gets and sets the property PlayerId. 
        /// <para>
        /// A unique identifier for a player to retrieve player sessions for.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// A unique identifier for a player session to retrieve.
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
        /// Gets and sets the property PlayerSessionStatusFilter. 
        /// <para>
        /// Player session status to filter results on. Note that when a PlayerSessionId or PlayerId
        /// is provided in a DescribePlayerSessions request, then the PlayerSessionStatusFilter
        /// has no effect on the response.
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
        [AWSProperty(Min=1, Max=1024)]
        public string PlayerSessionStatusFilter
        {
            get { return this._playerSessionStatusFilter; }
            set { this._playerSessionStatusFilter = value; }
        }

        // Check to see if PlayerSessionStatusFilter property is set
        internal bool IsSetPlayerSessionStatusFilter()
        {
            return this._playerSessionStatusFilter != null;
        }

    }
}