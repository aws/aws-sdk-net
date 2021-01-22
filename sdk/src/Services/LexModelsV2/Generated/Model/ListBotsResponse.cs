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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// This is the response object from the ListBots operation.
    /// </summary>
    public partial class ListBotsResponse : AmazonWebServiceResponse
    {
        private List<BotSummary> _botSummaries = new List<BotSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property BotSummaries. 
        /// <para>
        /// Summary information for the bots that meet the filter criteria specified in the request.
        /// The length of the list is specified in the <code>maxResults</code> parameter of the
        /// request. If there are more bots available, the <code>nextToken</code> field contains
        /// a token to the next page of results.
        /// </para>
        /// </summary>
        public List<BotSummary> BotSummaries
        {
            get { return this._botSummaries; }
            set { this._botSummaries = value; }
        }

        // Check to see if BotSummaries property is set
        internal bool IsSetBotSummaries()
        {
            return this._botSummaries != null && this._botSummaries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates whether there are more results to return in a response to the
        /// <code>ListBots</code> operation. If the <code>nextToken</code> field is present, you
        /// send the contents as the <code>nextToken</code> parameter of a <code>ListBots</code>
        /// operation request to get the next page of results.
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