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
    /// The comprehensive result of an evaluation containing the score, explanation, evaluator
    /// metadata, and execution details. Provides both quantitative ratings and qualitative
    /// insights about agent performance.
    /// </summary>
    public partial class EvaluationResultContent
    {
        /// <summary>
        /// Gets and sets the property Context. 
        /// <para>
        ///  The contextual information associated with this evaluation result, including span
        /// context details that identify the specific traces and sessions that were evaluated.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Context Context { get; set; }

        /// <summary>
        /// Checks to see if the Context property is set.
        /// </summary>
        internal bool IsSetContext() => this.Context != null;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        ///  The error code indicating the type of failure that occurred during evaluation. Used
        /// to programmatically identify and handle different categories of evaluation errors.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        ///  The error message describing what went wrong if the evaluation failed. Provides detailed
        /// information about evaluation failures to help diagnose and resolve issues with evaluator
        /// configuration or input data. 
        /// </para>
        /// </summary>
        [AWSProperty(Max = 2048)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property EvaluatorArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the evaluator used to generate this result. For
        /// custom evaluators, this is the full ARN; for built-in evaluators, this follows the
        /// pattern <c>Builtin.{EvaluatorName}</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EvaluatorArn { get; set; }

        /// <summary>
        /// Checks to see if the EvaluatorArn property is set.
        /// </summary>
        internal bool IsSetEvaluatorArn() => this.EvaluatorArn != null;

        /// <summary>
        /// Gets and sets the property EvaluatorId. 
        /// <para>
        ///  The unique identifier of the evaluator that produced this result. This matches the
        /// <c>evaluatorId</c> provided in the evaluation request and can be used to identify
        /// which evaluator generated specific results. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 111)]
        public string EvaluatorId { get; set; }

        /// <summary>
        /// Checks to see if the EvaluatorId property is set.
        /// </summary>
        internal bool IsSetEvaluatorId() => this.EvaluatorId != null;

        /// <summary>
        /// Gets and sets the property EvaluatorName. 
        /// <para>
        ///  The human-readable name of the evaluator used for this evaluation. For built-in evaluators,
        /// this is the descriptive name (e.g., "Helpfulness", "Correctness"); for custom evaluators,
        /// this is the user-defined name. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 48)]
        public string EvaluatorName { get; set; }

        /// <summary>
        /// Checks to see if the EvaluatorName property is set.
        /// </summary>
        internal bool IsSetEvaluatorName() => this.EvaluatorName != null;

        /// <summary>
        /// Gets and sets the property Explanation. 
        /// <para>
        ///  The detailed explanation provided by the evaluator describing the reasoning behind
        /// the assigned score. This qualitative feedback helps understand why specific ratings
        /// were given and provides actionable insights for improvement. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 2048)]
        public string Explanation { get; set; }

        /// <summary>
        /// Checks to see if the Explanation property is set.
        /// </summary>
        internal bool IsSetExplanation() => this.Explanation != null;

        /// <summary>
        /// Gets and sets the property IgnoredReferenceInputFields. 
        /// <para>
        ///  The list of reference input field names that were provided but not used by the evaluator.
        /// Helps identify which ground truth data was not consumed during evaluation. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 100)]
        public List<string> IgnoredReferenceInputFields { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the IgnoredReferenceInputFields property is set.
        /// </summary>
        internal bool IsSetIgnoredReferenceInputFields() => this.IgnoredReferenceInputFields != null && (this.IgnoredReferenceInputFields.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        ///  The categorical label assigned by the evaluator when using a categorical rating scale.
        /// This provides a human-readable description of the evaluation result (e.g., "Excellent",
        /// "Good", "Poor") corresponding to the numerical value. For numerical scales, this field
        /// is optional and provides a natural language explanation of what the value means (e.g.,
        /// value 0.5 = "Somewhat Helpful"). 
        /// </para>
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Checks to see if the Label property is set.
        /// </summary>
        internal bool IsSetLabel() => this.Label != null;

        /// <summary>
        /// Gets and sets the property TokenUsage. 
        /// <para>
        ///  The token consumption statistics for this evaluation, including input tokens, output
        /// tokens, and total tokens used by the underlying language model during the evaluation
        /// process. 
        /// </para>
        /// </summary>
        public TokenUsage TokenUsage { get; set; }

        /// <summary>
        /// Checks to see if the TokenUsage property is set.
        /// </summary>
        internal bool IsSetTokenUsage() => this.TokenUsage != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        ///  The numerical score assigned by the evaluator according to its configured rating
        /// scale. For numerical scales, this is a decimal value within the defined range. This
        /// field is not allowed for categorical scales. 
        /// </para>
        /// </summary>
        public double? Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value.HasValue;
    }
}
