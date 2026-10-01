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

namespace Amazon.QConnect.Model
{
    /// <summary>
    /// The configuration for inference parameters when using AI Prompts.
    /// </summary>
    public partial class AIPromptInferenceConfiguration
    {
        /// <summary>
        /// Gets and sets the property MaxTokensToSample. 
        /// <para>
        /// The maximum number of tokens to generate in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 4096)]
        public int? MaxTokensToSample { get; set; }

        /// <summary>
        /// Checks to see if the MaxTokensToSample property is set.
        /// </summary>
        internal bool IsSetMaxTokensToSample() => this.MaxTokensToSample.HasValue;

        /// <summary>
        /// Gets and sets the property Temperature. 
        /// <para>
        /// The temperature setting for controlling randomness in the generated response.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 1)]
        public float? Temperature { get; set; }

        /// <summary>
        /// Checks to see if the Temperature property is set.
        /// </summary>
        internal bool IsSetTemperature() => this.Temperature.HasValue;

        /// <summary>
        /// Gets and sets the property TopK. 
        /// <para>
        /// The top-K sampling parameter for token selection.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 200)]
        public int? TopK { get; set; }

        /// <summary>
        /// Checks to see if the TopK property is set.
        /// </summary>
        internal bool IsSetTopK() => this.TopK.HasValue;

        /// <summary>
        /// Gets and sets the property TopP. 
        /// <para>
        /// The top-P sampling parameter for nucleus sampling.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 1)]
        public float? TopP { get; set; }

        /// <summary>
        /// Checks to see if the TopP property is set.
        /// </summary>
        internal bool IsSetTopP() => this.TopP.HasValue;
    }
}
