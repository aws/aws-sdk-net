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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// This is the response object from the GetBots operation.
    /// </summary>
    public partial class GetBotsResponse : AmazonWebServiceResponse
    {
        private List<BotMetadata> _bots = new List<BotMetadata>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Bots. 
        /// <para>
        /// An array of <code>botMetadata</code> objects, with one entry for each bot. 
        /// </para>
        /// </summary>
        public List<BotMetadata> Bots
        {
            get { return this._bots; }
            set { this._bots = value; }
        }

        // Check to see if Bots property is set
        internal bool IsSetBots()
        {
            return this._bots != null && this._bots.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response is truncated, it includes a pagination token that you can specify
        /// in your next request to fetch the next page of bots. 
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

    }
}