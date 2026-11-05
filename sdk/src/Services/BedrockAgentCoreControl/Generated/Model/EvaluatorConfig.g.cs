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
    /// The configuration that defines how an evaluator assesses agent performance, including
    /// the evaluation method and parameters.
    /// </summary>
    public partial class EvaluatorConfig
    {
        /// <summary>
        /// Gets and sets the property CodeBased. 
        /// <para>
        ///  Configuration for a code-based evaluator that uses a customer-managed Lambda function
        /// to programmatically assess agent performance. 
        /// </para>
        /// </summary>
        public CodeBasedEvaluatorConfig CodeBased { get; set; }

        /// <summary>
        /// Checks to see if the CodeBased property is set.
        /// </summary>
        internal bool IsSetCodeBased() => this.CodeBased != null;

        /// <summary>
        /// Gets and sets the property Derived. 
        /// <para>
        ///  The configuration for an evaluator derived from an existing base evaluator (a built-in
        /// or third-party evaluator), run on your own model. The base evaluator supplies the
        /// prompt and scoring. 
        /// </para>
        /// </summary>
        public DerivedEvaluatorConfig Derived { get; set; }

        /// <summary>
        /// Checks to see if the Derived property is set.
        /// </summary>
        internal bool IsSetDerived() => this.Derived != null;

        /// <summary>
        /// Gets and sets the property LlmAsAJudge. 
        /// <para>
        ///  The LLM-as-a-Judge configuration that uses a language model to evaluate agent performance
        /// based on custom instructions and rating scales. 
        /// </para>
        /// </summary>
        public LlmAsAJudgeEvaluatorConfig LlmAsAJudge { get; set; }

        /// <summary>
        /// Checks to see if the LlmAsAJudge property is set.
        /// </summary>
        internal bool IsSetLlmAsAJudge() => this.LlmAsAJudge != null;
    }
}
