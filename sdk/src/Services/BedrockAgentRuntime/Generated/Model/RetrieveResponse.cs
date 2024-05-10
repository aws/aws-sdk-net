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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// This is the response object from the Retrieve operation.
    /// </summary>
    public partial class RetrieveResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<KnowledgeBaseRetrievalResult> _retrievalResults = AWSConfigs.InitializeCollections ? new List<KnowledgeBaseRetrievalResult>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If there are more results than can fit in the response, the response returns a <c>nextToken</c>.
        /// Use this token in the <c>nextToken</c> field of another request to retrieve the next
        /// batch of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property RetrievalResults. 
        /// <para>
        /// A list of results from querying the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public List<KnowledgeBaseRetrievalResult> RetrievalResults
        {
            get { return this._retrievalResults; }
            set { this._retrievalResults = value; }
        }

        // Check to see if RetrievalResults property is set
        internal bool IsSetRetrievalResults()
        {
            return this._retrievalResults != null && (this._retrievalResults.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}