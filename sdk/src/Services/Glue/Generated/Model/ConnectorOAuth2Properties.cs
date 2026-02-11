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
    /// OAuth2 configuration container that defines the authentication properties and flow-specific
    /// configurations for OAuth2-based connections.
    /// </summary>
    public partial class ConnectorOAuth2Properties
    {
        private ConnectorAuthorizationCodeProperties _authorizationCodeProperties;
        private ClientCredentialsProperties _clientCredentialsProperties;
        private JWTBearerProperties _jwtBearerProperties;
        private ConnectorOAuth2GrantType _oAuth2GrantType;

        /// <summary>
        /// Gets and sets the property AuthorizationCodeProperties. 
        /// <para>
        /// Configuration properties specific to the OAuth2 Authorization Code grant type flow.
        /// </para>
        /// </summary>
        public ConnectorAuthorizationCodeProperties AuthorizationCodeProperties
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
        /// Gets and sets the property ClientCredentialsProperties. 
        /// <para>
        /// Configuration properties specific to the OAuth2 Client Credentials grant type flow.
        /// </para>
        /// </summary>
        public ClientCredentialsProperties ClientCredentialsProperties
        {
            get { return this._clientCredentialsProperties; }
            set { this._clientCredentialsProperties = value; }
        }

        // Check to see if ClientCredentialsProperties property is set
        internal bool IsSetClientCredentialsProperties()
        {
            return this._clientCredentialsProperties != null;
        }

        /// <summary>
        /// Gets and sets the property JWTBearerProperties. 
        /// <para>
        /// Configuration properties specific to the OAuth2 JWT Bearer grant type flow.
        /// </para>
        /// </summary>
        public JWTBearerProperties JWTBearerProperties
        {
            get { return this._jwtBearerProperties; }
            set { this._jwtBearerProperties = value; }
        }

        // Check to see if JWTBearerProperties property is set
        internal bool IsSetJWTBearerProperties()
        {
            return this._jwtBearerProperties != null;
        }

        /// <summary>
        /// Gets and sets the property OAuth2GrantType. 
        /// <para>
        /// The OAuth2 grant type to use for authentication, such as CLIENT_CREDENTIALS, JWT_BEARER,
        /// or AUTHORIZATION_CODE.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConnectorOAuth2GrantType OAuth2GrantType
        {
            get { return this._oAuth2GrantType; }
            set { this._oAuth2GrantType = value; }
        }

        // Check to see if OAuth2GrantType property is set
        internal bool IsSetOAuth2GrantType()
        {
            return this._oAuth2GrantType != null;
        }

    }
}