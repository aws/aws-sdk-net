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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Options for an OIDC-based, user-identity type trust provider.
    /// </summary>
    public partial class CreateVerifiedAccessTrustProviderOidcOptions
    {
        private string _authorizationEndpoint;
        private string _clientId;
        private string _clientSecret;
        private string _issuer;
        private string _scope;
        private string _tokenEndpoint;
        private string _userInfoEndpoint;

        /// <summary>
        /// Gets and sets the property AuthorizationEndpoint. 
        /// <para>
        /// The OIDC authorization endpoint.
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
        /// The client identifier.
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
        /// The client secret.
        /// </para>
        /// </summary>
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
        /// The OIDC issuer.
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
        /// Gets and sets the property Scope. 
        /// <para>
        /// OpenID Connect (OIDC) scopes are used by an application during authentication to authorize
        /// access to a user's details. Each scope returns a specific set of user attributes.
        /// </para>
        /// </summary>
        public string Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

        /// <summary>
        /// Gets and sets the property TokenEndpoint. 
        /// <para>
        /// The OIDC token endpoint.
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
        /// Gets and sets the property UserInfoEndpoint. 
        /// <para>
        /// The OIDC user info endpoint.
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