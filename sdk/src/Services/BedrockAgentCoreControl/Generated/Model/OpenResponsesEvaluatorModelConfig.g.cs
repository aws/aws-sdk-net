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
    /// The configuration for using models served through the OpenResponses API in evaluator
    /// assessments, including model selection and inference parameters.
    /// </summary>
    public partial class OpenResponsesEvaluatorModelConfig
    {
        /// <summary>
        /// Gets and sets the property MaxOutputTokens. 
        /// <para>
        ///  The maximum number of tokens to generate in the model response, including visible
        /// output and reasoning tokens. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? MaxOutputTokens { get; set; }

        /// <summary>
        /// Checks to see if the MaxOutputTokens property is set.
        /// </summary>
        internal bool IsSetMaxOutputTokens() => this.MaxOutputTokens.HasValue;

        /// <summary>
        /// Gets and sets the property ModelId. 
        /// <para>
        ///  The identifier of the model to use for evaluation. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ModelId { get; set; }

        /// <summary>
        /// Checks to see if the ModelId property is set.
        /// </summary>
        internal bool IsSetModelId() => this.ModelId != null;

        /// <summary>
        /// Gets and sets the property Reasoning. 
        /// <para>
        ///  The reasoning configuration for reasoning models. Non-reasoning models ignore this
        /// configuration. 
        /// </para>
        /// </summary>
        public ReasoningConfiguration Reasoning { get; set; }

        /// <summary>
        /// Checks to see if the Reasoning property is set.
        /// </summary>
        internal bool IsSetReasoning() => this.Reasoning != null;

        /// <summary>
        /// Gets and sets the property Temperature. 
        /// <para>
        ///  The temperature value that controls randomness in the model's responses. Lower values
        /// produce more deterministic outputs. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2)]
        public float? Temperature { get; set; }

        /// <summary>
        /// Checks to see if the Temperature property is set.
        /// </summary>
        internal bool IsSetTemperature() => this.Temperature.HasValue;

        /// <summary>
        /// Gets and sets the property TopP. 
        /// <para>
        ///  The top-p sampling parameter that controls the diversity of the model's responses
        /// by limiting the cumulative probability of token choices. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public float? TopP { get; set; }

        /// <summary>
        /// Checks to see if the TopP property is set.
        /// </summary>
        internal bool IsSetTopP() => this.TopP.HasValue;
    }
}
