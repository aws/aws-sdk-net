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
    /// Configuration settings for connecting to a supported OAuth2 provider. This includes
    /// client credentials and OAuth2 discovery information for providers that have built-in
    /// support.
    /// </summary>
    public partial class IncludedOauth2ProviderConfigInput
    {
        /// <summary>
        /// Gets and sets the property AuthorizationEndpoint. 
        /// <para>
        /// OAuth2 authorization endpoint for your isolated OAuth2 application tenant. This is
        /// where users are redirected to authenticate and authorize access to their resources.
        /// </para>
        /// </summary>
        public string AuthorizationEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationEndpoint property is set.
        /// </summary>
        internal bool IsSetAuthorizationEndpoint() => this.AuthorizationEndpoint != null;

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The client ID for the supported OAuth2 provider. This identifier is assigned by the
        /// OAuth2 provider when you register your application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;

        /// <summary>
        /// Gets and sets the property ClientSecret. 
        /// <para>
        /// The client secret for the supported OAuth2 provider. This secret is assigned by the
        /// OAuth2 provider and used along with the client ID to authenticate your application.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 2048)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Checks to see if the ClientSecret property is set.
        /// </summary>
        internal bool IsSetClientSecret() => this.ClientSecret != null;

        /// <summary>
        /// Gets and sets the property ClientSecretConfig. 
        /// <para>
        /// A reference to the Amazon Web Services Secrets Manager secret that stores the client
        /// secret. This includes the secret ID and the JSON key used to extract the client secret
        /// value from the secret. Required when <c>clientSecretSource</c> is set to <c>EXTERNAL</c>.
        /// </para>
        /// </summary>
        public SecretReference ClientSecretConfig { get; set; }

        /// <summary>
        /// Checks to see if the ClientSecretConfig property is set.
        /// </summary>
        internal bool IsSetClientSecretConfig() => this.ClientSecretConfig != null;

        /// <summary>
        /// Gets and sets the property ClientSecretSource. 
        /// <para>
        /// The source type of the client secret. Use <c>MANAGED</c> if the secret is managed
        /// by the service, or <c>EXTERNAL</c> if you manage the secret yourself in Amazon Web
        /// Services Secrets Manager.
        /// </para>
        /// </summary>
        public SecretSourceType ClientSecretSource { get; set; }

        /// <summary>
        /// Checks to see if the ClientSecretSource property is set.
        /// </summary>
        internal bool IsSetClientSecretSource() => this.ClientSecretSource != null;

        /// <summary>
        /// Gets and sets the property Issuer. 
        /// <para>
        /// Token issuer of your isolated OAuth2 application tenant. This URL identifies the authorization
        /// server that issues tokens for this provider.
        /// </para>
        /// </summary>
        public string Issuer { get; set; }

        /// <summary>
        /// Checks to see if the Issuer property is set.
        /// </summary>
        internal bool IsSetIssuer() => this.Issuer != null;

        /// <summary>
        /// Gets and sets the property TokenEndpoint. 
        /// <para>
        /// OAuth2 token endpoint for your isolated OAuth2 application tenant. This is where authorization
        /// codes are exchanged for access tokens.
        /// </para>
        /// </summary>
        public string TokenEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the TokenEndpoint property is set.
        /// </summary>
        internal bool IsSetTokenEndpoint() => this.TokenEndpoint != null;
    }
}
