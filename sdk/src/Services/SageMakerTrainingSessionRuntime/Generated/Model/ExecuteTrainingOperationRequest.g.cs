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
    /// Container for the parameters to the ExecuteTrainingOperation operation. Submits an
    /// asynchronous training operation to the specified training session. The service executes
    /// operations in sequence number order. The session must be in <c>Running</c> or <c>Blocked</c>
    /// state. Use <c>GetTrainingOperationResult</c> to poll for the result. Supported operation
    /// types: <c>forward</c>, <c>forwardBackward</c>, <c>optimizerStep</c>, <c>saveWeights</c>,
    /// <c>saveState</c>, and <c>loadState</c>.
    /// </summary>
    public partial class ExecuteTrainingOperationRequest : AmazonSageMakerTrainingSessionRuntimeRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure that the operation
        /// completes no more than one time. If you retry a request with the same client token
        /// and the same parameters, the service ignores the request but does not return an error.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property OperationConfig. 
        /// <para>
        /// The configuration that specifies the type and parameters of the training operation.
        /// Exactly one member of the union must be set.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OperationConfig OperationConfig { get; set; }

        /// <summary>
        /// Checks to see if the OperationConfig property is set.
        /// </summary>
        internal bool IsSetOperationConfig() => this.OperationConfig != null;

        /// <summary>
        /// Gets and sets the property SequenceNumber. 
        /// <para>
        /// The monotonically increasing sequence number that determines execution order. The
        /// training session processes operations strictly in sequence number order. If a gap
        /// exists, the session blocks until the missing operation arrives or times out. Must
        /// be at least 1.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public int? SequenceNumber { get; set; }

        /// <summary>
        /// Checks to see if the SequenceNumber property is set.
        /// </summary>
        internal bool IsSetSequenceNumber() => this.SequenceNumber.HasValue;

        /// <summary>
        /// Gets and sets the property TrainingSessionName. 
        /// <para>
        /// The name of the training session to submit the operation to.
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
