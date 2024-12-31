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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateMarketplaceModelEndpoint operation.
    /// Updates the configuration of an existing endpoint for a model from Amazon Bedrock
    /// Marketplace.
    /// </summary>
    public partial class UpdateMarketplaceModelEndpointRequest : AmazonBedrockRequest
    {
        private string _clientRequestToken;
        private string _endpointArn;
        private EndpointConfig _endpointConfig;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. This token is listed as not required because Amazon Web Services SDKs
        /// automatically generate it for you and set this parameter. If you're not using the
        /// Amazon Web Services SDK or the CLI, you must provide this token or the action will
        /// fail.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property EndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the endpoint you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string EndpointArn
        {
            get { return this._endpointArn; }
            set { this._endpointArn = value; }
        }

        // Check to see if EndpointArn property is set
        internal bool IsSetEndpointArn()
        {
            return this._endpointArn != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointConfig. 
        /// <para>
        /// The new configuration for the endpoint, including the number and type of instances
        /// to use.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EndpointConfig EndpointConfig
        {
            get { return this._endpointConfig; }
            set { this._endpointConfig = value; }
        }

        // Check to see if EndpointConfig property is set
        internal bool IsSetEndpointConfig()
        {
            return this._endpointConfig != null;
        }

    }
}