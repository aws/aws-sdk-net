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
    /// Configuration for managed search in a knowledge base. Managed search automatically
    /// determines the best search strategy based on your data store configuration.
    /// </summary>
    public partial class ManagedSearchConfiguration
    {
        private RetrievalFilter _filter;
        private int? _numberOfResults;
        private ManagedSearchRerankingConfiguration _rerankingConfiguration;
        private RerankingModelType _rerankingModelType;

        /// <summary>
        /// Gets and sets the property Filter.
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
        /// The number of results to retrieve.
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
        /// Gets and sets the property RerankingConfiguration. 
        /// <para>
        /// Contains configurations for reranking the results retrieved from the managed search.
        /// </para>
        /// </summary>
        public ManagedSearchRerankingConfiguration RerankingConfiguration
        {
            get { return this._rerankingConfiguration; }
            set { this._rerankingConfiguration = value; }
        }

        // Check to see if RerankingConfiguration property is set
        internal bool IsSetRerankingConfiguration()
        {
            return this._rerankingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RerankingModelType. 
        /// <para>
        /// The type of reranking model to use when reranking results retrieved from the managed
        /// search. Use <c>CUSTOM</c> to specify a model, <c>MANAGED</c> to use the service default,
        /// or <c>NONE</c> to disable reranking.
        /// </para>
        /// </summary>
        public RerankingModelType RerankingModelType
        {
            get { return this._rerankingModelType; }
            set { this._rerankingModelType = value; }
        }

        // Check to see if RerankingModelType property is set
        internal bool IsSetRerankingModelType()
        {
            return this._rerankingModelType != null;
        }

    }
}