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

namespace Amazon.SageMakerTrainingSessionRuntime.Model
{
    /// <summary>
    /// A single generated sequence from the model.
    /// </summary>
    public partial class SampledSequence
    {
        /// <summary>
        /// Gets and sets the property Logprobs. 
        /// <para>
        /// The per-token log-probabilities for the generated tokens.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<double> Logprobs { get; set; } = AWSConfigs.InitializeCollections ? new List<double>() : null;

        /// <summary>
        /// Checks to see if the Logprobs property is set.
        /// </summary>
        internal bool IsSetLogprobs() => this.Logprobs != null && (this.Logprobs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StopReason. 
        /// <para>
        /// The reason why generation stopped. A value of <c>stop</c> indicates a stop sequence
        /// was encountered. A value of <c>length</c> indicates the maximum token limit was reached.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StopReason StopReason { get; set; }

        /// <summary>
        /// Checks to see if the StopReason property is set.
        /// </summary>
        internal bool IsSetStopReason() => this.StopReason != null;

        /// <summary>
        /// Gets and sets the property TokenUsage. 
        /// <para>
        /// The token usage statistics for this individual sample.
        /// </para>
        /// </summary>
        public SampleTokenUsage TokenUsage { get; set; }

        /// <summary>
        /// Checks to see if the TokenUsage property is set.
        /// </summary>
        internal bool IsSetTokenUsage() => this.TokenUsage != null;

        /// <summary>
        /// Gets and sets the property Tokens. 
        /// <para>
        /// The token IDs of the generated sequence.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<int> Tokens { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the Tokens property is set.
        /// </summary>
        internal bool IsSetTokens() => this.Tokens != null && (this.Tokens.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
