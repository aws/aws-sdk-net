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
    /// Contains input information for creating a memory strategy.
    /// </summary>
    public partial class MemoryStrategyInput
    {
        private CustomMemoryStrategyInput _customMemoryStrategy;
        private SemanticMemoryStrategyInput _semanticMemoryStrategy;
        private SummaryMemoryStrategyInput _summaryMemoryStrategy;
        private UserPreferenceMemoryStrategyInput _userPreferenceMemoryStrategy;

        /// <summary>
        /// Gets and sets the property CustomMemoryStrategy. 
        /// <para>
        /// Input for creating a custom memory strategy.
        /// </para>
        /// </summary>
        public CustomMemoryStrategyInput CustomMemoryStrategy
        {
            get { return this._customMemoryStrategy; }
            set { this._customMemoryStrategy = value; }
        }

        // Check to see if CustomMemoryStrategy property is set
        internal bool IsSetCustomMemoryStrategy()
        {
            return this._customMemoryStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property SemanticMemoryStrategy. 
        /// <para>
        /// Input for creating a semantic memory strategy.
        /// </para>
        /// </summary>
        public SemanticMemoryStrategyInput SemanticMemoryStrategy
        {
            get { return this._semanticMemoryStrategy; }
            set { this._semanticMemoryStrategy = value; }
        }

        // Check to see if SemanticMemoryStrategy property is set
        internal bool IsSetSemanticMemoryStrategy()
        {
            return this._semanticMemoryStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property SummaryMemoryStrategy. 
        /// <para>
        /// Input for creating a summary memory strategy.
        /// </para>
        /// </summary>
        public SummaryMemoryStrategyInput SummaryMemoryStrategy
        {
            get { return this._summaryMemoryStrategy; }
            set { this._summaryMemoryStrategy = value; }
        }

        // Check to see if SummaryMemoryStrategy property is set
        internal bool IsSetSummaryMemoryStrategy()
        {
            return this._summaryMemoryStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property UserPreferenceMemoryStrategy. 
        /// <para>
        /// Input for creating a user preference memory strategy.
        /// </para>
        /// </summary>
        public UserPreferenceMemoryStrategyInput UserPreferenceMemoryStrategy
        {
            get { return this._userPreferenceMemoryStrategy; }
            set { this._userPreferenceMemoryStrategy = value; }
        }

        // Check to see if UserPreferenceMemoryStrategy property is set
        internal bool IsSetUserPreferenceMemoryStrategy()
        {
            return this._userPreferenceMemoryStrategy != null;
        }

    }
}