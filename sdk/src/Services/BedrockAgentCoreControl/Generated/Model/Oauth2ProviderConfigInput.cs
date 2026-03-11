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
    /// Contains the input configuration for an OAuth2 provider.
    /// </summary>
    public partial class Oauth2ProviderConfigInput
    {
        private AtlassianOauth2ProviderConfigInput _atlassianOauth2ProviderConfig;
        private CustomOauth2ProviderConfigInput _customOauth2ProviderConfig;
        private GithubOauth2ProviderConfigInput _githubOauth2ProviderConfig;
        private GoogleOauth2ProviderConfigInput _googleOauth2ProviderConfig;
        private IncludedOauth2ProviderConfigInput _includedOauth2ProviderConfig;
        private LinkedinOauth2ProviderConfigInput _linkedinOauth2ProviderConfig;
        private MicrosoftOauth2ProviderConfigInput _microsoftOauth2ProviderConfig;
        private SalesforceOauth2ProviderConfigInput _salesforceOauth2ProviderConfig;
        private SlackOauth2ProviderConfigInput _slackOauth2ProviderConfig;

        /// <summary>
        /// Gets and sets the property AtlassianOauth2ProviderConfig. 
        /// <para>
        /// Configuration settings for Atlassian OAuth2 provider integration.
        /// </para>
        /// </summary>
        public AtlassianOauth2ProviderConfigInput AtlassianOauth2ProviderConfig
        {
            get { return this._atlassianOauth2ProviderConfig; }
            set { this._atlassianOauth2ProviderConfig = value; }
        }

        // Check to see if AtlassianOauth2ProviderConfig property is set
        internal bool IsSetAtlassianOauth2ProviderConfig()
        {
            return this._atlassianOauth2ProviderConfig != null;
        }

        /// <summary>
        /// Gets and sets the property CustomOauth2ProviderConfig. 
        /// <para>
        /// The configuration for a custom OAuth2 provider.
        /// </para>
        /// </summary>
        public CustomOauth2ProviderConfigInput CustomOauth2ProviderConfig
        {
            get { return this._customOauth2ProviderConfig; }
            set { this._customOauth2ProviderConfig = value; }
        }

        // Check to see if CustomOauth2ProviderConfig property is set
        internal bool IsSetCustomOauth2ProviderConfig()
        {
            return this._customOauth2ProviderConfig != null;
        }

        /// <summary>
        /// Gets and sets the property GithubOauth2ProviderConfig. 
        /// <para>
        /// The configuration for a GitHub OAuth2 provider.
        /// </para>
        /// </summary>
        public GithubOauth2ProviderConfigInput GithubOauth2ProviderConfig
        {
            get { return this._githubOauth2ProviderConfig; }
            set { this._githubOauth2ProviderConfig = value; }
        }

        // Check to see if GithubOauth2ProviderConfig property is set
        internal bool IsSetGithubOauth2ProviderConfig()
        {
            return this._githubOauth2ProviderConfig != null;
        }

        /// <summary>
        /// Gets and sets the property GoogleOauth2ProviderConfig. 
        /// <para>
        /// The configuration for a Google OAuth2 provider.
        /// </para>
        /// </summary>
        public GoogleOauth2ProviderConfigInput GoogleOauth2ProviderConfig
        {
            get { return this._googleOauth2ProviderConfig; }
            set { this._googleOauth2ProviderConfig = value; }
        }

        // Check to see if GoogleOauth2ProviderConfig property is set
        internal bool IsSetGoogleOauth2ProviderConfig()
        {
            return this._googleOauth2ProviderConfig != null;
        }

        /// <summary>
        /// Gets and sets the property IncludedOauth2ProviderConfig. 
        /// <para>
        /// The configuration for a non-custom OAuth2 provider. This includes settings for supported
        /// OAuth2 providers that have built-in integration support.
        /// </para>
        /// </summary>
        public IncludedOauth2ProviderConfigInput IncludedOauth2ProviderConfig
        {
            get { return this._includedOauth2ProviderConfig; }
            set { this._includedOauth2ProviderConfig = value; }
        }

        // Check to see if IncludedOauth2ProviderConfig property is set
        internal bool IsSetIncludedOauth2ProviderConfig()
        {
            return this._includedOauth2ProviderConfig != null;
        }

        /// <summary>
        /// Gets and sets the property LinkedinOauth2ProviderConfig. 
        /// <para>
        /// Configuration settings for LinkedIn OAuth2 provider integration.
        /// </para>
        /// </summary>
        public LinkedinOauth2ProviderConfigInput LinkedinOauth2ProviderConfig
        {
            get { return this._linkedinOauth2ProviderConfig; }
            set { this._linkedinOauth2ProviderConfig = value; }
        }

        // Check to see if LinkedinOauth2ProviderConfig property is set
        internal bool IsSetLinkedinOauth2ProviderConfig()
        {
            return this._linkedinOauth2ProviderConfig != null;
        }

        /// <summary>
        /// Gets and sets the property MicrosoftOauth2ProviderConfig. 
        /// <para>
        /// The configuration for a Microsoft OAuth2 provider.
        /// </para>
        /// </summary>
        public MicrosoftOauth2ProviderConfigInput MicrosoftOauth2ProviderConfig
        {
            get { return this._microsoftOauth2ProviderConfig; }
            set { this._microsoftOauth2ProviderConfig = value; }
        }

        // Check to see if MicrosoftOauth2ProviderConfig property is set
        internal bool IsSetMicrosoftOauth2ProviderConfig()
        {
            return this._microsoftOauth2ProviderConfig != null;
        }

        /// <summary>
        /// Gets and sets the property SalesforceOauth2ProviderConfig. 
        /// <para>
        /// The configuration for a Salesforce OAuth2 provider.
        /// </para>
        /// </summary>
        public SalesforceOauth2ProviderConfigInput SalesforceOauth2ProviderConfig
        {
            get { return this._salesforceOauth2ProviderConfig; }
            set { this._salesforceOauth2ProviderConfig = value; }
        }

        // Check to see if SalesforceOauth2ProviderConfig property is set
        internal bool IsSetSalesforceOauth2ProviderConfig()
        {
            return this._salesforceOauth2ProviderConfig != null;
        }

        /// <summary>
        /// Gets and sets the property SlackOauth2ProviderConfig. 
        /// <para>
        /// The configuration for a Slack OAuth2 provider.
        /// </para>
        /// </summary>
        public SlackOauth2ProviderConfigInput SlackOauth2ProviderConfig
        {
            get { return this._slackOauth2ProviderConfig; }
            set { this._slackOauth2ProviderConfig = value; }
        }

        // Check to see if SlackOauth2ProviderConfig property is set
        internal bool IsSetSlackOauth2ProviderConfig()
        {
            return this._slackOauth2ProviderConfig != null;
        }

    }
}