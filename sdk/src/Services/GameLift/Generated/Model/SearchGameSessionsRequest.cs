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
    /// Retrieves a list of game sessions in a fleet that match a set of search criteria and
    /// sorts them in a specified order. Currently game session searches are limited to a
    /// single fleet. Search results include only game sessions that are in ACTIVE status.
    /// 
    ///  
    /// <para>
    /// You can search or sort by the following game session attributes:
    /// </para>
    ///  <ul> <li> <b>gameSessionId</b> -- ID value assigned to a game session. This unique
    /// value is returned in a <a>GameSession</a> object when a new game session is created.
    /// </li> <li> <b>gameSessionName</b> -- Name assigned to a game session. This value is
    /// set when requesting a new game session with <a>CreateGameSession</a> or updating with
    /// <a>UpdateGameSession</a>. Game session names do not need to be unique to a game session.</li>
    /// <li> <b>creationTimeMillis</b> -- Value indicating when a game session was created.
    /// It is expressed in Unix time as milliseconds.</li> <li> <b>playerSessionCount</b>
    /// -- Number of players currently connected to a game session. This value changes rapidly
    /// as players join the session or drop out.</li> <li> <b>maximumSessions</b> -- Maximum
    /// number of player sessions allowed for a game session. This value is set when requesting
    /// a new game session with <a>CreateGameSession</a> or updating with <a>UpdateGameSession</a>.</li>
    /// <li> <b>hasAvailablePlayerSessions</b> -- Boolean value indicating whether or not
    /// a game session has reached its maximum number of players. When searching with this
    /// attribute, the search value must be <code>true</code> or <code>false</code>. It is
    /// highly recommended that all search requests include this filter attribute to optimize
    /// search performance and return only sessions that players can join. </li> </ul> 
    /// <para>
    /// To search or sort, specify either a fleet ID or an alias ID, and provide a search
    /// filter expression, a sort expression, or both. Use the pagination parameters to retrieve
    /// results as a set of sequential pages. If successful, a collection of <a>GameSession</a>
    /// objects matching the request is returned.
    /// </para>
    ///  <note> 
    /// <para>
    /// Returned values for <code>playerSessionCount</code> and <code>hasAvailablePlayerSessions</code>
    /// change quickly as players join sessions and others drop out. Results should be considered
    /// a snapshot in time. Be sure to refresh search results often, and handle sessions that
    /// fill up before a player can join. 
    /// </para>
    ///  </note>
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
        /// Unique identifier for a fleet alias. Each request must reference either a fleet ID
        /// or alias ID, but not both.
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
        /// in ACTIVE status. 
        /// </para>
        ///  
        /// <para>
        /// A filter expression can contain one or multiple conditions. Each condition consists
        /// of the following:
        /// </para>
        ///  <ul> <li> <b>Operand</b> -- Name of a game session attribute. Valid values are <code>gameSessionName</code>,
        /// <code>gameSessionId</code>, <code>creationTimeMillis</code>, <code>playerSessionCount</code>,
        /// <code>maximumSessions</code>, <code>hasAvailablePlayerSessions</code>.</li> <li> <b>Comparator</b>
        /// -- Valid comparators are: <code>=</code>, <code>&amp;lt;&amp;gt;</code>, <code>&amp;lt;</code>,
        /// <code>&amp;gt;</code>, <code>&amp;lt;=</code>, <code>&amp;gt;=</code>. </li> <li>
        /// <b>Value</b> -- Value to be searched for. Values can be numbers, boolean values (true/false)
        /// or strings. String values are case sensitive, enclosed in single quotes. Special characters
        /// must be escaped. Boolean and string values can only be used with the comparators <code>=</code>
        /// and <code>&amp;lt;&amp;gt;</code>. For example, the following filter expression searches
        /// on <code>gameSessionName</code>: "<code>FilterExpression": "gameSessionName = 'Matt\\'s
        /// Awesome Game 1'"</code>. </li> </ul> 
        /// <para>
        /// To chain multiple conditions in a single expression, use the logical keywords <code>AND</code>,
        /// <code>OR</code>, and <code>NOT</code> and parentheses as needed. For example: <code>x
        /// AND y AND NOT z</code>, <code>NOT (x OR y)</code>.
        /// </para>
        ///  
        /// <para>
        ///  Session search evaluates conditions from left to right using the following precedence
        /// rules: 
        /// </para>
        ///  <ol> <li> <code>=</code>, <code>&amp;lt;&amp;gt;</code>, <code>&amp;lt;</code>, <code>&amp;gt;</code>,
        /// <code>&amp;lt;=</code>, <code>&amp;gt;=</code> </li> <li>Parentheses </li> <li>NOT</li>
        /// <li>AND</li> <li>OR</li> </ol> 
        /// <para>
        /// For example, this filter expression retrieves game sessions hosting at least ten players
        /// that have an open player slot: <code>"maximumSessions&amp;gt;=10 AND hasAvailablePlayerSessions=true"</code>.
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
        /// Unique identifier for a fleet. Each request must reference either a fleet ID or alias
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
        /// Token indicating the start of the next sequential page of results. Use the token that
        /// is returned with a previous call to this action. To specify the start of the result
        /// set, do not specify a value.
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
        ///  <ul> <li> <b>Operand</b> -- Name of a game session attribute. Valid values are <code>gameSessionName</code>,
        /// <code>gameSessionId</code>, <code>creationTimeMillis</code>, <code>playerSessionCount</code>,
        /// <code>maximumSessions</code>, <code>hasAvailablePlayerSessions</code>.</li> <li> <b>Order</b>
        /// -- Valid sort orders are <code>ASC</code> (ascending) and <code>DESC</code> (descending).</li>
        /// </ul> 
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