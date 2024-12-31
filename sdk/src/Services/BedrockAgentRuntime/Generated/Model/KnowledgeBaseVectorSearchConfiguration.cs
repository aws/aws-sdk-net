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
    /// Configurations for how to perform the search query and return results. For more information,
    /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/kb-test-config.html">Query
    /// configurations</a>.
    /// 
    ///  
    /// <para>
    /// This data type is used in the following API operations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_Retrieve.html#API_agent-runtime_Retrieve_RequestSyntax">Retrieve
    /// request</a> – in the <c>vectorSearchConfiguration</c> field
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_RetrieveAndGenerate.html#API_agent-runtime_RetrieveAndGenerate_RequestSyntax">RetrieveAndGenerate
    /// request</a> – in the <c>vectorSearchConfiguration</c> field
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class KnowledgeBaseVectorSearchConfiguration
    {
        private RetrievalFilter _filter;
        private ImplicitFilterConfiguration _implicitFilterConfiguration;
        private int? _numberOfResults;
        private SearchType _overrideSearchType;
        private VectorSearchRerankingConfiguration _rerankingConfiguration;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// Specifies the filters to use on the metadata in the knowledge base data sources before
        /// returning results. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/kb-test-config.html">Query
        /// configurations</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public RetrievalFilter Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

        /// <summary>
        /// Gets and sets the property ImplicitFilterConfiguration. 
        /// <para>
        /// Settings for implicit filtering.
        /// </para>
        /// </summary>
        public ImplicitFilterConfiguration ImplicitFilterConfiguration
        {
            get { return this._implicitFilterConfiguration; }
            set { this._implicitFilterConfiguration = value; }
        }

        // Check to see if ImplicitFilterConfiguration property is set
        internal bool IsSetImplicitFilterConfiguration()
        {
            return this._implicitFilterConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfResults. 
        /// <para>
        /// The number of source chunks to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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

        /// <summary>
        /// Gets and sets the property RerankingConfiguration. 
        /// <para>
        /// Contains configurations for reranking the retrieved results. For more information,
        /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/rerank.html">Improve
        /// the relevance of query responses with a reranker model</a>.
        /// </para>
        /// </summary>
        public VectorSearchRerankingConfiguration RerankingConfiguration
        {
            get { return this._rerankingConfiguration; }
            set { this._rerankingConfiguration = value; }
        }

        // Check to see if RerankingConfiguration property is set
        internal bool IsSetRerankingConfiguration()
        {
            return this._rerankingConfiguration != null;
        }

    }
}