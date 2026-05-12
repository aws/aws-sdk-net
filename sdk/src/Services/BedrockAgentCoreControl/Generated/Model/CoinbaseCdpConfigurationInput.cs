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
    /// Coinbase CDP configuration - credentials provided by Coinbase Developer Platform
    /// </summary>
    public partial class CoinbaseCdpConfigurationInput
    {
        private string _apiKeyId;
        private string _apiKeySecret;
        private string _walletSecret;

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
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=2048)]
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
        /// Gets and sets the property WalletSecret. 
        /// <para>
        /// The wallet secret provided by Coinbase Developer Platform.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=2048)]
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

    }
}