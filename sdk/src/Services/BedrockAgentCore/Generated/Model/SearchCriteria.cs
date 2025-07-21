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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Contains search criteria for retrieving memory records.
    /// </summary>
    public partial class SearchCriteria
    {
        private string _memoryStrategyId;
        private string _searchQuery;
        private int? _topk;

        /// <summary>
        /// Gets and sets the property MemoryStrategyId. 
        /// <para>
        /// The memory strategy identifier to filter memory records by.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string MemoryStrategyId
        {
            get { return this._memoryStrategyId; }
            set { this._memoryStrategyId = value; }
        }

        // Check to see if MemoryStrategyId property is set
        internal bool IsSetMemoryStrategyId()
        {
            return this._memoryStrategyId != null;
        }

        /// <summary>
        /// Gets and sets the property SearchQuery. 
        /// <para>
        /// The search query to use for finding relevant memory records.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=10000)]
        public string SearchQuery
        {
            get { return this._searchQuery; }
            set { this._searchQuery = value; }
        }

        // Check to see if SearchQuery property is set
        internal bool IsSetSearchQuery()
        {
            return this._searchQuery != null;
        }

        /// <summary>
        /// Gets and sets the property TopK. 
        /// <para>
        /// The maximum number of top-scoring memory records to return. This value is used for
        /// semantic search ranking.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? TopK
        {
            get { return this._topk; }
            set { this._topk = value; }
        }

        // Check to see if TopK property is set
        internal bool IsSetTopK()
        {
            return this._topk.HasValue; 
        }

    }
}