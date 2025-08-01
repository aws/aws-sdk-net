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
    /// Configuration settings for text generation using a language model via the RetrieveAndGenerate
    /// operation. Includes parameters like temperature, top-p, maximum token count, and stop
    /// sequences. 
    /// 
    ///  <note> 
    /// <para>
    /// The valid range of <c>maxTokens</c> depends on the accepted values for your chosen
    /// model's inference parameters. To see the inference parameters for your model, see
    /// <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-parameters.html">Inference
    /// parameters for foundation models.</a> 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class TextInferenceConfig
    {
        private int? _maxTokens;
        private List<string> _stopSequences = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private float? _temperature;
        private float? _topp;

        /// <summary>
        /// Gets and sets the property MaxTokens. 
        /// <para>
        /// The maximum number of tokens to generate in the output text. Do not use the minimum
        /// of 0 or the maximum of 65536. The limit values described here are arbitary values,
        /// for actual values consult the limits defined by your specific model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65536)]
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
        /// A list of sequences of characters that, if generated, will cause the model to stop
        /// generating further tokens. Do not use a minimum length of 1 or a maximum length of
        /// 1000. The limit values described here are arbitary values, for actual values consult
        /// the limits defined by your specific model.
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
        ///  Controls the random-ness of text generated by the language model, influencing how
        /// much the model sticks to the most predictable next words versus exploring more surprising
        /// options. A lower temperature value (e.g. 0.2 or 0.3) makes model outputs more deterministic
        /// or predictable, while a higher temperature (e.g. 0.8 or 0.9) makes the outputs more
        /// creative or unpredictable. 
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
        ///  A probability distribution threshold which controls what the model considers for
        /// the set of possible next tokens. The model will only consider the top p% of the probability
        /// distribution when generating the next token. 
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