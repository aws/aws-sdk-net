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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// The configuration for a provider-based inference target. This configuration explicitly
    /// defines the endpoint, model mapping, and operations used to route requests to a large
    /// language model (LLM) provider.
    /// </summary>
    public partial class InferenceProviderTargetConfiguration
    {
        private string _endpoint;
        private ModelMapping _modelMapping;
        private List<InferenceOperationConfiguration> _operations = AWSConfigs.InitializeCollections ? new List<InferenceOperationConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The HTTPS endpoint of the inference provider that the gateway forwards requests to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

        /// <summary>
        /// Gets and sets the property ModelMapping. 
        /// <para>
        /// The configuration that translates client-facing model IDs to the model IDs expected
        /// by the provider.
        /// </para>
        /// </summary>
        public ModelMapping ModelMapping
        {
            get { return this._modelMapping; }
            set { this._modelMapping = value; }
        }

        // Check to see if ModelMapping property is set
        internal bool IsSetModelMapping()
        {
            return this._modelMapping != null;
        }

        /// <summary>
        /// Gets and sets the property Operations. 
        /// <para>
        /// A list of per-operation configurations that map request paths to the models supported
        /// for each operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<InferenceOperationConfiguration> Operations
        {
            get { return this._operations; }
            set { this._operations = value; }
        }

        // Check to see if Operations property is set
        internal bool IsSetOperations()
        {
            return this._operations != null && (this._operations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}