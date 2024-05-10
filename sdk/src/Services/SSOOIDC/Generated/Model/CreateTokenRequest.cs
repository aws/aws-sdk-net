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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SSOOIDC.Model
{
    /// <summary>
    /// Container for the parameters to the CreateToken operation.
    /// Creates and returns access and refresh tokens for clients that are authenticated using
    /// client secrets. The access token can be used to fetch short-term credentials for the
    /// assigned AWS accounts or to access application APIs using <c>bearer</c> authentication.
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
        private List<string> _scope = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The unique identifier string for the client or application. This value comes from
        /// the result of the <a>RegisterClient</a> API.
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
        [AWSProperty(Required=true, Sensitive=true)]
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
        /// Used only when calling this API for the Authorization Code grant type. The short-term
        /// code is used to identify this authorization request. This grant type is currently
        /// unsupported for the <a>CreateToken</a> API.
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
        /// Used only when calling this API for the Device Code grant type. This short-term code
        /// is used to identify this authorization request. This comes from the result of the
        /// <a>StartDeviceAuthorization</a> API.
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
        /// Supports the following OAuth grant types: Device Code and Refresh Token. Specify either
        /// of the following values, depending on the grant type that you want:
        /// </para>
        ///  
        /// <para>
        /// * Device Code - <c>urn:ietf:params:oauth:grant-type:device_code</c> 
        /// </para>
        ///  
        /// <para>
        /// * Refresh Token - <c>refresh_token</c> 
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
        /// Gets and sets the property Scope. 
        /// <para>
        /// The list of scopes for which authorization is requested. The access token that is
        /// issued is limited to the scopes that are granted. If this value is not specified,
        /// IAM Identity Center authorizes all scopes that are configured for the client during
        /// the call to <a>RegisterClient</a>.
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
        /// Get the signer to use for this request.
        /// </summary>
        /// <returns>A signer for this request.</returns>
        override protected AbstractAWSSigner CreateSigner()
        {
            return new NullSigner();
        }
    }
}