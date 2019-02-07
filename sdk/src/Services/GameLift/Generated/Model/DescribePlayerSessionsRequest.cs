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
    /// Container for the parameters to the DescribePlayerSessions operation.
    /// Retrieves properties for one or more player sessions. This action can be used in several
    /// ways: (1) provide a <code>PlayerSessionId</code> to request properties for a specific
    /// player session; (2) provide a <code>GameSessionId</code> to request properties for
    /// all player sessions in the specified game session; (3) provide a <code>PlayerId</code>
    /// to request properties for all player sessions of a specified player. 
    /// 
    ///  
    /// <para>
    /// To get game session record(s), specify only one of the following: a player session
    /// ID, a game session ID, or a player ID. You can filter this request by player session
    /// status. Use the pagination parameters to retrieve results as a set of sequential pages.
    /// If successful, a <a>PlayerSession</a> object is returned for each session matching
    /// the request.
    /// </para>
    ///  
    /// <para>
    ///  <i>Available in Amazon GameLift Local.</i> 
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
        /// Unique identifier for the game session to retrieve player sessions for.
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
        /// Gets and sets the property Limit. 
        /// <para>
        /// Maximum number of results to return. Use this parameter with <code>NextToken</code>
        /// to get results as a set of sequential pages. If a player session ID is specified,
        /// this parameter is ignored.
        /// </para>
        /// </summary>
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
        /// Token that indicates the start of the next sequential page of results. Use the token
        /// that is returned with a previous call to this action. To start at the beginning of
        /// the result set, do not specify a value. If a player session ID is specified, this
        /// parameter is ignored.
        /// </para>
        /// </summary>
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
        /// Unique identifier for a player to retrieve player sessions for.
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
        /// Unique identifier for a player session to retrieve.
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
        /// Player session status to filter results on.
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