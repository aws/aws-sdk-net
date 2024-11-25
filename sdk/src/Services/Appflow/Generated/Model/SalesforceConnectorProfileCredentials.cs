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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
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
namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The connector-specific profile credentials required when using Salesforce.
    /// </summary>
    public partial class SalesforceConnectorProfileCredentials
    {
        private string _accessToken;
        private string _clientCredentialsArn;
        private string _jwtToken;
        private OAuth2GrantType _oAuth2GrantType;
        private ConnectorOAuthRequest _oAuthRequest;
        private string _refreshToken;

        /// <summary>
        /// Gets and sets the property AccessToken. 
        /// <para>
        ///  The credentials used to access protected Salesforce resources. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=4096)]
        public string AccessToken
        {
            get { return this._accessToken; }
            set { this._accessToken = value; }
        }

        // Check to see if AccessToken property is set
        internal bool IsSetAccessToken()
        {
            return this._accessToken != null;
        }

        /// <summary>
        /// Gets and sets the property ClientCredentialsArn. 
        /// <para>
        ///  The secret manager ARN, which contains the client ID and client secret of the connected
        /// app. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=20, Max=2048)]
        public string ClientCredentialsArn
        {
            get { return this._clientCredentialsArn; }
            set { this._clientCredentialsArn = value; }
        }

        // Check to see if ClientCredentialsArn property is set
        internal bool IsSetClientCredentialsArn()
        {
            return this._clientCredentialsArn != null;
        }

        /// <summary>
        /// Gets and sets the property JwtToken. 
        /// <para>
        /// A JSON web token (JWT) that authorizes Amazon AppFlow to access your Salesforce records.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=8000)]
        public string JwtToken
        {
            get { return this._jwtToken; }
            set { this._jwtToken = value; }
        }

        // Check to see if JwtToken property is set
        internal bool IsSetJwtToken()
        {
            return this._jwtToken != null;
        }

        /// <summary>
        /// Gets and sets the property OAuth2GrantType. 
        /// <para>
        /// Specifies the OAuth 2.0 grant type that Amazon AppFlow uses when it requests an access
        /// token from Salesforce. Amazon AppFlow requires an access token each time it attempts
        /// to access your Salesforce records.
        /// </para>
        ///  
        /// <para>
        /// You can specify one of the following values:
        /// </para>
        ///  <dl> <dt>AUTHORIZATION_CODE</dt> <dd> 
        /// <para>
        /// Amazon AppFlow passes an authorization code when it requests the access token from
        /// Salesforce. Amazon AppFlow receives the authorization code from Salesforce after you
        /// log in to your Salesforce account and authorize Amazon AppFlow to access your records.
        /// </para>
        ///  </dd> <dt>JWT_BEARER</dt> <dd> 
        /// <para>
        /// Amazon AppFlow passes a JSON web token (JWT) when it requests the access token from
        /// Salesforce. You provide the JWT to Amazon AppFlow when you define the connection to
        /// your Salesforce account. When you use this grant type, you don't need to log in to
        /// your Salesforce account to authorize Amazon AppFlow to access your records.
        /// </para>
        ///  </dd> </dl> <note> 
        /// <para>
        /// The CLIENT_CREDENTIALS value is not supported for Salesforce.
        /// </para>
        ///  </note>
        /// </summary>
        public OAuth2GrantType OAuth2GrantType
        {
            get { return this._oAuth2GrantType; }
            set { this._oAuth2GrantType = value; }
        }

        // Check to see if OAuth2GrantType property is set
        internal bool IsSetOAuth2GrantType()
        {
            return this._oAuth2GrantType != null;
        }

        /// <summary>
        /// Gets and sets the property OAuthRequest. 
        /// <para>
        ///  The OAuth requirement needed to request security tokens from the connector endpoint.
        /// 
        /// </para>
        /// </summary>
        public ConnectorOAuthRequest OAuthRequest
        {
            get { return this._oAuthRequest; }
            set { this._oAuthRequest = value; }
        }

        // Check to see if OAuthRequest property is set
        internal bool IsSetOAuthRequest()
        {
            return this._oAuthRequest != null;
        }

        /// <summary>
        /// Gets and sets the property RefreshToken. 
        /// <para>
        ///  The credentials used to acquire new access tokens. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=4096)]
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

    }
}