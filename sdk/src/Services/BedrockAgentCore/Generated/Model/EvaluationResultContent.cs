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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
        private Context _context;
        private string _errorCode;
        private string _errorMessage;
        private string _evaluatorArn;
        private string _evaluatorId;
        private string _evaluatorName;
        private string _explanation;
        private string _label;
        private TokenUsage _tokenUsage;
        private double? _value;

        /// <summary>
        /// Gets and sets the property Context. 
        /// <para>
        ///  The contextual information associated with this evaluation result, including span
        /// context details that identify the specific traces and sessions that were evaluated.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Context Context
        {
            get { return this._context; }
            set { this._context = value; }
        }

        // Check to see if Context property is set
        internal bool IsSetContext()
        {
            return this._context != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        ///  The error code indicating the type of failure that occurred during evaluation. Used
        /// to programmatically identify and handle different categories of evaluation errors.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        ///  The error message describing what went wrong if the evaluation failed. Provides detailed
        /// information about evaluation failures to help diagnose and resolve issues with evaluator
        /// configuration or input data. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluatorArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the evaluator used to generate this result. For
        /// custom evaluators, this is the full ARN; for built-in evaluators, this follows the
        /// pattern <c>Builtin.{EvaluatorName}</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EvaluatorArn
        {
            get { return this._evaluatorArn; }
            set { this._evaluatorArn = value; }
        }

        // Check to see if EvaluatorArn property is set
        internal bool IsSetEvaluatorArn()
        {
            return this._evaluatorArn != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluatorId. 
        /// <para>
        ///  The unique identifier of the evaluator that produced this result. This matches the
        /// <c>evaluatorId</c> provided in the evaluation request and can be used to identify
        /// which evaluator generated specific results. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EvaluatorId
        {
            get { return this._evaluatorId; }
            set { this._evaluatorId = value; }
        }

        // Check to see if EvaluatorId property is set
        internal bool IsSetEvaluatorId()
        {
            return this._evaluatorId != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluatorName. 
        /// <para>
        ///  The human-readable name of the evaluator used for this evaluation. For built-in evaluators,
        /// this is the descriptive name (e.g., "Helpfulness", "Correctness"); for custom evaluators,
        /// this is the user-defined name. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EvaluatorName
        {
            get { return this._evaluatorName; }
            set { this._evaluatorName = value; }
        }

        // Check to see if EvaluatorName property is set
        internal bool IsSetEvaluatorName()
        {
            return this._evaluatorName != null;
        }

        /// <summary>
        /// Gets and sets the property Explanation. 
        /// <para>
        ///  The detailed explanation provided by the evaluator describing the reasoning behind
        /// the assigned score. This qualitative feedback helps understand why specific ratings
        /// were given and provides actionable insights for improvement. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=2048)]
        public string Explanation
        {
            get { return this._explanation; }
            set { this._explanation = value; }
        }

        // Check to see if Explanation property is set
        internal bool IsSetExplanation()
        {
            return this._explanation != null;
        }

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
        public string Label
        {
            get { return this._label; }
            set { this._label = value; }
        }

        // Check to see if Label property is set
        internal bool IsSetLabel()
        {
            return this._label != null;
        }

        /// <summary>
        /// Gets and sets the property TokenUsage. 
        /// <para>
        ///  The token consumption statistics for this evaluation, including input tokens, output
        /// tokens, and total tokens used by the underlying language model during the evaluation
        /// process. 
        /// </para>
        /// </summary>
        public TokenUsage TokenUsage
        {
            get { return this._tokenUsage; }
            set { this._tokenUsage = value; }
        }

        // Check to see if TokenUsage property is set
        internal bool IsSetTokenUsage()
        {
            return this._tokenUsage != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        ///  The numerical score assigned by the evaluator according to its configured rating
        /// scale. For numerical scales, this is a decimal value within the defined range. This
        /// field is not allowed for categorical scales. 
        /// </para>
        /// </summary>
        public double Value
        {
            get { return this._value.GetValueOrDefault(); }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value.HasValue; 
        }

    }
}