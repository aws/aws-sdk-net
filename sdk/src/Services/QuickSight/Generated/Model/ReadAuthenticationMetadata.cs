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
    /// Read-only authentication metadata union containing non-sensitive configuration details
    /// for different authentication types.
    /// </summary>
    public partial class ReadAuthenticationMetadata
    {
        private ReadAPIKeyConnectionMetadata _apiKeyConnectionMetadata;
        private ReadAuthorizationCodeGrantMetadata _authorizationCodeGrantMetadata;
        private ReadBasicAuthConnectionMetadata _basicAuthConnectionMetadata;
        private ReadClientCredentialsGrantMetadata _clientCredentialsGrantMetadata;
        private ReadIamConnectionMetadata _iamConnectionMetadata;
        private ReadNoneConnectionMetadata _noneConnectionMetadata;

        /// <summary>
        /// Gets and sets the property ApiKeyConnectionMetadata. 
        /// <para>
        /// Read-only metadata for API key authentication configuration.
        /// </para>
        /// </summary>
        public ReadAPIKeyConnectionMetadata ApiKeyConnectionMetadata
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
        /// Read-only metadata for OAuth2 authorization code grant flow configuration.
        /// </para>
        /// </summary>
        public ReadAuthorizationCodeGrantMetadata AuthorizationCodeGrantMetadata
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
        /// Read-only metadata for basic authentication configuration.
        /// </para>
        /// </summary>
        public ReadBasicAuthConnectionMetadata BasicAuthConnectionMetadata
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
        /// Read-only metadata for OAuth2 client credentials grant flow configuration.
        /// </para>
        /// </summary>
        public ReadClientCredentialsGrantMetadata ClientCredentialsGrantMetadata
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
        /// Read-only metadata for IAM-based authentication configuration.
        /// </para>
        /// </summary>
        public ReadIamConnectionMetadata IamConnectionMetadata
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
        /// Read-only metadata for connections that do not require authentication.
        /// </para>
        /// </summary>
        public ReadNoneConnectionMetadata NoneConnectionMetadata
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