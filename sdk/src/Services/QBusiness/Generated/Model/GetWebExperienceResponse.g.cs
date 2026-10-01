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
    /// This is the response object from the GetWebExperience operation.
    /// </summary>
    public partial class GetWebExperienceResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The identifier of the Amazon Q Business application linked to the web experience.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property AuthenticationConfiguration. 
        /// <para>
        /// The authentication configuration information for your Amazon Q Business web experience.
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
        /// </summary>
        public BrowserExtensionConfiguration BrowserExtensionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the BrowserExtensionConfiguration property is set.
        /// </summary>
        internal bool IsSetBrowserExtensionConfiguration() => this.BrowserExtensionConfiguration != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix timestamp when the Amazon Q Business web experience was last created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CustomizationConfiguration. 
        /// <para>
        /// Gets the custom logo, favicon, font, and color used in the Amazon Q web experience.
        /// 
        /// </para>
        /// </summary>
        public CustomizationConfiguration CustomizationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CustomizationConfiguration property is set.
        /// </summary>
        internal bool IsSetCustomizationConfiguration() => this.CustomizationConfiguration != null;

        /// <summary>
        /// Gets and sets the property DefaultEndpoint. 
        /// <para>
        /// The endpoint of your Amazon Q Business web experience.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string DefaultEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the DefaultEndpoint property is set.
        /// </summary>
        internal bool IsSetDefaultEndpoint() => this.DefaultEndpoint != null;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// When the <c>Status</c> field value is <c>FAILED</c>, the <c>ErrorMessage</c> field
        /// contains a description of the error that caused the data source connector to fail.
        /// </para>
        /// </summary>
        public ErrorDetail Error { get; set; }

        /// <summary>
        /// Checks to see if the Error property is set.
        /// </summary>
        internal bool IsSetError() => this.Error != null;

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
        /// Gets the website domain origins that are allowed to embed the Amazon Q Business web
        /// experience. The <i>domain origin</i> refers to the base URL for accessing a website
        /// including the protocol (<c>http/https</c>), the domain name, and the port number (if
        /// specified). 
        /// </para>
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
        ///  The Amazon Resource Name (ARN) of the service role attached to your web experience.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the Amazon Q Business web experience. When the <c>Status</c>
        /// field value is <c>FAILED</c>, the <c>ErrorMessage</c> field contains a description
        /// of the error that caused the data source connector to fail. 
        /// </para>
        /// </summary>
        public WebExperienceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Subtitle. 
        /// <para>
        /// The subtitle for your Amazon Q Business web experience. 
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
        /// The title for your Amazon Q Business web experience. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The Unix timestamp when the Amazon Q Business web experience was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property WebExperienceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the role with the permission to access the Amazon
        /// Q Business web experience and required resources.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1284)]
        public string WebExperienceArn { get; set; }

        /// <summary>
        /// Checks to see if the WebExperienceArn property is set.
        /// </summary>
        internal bool IsSetWebExperienceArn() => this.WebExperienceArn != null;

        /// <summary>
        /// Gets and sets the property WebExperienceId. 
        /// <para>
        /// The identifier of the Amazon Q Business web experience.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string WebExperienceId { get; set; }

        /// <summary>
        /// Checks to see if the WebExperienceId property is set.
        /// </summary>
        internal bool IsSetWebExperienceId() => this.WebExperienceId != null;

        /// <summary>
        /// Gets and sets the property WelcomeMessage. 
        /// <para>
        /// The customized welcome message for end users of an Amazon Q Business web experience.
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
