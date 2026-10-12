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
    /// The configuration for a sampling operation. Exactly one member must be set to specify
    /// the operation type.
    /// </summary>
    public partial class SampleOperationConfig
    {
        /// <summary>
        /// Gets and sets the property ComputeLogprobs. 
        /// <para>
        /// The configuration for computing log-probabilities of prompt tokens without generating
        /// new text.
        /// </para>
        /// </summary>
        public ComputeLogprobsConfig ComputeLogprobs { get; set; }

        /// <summary>
        /// Checks to see if the ComputeLogprobs property is set.
        /// </summary>
        internal bool IsSetComputeLogprobs() => this.ComputeLogprobs != null;

        /// <summary>
        /// Gets and sets the property LoadWeightsForSampling. 
        /// <para>
        /// The configuration for loading model weights for inference and sampling without restoring
        /// optimizer state.
        /// </para>
        /// </summary>
        public LoadWeightsForSamplingConfig LoadWeightsForSampling { get; set; }

        /// <summary>
        /// Checks to see if the LoadWeightsForSampling property is set.
        /// </summary>
        internal bool IsSetLoadWeightsForSampling() => this.LoadWeightsForSampling != null;

        /// <summary>
        /// Gets and sets the property Sample. 
        /// <para>
        /// The configuration for generating text samples from the model.
        /// </para>
        /// </summary>
        public SampleConfig Sample { get; set; }

        /// <summary>
        /// Checks to see if the Sample property is set.
        /// </summary>
        internal bool IsSetSample() => this.Sample != null;
    }
}
