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
    /// Container for the parameters to the ListGameServers operation.
    /// <b>This action is part of Amazon GameLift FleetIQ with game server groups, which
    /// is in preview release and is subject to change.</b> 
    /// 
    ///  
    /// <para>
    /// Retrieves information on all game servers that are currently running in a specified
    /// game server group. If there are custom key sort values for your game servers, you
    /// can opt to have the returned list sorted based on these values. Use the pagination
    /// parameters to retrieve results in a set of sequential pages. 
    /// </para>
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gsg-intro.html">GameLift
    /// FleetIQ Guide</a> 
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>RegisterGameServer</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListGameServers</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ClaimGameServer</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeGameServer</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateGameServer</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeregisterGameServer</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ListGameServersRequest : AmazonGameLiftRequest
    {
        private string _gameServerGroupName;
        private int? _limit;
        private string _nextToken;
        private SortOrder _sortOrder;

        /// <summary>
        /// Gets and sets the property GameServerGroupName. 
        /// <para>
        /// An identifier for the game server group for the game server you want to list. Use
        /// either the <a>GameServerGroup</a> name or ARN value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string GameServerGroupName
        {
            get { return this._gameServerGroupName; }
            set { this._gameServerGroupName = value; }
        }

        // Check to see if GameServerGroupName property is set
        internal bool IsSetGameServerGroupName()
        {
            return this._gameServerGroupName != null;
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates the start of the next sequential page of results. Use the token
        /// that is returned with a previous call to this action. To start at the beginning of
        /// the result set, do not specify a value.
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
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// Indicates how to sort the returned data based on the game servers' custom key sort
        /// value. If this parameter is left empty, the list of game servers is returned in no
        /// particular order.
        /// </para>
        /// </summary>
        public SortOrder SortOrder
        {
            get { return this._sortOrder; }
            set { this._sortOrder = value; }
        }

        // Check to see if SortOrder property is set
        internal bool IsSetSortOrder()
        {
            return this._sortOrder != null;
        }

    }
}