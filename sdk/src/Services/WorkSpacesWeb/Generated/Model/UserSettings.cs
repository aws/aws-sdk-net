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
 * Do not modify this file. This file is generated from the workspaces-web-2020-07-08.normal.json service model.
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
        private Dictionary<string, string> _additionalEncryptionContext = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<string> _associatedPortalArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private CookieSynchronizationConfiguration _cookieSynchronizationConfiguration;
        private EnabledType _copyAllowed;
        private string _customerManagedKey;
        private EnabledType _deepLinkAllowed;
        private int? _disconnectTimeoutInMinutes;
        private EnabledType _downloadAllowed;
        private int? _idleDisconnectTimeoutInMinutes;
        private EnabledType _pasteAllowed;
        private EnabledType _printAllowed;
        private ToolbarConfiguration _toolbarConfiguration;
        private EnabledType _uploadAllowed;
        private string _userSettingsArn;

        /// <summary>
        /// Gets and sets the property AdditionalEncryptionContext. 
        /// <para>
        /// The additional encryption context of the user settings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> AdditionalEncryptionContext
        {
            get { return this._additionalEncryptionContext; }
            set { this._additionalEncryptionContext = value; }
        }

        // Check to see if AdditionalEncryptionContext property is set
        internal bool IsSetAdditionalEncryptionContext()
        {
            return this._additionalEncryptionContext != null && (this._additionalEncryptionContext.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AssociatedPortalArns. 
        /// <para>
        /// A list of web portal ARNs that this user settings is associated with.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AssociatedPortalArns
        {
            get { return this._associatedPortalArns; }
            set { this._associatedPortalArns = value; }
        }

        // Check to see if AssociatedPortalArns property is set
        internal bool IsSetAssociatedPortalArns()
        {
            return this._associatedPortalArns != null && (this._associatedPortalArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CookieSynchronizationConfiguration. 
        /// <para>
        /// The configuration that specifies which cookies should be synchronized from the end
        /// user's local browser to the remote browser.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public CookieSynchronizationConfiguration CookieSynchronizationConfiguration
        {
            get { return this._cookieSynchronizationConfiguration; }
            set { this._cookieSynchronizationConfiguration = value; }
        }

        // Check to see if CookieSynchronizationConfiguration property is set
        internal bool IsSetCookieSynchronizationConfiguration()
        {
            return this._cookieSynchronizationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property CopyAllowed. 
        /// <para>
        /// Specifies whether the user can copy text from the streaming session to the local device.
        /// </para>
        /// </summary>
        public EnabledType CopyAllowed
        {
            get { return this._copyAllowed; }
            set { this._copyAllowed = value; }
        }

        // Check to see if CopyAllowed property is set
        internal bool IsSetCopyAllowed()
        {
            return this._copyAllowed != null;
        }

        /// <summary>
        /// Gets and sets the property CustomerManagedKey. 
        /// <para>
        /// The customer managed key used to encrypt sensitive information in the user settings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string CustomerManagedKey
        {
            get { return this._customerManagedKey; }
            set { this._customerManagedKey = value; }
        }

        // Check to see if CustomerManagedKey property is set
        internal bool IsSetCustomerManagedKey()
        {
            return this._customerManagedKey != null;
        }

        /// <summary>
        /// Gets and sets the property DeepLinkAllowed. 
        /// <para>
        /// Specifies whether the user can use deep links that open automatically when connecting
        /// to a session.
        /// </para>
        /// </summary>
        public EnabledType DeepLinkAllowed
        {
            get { return this._deepLinkAllowed; }
            set { this._deepLinkAllowed = value; }
        }

        // Check to see if DeepLinkAllowed property is set
        internal bool IsSetDeepLinkAllowed()
        {
            return this._deepLinkAllowed != null;
        }

        /// <summary>
        /// Gets and sets the property DisconnectTimeoutInMinutes. 
        /// <para>
        /// The amount of time that a streaming session remains active after users disconnect.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=600)]
        public int? DisconnectTimeoutInMinutes
        {
            get { return this._disconnectTimeoutInMinutes; }
            set { this._disconnectTimeoutInMinutes = value; }
        }

        // Check to see if DisconnectTimeoutInMinutes property is set
        internal bool IsSetDisconnectTimeoutInMinutes()
        {
            return this._disconnectTimeoutInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DownloadAllowed. 
        /// <para>
        /// Specifies whether the user can download files from the streaming session to the local
        /// device.
        /// </para>
        /// </summary>
        public EnabledType DownloadAllowed
        {
            get { return this._downloadAllowed; }
            set { this._downloadAllowed = value; }
        }

        // Check to see if DownloadAllowed property is set
        internal bool IsSetDownloadAllowed()
        {
            return this._downloadAllowed != null;
        }

        /// <summary>
        /// Gets and sets the property IdleDisconnectTimeoutInMinutes. 
        /// <para>
        /// The amount of time that users can be idle (inactive) before they are disconnected
        /// from their streaming session and the disconnect timeout interval begins.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=60)]
        public int? IdleDisconnectTimeoutInMinutes
        {
            get { return this._idleDisconnectTimeoutInMinutes; }
            set { this._idleDisconnectTimeoutInMinutes = value; }
        }

        // Check to see if IdleDisconnectTimeoutInMinutes property is set
        internal bool IsSetIdleDisconnectTimeoutInMinutes()
        {
            return this._idleDisconnectTimeoutInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PasteAllowed. 
        /// <para>
        /// Specifies whether the user can paste text from the local device to the streaming session.
        /// </para>
        /// </summary>
        public EnabledType PasteAllowed
        {
            get { return this._pasteAllowed; }
            set { this._pasteAllowed = value; }
        }

        // Check to see if PasteAllowed property is set
        internal bool IsSetPasteAllowed()
        {
            return this._pasteAllowed != null;
        }

        /// <summary>
        /// Gets and sets the property PrintAllowed. 
        /// <para>
        /// Specifies whether the user can print to the local device.
        /// </para>
        /// </summary>
        public EnabledType PrintAllowed
        {
            get { return this._printAllowed; }
            set { this._printAllowed = value; }
        }

        // Check to see if PrintAllowed property is set
        internal bool IsSetPrintAllowed()
        {
            return this._printAllowed != null;
        }

        /// <summary>
        /// Gets and sets the property ToolbarConfiguration. 
        /// <para>
        /// The configuration of the toolbar. This allows administrators to select the toolbar
        /// type and visual mode, set maximum display resolution for sessions, and choose which
        /// items are visible to end users during their sessions. If administrators do not modify
        /// these settings, end users retain control over their toolbar preferences.
        /// </para>
        /// </summary>
        public ToolbarConfiguration ToolbarConfiguration
        {
            get { return this._toolbarConfiguration; }
            set { this._toolbarConfiguration = value; }
        }

        // Check to see if ToolbarConfiguration property is set
        internal bool IsSetToolbarConfiguration()
        {
            return this._toolbarConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property UploadAllowed. 
        /// <para>
        /// Specifies whether the user can upload files from the local device to the streaming
        /// session.
        /// </para>
        /// </summary>
        public EnabledType UploadAllowed
        {
            get { return this._uploadAllowed; }
            set { this._uploadAllowed = value; }
        }

        // Check to see if UploadAllowed property is set
        internal bool IsSetUploadAllowed()
        {
            return this._uploadAllowed != null;
        }

        /// <summary>
        /// Gets and sets the property UserSettingsArn. 
        /// <para>
        /// The ARN of the user settings.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string UserSettingsArn
        {
            get { return this._userSettingsArn; }
            set { this._userSettingsArn = value; }
        }

        // Check to see if UserSettingsArn property is set
        internal bool IsSetUserSettingsArn()
        {
            return this._userSettingsArn != null;
        }

    }
}