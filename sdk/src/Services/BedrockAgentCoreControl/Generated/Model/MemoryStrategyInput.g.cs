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
    /// Contains input information for creating a memory strategy.
    /// </summary>
    public partial class MemoryStrategyInput
    {
        /// <summary>
        /// Gets and sets the property CustomMemoryStrategy. 
        /// <para>
        /// Input for creating a custom memory strategy.
        /// </para>
        /// </summary>
        public CustomMemoryStrategyInput CustomMemoryStrategy { get; set; }

        /// <summary>
        /// Checks to see if the CustomMemoryStrategy property is set.
        /// </summary>
        internal bool IsSetCustomMemoryStrategy() => this.CustomMemoryStrategy != null;

        /// <summary>
        /// Gets and sets the property EpisodicMemoryStrategy. 
        /// <para>
        /// Input for creating an episodic memory strategy
        /// </para>
        /// </summary>
        public EpisodicMemoryStrategyInput EpisodicMemoryStrategy { get; set; }

        /// <summary>
        /// Checks to see if the EpisodicMemoryStrategy property is set.
        /// </summary>
        internal bool IsSetEpisodicMemoryStrategy() => this.EpisodicMemoryStrategy != null;

        /// <summary>
        /// Gets and sets the property SemanticMemoryStrategy. 
        /// <para>
        /// Input for creating a semantic memory strategy.
        /// </para>
        /// </summary>
        public SemanticMemoryStrategyInput SemanticMemoryStrategy { get; set; }

        /// <summary>
        /// Checks to see if the SemanticMemoryStrategy property is set.
        /// </summary>
        internal bool IsSetSemanticMemoryStrategy() => this.SemanticMemoryStrategy != null;

        /// <summary>
        /// Gets and sets the property SummaryMemoryStrategy. 
        /// <para>
        /// Input for creating a summary memory strategy.
        /// </para>
        /// </summary>
        public SummaryMemoryStrategyInput SummaryMemoryStrategy { get; set; }

        /// <summary>
        /// Checks to see if the SummaryMemoryStrategy property is set.
        /// </summary>
        internal bool IsSetSummaryMemoryStrategy() => this.SummaryMemoryStrategy != null;

        /// <summary>
        /// Gets and sets the property UserPreferenceMemoryStrategy. 
        /// <para>
        /// Input for creating a user preference memory strategy.
        /// </para>
        /// </summary>
        public UserPreferenceMemoryStrategyInput UserPreferenceMemoryStrategy { get; set; }

        /// <summary>
        /// Checks to see if the UserPreferenceMemoryStrategy property is set.
        /// </summary>
        internal bool IsSetUserPreferenceMemoryStrategy() => this.UserPreferenceMemoryStrategy != null;
    }
}
