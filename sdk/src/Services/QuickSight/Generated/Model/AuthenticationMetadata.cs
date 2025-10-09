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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Union type containing authentication metadata for different authentication methods.
    /// </summary>
    public partial class AuthenticationMetadata
    {
        private APIKeyConnectionMetadata _apiKeyConnectionMetadata;
        private AuthorizationCodeGrantMetadata _authorizationCodeGrantMetadata;
        private BasicAuthConnectionMetadata _basicAuthConnectionMetadata;
        private ClientCredentialsGrantMetadata _clientCredentialsGrantMetadata;
        private IAMConnectionMetadata _iamConnectionMetadata;
        private NoneConnectionMetadata _noneConnectionMetadata;

        /// <summary>
        /// Gets and sets the property ApiKeyConnectionMetadata. 
        /// <para>
        /// API key authentication metadata.
        /// </para>
        /// </summary>
        public APIKeyConnectionMetadata ApiKeyConnectionMetadata
        {
            get { return this._apiKeyConnectionMetadata; }
            set { this._apiKeyConnectionMetadata = value; }
        }

        // Check to see if ApiKeyConnectionMetadata property is set
        internal bool IsSetApiKeyConnectionMetadata()
        {
            return this._apiKeyConnectionMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property AuthorizationCodeGrantMetadata. 
        /// <para>
        /// OAuth 2.0 authorization code grant authentication metadata.
        /// </para>
        /// </summary>
        public AuthorizationCodeGrantMetadata AuthorizationCodeGrantMetadata
        {
            get { return this._authorizationCodeGrantMetadata; }
            set { this._authorizationCodeGrantMetadata = value; }
        }

        // Check to see if AuthorizationCodeGrantMetadata property is set
        internal bool IsSetAuthorizationCodeGrantMetadata()
        {
            return this._authorizationCodeGrantMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property BasicAuthConnectionMetadata. 
        /// <para>
        /// Basic authentication metadata using username and password.
        /// </para>
        /// </summary>
        public BasicAuthConnectionMetadata BasicAuthConnectionMetadata
        {
            get { return this._basicAuthConnectionMetadata; }
            set { this._basicAuthConnectionMetadata = value; }
        }

        // Check to see if BasicAuthConnectionMetadata property is set
        internal bool IsSetBasicAuthConnectionMetadata()
        {
            return this._basicAuthConnectionMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property ClientCredentialsGrantMetadata. 
        /// <para>
        /// OAuth 2.0 client credentials grant authentication metadata.
        /// </para>
        /// </summary>
        public ClientCredentialsGrantMetadata ClientCredentialsGrantMetadata
        {
            get { return this._clientCredentialsGrantMetadata; }
            set { this._clientCredentialsGrantMetadata = value; }
        }

        // Check to see if ClientCredentialsGrantMetadata property is set
        internal bool IsSetClientCredentialsGrantMetadata()
        {
            return this._clientCredentialsGrantMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property IamConnectionMetadata. 
        /// <para>
        /// IAM role-based authentication metadata for Amazon Web Services services.
        /// </para>
        /// </summary>
        public IAMConnectionMetadata IamConnectionMetadata
        {
            get { return this._iamConnectionMetadata; }
            set { this._iamConnectionMetadata = value; }
        }

        // Check to see if IamConnectionMetadata property is set
        internal bool IsSetIamConnectionMetadata()
        {
            return this._iamConnectionMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property NoneConnectionMetadata. 
        /// <para>
        /// No authentication metadata for services that don't require authentication.
        /// </para>
        /// </summary>
        public NoneConnectionMetadata NoneConnectionMetadata
        {
            get { return this._noneConnectionMetadata; }
            set { this._noneConnectionMetadata = value; }
        }

        // Check to see if NoneConnectionMetadata property is set
        internal bool IsSetNoneConnectionMetadata()
        {
            return this._noneConnectionMetadata != null;
        }

    }
}