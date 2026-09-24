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

namespace Amazon.WorkSpacesWeb.Model
{
    /// <summary>
    /// A user settings resource that can be associated with a web portal. Once associated
    /// with a web portal, user settings control how users can transfer data between a streaming
    /// session and the their local devices.
    /// </summary>
    public partial class UserSettings
    {
        /// <summary>
        /// Gets and sets the property AdditionalEncryptionContext. 
        /// <para>
        /// The additional encryption context of the user settings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> AdditionalEncryptionContext { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the AdditionalEncryptionContext property is set.
        /// </summary>
        internal bool IsSetAdditionalEncryptionContext() => this.AdditionalEncryptionContext != null && (this.AdditionalEncryptionContext.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AssociatedPortalArns. 
        /// <para>
        /// A list of web portal ARNs that this user settings is associated with.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AssociatedPortalArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AssociatedPortalArns property is set.
        /// </summary>
        internal bool IsSetAssociatedPortalArns() => this.AssociatedPortalArns != null && (this.AssociatedPortalArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BrandingConfiguration. 
        /// <para>
        /// The branding configuration output that customizes the appearance of the web portal
        /// for end users.
        /// </para>
        /// </summary>
        public BrandingConfiguration BrandingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the BrandingConfiguration property is set.
        /// </summary>
        internal bool IsSetBrandingConfiguration() => this.BrandingConfiguration != null;

        /// <summary>
        /// Gets and sets the property CookieSynchronizationConfiguration. 
        /// <para>
        /// The configuration that specifies which cookies should be synchronized from the end
        /// user's local browser to the remote browser.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public CookieSynchronizationConfiguration CookieSynchronizationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CookieSynchronizationConfiguration property is set.
        /// </summary>
        internal bool IsSetCookieSynchronizationConfiguration() => this.CookieSynchronizationConfiguration != null;

        /// <summary>
        /// Gets and sets the property CopyAllowed. 
        /// <para>
        /// Specifies whether the user can copy text from the streaming session to the local device.
        /// </para>
        /// </summary>
        public EnabledType CopyAllowed { get; set; }

        /// <summary>
        /// Checks to see if the CopyAllowed property is set.
        /// </summary>
        internal bool IsSetCopyAllowed() => this.CopyAllowed != null;

        /// <summary>
        /// Gets and sets the property CustomerManagedKey. 
        /// <para>
        /// The customer managed key used to encrypt sensitive information in the user settings.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string CustomerManagedKey { get; set; }

        /// <summary>
        /// Checks to see if the CustomerManagedKey property is set.
        /// </summary>
        internal bool IsSetCustomerManagedKey() => this.CustomerManagedKey != null;

        /// <summary>
        /// Gets and sets the property DeepLinkAllowed. 
        /// <para>
        /// Specifies whether the user can use deep links that open automatically when connecting
        /// to a session.
        /// </para>
        /// </summary>
        public EnabledType DeepLinkAllowed { get; set; }

        /// <summary>
        /// Checks to see if the DeepLinkAllowed property is set.
        /// </summary>
        internal bool IsSetDeepLinkAllowed() => this.DeepLinkAllowed != null;

        /// <summary>
        /// Gets and sets the property DisconnectTimeoutInMinutes. 
        /// <para>
        /// The amount of time that a streaming session remains active after users disconnect.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 600)]
        public int? DisconnectTimeoutInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the DisconnectTimeoutInMinutes property is set.
        /// </summary>
        internal bool IsSetDisconnectTimeoutInMinutes() => this.DisconnectTimeoutInMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property DownloadAllowed. 
        /// <para>
        /// Specifies whether the user can download files from the streaming session to the local
        /// device.
        /// </para>
        /// </summary>
        public EnabledType DownloadAllowed { get; set; }

        /// <summary>
        /// Checks to see if the DownloadAllowed property is set.
        /// </summary>
        internal bool IsSetDownloadAllowed() => this.DownloadAllowed != null;

        /// <summary>
        /// Gets and sets the property IdleDisconnectTimeoutInMinutes. 
        /// <para>
        /// The amount of time that users can be idle (inactive) before they are disconnected
        /// from their streaming session and the disconnect timeout interval begins.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 60)]
        public int? IdleDisconnectTimeoutInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the IdleDisconnectTimeoutInMinutes property is set.
        /// </summary>
        internal bool IsSetIdleDisconnectTimeoutInMinutes() => this.IdleDisconnectTimeoutInMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property PasteAllowed. 
        /// <para>
        /// Specifies whether the user can paste text from the local device to the streaming session.
        /// </para>
        /// </summary>
        public EnabledType PasteAllowed { get; set; }

        /// <summary>
        /// Checks to see if the PasteAllowed property is set.
        /// </summary>
        internal bool IsSetPasteAllowed() => this.PasteAllowed != null;

        /// <summary>
        /// Gets and sets the property PrintAllowed. 
        /// <para>
        /// Specifies whether the user can print to the local device.
        /// </para>
        /// </summary>
        public EnabledType PrintAllowed { get; set; }

        /// <summary>
        /// Checks to see if the PrintAllowed property is set.
        /// </summary>
        internal bool IsSetPrintAllowed() => this.PrintAllowed != null;

        /// <summary>
        /// Gets and sets the property ToolbarConfiguration. 
        /// <para>
        /// The configuration of the toolbar. This allows administrators to select the toolbar
        /// type and visual mode, set maximum display resolution for sessions, and choose which
        /// items are visible to end users during their sessions. If administrators do not modify
        /// these settings, end users retain control over their toolbar preferences.
        /// </para>
        /// </summary>
        public ToolbarConfiguration ToolbarConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ToolbarConfiguration property is set.
        /// </summary>
        internal bool IsSetToolbarConfiguration() => this.ToolbarConfiguration != null;

        /// <summary>
        /// Gets and sets the property UploadAllowed. 
        /// <para>
        /// Specifies whether the user can upload files from the local device to the streaming
        /// session.
        /// </para>
        /// </summary>
        public EnabledType UploadAllowed { get; set; }

        /// <summary>
        /// Checks to see if the UploadAllowed property is set.
        /// </summary>
        internal bool IsSetUploadAllowed() => this.UploadAllowed != null;

        /// <summary>
        /// Gets and sets the property UserSettingsArn. 
        /// <para>
        /// The ARN of the user settings.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string UserSettingsArn { get; set; }

        /// <summary>
        /// Checks to see if the UserSettingsArn property is set.
        /// </summary>
        internal bool IsSetUserSettingsArn() => this.UserSettingsArn != null;

        /// <summary>
        /// Gets and sets the property WebAuthnAllowed. 
        /// <para>
        /// Specifies whether the user can use WebAuthn redirection for passwordless login to
        /// websites within the streaming session.
        /// </para>
        /// </summary>
        public EnabledType WebAuthnAllowed { get; set; }

        /// <summary>
        /// Checks to see if the WebAuthnAllowed property is set.
        /// </summary>
        internal bool IsSetWebAuthnAllowed() => this.WebAuthnAllowed != null;
    }
}
