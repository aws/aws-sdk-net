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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Conditions that a session must meet to be selected. A session must meet every condition
    /// you specify. Attribute and turn count filters work with any source. Evaluator filters
    /// need a source that has evaluation results.
    /// </summary>
    public partial class GenerationFilters
    {
        /// <summary>
        /// Gets and sets the property AttributeFilters. 
        /// <para>
        /// Attribute conditions, up to 5. A session must meet all of them. An attribute on a
        /// span matches when any span in the session meets the condition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 5)]
        public List<GenerationAttributeFilter> AttributeFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<GenerationAttributeFilter>() : null;

        /// <summary>
        /// Checks to see if the AttributeFilters property is set.
        /// </summary>
        internal bool IsSetAttributeFilters() => this.AttributeFilters != null && (this.AttributeFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EvaluatorFilters. 
        /// <para>
        /// Conditions on evaluation results, up to 10. A session must meet all of them. You can
        /// use these only with an <c>onlineEvaluation</c> or <c>batchEvaluation</c> source. A
        /// <c>cloudWatchLogs</c> source has no evaluation results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<EvaluatorFilter> EvaluatorFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<EvaluatorFilter>() : null;

        /// <summary>
        /// Checks to see if the EvaluatorFilters property is set.
        /// </summary>
        internal bool IsSetEvaluatorFilters() => this.EvaluatorFilters != null && (this.EvaluatorFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TurnCount. 
        /// <para>
        /// The range of turns a session can have. For example, set <c>max</c> to 1 for single-turn
        /// sessions only, or <c>min</c> to 2 for multi-turn sessions only. Sessions with more
        /// than 100 turns are never selected.
        /// </para>
        /// </summary>
        public TurnCountRange TurnCount { get; set; }

        /// <summary>
        /// Checks to see if the TurnCount property is set.
        /// </summary>
        internal bool IsSetTurnCount() => this.TurnCount != null;
    }
}
