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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Contains the ARN of the Amazon Bedrock model or <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/cross-region-inference.html">inference
    /// profile</a> specified in your evaluation job. Each Amazon Bedrock model supports different
    /// <c>inferenceParams</c>. To learn more about supported inference parameters for Amazon
    /// Bedrock models, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-parameters.html">Inference
    /// parameters for foundation models</a>.
    /// 
    ///  
    /// <para>
    /// The <c>inferenceParams</c> are specified using JSON. To successfully insert JSON as
    /// string make sure that all quotations are properly escaped. For example, <c>"temperature":"0.25"</c>
    /// key value pair would need to be formatted as <c>\"temperature\":\"0.25\"</c> to successfully
    /// accepted in the request.
    /// </para>
    /// </summary>
    public partial class EvaluationBedrockModel
    {
        private string _inferenceParams;
        private string _modelIdentifier;
        private PerformanceConfiguration _performanceConfig;

        /// <summary>
        /// Gets and sets the property InferenceParams. 
        /// <para>
        /// Each Amazon Bedrock support different inference parameters that change how the model
        /// behaves during inference.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1023)]
        public string InferenceParams
        {
            get { return this._inferenceParams; }
            set { this._inferenceParams = value; }
        }

        // Check to see if InferenceParams property is set
        internal bool IsSetInferenceParams()
        {
            return this._inferenceParams != null;
        }

        /// <summary>
        /// Gets and sets the property ModelIdentifier. 
        /// <para>
        /// The ARN of the Amazon Bedrock model or inference profile specified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ModelIdentifier
        {
            get { return this._modelIdentifier; }
            set { this._modelIdentifier = value; }
        }

        // Check to see if ModelIdentifier property is set
        internal bool IsSetModelIdentifier()
        {
            return this._modelIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property PerformanceConfig. 
        /// <para>
        /// Specifies performance settings for the model or inference profile.
        /// </para>
        /// </summary>
        public PerformanceConfiguration PerformanceConfig
        {
            get { return this._performanceConfig; }
            set { this._performanceConfig = value; }
        }

        // Check to see if PerformanceConfig property is set
        internal bool IsSetPerformanceConfig()
        {
            return this._performanceConfig != null;
        }

    }
}