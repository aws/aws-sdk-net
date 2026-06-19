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
    /// Container for the parameters to the UpdateApiKeyCredentialProvider operation.
    /// Updates an existing API key credential provider.
    /// </summary>
    public partial class UpdateApiKeyCredentialProviderRequest : AmazonBedrockAgentCoreControlRequest
    {
        private string _apiKey;
        private SecretReference _apiKeySecretConfig;
        private SecretSourceType _apiKeySecretSource;
        private string _name;

        /// <summary>
        /// Gets and sets the property ApiKey. 
        /// <para>
        /// The new API key to use for authentication. This value replaces the existing API key
        /// and is encrypted and stored securely.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=65536)]
        public string ApiKey
        {
            get { return this._apiKey; }
            set { this._apiKey = value; }
        }

        // Check to see if ApiKey property is set
        internal bool IsSetApiKey()
        {
            return this._apiKey != null;
        }

        /// <summary>
        /// Gets and sets the property ApiKeySecretConfig. 
        /// <para>
        /// A reference to the Amazon Web Services Secrets Manager secret that stores the API
        /// key. This includes the secret ID and the JSON key used to extract the API key value
        /// from the secret. Required when <c>apiKeySecretSource</c> is set to <c>EXTERNAL</c>.
        /// </para>
        /// </summary>
        public SecretReference ApiKeySecretConfig
        {
            get { return this._apiKeySecretConfig; }
            set { this._apiKeySecretConfig = value; }
        }

        // Check to see if ApiKeySecretConfig property is set
        internal bool IsSetApiKeySecretConfig()
        {
            return this._apiKeySecretConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ApiKeySecretSource. 
        /// <para>
        /// The source type of the API key secret. Use <c>MANAGED</c> if the secret is managed
        /// by the service, or <c>EXTERNAL</c> if you manage the secret yourself in Amazon Web
        /// Services Secrets Manager.
        /// </para>
        /// </summary>
        public SecretSourceType ApiKeySecretSource
        {
            get { return this._apiKeySecretSource; }
            set { this._apiKeySecretSource = value; }
        }

        // Check to see if ApiKeySecretSource property is set
        internal bool IsSetApiKeySecretSource()
        {
            return this._apiKeySecretSource != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the API key credential provider to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}