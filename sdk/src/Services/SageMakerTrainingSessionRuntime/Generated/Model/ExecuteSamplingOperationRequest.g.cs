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
    /// Container for the parameters to the ExecuteSamplingOperation operation. Submits an
    /// asynchronous sampling operation to generate text or compute log-probabilities from
    /// the model associated with the specified training session. The session must be in <c>Running</c>
    /// or <c>Blocked</c> state. Use <c>GetSamplingOperationResult</c> to poll for the result.
    /// </summary>
    public partial class ExecuteSamplingOperationRequest : AmazonSageMakerTrainingSessionRuntimeRequest
    {
        /// <summary>
        /// Gets and sets the property OperationConfig. 
        /// <para>
        /// The configuration for the sample operation. Specify either a sample configuration
        /// to generate text or a computeLogprobs configuration to compute token log-probabilities.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SampleOperationConfig OperationConfig { get; set; }

        /// <summary>
        /// Checks to see if the OperationConfig property is set.
        /// </summary>
        internal bool IsSetOperationConfig() => this.OperationConfig != null;

        /// <summary>
        /// Gets and sets the property TrainingSessionName. 
        /// <para>
        /// The name of the training session to sample from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string TrainingSessionName { get; set; }

        /// <summary>
        /// Checks to see if the TrainingSessionName property is set.
        /// </summary>
        internal bool IsSetTrainingSessionName() => this.TrainingSessionName != null;
    }
}
