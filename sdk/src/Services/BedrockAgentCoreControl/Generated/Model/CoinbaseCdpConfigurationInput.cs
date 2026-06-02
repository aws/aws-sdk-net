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
    /// Coinbase CDP configuration — credentials provided by Coinbase Developer Platform.
    /// </summary>
    public partial class CoinbaseCdpConfigurationInput
    {
        private string _apiKeyId;
        private string _apiKeySecret;
        private SecretReference _apiKeySecretConfig;
        private SecretSourceType _apiKeySecretSource;
        private string _walletSecret;
        private SecretReference _walletSecretConfig;
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
        /// Gets and sets the property ApiKeySecret. 
        /// <para>
        /// The API key secret provided by Coinbase Developer Platform.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=2048)]
        public string ApiKeySecret
        {
            get { return this._apiKeySecret; }
            set { this._apiKeySecret = value; }
        }

        // Check to see if ApiKeySecret property is set
        internal bool IsSetApiKeySecret()
        {
            return this._apiKeySecret != null;
        }

        /// <summary>
        /// Gets and sets the property ApiKeySecretConfig. 
        /// <para>
        /// A reference to the AWS Secrets Manager secret that stores the API key secret. This
        /// includes the secret ID and the JSON key used to extract the API key secret value from
        /// the secret. Required when <c>apiKeySecretSource</c> is set to <c>EXTERNAL</c>.
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
        /// The source type of the API key secret for the Coinbase Developer Platform. Use <c>MANAGED</c>
        /// if the secret is managed by the service, or <c>EXTERNAL</c> if you manage the secret
        /// yourself in AWS Secrets Manager.
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
        /// Gets and sets the property WalletSecret. 
        /// <para>
        /// The wallet secret provided by Coinbase Developer Platform.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=2048)]
        public string WalletSecret
        {
            get { return this._walletSecret; }
            set { this._walletSecret = value; }
        }

        // Check to see if WalletSecret property is set
        internal bool IsSetWalletSecret()
        {
            return this._walletSecret != null;
        }

        /// <summary>
        /// Gets and sets the property WalletSecretConfig. 
        /// <para>
        /// A reference to the AWS Secrets Manager secret that stores the wallet secret. This
        /// includes the secret ID and the JSON key used to extract the wallet secret value from
        /// the secret. Required when <c>walletSecretSource</c> is set to <c>EXTERNAL</c>.
        /// </para>
        /// </summary>
        public SecretReference WalletSecretConfig
        {
            get { return this._walletSecretConfig; }
            set { this._walletSecretConfig = value; }
        }

        // Check to see if WalletSecretConfig property is set
        internal bool IsSetWalletSecretConfig()
        {
            return this._walletSecretConfig != null;
        }

        /// <summary>
        /// Gets and sets the property WalletSecretSource. 
        /// <para>
        /// The source type of the wallet secret for the Coinbase Developer Platform. Use <c>MANAGED</c>
        /// if the secret is managed by the service, or <c>EXTERNAL</c> if you manage the secret
        /// yourself in AWS Secrets Manager.
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