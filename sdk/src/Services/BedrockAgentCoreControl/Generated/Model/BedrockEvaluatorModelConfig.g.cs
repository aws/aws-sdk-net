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
    /// The configuration for using Amazon Bedrock models in evaluator assessments, including
    /// model selection and inference parameters.
    /// </summary>
    public partial class BedrockEvaluatorModelConfig
    {
        /// <summary>
        /// Gets and sets the property AdditionalModelRequestFields. 
        /// <para>
        ///  Additional model-specific request fields to customize model behavior beyond the standard
        /// inference configuration. 
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document AdditionalModelRequestFields { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalModelRequestFields property is set.
        /// </summary>
        internal bool IsSetAdditionalModelRequestFields() => !this.AdditionalModelRequestFields.IsNull();

        /// <summary>
        /// Gets and sets the property InferenceConfig. 
        /// <para>
        ///  The inference configuration parameters that control model behavior during evaluation,
        /// including temperature, token limits, and sampling settings. 
        /// </para>
        /// </summary>
        public InferenceConfiguration InferenceConfig { get; set; }

        /// <summary>
        /// Checks to see if the InferenceConfig property is set.
        /// </summary>
        internal bool IsSetInferenceConfig() => this.InferenceConfig != null;

        /// <summary>
        /// Gets and sets the property ModelId. 
        /// <para>
        ///  The identifier of the Amazon Bedrock model to use for evaluation. Must be a supported
        /// foundation model available in your region. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ModelId { get; set; }

        /// <summary>
        /// Checks to see if the ModelId property is set.
        /// </summary>
        internal bool IsSetModelId() => this.ModelId != null;
    }
}
