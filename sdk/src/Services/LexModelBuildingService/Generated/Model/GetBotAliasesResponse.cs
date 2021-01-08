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
    /// This is the response object from the GetBotAliases operation.
    /// </summary>
    public partial class GetBotAliasesResponse : AmazonWebServiceResponse
    {
        private List<BotAliasMetadata> _botAliases = new List<BotAliasMetadata>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property BotAliases. 
        /// <para>
        /// An array of <code>BotAliasMetadata</code> objects, each describing a bot alias.
        /// </para>
        /// </summary>
        public List<BotAliasMetadata> BotAliases
        {
            get { return this._botAliases; }
            set { this._botAliases = value; }
        }

        // Check to see if BotAliases property is set
        internal bool IsSetBotAliases()
        {
            return this._botAliases != null && this._botAliases.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token for fetching next page of aliases. If the response to this call
        /// is truncated, Amazon Lex returns a pagination token in the response. To fetch the
        /// next page of aliases, specify the pagination token in the next request. 
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