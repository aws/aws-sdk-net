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
using Amazon.Runtime.Internal.Auth;

namespace Amazon.SSOOIDC.Model
{
    /// <summary>
    /// Container for the parameters to the CreateToken operation.
    /// Creates and returns an access token for the authorized client. The access token issued
    /// will be used to fetch short-term credentials for the assigned roles in the AWS account.
    /// </summary>
    public partial class CreateTokenRequest : AmazonSSOOIDCRequest
    {
        private string _clientId;
        private string _clientSecret;
        private string _code;
        private string _deviceCode;
        private string _grantType;
        private string _redirectUri;
        private string _refreshToken;
        private List<string> _scope = new List<string>();

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The unique identifier string for each client. This value should come from the persisted
        /// result of the <a>RegisterClient</a> API.
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
        /// Gets and sets the property ClientSecret. 
        /// <para>
        /// A secret string generated for the client. This value should come from the persisted
        /// result of the <a>RegisterClient</a> API.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Code. 
        /// <para>
        /// The authorization code received from the authorization service. This parameter is
        /// required to perform an authorization grant request to get access to a token.
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
        /// Gets and sets the property DeviceCode. 
        /// <para>
        /// Used only when calling this API for the device code grant type. This short-term code
        /// is used to identify this authentication attempt. This should come from an in-memory
        /// reference to the result of the <a>StartDeviceAuthorization</a> API.
        /// </para>
        /// </summary>
        public string DeviceCode
        {
            get { return this._deviceCode; }
            set { this._deviceCode = value; }
        }

        // Check to see if DeviceCode property is set
        internal bool IsSetDeviceCode()
        {
            return this._deviceCode != null;
        }

        /// <summary>
        /// Gets and sets the property GrantType. 
        /// <para>
        /// Supports grant types for the authorization code, refresh token, and device code request.
        /// For device code requests, specify the following value:
        /// </para>
        ///  
        /// <para>
        ///  <code>urn:ietf:params:oauth:grant-type:<i>device_code</i> </code> 
        /// </para>
        ///  
        /// <para>
        /// For information about how to obtain the device code, see the <a>StartDeviceAuthorization</a>
        /// topic.
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
        /// The location of the application that will receive the authorization code. Users authorize
        /// the service to send the request to this location.
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
        /// Currently, <code>refreshToken</code> is not yet implemented and is not supported.
        /// For more information about the features and limitations of the current IAM Identity
        /// Center OIDC implementation, see <i>Considerations for Using this Guide</i> in the
        /// <a href="https://docs.aws.amazon.com/singlesignon/latest/OIDCAPIReference/Welcome.html">IAM
        /// Identity Center OIDC API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// The token used to obtain an access token in the event that the access token is invalid
        /// or expired.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Scope. 
        /// <para>
        /// The list of scopes that is defined by the client. Upon authorization, this list is
        /// used to restrict permissions when granting an access token.
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
            return this._scope != null && this._scope.Count > 0; 
        }

        /// <summary>
        /// Get the signer to use for this request.
        /// </summary>
        /// <returns>A signer for this request.</returns>
        override protected AbstractAWSSigner CreateSigner()
        {
            return new NullSigner();
        }
    }
}