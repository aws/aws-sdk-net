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
    /// The response containing generated samples and optional log-probabilities.
    /// </summary>
    public partial class SampleResponse
    {
        /// <summary>
        /// Gets and sets the property PromptLogprobs. 
        /// <para>
        /// The per-token log-probabilities for the input prompt. Populated only when <c>includePromptLogprobs</c>
        /// is true.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<double> PromptLogprobs { get; set; } = AWSConfigs.InitializeCollections ? new List<double>() : null;

        /// <summary>
        /// Checks to see if the PromptLogprobs property is set.
        /// </summary>
        internal bool IsSetPromptLogprobs() => this.PromptLogprobs != null && (this.PromptLogprobs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Sequences. 
        /// <para>
        /// The list of generated sequences.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<SampledSequence> Sequences { get; set; } = AWSConfigs.InitializeCollections ? new List<SampledSequence>() : null;

        /// <summary>
        /// Checks to see if the Sequences property is set.
        /// </summary>
        internal bool IsSetSequences() => this.Sequences != null && (this.Sequences.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TopkPromptLogprobs. 
        /// <para>
        /// The top-k log-probabilities per prompt token, as a list of lists. Populated only when
        /// <c>topkPromptLogprobs</c> is greater than 0.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<List<TokenLogprob>> TopkPromptLogprobs { get; set; } = AWSConfigs.InitializeCollections ? new List<List<TokenLogprob>>() : null;

        /// <summary>
        /// Checks to see if the TopkPromptLogprobs property is set.
        /// </summary>
        internal bool IsSetTopkPromptLogprobs() => this.TopkPromptLogprobs != null && (this.TopkPromptLogprobs.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
