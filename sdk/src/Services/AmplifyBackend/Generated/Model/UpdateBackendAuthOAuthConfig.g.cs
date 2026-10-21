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

namespace Amazon.AmplifyBackend.Model
{
    /// <summary>
    /// The OAuth configurations for authenticating users into your Amplify app.
    /// </summary>
    public partial class UpdateBackendAuthOAuthConfig
    {
        /// <summary>
        /// Gets and sets the property DomainPrefix. 
        /// <para>
        /// The Amazon Cognito domain prefix used to create a hosted UI for authentication.
        /// </para>
        /// </summary>
        public string DomainPrefix { get; set; }

        /// <summary>
        /// Checks to see if the DomainPrefix property is set.
        /// </summary>
        internal bool IsSetDomainPrefix() => this.DomainPrefix != null;

        /// <summary>
        /// Gets and sets the property OAuthGrantType. 
        /// <para>
        /// The OAuth grant type to allow app users to authenticate from your Amplify app.
        /// </para>
        /// </summary>
        public OAuthGrantType OAuthGrantType { get; set; }

        /// <summary>
        /// Checks to see if the OAuthGrantType property is set.
        /// </summary>
        internal bool IsSetOAuthGrantType() => this.OAuthGrantType != null;

        /// <summary>
        /// Gets and sets the property OAuthScopes. 
        /// <para>
        /// The list of OAuth-related flows that can allow users to authenticate from your Amplify
        /// app.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> OAuthScopes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the OAuthScopes property is set.
        /// </summary>
        internal bool IsSetOAuthScopes() => this.OAuthScopes != null && (this.OAuthScopes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RedirectSignInURIs. 
        /// <para>
        /// Redirect URLs that OAuth uses when a user signs in to an Amplify app.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RedirectSignInURIs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RedirectSignInURIs property is set.
        /// </summary>
        internal bool IsSetRedirectSignInURIs() => this.RedirectSignInURIs != null && (this.RedirectSignInURIs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RedirectSignOutURIs. 
        /// <para>
        /// Redirect URLs that OAuth uses when a user signs out of an Amplify app.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RedirectSignOutURIs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RedirectSignOutURIs property is set.
        /// </summary>
        internal bool IsSetRedirectSignOutURIs() => this.RedirectSignOutURIs != null && (this.RedirectSignOutURIs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SocialProviderSettings. 
        /// <para>
        /// Describes third-party social federation configurations for allowing your users to
        /// sign in with OAuth.
        /// </para>
        /// </summary>
        public SocialProviderSettings SocialProviderSettings { get; set; }

        /// <summary>
        /// Checks to see if the SocialProviderSettings property is set.
        /// </summary>
        internal bool IsSetSocialProviderSettings() => this.SocialProviderSettings != null;
    }
}
