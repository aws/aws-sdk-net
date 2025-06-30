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
    /// Configuration for using Amazon Bedrock foundation models to rerank Knowledge Base
    /// vector search results. This enables more sophisticated relevance ranking using large
    /// language models.
    /// </summary>
    public partial class VectorSearchBedrockRerankingConfiguration
    {
        private MetadataConfigurationForReranking _metadataConfiguration;
        private VectorSearchBedrockRerankingModelConfiguration _modelConfiguration;
        private int? _numberOfRerankedResults;

        /// <summary>
        /// Gets and sets the property MetadataConfiguration. 
        /// <para>
        /// Configuration for how document metadata should be used during the reranking process.
        /// This determines which metadata fields are included when reordering search results.
        /// </para>
        /// </summary>
        public MetadataConfigurationForReranking MetadataConfiguration
        {
            get { return this._metadataConfiguration; }
            set { this._metadataConfiguration = value; }
        }

        // Check to see if MetadataConfiguration property is set
        internal bool IsSetMetadataConfiguration()
        {
            return this._metadataConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ModelConfiguration. 
        /// <para>
        /// Configuration for the Amazon Bedrock foundation model used for reranking. This includes
        /// the model ARN and any additional request fields required by the model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VectorSearchBedrockRerankingModelConfiguration ModelConfiguration
        {
            get { return this._modelConfiguration; }
            set { this._modelConfiguration = value; }
        }

        // Check to see if ModelConfiguration property is set
        internal bool IsSetModelConfiguration()
        {
            return this._modelConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfRerankedResults. 
        /// <para>
        /// The maximum number of results to rerank. This limits how many of the initial vector
        /// search results will be processed by the reranking model. A smaller number improves
        /// performance but may exclude potentially relevant results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? NumberOfRerankedResults
        {
            get { return this._numberOfRerankedResults; }
            set { this._numberOfRerankedResults = value; }
        }

        // Check to see if NumberOfRerankedResults property is set
        internal bool IsSetNumberOfRerankedResults()
        {
            return this._numberOfRerankedResults.HasValue; 
        }

    }
}