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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property ApiKeyId. 
        /// <para>
        /// The API key identifier provided by Coinbase Developer Platform.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string ApiKeyId { get; set; }

        /// <summary>
        /// Checks to see if the ApiKeyId property is set.
        /// </summary>
        internal bool IsSetApiKeyId() => this.ApiKeyId != null;

        /// <summary>
        /// Gets and sets the property ApiKeySecret. 
        /// <para>
        /// The API key secret provided by Coinbase Developer Platform.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 2048)]
        public string ApiKeySecret { get; set; }

        /// <summary>
        /// Checks to see if the ApiKeySecret property is set.
        /// </summary>
        internal bool IsSetApiKeySecret() => this.ApiKeySecret != null;

        /// <summary>
        /// Gets and sets the property ApiKeySecretConfig. 
        /// <para>
        /// A reference to the Amazon Web Services Secrets Manager secret that stores the API
        /// key secret. This includes the secret ID and the JSON key used to extract the API key
        /// secret value from the secret. Required when <c>apiKeySecretSource</c> is set to <c>EXTERNAL</c>.
        /// </para>
        /// </summary>
        public SecretReference ApiKeySecretConfig { get; set; }

        /// <summary>
        /// Checks to see if the ApiKeySecretConfig property is set.
        /// </summary>
        internal bool IsSetApiKeySecretConfig() => this.ApiKeySecretConfig != null;

        /// <summary>
        /// Gets and sets the property ApiKeySecretSource. 
        /// <para>
        /// The source type of the API key secret for the Coinbase Developer Platform. Use <c>MANAGED</c>
        /// if the secret is managed by the service, or <c>EXTERNAL</c> if you manage the secret
        /// yourself in Amazon Web Services Secrets Manager.
        /// </para>
        /// </summary>
        public SecretSourceType ApiKeySecretSource { get; set; }

        /// <summary>
        /// Checks to see if the ApiKeySecretSource property is set.
        /// </summary>
        internal bool IsSetApiKeySecretSource() => this.ApiKeySecretSource != null;

        /// <summary>
        /// Gets and sets the property WalletSecret. 
        /// <para>
        /// The wallet secret provided by Coinbase Developer Platform.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 2048)]
        public string WalletSecret { get; set; }

        /// <summary>
        /// Checks to see if the WalletSecret property is set.
        /// </summary>
        internal bool IsSetWalletSecret() => this.WalletSecret != null;

        /// <summary>
        /// Gets and sets the property WalletSecretConfig. 
        /// <para>
        /// A reference to the Amazon Web Services Secrets Manager secret that stores the wallet
        /// secret. This includes the secret ID and the JSON key used to extract the wallet secret
        /// value from the secret. Required when <c>walletSecretSource</c> is set to <c>EXTERNAL</c>.
        /// </para>
        /// </summary>
        public SecretReference WalletSecretConfig { get; set; }

        /// <summary>
        /// Checks to see if the WalletSecretConfig property is set.
        /// </summary>
        internal bool IsSetWalletSecretConfig() => this.WalletSecretConfig != null;

        /// <summary>
        /// Gets and sets the property WalletSecretSource. 
        /// <para>
        /// The source type of the wallet secret for the Coinbase Developer Platform. Use <c>MANAGED</c>
        /// if the secret is managed by the service, or <c>EXTERNAL</c> if you manage the secret
        /// yourself in Amazon Web Services Secrets Manager.
        /// </para>
        /// </summary>
        public SecretSourceType WalletSecretSource { get; set; }

        /// <summary>
        /// Checks to see if the WalletSecretSource property is set.
        /// </summary>
        internal bool IsSetWalletSecretSource() => this.WalletSecretSource != null;
    }
}
