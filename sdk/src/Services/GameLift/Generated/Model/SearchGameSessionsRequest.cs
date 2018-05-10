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
    /// Container for the parameters to the SearchGameSessions operation.
    /// Retrieves all active game sessions that match a set of search criteria and sorts them
    /// in a specified order. You can search or sort by the following game session attributes:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <b>gameSessionId</b> -- Unique identifier for the game session. You can use either
    /// a <code>GameSessionId</code> or <code>GameSessionArn</code> value. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>gameSessionName</b> -- Name assigned to a game session. This value is set when
    /// requesting a new game session with <a>CreateGameSession</a> or updating with <a>UpdateGameSession</a>.
    /// Game session names do not need to be unique to a game session.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>gameSessionProperties</b> -- Custom data defined in a game session's <code>GameProperty</code>
    /// parameter. <code>GameProperty</code> values are stored as key:value pairs; the filter
    /// expression must indicate the key and a string to search the data values for. For example,
    /// to search for game sessions with custom data containing the key:value pair "gameMode:brawl",
    /// specify the following: <code>gameSessionProperties.gameMode = "brawl"</code>. All
    /// custom data values are searched as strings.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>maximumSessions</b> -- Maximum number of player sessions allowed for a game session.
    /// This value is set when requesting a new game session with <a>CreateGameSession</a>
    /// or updating with <a>UpdateGameSession</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>creationTimeMillis</b> -- Value indicating when a game session was created. It
    /// is expressed in Unix time as milliseconds.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>playerSessionCount</b> -- Number of players currently connected to a game session.
    /// This value changes rapidly as players join the session or drop out.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>hasAvailablePlayerSessions</b> -- Boolean value indicating whether a game session
    /// has reached its maximum number of players. It is highly recommended that all search
    /// requests include this filter attribute to optimize search performance and return only
    /// sessions that players can join. 
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// Returned values for <code>playerSessionCount</code> and <code>hasAvailablePlayerSessions</code>
    /// change quickly as players join sessions and others drop out. Results should be considered
    /// a snapshot in time. Be sure to refresh search results often, and handle sessions that
    /// fill up before a player can join. 
    /// </para>
    ///  </note> 
    /// <para>
    /// To search or sort, specify either a fleet ID or an alias ID, and provide a search
    /// filter expression, a sort expression, or both. If successful, a collection of <a>GameSession</a>
    /// objects matching the request is returned. Use the pagination parameters to retrieve
    /// results as a set of sequential pages. 
    /// </para>
    ///  
    /// <para>
    /// You can search for game sessions one fleet at a time only. To find game sessions across
    /// multiple fleets, you must search each fleet separately and combine the results. This
    /// search feature finds only game sessions that are in <code>ACTIVE</code> status. To
    /// locate games in statuses other than active, use <a>DescribeGameSessionDetails</a>.
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
    public partial class SearchGameSessionsRequest : AmazonGameLiftRequest
    {
        private string _aliasId;
        private string _filterExpression;
        private string _fleetId;
        private int? _limit;
        private string _nextToken;
        private string _sortExpression;

        /// <summary>
        /// Gets and sets the property AliasId. 
        /// <para>
        /// Unique identifier for an alias associated with the fleet to search for active game
        /// sessions. Each request must reference either a fleet ID or alias ID, but not both.
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
        /// Gets and sets the property FilterExpression. 
        /// <para>
        /// String containing the search criteria for the session search. If no filter expression
        /// is included, the request returns results for all game sessions in the fleet that are
        /// in <code>ACTIVE</code> status.
        /// </para>
        ///  
        /// <para>
        /// A filter expression can contain one or multiple conditions. Each condition consists
        /// of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Operand</b> -- Name of a game session attribute. Valid values are <code>gameSessionName</code>,
        /// <code>gameSessionId</code>, <code>gameSessionProperties</code>, <code>maximumSessions</code>,
        /// <code>creationTimeMillis</code>, <code>playerSessionCount</code>, <code>hasAvailablePlayerSessions</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Comparator</b> -- Valid comparators are: <code>=</code>, <code>&lt;&gt;</code>,
        /// <code>&lt;</code>, <code>&gt;</code>, <code>&lt;=</code>, <code>&gt;=</code>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Value</b> -- Value to be searched for. Values may be numbers, boolean values (true/false)
        /// or strings depending on the operand. String values are case sensitive and must be
        /// enclosed in single quotes. Special characters must be escaped. Boolean and string
        /// values can only be used with the comparators <code>=</code> and <code>&lt;&gt;</code>.
        /// For example, the following filter expression searches on <code>gameSessionName</code>:
        /// "<code>FilterExpression": "gameSessionName = 'Matt\\'s Awesome Game 1'"</code>. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To chain multiple conditions in a single expression, use the logical keywords <code>AND</code>,
        /// <code>OR</code>, and <code>NOT</code> and parentheses as needed. For example: <code>x
        /// AND y AND NOT z</code>, <code>NOT (x OR y)</code>.
        /// </para>
        ///  
        /// <para>
        /// Session search evaluates conditions from left to right using the following precedence
        /// rules:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        ///  <code>=</code>, <code>&lt;&gt;</code>, <code>&lt;</code>, <code>&gt;</code>, <code>&lt;=</code>,
        /// <code>&gt;=</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Parentheses
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NOT
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AND
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OR
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For example, this filter expression retrieves game sessions hosting at least ten players
        /// that have an open player slot: <code>"maximumSessions&gt;=10 AND hasAvailablePlayerSessions=true"</code>.
        /// 
        /// </para>
        /// </summary>
        public string FilterExpression
        {
            get { return this._filterExpression; }
            set { this._filterExpression = value; }
        }

        // Check to see if FilterExpression property is set
        internal bool IsSetFilterExpression()
        {
            return this._filterExpression != null;
        }

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// Unique identifier for a fleet to search for active game sessions. Each request must
        /// reference either a fleet ID or alias ID, but not both.
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
        /// Gets and sets the property Limit. 
        /// <para>
        /// Maximum number of results to return. Use this parameter with <code>NextToken</code>
        /// to get results as a set of sequential pages. The maximum number of results returned
        /// is 20, even if this value is not set or is set higher than 20. 
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
        /// the result set, do not specify a value.
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
        /// Gets and sets the property SortExpression. 
        /// <para>
        /// Instructions on how to sort the search results. If no sort expression is included,
        /// the request returns results in random order. A sort expression consists of the following
        /// elements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Operand</b> -- Name of a game session attribute. Valid values are <code>gameSessionName</code>,
        /// <code>gameSessionId</code>, <code>gameSessionProperties</code>, <code>maximumSessions</code>,
        /// <code>creationTimeMillis</code>, <code>playerSessionCount</code>, <code>hasAvailablePlayerSessions</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Order</b> -- Valid sort orders are <code>ASC</code> (ascending) and <code>DESC</code>
        /// (descending).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For example, this sort expression returns the oldest active sessions first: <code>"SortExpression":
        /// "creationTimeMillis ASC"</code>. Results with a null value for the sort operand are
        /// returned at the end of the list.
        /// </para>
        /// </summary>
        public string SortExpression
        {
            get { return this._sortExpression; }
            set { this._sortExpression = value; }
        }

        // Check to see if SortExpression property is set
        internal bool IsSetSortExpression()
        {
            return this._sortExpression != null;
        }

    }
}