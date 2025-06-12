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
 * Do not modify this file. This file is generated from the sso-oidc-2019-06-10.normal.json service model.
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
    /// Container for the parameters to the RegisterClient operation.
    /// Registers a public client with IAM Identity Center. This allows clients to perform
    /// authorization using the authorization code grant with Proof Key for Code Exchange
    /// (PKCE) or the device code grant.
    /// </summary>
    public partial class RegisterClientRequest : AmazonSSOOIDCRequest
    {
        private string _clientName;
        private string _clientType;
        private string _entitledApplicationArn;
        private List<string> _grantTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _issuerUrl;
        private List<string> _redirectUris = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _scopes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ClientName. 
        /// <para>
        /// The friendly name of the client.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClientName
        {
            get { return this._clientName; }
            set { this._clientName = value; }
        }

        // Check to see if ClientName property is set
        internal bool IsSetClientName()
        {
            return this._clientName != null;
        }

        /// <summary>
        /// Gets and sets the property ClientType. 
        /// <para>
        /// The type of client. The service supports only <c>public</c> as a client type. Anything
        /// other than public will be rejected by the service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClientType
        {
            get { return this._clientType; }
            set { this._clientType = value; }
        }

        // Check to see if ClientType property is set
        internal bool IsSetClientType()
        {
            return this._clientType != null;
        }

        /// <summary>
        /// Gets and sets the property EntitledApplicationArn. 
        /// <para>
        /// This IAM Identity Center application ARN is used to define administrator-managed configuration
        /// for public client access to resources. At authorization, the scopes, grants, and redirect
        /// URI available to this client will be restricted by this application resource.
        /// </para>
        /// </summary>
        public string EntitledApplicationArn
        {
            get { return this._entitledApplicationArn; }
            set { this._entitledApplicationArn = value; }
        }

        // Check to see if EntitledApplicationArn property is set
        internal bool IsSetEntitledApplicationArn()
        {
            return this._entitledApplicationArn != null;
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> GrantTypes
        {
            get { return this._grantTypes; }
            set { this._grantTypes = value; }
        }

        // Check to see if GrantTypes property is set
        internal bool IsSetGrantTypes()
        {
            return this._grantTypes != null && (this._grantTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IssuerUrl. 
        /// <para>
        /// The IAM Identity Center Issuer URL associated with an instance of IAM Identity Center.
        /// This value is needed for user access to resources through the client.
        /// </para>
        /// </summary>
        public string IssuerUrl
        {
            get { return this._issuerUrl; }
            set { this._issuerUrl = value; }
        }

        // Check to see if IssuerUrl property is set
        internal bool IsSetIssuerUrl()
        {
            return this._issuerUrl != null;
        }

        /// <summary>
        /// Gets and sets the property RedirectUris. 
        /// <para>
        /// The list of redirect URI that are defined by the client. At completion of authorization,
        /// this list is used to restrict what locations the user agent can be redirected back
        /// to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RedirectUris
        {
            get { return this._redirectUris; }
            set { this._redirectUris = value; }
        }

        // Check to see if RedirectUris property is set
        internal bool IsSetRedirectUris()
        {
            return this._redirectUris != null && (this._redirectUris.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Scopes. 
        /// <para>
        /// The list of scopes that are defined by the client. Upon authorization, this list is
        /// used to restrict permissions when granting an access token.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Scopes
        {
            get { return this._scopes; }
            set { this._scopes = value; }
        }

        // Check to see if Scopes property is set
        internal bool IsSetScopes()
        {
            return this._scopes != null && (this._scopes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}