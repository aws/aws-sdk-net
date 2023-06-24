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
    /// This is the response object from the DescribeGameServerInstances operation.
    /// </summary>
    public partial class DescribeGameServerInstancesResponse : AmazonWebServiceResponse
    {
        private List<GameServerInstance> _gameServerInstances = new List<GameServerInstance>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property GameServerInstances. 
        /// <para>
        /// The collection of requested game server instances.
        /// </para>
        /// </summary>
        public List<GameServerInstance> GameServerInstances
        {
            get { return this._gameServerInstances; }
            set { this._gameServerInstances = value; }
        }

        // Check to see if GameServerInstances property is set
        internal bool IsSetGameServerInstances()
        {
            return this._gameServerInstances != null && this._gameServerInstances.Count > 0; 
        }

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

    }
}