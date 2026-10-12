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
    /// The Adam optimizer hyperparameters used during an optimizer step.
    /// </summary>
    public partial class AdamParamsConfig
    {
        /// <summary>
        /// Gets and sets the property Beta1. 
        /// <para>
        /// The exponential decay rate for the first moment estimates.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public double? Beta1 { get; set; }

        /// <summary>
        /// Checks to see if the Beta1 property is set.
        /// </summary>
        internal bool IsSetBeta1() => this.Beta1.HasValue;

        /// <summary>
        /// Gets and sets the property Beta2. 
        /// <para>
        /// The exponential decay rate for the second moment estimates.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public double? Beta2 { get; set; }

        /// <summary>
        /// Checks to see if the Beta2 property is set.
        /// </summary>
        internal bool IsSetBeta2() => this.Beta2.HasValue;

        /// <summary>
        /// Gets and sets the property Eps. 
        /// <para>
        /// A small constant added to the denominator for numerical stability.
        /// </para>
        /// </summary>
        public double? Eps { get; set; }

        /// <summary>
        /// Checks to see if the Eps property is set.
        /// </summary>
        internal bool IsSetEps() => this.Eps.HasValue;

        /// <summary>
        /// Gets and sets the property GradClipNorm. 
        /// <para>
        /// The maximum gradient norm for gradient clipping. Gradients are scaled down if their
        /// norm exceeds this value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public double? GradClipNorm { get; set; }

        /// <summary>
        /// Checks to see if the GradClipNorm property is set.
        /// </summary>
        internal bool IsSetGradClipNorm() => this.GradClipNorm.HasValue;

        /// <summary>
        /// Gets and sets the property LearningRate. 
        /// <para>
        /// The learning rate for the optimizer. Must be greater than 0.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public double? LearningRate { get; set; }

        /// <summary>
        /// Checks to see if the LearningRate property is set.
        /// </summary>
        internal bool IsSetLearningRate() => this.LearningRate.HasValue;

        /// <summary>
        /// Gets and sets the property LoraPlusLrRatio. 
        /// <para>
        /// The learning rate multiplier for LoRA+ B matrices relative to A matrices. When set,
        /// B matrices use <c>learningRate * loraPlusLrRatio</c> while A matrices use the base
        /// learning rate.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public double? LoraPlusLrRatio { get; set; }

        /// <summary>
        /// Checks to see if the LoraPlusLrRatio property is set.
        /// </summary>
        internal bool IsSetLoraPlusLrRatio() => this.LoraPlusLrRatio.HasValue;

        /// <summary>
        /// Gets and sets the property WeightDecay. 
        /// <para>
        /// The weight decay (L2 regularization) coefficient.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public double? WeightDecay { get; set; }

        /// <summary>
        /// Checks to see if the WeightDecay property is set.
        /// </summary>
        internal bool IsSetWeightDecay() => this.WeightDecay.HasValue;
    }
}
