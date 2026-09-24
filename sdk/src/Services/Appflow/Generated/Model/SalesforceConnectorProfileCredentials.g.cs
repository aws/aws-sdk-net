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

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The connector-specific profile credentials required when using Salesforce.
    /// </summary>
    public partial class SalesforceConnectorProfileCredentials
    {
        /// <summary>
        /// Gets and sets the property AccessToken. 
        /// <para>
        ///  The credentials used to access protected Salesforce resources. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4096)]
        public string AccessToken { get; set; }

        /// <summary>
        /// Checks to see if the AccessToken property is set.
        /// </summary>
        internal bool IsSetAccessToken() => this.AccessToken != null;

        /// <summary>
        /// Gets and sets the property ClientCredentialsArn. 
        /// <para>
        ///  The secret manager ARN, which contains the client ID and client secret of the connected
        /// app. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 20, Max = 2048)]
        public string ClientCredentialsArn { get; set; }

        /// <summary>
        /// Checks to see if the ClientCredentialsArn property is set.
        /// </summary>
        internal bool IsSetClientCredentialsArn() => this.ClientCredentialsArn != null;

        /// <summary>
        /// Gets and sets the property JwtToken. 
        /// <para>
        /// A JSON web token (JWT) that authorizes Amazon AppFlow to access your Salesforce records.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 8000)]
        public string JwtToken { get; set; }

        /// <summary>
        /// Checks to see if the JwtToken property is set.
        /// </summary>
        internal bool IsSetJwtToken() => this.JwtToken != null;

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
        public OAuth2GrantType OAuth2GrantType { get; set; }

        /// <summary>
        /// Checks to see if the OAuth2GrantType property is set.
        /// </summary>
        internal bool IsSetOAuth2GrantType() => this.OAuth2GrantType != null;

        /// <summary>
        /// Gets and sets the property OAuthRequest. 
        /// <para>
        ///  The OAuth requirement needed to request security tokens from the connector endpoint.
        /// 
        /// </para>
        /// </summary>
        public ConnectorOAuthRequest OAuthRequest { get; set; }

        /// <summary>
        /// Checks to see if the OAuthRequest property is set.
        /// </summary>
        internal bool IsSetOAuthRequest() => this.OAuthRequest != null;

        /// <summary>
        /// Gets and sets the property RefreshToken. 
        /// <para>
        ///  The credentials used to acquire new access tokens. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Checks to see if the RefreshToken property is set.
        /// </summary>
        internal bool IsSetRefreshToken() => this.RefreshToken != null;
    }
}
