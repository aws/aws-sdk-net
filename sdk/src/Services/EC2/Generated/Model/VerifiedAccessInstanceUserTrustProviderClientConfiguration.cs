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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the trust provider.
    /// </summary>
    public partial class VerifiedAccessInstanceUserTrustProviderClientConfiguration
    {
        private string _authorizationEndpoint;
        private string _clientId;
        private string _clientSecret;
        private string _issuer;
        private bool? _pkceEnabled;
        private string _publicSigningKeyEndpoint;
        private string _scopes;
        private string _tokenEndpoint;
        private UserTrustProviderType _type;
        private string _userInfoEndpoint;

        /// <summary>
        /// Gets and sets the property AuthorizationEndpoint. 
        /// <para>
        /// The authorization endpoint of the IdP.
        /// </para>
        /// </summary>
        public string AuthorizationEndpoint
        {
            get { return this._authorizationEndpoint; }
            set { this._authorizationEndpoint = value; }
        }

        // Check to see if AuthorizationEndpoint property is set
        internal bool IsSetAuthorizationEndpoint()
        {
            return this._authorizationEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The OAuth 2.0 client identifier.
        /// </para>
        /// </summary>
        public string ClientId
        {
            get { return this._clientId; }
            set { this._clientId = value; }
        }

        // Check to see if ClientId property is set
        internal bool IsSetClientId()
        {
            return this._clientId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientSecret. 
        /// <para>
        /// The OAuth 2.0 client secret.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string ClientSecret
        {
            get { return this._clientSecret; }
            set { this._clientSecret = value; }
        }

        // Check to see if ClientSecret property is set
        internal bool IsSetClientSecret()
        {
            return this._clientSecret != null;
        }

        /// <summary>
        /// Gets and sets the property Issuer. 
        /// <para>
        /// The OIDC issuer identifier of the IdP.
        /// </para>
        /// </summary>
        public string Issuer
        {
            get { return this._issuer; }
            set { this._issuer = value; }
        }

        // Check to see if Issuer property is set
        internal bool IsSetIssuer()
        {
            return this._issuer != null;
        }

        /// <summary>
        /// Gets and sets the property PkceEnabled. 
        /// <para>
        /// Indicates whether Proof of Key Code Exchange (PKCE) is enabled.
        /// </para>
        /// </summary>
        public bool? PkceEnabled
        {
            get { return this._pkceEnabled; }
            set { this._pkceEnabled = value; }
        }

        // Check to see if PkceEnabled property is set
        internal bool IsSetPkceEnabled()
        {
            return this._pkceEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PublicSigningKeyEndpoint. 
        /// <para>
        /// The public signing key endpoint.
        /// </para>
        /// </summary>
        public string PublicSigningKeyEndpoint
        {
            get { return this._publicSigningKeyEndpoint; }
            set { this._publicSigningKeyEndpoint = value; }
        }

        // Check to see if PublicSigningKeyEndpoint property is set
        internal bool IsSetPublicSigningKeyEndpoint()
        {
            return this._publicSigningKeyEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property Scopes. 
        /// <para>
        /// The set of user claims to be requested from the IdP.
        /// </para>
        /// </summary>
        public string Scopes
        {
            get { return this._scopes; }
            set { this._scopes = value; }
        }

        // Check to see if Scopes property is set
        internal bool IsSetScopes()
        {
            return this._scopes != null;
        }

        /// <summary>
        /// Gets and sets the property TokenEndpoint. 
        /// <para>
        /// The token endpoint of the IdP.
        /// </para>
        /// </summary>
        public string TokenEndpoint
        {
            get { return this._tokenEndpoint; }
            set { this._tokenEndpoint = value; }
        }

        // Check to see if TokenEndpoint property is set
        internal bool IsSetTokenEndpoint()
        {
            return this._tokenEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The trust provider type.
        /// </para>
        /// </summary>
        public UserTrustProviderType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UserInfoEndpoint. 
        /// <para>
        /// The user info endpoint of the IdP.
        /// </para>
        /// </summary>
        public string UserInfoEndpoint
        {
            get { return this._userInfoEndpoint; }
            set { this._userInfoEndpoint = value; }
        }

        // Check to see if UserInfoEndpoint property is set
        internal bool IsSetUserInfoEndpoint()
        {
            return this._userInfoEndpoint != null;
        }

    }
}