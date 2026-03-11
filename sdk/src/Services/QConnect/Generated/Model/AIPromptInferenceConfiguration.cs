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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// The configuration for inference parameters when using AI Prompts.
    /// </summary>
    public partial class AIPromptInferenceConfiguration
    {
        private int? _maxTokensToSample;
        private float? _temperature;
        private int? _topk;
        private float? _topp;

        /// <summary>
        /// Gets and sets the property MaxTokensToSample. 
        /// <para>
        /// The maximum number of tokens to generate in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=4096)]
        public int? MaxTokensToSample
        {
            get { return this._maxTokensToSample; }
            set { this._maxTokensToSample = value; }
        }

        // Check to see if MaxTokensToSample property is set
        internal bool IsSetMaxTokensToSample()
        {
            return this._maxTokensToSample.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Temperature. 
        /// <para>
        /// The temperature setting for controlling randomness in the generated response.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=1)]
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
        /// The top-K sampling parameter for token selection.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=200)]
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
        /// The top-P sampling parameter for nucleus sampling.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=1)]
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