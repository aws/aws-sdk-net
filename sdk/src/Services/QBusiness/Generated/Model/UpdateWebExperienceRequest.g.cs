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

namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateWebExperience operation. Updates an Amazon
    /// Q Business web experience.
    /// </summary>
    public partial class UpdateWebExperienceRequest : AmazonQBusinessRequest
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The identifier of the Amazon Q Business application attached to the web experience.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property AuthenticationConfiguration. 
        /// <para>
        /// The authentication configuration of the Amazon Q Business web experience.
        /// </para>
        /// </summary>
        [Obsolete("Property associated with legacy SAML IdP flow. Deprecated in favor of using AWS IAM Identity Center for user management.")]
        public WebExperienceAuthConfiguration AuthenticationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationConfiguration property is set.
        /// </summary>
        internal bool IsSetAuthenticationConfiguration() => this.AuthenticationConfiguration != null;

        /// <summary>
        /// Gets and sets the property BrowserExtensionConfiguration. 
        /// <para>
        /// The browser extension configuration for an Amazon Q Business web experience.
        /// </para>
        ///  <note> 
        /// <para>
        ///  For Amazon Q Business application using external OIDC-compliant identity providers
        /// (IdPs). The IdP administrator must add the browser extension sign-in redirect URLs
        /// to the IdP application. For more information, see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/browser-extensions.html">Configure
        /// external OIDC identity provider for your browser extensions.</a>. 
        /// </para>
        ///  </note>
        /// </summary>
        public BrowserExtensionConfiguration BrowserExtensionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the BrowserExtensionConfiguration property is set.
        /// </summary>
        internal bool IsSetBrowserExtensionConfiguration() => this.BrowserExtensionConfiguration != null;

        /// <summary>
        /// Gets and sets the property CustomizationConfiguration. 
        /// <para>
        /// Updates the custom logo, favicon, font, and color used in the Amazon Q web experience.
        /// 
        /// </para>
        /// </summary>
        public CustomizationConfiguration CustomizationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CustomizationConfiguration property is set.
        /// </summary>
        internal bool IsSetCustomizationConfiguration() => this.CustomizationConfiguration != null;

        /// <summary>
        /// Gets and sets the property IdentityProviderConfiguration. 
        /// <para>
        /// Information about the identity provider (IdP) used to authenticate end users of an
        /// Amazon Q Business web experience.
        /// </para>
        /// </summary>
        public IdentityProviderConfiguration IdentityProviderConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the IdentityProviderConfiguration property is set.
        /// </summary>
        internal bool IsSetIdentityProviderConfiguration() => this.IdentityProviderConfiguration != null;

        /// <summary>
        /// Gets and sets the property Origins. 
        /// <para>
        /// Updates the website domain origins that are allowed to embed the Amazon Q Business
        /// web experience. The <i>domain origin</i> refers to the <i>base URL</i> for accessing
        /// a website including the protocol (<c>http/https</c>), the domain name, and the port
        /// number (if specified).
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// Any values except <c>null</c> submitted as part of this update will replace all previous
        /// values.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must only submit a <i>base URL</i> and not a full path. For example, <c>https://docs.aws.amazon.com</c>.
        /// </para>
        ///  </li> </ul> </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<string> Origins { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Origins property is set.
        /// </summary>
        internal bool IsSetOrigins() => this.Origins != null && (this.Origins.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the role with permission to access the Amazon Q
        /// Business web experience and required resources.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1284)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property SamplePromptsControlMode. 
        /// <para>
        /// Determines whether sample prompts are enabled in the web experience for an end user.
        /// </para>
        /// </summary>
        public WebExperienceSamplePromptsControlMode SamplePromptsControlMode { get; set; }

        /// <summary>
        /// Checks to see if the SamplePromptsControlMode property is set.
        /// </summary>
        internal bool IsSetSamplePromptsControlMode() => this.SamplePromptsControlMode != null;

        /// <summary>
        /// Gets and sets the property Subtitle. 
        /// <para>
        /// The subtitle of the Amazon Q Business web experience.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string Subtitle { get; set; }

        /// <summary>
        /// Checks to see if the Subtitle property is set.
        /// </summary>
        internal bool IsSetSubtitle() => this.Subtitle != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the Amazon Q Business web experience.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property WebExperienceId. 
        /// <para>
        /// The identifier of the Amazon Q Business web experience.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string WebExperienceId { get; set; }

        /// <summary>
        /// Checks to see if the WebExperienceId property is set.
        /// </summary>
        internal bool IsSetWebExperienceId() => this.WebExperienceId != null;

        /// <summary>
        /// Gets and sets the property WelcomeMessage. 
        /// <para>
        /// A customized welcome message for an end user in an Amazon Q Business web experience.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 300)]
        public string WelcomeMessage { get; set; }

        /// <summary>
        /// Checks to see if the WelcomeMessage property is set.
        /// </summary>
        internal bool IsSetWelcomeMessage() => this.WelcomeMessage != null;
    }
}
