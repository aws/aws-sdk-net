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
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.MachineLearning.Util
{
    public partial class RealtimePredictor
    {

        /// <summary>
        /// The realtime prediction endpoint for the given MLModel.
        /// </summary>
        public async Task<string> GetEndpointAsync()
        {
            if (null == this.endpoint)
            {
                GetMLModelRequest request = new GetMLModelRequest { MLModelId = ModelId };
                this.endpoint = (await client.GetMLModelAsync(request).ConfigureAwait(false)).EndpointInfo.EndpointUrl;                
            }

            return this.endpoint;
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Predict operation.
        /// </summary>
        /// 
        /// <param name="record">Data to generate prediction for.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public async Task<Prediction> PredictAsync(Dictionary<string, string> record, CancellationToken cancellationToken = default(CancellationToken))
        {
            var endpoint = await GetEndpointAsync().ConfigureAwait(false);

            return (await this.client.PredictAsync(new PredictRequest {
                MLModelId = ModelId,
                PredictEndpoint = endpoint,
                Record = record
            }, cancellationToken).ConfigureAwait(false)).Prediction;
        }
    }

}
   