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

namespace Amazon.Wickr.Model
{
    /// <summary>
    /// Comprehensive configuration settings that define all user capabilities, restrictions,
    /// and features for members of a security group. These settings control everything from
    /// calling permissions to federation settings to security policies.
    /// </summary>
    public partial class SecurityGroupSettings
    {
        /// <summary>
        /// Gets and sets the property AlwaysReauthenticate. 
        /// <para>
        /// Requires users to reauthenticate every time they return to the application, providing
        /// an additional layer of security.
        /// </para>
        /// </summary>
        public bool? AlwaysReauthenticate { get; set; }

        /// <summary>
        /// Checks to see if the AlwaysReauthenticate property is set.
        /// </summary>
        internal bool IsSetAlwaysReauthenticate() => this.AlwaysReauthenticate.HasValue;

        /// <summary>
        /// Gets and sets the property AtakPackageValues. 
        /// <para>
        /// Configuration values for ATAK (Android Team Awareness Kit) package integration, when
        /// ATAK is enabled.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AtakPackageValues { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AtakPackageValues property is set.
        /// </summary>
        internal bool IsSetAtakPackageValues() => this.AtakPackageValues != null && (this.AtakPackageValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Calling. 
        /// <para>
        /// The calling feature permissions and settings that control what types of calls users
        /// can initiate and participate in.
        /// </para>
        /// </summary>
        public CallingSettings Calling { get; set; }

        /// <summary>
        /// Checks to see if the Calling property is set.
        /// </summary>
        internal bool IsSetCalling() => this.Calling != null;

        /// <summary>
        /// Gets and sets the property CheckForUpdates. 
        /// <para>
        /// Enables automatic checking for Wickr client updates to ensure users stay current with
        /// the latest version.
        /// </para>
        /// </summary>
        public bool? CheckForUpdates { get; set; }

        /// <summary>
        /// Checks to see if the CheckForUpdates property is set.
        /// </summary>
        internal bool IsSetCheckForUpdates() => this.CheckForUpdates.HasValue;

        /// <summary>
        /// Gets and sets the property EnableAtak. 
        /// <para>
        /// Enables ATAK (Android Team Awareness Kit) integration for tactical communication and
        /// situational awareness.
        /// </para>
        /// </summary>
        public bool? EnableAtak { get; set; }

        /// <summary>
        /// Checks to see if the EnableAtak property is set.
        /// </summary>
        internal bool IsSetEnableAtak() => this.EnableAtak.HasValue;

        /// <summary>
        /// Gets and sets the property EnableCrashReports. 
        /// <para>
        /// Allow users to report crashes.
        /// </para>
        /// </summary>
        public bool? EnableCrashReports { get; set; }

        /// <summary>
        /// Checks to see if the EnableCrashReports property is set.
        /// </summary>
        internal bool IsSetEnableCrashReports() => this.EnableCrashReports.HasValue;

        /// <summary>
        /// Gets and sets the property EnableFileDownload. 
        /// <para>
        /// Specifies whether users can download files from messages to their devices.
        /// </para>
        /// </summary>
        public bool? EnableFileDownload { get; set; }

        /// <summary>
        /// Checks to see if the EnableFileDownload property is set.
        /// </summary>
        internal bool IsSetEnableFileDownload() => this.EnableFileDownload.HasValue;

        /// <summary>
        /// Gets and sets the property EnableGuestFederation. 
        /// <para>
        /// Allows users to communicate with guest users from other Wickr networks and federated
        /// external networks.
        /// </para>
        /// </summary>
        public bool? EnableGuestFederation { get; set; }

        /// <summary>
        /// Checks to see if the EnableGuestFederation property is set.
        /// </summary>
        internal bool IsSetEnableGuestFederation() => this.EnableGuestFederation.HasValue;

        /// <summary>
        /// Gets and sets the property EnableNotificationPreview. 
        /// <para>
        /// Enables message preview text in push notifications, allowing users to see message
        /// content before opening the app.
        /// </para>
        /// </summary>
        public bool? EnableNotificationPreview { get; set; }

        /// <summary>
        /// Checks to see if the EnableNotificationPreview property is set.
        /// </summary>
        internal bool IsSetEnableNotificationPreview() => this.EnableNotificationPreview.HasValue;

        /// <summary>
        /// Gets and sets the property EnableOpenAccessOption. 
        /// <para>
        ///  Allow users to avoid censorship when they are geo-blocked or have network limitations.
        /// </para>
        /// </summary>
        public bool? EnableOpenAccessOption { get; set; }

        /// <summary>
        /// Checks to see if the EnableOpenAccessOption property is set.
        /// </summary>
        internal bool IsSetEnableOpenAccessOption() => this.EnableOpenAccessOption.HasValue;

        /// <summary>
        /// Gets and sets the property EnableRestrictedGlobalFederation. 
        /// <para>
        /// Enables restricted global federation, limiting external communication to only specified
        /// permitted networks.
        /// </para>
        /// </summary>
        public bool? EnableRestrictedGlobalFederation { get; set; }

        /// <summary>
        /// Checks to see if the EnableRestrictedGlobalFederation property is set.
        /// </summary>
        internal bool IsSetEnableRestrictedGlobalFederation() => this.EnableRestrictedGlobalFederation.HasValue;

        /// <summary>
        /// Gets and sets the property FederationMode. 
        /// <para>
        /// The local federation mode controlling how users can communicate with other networks.
        /// Values: 0 (none), 1 (federated), 2 (restricted).
        /// </para>
        /// </summary>
        public int? FederationMode { get; set; }

        /// <summary>
        /// Checks to see if the FederationMode property is set.
        /// </summary>
        internal bool IsSetFederationMode() => this.FederationMode.HasValue;

        /// <summary>
        /// Gets and sets the property FilesEnabled. 
        /// <para>
        /// Enables file sharing capabilities, allowing users to send and receive files in conversations.
        /// </para>
        /// </summary>
        public bool? FilesEnabled { get; set; }

        /// <summary>
        /// Checks to see if the FilesEnabled property is set.
        /// </summary>
        internal bool IsSetFilesEnabled() => this.FilesEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property ForceDeviceLockout. 
        /// <para>
        ///  Defines the number of failed login attempts before data stored on the device is reset.
        /// Should be less than lockoutThreshold.
        /// </para>
        /// </summary>
        public int? ForceDeviceLockout { get; set; }

        /// <summary>
        /// Checks to see if the ForceDeviceLockout property is set.
        /// </summary>
        internal bool IsSetForceDeviceLockout() => this.ForceDeviceLockout.HasValue;

        /// <summary>
        /// Gets and sets the property ForceOpenAccess. 
        /// <para>
        /// Automatically enable and enforce Wickr open access on all devices. Valid only if enableOpenAccessOption
        /// settings is enabled.
        /// </para>
        /// </summary>
        public bool? ForceOpenAccess { get; set; }

        /// <summary>
        /// Checks to see if the ForceOpenAccess property is set.
        /// </summary>
        internal bool IsSetForceOpenAccess() => this.ForceOpenAccess.HasValue;

        /// <summary>
        /// Gets and sets the property ForceReadReceipts. 
        /// <para>
        /// Allow user approved bots to read messages in rooms without using a slash command.
        /// </para>
        /// </summary>
        public bool? ForceReadReceipts { get; set; }

        /// <summary>
        /// Checks to see if the ForceReadReceipts property is set.
        /// </summary>
        internal bool IsSetForceReadReceipts() => this.ForceReadReceipts.HasValue;

        /// <summary>
        /// Gets and sets the property GlobalFederation. 
        /// <para>
        /// Allows users to communicate with users on other Wickr instances (Wickr Enterprise)
        /// outside the current network.
        /// </para>
        /// </summary>
        public bool? GlobalFederation { get; set; }

        /// <summary>
        /// Checks to see if the GlobalFederation property is set.
        /// </summary>
        internal bool IsSetGlobalFederation() => this.GlobalFederation.HasValue;

        /// <summary>
        /// Gets and sets the property IsAtoEnabled. 
        /// <para>
        /// Enforces a two-factor authentication when a user adds a new device to their account.
        /// </para>
        /// </summary>
        public bool? IsAtoEnabled { get; set; }

        /// <summary>
        /// Checks to see if the IsAtoEnabled property is set.
        /// </summary>
        internal bool IsSetIsAtoEnabled() => this.IsAtoEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property IsLinkPreviewEnabled. 
        /// <para>
        /// Enables automatic preview of links shared in messages, showing webpage thumbnails
        /// and descriptions.
        /// </para>
        /// </summary>
        public bool? IsLinkPreviewEnabled { get; set; }

        /// <summary>
        /// Checks to see if the IsLinkPreviewEnabled property is set.
        /// </summary>
        internal bool IsSetIsLinkPreviewEnabled() => this.IsLinkPreviewEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property LocationAllowMaps. 
        /// <para>
        /// Allows map integration in location sharing, enabling users to view shared locations
        /// on interactive maps. Only allowed when location setting is enabled.
        /// </para>
        /// </summary>
        public bool? LocationAllowMaps { get; set; }

        /// <summary>
        /// Checks to see if the LocationAllowMaps property is set.
        /// </summary>
        internal bool IsSetLocationAllowMaps() => this.LocationAllowMaps.HasValue;

        /// <summary>
        /// Gets and sets the property LocationEnabled. 
        /// <para>
        /// Enables location sharing features, allowing users to share their current location
        /// with others.
        /// </para>
        /// </summary>
        public bool? LocationEnabled { get; set; }

        /// <summary>
        /// Checks to see if the LocationEnabled property is set.
        /// </summary>
        internal bool IsSetLocationEnabled() => this.LocationEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property LockoutThreshold. 
        /// <para>
        /// The number of failed password attempts before a user account is locked out.
        /// </para>
        /// </summary>
        public int? LockoutThreshold { get; set; }

        /// <summary>
        /// Checks to see if the LockoutThreshold property is set.
        /// </summary>
        internal bool IsSetLockoutThreshold() => this.LockoutThreshold.HasValue;

        /// <summary>
        /// Gets and sets the property MaxAutoDownloadSize. 
        /// <para>
        /// The maximum file size in bytes that will be automatically downloaded without user
        /// confirmation. Only allowed if fileDownload is enabled. Valid Values [512000 (low_quality),
        /// 7340032 (high_quality) ]
        /// </para>
        /// </summary>
        public long? MaxAutoDownloadSize { get; set; }

        /// <summary>
        /// Checks to see if the MaxAutoDownloadSize property is set.
        /// </summary>
        internal bool IsSetMaxAutoDownloadSize() => this.MaxAutoDownloadSize.HasValue;

        /// <summary>
        /// Gets and sets the property MaxBor. 
        /// <para>
        /// The maximum burn-on-read (BOR) time in seconds, which determines how long messages
        /// remain visible before auto-deletion after being read.
        /// </para>
        /// </summary>
        public int? MaxBor { get; set; }

        /// <summary>
        /// Checks to see if the MaxBor property is set.
        /// </summary>
        internal bool IsSetMaxBor() => this.MaxBor.HasValue;

        /// <summary>
        /// Gets and sets the property MaxNonSsoSessionMinutes. 
        /// <para>
        /// Maximum session duration in minutes for non-SSO users. Set to 0 to disable. Valid
        /// range is 60 to 525600 (1 hour to 365 days).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 525600)]
        public int? MaxNonSsoSessionMinutes { get; set; }

        /// <summary>
        /// Checks to see if the MaxNonSsoSessionMinutes property is set.
        /// </summary>
        internal bool IsSetMaxNonSsoSessionMinutes() => this.MaxNonSsoSessionMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property MaxTtl. 
        /// <para>
        /// The maximum time-to-live (TTL) in seconds for messages, after which they will be automatically
        /// deleted from all devices.
        /// </para>
        /// </summary>
        public long? MaxTtl { get; set; }

        /// <summary>
        /// Checks to see if the MaxTtl property is set.
        /// </summary>
        internal bool IsSetMaxTtl() => this.MaxTtl.HasValue;

        /// <summary>
        /// Gets and sets the property MessageForwardingEnabled. 
        /// <para>
        /// Enables message forwarding, allowing users to forward messages from one conversation
        /// to another.
        /// </para>
        /// </summary>
        public bool? MessageForwardingEnabled { get; set; }

        /// <summary>
        /// Checks to see if the MessageForwardingEnabled property is set.
        /// </summary>
        internal bool IsSetMessageForwardingEnabled() => this.MessageForwardingEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property PasswordRequirements. 
        /// <para>
        /// The password complexity requirements that users must follow when creating or changing
        /// passwords.
        /// </para>
        /// </summary>
        public PasswordRequirements PasswordRequirements { get; set; }

        /// <summary>
        /// Checks to see if the PasswordRequirements property is set.
        /// </summary>
        internal bool IsSetPasswordRequirements() => this.PasswordRequirements != null;

        /// <summary>
        /// Gets and sets the property PermittedNetworks. 
        /// <para>
        /// A list of network IDs that are permitted for local federation when federation mode
        /// is set to restricted.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PermittedNetworks { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PermittedNetworks property is set.
        /// </summary>
        internal bool IsSetPermittedNetworks() => this.PermittedNetworks != null && (this.PermittedNetworks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PermittedWickrAwsNetworks. 
        /// <para>
        /// A list of permitted Wickr networks for global federation, restricting communication
        /// to specific approved networks.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<WickrAwsNetworks> PermittedWickrAwsNetworks { get; set; } = AWSConfigs.InitializeCollections ? new List<WickrAwsNetworks>() : null;

        /// <summary>
        /// Checks to see if the PermittedWickrAwsNetworks property is set.
        /// </summary>
        internal bool IsSetPermittedWickrAwsNetworks() => this.PermittedWickrAwsNetworks != null && (this.PermittedWickrAwsNetworks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PermittedWickrEnterpriseNetworks. 
        /// <para>
        /// A list of permitted Wickr Enterprise networks for global federation, restricting communication
        /// to specific approved networks.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PermittedWickrEnterpriseNetwork> PermittedWickrEnterpriseNetworks { get; set; } = AWSConfigs.InitializeCollections ? new List<PermittedWickrEnterpriseNetwork>() : null;

        /// <summary>
        /// Checks to see if the PermittedWickrEnterpriseNetworks property is set.
        /// </summary>
        internal bool IsSetPermittedWickrEnterpriseNetworks() => this.PermittedWickrEnterpriseNetworks != null && (this.PermittedWickrEnterpriseNetworks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PresenceEnabled. 
        /// <para>
        /// Enables presence indicators that show whether users are online, away, or offline.
        /// </para>
        /// </summary>
        public bool? PresenceEnabled { get; set; }

        /// <summary>
        /// Checks to see if the PresenceEnabled property is set.
        /// </summary>
        internal bool IsSetPresenceEnabled() => this.PresenceEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property QuickResponses. 
        /// <para>
        /// A list of pre-defined quick response message templates that users can send with a
        /// single tap.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> QuickResponses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the QuickResponses property is set.
        /// </summary>
        internal bool IsSetQuickResponses() => this.QuickResponses != null && (this.QuickResponses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ShowMasterRecoveryKey. 
        /// <para>
        /// Users will get a master recovery key that can be used to securely sign in to their
        /// Wickr account without having access to their primary device for authentication. Available
        /// in SSO enabled network.
        /// </para>
        /// </summary>
        public bool? ShowMasterRecoveryKey { get; set; }

        /// <summary>
        /// Checks to see if the ShowMasterRecoveryKey property is set.
        /// </summary>
        internal bool IsSetShowMasterRecoveryKey() => this.ShowMasterRecoveryKey.HasValue;

        /// <summary>
        /// Gets and sets the property Shredder. 
        /// <para>
        /// The message shredder configuration that controls secure deletion of messages and files
        /// from devices.
        /// </para>
        /// </summary>
        public ShredderSettings Shredder { get; set; }

        /// <summary>
        /// Checks to see if the Shredder property is set.
        /// </summary>
        internal bool IsSetShredder() => this.Shredder != null;

        /// <summary>
        /// Gets and sets the property SsoMaxIdleMinutes. 
        /// <para>
        /// The duration for which users SSO session remains inactive before automatically logging
        /// them out for security. Available in SSO enabled network.
        /// </para>
        /// </summary>
        public int? SsoMaxIdleMinutes { get; set; }

        /// <summary>
        /// Checks to see if the SsoMaxIdleMinutes property is set.
        /// </summary>
        internal bool IsSetSsoMaxIdleMinutes() => this.SsoMaxIdleMinutes.HasValue;
    }
}
