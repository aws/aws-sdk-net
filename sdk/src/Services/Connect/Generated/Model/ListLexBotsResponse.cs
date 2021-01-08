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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// This is the response object from the ListLexBots operation.
    /// </summary>
    public partial class ListLexBotsResponse : AmazonWebServiceResponse
    {
        private List<LexBot> _lexBots = new List<LexBot>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property LexBots. 
        /// <para>
        /// The the names and regions of the Amazon Lex bots associated with the specified instance.
        /// </para>
        /// </summary>
        public List<LexBot> LexBots
        {
            get { return this._lexBots; }
            set { this._lexBots = value; }
        }

        // Check to see if LexBots property is set
        internal bool IsSetLexBots()
        {
            return this._lexBots != null && this._lexBots.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If there are additional results, this is the token for the next set of results.
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