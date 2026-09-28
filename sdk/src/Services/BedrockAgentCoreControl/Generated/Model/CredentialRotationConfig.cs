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
    /// Specifies the service-managed credentials to rotate. Provide the member that matches
    /// the payment connector's <c>type</c>.
    /// </summary>
    public partial class CredentialRotationConfig
    {
        private CoinbaseCdpRotationTargets _coinbasecdp;

        /// <summary>
        /// Gets and sets the property CoinbaseCDP. 
        /// <para>
        /// The credentials to rotate for a Coinbase CDP payment connector.
        /// </para>
        /// </summary>
        public CoinbaseCdpRotationTargets CoinbaseCDP
        {
            get { return this._coinbasecdp; }
            set { this._coinbasecdp = value; }
        }

        // Check to see if CoinbaseCDP property is set
        internal bool IsSetCoinbaseCDP()
        {
            return this._coinbasecdp != null;
        }

    }
}