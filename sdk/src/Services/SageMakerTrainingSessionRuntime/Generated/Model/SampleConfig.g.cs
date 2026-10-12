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
    /// The configuration for generating text samples from the model.
    /// </summary>
    public partial class SampleConfig
    {
        /// <summary>
        /// Gets and sets the property IncludePromptLogprobs. 
        /// <para>
        /// Specifies whether to include per-token log-probabilities for the input prompt in the
        /// response.
        /// </para>
        /// </summary>
        public bool? IncludePromptLogprobs { get; set; }

        /// <summary>
        /// Checks to see if the IncludePromptLogprobs property is set.
        /// </summary>
        internal bool IsSetIncludePromptLogprobs() => this.IncludePromptLogprobs.HasValue;

        /// <summary>
        /// Gets and sets the property ModelPackageArn. 
        /// <para>
        /// The ARN of the model package whose checkpoint this sample should run against. Must
        /// be a valid SageMaker model package ARN in the format <c>arn:aws:sagemaker:REGION:ACCOUNT:model-package/PACKAGE_NAME/VERSION</c>.
        /// When absent, the sample runs against the session's latest checkpoint.
        /// </para>
        /// </summary>
        public string ModelPackageArn { get; set; }

        /// <summary>
        /// Checks to see if the ModelPackageArn property is set.
        /// </summary>
        internal bool IsSetModelPackageArn() => this.ModelPackageArn != null;

        /// <summary>
        /// Gets and sets the property NumSamples. 
        /// <para>
        /// The number of independent samples to generate for the prompt.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1000)]
        public int? NumSamples { get; set; }

        /// <summary>
        /// Checks to see if the NumSamples property is set.
        /// </summary>
        internal bool IsSetNumSamples() => this.NumSamples.HasValue;

        /// <summary>
        /// Gets and sets the property Prompt. 
        /// <para>
        /// The input prompt to send to the model for text generation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public ModelInput Prompt { get; set; }

        /// <summary>
        /// Checks to see if the Prompt property is set.
        /// </summary>
        internal bool IsSetPrompt() => this.Prompt != null;

        /// <summary>
        /// Gets and sets the property SamplingParams. 
        /// <para>
        /// The parameters controlling the sampling strategy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SamplingParams SamplingParams { get; set; }

        /// <summary>
        /// Checks to see if the SamplingParams property is set.
        /// </summary>
        internal bool IsSetSamplingParams() => this.SamplingParams != null;

        /// <summary>
        /// Gets and sets the property TopkPromptLogprobs. 
        /// <para>
        /// The number of top-k log-probabilities to return per prompt token.
        /// </para>
        /// </summary>
        public int? TopkPromptLogprobs { get; set; }

        /// <summary>
        /// Checks to see if the TopkPromptLogprobs property is set.
        /// </summary>
        internal bool IsSetTopkPromptLogprobs() => this.TopkPromptLogprobs.HasValue;
    }
}
