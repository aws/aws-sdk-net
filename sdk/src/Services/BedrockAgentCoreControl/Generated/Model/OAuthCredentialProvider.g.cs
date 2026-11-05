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
    /// An OAuth credential provider for gateway authentication. This structure contains the
    /// configuration for authenticating with the target endpoint using OAuth.
    /// </summary>
    public partial class OAuthCredentialProvider
    {
        /// <summary>
        /// Gets and sets the property CustomParameters. 
        /// <para>
        /// The custom parameters for the OAuth credential provider. These parameters provide
        /// additional configuration for the OAuth authentication process.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public Dictionary<string, string> CustomParameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the CustomParameters property is set.
        /// </summary>
        internal bool IsSetCustomParameters() => this.CustomParameters != null && (this.CustomParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DefaultReturnUrl. 
        /// <para>
        /// The URL where the end user's browser is redirected after obtaining the authorization
        /// code. Generally points to the customer's application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string DefaultReturnUrl { get; set; }

        /// <summary>
        /// Checks to see if the DefaultReturnUrl property is set.
        /// </summary>
        internal bool IsSetDefaultReturnUrl() => this.DefaultReturnUrl != null;

        /// <summary>
        /// Gets and sets the property GrantType. 
        /// <para>
        /// Specifies the kind of credentials to use for authorization:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CLIENT_CREDENTIALS</c> - Authorization with a client ID and secret.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AUTHORIZATION_CODE</c> - Authorization with a token that is specific to an individual
        /// end user.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TOKEN_EXCHANGE</c> - Authorization using on-behalf-of token exchange. An inbound
        /// user token is exchanged for a downstream access token scoped to the target audience.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public OAuthGrantType GrantType { get; set; }

        /// <summary>
        /// Checks to see if the GrantType property is set.
        /// </summary>
        internal bool IsSetGrantType() => this.GrantType != null;

        /// <summary>
        /// Gets and sets the property ProviderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the OAuth credential provider. This ARN identifies
        /// the provider in Amazon Web Services.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ProviderArn { get; set; }

        /// <summary>
        /// Checks to see if the ProviderArn property is set.
        /// </summary>
        internal bool IsSetProviderArn() => this.ProviderArn != null;

        /// <summary>
        /// Gets and sets the property Scopes. 
        /// <para>
        /// The OAuth scopes for the credential provider. These scopes define the level of access
        /// requested from the OAuth provider.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Max = 100)]
        public List<string> Scopes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Scopes property is set.
        /// </summary>
        internal bool IsSetScopes() => this.Scopes != null && (this.Scopes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
