/*
 * Copyright 2010-2015 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    public partial class RealtimePredictor
    {
        /// <summary>
        /// Initiates the asynchronous execution of the Predict operation.
        /// </summary>
        /// <param name="record">Data to generate a prediction for.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPredict
        ///         operation.</returns>
        public IAsyncResult BeginPredict(Dictionary<string, string> record, AsyncCallback callback, object state)
        {
            return this.client.BeginPredict(new PredictRequest {
                MLModelId = ModelId,
                PredictEndpoint = Endpoint,
                Record = record
            }, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  Predict operation.
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPredict.</param>
        /// <returns>A prediction for the observation, as returned by MachineLearning.</returns>
        public Prediction EndPredict(IAsyncResult asyncResult)
        {
            return this.client.EndPredict(asyncResult).Prediction;
        }
    }

}
   