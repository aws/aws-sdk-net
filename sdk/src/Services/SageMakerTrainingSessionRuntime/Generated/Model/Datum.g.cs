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
    /// A single training datum containing model input and optional loss function inputs.
    /// </summary>
    public partial class Datum
    {
        /// <summary>
        /// Gets and sets the property LossFnInputs. 
        /// <para>
        /// The tensor inputs for the loss function, keyed by name. Unsupported keys are rejected.
        /// Supported keys: <c>target_tokens</c>, <c>weights</c>, <c>advantages</c>, <c>logprobs</c>,
        /// <c>ref_log_prob</c>, <c>temperature</c>. Required keys depend on the loss function
        /// type: SFT (<c>cross_entropy</c>) requires <c>target_tokens</c> and <c>weights</c>;
        /// RL (<c>ppo</c>, <c>cispo</c>, <c>importance_sampling</c>) requires <c>target_tokens</c>,
        /// <c>weights</c>, <c>advantages</c>, and <c>logprobs</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, TensorData> LossFnInputs { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, TensorData>() : null;

        /// <summary>
        /// Checks to see if the LossFnInputs property is set.
        /// </summary>
        internal bool IsSetLossFnInputs() => this.LossFnInputs != null && (this.LossFnInputs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ModelInput. 
        /// <para>
        /// The tokenized input to feed to the model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public ModelInput ModelInput { get; set; }

        /// <summary>
        /// Checks to see if the ModelInput property is set.
        /// </summary>
        internal bool IsSetModelInput() => this.ModelInput != null;
    }
}
