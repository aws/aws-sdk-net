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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Your OIDC IdP workforce configuration.
    /// </summary>
    public partial class OidcConfigForResponse
    {
        private Dictionary<string, string> _authenticationRequestExtraParams = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _authorizationEndpoint;
        private string _clientId;
        private string _issuer;
        private string _jwksUri;
        private string _logoutEndpoint;
        private string _scope;
        private string _tokenEndpoint;
        private string _userInfoEndpoint;

        /// <summary>
        /// Gets and sets the property AuthenticationRequestExtraParams. 
        /// <para>
        /// A string to string map of identifiers specific to the custom identity provider (IdP)
        /// being used.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public Dictionary<string, string> AuthenticationRequestExtraParams
        {
            get { return this._authenticationRequestExtraParams; }
            set { this._authenticationRequestExtraParams = value; }
        }

        // Check to see if AuthenticationRequestExtraParams property is set
        internal bool IsSetAuthenticationRequestExtraParams()
        {
            return this._authenticationRequestExtraParams != null && (this._authenticationRequestExtraParams.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AuthorizationEndpoint. 
        /// <para>
        /// The OIDC IdP authorization endpoint used to configure your private workforce.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
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
        /// The OIDC IdP client ID used to configure your private workforce.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property Issuer. 
        /// <para>
        /// The OIDC IdP issuer used to configure your private workforce.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
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
        /// Gets and sets the property JwksUri. 
        /// <para>
        /// The OIDC IdP JSON Web Key Set (Jwks) URI used to configure your private workforce.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public string JwksUri
        {
            get { return this._jwksUri; }
            set { this._jwksUri = value; }
        }

        // Check to see if JwksUri property is set
        internal bool IsSetJwksUri()
        {
            return this._jwksUri != null;
        }

        /// <summary>
        /// Gets and sets the property LogoutEndpoint. 
        /// <para>
        /// The OIDC IdP logout endpoint used to configure your private workforce.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public string LogoutEndpoint
        {
            get { return this._logoutEndpoint; }
            set { this._logoutEndpoint = value; }
        }

        // Check to see if LogoutEndpoint property is set
        internal bool IsSetLogoutEndpoint()
        {
            return this._logoutEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// An array of string identifiers used to refer to the specific pieces of user data or
        /// claims that the client application wants to access.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// The OIDC IdP token endpoint used to configure your private workforce.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
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
        /// The OIDC IdP user information endpoint used to configure your private workforce.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
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