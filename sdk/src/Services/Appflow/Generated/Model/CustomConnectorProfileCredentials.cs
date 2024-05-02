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
    /// The connector-specific profile credentials that are required when using the custom
    /// connector.
    /// </summary>
    public partial class CustomConnectorProfileCredentials
    {
        private ApiKeyCredentials _apiKey;
        private AuthenticationType _authenticationType;
        private BasicAuthCredentials _basic;
        private CustomAuthCredentials _custom;
        private OAuth2Credentials _oauth2;

        /// <summary>
        /// Gets and sets the property ApiKey. 
        /// <para>
        /// The API keys required for the authentication of the user.
        /// </para>
        /// </summary>
        public ApiKeyCredentials ApiKey
        {
            get { return this._apiKey; }
            set { this._apiKey = value; }
        }

        // Check to see if ApiKey property is set
        internal bool IsSetApiKey()
        {
            return this._apiKey != null;
        }

        /// <summary>
        /// Gets and sets the property AuthenticationType. 
        /// <para>
        /// The authentication type that the custom connector uses for authenticating while creating
        /// a connector profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AuthenticationType AuthenticationType
        {
            get { return this._authenticationType; }
            set { this._authenticationType = value; }
        }

        // Check to see if AuthenticationType property is set
        internal bool IsSetAuthenticationType()
        {
            return this._authenticationType != null;
        }

        /// <summary>
        /// Gets and sets the property Basic. 
        /// <para>
        /// The basic credentials that are required for the authentication of the user.
        /// </para>
        /// </summary>
        public BasicAuthCredentials Basic
        {
            get { return this._basic; }
            set { this._basic = value; }
        }

        // Check to see if Basic property is set
        internal bool IsSetBasic()
        {
            return this._basic != null;
        }

        /// <summary>
        /// Gets and sets the property Custom. 
        /// <para>
        /// If the connector uses the custom authentication mechanism, this holds the required
        /// credentials.
        /// </para>
        /// </summary>
        public CustomAuthCredentials Custom
        {
            get { return this._custom; }
            set { this._custom = value; }
        }

        // Check to see if Custom property is set
        internal bool IsSetCustom()
        {
            return this._custom != null;
        }

        /// <summary>
        /// Gets and sets the property Oauth2. 
        /// <para>
        /// The OAuth 2.0 credentials required for the authentication of the user.
        /// </para>
        /// </summary>
        public OAuth2Credentials Oauth2
        {
            get { return this._oauth2; }
            set { this._oauth2 = value; }
        }

        // Check to see if Oauth2 property is set
        internal bool IsSetOauth2()
        {
            return this._oauth2 != null;
        }

    }
}