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

namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// The credential that an integration uses to authenticate with its external system.
    /// Exactly one member is set, matching the integration's authentication type.
    /// </summary>
    public partial class IntegrationCredential
    {
        /// <summary>
        /// Gets and sets the property ApiKeyCredential. An API key credential.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public ApiKeyCredential ApiKeyCredential { get; set; }

        /// <summary>
        /// Checks to see if the ApiKeyCredential property is set.
        /// </summary>
        internal bool IsSetApiKeyCredential() => this.ApiKeyCredential != null;

        /// <summary>
        /// Gets and sets the property OauthClientCredential. Credentials for an OAuth 2.0 client-credentials
        /// grant.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public OAuthClientCredential OauthClientCredential { get; set; }

        /// <summary>
        /// Checks to see if the OauthClientCredential property is set.
        /// </summary>
        internal bool IsSetOauthClientCredential() => this.OauthClientCredential != null;

        /// <summary>
        /// Gets and sets the property OauthCodeCredential. Credentials for an OAuth 2.0 authorization-code
        /// grant.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public OAuthCodeCredential OauthCodeCredential { get; set; }

        /// <summary>
        /// Checks to see if the OauthCodeCredential property is set.
        /// </summary>
        internal bool IsSetOauthCodeCredential() => this.OauthCodeCredential != null;
    }
}
