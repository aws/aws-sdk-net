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
    /// Coinbase CDP configuration output with secret ARNs.
    /// </summary>
    public partial class CoinbaseCdpConfigurationOutput
    {
        private string _apiKeyId;
        private Secret _apiKeySecretArn;
        private string _apiKeySecretJsonKey;
        private SecretSourceType _apiKeySecretSource;
        private Secret _walletSecretArn;
        private string _walletSecretJsonKey;
        private SecretSourceType _walletSecretSource;

        /// <summary>
        /// Gets and sets the property ApiKeyId. 
        /// <para>
        /// The API key identifier provided by Coinbase Developer Platform.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string ApiKeyId
        {
            get { return this._apiKeyId; }
            set { this._apiKeyId = value; }
        }

        // Check to see if ApiKeyId property is set
        internal bool IsSetApiKeyId()
        {
            return this._apiKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property ApiKeySecretArn.
        /// </summary>
        [AWSProperty(Required=true)]
        public Secret ApiKeySecretArn
        {
            get { return this._apiKeySecretArn; }
            set { this._apiKeySecretArn = value; }
        }

        // Check to see if ApiKeySecretArn property is set
        internal bool IsSetApiKeySecretArn()
        {
            return this._apiKeySecretArn != null;
        }

        /// <summary>
        /// Gets and sets the property ApiKeySecretJsonKey. 
        /// <para>
        /// The JSON key used to extract the API key secret value from the Amazon Web Services
        /// Secrets Manager secret.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ApiKeySecretJsonKey
        {
            get { return this._apiKeySecretJsonKey; }
            set { this._apiKeySecretJsonKey = value; }
        }

        // Check to see if ApiKeySecretJsonKey property is set
        internal bool IsSetApiKeySecretJsonKey()
        {
            return this._apiKeySecretJsonKey != null;
        }

        /// <summary>
        /// Gets and sets the property ApiKeySecretSource. 
        /// <para>
        /// The source type of the API key secret. Either <c>MANAGED</c> if the secret is managed
        /// by the service, or <c>EXTERNAL</c> if managed by the user in Amazon Web Services Secrets
        /// Manager.
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
        /// Gets and sets the property WalletSecretArn.
        /// </summary>
        [AWSProperty(Required=true)]
        public Secret WalletSecretArn
        {
            get { return this._walletSecretArn; }
            set { this._walletSecretArn = value; }
        }

        // Check to see if WalletSecretArn property is set
        internal bool IsSetWalletSecretArn()
        {
            return this._walletSecretArn != null;
        }

        /// <summary>
        /// Gets and sets the property WalletSecretJsonKey. 
        /// <para>
        /// The JSON key used to extract the wallet secret value from the Amazon Web Services
        /// Secrets Manager secret.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string WalletSecretJsonKey
        {
            get { return this._walletSecretJsonKey; }
            set { this._walletSecretJsonKey = value; }
        }

        // Check to see if WalletSecretJsonKey property is set
        internal bool IsSetWalletSecretJsonKey()
        {
            return this._walletSecretJsonKey != null;
        }

        /// <summary>
        /// Gets and sets the property WalletSecretSource. 
        /// <para>
        /// The source type of the wallet secret. Either <c>MANAGED</c> if the secret is managed
        /// by the service, or <c>EXTERNAL</c> if managed by the user in Amazon Web Services Secrets
        /// Manager.
        /// </para>
        /// </summary>
        public SecretSourceType WalletSecretSource
        {
            get { return this._walletSecretSource; }
            set { this._walletSecretSource = value; }
        }

        // Check to see if WalletSecretSource property is set
        internal bool IsSetWalletSecretSource()
        {
            return this._walletSecretSource != null;
        }

    }
}