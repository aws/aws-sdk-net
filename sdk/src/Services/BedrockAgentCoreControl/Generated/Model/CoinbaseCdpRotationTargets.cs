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
    /// Specifies the service-managed Coinbase CDP secrets to rotate.
    /// </summary>
    public partial class CoinbaseCdpRotationTargets
    {
        private List<string> _secrets = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Secrets. 
        /// <para>
        /// The secrets to rotate. Specify at least one value. Each secret that you specify is
        /// rotated independently.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>API_KEY</c> - The API key that the payment connector uses to call Coinbase CDP.
        /// Rotate it as routine maintenance, or if you suspect that it is compromised.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WALLET_SECRET</c> - The wallet secret that signs transactions. Rotate it only
        /// if it is lost or compromised. Coinbase CDP allows one wallet secret per project, so
        /// it is replaced in place and signing can be briefly interrupted.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<string> Secrets
        {
            get { return this._secrets; }
            set { this._secrets = value; }
        }

        // Check to see if Secrets property is set
        internal bool IsSetSecrets()
        {
            return this._secrets != null && (this._secrets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}