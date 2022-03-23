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
 * Do not modify this file. This file is generated from the gamesparks-2021-08-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameSparks.Model
{
    /// <summary>
    /// This is the response object from the ListGames operation.
    /// </summary>
    public partial class ListGamesResponse : AmazonWebServiceResponse
    {
        private List<GameSummary> _games = new List<GameSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Games. 
        /// <para>
        /// The list of games.
        /// </para>
        /// </summary>
        public List<GameSummary> Games
        {
            get { return this._games; }
            set { this._games = value; }
        }

        // Check to see if Games property is set
        internal bool IsSetGames()
        {
            return this._games != null && this._games.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token that indicates the start of the next sequential page of results.
        /// </para>
        ///  
        /// <para>
        ///  Use this value when making the next call to this operation to continue where the
        /// last one finished. 
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