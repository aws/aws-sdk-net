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

namespace Amazon.SSOOIDC.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTokenWithIAM operation.
    /// Creates and returns access and refresh tokens for clients and applications that are
    /// authenticated using IAM entities. The access token can be used to fetch short-term
    /// credentials for the assigned AWS accounts or to access application APIs using <c>bearer</c>
    /// authentication.
    /// </summary>
    public partial class CreateTokenWithIAMRequest : AmazonSSOOIDCRequest
    {
        private string _assertion;
        private string _clientId;
        private string _code;
        private string _grantType;
        private string _redirectUri;
        private string _refreshToken;
        private string _requestedTokenType;
        private List<string> _scope = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _subjectToken;
        private string _subjectTokenType;

        /// <summary>
        /// Gets and sets the property Assertion. 
        /// <para>
        /// Used only when calling this API for the JWT Bearer grant type. This value specifies
        /// the JSON Web Token (JWT) issued by a trusted token issuer. To authorize a trusted
        /// token issuer, configure the JWT Bearer GrantOptions for the application.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Assertion
        {
            get { return this._assertion; }
            set { this._assertion = value; }
        }

        // Check to see if Assertion property is set
        internal bool IsSetAssertion()
        {
            return this._assertion != null;
        }

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The unique identifier string for the client or application. This value is an application
        /// ARN that has OAuth grants configured.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Code. 
        /// <para>
        /// Used only when calling this API for the Authorization Code grant type. This short-term
        /// code is used to identify this authorization request. The code is obtained through
        /// a redirect from IAM Identity Center to a redirect URI persisted in the Authorization
        /// Code GrantOptions for the application.
        /// </para>
        /// </summary>
        public string Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property GrantType. 
        /// <para>
        /// Supports the following OAuth grant types: Authorization Code, Refresh Token, JWT Bearer,
        /// and Token Exchange. Specify one of the following values, depending on the grant type
        /// that you want:
        /// </para>
        ///  
        /// <para>
        /// * Authorization Code - <c>authorization_code</c> 
        /// </para>
        ///  
        /// <para>
        /// * Refresh Token - <c>refresh_token</c> 
        /// </para>
        ///  
        /// <para>
        /// * JWT Bearer - <c>urn:ietf:params:oauth:grant-type:jwt-bearer</c> 
        /// </para>
        ///  
        /// <para>
        /// * Token Exchange - <c>urn:ietf:params:oauth:grant-type:token-exchange</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GrantType
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
        /// Gets and sets the property RedirectUri. 
        /// <para>
        /// Used only when calling this API for the Authorization Code grant type. This value
        /// specifies the location of the client or application that has registered to receive
        /// the authorization code. 
        /// </para>
        /// </summary>
        public string RedirectUri
        {
            get { return this._redirectUri; }
            set { this._redirectUri = value; }
        }

        // Check to see if RedirectUri property is set
        internal bool IsSetRedirectUri()
        {
            return this._redirectUri != null;
        }

        /// <summary>
        /// Gets and sets the property RefreshToken. 
        /// <para>
        /// Used only when calling this API for the Refresh Token grant type. This token is used
        /// to refresh short-term tokens, such as the access token, that might expire.
        /// </para>
        ///  
        /// <para>
        /// For more information about the features and limitations of the current IAM Identity
        /// Center OIDC implementation, see <i>Considerations for Using this Guide</i> in the
        /// <a href="https://docs.aws.amazon.com/singlesignon/latest/OIDCAPIReference/Welcome.html">IAM
        /// Identity Center OIDC API Reference</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string RefreshToken
        {
            get { return this._refreshToken; }
            set { this._refreshToken = value; }
        }

        // Check to see if RefreshToken property is set
        internal bool IsSetRefreshToken()
        {
            return this._refreshToken != null;
        }

        /// <summary>
        /// Gets and sets the property RequestedTokenType. 
        /// <para>
        /// Used only when calling this API for the Token Exchange grant type. This value specifies
        /// the type of token that the requester can receive. The following values are supported:
        /// </para>
        ///  
        /// <para>
        /// * Access Token - <c>urn:ietf:params:oauth:token-type:access_token</c> 
        /// </para>
        ///  
        /// <para>
        /// * Refresh Token - <c>urn:ietf:params:oauth:token-type:refresh_token</c> 
        /// </para>
        /// </summary>
        public string RequestedTokenType
        {
            get { return this._requestedTokenType; }
            set { this._requestedTokenType = value; }
        }

        // Check to see if RequestedTokenType property is set
        internal bool IsSetRequestedTokenType()
        {
            return this._requestedTokenType != null;
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// The list of scopes for which authorization is requested. The access token that is
        /// issued is limited to the scopes that are granted. If the value is not specified, IAM
        /// Identity Center authorizes all scopes configured for the application, including the
        /// following default scopes: <c>openid</c>, <c>aws</c>, <c>sts:identity_context</c>.
        /// </para>
        /// </summary>
        public List<string> Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null && (this._scope.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SubjectToken. 
        /// <para>
        /// Used only when calling this API for the Token Exchange grant type. This value specifies
        /// the subject of the exchange. The value of the subject token must be an access token
        /// issued by IAM Identity Center to a different client or application. The access token
        /// must have authorized scopes that indicate the requested application as a target audience.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string SubjectToken
        {
            get { return this._subjectToken; }
            set { this._subjectToken = value; }
        }

        // Check to see if SubjectToken property is set
        internal bool IsSetSubjectToken()
        {
            return this._subjectToken != null;
        }

        /// <summary>
        /// Gets and sets the property SubjectTokenType. 
        /// <para>
        /// Used only when calling this API for the Token Exchange grant type. This value specifies
        /// the type of token that is passed as the subject of the exchange. The following value
        /// is supported:
        /// </para>
        ///  
        /// <para>
        /// * Access Token - <c>urn:ietf:params:oauth:token-type:access_token</c> 
        /// </para>
        /// </summary>
        public string SubjectTokenType
        {
            get { return this._subjectTokenType; }
            set { this._subjectTokenType = value; }
        }

        // Check to see if SubjectTokenType property is set
        internal bool IsSetSubjectTokenType()
        {
            return this._subjectTokenType != null;
        }

    }
}