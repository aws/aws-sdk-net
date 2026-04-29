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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Configuration for memory retrieval within a namespace.
    /// </summary>
    public partial class HarnessAgentCoreMemoryRetrievalConfig
    {
        private float? _relevanceScore;
        private string _strategyId;
        private int? _topk;

        /// <summary>
        /// Gets and sets the property RelevanceScore. 
        /// <para>
        /// The minimum relevance score for retrieved memories.
        /// </para>
        /// </summary>
        public float? RelevanceScore
        {
            get { return this._relevanceScore; }
            set { this._relevanceScore = value; }
        }

        // Check to see if RelevanceScore property is set
        internal bool IsSetRelevanceScore()
        {
            return this._relevanceScore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StrategyId. 
        /// <para>
        /// The ID of the retrieval strategy to use.
        /// </para>
        /// </summary>
        public string StrategyId
        {
            get { return this._strategyId; }
            set { this._strategyId = value; }
        }

        // Check to see if StrategyId property is set
        internal bool IsSetStrategyId()
        {
            return this._strategyId != null;
        }

        /// <summary>
        /// Gets and sets the property TopK. 
        /// <para>
        /// The maximum number of memory entries to retrieve.
        /// </para>
        /// </summary>
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