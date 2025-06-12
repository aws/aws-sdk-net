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
 * Do not modify this file. This file is generated from the amplifybackend-2020-08-11.normal.json service model.
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
    /// Creates the OAuth configuration for your Amplify project.
    /// </summary>
    public partial class CreateBackendAuthOAuthConfig
    {
        private string _domainPrefix;
        private OAuthGrantType _oAuthGrantType;
        private List<string> _oAuthScopes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _redirectSignInURIs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _redirectSignOutURIs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private SocialProviderSettings _socialProviderSettings;

        /// <summary>
        /// Gets and sets the property DomainPrefix. 
        /// <para>
        /// The domain prefix for your Amplify app.
        /// </para>
        /// </summary>
        public string DomainPrefix
        {
            get { return this._domainPrefix; }
            set { this._domainPrefix = value; }
        }

        // Check to see if DomainPrefix property is set
        internal bool IsSetDomainPrefix()
        {
            return this._domainPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property OAuthGrantType. 
        /// <para>
        /// The OAuth grant type that you use to allow app users to authenticate from your Amplify
        /// app.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OAuthGrantType OAuthGrantType
        {
            get { return this._oAuthGrantType; }
            set { this._oAuthGrantType = value; }
        }

        // Check to see if OAuthGrantType property is set
        internal bool IsSetOAuthGrantType()
        {
            return this._oAuthGrantType != null;
        }

        /// <summary>
        /// Gets and sets the property OAuthScopes. 
        /// <para>
        /// List of OAuth-related flows used to allow your app users to authenticate from your
        /// Amplify app.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> OAuthScopes
        {
            get { return this._oAuthScopes; }
            set { this._oAuthScopes = value; }
        }

        // Check to see if OAuthScopes property is set
        internal bool IsSetOAuthScopes()
        {
            return this._oAuthScopes != null && (this._oAuthScopes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RedirectSignInURIs. 
        /// <para>
        /// The redirected URI for signing in to your Amplify app.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> RedirectSignInURIs
        {
            get { return this._redirectSignInURIs; }
            set { this._redirectSignInURIs = value; }
        }

        // Check to see if RedirectSignInURIs property is set
        internal bool IsSetRedirectSignInURIs()
        {
            return this._redirectSignInURIs != null && (this._redirectSignInURIs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RedirectSignOutURIs. 
        /// <para>
        /// Redirect URLs that OAuth uses when a user signs out of an Amplify app.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> RedirectSignOutURIs
        {
            get { return this._redirectSignOutURIs; }
            set { this._redirectSignOutURIs = value; }
        }

        // Check to see if RedirectSignOutURIs property is set
        internal bool IsSetRedirectSignOutURIs()
        {
            return this._redirectSignOutURIs != null && (this._redirectSignOutURIs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SocialProviderSettings. 
        /// <para>
        /// The settings for using social providers to access your Amplify app.
        /// </para>
        /// </summary>
        public SocialProviderSettings SocialProviderSettings
        {
            get { return this._socialProviderSettings; }
            set { this._socialProviderSettings = value; }
        }

        // Check to see if SocialProviderSettings property is set
        internal bool IsSetSocialProviderSettings()
        {
            return this._socialProviderSettings != null;
        }

    }
}