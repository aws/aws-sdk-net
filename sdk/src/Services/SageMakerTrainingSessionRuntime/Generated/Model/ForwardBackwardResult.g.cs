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
    /// The result of a forward and backward pass through the model, including computed gradients.
    /// </summary>
    public partial class ForwardBackwardResult
    {
        /// <summary>
        /// Gets and sets the property LossFnOutputType. 
        /// <para>
        /// The data type of the loss function output tensors.
        /// </para>
        /// </summary>
        public string LossFnOutputType { get; set; }

        /// <summary>
        /// Checks to see if the LossFnOutputType property is set.
        /// </summary>
        internal bool IsSetLossFnOutputType() => this.LossFnOutputType != null;

        /// <summary>
        /// Gets and sets the property LossFnOutputs. 
        /// <para>
        /// The loss function output tensors, keyed by name.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Dictionary<string, TensorData>> LossFnOutputs { get; set; } = AWSConfigs.InitializeCollections ? new List<Dictionary<string, TensorData>>() : null;

        /// <summary>
        /// Checks to see if the LossFnOutputs property is set.
        /// </summary>
        internal bool IsSetLossFnOutputs() => this.LossFnOutputs != null && (this.LossFnOutputs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// The training metrics emitted by the engine, such as loss values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, double> Metrics { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, double>() : null;

        /// <summary>
        /// Checks to see if the Metrics property is set.
        /// </summary>
        internal bool IsSetMetrics() => this.Metrics != null && (this.Metrics.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TokenUsage. 
        /// <para>
        /// The token usage statistics for metering.
        /// </para>
        /// </summary>
        public TrainingTokenUsage TokenUsage { get; set; }

        /// <summary>
        /// Checks to see if the TokenUsage property is set.
        /// </summary>
        internal bool IsSetTokenUsage() => this.TokenUsage != null;
    }
}
