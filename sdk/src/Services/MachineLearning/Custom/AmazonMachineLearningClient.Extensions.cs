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

using System;
using System.Collections.Generic;

using Amazon.MachineLearning.Model;
using Amazon.MachineLearning.Util;
using Amazon.MachineLearning.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.MachineLearning
{
    /// <summary>
    /// Implementation for accessing MachineLearning
    ///
    /// Definition of the public APIs exposed by Amazon Machine Learning
    /// </summary>
    public partial class AmazonMachineLearningClient
    {
        /// <summary>
        /// Creates a simple client that just does realtime predictions.
        /// </summary>
        /// <remarks>
        /// Fetches the realtime prediction endpoint for the specified model using the GetMLModel call.
        /// </remarks>
        /// <param name="modelId">The model to create the realtime predictor for.</param>
        /// <returns>A realtime prediction client.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.LimitExceededException">
        /// The subscriber exceeded the maximum number of operations. This exception can occur
        /// when listing objects such as <code>DataSource</code>.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.PredictorNotMountedException">
        /// The exception is thrown when a predict request is made to an unmounted <code>MLModel</code>.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        public RealtimePredictor CreateRealtimePredictor(string modelId)
        {
            return new RealtimePredictor(this, modelId);
        }
    }
}