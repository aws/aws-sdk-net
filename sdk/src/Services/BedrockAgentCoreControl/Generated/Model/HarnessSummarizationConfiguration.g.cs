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
    /// Configuration for summarization-based truncation strategy.
    /// </summary>
    public partial class HarnessSummarizationConfiguration
    {
        /// <summary>
        /// Gets and sets the property PreserveRecentMessages. 
        /// <para>
        /// The number of recent messages to preserve without summarization.
        /// </para>
        /// </summary>
        public int? PreserveRecentMessages { get; set; }

        /// <summary>
        /// Checks to see if the PreserveRecentMessages property is set.
        /// </summary>
        internal bool IsSetPreserveRecentMessages() => this.PreserveRecentMessages.HasValue;

        /// <summary>
        /// Gets and sets the property SummarizationSystemPrompt. 
        /// <para>
        /// The system prompt used for generating summaries.
        /// </para>
        /// </summary>
        public string SummarizationSystemPrompt { get; set; }

        /// <summary>
        /// Checks to see if the SummarizationSystemPrompt property is set.
        /// </summary>
        internal bool IsSetSummarizationSystemPrompt() => this.SummarizationSystemPrompt != null;

        /// <summary>
        /// Gets and sets the property SummaryRatio. 
        /// <para>
        /// The ratio of content to summarize.
        /// </para>
        /// </summary>
        public float? SummaryRatio { get; set; }

        /// <summary>
        /// Checks to see if the SummaryRatio property is set.
        /// </summary>
        internal bool IsSetSummaryRatio() => this.SummaryRatio.HasValue;
    }
}
