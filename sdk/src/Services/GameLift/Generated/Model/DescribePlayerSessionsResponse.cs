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
    /// This is the response object from the DescribePlayerSessions operation.
    /// </summary>
    public partial class DescribePlayerSessionsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<PlayerSession> _playerSessions = new List<PlayerSession>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates where to resume retrieving results on the next call to this
        /// operation. If no token is returned, these results represent the end of the list.
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
        /// Gets and sets the property PlayerSessions. 
        /// <para>
        /// A collection of objects containing properties for each player session that matches
        /// the request.
        /// </para>
        /// </summary>
        public List<PlayerSession> PlayerSessions
        {
            get { return this._playerSessions; }
            set { this._playerSessions = value; }
        }

        // Check to see if PlayerSessions property is set
        internal bool IsSetPlayerSessions()
        {
            return this._playerSessions != null && this._playerSessions.Count > 0; 
        }

    }
}