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
 * Do not modify this file. This file is generated from the wickr-2024-02-01.normal.json service model.
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
        private bool? _alwaysReauthenticate;
        private List<string> _atakPackageValues = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private CallingSettings _calling;
        private bool? _checkForUpdates;
        private bool? _enableAtak;
        private bool? _enableCrashReports;
        private bool? _enableFileDownload;
        private bool? _enableGuestFederation;
        private bool? _enableNotificationPreview;
        private bool? _enableOpenAccessOption;
        private bool? _enableRestrictedGlobalFederation;
        private int? _federationMode;
        private bool? _filesEnabled;
        private int? _forceDeviceLockout;
        private bool? _forceOpenAccess;
        private bool? _forceReadReceipts;
        private bool? _globalFederation;
        private bool? _isAtoEnabled;
        private bool? _isLinkPreviewEnabled;
        private bool? _locationAllowMaps;
        private bool? _locationEnabled;
        private int? _lockoutThreshold;
        private long? _maxAutoDownloadSize;
        private int? _maxBor;
        private long? _maxTtl;
        private bool? _messageForwardingEnabled;
        private PasswordRequirements _passwordRequirements;
        private List<string> _permittedNetworks = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<WickrAwsNetworks> _permittedWickrAwsNetworks = AWSConfigs.InitializeCollections ? new List<WickrAwsNetworks>() : null;
        private List<PermittedWickrEnterpriseNetwork> _permittedWickrEnterpriseNetworks = AWSConfigs.InitializeCollections ? new List<PermittedWickrEnterpriseNetwork>() : null;
        private bool? _presenceEnabled;
        private List<string> _quickResponses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _showMasterRecoveryKey;
        private ShredderSettings _shredder;
        private int? _ssoMaxIdleMinutes;

        /// <summary>
        /// Gets and sets the property AlwaysReauthenticate. 
        /// <para>
        /// Requires users to reauthenticate every time they return to the application, providing
        /// an additional layer of security.
        /// </para>
        /// </summary>
        public bool? AlwaysReauthenticate
        {
            get { return this._alwaysReauthenticate; }
            set { this._alwaysReauthenticate = value; }
        }

        // Check to see if AlwaysReauthenticate property is set
        internal bool IsSetAlwaysReauthenticate()
        {
            return this._alwaysReauthenticate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AtakPackageValues. 
        /// <para>
        /// Configuration values for ATAK (Android Team Awareness Kit) package integration, when
        /// ATAK is enabled.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AtakPackageValues
        {
            get { return this._atakPackageValues; }
            set { this._atakPackageValues = value; }
        }

        // Check to see if AtakPackageValues property is set
        internal bool IsSetAtakPackageValues()
        {
            return this._atakPackageValues != null && (this._atakPackageValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Calling. 
        /// <para>
        /// The calling feature permissions and settings that control what types of calls users
        /// can initiate and participate in.
        /// </para>
        /// </summary>
        public CallingSettings Calling
        {
            get { return this._calling; }
            set { this._calling = value; }
        }

        // Check to see if Calling property is set
        internal bool IsSetCalling()
        {
            return this._calling != null;
        }

        /// <summary>
        /// Gets and sets the property CheckForUpdates. 
        /// <para>
        /// Enables automatic checking for Wickr client updates to ensure users stay current with
        /// the latest version.
        /// </para>
        /// </summary>
        public bool? CheckForUpdates
        {
            get { return this._checkForUpdates; }
            set { this._checkForUpdates = value; }
        }

        // Check to see if CheckForUpdates property is set
        internal bool IsSetCheckForUpdates()
        {
            return this._checkForUpdates.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableAtak. 
        /// <para>
        /// Enables ATAK (Android Team Awareness Kit) integration for tactical communication and
        /// situational awareness.
        /// </para>
        /// </summary>
        public bool? EnableAtak
        {
            get { return this._enableAtak; }
            set { this._enableAtak = value; }
        }

        // Check to see if EnableAtak property is set
        internal bool IsSetEnableAtak()
        {
            return this._enableAtak.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableCrashReports. 
        /// <para>
        /// Allow users to report crashes.
        /// </para>
        /// </summary>
        public bool? EnableCrashReports
        {
            get { return this._enableCrashReports; }
            set { this._enableCrashReports = value; }
        }

        // Check to see if EnableCrashReports property is set
        internal bool IsSetEnableCrashReports()
        {
            return this._enableCrashReports.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableFileDownload. 
        /// <para>
        /// Specifies whether users can download files from messages to their devices.
        /// </para>
        /// </summary>
        public bool? EnableFileDownload
        {
            get { return this._enableFileDownload; }
            set { this._enableFileDownload = value; }
        }

        // Check to see if EnableFileDownload property is set
        internal bool IsSetEnableFileDownload()
        {
            return this._enableFileDownload.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableGuestFederation. 
        /// <para>
        /// Allows users to communicate with guest users from other Wickr networks and federated
        /// external networks.
        /// </para>
        /// </summary>
        public bool? EnableGuestFederation
        {
            get { return this._enableGuestFederation; }
            set { this._enableGuestFederation = value; }
        }

        // Check to see if EnableGuestFederation property is set
        internal bool IsSetEnableGuestFederation()
        {
            return this._enableGuestFederation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableNotificationPreview. 
        /// <para>
        /// Enables message preview text in push notifications, allowing users to see message
        /// content before opening the app.
        /// </para>
        /// </summary>
        public bool? EnableNotificationPreview
        {
            get { return this._enableNotificationPreview; }
            set { this._enableNotificationPreview = value; }
        }

        // Check to see if EnableNotificationPreview property is set
        internal bool IsSetEnableNotificationPreview()
        {
            return this._enableNotificationPreview.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableOpenAccessOption. 
        /// <para>
        ///  Allow users to avoid censorship when they are geo-blocked or have network limitations.
        /// </para>
        /// </summary>
        public bool? EnableOpenAccessOption
        {
            get { return this._enableOpenAccessOption; }
            set { this._enableOpenAccessOption = value; }
        }

        // Check to see if EnableOpenAccessOption property is set
        internal bool IsSetEnableOpenAccessOption()
        {
            return this._enableOpenAccessOption.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableRestrictedGlobalFederation. 
        /// <para>
        /// Enables restricted global federation, limiting external communication to only specified
        /// permitted networks.
        /// </para>
        /// </summary>
        public bool? EnableRestrictedGlobalFederation
        {
            get { return this._enableRestrictedGlobalFederation; }
            set { this._enableRestrictedGlobalFederation = value; }
        }

        // Check to see if EnableRestrictedGlobalFederation property is set
        internal bool IsSetEnableRestrictedGlobalFederation()
        {
            return this._enableRestrictedGlobalFederation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FederationMode. 
        /// <para>
        /// The local federation mode controlling how users can communicate with other networks.
        /// Values: 0 (none), 1 (federated), 2 (restricted).
        /// </para>
        /// </summary>
        public int? FederationMode
        {
            get { return this._federationMode; }
            set { this._federationMode = value; }
        }

        // Check to see if FederationMode property is set
        internal bool IsSetFederationMode()
        {
            return this._federationMode.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FilesEnabled. 
        /// <para>
        /// Enables file sharing capabilities, allowing users to send and receive files in conversations.
        /// </para>
        /// </summary>
        public bool? FilesEnabled
        {
            get { return this._filesEnabled; }
            set { this._filesEnabled = value; }
        }

        // Check to see if FilesEnabled property is set
        internal bool IsSetFilesEnabled()
        {
            return this._filesEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ForceDeviceLockout. 
        /// <para>
        ///  Defines the number of failed login attempts before data stored on the device is reset.
        /// Should be less than lockoutThreshold.
        /// </para>
        /// </summary>
        public int? ForceDeviceLockout
        {
            get { return this._forceDeviceLockout; }
            set { this._forceDeviceLockout = value; }
        }

        // Check to see if ForceDeviceLockout property is set
        internal bool IsSetForceDeviceLockout()
        {
            return this._forceDeviceLockout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ForceOpenAccess. 
        /// <para>
        /// Automatically enable and enforce Wickr open access on all devices. Valid only if enableOpenAccessOption
        /// settings is enabled.
        /// </para>
        /// </summary>
        public bool? ForceOpenAccess
        {
            get { return this._forceOpenAccess; }
            set { this._forceOpenAccess = value; }
        }

        // Check to see if ForceOpenAccess property is set
        internal bool IsSetForceOpenAccess()
        {
            return this._forceOpenAccess.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ForceReadReceipts. 
        /// <para>
        /// Allow user approved bots to read messages in rooms without using a slash command.
        /// </para>
        /// </summary>
        public bool? ForceReadReceipts
        {
            get { return this._forceReadReceipts; }
            set { this._forceReadReceipts = value; }
        }

        // Check to see if ForceReadReceipts property is set
        internal bool IsSetForceReadReceipts()
        {
            return this._forceReadReceipts.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GlobalFederation. 
        /// <para>
        /// Allows users to communicate with users on other Wickr instances (Wickr Enterprise)
        /// outside the current network.
        /// </para>
        /// </summary>
        public bool? GlobalFederation
        {
            get { return this._globalFederation; }
            set { this._globalFederation = value; }
        }

        // Check to see if GlobalFederation property is set
        internal bool IsSetGlobalFederation()
        {
            return this._globalFederation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsAtoEnabled. 
        /// <para>
        /// Enforces a two-factor authentication when a user adds a new device to their account.
        /// </para>
        /// </summary>
        public bool? IsAtoEnabled
        {
            get { return this._isAtoEnabled; }
            set { this._isAtoEnabled = value; }
        }

        // Check to see if IsAtoEnabled property is set
        internal bool IsSetIsAtoEnabled()
        {
            return this._isAtoEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsLinkPreviewEnabled. 
        /// <para>
        /// Enables automatic preview of links shared in messages, showing webpage thumbnails
        /// and descriptions.
        /// </para>
        /// </summary>
        public bool? IsLinkPreviewEnabled
        {
            get { return this._isLinkPreviewEnabled; }
            set { this._isLinkPreviewEnabled = value; }
        }

        // Check to see if IsLinkPreviewEnabled property is set
        internal bool IsSetIsLinkPreviewEnabled()
        {
            return this._isLinkPreviewEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LocationAllowMaps. 
        /// <para>
        /// Allows map integration in location sharing, enabling users to view shared locations
        /// on interactive maps. Only allowed when location setting is enabled.
        /// </para>
        /// </summary>
        public bool? LocationAllowMaps
        {
            get { return this._locationAllowMaps; }
            set { this._locationAllowMaps = value; }
        }

        // Check to see if LocationAllowMaps property is set
        internal bool IsSetLocationAllowMaps()
        {
            return this._locationAllowMaps.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LocationEnabled. 
        /// <para>
        /// Enables location sharing features, allowing users to share their current location
        /// with others.
        /// </para>
        /// </summary>
        public bool? LocationEnabled
        {
            get { return this._locationEnabled; }
            set { this._locationEnabled = value; }
        }

        // Check to see if LocationEnabled property is set
        internal bool IsSetLocationEnabled()
        {
            return this._locationEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LockoutThreshold. 
        /// <para>
        /// The number of failed password attempts before a user account is locked out.
        /// </para>
        /// </summary>
        public int? LockoutThreshold
        {
            get { return this._lockoutThreshold; }
            set { this._lockoutThreshold = value; }
        }

        // Check to see if LockoutThreshold property is set
        internal bool IsSetLockoutThreshold()
        {
            return this._lockoutThreshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxAutoDownloadSize. 
        /// <para>
        /// The maximum file size in bytes that will be automatically downloaded without user
        /// confirmation. Only allowed if fileDownload is enabled. Valid Values [512000 (low_quality),
        /// 7340032 (high_quality) ]
        /// </para>
        /// </summary>
        public long? MaxAutoDownloadSize
        {
            get { return this._maxAutoDownloadSize; }
            set { this._maxAutoDownloadSize = value; }
        }

        // Check to see if MaxAutoDownloadSize property is set
        internal bool IsSetMaxAutoDownloadSize()
        {
            return this._maxAutoDownloadSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxBor. 
        /// <para>
        /// The maximum burn-on-read (BOR) time in seconds, which determines how long messages
        /// remain visible before auto-deletion after being read.
        /// </para>
        /// </summary>
        public int? MaxBor
        {
            get { return this._maxBor; }
            set { this._maxBor = value; }
        }

        // Check to see if MaxBor property is set
        internal bool IsSetMaxBor()
        {
            return this._maxBor.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxTtl. 
        /// <para>
        /// The maximum time-to-live (TTL) in seconds for messages, after which they will be automatically
        /// deleted from all devices.
        /// </para>
        /// </summary>
        public long? MaxTtl
        {
            get { return this._maxTtl; }
            set { this._maxTtl = value; }
        }

        // Check to see if MaxTtl property is set
        internal bool IsSetMaxTtl()
        {
            return this._maxTtl.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MessageForwardingEnabled. 
        /// <para>
        /// Enables message forwarding, allowing users to forward messages from one conversation
        /// to another.
        /// </para>
        /// </summary>
        public bool? MessageForwardingEnabled
        {
            get { return this._messageForwardingEnabled; }
            set { this._messageForwardingEnabled = value; }
        }

        // Check to see if MessageForwardingEnabled property is set
        internal bool IsSetMessageForwardingEnabled()
        {
            return this._messageForwardingEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PasswordRequirements. 
        /// <para>
        /// The password complexity requirements that users must follow when creating or changing
        /// passwords.
        /// </para>
        /// </summary>
        public PasswordRequirements PasswordRequirements
        {
            get { return this._passwordRequirements; }
            set { this._passwordRequirements = value; }
        }

        // Check to see if PasswordRequirements property is set
        internal bool IsSetPasswordRequirements()
        {
            return this._passwordRequirements != null;
        }

        /// <summary>
        /// Gets and sets the property PermittedNetworks. 
        /// <para>
        /// A list of network IDs that are permitted for local federation when federation mode
        /// is set to restricted.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PermittedNetworks
        {
            get { return this._permittedNetworks; }
            set { this._permittedNetworks = value; }
        }

        // Check to see if PermittedNetworks property is set
        internal bool IsSetPermittedNetworks()
        {
            return this._permittedNetworks != null && (this._permittedNetworks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PermittedWickrAwsNetworks. 
        /// <para>
        /// A list of permitted Wickr networks for global federation, restricting communication
        /// to specific approved networks.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<WickrAwsNetworks> PermittedWickrAwsNetworks
        {
            get { return this._permittedWickrAwsNetworks; }
            set { this._permittedWickrAwsNetworks = value; }
        }

        // Check to see if PermittedWickrAwsNetworks property is set
        internal bool IsSetPermittedWickrAwsNetworks()
        {
            return this._permittedWickrAwsNetworks != null && (this._permittedWickrAwsNetworks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PermittedWickrEnterpriseNetworks. 
        /// <para>
        /// A list of permitted Wickr Enterprise networks for global federation, restricting communication
        /// to specific approved networks.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PermittedWickrEnterpriseNetwork> PermittedWickrEnterpriseNetworks
        {
            get { return this._permittedWickrEnterpriseNetworks; }
            set { this._permittedWickrEnterpriseNetworks = value; }
        }

        // Check to see if PermittedWickrEnterpriseNetworks property is set
        internal bool IsSetPermittedWickrEnterpriseNetworks()
        {
            return this._permittedWickrEnterpriseNetworks != null && (this._permittedWickrEnterpriseNetworks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PresenceEnabled. 
        /// <para>
        /// Enables presence indicators that show whether users are online, away, or offline.
        /// </para>
        /// </summary>
        public bool? PresenceEnabled
        {
            get { return this._presenceEnabled; }
            set { this._presenceEnabled = value; }
        }

        // Check to see if PresenceEnabled property is set
        internal bool IsSetPresenceEnabled()
        {
            return this._presenceEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QuickResponses. 
        /// <para>
        /// A list of pre-defined quick response message templates that users can send with a
        /// single tap.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> QuickResponses
        {
            get { return this._quickResponses; }
            set { this._quickResponses = value; }
        }

        // Check to see if QuickResponses property is set
        internal bool IsSetQuickResponses()
        {
            return this._quickResponses != null && (this._quickResponses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ShowMasterRecoveryKey. 
        /// <para>
        /// Users will get a master recovery key that can be used to securely sign in to their
        /// Wickr account without having access to their primary device for authentication. Available
        /// in SSO enabled network.
        /// </para>
        /// </summary>
        public bool? ShowMasterRecoveryKey
        {
            get { return this._showMasterRecoveryKey; }
            set { this._showMasterRecoveryKey = value; }
        }

        // Check to see if ShowMasterRecoveryKey property is set
        internal bool IsSetShowMasterRecoveryKey()
        {
            return this._showMasterRecoveryKey.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Shredder. 
        /// <para>
        /// The message shredder configuration that controls secure deletion of messages and files
        /// from devices.
        /// </para>
        /// </summary>
        public ShredderSettings Shredder
        {
            get { return this._shredder; }
            set { this._shredder = value; }
        }

        // Check to see if Shredder property is set
        internal bool IsSetShredder()
        {
            return this._shredder != null;
        }

        /// <summary>
        /// Gets and sets the property SsoMaxIdleMinutes. 
        /// <para>
        /// The duration for which users SSO session remains inactive before automatically logging
        /// them out for security. Available in SSO enabled network.
        /// </para>
        /// </summary>
        public int? SsoMaxIdleMinutes
        {
            get { return this._ssoMaxIdleMinutes; }
            set { this._ssoMaxIdleMinutes = value; }
        }

        // Check to see if SsoMaxIdleMinutes property is set
        internal bool IsSetSsoMaxIdleMinutes()
        {
            return this._ssoMaxIdleMinutes.HasValue; 
        }

    }
}