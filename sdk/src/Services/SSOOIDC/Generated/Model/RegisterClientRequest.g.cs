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

namespace Amazon.SSOOIDC.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterClient operation. Registers a public client
    /// with IAM Identity Center. This allows clients to perform authorization using the authorization
    /// code grant with Proof Key for Code Exchange (PKCE) or the device code grant.
    /// </summary>
    public partial class RegisterClientRequest : AmazonSSOOIDCRequest
    {
        /// <summary>
        /// Gets and sets the property ClientName. 
        /// <para>
        /// The friendly name of the client.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClientName { get; set; }

        /// <summary>
        /// Checks to see if the ClientName property is set.
        /// </summary>
        internal bool IsSetClientName() => this.ClientName != null;

        /// <summary>
        /// Gets and sets the property ClientType. 
        /// <para>
        /// The type of client. The service supports only <c>public</c> as a client type. Anything
        /// other than public will be rejected by the service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClientType { get; set; }

        /// <summary>
        /// Checks to see if the ClientType property is set.
        /// </summary>
        internal bool IsSetClientType() => this.ClientType != null;

        /// <summary>
        /// Gets and sets the property EntitledApplicationArn. 
        /// <para>
        /// This IAM Identity Center application ARN is used to define administrator-managed configuration
        /// for public client access to resources. At authorization, the scopes, grants, and redirect
        /// URI available to this client will be restricted by this application resource.
        /// </para>
        /// </summary>
        public string EntitledApplicationArn { get; set; }

        /// <summary>
        /// Checks to see if the EntitledApplicationArn property is set.
        /// </summary>
        internal bool IsSetEntitledApplicationArn() => this.EntitledApplicationArn != null;

        /// <summary>
        /// Gets and sets the property GrantTypes. 
        /// <para>
        /// The list of OAuth 2.0 grant types that are defined by the client. This list is used
        /// to restrict the token granting flows available to the client. Supports the following
        /// OAuth 2.0 grant types: Authorization Code, Device Code, and Refresh Token. 
        /// </para>
        ///  
        /// <para>
        /// * Authorization Code - <c>authorization_code</c> 
        /// </para>
        ///  
        /// <para>
        /// * Device Code - <c>urn:ietf:params:oauth:grant-type:device_code</c> 
        /// </para>
        ///  
        /// <para>
        /// * Refresh Token - <c>refresh_token</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> GrantTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the GrantTypes property is set.
        /// </summary>
        internal bool IsSetGrantTypes() => this.GrantTypes != null && (this.GrantTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IssuerUrl. 
        /// <para>
        /// The IAM Identity Center Issuer URL associated with an instance of IAM Identity Center.
        /// This value is needed for user access to resources through the client.
        /// </para>
        /// </summary>
        public string IssuerUrl { get; set; }

        /// <summary>
        /// Checks to see if the IssuerUrl property is set.
        /// </summary>
        internal bool IsSetIssuerUrl() => this.IssuerUrl != null;

        /// <summary>
        /// Gets and sets the property RedirectUris. 
        /// <para>
        /// The list of redirect URI that are defined by the client. At completion of authorization,
        /// this list is used to restrict what locations the user agent can be redirected back
        /// to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RedirectUris { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RedirectUris property is set.
        /// </summary>
        internal bool IsSetRedirectUris() => this.RedirectUris != null && (this.RedirectUris.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Scopes. 
        /// <para>
        /// The list of scopes that are defined by the client. Upon authorization, this list is
        /// used to restrict permissions when granting an access token.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Scopes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Scopes property is set.
        /// </summary>
        internal bool IsSetScopes() => this.Scopes != null && (this.Scopes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
