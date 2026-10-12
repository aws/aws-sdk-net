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
    /// The result of a completed sampling operation. Exactly one member is populated, corresponding
    /// to the operation type that was submitted.
    /// </summary>
    public partial class SampleOperationResult
    {
        /// <summary>
        /// Gets and sets the property ComputeLogprobs. 
        /// <para>
        /// The computed log-probabilities for the prompt tokens.
        /// </para>
        /// </summary>
        public ComputeLogprobsResult ComputeLogprobs { get; set; }

        /// <summary>
        /// Checks to see if the ComputeLogprobs property is set.
        /// </summary>
        internal bool IsSetComputeLogprobs() => this.ComputeLogprobs != null;

        /// <summary>
        /// Gets and sets the property LoadWeightsForSampling. 
        /// <para>
        /// The result from loading weights for sampling.
        /// </para>
        /// </summary>
        public LoadWeightsForSamplingResult LoadWeightsForSampling { get; set; }

        /// <summary>
        /// Checks to see if the LoadWeightsForSampling property is set.
        /// </summary>
        internal bool IsSetLoadWeightsForSampling() => this.LoadWeightsForSampling != null;

        /// <summary>
        /// Gets and sets the property Sample. 
        /// <para>
        /// The generated text samples from the model.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public SampleResponse Sample { get; set; }

        /// <summary>
        /// Checks to see if the Sample property is set.
        /// </summary>
        internal bool IsSetSample() => this.Sample != null;
    }
}
