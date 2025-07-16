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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// A credential provider for gateway authentication. This structure contains the configuration
    /// for authenticating with the target endpoint.
    /// </summary>
    public partial class CredentialProvider
    {
        private ApiKeyCredentialProvider _apiKeyCredentialProvider;
        private OAuthCredentialProvider _oauthCredentialProvider;

        /// <summary>
        /// Gets and sets the property ApiKeyCredentialProvider. 
        /// <para>
        /// The API key credential provider. This provider uses an API key to authenticate with
        /// the target endpoint.
        /// </para>
        /// </summary>
        public ApiKeyCredentialProvider ApiKeyCredentialProvider
        {
            get { return this._apiKeyCredentialProvider; }
            set { this._apiKeyCredentialProvider = value; }
        }

        // Check to see if ApiKeyCredentialProvider property is set
        internal bool IsSetApiKeyCredentialProvider()
        {
            return this._apiKeyCredentialProvider != null;
        }

        /// <summary>
        /// Gets and sets the property OauthCredentialProvider. 
        /// <para>
        /// The OAuth credential provider. This provider uses OAuth authentication to access the
        /// target endpoint.
        /// </para>
        /// </summary>
        public OAuthCredentialProvider OauthCredentialProvider
        {
            get { return this._oauthCredentialProvider; }
            set { this._oauthCredentialProvider = value; }
        }

        // Check to see if OauthCredentialProvider property is set
        internal bool IsSetOauthCredentialProvider()
        {
            return this._oauthCredentialProvider != null;
        }

    }
}