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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// The configuration details for returning the results from the knowledge base vector
    /// search.
    /// </summary>
    public partial class KnowledgeBaseVectorSearchConfiguration
    {
        private RetrievalFilter _filter;
        private int? _numberOfResults;
        private SearchType _overrideSearchType;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// Specifies the filters to use on the metadata fields in the knowledge base data sources
        /// before returning results.
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
        /// Gets and sets the property NumberOfResults. 
        /// <para>
        /// The number of text chunks to retrieve; the number of results to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int NumberOfResults
        {
            get { return this._numberOfResults.GetValueOrDefault(); }
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
        /// For other vector store configurations, only <c>SEMANTIC</c> search is available.
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