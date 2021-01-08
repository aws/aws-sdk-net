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
    /// This is the response object from the GetBuiltinIntents operation.
    /// </summary>
    public partial class GetBuiltinIntentsResponse : AmazonWebServiceResponse
    {
        private List<BuiltinIntentMetadata> _intents = new List<BuiltinIntentMetadata>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Intents. 
        /// <para>
        /// An array of <code>builtinIntentMetadata</code> objects, one for each intent in the
        /// response.
        /// </para>
        /// </summary>
        public List<BuiltinIntentMetadata> Intents
        {
            get { return this._intents; }
            set { this._intents = value; }
        }

        // Check to see if Intents property is set
        internal bool IsSetIntents()
        {
            return this._intents != null && this._intents.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token that fetches the next page of intents. If the response to this
        /// API call is truncated, Amazon Lex returns a pagination token in the response. To fetch
        /// the next page of intents, specify the pagination token in the next request.
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