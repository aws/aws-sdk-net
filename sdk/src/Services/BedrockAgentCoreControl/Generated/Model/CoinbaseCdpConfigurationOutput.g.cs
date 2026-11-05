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
    /// Coinbase CDP configuration output with secret ARNs.
    /// </summary>
    public partial class CoinbaseCdpConfigurationOutput
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
        /// Gets and sets the property ApiKeySecretArn.
        /// </summary>
        [AWSProperty(Required = true)]
        public Secret ApiKeySecretArn { get; set; }

        /// <summary>
        /// Checks to see if the ApiKeySecretArn property is set.
        /// </summary>
        internal bool IsSetApiKeySecretArn() => this.ApiKeySecretArn != null;

        /// <summary>
        /// Gets and sets the property ApiKeySecretJsonKey. 
        /// <para>
        /// The JSON key used to extract the API key secret value from the Amazon Web Services
        /// Secrets Manager secret.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ApiKeySecretJsonKey { get; set; }

        /// <summary>
        /// Checks to see if the ApiKeySecretJsonKey property is set.
        /// </summary>
        internal bool IsSetApiKeySecretJsonKey() => this.ApiKeySecretJsonKey != null;

        /// <summary>
        /// Gets and sets the property ApiKeySecretSource. 
        /// <para>
        /// The source type of the API key secret. Either <c>MANAGED</c> if the secret is managed
        /// by the service, or <c>EXTERNAL</c> if managed by the user in Amazon Web Services Secrets
        /// Manager.
        /// </para>
        /// </summary>
        public SecretSourceType ApiKeySecretSource { get; set; }

        /// <summary>
        /// Checks to see if the ApiKeySecretSource property is set.
        /// </summary>
        internal bool IsSetApiKeySecretSource() => this.ApiKeySecretSource != null;

        /// <summary>
        /// Gets and sets the property WalletSecretArn.
        /// </summary>
        [AWSProperty(Required = true)]
        public Secret WalletSecretArn { get; set; }

        /// <summary>
        /// Checks to see if the WalletSecretArn property is set.
        /// </summary>
        internal bool IsSetWalletSecretArn() => this.WalletSecretArn != null;

        /// <summary>
        /// Gets and sets the property WalletSecretJsonKey. 
        /// <para>
        /// The JSON key used to extract the wallet secret value from the Amazon Web Services
        /// Secrets Manager secret.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string WalletSecretJsonKey { get; set; }

        /// <summary>
        /// Checks to see if the WalletSecretJsonKey property is set.
        /// </summary>
        internal bool IsSetWalletSecretJsonKey() => this.WalletSecretJsonKey != null;

        /// <summary>
        /// Gets and sets the property WalletSecretSource. 
        /// <para>
        /// The source type of the wallet secret. Either <c>MANAGED</c> if the secret is managed
        /// by the service, or <c>EXTERNAL</c> if managed by the user in Amazon Web Services Secrets
        /// Manager.
        /// </para>
        /// </summary>
        public SecretSourceType WalletSecretSource { get; set; }

        /// <summary>
        /// Checks to see if the WalletSecretSource property is set.
        /// </summary>
        internal bool IsSetWalletSecretSource() => this.WalletSecretSource != null;
    }
}
