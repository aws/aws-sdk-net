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
    /// The configuration for using models served through the OpenResponses API in evaluator
    /// assessments, including model selection and inference parameters.
    /// </summary>
    public partial class OpenResponsesEvaluatorModelConfig
    {
        private int? _maxOutputTokens;
        private string _modelId;
        private ReasoningConfiguration _reasoning;
        private float? _temperature;
        private float? _topp;

        /// <summary>
        /// Gets and sets the property MaxOutputTokens. 
        /// <para>
        ///  The maximum number of tokens to generate in the model response, including visible
        /// output and reasoning tokens. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? MaxOutputTokens
        {
            get { return this._maxOutputTokens; }
            set { this._maxOutputTokens = value; }
        }

        // Check to see if MaxOutputTokens property is set
        internal bool IsSetMaxOutputTokens()
        {
            return this._maxOutputTokens.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelId. 
        /// <para>
        ///  The identifier of the model to use for evaluation. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ModelId
        {
            get { return this._modelId; }
            set { this._modelId = value; }
        }

        // Check to see if ModelId property is set
        internal bool IsSetModelId()
        {
            return this._modelId != null;
        }

        /// <summary>
        /// Gets and sets the property Reasoning. 
        /// <para>
        ///  The reasoning configuration for reasoning models. Non-reasoning models ignore this
        /// configuration. 
        /// </para>
        /// </summary>
        public ReasoningConfiguration Reasoning
        {
            get { return this._reasoning; }
            set { this._reasoning = value; }
        }

        // Check to see if Reasoning property is set
        internal bool IsSetReasoning()
        {
            return this._reasoning != null;
        }

        /// <summary>
        /// Gets and sets the property Temperature. 
        /// <para>
        ///  The temperature value that controls randomness in the model's responses. Lower values
        /// produce more deterministic outputs. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
        public float? Temperature
        {
            get { return this._temperature; }
            set { this._temperature = value; }
        }

        // Check to see if Temperature property is set
        internal bool IsSetTemperature()
        {
            return this._temperature.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TopP. 
        /// <para>
        ///  The top-p sampling parameter that controls the diversity of the model's responses
        /// by limiting the cumulative probability of token choices. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public float? TopP
        {
            get { return this._topp; }
            set { this._topp = value; }
        }

        // Check to see if TopP property is set
        internal bool IsSetTopP()
        {
            return this._topp.HasValue; 
        }

    }
}