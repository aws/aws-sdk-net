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
 * Do not modify this file. This file is generated from the cloudwatchomni-2025-01-01.normal.json service model.
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
namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// The credential that an integration uses to authenticate with its external system.
    /// Exactly one member is set, matching the integration's authentication type.
    /// </summary>
    public partial class IntegrationCredential
    {
        private ApiKeyCredential _apiKeyCredential;
        private OAuthClientCredential _oauthClientCredential;
        private OAuthCodeCredential _oauthCodeCredential;

        /// <summary>
        /// Gets and sets the property ApiKeyCredential. 
        /// <para>
        /// An API key credential.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public ApiKeyCredential ApiKeyCredential
        {
            get { return this._apiKeyCredential; }
            set { this._apiKeyCredential = value; }
        }

        // Check to see if ApiKeyCredential property is set
        internal bool IsSetApiKeyCredential()
        {
            return this._apiKeyCredential != null;
        }

        /// <summary>
        /// Gets and sets the property OauthClientCredential. 
        /// <para>
        /// Credentials for an OAuth 2.0 client-credentials grant.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public OAuthClientCredential OauthClientCredential
        {
            get { return this._oauthClientCredential; }
            set { this._oauthClientCredential = value; }
        }

        // Check to see if OauthClientCredential property is set
        internal bool IsSetOauthClientCredential()
        {
            return this._oauthClientCredential != null;
        }

        /// <summary>
        /// Gets and sets the property OauthCodeCredential. 
        /// <para>
        /// Credentials for an OAuth 2.0 authorization-code grant.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public OAuthCodeCredential OauthCodeCredential
        {
            get { return this._oauthCodeCredential; }
            set { this._oauthCodeCredential = value; }
        }

        // Check to see if OauthCodeCredential property is set
        internal bool IsSetOauthCodeCredential()
        {
            return this._oauthCodeCredential != null;
        }

    }
}