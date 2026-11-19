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

namespace Amazon.OpenSearchMemory.Model
{
    /// <summary>
    /// Settings for a memory strategy. The defaults described here apply when you create
    /// a strategy. In <c>UpdateSpace</c>, a member you omit for a kept strategy keeps its
    /// current value.
    /// </summary>
    public partial class MemoryStrategyConfiguration
    {
        /// <summary>
        /// Gets and sets the property ConsolidationEnabled. 
        /// <para>
        /// Specifies whether the strategy consolidates memories. With consolidation, each new
        /// memory is compared with similar stored memories, and the service adds it, updates
        /// a stored memory, or skips it, so duplicate or contradicting facts don't accumulate.
        /// Without it, every extracted memory is stored as a new memory, which costs less and
        /// keeps a full history.
        /// </para>
        ///  
        /// <para>
        /// When omitted, the default depends on the strategy's type: on for <c>SEMANTIC</c> and
        /// <c>SUMMARY</c>, off for <c>CUSTOM</c>.
        /// </para>
        /// </summary>
        public bool? ConsolidationEnabled { get; set; }

        /// <summary>
        /// Checks to see if the ConsolidationEnabled property is set.
        /// </summary>
        internal bool IsSetConsolidationEnabled() => this.ConsolidationEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property ExtractEveryNMessages. 
        /// <para>
        /// Extract once this many messages have accumulated, from 1 to 1000. Lower values extract
        /// more often, in smaller batches. The default is 12.
        /// </para>
        ///  
        /// <para>
        /// Messages accumulate until the first of <c>extractEveryNMessages</c>, <c>extractEveryNTokens</c>,
        /// and <c>idleTimeoutSeconds</c> is reached. The service then extracts them together
        /// in one pass.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? ExtractEveryNMessages { get; set; }

        /// <summary>
        /// Checks to see if the ExtractEveryNMessages property is set.
        /// </summary>
        internal bool IsSetExtractEveryNMessages() => this.ExtractEveryNMessages.HasValue;

        /// <summary>
        /// Gets and sets the property ExtractEveryNTokens. 
        /// <para>
        /// Extract once this many tokens of conversation have accumulated, from 1 to 80,000,
        /// however few messages that takes. Use it to bound how much text one extraction call
        /// carries when message sizes vary widely. Omit it to bound a batch only by <c>extractEveryNMessages</c>,
        /// <c>idleTimeoutSeconds</c>, and the service's maximum batch size.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 80000)]
        public int? ExtractEveryNTokens { get; set; }

        /// <summary>
        /// Checks to see if the ExtractEveryNTokens property is set.
        /// </summary>
        internal bool IsSetExtractEveryNTokens() => this.ExtractEveryNTokens.HasValue;

        /// <summary>
        /// Gets and sets the property ExtractionPrompt. 
        /// <para>
        /// Instructions that define what a <c>CUSTOM</c> strategy extracts, up to 30,720 characters.
        /// Required for a <c>CUSTOM</c> strategy: <c>CreateSpace</c> and <c>UpdateSpace</c> fail
        /// with <c>ValidationException</c> if a <c>CUSTOM</c> strategy has none.
        /// </para>
        ///  
        /// <para>
        /// Only <c>CUSTOM</c> strategies use it. <c>SEMANTIC</c> and <c>SUMMARY</c> strategies
        /// always extract with the service's built-in instructions: the service accepts and stores
        /// a prompt on them, and <c>GetSpace</c> returns it, but extraction doesn't use it.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 30720)]
        public string ExtractionPrompt { get; set; }

        /// <summary>
        /// Checks to see if the ExtractionPrompt property is set.
        /// </summary>
        internal bool IsSetExtractionPrompt() => this.ExtractionPrompt != null;

        /// <summary>
        /// Gets and sets the property ExtractionSeedRecentN. 
        /// <para>
        /// How many of the strategy's most recent stored memories to include in the extraction
        /// prompt, from 0 to 20. If you omit this or set it to 0, the service uses its default:
        /// no seeding for most strategy types, and the 10 most recent memories for a <c>SUMMARY</c>
        /// strategy when neither seed setting is given. When this and <c>extractionSeedTopK</c>
        /// are both set, the two sets of memories are combined without duplicates.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public int? ExtractionSeedRecentN { get; set; }

        /// <summary>
        /// Checks to see if the ExtractionSeedRecentN property is set.
        /// </summary>
        internal bool IsSetExtractionSeedRecentN() => this.ExtractionSeedRecentN.HasValue;

        /// <summary>
        /// Gets and sets the property ExtractionSeedTopK. 
        /// <para>
        /// How many of the strategy's stored memories that are most relevant to the conversation
        /// to include in the extraction prompt, from 0 to 20, to improve extraction and reduce
        /// duplicates. If you omit this or set it to 0, the service uses its default (see <c>extractionSeedRecentN</c>).
        /// When this and <c>extractionSeedRecentN</c> are both set, the two sets of memories
        /// are combined without duplicates.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public int? ExtractionSeedTopK { get; set; }

        /// <summary>
        /// Checks to see if the ExtractionSeedTopK property is set.
        /// </summary>
        internal bool IsSetExtractionSeedTopK() => this.ExtractionSeedTopK.HasValue;

        /// <summary>
        /// Gets and sets the property IdleTimeoutSeconds. 
        /// <para>
        /// Extract what has accumulated once the conversation has been idle for this many seconds,
        /// from 1 to 86,400. The default is 60. This is what extracts the end of a conversation
        /// that stops. Raise it when the pauses in your conversations are longer than that, so
        /// that one exchange isn't split across several extraction passes.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 86400)]
        public int? IdleTimeoutSeconds { get; set; }

        /// <summary>
        /// Checks to see if the IdleTimeoutSeconds property is set.
        /// </summary>
        internal bool IsSetIdleTimeoutSeconds() => this.IdleTimeoutSeconds.HasValue;
    }
}
