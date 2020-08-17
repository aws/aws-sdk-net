/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// Container for the parameters to the StartSimulationJobBatch operation.
    /// Starts a new simulation job batch. The batch is defined using one or more <code>SimulationJobRequest</code>
    /// objects.
    /// </summary>
    public partial class StartSimulationJobBatchRequest : AmazonRoboMakerRequest
    {
        private BatchPolicy _batchPolicy;
        private string _clientRequestToken;
        private List<SimulationJobRequest> _createSimulationJobRequests = new List<SimulationJobRequest>();
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property BatchPolicy. 
        /// <para>
        /// The batch policy.
        /// </para>
        /// </summary>
        public BatchPolicy BatchPolicy
        {
            get { return this._batchPolicy; }
            set { this._batchPolicy = value; }
        }

        // Check to see if BatchPolicy property is set
        internal bool IsSetBatchPolicy()
        {
            return this._batchPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property CreateSimulationJobRequests. 
        /// <para>
        /// A list of simulation job requests to create in the batch.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
        public List<SimulationJobRequest> CreateSimulationJobRequests
        {
            get { return this._createSimulationJobRequests; }
            set { this._createSimulationJobRequests = value; }
        }

        // Check to see if CreateSimulationJobRequests property is set
        internal bool IsSetCreateSimulationJobRequests()
        {
            return this._createSimulationJobRequests != null && this._createSimulationJobRequests.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map that contains tag keys and tag values that are attached to the deployment job
        /// batch.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}