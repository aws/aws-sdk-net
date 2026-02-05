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
    /// OAuth2 authorization code configuration that defines the properties needed for the
    /// Authorization Code grant type flow.
    /// </summary>
    public partial class ConnectorAuthorizationCodeProperties
    {
        private ConnectorProperty _authorizationCode;
        private ConnectorProperty _authorizationCodeUrl;
        private ConnectorProperty _clientId;
        private ConnectorProperty _clientSecret;
        private ContentType _contentType;
        private ConnectorProperty _prompt;
        private ConnectorProperty _redirectUri;
        private HTTPMethod _requestMethod;
        private ConnectorProperty _scope;
        private ConnectorProperty _tokenUrl;
        private List<ConnectorProperty> _tokenUrlParameters = AWSConfigs.InitializeCollections ? new List<ConnectorProperty>() : null;

        /// <summary>
        /// Gets and sets the property AuthorizationCode. 
        /// <para>
        /// The authorization code received from the authorization server after user consent.
        /// </para>
        /// </summary>
        public ConnectorProperty AuthorizationCode
        {
            get { return this._authorizationCode; }
            set { this._authorizationCode = value; }
        }

        // Check to see if AuthorizationCode property is set
        internal bool IsSetAuthorizationCode()
        {
            return this._authorizationCode != null;
        }

        /// <summary>
        /// Gets and sets the property AuthorizationCodeUrl. 
        /// <para>
        /// The authorization endpoint URL where users will be redirected to grant authorization.
        /// </para>
        /// </summary>
        public ConnectorProperty AuthorizationCodeUrl
        {
            get { return this._authorizationCodeUrl; }
            set { this._authorizationCodeUrl = value; }
        }

        // Check to see if AuthorizationCodeUrl property is set
        internal bool IsSetAuthorizationCodeUrl()
        {
            return this._authorizationCodeUrl != null;
        }

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The OAuth2 client identifier provided by the authorization server.
        /// </para>
        /// </summary>
        public ConnectorProperty ClientId
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
        /// The OAuth2 client secret provided by the authorization server.
        /// </para>
        /// </summary>
        public ConnectorProperty ClientSecret
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
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The content type to use for token exchange requests, such as application/x-www-form-urlencoded
        /// or application/json.
        /// </para>
        /// </summary>
        public ContentType ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

        /// <summary>
        /// Gets and sets the property Prompt. 
        /// <para>
        /// The OAuth2 prompt parameter that controls the authorization server's behavior during
        /// user authentication.
        /// </para>
        /// </summary>
        public ConnectorProperty Prompt
        {
            get { return this._prompt; }
            set { this._prompt = value; }
        }

        // Check to see if Prompt property is set
        internal bool IsSetPrompt()
        {
            return this._prompt != null;
        }

        /// <summary>
        /// Gets and sets the property RedirectUri. 
        /// <para>
        /// The redirect URI that must match the URI registered with the authorization server.
        /// </para>
        /// </summary>
        public ConnectorProperty RedirectUri
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
        /// Gets and sets the property RequestMethod. 
        /// <para>
        /// The HTTP method to use when making token exchange requests, typically POST.
        /// </para>
        /// </summary>
        public HTTPMethod RequestMethod
        {
            get { return this._requestMethod; }
            set { this._requestMethod = value; }
        }

        // Check to see if RequestMethod property is set
        internal bool IsSetRequestMethod()
        {
            return this._requestMethod != null;
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// The OAuth2 scope that defines the level of access requested for the authorization
        /// code flow.
        /// </para>
        /// </summary>
        public ConnectorProperty Scope
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
        /// Gets and sets the property TokenUrl. 
        /// <para>
        /// The token endpoint URL where the authorization code will be exchanged for an access
        /// token.
        /// </para>
        /// </summary>
        public ConnectorProperty TokenUrl
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
        /// Gets and sets the property TokenUrlParameters. 
        /// <para>
        /// Additional parameters to include in token URL requests as key-value pairs.
        /// </para>
        /// </summary>
        public List<ConnectorProperty> TokenUrlParameters
        {
            get { return this._tokenUrlParameters; }
            set { this._tokenUrlParameters = value; }
        }

        // Check to see if TokenUrlParameters property is set
        internal bool IsSetTokenUrlParameters()
        {
            return this._tokenUrlParameters != null && (this._tokenUrlParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}