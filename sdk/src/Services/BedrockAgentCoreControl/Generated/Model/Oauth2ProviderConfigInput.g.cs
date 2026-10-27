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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Contains the input configuration for an OAuth2 provider.
    /// </summary>
    public partial class Oauth2ProviderConfigInput
    {
        /// <summary>
        /// Gets and sets the property AtlassianOauth2ProviderConfig. 
        /// <para>
        /// Configuration settings for Atlassian OAuth2 provider integration.
        /// </para>
        /// </summary>
        public AtlassianOauth2ProviderConfigInput AtlassianOauth2ProviderConfig { get; set; }

        /// <summary>
        /// Checks to see if the AtlassianOauth2ProviderConfig property is set.
        /// </summary>
        internal bool IsSetAtlassianOauth2ProviderConfig() => this.AtlassianOauth2ProviderConfig != null;

        /// <summary>
        /// Gets and sets the property CustomOauth2ProviderConfig. 
        /// <para>
        /// The configuration for a custom OAuth2 provider.
        /// </para>
        /// </summary>
        public CustomOauth2ProviderConfigInput CustomOauth2ProviderConfig { get; set; }

        /// <summary>
        /// Checks to see if the CustomOauth2ProviderConfig property is set.
        /// </summary>
        internal bool IsSetCustomOauth2ProviderConfig() => this.CustomOauth2ProviderConfig != null;

        /// <summary>
        /// Gets and sets the property GithubOauth2ProviderConfig. 
        /// <para>
        /// The configuration for a GitHub OAuth2 provider.
        /// </para>
        /// </summary>
        public GithubOauth2ProviderConfigInput GithubOauth2ProviderConfig { get; set; }

        /// <summary>
        /// Checks to see if the GithubOauth2ProviderConfig property is set.
        /// </summary>
        internal bool IsSetGithubOauth2ProviderConfig() => this.GithubOauth2ProviderConfig != null;

        /// <summary>
        /// Gets and sets the property GoogleOauth2ProviderConfig. 
        /// <para>
        /// The configuration for a Google OAuth2 provider.
        /// </para>
        /// </summary>
        public GoogleOauth2ProviderConfigInput GoogleOauth2ProviderConfig { get; set; }

        /// <summary>
        /// Checks to see if the GoogleOauth2ProviderConfig property is set.
        /// </summary>
        internal bool IsSetGoogleOauth2ProviderConfig() => this.GoogleOauth2ProviderConfig != null;

        /// <summary>
        /// Gets and sets the property IncludedOauth2ProviderConfig. 
        /// <para>
        /// The configuration for a non-custom OAuth2 provider. This includes settings for supported
        /// OAuth2 providers that have built-in integration support.
        /// </para>
        /// </summary>
        public IncludedOauth2ProviderConfigInput IncludedOauth2ProviderConfig { get; set; }

        /// <summary>
        /// Checks to see if the IncludedOauth2ProviderConfig property is set.
        /// </summary>
        internal bool IsSetIncludedOauth2ProviderConfig() => this.IncludedOauth2ProviderConfig != null;

        /// <summary>
        /// Gets and sets the property LinkedinOauth2ProviderConfig. 
        /// <para>
        /// Configuration settings for LinkedIn OAuth2 provider integration.
        /// </para>
        /// </summary>
        public LinkedinOauth2ProviderConfigInput LinkedinOauth2ProviderConfig { get; set; }

        /// <summary>
        /// Checks to see if the LinkedinOauth2ProviderConfig property is set.
        /// </summary>
        internal bool IsSetLinkedinOauth2ProviderConfig() => this.LinkedinOauth2ProviderConfig != null;

        /// <summary>
        /// Gets and sets the property MicrosoftOauth2ProviderConfig. 
        /// <para>
        /// The configuration for a Microsoft OAuth2 provider.
        /// </para>
        /// </summary>
        public MicrosoftOauth2ProviderConfigInput MicrosoftOauth2ProviderConfig { get; set; }

        /// <summary>
        /// Checks to see if the MicrosoftOauth2ProviderConfig property is set.
        /// </summary>
        internal bool IsSetMicrosoftOauth2ProviderConfig() => this.MicrosoftOauth2ProviderConfig != null;

        /// <summary>
        /// Gets and sets the property SalesforceOauth2ProviderConfig. 
        /// <para>
        /// The configuration for a Salesforce OAuth2 provider.
        /// </para>
        /// </summary>
        public SalesforceOauth2ProviderConfigInput SalesforceOauth2ProviderConfig { get; set; }

        /// <summary>
        /// Checks to see if the SalesforceOauth2ProviderConfig property is set.
        /// </summary>
        internal bool IsSetSalesforceOauth2ProviderConfig() => this.SalesforceOauth2ProviderConfig != null;

        /// <summary>
        /// Gets and sets the property SlackOauth2ProviderConfig. 
        /// <para>
        /// The configuration for a Slack OAuth2 provider.
        /// </para>
        /// </summary>
        public SlackOauth2ProviderConfigInput SlackOauth2ProviderConfig { get; set; }

        /// <summary>
        /// Checks to see if the SlackOauth2ProviderConfig property is set.
        /// </summary>
        internal bool IsSetSlackOauth2ProviderConfig() => this.SlackOauth2ProviderConfig != null;
    }
}
