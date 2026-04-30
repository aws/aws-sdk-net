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
    /// Configuration for on-behalf-of token exchange
    /// </summary>
    public partial class OnBehalfOfTokenExchangeConfigType
    {
        private OnBehalfOfTokenExchangeGrantTypeType _grantType;
        private TokenExchangeGrantTypeConfigType _tokenExchangeGrantTypeConfig;

        /// <summary>
        /// Gets and sets the property GrantType. 
        /// <para>
        /// The grant type for the on-behalf-of token exchange.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OnBehalfOfTokenExchangeGrantTypeType GrantType
        {
            get { return this._grantType; }
            set { this._grantType = value; }
        }

        // Check to see if GrantType property is set
        internal bool IsSetGrantType()
        {
            return this._grantType != null;
        }

        /// <summary>
        /// Gets and sets the property TokenExchangeGrantTypeConfig. 
        /// <para>
        /// Configuration specific to TOKEN_EXCHANGE grant type (RFC 8693)
        /// </para>
        /// </summary>
        public TokenExchangeGrantTypeConfigType TokenExchangeGrantTypeConfig
        {
            get { return this._tokenExchangeGrantTypeConfig; }
            set { this._tokenExchangeGrantTypeConfig = value; }
        }

        // Check to see if TokenExchangeGrantTypeConfig property is set
        internal bool IsSetTokenExchangeGrantTypeConfig()
        {
            return this._tokenExchangeGrantTypeConfig != null;
        }

    }
}