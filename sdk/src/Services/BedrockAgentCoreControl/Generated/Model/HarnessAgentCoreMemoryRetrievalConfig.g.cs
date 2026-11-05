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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property RelevanceScore. 
        /// <para>
        /// The minimum relevance score for retrieved memories.
        /// </para>
        /// </summary>
        public float? RelevanceScore { get; set; }

        /// <summary>
        /// Checks to see if the RelevanceScore property is set.
        /// </summary>
        internal bool IsSetRelevanceScore() => this.RelevanceScore.HasValue;

        /// <summary>
        /// Gets and sets the property StrategyId. 
        /// <para>
        /// The ID of the retrieval strategy to use.
        /// </para>
        /// </summary>
        public string StrategyId { get; set; }

        /// <summary>
        /// Checks to see if the StrategyId property is set.
        /// </summary>
        internal bool IsSetStrategyId() => this.StrategyId != null;

        /// <summary>
        /// Gets and sets the property TopK. 
        /// <para>
        /// The maximum number of memory entries to retrieve.
        /// </para>
        /// </summary>
        public int? TopK { get; set; }

        /// <summary>
        /// Checks to see if the TopK property is set.
        /// </summary>
        internal bool IsSetTopK() => this.TopK.HasValue;
    }
}
