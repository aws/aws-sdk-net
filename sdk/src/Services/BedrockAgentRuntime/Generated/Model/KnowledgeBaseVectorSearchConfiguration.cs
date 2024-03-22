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

namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Configurations for how to carry out the search.
    /// </summary>
    public partial class KnowledgeBaseVectorSearchConfiguration
    {
        private int? _numberOfResults;
        private SearchType _overrideSearchType;

        /// <summary>
        /// Gets and sets the property NumberOfResults. 
        /// <para>
        /// The number of results to return.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>numberOfResults</c> field is currently unsupported for <c>RetrieveAndGenerate</c>.
        /// Don't include it in this field if you are sending a <c>RetrieveAndGenerate</c> request.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public int? NumberOfResults
        {
            get { return this._numberOfResults; }
            set { this._numberOfResults = value; }
        }

        // Check to see if NumberOfResults property is set
        internal bool IsSetNumberOfResults()
        {
            return this._numberOfResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OverrideSearchType. 
        /// <para>
        /// By default, Amazon Bedrock decides a search strategy for you. If you're using an Amazon
        /// OpenSearch Serverless vector store that contains a filterable text field, you can
        /// specify whether to query the knowledge base with a <c>HYBRID</c> search using both
        /// vector embeddings and raw text, or <c>SEMANTIC</c> search using only vector embeddings.
        /// For other vector store configurations, only <c>SEMANTIC</c> search is available. For
        /// more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/knowledge-base-test.html">Test
        /// a knowledge base</a>.
        /// </para>
        /// </summary>
        public SearchType OverrideSearchType
        {
            get { return this._overrideSearchType; }
            set { this._overrideSearchType = value; }
        }

        // Check to see if OverrideSearchType property is set
        internal bool IsSetOverrideSearchType()
        {
            return this._overrideSearchType != null;
        }

    }
}