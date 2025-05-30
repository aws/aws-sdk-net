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
    /// Container for the parameters to the SearchGameSessions operation.
    /// Retrieves all active game sessions that match a set of search criteria and sorts them
    /// into a specified order. 
    /// 
    ///  
    /// <para>
    /// This operation is not designed to continually track game session status because that
    /// practice can cause you to exceed your API limit and generate errors. Instead, configure
    /// an Amazon Simple Notification Service (Amazon SNS) topic to receive notifications
    /// from a matchmaker or a game session placement queue.
    /// </para>
    ///  
    /// <para>
    /// When searching for game sessions, you specify exactly where you want to search and
    /// provide a search filter expression, a sort expression, or both. A search request can
    /// search only one fleet, but it can search all of a fleet's locations. 
    /// </para>
    ///  
    /// <para>
    /// This operation can be used in the following ways: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// To search all game sessions that are currently running on all locations in a fleet,
    /// provide a fleet or alias ID. This approach returns game sessions in the fleet's home
    /// Region and all remote locations that fit the search criteria.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To search all game sessions that are currently running on a specific fleet location,
    /// provide a fleet or alias ID and a location name. For location, you can specify a fleet's
    /// home Region or any remote location.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Use the pagination parameters to retrieve results as a set of sequential pages. 
    /// </para>
    ///  
    /// <para>
    /// If successful, a <c>GameSession</c> object is returned for each game session that
    /// matches the request. Search finds game sessions that are in <c>ACTIVE</c> status only.
    /// To retrieve information on game sessions in other statuses, use <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeGameSessions.html">DescribeGameSessions</a>.
    /// </para>
    ///  
    /// <para>
    /// To set search and sort criteria, create a filter expression using the following game
    /// session attributes. For game session search examples, see the Examples section of
    /// this topic.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>gameSessionId</b> -- A unique identifier for the game session. You can use either
    /// a <c>GameSessionId</c> or <c>GameSessionArn</c> value. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>gameSessionName</b> -- Name assigned to a game session. Game session names do
    /// not need to be unique to a game session.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>gameSessionProperties</b> -- A set of key-value pairs that can store custom data
    /// in a game session. For example: <c>{"Key": "difficulty", "Value": "novice"}</c>. The
    /// filter expression must specify the <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_GameProperty">https://docs.aws.amazon.com/gamelift/latest/apireference/API_GameProperty</a>
    /// -- a <c>Key</c> and a string <c>Value</c> to search for the game sessions.
    /// </para>
    ///  
    /// <para>
    /// For example, to search for the above key-value pair, specify the following search
    /// filter: <c>gameSessionProperties.difficulty = "novice"</c>. All game property values
    /// are searched as strings.
    /// </para>
    ///  
    /// <para>
    ///  For examples of searching game sessions, see the ones below, and also see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-sdk-client-api.html#game-properties-search">Search
    /// game sessions by game property</a>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>maximumSessions</b> -- Maximum number of player sessions allowed for a game session.
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
    /// Returned values for <c>playerSessionCount</c> and <c>hasAvailablePlayerSessions</c>
    /// change quickly as players join sessions and others drop out. Results should be considered
    /// a snapshot in time. Be sure to refresh search results often, and handle sessions that
    /// fill up before a player can join. 
    /// </para>
    ///  </note> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
    /// APIs by task</a> 
    /// </para>
    /// </summary>
    public partial class SearchGameSessionsRequest : AmazonGameLiftRequest
    {
        private string _aliasId;
        private string _filterExpression;
        private string _fleetId;
        private int? _limit;
        private string _location;
        private string _nextToken;
        private string _sortExpression;

        /// <summary>
        /// Gets and sets the property AliasId. 
        /// <para>
        /// A unique identifier for the alias associated with the fleet to search for active game
        /// sessions. You can use either the alias ID or ARN value. Each request must reference
        /// either a fleet ID or alias ID, but not both.
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
        /// in <c>ACTIVE</c> status.
        /// </para>
        ///  
        /// <para>
        /// A filter expression can contain one or multiple conditions. Each condition consists
        /// of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Operand</b> -- Name of a game session attribute. Valid values are <c>gameSessionName</c>,
        /// <c>gameSessionId</c>, <c>gameSessionProperties</c>, <c>maximumSessions</c>, <c>creationTimeMillis</c>,
        /// <c>playerSessionCount</c>, <c>hasAvailablePlayerSessions</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Comparator</b> -- Valid comparators are: <c>=</c>, <c>&lt;&gt;</c>, <c>&lt;</c>,
        /// <c>&gt;</c>, <c>&lt;=</c>, <c>&gt;=</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Value</b> -- Value to be searched for. Values may be numbers, boolean values (true/false)
        /// or strings depending on the operand. String values are case sensitive and must be
        /// enclosed in single quotes. Special characters must be escaped. Boolean and string
        /// values can only be used with the comparators <c>=</c> and <c>&lt;&gt;</c>. For example,
        /// the following filter expression searches on <c>gameSessionName</c>: "<c>FilterExpression":
        /// "gameSessionName = 'Matt\\'s Awesome Game 1'"</c>. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To chain multiple conditions in a single expression, use the logical keywords <c>AND</c>,
        /// <c>OR</c>, and <c>NOT</c> and parentheses as needed. For example: <c>x AND y AND NOT
        /// z</c>, <c>NOT (x OR y)</c>.
        /// </para>
        ///  
        /// <para>
        /// Session search evaluates conditions from left to right using the following precedence
        /// rules:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        ///  <c>=</c>, <c>&lt;&gt;</c>, <c>&lt;</c>, <c>&gt;</c>, <c>&lt;=</c>, <c>&gt;=</c> 
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
        /// that have an open player slot: <c>"maximumSessions&gt;=10 AND hasAvailablePlayerSessions=true"</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// A unique identifier for the fleet to search for active game sessions. You can use
        /// either the fleet ID or ARN value. Each request must reference either a fleet ID or
        /// alias ID, but not both.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
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
        /// The maximum number of results to return. Use this parameter with <c>NextToken</c>
        /// to get results as a set of sequential pages. The maximum number of results returned
        /// is 20, even if this value is not set or is set higher than 20. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? Limit
        {
            get { return this._limit; }
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
        /// A fleet location to search for game sessions. You can specify a fleet's home Region
        /// or a remote location. Use the Amazon Web Services Region code format, such as <c>us-west-2</c>.
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
        /// Gets and sets the property SortExpression. 
        /// <para>
        /// Instructions on how to sort the search results. If no sort expression is included,
        /// the request returns results in random order. A sort expression consists of the following
        /// elements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Operand</b> -- Name of a game session attribute. Valid values are <c>gameSessionName</c>,
        /// <c>gameSessionId</c>, <c>gameSessionProperties</c>, <c>maximumSessions</c>, <c>creationTimeMillis</c>,
        /// <c>playerSessionCount</c>, <c>hasAvailablePlayerSessions</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Order</b> -- Valid sort orders are <c>ASC</c> (ascending) and <c>DESC</c> (descending).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For example, this sort expression returns the oldest active sessions first: <c>"SortExpression":
        /// "creationTimeMillis ASC"</c>. Results with a null value for the sort operand are returned
        /// at the end of the list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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