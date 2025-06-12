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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
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
namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Specifications about the inference parameters that were provided alongside the prompt.
    /// These are specified in the <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent_PromptOverrideConfiguration.html">PromptOverrideConfiguration</a>
    /// object that was set when the agent was created or updated. For more information, see
    /// <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-parameters.html">Inference
    /// parameters for foundation models</a>.
    /// </summary>
    public partial class InferenceConfiguration
    {
        private int? _maximumLength;
        private List<string> _stopSequences = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private float? _temperature;
        private int? _topk;
        private float? _topp;

        /// <summary>
        /// Gets and sets the property MaximumLength. 
        /// <para>
        /// The maximum number of tokens allowed in the generated response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
        public int? MaximumLength
        {
            get { return this._maximumLength; }
            set { this._maximumLength = value; }
        }

        // Check to see if MaximumLength property is set
        internal bool IsSetMaximumLength()
        {
            return this._maximumLength.HasValue; 
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
        [AWSProperty(Min=0, Max=4)]
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
        /// Gets and sets the property TopK. 
        /// <para>
        /// While generating a response, the model determines the probability of the following
        /// token at each point of generation. The value that you set for <c>topK</c> is the number
        /// of most-likely candidates from which the model chooses the next token in the sequence.
        /// For example, if you set <c>topK</c> to 50, the model selects the next token from among
        /// the top 50 most likely choices.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public int? TopK
        {
            get { return this._topk; }
            set { this._topk = value; }
        }

        // Check to see if TopK property is set
        internal bool IsSetTopK()
        {
            return this._topk.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TopP. 
        /// <para>
        /// While generating a response, the model determines the probability of the following
        /// token at each point of generation. The value that you set for <c>Top P</c> determines
        /// the number of most-likely candidates from which the model chooses the next token in
        /// the sequence. For example, if you set <c>topP</c> to 0.8, the model only selects the
        /// next token from the top 80% of the probability distribution of next tokens.
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