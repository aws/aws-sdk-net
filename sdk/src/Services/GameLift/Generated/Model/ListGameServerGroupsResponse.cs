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
    /// This is the response object from the ListGameServerGroups operation.
    /// </summary>
    public partial class ListGameServerGroupsResponse : AmazonWebServiceResponse
    {
        private List<GameServerGroup> _gameServerGroups = new List<GameServerGroup>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property GameServerGroups. 
        /// <para>
        /// The game server groups' game server groups.
        /// </para>
        /// </summary>
        public List<GameServerGroup> GameServerGroups
        {
            get { return this._gameServerGroups; }
            set { this._gameServerGroups = value; }
        }

        // Check to see if GameServerGroups property is set
        internal bool IsSetGameServerGroups()
        {
            return this._gameServerGroups != null && this._gameServerGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Specify the pagination token from a previous request to retrieve the next page of
        /// results.
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

    }
}