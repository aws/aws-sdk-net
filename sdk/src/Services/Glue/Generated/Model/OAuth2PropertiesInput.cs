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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// A structure containing properties for OAuth2 in the CreateConnection request.
    /// </summary>
    public partial class OAuth2PropertiesInput
    {
        private AuthorizationCodeProperties _authorizationCodeProperties;
        private OAuth2ClientApplication _oAuth2ClientApplication;
        private OAuth2Credentials _oAuth2Credentials;
        private OAuth2GrantType _oAuth2GrantType;
        private string _tokenUrl;
        private Dictionary<string, string> _tokenUrlParametersMap = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AuthorizationCodeProperties. 
        /// <para>
        /// The set of properties required for the the OAuth2 <c>AUTHORIZATION_CODE</c> grant
        /// type.
        /// </para>
        /// </summary>
        public AuthorizationCodeProperties AuthorizationCodeProperties
        {
            get { return this._authorizationCodeProperties; }
            set { this._authorizationCodeProperties = value; }
        }

        // Check to see if AuthorizationCodeProperties property is set
        internal bool IsSetAuthorizationCodeProperties()
        {
            return this._authorizationCodeProperties != null;
        }

        /// <summary>
        /// Gets and sets the property OAuth2ClientApplication. 
        /// <para>
        /// The client application type in the CreateConnection request. For example, <c>AWS_MANAGED</c>
        /// or <c>USER_MANAGED</c>.
        /// </para>
        /// </summary>
        public OAuth2ClientApplication OAuth2ClientApplication
        {
            get { return this._oAuth2ClientApplication; }
            set { this._oAuth2ClientApplication = value; }
        }

        // Check to see if OAuth2ClientApplication property is set
        internal bool IsSetOAuth2ClientApplication()
        {
            return this._oAuth2ClientApplication != null;
        }

        /// <summary>
        /// Gets and sets the property OAuth2Credentials. 
        /// <para>
        /// The credentials used when the authentication type is OAuth2 authentication.
        /// </para>
        /// </summary>
        public OAuth2Credentials OAuth2Credentials
        {
            get { return this._oAuth2Credentials; }
            set { this._oAuth2Credentials = value; }
        }

        // Check to see if OAuth2Credentials property is set
        internal bool IsSetOAuth2Credentials()
        {
            return this._oAuth2Credentials != null;
        }

        /// <summary>
        /// Gets and sets the property OAuth2GrantType. 
        /// <para>
        /// The OAuth2 grant type in the CreateConnection request. For example, <c>AUTHORIZATION_CODE</c>,
        /// <c>JWT_BEARER</c>, or <c>CLIENT_CREDENTIALS</c>.
        /// </para>
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
        /// Gets and sets the property TokenUrl. 
        /// <para>
        /// The URL of the provider's authentication server, to exchange an authorization code
        /// for an access token.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string TokenUrl
        {
            get { return this._tokenUrl; }
            set { this._tokenUrl = value; }
        }

        // Check to see if TokenUrl property is set
        internal bool IsSetTokenUrl()
        {
            return this._tokenUrl != null;
        }

        /// <summary>
        /// Gets and sets the property TokenUrlParametersMap. 
        /// <para>
        /// A map of parameters that are added to the token <c>GET</c> request.
        /// </para>
        /// </summary>
        public Dictionary<string, string> TokenUrlParametersMap
        {
            get { return this._tokenUrlParametersMap; }
            set { this._tokenUrlParametersMap = value; }
        }

        // Check to see if TokenUrlParametersMap property is set
        internal bool IsSetTokenUrlParametersMap()
        {
            return this._tokenUrlParametersMap != null && (this._tokenUrlParametersMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}