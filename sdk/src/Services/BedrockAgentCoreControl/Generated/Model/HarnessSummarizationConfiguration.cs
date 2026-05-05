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
    /// Configuration for summarization-based truncation strategy.
    /// </summary>
    public partial class HarnessSummarizationConfiguration
    {
        private int? _preserveRecentMessages;
        private string _summarizationSystemPrompt;
        private float? _summaryRatio;

        /// <summary>
        /// Gets and sets the property PreserveRecentMessages. 
        /// <para>
        /// The number of recent messages to preserve without summarization.
        /// </para>
        /// </summary>
        public int? PreserveRecentMessages
        {
            get { return this._preserveRecentMessages; }
            set { this._preserveRecentMessages = value; }
        }

        // Check to see if PreserveRecentMessages property is set
        internal bool IsSetPreserveRecentMessages()
        {
            return this._preserveRecentMessages.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SummarizationSystemPrompt. 
        /// <para>
        /// The system prompt used for generating summaries.
        /// </para>
        /// </summary>
        public string SummarizationSystemPrompt
        {
            get { return this._summarizationSystemPrompt; }
            set { this._summarizationSystemPrompt = value; }
        }

        // Check to see if SummarizationSystemPrompt property is set
        internal bool IsSetSummarizationSystemPrompt()
        {
            return this._summarizationSystemPrompt != null;
        }

        /// <summary>
        /// Gets and sets the property SummaryRatio. 
        /// <para>
        /// The ratio of content to summarize.
        /// </para>
        /// </summary>
        public float? SummaryRatio
        {
            get { return this._summaryRatio; }
            set { this._summaryRatio = value; }
        }

        // Check to see if SummaryRatio property is set
        internal bool IsSetSummaryRatio()
        {
            return this._summaryRatio.HasValue; 
        }

    }
}