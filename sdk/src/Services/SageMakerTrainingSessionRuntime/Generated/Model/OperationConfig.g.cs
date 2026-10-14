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
    /// The configuration for a training operation. Exactly one member must be set to specify
    /// the operation type and its parameters.
    /// </summary>
    public partial class OperationConfig
    {
        /// <summary>
        /// Gets and sets the property Forward. 
        /// <para>
        /// The configuration for a forward-only pass through the model without gradient computation.
        /// </para>
        /// </summary>
        public ForwardConfig Forward { get; set; }

        /// <summary>
        /// Checks to see if the Forward property is set.
        /// </summary>
        internal bool IsSetForward() => this.Forward != null;

        /// <summary>
        /// Gets and sets the property ForwardBackward. 
        /// <para>
        /// The configuration for a forward and backward pass that computes gradients.
        /// </para>
        /// </summary>
        public ForwardBackwardConfig ForwardBackward { get; set; }

        /// <summary>
        /// Checks to see if the ForwardBackward property is set.
        /// </summary>
        internal bool IsSetForwardBackward() => this.ForwardBackward != null;

        /// <summary>
        /// Gets and sets the property LoadState. 
        /// <para>
        /// The configuration for loading training state from a previously saved checkpoint.
        /// </para>
        /// </summary>
        public LoadStateConfig LoadState { get; set; }

        /// <summary>
        /// Checks to see if the LoadState property is set.
        /// </summary>
        internal bool IsSetLoadState() => this.LoadState != null;

        /// <summary>
        /// Gets and sets the property OptimizerStep. 
        /// <para>
        /// The configuration for an optimizer step that updates model weights using accumulated
        /// gradients.
        /// </para>
        /// </summary>
        public OptimizerStepConfig OptimizerStep { get; set; }

        /// <summary>
        /// Checks to see if the OptimizerStep property is set.
        /// </summary>
        internal bool IsSetOptimizerStep() => this.OptimizerStep != null;

        /// <summary>
        /// Gets and sets the property SaveState. 
        /// <para>
        /// The configuration for saving full training state, including model weights and optimizer
        /// state.
        /// </para>
        /// </summary>
        public SaveStateConfig SaveState { get; set; }

        /// <summary>
        /// Checks to see if the SaveState property is set.
        /// </summary>
        internal bool IsSetSaveState() => this.SaveState != null;

        /// <summary>
        /// Gets and sets the property SaveWeights. 
        /// <para>
        /// The configuration for saving model weights as a checkpoint.
        /// </para>
        /// </summary>
        public SaveWeightsConfig SaveWeights { get; set; }

        /// <summary>
        /// Checks to see if the SaveWeights property is set.
        /// </summary>
        internal bool IsSetSaveWeights() => this.SaveWeights != null;
    }
}
