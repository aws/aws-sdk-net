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
    /// Container for the parameters to the DescribeGameSessions operation.
    /// Retrieves properties for one or more game sessions. This action can be used in several
    /// ways: (1) provide a <i>GameSessionId</i> parameter to request properties for a specific
    /// game session; (2) provide a <i>FleetId</i> or <i>AliasId</i> parameter to request
    /// properties for all game sessions running on a fleet. 
    /// 
    ///  
    /// <para>
    /// To get game session record(s), specify only one of the following: game session ID,
    /// fleet ID, or alias ID. You can filter this request by game session status. Use the
    /// pagination parameters to retrieve results as a set of sequential pages. If successful,
    /// a <a>GameSession</a> object is returned for each session matching the request.
    /// </para>
    /// </summary>
    public partial class DescribeGameSessionsRequest : AmazonGameLiftRequest
    {
        private string _aliasId;
        private string _fleetId;
        private string _gameSessionId;
        private int? _limit;
        private string _nextToken;
        private string _statusFilter;

        /// <summary>
        /// Gets and sets the property AliasId. 
        /// <para>
        /// Unique identifier for a fleet alias. Specify an alias to retrieve information on all
        /// game sessions active on the fleet.
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
        /// Unique identifier for a fleet. Specify a fleet to retrieve information on all game
        /// sessions active on the fleet.
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
        /// Unique identifier for a game session. Specify the game session to retrieve information
        /// on.
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
        /// Maximum number of results to return. You can use this parameter with <i>NextToken</i>
        /// to get results as a set of sequential pages.
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
        /// Gets and sets the property StatusFilter. 
        /// <para>
        /// Game session status to filter results on. Possible game session states include ACTIVE,
        /// TERMINATED, ACTIVATING and TERMINATING (the last two are transitory). 
        /// </para>
        /// </summary>
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