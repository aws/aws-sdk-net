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
    /// Configuration for on-behalf-of token exchange.
    /// </summary>
    public partial class OnBehalfOfTokenExchangeConfigType
    {
        /// <summary>
        /// Gets and sets the property GrantType. 
        /// <para>
        /// The grant type for the on-behalf-of token exchange.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OnBehalfOfTokenExchangeGrantTypeType GrantType { get; set; }

        /// <summary>
        /// Checks to see if the GrantType property is set.
        /// </summary>
        internal bool IsSetGrantType() => this.GrantType != null;

        /// <summary>
        /// Gets and sets the property OnBehalfOfAuthenticationConfig. 
        /// <para>
        /// Specify the client authentication configuration to use for the on-behalf-of token
        /// exchange. With this configuration, you override the provider level client authentication
        /// method for the on-behalf-of exchange with the identity provider. If you don't specify
        /// this configuration, we use the provider level client authentication method.
        /// </para>
        /// </summary>
        public OnBehalfOfAuthenticationConfig OnBehalfOfAuthenticationConfig { get; set; }

        /// <summary>
        /// Checks to see if the OnBehalfOfAuthenticationConfig property is set.
        /// </summary>
        internal bool IsSetOnBehalfOfAuthenticationConfig() => this.OnBehalfOfAuthenticationConfig != null;

        /// <summary>
        /// Gets and sets the property TokenExchangeGrantTypeConfig. 
        /// <para>
        /// Configuration specific to the TOKEN_EXCHANGE grant type (RFC 8693).
        /// </para>
        /// </summary>
        public TokenExchangeGrantTypeConfigType TokenExchangeGrantTypeConfig { get; set; }

        /// <summary>
        /// Checks to see if the TokenExchangeGrantTypeConfig property is set.
        /// </summary>
        internal bool IsSetTokenExchangeGrantTypeConfig() => this.TokenExchangeGrantTypeConfig != null;
    }
}
