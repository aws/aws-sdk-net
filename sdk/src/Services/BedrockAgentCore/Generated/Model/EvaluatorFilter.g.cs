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
    /// A condition on a session's evaluation result.
    /// </summary>
    public partial class EvaluatorFilter
    {
        /// <summary>
        /// Gets and sets the property Aggregation. 
        /// <para>
        /// How to combine the evaluator's per-trace or per-span results into one result for the
        /// session. Required for an evaluator that scores traces or spans. Don't specify it for
        /// an evaluator that scores sessions.
        /// </para>
        /// </summary>
        public ResultAggregation Aggregation { get; set; }

        /// <summary>
        /// Checks to see if the Aggregation property is set.
        /// </summary>
        internal bool IsSetAggregation() => this.Aggregation != null;

        /// <summary>
        /// Gets and sets the property EvaluationDimensionName. 
        /// <para>
        /// The dimension of the evaluator's result to compare. Required for an evaluator that
        /// scores more than one dimension. Don't specify it for any other evaluator.
        /// </para>
        /// </summary>
        public string EvaluationDimensionName { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationDimensionName property is set.
        /// </summary>
        internal bool IsSetEvaluationDimensionName() => this.EvaluationDimensionName != null;

        /// <summary>
        /// Gets and sets the property EvaluatorId. 
        /// <para>
        /// The unique identifier of the evaluator whose result to compare.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 111)]
        public string EvaluatorId { get; set; }

        /// <summary>
        /// Checks to see if the EvaluatorId property is set.
        /// </summary>
        internal bool IsSetEvaluatorId() => this.EvaluatorId != null;

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// How to compare the evaluation result with <c>value</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GenerationFilterOperator Operator { get; set; }

        /// <summary>
        /// Checks to see if the Operator property is set.
        /// </summary>
        internal bool IsSetOperator() => this.Operator != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value to compare the evaluation result with. Use <c>doubleValue</c> for a score
        /// and <c>stringValue</c> for a label. <c>booleanValue</c> isn't supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GenerationFilterValue Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
