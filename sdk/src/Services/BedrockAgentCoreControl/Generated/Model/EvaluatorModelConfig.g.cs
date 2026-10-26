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
    /// The model configuration that specifies which foundation model to use for evaluation
    /// and how to configure it.
    /// </summary>
    public partial class EvaluatorModelConfig
    {
        /// <summary>
        /// Gets and sets the property BedrockEvaluatorModelConfig. 
        /// <para>
        ///  The Amazon Bedrock model configuration for evaluation. 
        /// </para>
        /// </summary>
        public BedrockEvaluatorModelConfig BedrockEvaluatorModelConfig { get; set; }

        /// <summary>
        /// Checks to see if the BedrockEvaluatorModelConfig property is set.
        /// </summary>
        internal bool IsSetBedrockEvaluatorModelConfig() => this.BedrockEvaluatorModelConfig != null;

        /// <summary>
        /// Gets and sets the property ResponsesEvaluatorModelConfig. 
        /// <para>
        ///  The OpenResponses model configuration for evaluation. 
        /// </para>
        /// </summary>
        public OpenResponsesEvaluatorModelConfig ResponsesEvaluatorModelConfig { get; set; }

        /// <summary>
        /// Checks to see if the ResponsesEvaluatorModelConfig property is set.
        /// </summary>
        internal bool IsSetResponsesEvaluatorModelConfig() => this.ResponsesEvaluatorModelConfig != null;
    }
}
