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
    /// Coinbase CDP configuration output with secret ARNs
    /// </summary>
    public partial class CoinbaseCdpConfigurationOutput
    {
        private string _apiKeyId;
        private Secret _apiKeySecretArn;
        private Secret _walletSecretArn;

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

    }
}