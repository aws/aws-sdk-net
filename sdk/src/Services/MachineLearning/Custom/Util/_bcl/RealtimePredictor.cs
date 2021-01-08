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

using Amazon.Runtime;
using Amazon.MachineLearning.Model;
using System.Collections.Generic;

namespace Amazon.MachineLearning.Util
{
    /// <summary>
    /// A simplified client that just does realtime predictions.
    /// </summary>
    public partial class RealtimePredictor : IDisposable
    {
        /// <summary>
        /// Constructs a RealtimePredictor which construct a client using configured defaults.
        /// </summary>
        /// <remarks>
        /// The endpoint URL will be determined my making a service call to retrieve it.
        /// </remarks>        
        /// <param name="modelId">The MachineLearning model to predict against.</param>
        public RealtimePredictor(string modelId)
        {
            this.client = new AmazonMachineLearningClient();
            this.shouldDispose = true;
            this.ModelId = modelId;
        }

        /// <summary>
        /// The realtime prediction endpoint for the given MLModel.
        /// </summary>
        public string Endpoint
        {
            get
            {
                if (null == this.endpoint)
                    this.endpoint = client.GetMLModel(ModelId).EndpointInfo.EndpointUrl;

                return this.endpoint;
            }
        }

        /// <summary>
        /// Generates a prediction for an observation.
        /// </summary>
        /// <param name="record">Data to generate a prediction for.</param>
        /// <returns>A prediction for the observation, as returned by MachineLearning.</returns>
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
        public Prediction Predict(Dictionary<string, string> record)
        {
            return client.Predict(new PredictRequest {
                MLModelId = ModelId,
                PredictEndpoint = Endpoint,
                Record = record
            }).Prediction;
        }
    }

}
   