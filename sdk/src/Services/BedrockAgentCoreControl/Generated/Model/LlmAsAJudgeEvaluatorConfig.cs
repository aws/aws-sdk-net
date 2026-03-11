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
    /// The configuration for LLM-as-a-Judge evaluation that uses a language model to assess
    /// agent performance based on custom instructions and rating scales.
    /// </summary>
    public partial class LlmAsAJudgeEvaluatorConfig
    {
        private string _instructions;
        private EvaluatorModelConfig _modelConfig;
        private RatingScale _ratingScale;

        /// <summary>
        /// Gets and sets the property Instructions. 
        /// <para>
        ///  The evaluation instructions that guide the language model in assessing agent performance,
        /// including criteria and evaluation guidelines. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string Instructions
        {
            get { return this._instructions; }
            set { this._instructions = value; }
        }

        // Check to see if Instructions property is set
        internal bool IsSetInstructions()
        {
            return this._instructions != null;
        }

        /// <summary>
        /// Gets and sets the property ModelConfig. 
        /// <para>
        ///  The model configuration that specifies which foundation model to use and how to configure
        /// it for evaluation. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EvaluatorModelConfig ModelConfig
        {
            get { return this._modelConfig; }
            set { this._modelConfig = value; }
        }

        // Check to see if ModelConfig property is set
        internal bool IsSetModelConfig()
        {
            return this._modelConfig != null;
        }

        /// <summary>
        /// Gets and sets the property RatingScale. 
        /// <para>
        ///  The rating scale that defines how the evaluator should score agent performance, either
        /// numerical or categorical. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RatingScale RatingScale
        {
            get { return this._ratingScale; }
            set { this._ratingScale = value; }
        }

        // Check to see if RatingScale property is set
        internal bool IsSetRatingScale()
        {
            return this._ratingScale != null;
        }

    }
}