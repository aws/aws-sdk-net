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
 * Do not modify this file. This file is generated from the bedrock-runtime-2023-09-30.normal.json service model.
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
namespace Amazon.BedrockRuntime.Model
{
    /// <summary>
    /// Base inference parameters to pass to a model in a call to <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_runtime_Converse.html">Converse</a>
    /// or <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_runtime_ConverseStream.html">ConverseStream</a>.
    /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-parameters.html">Inference
    /// parameters for foundation models</a>.
    /// 
    ///  
    /// <para>
    /// If you need to pass additional parameters that the model supports, use the <c>additionalModelRequestFields</c>
    /// request field in the call to <c>Converse</c> or <c>ConverseStream</c>. For more information,
    /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-parameters.html">Model
    /// parameters</a>.
    /// </para>
    /// </summary>
    public partial class InferenceConfiguration
    {
        private int? _maxTokens;
        private List<string> _stopSequences = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private float? _temperature;
        private float? _topp;

        /// <summary>
        /// Gets and sets the property MaxTokens. 
        /// <para>
        /// The maximum number of tokens to allow in the generated response. The default value
        /// is the maximum allowed value for the model that you are using. For more information,
        /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-parameters.html">Inference
        /// parameters for foundation models</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? MaxTokens
        {
            get { return this._maxTokens; }
            set { this._maxTokens = value; }
        }

        // Check to see if MaxTokens property is set
        internal bool IsSetMaxTokens()
        {
            return this._maxTokens.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StopSequences. 
        /// <para>
        /// A list of stop sequences. A stop sequence is a sequence of characters that causes
        /// the model to stop generating the response. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=2500)]
        public List<string> StopSequences
        {
            get { return this._stopSequences; }
            set { this._stopSequences = value; }
        }

        // Check to see if StopSequences property is set
        internal bool IsSetStopSequences()
        {
            return this._stopSequences != null && (this._stopSequences.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Temperature. 
        /// <para>
        /// The likelihood of the model selecting higher-probability options while generating
        /// a response. A lower value makes the model more likely to choose higher-probability
        /// options, while a higher value makes the model more likely to choose lower-probability
        /// options.
        /// </para>
        ///  
        /// <para>
        /// The default value is the default value for the model that you are using. For more
        /// information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-parameters.html">Inference
        /// parameters for foundation models</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
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
        /// The percentage of most-likely candidates that the model considers for the next token.
        /// For example, if you choose a value of 0.8 for <c>topP</c>, the model selects from
        /// the top 80% of the probability distribution of tokens that could be next in the sequence.
        /// </para>
        ///  
        /// <para>
        /// The default value is the default value for the model that you are using. For more
        /// information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-parameters.html">Inference
        /// parameters for foundation models</a>. 
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