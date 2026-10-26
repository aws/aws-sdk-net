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
    /// The configuration for LLM-as-a-Judge evaluation that uses a language model to assess
    /// agent performance based on custom instructions and rating scales.
    /// </summary>
    public partial class LlmAsAJudgeEvaluatorConfig
    {
        /// <summary>
        /// Gets and sets the property Instructions. 
        /// <para>
        ///  The evaluation instructions that guide the language model in assessing agent performance,
        /// including criteria and evaluation guidelines. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string Instructions { get; set; }

        /// <summary>
        /// Checks to see if the Instructions property is set.
        /// </summary>
        internal bool IsSetInstructions() => this.Instructions != null;

        /// <summary>
        /// Gets and sets the property ModelConfig. 
        /// <para>
        ///  The model configuration that specifies which foundation model to use and how to configure
        /// it for evaluation. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EvaluatorModelConfig ModelConfig { get; set; }

        /// <summary>
        /// Checks to see if the ModelConfig property is set.
        /// </summary>
        internal bool IsSetModelConfig() => this.ModelConfig != null;

        /// <summary>
        /// Gets and sets the property RatingScale. 
        /// <para>
        ///  The rating scale that defines how the evaluator should score agent performance, either
        /// numerical or categorical. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public RatingScale RatingScale { get; set; }

        /// <summary>
        /// Checks to see if the RatingScale property is set.
        /// </summary>
        internal bool IsSetRatingScale() => this.RatingScale != null;
    }
}
