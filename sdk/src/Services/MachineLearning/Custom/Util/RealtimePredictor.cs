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
        private bool shouldDispose = false;
        private bool isDisposed = false;
        private IAmazonMachineLearning client;
        private string endpoint = null;
        
        /// <summary>
        /// Constructs a RealtimePredictor which will use the passed in client to make requests.
        /// </summary>
        /// <remarks>
        /// The endpoint URL will be determined my making a service call to retrieve it.
        /// </remarks>
        /// <param name="client">The MachineLearning client that will be used to make requests.</param>
        /// <param name="modelId">The MachineLearning model to predict against.</param>
        public RealtimePredictor(IAmazonMachineLearning client, string modelId)
        {
            this.client = client;
            this.ModelId = modelId;
        }

        /// <summary>
        /// Constructs a RealtimePredictor which will use the passed in client to make requests.
        /// </summary>
        /// <param name="client">The MachineLearning client that will be used to make requests.</param>
        /// <param name="modelId">The MachineLearning model to predict against.</param>
        /// <param name="endpoint">The endpoint to send requests to.</param>
        public RealtimePredictor(IAmazonMachineLearning client, string modelId, string endpoint)
        {
            this.client = client;
            this.ModelId = modelId;
            this.endpoint = endpoint;
        }

        /// <summary>
        /// The Id of the MachineLearning model.
        /// </summary>
        public string ModelId { get; private set; }

        #region Dispose Pattern Implementation

        /// <summary>
        /// Implements the Dispose pattern
        /// </summary>
        /// <param name="disposing">Whether this object is being disposed via a call to Dispose
        /// or garbage collected.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!isDisposed)
            {
                if (disposing && client != null && shouldDispose)
                {
                    client.Dispose();
                    client = null;
                }
                isDisposed = true;
            }
        }

        /// <summary>
        /// Disposes of all managed and unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }

}
   